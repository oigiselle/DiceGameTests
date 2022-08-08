using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using DiceRoller.Models;

namespace DieTests
{
    [TestClass]
    public class DieTests
    {
        [TestMethod]
        public void DieNotNull()
        {
            Die d = new Die();
            d.Should().NotBeNull();
        }
    }
}
