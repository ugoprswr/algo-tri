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
    public partial class FrmAide : Form
    {
        public FrmAide()
        {
            InitializeComponent();
        }

        private void FrmAide_Load(object sender, EventArgs e)
        {
            lblAide.Text = "Découvrez les algorithmes de tri !\r\n\r\nLes algorithmes de tri sont des méthodes permettant d'organiser et d'ordonner des données de manière spécifique. Ils sont essentiels en informatique pour faciliter les opérations sur les données.\r\n\r\nDans cet application, nous explorerons les algorithmes les plus courants tels que le tri par insertion, le tri à bulles, le tri par sélection, le tri Shell et le tri à peigne. Vous apprendrez comment les mettre en œuvre en utilisant C#.\r\n\r\nQue vous soyez débutant ou développeur expérimenté, ce guide vous aidera à comprendre le fonctionnement des algorithmes de tri et à choisir le bon pour vos besoins.\r\n\r\nPréparez-vous à plonger dans le monde des algorithmes de tri et à simplifier vos manipulations de données !";
        }
    }
}
