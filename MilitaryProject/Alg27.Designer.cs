namespace MilitaryProject
{
    partial class Alg27
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
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_boxN = new System.Windows.Forms.TextBox();
            this.Txt_Boxf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_BoxL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BoxM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 45);
            this.button1.TabIndex = 385;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_boxN
            // 
            this.Txt_boxN.Location = new System.Drawing.Point(163, 220);
            this.Txt_boxN.Name = "Txt_boxN";
            this.Txt_boxN.Size = new System.Drawing.Size(69, 20);
            this.Txt_boxN.TabIndex = 384;
            // 
            // Txt_Boxf
            // 
            this.Txt_Boxf.Location = new System.Drawing.Point(163, 178);
            this.Txt_Boxf.Name = "Txt_Boxf";
            this.Txt_Boxf.Size = new System.Drawing.Size(69, 20);
            this.Txt_Boxf.TabIndex = 383;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 382;
            this.label9.Text = "Результати:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 381;
            this.label6.Text = "Необхідні показники";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(115, 220);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(23, 22);
            this.label5.TabIndex = 379;
            this.label5.Text = "N";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label23.Location = new System.Drawing.Point(115, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 22);
            this.label23.TabIndex = 378;
            this.label23.Text = "f";
            // 
            // txt_BoxL
            // 
            this.txt_BoxL.Location = new System.Drawing.Point(163, 266);
            this.txt_BoxL.Name = "txt_BoxL";
            this.txt_BoxL.Size = new System.Drawing.Size(69, 20);
            this.txt_BoxL.TabIndex = 393;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(115, 266);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(23, 22);
            this.label3.TabIndex = 392;
            this.label3.Text = "L";
            // 
            // txt_BoxM
            // 
            this.txt_BoxM.Location = new System.Drawing.Point(466, 198);
            this.txt_BoxM.Name = "txt_BoxM";
            this.txt_BoxM.Size = new System.Drawing.Size(69, 20);
            this.txt_BoxM.TabIndex = 395;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(418, 198);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 394;
            this.label4.Text = "M";
            // 
            // Alg27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 431);
            this.Controls.Add(this.txt_BoxM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_BoxL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_boxN);
            this.Controls.Add(this.Txt_Boxf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label23);
            this.Name = "Alg27";
            this.Text = "Ураження підрозділів похідної охорони противника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_boxN;
        private System.Windows.Forms.TextBox Txt_Boxf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_BoxL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BoxM;
        private System.Windows.Forms.Label label4;
    }
}