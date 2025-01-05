using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayToTheWorldOfMusic
{
    public class Song
    {
        public int _number_of_staffs;
        public List<List<Note>> _note = new List<List<Note>>();
        public string _title;
        public string _scale;

        public bool _sung;

        public bool Sung
        { get { return _sung; } set { _sung = value; } }

        public List < List <Note>> Notes
        { get { return _note; } set { _note = value; } }

        public string Title
        { get { return _title; } set { _title = value; } }

        public string Scale
        { get { return _scale; } set { _scale = value; } }

        public int NumberOfStaffs
        { get { return _number_of_staffs; } set { _number_of_staffs = value; } }

        public Song(string title, string scale, int number_of_staffs, List<List<Note>> notes)
        {
            Title = title;
            Scale = scale;
            NumberOfStaffs = number_of_staffs;
            Notes = notes;
        }
    }
}
