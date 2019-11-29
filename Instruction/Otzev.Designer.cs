namespace Instruction
{
    partial class Otzev
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btOtpravka = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.tbOtKovo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Тема: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "От кого: ";
            // 
            // btOtpravka
            // 
            this.btOtpravka.Location = new System.Drawing.Point(363, 17);
            this.btOtpravka.Name = "btOtpravka";
            this.btOtpravka.Size = new System.Drawing.Size(183, 39);
            this.btOtpravka.TabIndex = 32;
            this.btOtpravka.Text = "Отправить";
            this.btOtpravka.UseVisualStyleBackColor = true;
            this.btOtpravka.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(33, 90);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(560, 264);
            this.tbText.TabIndex = 31;
            // 
            // tbTema
            // 
            this.tbTema.Location = new System.Drawing.Point(68, 53);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(233, 20);
            this.tbTema.TabIndex = 30;
            // 
            // tbOtKovo
            // 
            this.tbOtKovo.Location = new System.Drawing.Point(68, 10);
            this.tbOtKovo.Name = "tbOtKovo";
            this.tbOtKovo.Size = new System.Drawing.Size(233, 20);
            this.tbOtKovo.TabIndex = 29;
            // 
            // Otzev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOtpravka);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbTema);
            this.Controls.Add(this.tbOtKovo);
            this.Name = "Otzev";
            this.Text = "Отзев";
            this.Load += new System.EventHandler(this.Otzev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOtpravka;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.TextBox tbOtKovo;
    }
}