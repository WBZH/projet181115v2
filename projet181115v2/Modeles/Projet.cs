using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet181115v2.Modeles
{
    class Projet
    {
        #region Attributs

        public static ArrayList CollClasseProjet = new ArrayList();

        private string _nom;
        private DateTime _DateDebut;
        private DateTime _DateFin;
        private float _prixFacturéMO;
        private Mission _lesMission;

        #endregion

        #region Constructeur
        public Projet(string nom, DateTime DateDebut, DateTime DateFin, float prixFacturéMO, Mission lesMission)
        {
            Nom = nom;
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
            PrixFacturéMO = prixFacturéMO;
            LesMission = lesMission;
        }


        #endregion

        #region Getter Setter
        public string Nom { get => _nom; set => _nom = value; }
        public DateTime DateDebut { get => _DateDebut; set => _DateDebut = value; }
        public DateTime DateFin { get => _DateFin; set => _DateFin = value; }
        public float PrixFacturéMO { get => _prixFacturéMO; set => _prixFacturéMO = value; }
        public Mission LesMission { get => _lesMission; set => _lesMission = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
