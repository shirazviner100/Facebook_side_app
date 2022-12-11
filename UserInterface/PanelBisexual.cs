using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public class PanelBisexual : PanelToUser
    {
        public PanelBisexual(User i_User) : base(i_User)
        {
        }

        public override void SetColorsDesign()
        {
            this.BackColor = Color.DeepPink;
            UserName.ForeColor = Age.ForeColor = Color.PowderBlue;
        }
    }
}
