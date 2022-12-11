using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public class PanelMen : PanelToUser
    {
        public PanelMen(User i_User) : base(i_User)
        {
        }

        public override void SetColorsDesign()
        {
            this.BackColor = Color.LightSkyBlue;
            UserName.ForeColor = Age.ForeColor = Color.DarkBlue;
        }
    }
}
