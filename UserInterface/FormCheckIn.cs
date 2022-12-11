using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace UserInterface
{
    public partial class FormCheckIn : Form , IObserverCoronaSick
    {
        private User m_LoggedInUser;
        private SmartPictureBox m_SmartPictureBoxPostNotifier;

        public FormCheckIn(User i_User = null)
        {
            m_LoggedInUser = i_User;
            InitializeComponent();
        }

        private void signToNotifier()
        {
            m_SmartPictureBoxPostNotifier.CoronaSick += new Action(UpdateCoronaSick);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchCheckins).Start();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            labelCoronaList.Invoke(new Action(() => labelCoronaList.Visible = false));
        }

        public SmartPictureBox UpdateNotifier
        {
            set
            {
                m_SmartPictureBoxPostNotifier = value;
                signToNotifier();
            }
        }

        private void fetchCheckins()
        {
            try
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Clear()));
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.DisplayMember = "Name"));
                if (m_LoggedInUser.Checkins.Count == 0)
                {
                    listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("No Checkins to show.")));
                }
                else
                {
                    if (listBoxCheckins.ForeColor == Color.Red)
                    {
                        labelCoronaList.Invoke(new Action(() => labelCoronaList.Visible = true));
                        foreach (Checkin checkin in m_LoggedInUser.Checkins)
                        {
                            if (checkin.CreatedTime.Value.Month >= (DateTime.Now.Month - 1)
                                && checkin.CreatedTime.Value.Year == DateTime.Now.Year)
                            {
                                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place)));
                            }
                        }

                        if(listBoxCheckins.Items.Count == 0)
                        {
                            listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("No Checkins in the last month.")));
                        }
                    }
                    else
                    {
                        foreach (Checkin checkin in m_LoggedInUser.Checkins)
                        {
                            listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place)));
                        }
                    }
                    
                }
            }
            catch (Exception)
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add("Checkins list - Permission error !!!!")));
            }
        }

        public ListBox ListBoxCheckins
        {
            get
            {
                return listBoxCheckins;
            }
        }

        public void UpdateCoronaSick()
        {
            this.ListBoxCheckins.ForeColor = Color.Red;
        }
    }
}