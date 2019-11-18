using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet181115v2.Modeles
{
    class Mission
    {
        #region Attributs
            private string _nom;
            private string _description;
            private int _nbHeursPrevues;
            private Dictionary<DateTime, int> _releveHoraire = new Dictionary<DateTime, int>();
            private Intervenant Executant;
        #endregion

        #region Constructeurs
            public Mission(string nom, string description, int nbHeursPrevues, Dictionary<DateTime, int> releveHoraire, Intervenant executant1)
            {
                Nom = nom;
                Description = description;
                NbHeursPrevues = nbHeursPrevues;
                ReleveHoraire = releveHoraire;
                Executant1 = executant1;
            }
        #endregion

        #region Getters/Setters
             public string Nom { get => _nom; set => _nom = value; }
            public string Description { get => _description; set => _description = value; }
            public int NbHeursPrevues { get => _nbHeursPrevues; set => _nbHeursPrevues = value; }
            public Dictionary<DateTime, int> ReleveHoraire { get => _releveHoraire; set => _releveHoraire = value; }
            public Intervenant Executant1 { get => Executant; set => Executant = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
