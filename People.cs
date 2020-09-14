using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotRater
{
    class People
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Thumbnail { get; set; }

        public string evolution1 { get; set; }

        public string evolution2 { get; set; }

        public int Score { get; set; }

        public decimal Rating { get; set; }
    
        public int TotalTime { get; set; }

        public People() { }

    }

}
