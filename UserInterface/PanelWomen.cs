using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public class PanelWomen : PanelToUser
    {
        public PanelWomen(User i_User) : base(i_User)
        {
        }

        public override void SetColorsDesign()
        {
            this.BackColor = Color.LightPink;
            UserName.ForeColor = Age.ForeColor = Color.MediumVioletRed;
        }
    }
}