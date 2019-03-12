namespace ei_si_worksheet3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDataToEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEncryptedData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDecryptedData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(11, 180);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(340, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = " Encrypt File to \"c:\\temp\\temp.dat\"   (not data in textbox above)";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(12, 12);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(163, 23);
            this.buttonChooseFile.TabIndex = 3;
            this.buttonChooseFile.Text = "Choose File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.ButtonChooseFile_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(12, 321);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(339, 23);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Decrypt File (\"c:\\temp\\temp.dat\") to Textbox bellow";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // textBoxDataToEncrypt
            // 
            this.textBoxDataToEncrypt.Location = new System.Drawing.Point(12, 64);
            this.textBoxDataToEncrypt.Multiline = true;
            this.textBoxDataToEncrypt.Name = "textBoxDataToEncrypt";
            this.textBoxDataToEncrypt.Size = new System.Drawing.Size(568, 96);
            this.textBoxDataToEncrypt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First 200 bytes to encrypt";
            // 
            // textBoxEncryptedData
            // 
            this.textBoxEncryptedData.Location = new System.Drawing.Point(12, 222);
            this.textBoxEncryptedData.Multiline = true;
            this.textBoxEncryptedData.Name = "textBoxEncryptedData";
            this.textBoxEncryptedData.Size = new System.Drawing.Size(568, 78);
            this.textBoxEncryptedData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First 100 encrypted bytes";
            // 
            // textBoxDecryptedData
            // 
            this.textBoxDecryptedData.Location = new System.Drawing.Point(11, 364);
            this.textBoxDecryptedData.Multiline = true;
            this.textBoxDecryptedData.Name = "textBoxDecryptedData";
            this.textBoxDecryptedData.Size = new System.Drawing.Size(568, 103);
            this.textBoxDecryptedData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First 200 decrypted bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDecryptedData);
            this.Controls.Add(this.textBoxEncryptedData);
            this.Controls.Add(this.textBoxDataToEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.buttonEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Symmetric Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxDataToEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEncryptedData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDecryptedData;
        private System.Windows.Forms.Label label3;
    }
}

