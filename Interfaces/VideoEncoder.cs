using System.Collections;
using System.Collections.Generic;

namespace Interfaces
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChanel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChanel>();
        }

        public void Encode(Video video)
        {
            // Video Encodeing Logic
            //...
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChanel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
