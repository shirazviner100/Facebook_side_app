using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UserInterface
{
    public partial class FormMatch : Form
    {
        private readonly FacadeMatch r_FacadeToFormMatch;
        private User m_LoggedInUser;

        public FormMatch(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            r_FacadeToFormMatch = new FacadeMatch(i_LoggedInUser);
            InitializeComponent();
        }

        private void fetchMatch(eGender i_PanelChoice)
        {
            try
            {
                int lineCounter = 0, top = 10, left = 40;
                r_FacadeToFormMatch.Gender = i_PanelChoice;
                foreach(User fb_Friend in r_FacadeToFormMatch)
                {
                    Panel userPanel = PanelFactoryMethods.CreatePanel(i_PanelChoice, fb_Friend);
                    userPanel.Left = left;
                    userPanel.Top = top;
                    left = userPanel.Right + 30;
                    panelAllMatch.Controls.Add(userPanel);
                    lineCounter++;
                    if (lineCounter % 2 == 0)
                    {
                        left = 30;
                        top = userPanel.Bottom + 10;
                    }
                }
               
                if(lineCounter == 0)
                {
                    MessageBox.Show("Sorry, no Match found!");
                }
            }
            catch(ArgumentException i_Exception)
            {
                MessageBox.Show(i_Exception.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Match Error!!!");
            }
        }

        private void buttonMen_Click(object sender, EventArgs e)
        {
            panelAllMatch.Controls.Clear();
            fetchMatch(eGender.PanelMen);
        }

        private void buttonWomen_Click(object sender, EventArgs e)
        {
            panelAllMatch.Controls.Clear();
            fetchMatch(eGender.PanelWomen);
        }

        private void buttonBisexual_Click(object sender, EventArgs e)
        {
            panelAllMatch.Controls.Clear();
            fetchMatch(eGender.PanelBsexual);
        }
    }
}