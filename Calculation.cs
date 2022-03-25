namespace Fizz
{
    public class Calculation
    {
        private int _num;

        public int Num
        {

            get { return _num; }
            set { _num = value; }
        }
        public string calc()
        {
           
            return _num.ToString();
        }
    }

}
