using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UserInterface
{
    public partial class FormEventComposer : Form
    {
        private int m_MaxAttending;
        private int m_MinAttending;
        private EventsBuilder m_EventBuilder;
        private User m_LoggedInUser;

        public FormEventComposer(User i_LoggedInUser)
        {
            InitializeComponent();
            dateTimePickerStart.Value = DateTime.Now;
            m_LoggedInUser = i_LoggedInUser;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if(DialogResult == DialogResult.OK)
            {
                m_EventBuilder = new EventsBuilder(m_LoggedInUser, m_MaxAttending, m_MinAttending, StartingAt);
            }
        }

        public int MaxAttending
        {
            get
            {
                return m_MaxAttending;
            }
        }

        public int MinAttending
        {
            get
            {
                return m_MinAttending;
            }
        }

        public DateTime StartingAt
        {
            get
            {
                return dateTimePickerStart.Value;
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaxAttending.Text))
            {
                MessageBox.Show("It is mandatory to specify the maximum number of people you agree to see at the event");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                if (!int.TryParse(textBoxMaxAttending.Text, out m_MaxAttending))
                {
                    MessageBox.Show("The maximum number of people must be an integer");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

            if (string.IsNullOrEmpty(textBoxMinAttending.Text))
            {
                m_MinAttending = -1;
            }
            else
            {
                if (!int.TryParse(textBoxMinAttending.Text, out m_MinAttending))
                {
                    MessageBox.Show("The minimum number of people must be an integer");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxMinAttending_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMaxAttending_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
