using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacApp
{
    public static class ZodiacHelper
    {
        public static string GetZodiacSign(int day, int month)
        {
            // Zodiac sign determination logic
            return month switch
            {
                1 => (day < 20) ? "Capricorn" : "Aquarius", // If month is January and day is less than 20, return Capricorn, else Aquarius
                2 => (day < 19) ? "Aquarius" : "Pisces", // If month is February and day is less than 19, return Aquarius, else Pisces
                3 => (day < 21) ? "Pisces" : "Aries",
                4 => (day < 20) ? "Aries" : "Taurus",
                5 => (day < 21) ? "Taurus" : "Gemini",
                6 => (day < 21) ? "Gemini" : "Cancer",
                7 => (day < 23) ? "Cancer" : "Leo",
                8 => (day < 23) ? "Leo" : "Virgo",
                9 => (day < 23) ? "Virgo" : "Libra",
                10 => (day < 23) ? "Libra" : "Scorpio",
                11 => (day < 22) ? "Scorpio" : "Sagittarius",
                12 => (day < 22) ? "Sagittarius" : "Capricorn",
                _ => "Unknown"
            };
        }
    }
}