

using System.Collections.Generic;

namespace Car.Entities.Dtos
{
    public class ArabaDetaylariDto
    {
        public int CarId { get; set; }
        
        
        public string Marka { get; set; }
        public string Model { get; set; }
        public List<HasarDto> Hasars { get; set; }
    }
}
