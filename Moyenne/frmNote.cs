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
    public partial class frmNote : Form
    {
        /// <summary>
        /// Création de la classe note
        /// </summary>
        private Notes notesInt;
        
        public Notes NotesInt
        {
            get
            {
                return notesInt;
            }
            set
            {
                notesInt = value;
            }
        }
      
        public frmNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// bouton pour annuler la saisie de la note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            notesInt.NotesDecimale = nudDecimal.Value;
            notesInt.NotesEntier = nudEntier.Value;
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            nudDecimal.Value = notesInt.NotesDecimale;
            nudEntier.Value = notesInt.NotesEntier;
        }


    }
}
