namespace SimpleCalculator.Models
{
    public class Calculator
    {
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }

        public decimal Calculate(string operation)
        {
            decimal result = 0;
            switch (operation)
            {
                case "Add":
                    result = FirstNumber + SecondNumber;
                    break;
                case "Sub":
                    result = FirstNumber - SecondNumber;
                    break;
                case "Mul":
                    result = FirstNumber * SecondNumber;
                    break;
                case "Div":
                    result = FirstNumber / SecondNumber;
                    break;
            }
            return result;
        }
    }
}
