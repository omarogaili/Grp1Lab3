using SqlInjection;
namespace SqlTestInjection
{
    public class UnitTest1
    {
        UserValidation userValidation = new UserValidation();
        [Theory]
        [InlineData("omarogaili@hotmail.com", true)] // this one should pass
        [InlineData("omarogaili", false)]
        [InlineData("omarogaili@hotmail.com omar' or 1=1--", false)] // SQL injection test
        public void Get_the_Validation_of_The_UserInput(string userInput, bool expectedResult)
        {
            Assert.Equal(userValidation.IsValidEmail(userInput), expectedResult);
        }
        // Ny testmetod för telefonnummer validering
        [Theory]
        [InlineData("0701234567", true)]    // 10 siffror
        [InlineData("123456789012345", true)] // 15 siffror
        [InlineData("070123456", false)]   // för få siffror
        [InlineData("0701234567890123456", false)]  // för många siffror
        [InlineData("070-1234567", false)]  // innehåller tecken
        public void Get_the_Validation_of_The_UserInput_Phone(string userInput, bool expectedResult)
        {
            Assert.Equal(userValidation.IsValidPhoneNumber(userInput), expectedResult);
        }
    }
}