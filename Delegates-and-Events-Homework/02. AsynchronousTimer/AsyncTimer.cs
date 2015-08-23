namespace _02.AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {
        private Action<string> action;
        private int tick;
        private int t;

        public AsyncTimer(Action<string> action, int tick, int t)
        {
            this.Action = action;
            this.Tick = tick;
            this.T = t;
        }

        public Action<string> Action
        {
            get { return this.action; }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("action", "Action can't be null!");
                }

                this.action = value;
            }
        }

        public int Tick
        {
            get { return this.tick; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Tick can't be negative!");
                }

                this.tick = value;
            }
        }

        public int T
        {
            get { return this.t; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("T can't be negative!");
                }

                this.t = value;
            }
        }

        private void DoWork()
        {
            while (this.tick > 0)
            {
                Thread.Sleep(this.t);

                if (action != null)
                {
                    action(this.tick.ToString());
                }

                this.tick--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.DoWork);
            thread.Start();
        }
    }
}