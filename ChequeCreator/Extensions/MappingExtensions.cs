using ChequeCreator.Models;
using ChequeCreator.ViewModels;

namespace ChequeCreator.Extensions
{
    public static class MappingExtensions
    {
        public static ChequeViewModel MapToViewModel(this ChequeModel source)
        {
            if (source == null) return null;

            return new ChequeViewModel
            {
                PayeeName = source.PayeeName,
                DollarAmountInCurrency = $"${source.DollarAmount.ToString("N")}",
                DollarAmountInWords = source.DollarAmount.ToEnglishWords(),
                IssueDate = source.IssueDate.ToString("dd/MM/yyyy")
            };
        }
    }
}
