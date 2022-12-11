namespace UserInterface
{
    partial class FormBirthDay
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
            this.labelAlbumList = new System.Windows.Forms.Label();
            this.listBoxBirthdays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelAlbumList
            // 
            this.labelAlbumList.AutoSize = true;
            this.labelAlbumList.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumList.Location = new System.Drawing.Point(40, 41);
            this.labelAlbumList.Name = "labelAlbumList";
            this.labelAlbumList.Size = new System.Drawing.Size(471, 51);
            this.labelAlbumList.TabIndex = 7;
            this.labelAlbumList.Text = "Friends Birthday List:";
            // 
            // listBoxBirthdays
            // 
            this.listBoxBirthdays.FormattingEnabled = true;
            this.listBoxBirthdays.HorizontalScrollbar = true;
            this.listBoxBirthdays.ItemHeight = 20;
            this.listBoxBirthdays.Location = new System.Drawing.Point(73, 134);
            this.listBoxBirthdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxBirthdays.Name = "listBoxBirthdays";
            this.listBoxBirthdays.Size = new System.Drawing.Size(373, 524);
            this.listBoxBirthdays.TabIndex = 6;
            // 
            // FormBirthDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(520, 715);
            this.Controls.Add(this.labelAlbumList);
            this.Controls.Add(this.listBoxBirthdays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBirthDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbumList;
        private System.Windows.Forms.ListBox listBoxBirthdays;
    }
}