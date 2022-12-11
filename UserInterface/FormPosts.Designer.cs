namespace UserInterface
{
    partial class FormPosts
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
            this.labelPostLists = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxNoFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxLastYear = new System.Windows.Forms.CheckBox();
            this.checkBoxByLenth = new System.Windows.Forms.CheckBox();
            this.checkBoxLikes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelPostLists
            // 
            this.labelPostLists.AutoSize = true;
            this.labelPostLists.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostLists.Location = new System.Drawing.Point(298, 39);
            this.labelPostLists.Name = "labelPostLists";
            this.labelPostLists.Size = new System.Drawing.Size(247, 52);
            this.labelPostLists.TabIndex = 7;
            this.labelPostLists.Text = "Posts List:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(264, 111);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(320, 404);
            this.listBoxPosts.TabIndex = 6;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(32, 111);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(179, 68);
            this.labelFilter.TabIndex = 8;
            this.labelFilter.Text = "Filter posts \r\n     list by:";
            // 
            // checkBoxNoFilter
            // 
            this.checkBoxNoFilter.AutoSize = true;
            this.checkBoxNoFilter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxNoFilter.Location = new System.Drawing.Point(23, 207);
            this.checkBoxNoFilter.Name = "checkBoxNoFilter";
            this.checkBoxNoFilter.Size = new System.Drawing.Size(110, 25);
            this.checkBoxNoFilter.TabIndex = 9;
            this.checkBoxNoFilter.Text = "Show all ";
            this.checkBoxNoFilter.UseVisualStyleBackColor = true;
            this.checkBoxNoFilter.CheckedChanged += new System.EventHandler(this.checkBoxNoFilter_CheckedChanged);
            // 
            // checkBoxLastYear
            // 
            this.checkBoxLastYear.AutoSize = true;
            this.checkBoxLastYear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxLastYear.Location = new System.Drawing.Point(23, 250);
            this.checkBoxLastYear.Name = "checkBoxLastYear";
            this.checkBoxLastYear.Size = new System.Drawing.Size(149, 46);
            this.checkBoxLastYear.TabIndex = 10;
            this.checkBoxLastYear.Text = "Show the last\r\nthree years";
            this.checkBoxLastYear.UseVisualStyleBackColor = true;
            this.checkBoxLastYear.CheckedChanged += new System.EventHandler(this.checkBoxLastYear_CheckedChanged);
            // 
            // checkBoxByLenth
            // 
            this.checkBoxByLenth.AutoSize = true;
            this.checkBoxByLenth.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxByLenth.Location = new System.Drawing.Point(23, 313);
            this.checkBoxByLenth.Name = "checkBoxByLenth";
            this.checkBoxByLenth.Size = new System.Drawing.Size(155, 67);
            this.checkBoxByLenth.TabIndex = 11;
            this.checkBoxByLenth.Text = "Show by lenth\r\n(less than 100\r\ncharacters)";
            this.checkBoxByLenth.UseVisualStyleBackColor = true;
            this.checkBoxByLenth.CheckedChanged += new System.EventHandler(this.checkBoxByLenth_CheckedChanged);
            // 
            // checkBoxLikes
            // 
            this.checkBoxLikes.AutoSize = true;
            this.checkBoxLikes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxLikes.Location = new System.Drawing.Point(23, 401);
            this.checkBoxLikes.Name = "checkBoxLikes";
            this.checkBoxLikes.Size = new System.Drawing.Size(207, 46);
            this.checkBoxLikes.TabIndex = 12;
            this.checkBoxLikes.Text = "Show by Likes\r\n(more than 80 likes)";
            this.checkBoxLikes.UseVisualStyleBackColor = true;
            this.checkBoxLikes.CheckedChanged += new System.EventHandler(this.checkBoxLikes_CheckedChanged);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(643, 569);
            this.Controls.Add(this.checkBoxLikes);
            this.Controls.Add(this.checkBoxByLenth);
            this.Controls.Add(this.checkBoxLastYear);
            this.Controls.Add(this.checkBoxNoFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelPostLists);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPosts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostLists;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.CheckBox checkBoxNoFilter;
        private System.Windows.Forms.CheckBox checkBoxLastYear;
        private System.Windows.Forms.CheckBox checkBoxByLenth;
        private System.Windows.Forms.CheckBox checkBoxLikes;
    }
}