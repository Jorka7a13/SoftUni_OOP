namespace ConsoleForum.Commands
{
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;

            if (questions.Count == 0)
            {
                throw new CommandException(Messages.NoQuestions);
            }

            this.Forum.CurrentQuestion = null;

            foreach (var question in questions.OrderBy(question => question.Id))
            {
                this.Forum.Output.AppendLine(string.Format("[ Question ID: {0} ]", question.Id));
                this.Forum.Output.AppendLine(string.Format("Posted by: {0}", question.Author.Username));
                this.Forum.Output.AppendLine(string.Format("Question Title: {0}", question.Title));
                this.Forum.Output.AppendLine(string.Format("Question Body: {0}", question.Body));
                this.Forum.Output.AppendLine("====================");

                if (question.Answers.Count == 0)
                {
                    throw new CommandException(Messages.NoAnswers);
                }

                this.Forum.Output.AppendLine("Answers:");

                var bestAnswers = question.Answers.OfType<BestAnswer>();
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

                foreach (var answer in question.Answers.OrderBy(answer => answer.Id).Where(answer => !(answer is BestAnswer)))
                {
                    this.Forum.Output.AppendLine(string.Format("[ Answer ID: {0} ]", answer.Id));
                    this.Forum.Output.AppendLine(string.Format("Posted by: {0}", answer.Author.Username));
                    this.Forum.Output.AppendLine(string.Format("Answer Body: {0}", answer.Body));
                    this.Forum.Output.AppendLine("--------------------");
                }
            }
        }
    }
}