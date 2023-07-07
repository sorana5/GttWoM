using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalSpreLumeaMuzicii
{
    public class Cantec
    {
        public bool _cantat;
        public List <int> _note = new List<int> ();
        public string _titlu;

        public bool Cantat
        { get { return _cantat; } set { _cantat = value; } }

        public List <int> Note
        { get { return _note; } set { _note = value; } }

        public string Titlu
        { get { return _titlu; } set { _titlu = value; } }

        public Cantec(string titlu, List<int> note)
        {
            Titlu = titlu;
            Note = note;
        }
    }
}
