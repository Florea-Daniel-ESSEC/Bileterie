using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bileterie.Models
{
    public class Spectacol
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250), Unique]
        public string NumeSpectacol { get; set; }
        public DateTime DataSpectacol { get; set; }
    }
}