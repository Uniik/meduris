using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    public class Joueur
    {
        private string nom;
        private int laine = 1;
        private int bois = 1;
        private int pierre = 1;
        private int cuivre = 1;
        private int huttesDisponibles = 8;
        private int templesDisponibles = 2;
        private int ouvriersDisponible = 2;
        private int points = 5;

        public readonly int huttesTotal = 8;
        public readonly int templesTotal = 2;
        public readonly int ouvriersTotal = 2;

        public Joueur(string nom)
        {
            this.nom = nom;
        }

        public int Laine { get => laine; set => laine = value; }
        public int Bois { get => bois; set => bois = value; }
        public int Pierre { get => pierre; set => pierre = value; }
        public int Cuivre { get => cuivre; set => cuivre = value; }
        public string Nom { get => nom; set => nom = value; }
        public int HuttesDisponibles { get => huttesDisponibles; set => huttesDisponibles = value; }
        public int TemplesDisponibles { get => templesDisponibles; set => templesDisponibles = value; }
        public int OuvriersDisponible { get => ouvriersDisponible; set => ouvriersDisponible = value; }
        public int Points { get => points; set => points = value; }
    }
}
