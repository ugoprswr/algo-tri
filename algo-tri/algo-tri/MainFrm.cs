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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When I clicked on the about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.ShowDialog();
        }

        /// <summary>
        /// When I clicked on the button to download the manual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "manuel.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        /// <summary>
        /// When I clicked on the button for "Tri à bulle"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triÀBulleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriBulle frmTriBulle = new FrmTriBulle();
            frmTriBulle.ShowDialog();
        }

        /// <summary>
        /// When I clicked on the button for "Tri par sélection"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriSelection frmTriSelection = new FrmTriSelection();
            frmTriSelection.ShowDialog();
        }

        /// <summary>
        /// When I clicked on the button for "Tri Shell"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriShell frmTriShell = new FrmTriShell();
            frmTriShell.ShowDialog();
        }

        /// <summary>
        /// When I clicked on the button for "Tri à peigne"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triÀPeigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriPeigne frmTriPeigne = new FrmTriPeigne();
            frmTriPeigne.ShowDialog();
        }

        /// <summary>
        /// When I clicked on the button for "Tri par insertion"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void triParInsertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriInsertion frmTriInsertion = new FrmTriInsertion();
            frmTriInsertion.ShowDialog();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
