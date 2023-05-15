using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algo_tri
{
    public partial class FrmTriInsertion : Form
    {
        public FrmTriInsertion()
        {
            InitializeComponent();
        }

        private void txbPseudoCodeTriInsertion_TextChanged(object sender, EventArgs e)
        {
            txbPseudoCodeTriInsertion.Text = "";
        }
    }
}
