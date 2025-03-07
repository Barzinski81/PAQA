using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("ivan@softuni.bg")]
    [TestCase("ivan_ivanov@mail.com")]
    [TestCase("jordan23@mit.edu")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("fake @softuni_bg")]
    [TestCase("i@ivan@mail.com")]
    [TestCase("rrbm-berlin.edu")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
