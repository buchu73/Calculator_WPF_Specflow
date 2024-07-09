namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public string Add()
        {
            return (FirstNumber + SecondNumber).ToString();
        }

        public string Subtract()
        {
            return (FirstNumber - SecondNumber).ToString();
        }

        public string Multiply()
        {
            return (FirstNumber * SecondNumber).ToString();
        }

        public string Divide()
        {
            if (SecondNumber == 0)
            {
                return "Cannot divide by zero";
            }
            else
            {
                return (FirstNumber / SecondNumber).ToString();
            }
        }
    }
}