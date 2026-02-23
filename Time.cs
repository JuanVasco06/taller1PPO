using System;

// NOTE: All comments are in English as requested.
public class Time
{
    // Private fields
    private int _hour;
    private int _minute;
    private int _second;
    private int _millisecond;

    // Read-only properties
    public int Hour => _hour;
    public int Minute => _minute;
    public int Second => _second;
    public int Millisecond => _millisecond;

    // Constructor 1: no parameters
    public Time() : this(0, 0, 0, 0) { }

    // Constructor 2: hour
    public Time(int hour) : this(hour, 0, 0, 0) { }

    // Constructor 3: hour and minute
    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }

    // Constructor 4: hour, minute and second
    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }

    // Constructor 5: hour, minute, second and millisecond
    public Time(int hour, int minute, int second, int millisecond)
    {
        if (!ValidHour(hour))
            throw new Exception($"The hour: {hour}, is not valid.");

        if (!ValidMinute(minute))
            throw new Exception($"The minute: {minute}, is not valid.");

        if (!ValidSecond(second))
            throw new Exception($"The second: {second}, is not valid.");

        if (!ValidMillisecond(millisecond))
            throw new Exception($"The millisecond: {millisecond}, is not valid.");

        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
    }

    // Returns total milliseconds from 00:00:00.000
    public long ToMilliseconds()
    {
        return ((long)_hour * 60 * 60 * 1000) +
               ((long)_minute * 60 * 1000) +
               ((long)_second * 1000) +
               _millisecond;
    }

    // Returns total seconds from 00:00:00
    public long ToSeconds()
    {
        return ToMilliseconds() / 1000;
    }

    // Returns total minutes from 00:00
    public long ToMinutes()
    {
        return ToMilliseconds() / (60 * 1000);
    }

    // Returns true if the sum of this time and another time reaches the next day
    public bool IsOtherDay(Time other)
    {
        long oneDayInMilliseconds = 24L * 60L * 60L * 1000L;
        return (ToMilliseconds() + other.ToMilliseconds()) >= oneDayInMilliseconds;
    }

    // Adds two Time objects and returns the resulting time (mod 24 hours)
    public Time Add(Time other)
    {
        // Add milliseconds and carry to seconds
        int millisecond = _millisecond + other._millisecond;
        int carrySecond = millisecond / 1000;
        millisecond %= 1000;

        // Add seconds and carry to minutes
        int second = _second + other._second + carrySecond;
        int carryMinute = second / 60;
        second %= 60;

        // Add minutes and carry to hours
        int minute = _minute + other._minute + carryMinute;
        int carryHour = minute / 60;
        minute %= 60;

        // Add hours and wrap around 24
        int hour = _hour + other._hour + carryHour;
        hour %= 24;

        return new Time(hour, minute, second, millisecond);
    }

    // Validates hour [0..23]
    public bool ValidHour(int hour)
    {
        return hour >= 0 && hour <= 23;
    }

    // Validates minute [0..59]
    public bool ValidMinute(int minute)
    {
        return minute >= 0 && minute <= 59;
    }

    // Validates second [0..59]
    public bool ValidSecond(int second)
    {
        return second >= 0 && second <= 59;
    }

    // Validates millisecond [0..999]
    public bool ValidMillisecond(int millisecond)
    {
        return millisecond >= 0 && millisecond <= 999;
    }

    // Returns time in assignment-required format (12-hour with 00 for midnight/noon edge style)
    public override string ToString()
    {
        int displayHour = _hour % 12;
        string suffix = _hour < 12 ? "AM" : "PM";

        return $"{displayHour:00}:{_minute:00}:{_second:00}.{_millisecond:000} {suffix}";
    }
}