namespace ConsoleForum.Commands
{
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            int questionID = int.Parse(this.Data[1]);

            if (questions.All(question => question.Id != questionID))
            {
                throw new CommandException(Messages.NoQuestion);
            }

            var targetQuestion = questions.Single(question => question.Id == questionID);
            this.Forum.CurrentQuestion = targetQuestion;

            this.Forum.Output.AppendLine(string.Format("[ Question ID: {0} ]", targetQuestion.Id));
            this.Forum.Output.AppendLine(string.Format("Posted by: {0}", targetQuestion.Author.Username));
            this.Forum.Output.AppendLine(string.Format("Question Title: {0}", targetQuestion.Title));
            this.Forum.Output.AppendLine(string.Format("Question Body: {0}", targetQuestion.Body));
            this.Forum.Output.AppendLine("====================");

            if (targetQuestion.Answers.Count == 0)
            {
                throw new CommandException(Messages.NoAnswers);
            }

            this.Forum.Output.AppendLine("Answers:");

            var bestAnswers = targetQuestion.Answers.OfType<BestAnswer>();
            if (bestAnswers.Count() != 0)
            {
                foreach (var bestAnswer in bestAnswers)
                {
                    this.Forum.Output.AppendLine("********************");
                    this.Forum.Output.AppendLine(string.Format("[ Answer ID: {0} ]", bestAnswer.Id));
                    this.Forum.Output.AppendLine(string.Format("Posted by: {0}", bestAnswer.Author.Username));
                    this.Forum.Output.AppendLine(string.Format("Answer Body: {0}", bestAnswer.Body));
                    this.Forum.Output.AppendLine("--------------------");
                    this.Forum.Output.AppendLine("********************");
                }
            }

            foreach (var answer in targetQuestion.Answers.OrderBy(answer => answer.Id).Where(answer => !(answer is BestAnswer)))
            {
                this.Forum.Output.AppendLine(string.Format("[ Answer ID: {0} ]", answer.Id));
                this.Forum.Output.AppendLine(string.Format("Posted by: {0}", answer.Author.Username));
                this.Forum.Output.AppendLine(string.Format("Answer Body: {0}", answer.Body));
                this.Forum.Output.AppendLine("--------------------");
            }
        }
    }
}