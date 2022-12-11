using System;
using System.Globalization;

namespace Logic
{
    public class ZodiacData
    {
        public static eZodiac GetZodiac(string i_Birthday)
        {
            DateTime birthday = DateTime.ParseExact(
                 i_Birthday,
                 "MM/dd/yyyy",
                 CultureInfo.InvariantCulture);

            eMonth month = (eMonth)birthday.Month;
            int day = birthday.Day;
            eZodiac zodiac;

            switch (month)
            {
                case eMonth.January:
                    zodiac = (day < 20) ? eZodiac.Capricorn : eZodiac.Aquarius;
                    break;

                case eMonth.February:
                    zodiac = (day < 19) ? eZodiac.Aquarius : eZodiac.Pisces;
                    break;

                case eMonth.March:
                    zodiac = (day < 21) ? eZodiac.Pisces : eZodiac.Aries;
                    break;

                case eMonth.April:
                    zodiac = (day < 20) ? eZodiac.Aries : eZodiac.Taurus;
                    break;

                case eMonth.May:
                    zodiac = (day < 21) ? eZodiac.Taurus : eZodiac.Gemini;
                    break;

                case eMonth.June:
                    zodiac = (day < 21) ? eZodiac.Gemini : eZodiac.Cancer;
                    break;

                case eMonth.July:
                    zodiac = (day < 23) ? eZodiac.Cancer : eZodiac.Leo;
                    break;

                case eMonth.August:
                    zodiac = (day < 23) ? eZodiac.Leo : eZodiac.Virgo;
                    break;

                case eMonth.September:
                    zodiac = (day < 23) ? eZodiac.Virgo : eZodiac.Libra;
                    break;

                case eMonth.October:
                    zodiac = (day < 23) ? eZodiac.Libra : eZodiac.Scorpio;
                    break;

                case eMonth.November:
                    zodiac = (day < 22) ? eZodiac.Scorpio : eZodiac.Sagittarius;
                    break;

                default:
                case eMonth.December:
                    zodiac = (day < 22) ? eZodiac.Sagittarius : eZodiac.Capricorn;
                    break;
            }

            return zodiac;
        }
    }

    internal enum eMonth
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public enum eZodiac
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    }
}