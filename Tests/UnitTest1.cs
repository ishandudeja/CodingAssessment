using System;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPeopleCount()
        {
            BirthingUnit birthingUnit = new BirthingUnit();
            var people = birthingUnit.GetPeople(5);
            Assert.Equal(5, people.Count);
        }
    }
}
