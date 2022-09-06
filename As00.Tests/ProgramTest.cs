namespace As00.Tests;

public class ProgramTest
{
    [Fact]
    public void Is_Leap_Year_Eval_True_On_Mod4()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(16);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Is_Leap_Year_Eval_False_On_Mod4()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(81);

        // Assert
        result.Should().BeFalse();

    }
    
    [Fact]
    public void Is_Leap_Year_Eval_True_On_Mod4_And_100()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(400);

        // Assert
        result.Should().BeTrue();
    }
    
    [Fact]
    public void Is_Leap_Year_Eval_False_On_Mod4_And_100()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(281);

        // Assert
        result.Should().BeFalse();

    }

    [Fact]
    public void Is_Leap_Year_Eval_True_On_Mod4_And_100_And_400()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(2000);

        // Assert
        result.Should().BeTrue();
    }
    
    [Fact]
    public void Is_Leap_Year_Eval_False_On_Mod4_And_100_And_400()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(1700);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Is_Leap_Year_With_Input_Print_nay()
    {
        // Arrange
        var sut = new Program();

        // Act
        string result = sut.yayOrNay(false);

        // Assert
        result.Should().Be("nay");
    }

    [Fact]
    public void Is_Leap_Year_With_Input_Print_yay()
    {
        // Arrange
        var sut = new Program();

        // Act
        string result = sut.yayOrNay(true);

        // Assert
        result.Should().Be("yay");
    }
    
}