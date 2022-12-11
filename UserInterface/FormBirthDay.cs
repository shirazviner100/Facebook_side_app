using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public partial class FormBirthDay : Form
    {
        private User m_LoggedInUser;

        public FormBirthDay(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchBirthdays).Start();
        }

        private void fetchBirthdays()
        {
            try
            {
                DateTime today = DateTime.Now;
                listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Clear()));
                listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.DisplayMember = "Name"));
                if (m_LoggedInUser.Friends.Count > 0)
                {
                    foreach (User friend in m_LoggedInUser.Friends)
                    {
                        if (DateTime.Parse(friend.Birthday) == today)
                        {
                            listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Add(friend)));
                        }
                    }

                    if (listBoxBirthdays.Items.Count == 0)
                    {
                        listBoxBirthdays.Invoke(new Action(() =>
                        listBoxBirthdays.Items.Add("None of your friends have a birthday today")));
                    }
                }
                else
                {
                    listBoxBirthdays.Items.Add("The friends list is empty");
                }
            }
            catch (Exception)
            {
                listBoxBirthdays.Invoke(new Action(() =>
                     listBoxBirthdays.Items.Add("Birthday  - Permission error !!!!")));
            }
        }
    }
}