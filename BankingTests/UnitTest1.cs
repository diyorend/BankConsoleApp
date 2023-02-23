using BankLibrary;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }
        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Diyor", 20000);

            Assert.Throws<InvalidOperationException>(
                () => { account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw"); }
                );
        }
        [Fact]
        public void NeedMoneyToStart()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("Diyor", -51)
                );
        }
    }
}