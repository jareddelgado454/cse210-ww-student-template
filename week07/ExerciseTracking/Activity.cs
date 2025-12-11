public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public int GetLength()
    {
        return _lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}
