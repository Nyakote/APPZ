namespace Hello_world.Data
{
    public class DataRepository
    {
        public string GetGreeting()
        {
            return "Hello world";
        }

        public string GetFullName()
        {
            return "I'm Nevmivaka Dmitriy Andriyovich PR-3-2";
        }

        public string GetResponseTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
