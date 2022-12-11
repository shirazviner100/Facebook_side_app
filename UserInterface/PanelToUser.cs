using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public class PanelToUser : Panel
    {
        public PictureBox UserPicture
        {
            get; set;
        }

        public Label UserName
        {
            get; set;
        }

        public Label Age
        {
            get; set;
        }

        public LinkLabel FacebookLink
        {
            get; set;
        }

        public User PanelUser
        {
            get; set;
        }

        public PanelToUser(User i_User)
        {
            PanelUser = i_User;
            initializeComponent();
        }

        private void initializeComponent()
        {
            int top = 8;
            UserPicture = new PictureBox();
            UserName = new Label();
            Age = new Label();
            FacebookLink = new LinkLabel();

            this.Size = new System.Drawing.Size(160, 160);
            UserPicture.Size = new System.Drawing.Size(80, 80);
            UserPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPicture.Left = 8;
            UserPicture.Top = top;
            top = UserPicture.Bottom + 8;
            UserName.Left = 8;
            UserName.Top = top;
            UserName.Size = new System.Drawing.Size(140, 15);
            top = UserName.Bottom + 3;
            Age.Left = 8;
            Age.Top = top;
            Age.Size = new System.Drawing.Size(140, 15);
            top = Age.Bottom + 3;
            FacebookLink.Left = 8;
            FacebookLink.Top = top;
            FacebookLink.Size = new System.Drawing.Size(140, 15);

            this.Controls.Add(UserPicture);
            this.Controls.Add(UserName);
            this.Controls.Add(Age);
            this.Controls.Add(FacebookLink);
            SetColorsDesign();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                DateTime friendBirthday = DateTime.ParseExact(PanelUser.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                UserPicture.Load(PanelUser.PictureNormalURL);
                UserName.Text = string.Format("Name: {0}", PanelUser.Name);
                Age.Text = string.Format("Age: {0}", DateTime.Now.Year - friendBirthday.Year);
                FacebookLink.Text = PanelUser.Link;
                base.OnPaint(e);
            }
            catch (Exception)
            {
                UserName.ForeColor = Color.White;
                UserName.Size = new System.Drawing.Size(160, 50);
                UserName.Text = "Fcaebook server unaccessible";
            }
        }

        public virtual void SetColorsDesign()
        {
            this.BackColor = Color.Tan;
            UserName.ForeColor = Age.ForeColor = Color.SeaGreen;
        }
    }
}