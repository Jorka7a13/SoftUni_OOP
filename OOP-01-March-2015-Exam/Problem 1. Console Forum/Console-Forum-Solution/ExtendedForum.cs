namespace ConsoleForum
{
    using System;
    using System.Linq;

    using ConsoleForum.Entities.Posts;

    public class ExtendedForum : Forum
    {
        protected override void ExecuteCommandLoop()
        {
            base.Output.AppendLine("~~~~~~~~~~~~~~~~~~~~");

            if (!base.IsLogged)
            {
                base.Output.AppendLine("Hey stranger, care to login/register?");
            }
            else
            {
                base.Output.AppendLine(String.Format("Welcome, {0}!", base.CurrentUser.Username));
            }

            var hotQuestionsCount = base.Questions.Count(question => question.Answers.Any(answer => !(answer is BestAnswer)));
            var activeUsersCount = base.Users.Count(user => user.Questions.Any(question => question.Answers.Count == 3));

            base.Output.AppendLine(String.Format("Hot questions: {0}, Active users: {1}", hotQuestionsCount, activeUsersCount));
            base.Output.AppendLine("~~~~~~~~~~~~~~~~~~~~");
            Console.Write(this.Output);

            base.ExecuteCommandLoop();
        }
    }
}