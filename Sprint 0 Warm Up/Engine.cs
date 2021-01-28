namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool isStarted { get; set; }

        public Engine()
        {

        }

        public bool About()
        {
            return true;
        }

        public void Start()
        {
            isStarted = true;
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}