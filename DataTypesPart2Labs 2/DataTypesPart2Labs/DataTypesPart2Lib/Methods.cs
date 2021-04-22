using System;

namespace DataTypesPt2Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class Methods
    {
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
            {
                throw  new ArgumentException("Error - birthDate is in the future");
            }
            var day = date - birthDate;
            var age = day.Days/365.25;
            return (int)age;
        }

        public static string FormatDate(DateTime date)
        {
            return date.ToString("y/dd/MMM");
        }
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        public static string Fortune(Suit suit)
        {
            switch (suit)
            {
                case Suit.HEARTS:
                    return "You've broken my heart";
                    break;
                case Suit.CLUBS:
                    return "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.DIAMONDS:
                    return "Diamonds are a girls best friend";
                    break;
                case Suit.SPADES:
                    return "Bucket and spade";
                    break;
                default:
                    break;
            }
            return string.Empty;
        }


    }
}
    