namespace CreateDemandeGplusVPlus
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
            this.lblNoDossier = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNoDossier = new System.Windows.Forms.TextBox();
            this.rchTxtResponse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoDossier
            // 
            this.lblNoDossier.AutoSize = true;
            this.lblNoDossier.Location = new System.Drawing.Point(12, 23);
            this.lblNoDossier.Name = "lblNoDossier";
            this.lblNoDossier.Size = new System.Drawing.Size(63, 13);
            this.lblNoDossier.TabIndex = 7;
            this.lblNoDossier.Text = "No dossier: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(219, 74);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(149, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok Creer Demande";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNoDossier
            // 
            this.txtNoDossier.Location = new System.Drawing.Point(12, 39);
            this.txtNoDossier.Name = "txtNoDossier";
            this.txtNoDossier.Size = new System.Drawing.Size(441, 20);
            this.txtNoDossier.TabIndex = 4;
            this.txtNoDossier.Text = "111112";
            // 
            // rchTxtResponse
            // 
            this.rchTxtResponse.Location = new System.Drawing.Point(12, 110);
            this.rchTxtResponse.Name = "rchTxtResponse";
            this.rchTxtResponse.Size = new System.Drawing.Size(438, 277);
            this.rchTxtResponse.TabIndex = 8;
            this.rchTxtResponse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reponse: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchTxtResponse);
            this.Controls.Add(this.lblNoDossier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNoDossier);
            this.Name = "Form1";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoDossier;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNoDossier;
        private System.Windows.Forms.RichTextBox rchTxtResponse;
        private System.Windows.Forms.Label label1;
    }
}

