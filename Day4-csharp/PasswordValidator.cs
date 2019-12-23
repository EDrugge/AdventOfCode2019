using System;
using FluentAssertions;
using Xunit;

namespace Day4_csharp
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            var isValid = false;

            char? previousChar = null;
            int currentStreakOfAdjecentDigits = 1;
            bool hasAGroupOfTwoAdjecentDigits = false;
            foreach (var digit in password)
            {
                if (previousChar != null)
                {
                    if (previousChar == digit)
                    {
                        currentStreakOfAdjecentDigits++;
                    }
                    else
                    {
                        if (currentStreakOfAdjecentDigits == 2)
                        {
                            hasAGroupOfTwoAdjecentDigits = true;
                        }

                        currentStreakOfAdjecentDigits = 1;
                    }

                    if (Convert.ToInt32(previousChar.Value) > Convert.ToInt32(digit))
                    {
                        return false;
                    }
                }
                previousChar = digit;
            }

            if (currentStreakOfAdjecentDigits == 2)
            {
                hasAGroupOfTwoAdjecentDigits = true;
            }

            return hasAGroupOfTwoAdjecentDigits;
        }
    }

    public class PasswordValidatorTests
    {
        [Theory]
        [InlineData("123456", false)]
        [InlineData("122456", true)]
        public void MustHaveAtLeastTwoAdjacentDigits(string password, bool isValid)
        {
            var sut = new PasswordValidator();

            sut.IsValid(password).Should().Be(isValid);
        }

        [Theory]
        [InlineData("123444", false)]
        [InlineData("111122", true)]
        [InlineData("112233", true)]
        public void MustHaveAtLeastOneGroupWithOnlyTwoAdjacentDigits(string password, bool isValid)
        {
            var sut = new PasswordValidator();

            sut.IsValid(password).Should().Be(isValid);
        }

        [Theory]
        [InlineData("223450", false)]
        [InlineData("112234", true)]
        public void DigitsShouldNeverDecrease(string password, bool isValid)
        {
            var sut = new PasswordValidator();

            sut.IsValid(password).Should().Be(isValid);
        }
    }
}