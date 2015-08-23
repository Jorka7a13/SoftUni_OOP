namespace ConsoleForum.Entities.Posts
{
    using System.Collections.Generic;
    using ConsoleForum.Contracts;

    public class Question : Post, IQuestion
    {
        private IList<IAnswer> answers;
 
        public Question(int id, IUser autor, string body, string title)
            : base(id, autor, body)
        {
            this.Title = title;
            answers = new List<IAnswer>();
        }

        public string Title { get; set; }

        public IList<IAnswer> Answers
        {
            get { return answers; }
        }
    }
}
