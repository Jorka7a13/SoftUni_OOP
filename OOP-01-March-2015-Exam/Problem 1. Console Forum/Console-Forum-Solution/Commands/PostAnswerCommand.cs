namespace ConsoleForum.Commands
{
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            var openedQuestion = this.Forum.CurrentQuestion;

            if (openedQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var answers = this.Forum.Answers;
            IUser author = this.Forum.CurrentUser;
            string body = Data[1];

            Answer answer = new Answer(this.Forum.Answers.Count + 1, author, body);

            openedQuestion.Answers.Add(answer);
            answers.Add(answer);

            this.Forum.Output.AppendLine(
                string.Format(Messages.PostAnswerSuccess, answers.Last().Id)
            );
        }
    }
}