namespace As00.Tests;

public class ProgramTest
{
    [Fact]
    public void Is_Leap_Year_Eval_True_On_Mod4()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(1904);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Is_Leap_Year_Eval_False_On_Mod4()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(1905);

        // Assert
        result.Should().BeFalse();

    }
    
    [Fact]
    public void Is_Leap_Year_Eval_True_On_Mod4_And_100()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(1600);

        // Assert
        result.Should().BeTrue();
    }
    
    [Fact]
    public void Is_Leap_Year_Eval_False_On_Mod4_And_100()
    {
        // Arrange
        var sut = new Program();

        // Act
        bool result = sut.IsLeapYear(1900);

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
    public void YayOrNay_Print_nay()
    {
        // Arrange
        var sut = new Program();

        // Act
        string result = sut.YayOrNay(false);

        // Assert
        result.Should().Be("nay");
    }

    [Fact]
    public void YayOrNay_Print_yay()
    {
        // Arrange
        var sut = new Program();

        // Act
        string result = sut.YayOrNay(true);

        // Assert
        result.Should().Be("yay");
    }

    // [Fact]
    // public void ErrorHandling_Invalid_Characters_Input()
    // {
    //     // Arrange
    //     var sut = new Program();

    //     // Act
    //     bool result = sut.ErrorHandling("#zSo0p");

    //     // Assert
    //     result.Should().BeFalse();

    // }
    
    // [Fact]
    // public void ErrorHandling_Invalid_Number_Input()
    // {
    //     // Arrange
    //     var sut = new Program();

    //     // Act
    //     bool result = sut.ErrorHandling("1480");

    //     // Assert
    //     result.Should().BeFalse();
    // }

    // [Fact]
    // public void ErrorHandling_Valid_Input()
    // {
    //     // Arrange
    //     var sut = new Program();

    //     // Act
    //     bool result = sut.ErrorHandling("1996");

    //     // Assert
    //     result.Should().BeTrue();
    // }
    
}