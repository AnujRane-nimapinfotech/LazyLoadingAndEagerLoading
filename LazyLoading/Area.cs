namespace LazyLoading
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int CityId { get; set; }
        public string Pincode { get; set; }
        public virtual City City { get; set; }
    }
}
