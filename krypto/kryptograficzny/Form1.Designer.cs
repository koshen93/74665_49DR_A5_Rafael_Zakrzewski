
namespace kryptograficzny
{
    partial class Kryptacz
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnCreateAsmKeys = new System.Windows.Forms.Button();
            this.btnExportPublicKey = new System.Windows.Forms.Button();
            this.btnImportPublicKey = new System.Windows.Forms.Button();
            this.btnGetPrivateKey = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(12, 12);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptFile.TabIndex = 0;
            this.btnEncryptFile.Text = "Encrypt File";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(12, 41);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptFile.TabIndex = 1;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnCreateAsmKeys
            // 
            this.btnCreateAsmKeys.Location = new System.Drawing.Point(12, 70);
            this.btnCreateAsmKeys.Name = "btnCreateAsmKeys";
            this.btnCreateAsmKeys.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAsmKeys.TabIndex = 2;
            this.btnCreateAsmKeys.Text = "Create Keys";
            this.btnCreateAsmKeys.UseVisualStyleBackColor = true;
            this.btnCreateAsmKeys.Click += new System.EventHandler(this.btnCreateAsmKeys_Click);
            // 
            // btnExportPublicKey
            // 
            this.btnExportPublicKey.Location = new System.Drawing.Point(12, 99);
            this.btnExportPublicKey.Name = "btnExportPublicKey";
            this.btnExportPublicKey.Size = new System.Drawing.Size(75, 23);
            this.btnExportPublicKey.TabIndex = 3;
            this.btnExportPublicKey.Text = "Export Public Key";
            this.btnExportPublicKey.UseVisualStyleBackColor = true;
            this.btnExportPublicKey.Click += new System.EventHandler(this.btnExportPublicKey_Click);
            // 
            // btnImportPublicKey
            // 
            this.btnImportPublicKey.Location = new System.Drawing.Point(12, 128);
            this.btnImportPublicKey.Name = "btnImportPublicKey";
            this.btnImportPublicKey.Size = new System.Drawing.Size(75, 23);
            this.btnImportPublicKey.TabIndex = 4;
            this.btnImportPublicKey.Text = "Import Public Key";
            this.btnImportPublicKey.UseVisualStyleBackColor = true;
            this.btnImportPublicKey.Click += new System.EventHandler(this.btnImportPublicKey_Click);
            // 
            // btnGetPrivateKey
            // 
            this.btnGetPrivateKey.Location = new System.Drawing.Point(12, 157);
            this.btnGetPrivateKey.Name = "btnGetPrivateKey";
            this.btnGetPrivateKey.Size = new System.Drawing.Size(75, 23);
            this.btnGetPrivateKey.TabIndex = 5;
            this.btnGetPrivateKey.Text = "Get Private Key";
            this.btnGetPrivateKey.UseVisualStyleBackColor = true;
            this.btnGetPrivateKey.Click += new System.EventHandler(this.btnGetPrivateKey_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kryptacz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetPrivateKey);
            this.Controls.Add(this.btnImportPublicKey);
            this.Controls.Add(this.btnExportPublicKey);
            this.Controls.Add(this.btnCreateAsmKeys);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Name = "Kryptacz";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnCreateAsmKeys;
        private System.Windows.Forms.Button btnExportPublicKey;
        private System.Windows.Forms.Button btnImportPublicKey;
        private System.Windows.Forms.Button btnGetPrivateKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
    }
}

