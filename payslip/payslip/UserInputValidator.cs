using System;

namespace payslip
{
    public class UserInputValidator : InputValidatorInterface

    {
        private readonly InputReaderInterface _reader;
        public UserInputValidator(InputReaderInterface reader)
        {
            _reader = reader; 
        }
        public string ValidateName(string name)
        {
            if (name.Length > 0 && name.Length < 15)
                return name;
            return ValidateName(_reader.Read());
        }
    
        public int ValidateInteger(string num)
        {
            if (int.TryParse(num, out var intNum))
                return intNum;
            return ValidateInteger(_reader.Read());
        }
   
    }
}