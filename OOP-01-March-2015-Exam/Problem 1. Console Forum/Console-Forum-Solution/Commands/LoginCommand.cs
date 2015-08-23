namespace ConsoleForum.Commands
{
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Utility;
    using ConsoleForum.Entities.Users;

    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var users = this.Forum.Users;
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            if (users.All(u => u.Username != username || u.Password != password))
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            var user = users.Single(u => u.Username == username);
            this.Forum.CurrentUser = user;

            this.Forum.Output.AppendLine(
                string.Format(Messages.LoginSuccess, username)
            );
        }
    }
}