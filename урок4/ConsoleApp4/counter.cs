namespace ConsoleApp4
{

    public class counter
    {
        public delegate void Method();
        public event Method OnCount;
        public void LetsCount()
        {

            for (int i = 0; i < 100; i++)
            {
                if (i == 99)
                {
                    OnCount();
                }
            }


        }

    }
}
