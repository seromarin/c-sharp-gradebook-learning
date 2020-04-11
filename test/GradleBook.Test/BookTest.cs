using System;
using Xunit;

namespace GradleBook.Test
{
    public class BookTest
    {
        [Fact]
        public void BookTestAverangeGrade()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.65);
            book.AddGrade(47.35);
            book.AddGrade(95.05);

            // Act
            var averange = book.AverangeGrade();

            // Assert
            Assert.Equal(77.35, averange);
        }

        [Fact]
        public void BookTestHighGrade()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.65);
            book.AddGrade(47.35);
            book.AddGrade(95.05);

            // Act
            var highgrade = book.HighGrade();

            // Assert
            Assert.Equal(95.05, highgrade);
        }

        [Fact]
        public void BookTestLowGrade()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.65);
            book.AddGrade(47.35);
            book.AddGrade(95.05);

            // Act
            var lowGrade = book.LowGrade();

            // Assert
            Assert.Equal(47.35, lowGrade);
        }

        [Fact]
        public void BookTestStadistics()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.65);
            book.AddGrade(47.35);
            book.AddGrade(95.05);

            // Act
            var stadistics = book.GetStadistics();

            // Asserts
            // Assert Averange
            Assert.Equal(77.35, stadistics.Averange);
            // Assert High
            Assert.Equal(95.05, stadistics.High);
            // Assert Low
            Assert.Equal(47.35, stadistics.Low);
        }
    }
}
