namespace Patterns.Singleton.Simple
{
    public sealed class SomeNumber
    {
        private SomeNumber() { }

        private static SomeNumber? _instance { get; set;}

        private static int _number = 0;

        public static SomeNumber GetInstance() 
        {
            if(_instance == null)
            {
                _instance = new SomeNumber();
            }
            return _instance; 
        }

        public int GetNumber()
        {
            if(_number == 0)
            {
                Random random = new Random();
                _number = random.Next(1, 100000);
            }
            return _number;
        }
    }
}
