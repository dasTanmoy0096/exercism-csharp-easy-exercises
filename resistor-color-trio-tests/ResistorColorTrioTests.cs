using resistor_color_trio;

namespace resistor_color_trio_tests;

public class ResistorColorTrioTests
{
    [Fact]
    public void Orange_and_orange_and_black()
    {
        Assert.Equal("33 ohms", ResistorColorTrio.Label(new[] { "orange", "orange", "black" }));
    }

    [Fact]
    public void Blue_and_grey_and_brown()
    {
        Assert.Equal("680 ohms", ResistorColorTrio.Label(new[] { "blue", "grey", "brown" }));
    }

    [Fact]
    public void Red_and_black_and_red()
    {
        Assert.Equal("2 kiloohms", ResistorColorTrio.Label(new[] { "red", "black", "red" }));
    }

    [Fact]
    public void Green_and_brown_and_orange()
    {
        Assert.Equal("51 kiloohms", ResistorColorTrio.Label(new[] { "green", "brown", "orange" }));
    }

    [Fact]
    public void Yellow_and_violet_and_yellow()
    {
        Assert.Equal("470 kiloohms", ResistorColorTrio.Label(new[] { "yellow", "violet", "yellow" }));
    }
}