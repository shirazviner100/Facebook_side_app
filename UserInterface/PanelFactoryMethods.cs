using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UserInterface
{
    public static class PanelFactoryMethods
    {
        public static Panel CreatePanel(eGender i_Context, User i_User)
        {
            Panel panelToReturn;

            switch (i_Context)
            {
                case eGender.PanelMen:
                    panelToReturn = new PanelMen(i_User);
                    break;

                case eGender.PanelWomen:
                    panelToReturn = new PanelWomen(i_User);
                    break;

                case eGender.PanelBsexual:
                    panelToReturn = new PanelBisexual(i_User);
                    break;

                default:
                    panelToReturn = null;
                    break;
            }

            return panelToReturn;
        }
    }
}
