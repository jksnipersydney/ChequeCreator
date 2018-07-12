using System;

using ChequeCreator.Extensions;
using ChequeCreator.Models;

using FluentAssertions;

using Xunit;

namespace ChequeCreatorTests.Extensions
{
    public class MappingExtensionsTests
    {
        [Fact]
        public void MapToViewModel_WithNullModel_ReturnsNull()
        {
            var vm = MappingExtensions.MapToViewModel((ChequeModel)null);

            vm.Should().BeNull();
        }

        [Fact]
        public void MapToViewModel_WithValidModel_ReturnsChequeViewModel()
        {
            var cm = new ChequeModel
            {
                PayeeName = "John Doe",
                DollarAmount = 1234.56,
                IssueDate = DateTime.Now
            };

            var vm = MappingExtensions.MapToViewModel(cm);

            vm.Should().NotBeNull();
        }
    }
}
