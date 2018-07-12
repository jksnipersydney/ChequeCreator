using System;
using Humanizer;

namespace ChequeCreator.Extensions
{
    public static class NumericExtensions
    {
        public static string ToEnglishWords(this double source)
        {
            var currencyComponents = Math.Round(source, 2).ToString().Split('.');

            var dollarAmount = long.Parse(currencyComponents[0]);
            
            var dollarInWords = $"{dollarAmount.ToWords()} dollars";
            var centsInWords = string.Empty;

            if (currencyComponents.Length > 1)
            {
                var centAmount = long.Parse(currencyComponents[1]);
                centsInWords = $" and {centAmount.ToWords()} cents";
            }

            return $"{dollarInWords}{centsInWords}";
        }
    }
}
