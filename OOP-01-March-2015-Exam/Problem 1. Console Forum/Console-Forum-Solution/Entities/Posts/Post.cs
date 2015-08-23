namespace ConsoleForum.Entities.Posts
{
    using ConsoleForum.Contracts;

    public abstract class Post : IPost
    {
        protected Post(int id, IUser autor, string body)
        {
            this.Id = id;
            this.Author = autor;
            this.Body = body;
        }

        public int Id { get; set; }

        public IUser Author { get; set; }

        public string Body { get; set; }
    }
}