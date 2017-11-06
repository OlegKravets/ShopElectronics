using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();

            grid.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            User.ViewUsers(grid);
        }

        private void ViewUsers_SizeChanged(object sender, EventArgs e)
        {
            this.Login.Width = (grid.Size.Width / 3) - 10;
            this.Password.Width = (grid.Size.Width / 3) - 10;
            this.Admin.Width = (grid.Size.Width / 3) - 10;
        }
    }
}
