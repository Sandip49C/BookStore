using System;
using System.Threading.Tasks;

namespace BookstoreBlazorApp.Data
{
    public class NotificationService
    {
        public event Func<string, Task>? OnNotify;

        public async Task NotifyAsync(string message)
        {
            if (OnNotify != null)
            {
                await OnNotify.Invoke(message);
            }
        }
    }
}