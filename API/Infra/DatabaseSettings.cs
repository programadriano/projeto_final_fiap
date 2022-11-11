namespace API.Infra
{

    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }

    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
