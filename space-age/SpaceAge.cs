namespace space_age;

public class SpaceAge
{
    readonly double earthYearsInSeconds = 31557600;
    readonly double seconds;
    public SpaceAge(double seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => seconds / earthYearsInSeconds;

    public double OnMercury() => seconds / (earthYearsInSeconds * 0.2408467);

    public double OnVenus() => seconds / (earthYearsInSeconds * 0.61519726);

    public double OnMars() => seconds / (earthYearsInSeconds * 1.8808158);

    public double OnJupiter() => seconds / (earthYearsInSeconds * 11.862615);

    public double OnSaturn() => seconds / (earthYearsInSeconds * 29.447498);

    public double OnUranus() => seconds / (earthYearsInSeconds * 84.016846);

    public double OnNeptune() => seconds / (earthYearsInSeconds * 164.79132);
}
