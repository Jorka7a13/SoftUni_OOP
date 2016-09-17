namespace ConsoleForum.Entities.Posts
{
    using ConsoleForum.Contracts;

    public class Answer : Post, IAnswer
    {
        public Answer(int id, IUser autor, string body)
            : base(id, autor, body)
        {
        }
    }
}