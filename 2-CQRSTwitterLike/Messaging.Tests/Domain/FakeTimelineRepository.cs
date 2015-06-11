using Messaging.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging.Tests.Domain
{
    class FakeTimelineRepository : ITimelineMessageRepository
    {
    
        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            throw new NotImplementedException();
        }

        public List<TimelineMessage> Messages = new List<TimelineMessage>();

    }
}
