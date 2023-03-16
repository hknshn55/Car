using Car.Core.Entities;
using System;

namespace Car.Entities.Concrete
{
    public class Hasar : IEntity
    {
        public int Id { get; set; }
        public int ArabaId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Araba Araba { get; set; }
    }
}
