using Car.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entities.Concrete
{
    public class Araba:IEntity
    {
        public Araba()
        {
            CreateDate = DateTime.Now;
            Hasarlar = new List<Hasar>();
        }
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool HasarDurumu { get; set; }
        public int Yil { get; set; }
        public DateTime CreateDate { get; set; }
        public string Resim { get; set; }

        public virtual ICollection<Hasar> Hasarlar { get; set; }
    }
}
