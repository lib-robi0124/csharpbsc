namespace AcademyManagementServices
{
    public class ValidationService
    {
        public int GetValidationOption(int[] validOption)
        {
            string input = GetStringInput();
            bool isValidFormat = int.TryParse(input, out int parsedInput);
            if (!isValidFormat)
            {
                throw new Exception("Invalid input");
            }
            if (!validOption.Contains(parsedInput))
            {
                throw new Exception("Invalid option");
            }
            return parsedInput;
        }
        public string GetStringInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("Invalid input");
            }
            return input;
        }
     }
}
