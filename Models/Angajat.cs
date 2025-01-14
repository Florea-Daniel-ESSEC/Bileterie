using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Bileterie.Models
{
    public class Angajat
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NumeArtist { get; set; }
        [OneToMany]
        public List<Contract> Contracte { get; set; }
    }
}
