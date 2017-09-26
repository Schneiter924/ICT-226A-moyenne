using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moyenne
{
    public partial class frmMoyenne : Form
    {
        public frmMoyenne()
        {
            InitializeComponent();
            cmdModifier.Enabled = false;
            cmdSupprimer.Enabled = false;
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            frmEleve ajouEleve = new frmEleve();
            ajouEleve.ElevesInt = new Eleves();
            ajouEleve.ElevesInt.NoteEleve = new List<decimal>();
            if (ajouEleve.ShowDialog(this) == DialogResult.OK)
            {
                
            }
            else
            {

            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {

        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'un élève",MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {

            }
            else if (supprimer == DialogResult.No)
            {

            }
        }
    }
}
