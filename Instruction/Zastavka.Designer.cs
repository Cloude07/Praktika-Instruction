namespace Instruction
{
    partial class Zastavka
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picBoxLoad = new System.Windows.Forms.PictureBox();
            this.lbLoad = new System.Windows.Forms.Label();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picBoxLoad
            // 
            this.picBoxLoad.Image = global::Instruction.Properties.Resources.EducatedBouncyHawk_small;
            this.picBoxLoad.InitialImage = global::Instruction.Properties.Resources.EducatedBouncyHawk_small;
            this.picBoxLoad.Location = new System.Drawing.Point(201, 34);
            this.picBoxLoad.Name = "picBoxLoad";
            this.picBoxLoad.Size = new System.Drawing.Size(189, 144);
            this.picBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLoad.TabIndex = 0;
            this.picBoxLoad.TabStop = false;
            // 
            // lbLoad
            // 
            this.lbLoad.AutoSize = true;
            this.lbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLoad.Location = new System.Drawing.Point(79, 208);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(70, 16);
            this.lbLoad.TabIndex = 1;
            this.lbLoad.Text = "Загрузка";
            // 
            // pbLoad
            // 
            this.pbLoad.Location = new System.Drawing.Point(82, 227);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(395, 23);
            this.pbLoad.TabIndex = 2;
            // 
            // Zastavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 262);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.picBoxLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zastavka";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zastavka";
            this.Load += new System.EventHandler(this.Zastavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picBoxLoad;
        private System.Windows.Forms.Label lbLoad;
        private System.Windows.Forms.ProgressBar pbLoad;
    }
}