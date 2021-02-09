namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool IsStarted { get; set; }

        public Engine()
        {

        }

        public string About()
        {
            if (IsStarted)
                return $"{ToString()} is started.";
            else
                return $"{ToString()} is not started.";
        }

        public void Start()
        {
            IsStarted = true;
        }

        public void Stop()
        {
            IsStarted = false;
        }
    }
}