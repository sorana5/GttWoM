using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayToTheWorldOfMusic
{
    public class Song
    {
        public int _nrPortative;
        public List<List<int>> _note = new List<List<int>>();
        public string _titlu;
        public string _gama;

        public bool _cantat;

        public bool Cantat
        { get { return _cantat; } set { _cantat = value; } }

        public List < List <int>> Note
        { get { return _note; } set { _note = value; } }

        public string Titlu
        { get { return _titlu; } set { _titlu = value; } }

        public string Gama
        { get { return _gama; } set { _gama = value; } }

        public int NrPortative
        { get { return _nrPortative; } set { _nrPortative = value; } }

        public Song(string titlu, string gama, int nrPortative, List<List<int>> note)
        {
            Titlu = titlu;
            Gama = gama;
            NrPortative = nrPortative;
            Note = note;
        }
    }
}
