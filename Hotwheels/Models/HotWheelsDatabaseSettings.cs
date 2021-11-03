namespace Hotwheels.Models
{
    public class HotWheelsDatabaseSettings : IHotWheelsDatabaseSettings
    {
        public string HotWheelsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
