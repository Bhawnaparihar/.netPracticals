namespace SampleEvents
{
    public class SampleClass : ISampleEvents
    {
        public event SampleDelegate SampleEvent;
        public void Invoke()
        {
            if (SampleEvent != null)
                SampleEvent();
        }
    }

    public delegate void SampleDelegate();
    public interface ISampleEvents
    {
        event SampleDelegate SampleEvent;
        void Invoke();
    }
}
