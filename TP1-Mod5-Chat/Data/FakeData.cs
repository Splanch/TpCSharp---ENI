using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP.Models;

namespace TP1_Mod5_Chat.Data
{
    public class FakeData
    {

        private static readonly Lazy<FakeData> lazy =
            new Lazy<FakeData>(() => new FakeData());

        /// <summary>
        /// FakeDb singleton access.
        /// </summary>
        public static FakeData Instance { get { return lazy.Value; } }

        private FakeData()
        {
            this.ListeChats = this.GetMeuteDeChats();

        }

        public List<Chat> ListeChats { get; private set; }

        private List<Chat> GetMeuteDeChats()
        {
            var i = 1;
            return new List<Chat>
            {
                new Chat{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new Chat{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new Chat{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new Chat{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new Chat{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new Chat{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new Chat{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }

    }
}