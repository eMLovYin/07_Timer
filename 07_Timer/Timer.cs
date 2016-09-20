namespace _07_Timer
{
    internal class Timer
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;

        public override string ToString()
        {
            //string s = string.Format("{0:00}", seconds);
            //string m = string.Format("{0:00}", minutes);
            //string h = string.Format("{0:00}", hours);
            return Padded(hours) + ":" + Padded(minutes) + ":" + Padded(seconds);
        }
        public string Padded(int s)
        {
            return string.Format("{0:00}", s);
        }

        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value > 60)
                {
                    this.seconds = value % 60;
                    this.Minutes = value - seconds;
                }
                else
                {
                    this.seconds = value;
                }
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            private set
            {
                if (value / 60 > 60)
                {
                    this.minutes = (value / 60) % 60;
                    this.Hours = (value / 60) - minutes;
                }
                else
                {
                    this.minutes = value / 60;
                }
            }
        }

        public int Hours
        {
            get { return this.hours; }
            private set { this.hours = (value / 60); }
        }
    }
}