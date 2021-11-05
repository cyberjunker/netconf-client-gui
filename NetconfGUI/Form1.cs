using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NetconfGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                DirectoryInfo d = new DirectoryInfo(@"./XML");
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files

                comboBoxFile.DataSource = Files;
                comboBoxFile.DisplayMember = "Name";
            }
            catch (Exception ex)
            {

            }
            textBoxIPAddr.Text = ConfigurationManager.AppSettings.Get("IPAddress");
            textBoxPort.Text = ConfigurationManager.AppSettings.Get("Port");
            textBoxUser.Text = ConfigurationManager.AppSettings.Get("User");
            textBoxPass.Text = ConfigurationManager.AppSettings.Get("Pass");

        }

        private void ConvertXmlNodeToTreeNode(XmlNode xmlNode,
      TreeNodeCollection treeNodes)
        {

            TreeNode newTreeNode = treeNodes.Add(xmlNode.Name);

            switch (xmlNode.NodeType)
            {
                case XmlNodeType.ProcessingInstruction:
                case XmlNodeType.XmlDeclaration:
                    newTreeNode.Text = "<?" + xmlNode.Name + " " +
                      xmlNode.Value + "?>";
                    break;
                case XmlNodeType.Element:
                    newTreeNode.Text = "<" + xmlNode.Name + ">";
                    break;
                case XmlNodeType.Attribute:
                    newTreeNode.Text = "ATTRIBUTE: " + xmlNode.Name;
                    break;
                case XmlNodeType.Text:
                case XmlNodeType.CDATA:
                    newTreeNode.Text = xmlNode.Value;
                    break;
                case XmlNodeType.Comment:
                    newTreeNode.Text = "<!--" + xmlNode.Value + "-->";
                    break;
            }

            if (xmlNode.Attributes != null)
            {
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    ConvertXmlNodeToTreeNode(attribute, newTreeNode.Nodes);
                }
            }
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                ConvertXmlNodeToTreeNode(childNode, newTreeNode.Nodes);
            }
        }

        private void buttonGenericQuery_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["IPAddress"].Value = textBoxIPAddr.Text;
            config.AppSettings.Settings["Port"].Value = textBoxPort.Text;
            config.AppSettings.Settings["User"].Value = textBoxUser.Text;
            config.AppSettings.Settings["Pass"].Value = textBoxPass.Text;
            config.Save(ConfigurationSaveMode.Modified);

            try
            {
                RunNetconfQuery();
            }
            catch (Exception ex)
            {
                treeView1.Nodes.Clear();
                TreeNode rootNode = new TreeNode();
                rootNode.Text = "ERROR: " + ex.ToString();
                treeView1.Nodes.Add(rootNode);
            }

        }

        private void RunNetconfQuery()
        {
            Renci.SshNet.NetConfClient nc = new NetConfClient(textBoxIPAddr.Text, Int16.Parse(textBoxPort.Text), textBoxUser.Text, textBoxPass.Text);
            nc.Connect();
            //var x = nc.ServerCapabilities;
            string xml = richTextBoxQuery.Text;
            var ret = nc.SendReceiveRpc(xml);
            System.Diagnostics.Trace.WriteLine(ret.OuterXml);

            treeView1.Nodes.Clear();
            ConvertXmlNodeToTreeNode(ret, treeView1.Nodes);
            treeView1.Nodes[0].ExpandAll();
        }

        private void comboBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            FileInfo file = (FileInfo)cmb.SelectedValue;

            System.Diagnostics.Trace.WriteLine(file.FullName);
            
            string text = System.IO.File.ReadAllText(file.FullName);
            richTextBoxQuery.Text = text;
        }
    }
}
