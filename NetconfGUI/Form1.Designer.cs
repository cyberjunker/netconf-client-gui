
namespace NetconfGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIPAddr = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBoxQuery = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGenericQuery = new System.Windows.Forms.Button();
            this.comboBoxFile = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIPAddr
            // 
            this.textBoxIPAddr.Location = new System.Drawing.Point(32, 36);
            this.textBoxIPAddr.Name = "textBoxIPAddr";
            this.textBoxIPAddr.Size = new System.Drawing.Size(245, 23);
            this.textBoxIPAddr.TabIndex = 1;
            this.textBoxIPAddr.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(348, 36);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 23);
            this.textBoxPort.TabIndex = 2;
            this.textBoxPort.Text = "2022";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(488, 36);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 23);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Text = "admin";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(625, 36);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(100, 23);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(503, 170);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(637, 385);
            this.treeView1.TabIndex = 9;
            // 
            // richTextBoxQuery
            // 
            this.richTextBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxQuery.Location = new System.Drawing.Point(32, 170);
            this.richTextBoxQuery.Name = "richTextBoxQuery";
            this.richTextBoxQuery.Size = new System.Drawing.Size(403, 385);
            this.richTextBoxQuery.TabIndex = 10;
            this.richTextBoxQuery.Text = "<rpc xmlns=\"urn:ietf:params:xml:ns:netconf:base:1.0\" message-id=\"1\">\n<get>\n<filte" +
    "r>\n<testserver xmlns=\"\" >\n<servers/>\n</testserver>\n</filter>\n</get>\n</rpc>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "RPC Reply:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "RPC Query:";
            // 
            // buttonGenericQuery
            // 
            this.buttonGenericQuery.Location = new System.Drawing.Point(441, 170);
            this.buttonGenericQuery.Name = "buttonGenericQuery";
            this.buttonGenericQuery.Size = new System.Drawing.Size(56, 31);
            this.buttonGenericQuery.TabIndex = 13;
            this.buttonGenericQuery.Text = "Run";
            this.buttonGenericQuery.UseVisualStyleBackColor = true;
            this.buttonGenericQuery.Click += new System.EventHandler(this.buttonGenericQuery_Click);
            // 
            // comboBoxFile
            // 
            this.comboBoxFile.FormattingEnabled = true;
            this.comboBoxFile.Location = new System.Drawing.Point(32, 101);
            this.comboBoxFile.Name = "comboBoxFile";
            this.comboBoxFile.Size = new System.Drawing.Size(403, 23);
            this.comboBoxFile.TabIndex = 14;
            this.comboBoxFile.SelectedIndexChanged += new System.EventHandler(this.comboBoxFile_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "XML files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxFile);
            this.Controls.Add(this.buttonGenericQuery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxQuery);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIPAddr);
            this.Name = "Form1";
            this.Text = "Netconf client GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIPAddr;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBoxQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGenericQuery;
        private System.Windows.Forms.ComboBox comboBoxFile;
        private System.Windows.Forms.Label label7;
    }
}

