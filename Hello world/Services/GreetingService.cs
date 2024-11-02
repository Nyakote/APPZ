using Hello_world.Data;

namespace Hello_world.Services
{
    public class GreetingService
    {
        private readonly DataRepository _dataRepository;

        public GreetingService()
        {
            _dataRepository = new DataRepository();
        }

        public string GetGreetingMessage()
        {
            var greeting = _dataRepository.GetGreeting();
            var name = _dataRepository.GetFullName();
            var responseTime = _dataRepository.GetResponseTime();

            return $"{greeting}\n{name}\nExecution time {responseTime}";
        }
    }
}
