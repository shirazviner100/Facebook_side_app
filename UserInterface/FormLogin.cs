using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public partial class FormLogin : Form
    {
        public User LoggedInUser
        {
            get;
            private set;
        }

        public LoginResult FormLoginResult
        {
            get;
            private set;
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        public bool RememberMe
        {
            get
            {
                bool v_IfRemember = true;

                v_IfRemember = checkBoxRemember.Checked;

                return v_IfRemember;
            }
        }

        private void loginAndInit()
        {
            FormLoginResult = FacebookService.Login(
            "1753708491446221",
            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "publish_to_groups",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown");

            if (!string.IsNullOrEmpty(FormLoginResult.AccessToken))
            {
                LoggedInUser = FormLoginResult.LoggedInUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(FormLoginResult.ErrorMessage);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}