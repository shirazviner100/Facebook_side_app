using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public partial class FormEvents : Form
    {
        public FormEvents()
        {
            InitializeComponent();
        }

        public void SetDataOnList(List<Event> i_ApprovedEvents)
        {
            eventBindingSource.DataSource = i_ApprovedEvents;
            this.ShowDialog();
        }
    }
}