using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace Bileterie.Models
{
    public class Contract
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Spectacol))]
        public int SpectacolID { get; set; }
        public int AngajatID { get; set; }
    }
}
