using System.Collections.Generic;

namespace LazyLoading
{
    public class City
    {
        public City()
        {
            this.Areas = new HashSet<Area>();
        }
        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Area> Areas { get; set; }


    }
}
