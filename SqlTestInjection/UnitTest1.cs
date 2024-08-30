using SqlInjection;
namespace SqlTestInjection
{
    public class UnitTest1
    {
        UserValidation userValidation = new UserValidation();
        [Theory]
        [InlineData("omarogaili@hotmail.com", true)] // this one should pass
        [InlineData("omarogaili", false)]
        [InlineData ("omarogaili@hotmail.com omar' or 1=1--", false)] // SQL injection test
        public void Get_the_Validation_of_The_UserInput(string userInput, bool expectedResult)
        {
            Assert.Equal(userValidation.IsValidEmail(userInput), expectedResult);
        }
    }
}