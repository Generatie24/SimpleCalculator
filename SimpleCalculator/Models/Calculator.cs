using System.ComponentModel.DataAnnotations;

namespace SimpleCalculator.Models
{
    public class Calculator
    {
        static string error = "The field SecondNumber must be greater than 0.";
        public decimal FirstNumber { get; set; }
        [Required(ErrorMessage = "Second number is required.")]
        [ZeroNotAllowed]
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
