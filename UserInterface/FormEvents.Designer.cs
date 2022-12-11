namespace UserInterface
{
    partial class FormEvents
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
            System.Windows.Forms.Label attendingCountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label linkToFacebookLabel;
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelEvent = new System.Windows.Forms.Panel();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabelCity = new System.Windows.Forms.Label();
            this.attendingCountLabel1 = new System.Windows.Forms.Label();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelEventsList = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            attendingCountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attendingCountLabel
            // 
            attendingCountLabel.AutoSize = true;
            attendingCountLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            attendingCountLabel.Location = new System.Drawing.Point(34, 249);
            attendingCountLabel.Name = "attendingCountLabel";
            attendingCountLabel.Size = new System.Drawing.Size(136, 21);
            attendingCountLabel.TabIndex = 0;
            attendingCountLabel.Text = "Attending Count:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            descriptionLabel.Location = new System.Drawing.Point(35, 158);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(100, 21);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            endTimeLabel.Location = new System.Drawing.Point(36, 450);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(86, 21);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "End Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel.Location = new System.Drawing.Point(35, 119);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(59, 21);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            startTimeLabel.Location = new System.Drawing.Point(35, 397);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(94, 21);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel2.Location = new System.Drawing.Point(35, 345);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(44, 21);
            nameLabel2.TabIndex = 14;
            nameLabel2.Text = "City:";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            linkToFacebookLabel.Location = new System.Drawing.Point(35, 296);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(144, 21);
            linkToFacebookLabel.TabIndex = 15;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(this.descriptionTextBox);
            this.panelEvent.Controls.Add(linkToFacebookLabel);
            this.panelEvent.Controls.Add(this.linkToFacebookLinkLabel);
            this.panelEvent.Controls.Add(nameLabel2);
            this.panelEvent.Controls.Add(this.nameLabelCity);
            this.panelEvent.Controls.Add(attendingCountLabel);
            this.panelEvent.Controls.Add(this.attendingCountLabel1);
            this.panelEvent.Controls.Add(descriptionLabel);
            this.panelEvent.Controls.Add(endTimeLabel);
            this.panelEvent.Controls.Add(this.endTimeDateTimePicker);
            this.panelEvent.Controls.Add(this.imageNormalPictureBox);
            this.panelEvent.Controls.Add(nameLabel);
            this.panelEvent.Controls.Add(this.nameLabel1);
            this.panelEvent.Controls.Add(startTimeLabel);
            this.panelEvent.Controls.Add(this.startTimeDateTimePicker);
            this.panelEvent.Location = new System.Drawing.Point(423, 88);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(469, 500);
            this.panelEvent.TabIndex = 9;
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(199, 296);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.linkToFacebookLinkLabel.TabIndex = 16;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "linkLabel1";
            // 
            // nameLabelCity
            // 
            this.nameLabelCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Place.Name", true));
            this.nameLabelCity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabelCity.Location = new System.Drawing.Point(200, 343);
            this.nameLabelCity.Name = "nameLabelCity";
            this.nameLabelCity.Size = new System.Drawing.Size(100, 23);
            this.nameLabelCity.TabIndex = 15;
            this.nameLabelCity.Text = "labelCity";
            // 
            // attendingCountLabel1
            // 
            this.attendingCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
            this.attendingCountLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.attendingCountLabel1.Location = new System.Drawing.Point(198, 253);
            this.attendingCountLabel1.Name = "attendingCountLabel1";
            this.attendingCountLabel1.Size = new System.Drawing.Size(200, 23);
            this.attendingCountLabel1.TabIndex = 1;
            this.attendingCountLabel1.Text = "label1";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(202, 450);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endTimeDateTimePicker.TabIndex = 5;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(39, 20);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(182, 77);
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(198, 123);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(200, 23);
            this.nameLabel1.TabIndex = 9;
            this.nameLabel1.Text = "label1";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(203, 397);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startTimeDateTimePicker.TabIndex = 13;
            // 
            // labelEventsList
            // 
            this.labelEventsList.AutoSize = true;
            this.labelEventsList.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsList.Location = new System.Drawing.Point(235, 24);
            this.labelEventsList.Name = "labelEventsList";
            this.labelEventsList.Size = new System.Drawing.Size(439, 40);
            this.labelEventsList.TabIndex = 8;
            this.labelEventsList.Text = "Your Choosen events list:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(42, 88);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(356, 500);
            this.listBoxEvents.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(202, 159);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 78);
            this.descriptionTextBox.TabIndex = 17;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(929, 620);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.labelEventsList);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEvents";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Label labelEventsList;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label nameLabelCity;
        private System.Windows.Forms.Label attendingCountLabel1;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}