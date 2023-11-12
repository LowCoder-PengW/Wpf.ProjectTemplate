using Wpf.ProjectTemplate.Services.Interfaces;

namespace Wpf.ProjectTemplate.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the LowCoder-PengW";
        }
    }
}
