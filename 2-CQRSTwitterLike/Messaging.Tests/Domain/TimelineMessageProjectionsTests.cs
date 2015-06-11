using NFluent;
using NUnit.Framework;
using System.Collections.Generic;
using System;
using Messaging.Domain;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageProjectionsTests
    {
        [Test]
        public void WhenHandleMessagePublished_ThenTimelineMessageIsSavedForAuthor()
        {
            var messagePublished = new MessagePublished("un message de la mort qui tue", new UserId("pierrick"));
             //TODO : FakeTimelineRepository is a fake implementation of interface for tests purpose only -> keep it in test assembly
            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);

            timelineMessageProjections.Handle(messagePublished);

            var expectedTimelineMessage = new TimelineMessage(/* TODO add parameters to instanciate the expected object after handle call */);
            Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly(expectedTimelineMessage);
        }

        // TODO : repeat for some more Events : FollowerMessagePublished, FollowerMessageRepublished, FollowerMessageLiked, MessageDeleted...
    }
    public class MessagePublished

    {  
        private  DateTime _publishDate;
        private  UserId _authorId;
        private string _content;
      
        public MessagePublished(string message,UserId auteur)
        {
            this._publishDate = DateTime.Now;
            this._content = message;
            this._authorId = auteur;
        }
        public DateTime PublishDate
        {
            get { return _publishDate; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
        }


        public string Content
        {
            get { return _content; }
        }

    }

}
