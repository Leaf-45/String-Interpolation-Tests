using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        return date;
    }

    public string Number03()
    {
        var day = _date.Now.ToString("dd");
        var MonthAndYear = _date.Now.ToString("MMMM, yyyy");
        var answer = $"Day {day:dd} of {MonthAndYear:MMMM, yyyy}";
        return answer;
    }

    public string Number04()
    {
        var year = _date.Now.ToString("yyyy");
        var month = _date.Now.ToString("MM");
        var day = _date.Now.ToString("dd");
        var answer = $"Year: {year:yyyy}, Month: {month:MM}, Day: {day:dd}";
        return answer;
    }

    public string Number05()
    {
        var date = _date.Now.ToString("dddd");
        var answer = $"{date,10:dddd}";
        return answer;
    }

    public string Number06()
    {
        var time = _date.Now.ToString("hh:mm tt");
        var weekday = _date.Now.ToString("dddd");
        var answer = $"{time,10:hh:mm tt}{weekday,10:dddd}";
        return answer;
    }

    public string Number07()
    {
        var hour = _date.Now.ToString("hh");
        var minute = _date.Now.ToString("mm");
        var second = _date.Now.ToString("ss");
        var answer = $"h:{hour:hh}, m:{minute:mm}, s:{second:ss}";
        return answer;
    }

    public string Number08()
    {
        var date = _date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
        var answer = $"{date:yyyy.MM.dd.hh.mm.ss}";
        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:c}";
        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:n3}";
        return answer;
    }

    public string Number11()
    {
        double square = Math.Sqrt(2);

        int length = square.ToString().Length - 1;
        String hex = "";
        for (int i = 0; i <= length; i++)
        {
            int temp = Convert.ToInt32(Math.Floor(square));
            square = square - temp;
            square = square * 16;
            hex = String.Concat(hex, String.Format("{0:X}", temp));
            if (i == 0)
            {
                hex = String.Concat(hex, ".");
            }
        }
        return hex;
    }

    //2.2019.01.22
}
