using Messaging.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging.Tests.Domain
{
    class TimelineMessageProjections
    {
        private ITimelineMessageRepository timelineMessageRepository;

        public TimelineMessageProjections(ITimelineMessageRepository timelineMessageRepository)
        {
            this.timelineMessageRepository = timelineMessageRepository;
        }

        internal TimelineMessage Handle(MessagePublished messagePublished)
        { 
            TimelineMessage timelineMessage =new TimelineMessage();
            timelineMessage.PublishDate = messagePublished.PublishDate;
            timelineMessage.OwnerId = messagePublished.AuthorId;
            timelineMessage.Content = messagePublished.Content;
            timelineMessageRepository.s
        }
    }
}
