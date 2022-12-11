namespace UserInterface
{
    partial class FormMatch
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
            this.buttonBisexual = new System.Windows.Forms.Button();
            this.buttonWomen = new System.Windows.Forms.Button();
            this.buttonMen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAllMatch = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(76, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 48);
            this.label2.TabIndex = 13;
            this.label2.Text = "The matches found for you from your friend\'s list,\r\naccording to the zodiac calcu" +
    "lations are:";
            // 
            // buttonBisexual
            // 
            this.buttonBisexual.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonBisexual.Location = new System.Drawing.Point(549, 158);
            this.buttonBisexual.Name = "buttonBisexual";
            this.buttonBisexual.Size = new System.Drawing.Size(80, 31);
            this.buttonBisexual.TabIndex = 12;
            this.buttonBisexual.Text = "Bisexual";
            this.buttonBisexual.UseVisualStyleBackColor = false;
            this.buttonBisexual.Click += new System.EventHandler(this.buttonBisexual_Click);
            // 
            // buttonWomen
            // 
            this.buttonWomen.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonWomen.Location = new System.Drawing.Point(451, 158);
            this.buttonWomen.Name = "buttonWomen";
            this.buttonWomen.Size = new System.Drawing.Size(80, 31);
            this.buttonWomen.TabIndex = 11;
            this.buttonWomen.Text = "Women";
            this.buttonWomen.UseVisualStyleBackColor = false;
            this.buttonWomen.Click += new System.EventHandler(this.buttonWomen_Click);
            // 
            // buttonMen
            // 
            this.buttonMen.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonMen.Location = new System.Drawing.Point(355, 158);
            this.buttonMen.Name = "buttonMen";
            this.buttonMen.Size = new System.Drawing.Size(80, 31);
            this.buttonMen.TabIndex = 10;
            this.buttonMen.Text = "Men";
            this.buttonMen.UseVisualStyleBackColor = false;
            this.buttonMen.Click += new System.EventHandler(this.buttonMen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(76, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "What is your sexual orientation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAllMatch
            // 
            this.panelAllMatch.AutoScroll = true;
            this.panelAllMatch.Location = new System.Drawing.Point(38, 300);
            this.panelAllMatch.Name = "panelAllMatch";
            this.panelAllMatch.Size = new System.Drawing.Size(666, 325);
            this.panelAllMatch.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle.Location = new System.Drawing.Point(123, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(477, 92);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Matching relationships\r\nAccording to zodic signs";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFindMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(730, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBisexual);
            this.Controls.Add(this.buttonWomen);
            this.Controls.Add(this.buttonMen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAllMatch);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFindMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFindMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBisexual;
        private System.Windows.Forms.Button buttonWomen;
        private System.Windows.Forms.Button buttonMen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAllMatch;
        private System.Windows.Forms.Label labelTitle;
    }
}