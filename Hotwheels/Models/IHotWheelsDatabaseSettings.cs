namespace Hotwheels.Models
{
    public interface IHotWheelsDatabaseSettings
    {
        string HotWheelsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
