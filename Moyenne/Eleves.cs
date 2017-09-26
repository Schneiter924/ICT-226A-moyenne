﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    /// <summary>
    /// Gestion des élèves
    /// </summary>
    public class Eleves
    {
        public Eleves()
        {

        }
        /// <summary>
        /// Permet de récuper ou d'ajouter le nom
        /// </summary>
        public string Nom { set; get; }

        /// <summary>
        /// Permet de récuper ou d'ajouter le prénom
        /// </summary>
        public string Prenom { set; get; }

        /// <summary>
        /// Permet de récuper ou d'ajouter une image
        /// </summary>
        public string Image { set; get; }

        public List<decimal> NoteEleve { set; get; }
    }
}