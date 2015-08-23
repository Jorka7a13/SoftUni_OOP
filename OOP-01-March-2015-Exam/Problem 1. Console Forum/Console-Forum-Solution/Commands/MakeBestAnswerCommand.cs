namespace ConsoleForum.Commands
{
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    public class MakeBestAnswerCommand : AbstractCommand
    {
        public const string AdministratorType = "Administrator";

        public MakeBestAnswerCommand(IForum forum)
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

            var answers = openedQuestion.Answers;
            var answerID = int.Parse(this.Data[1]);

            if (answers.All(answer => answer.Id != answerID))
            {
                throw new CommandException(Messages.NoAnswer);
            }

            var currentUser = this.Forum.CurrentUser;

            if (openedQuestion.Author.Id != currentUser.Id && currentUser.GetType().Name != AdministratorType)
            {
                throw new CommandException(Messages.NoPermission);
            }

            IAnswer currentAnswer = answers.Single(answer => answer.Id == answerID);
            BestAnswer bestAnswer = new BestAnswer(currentAnswer.Id, currentAnswer.Author, currentAnswer.Body);

            answers.Remove(currentAnswer);
            this.Forum.Answers.Remove(currentAnswer);

            answers.Add(bestAnswer);
            this.Forum.Answers.Add(bestAnswer);

            this.Forum.Output.AppendLine(
                string.Format(Messages.BestAnswerSuccess, bestAnswer.Id)
            );
        }
    }
}