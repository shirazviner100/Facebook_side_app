using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public partial class FormFriends : Form
    {
        private User m_LoggedInUser;

        public FormFriends(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchFriendsList();
        }

        private void fetchFriendsList()
        {
            try
            {
                userBindingSource.DataSource = m_LoggedInUser.Friends;
                if (m_LoggedInUser.Friends.Count == 0)
                {
                    MessageBox.Show("No Friends to show");
                }
            }
            catch (Exception)
            {
                listBoxFriends.Items.Add("Friends - Permission error !!!!");
            }
        }
    }
}