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
    public partial class frmEleve : Form
    {
        private Eleves elevesInt;

        public Eleves ElevesInt
        {
            get
            {
                return elevesInt;
            }
            set
            {
                elevesInt = value;
            }
        }
        public frmEleve()
        {
            InitializeComponent();
            //updateStatus();
            
                       
        }
        
        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            frmNote noteAjou = new frmNote();
            noteAjou.NotesInt = new Notes();
            noteAjou.NotesInt.NotesEntier = 1;
            decimal moyennne = 0;
            if (noteAjou.ShowDialog(this) == DialogResult.OK)
            {
                lstNotes.Items.Add(noteAjou.NotesInt);
                ElevesInt.NoteEleve.Add(noteAjou.NotesInt.Convertion());
                foreach (decimal note in ElevesInt.NoteEleve)
                {
                    moyennne += note;
                }
                moyennne /= ElevesInt.NoteEleve.Count();
                ElevesInt.Moyenne = moyennne;
                txtMoyenne.Text = moyennne.ToString();
                ElevesInt.Prenom = txtPrenom.Text;
                ElevesInt.Nom = txtNom.Text;
                cmdValiderTest();
                updateStatus();
            }
            else
            {

            }
            
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex != -1)
            {
                frmNote noteModif = new frmNote();
                noteModif.NotesInt = (Notes) lstNotes.SelectedItem;
                int index = lstNotes.SelectedIndex;
                noteModif.NotesInt.NotesEntier = noteModif.NotesInt.DeConvertionEntier((decimal)5.9);
                noteModif.NotesInt.NotesDecimale = noteModif.NotesInt.DeConvertionDecimale((decimal)5.9);

            }
                
            
            
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult supprimer = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'une Note", MessageBoxButtons.YesNo);
            if (supprimer == DialogResult.Yes)
            {

            }
            else if (supprimer == DialogResult.No)
            {

            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult annuler = MessageBox.Show("Confirmez-vous l'annulation ?", "Suppression de la saisie", MessageBoxButtons.YesNo);
            if (annuler == DialogResult.Yes)
            {
                Dispose();
            }
            else if (annuler == DialogResult.No)
            {

            }
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {

        }

        
        private void cmdValiderTest()
        {
            if ((txtMoyenne.Text != "")&&(txtNom.Text != "")&&(txtPrenom.Text != ""))
            {
                cmdValider.Enabled = true;
                
            }
            else
            {
                cmdValider.Enabled = false;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            cmdValiderTest();
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            cmdValiderTest();
        }

        private void updateStatus()
        {
            if (lstNotes.SelectedIndex != -1)
            {
                cmdModifier.Enabled = true;
                cmdSupprimer.Enabled = true;
            }
            else
            {
                cmdModifier.Enabled = false;
                cmdSupprimer.Enabled = false;
            }
        }
    }
}
