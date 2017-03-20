using System;

namespace Premium.Server.Common.Extensions
{
    public static class NumberExtensions
    {
        public static string ToDefaultIfNegativeOrZero(this int number)
        {
            return number <= 0 ? String.Empty : number.ToString();
        }
    }
}