namespace ConsoleForum.Commands
{
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            var questions = this.Forum.Questions;
            string title = this.Data[1];
            string body = this.Data[2];

            Question question = new Question(questions.Count + 1, this.Forum.CurrentUser, body, title);

            questions.Add(question);

            this.Forum.Output.AppendLine(
                string.Format(Messages.PostQuestionSuccess, questions.Last().Id)
            );
        }
    }
}