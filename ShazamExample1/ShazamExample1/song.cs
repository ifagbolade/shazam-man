using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Song
    {
        private string _songTitle;
        private Artist artist;
        private float duration;

        public string SongTitle { get => _songTitle; set => _songTitle = value; }
        public float Duration { get => duration; set => duration = value; }
        internal Artist Artist { get => artist; set => artist = value; }
    }
}
