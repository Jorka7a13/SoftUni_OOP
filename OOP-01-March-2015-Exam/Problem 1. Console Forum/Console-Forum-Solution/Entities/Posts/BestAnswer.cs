using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class BestAnswer : Answer
    {
        public BestAnswer(int id, IUser autor, string body)
            : base(id, autor, body)
        {
        }
    }
}