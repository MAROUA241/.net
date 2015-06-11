using System;

namespace Messaging.Domain
{
    public struct TimelineMessage
    {
        private UserId _ownerId;
        private DateTime _publishDate;
        private UserId _authorId;
        private string _content;
        private readonly int _nbRepublish;

        public TimelineMessage(UserId ownerId, DateTime publishDate, UserId authorId, string content, int nbRepublish)
        {
            _ownerId = ownerId;
            _publishDate = publishDate;
            _authorId = authorId;
            _content = content;
            _nbRepublish = nbRepublish;
        }

        public UserId OwnerId
        {
            get { return _ownerId; }
            set { _ownerId = value; }
        }
     

        public DateTime PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public int NbRepublish
        {
            get { return _nbRepublish; }
        }
    }
}