using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayToTheWorldOfMusic
{
    public class Song
    {
        public int number_of_staffs;
        public List<List<Note>> notes = new List<List<Note>>();
        public string title;
        public string scale;

        public bool _sung;

        public bool Sung
        { get { return _sung; } set { _sung = value; } }

        public List < List <Note>> Notes
        { get { return notes; } set { notes = value; } }

        public string Title
        { get { return title; } set { title = value; } }

        public string Scale
        { get { return scale; } set { scale = value; } }

        public int NumberOfStaffs
        { get { return number_of_staffs; } set { number_of_staffs = value; } }

        public Song(string title, string scale, int number_of_staffs, List<List<Note>> notes)
        {
            Title = title;
            Scale = scale;
            NumberOfStaffs = number_of_staffs;
            Notes = notes;
        }
    }
}
