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

        [Fact]
        public void TestGetMarried()
        {
            BirthingUnit birthingUnit = new BirthingUnit();

            string fullName = birthingUnit.GetMarried(new People("Bob"), "test");
            Assert.Equal("Bob", fullName);

            string fullName = birthingUnit.GetMarried(new People("Bob"), "Trump");
            Assert.Equal("Bob Trump", fullName);

        }
        [Fact]
        public void TestIsGetBobOlderThen30()
        {
            BirthingUnit birthingUnit = new BirthingUnit();
            var people = birthingUnit.GetPeople(5);
            var bobMan = birthingUnit.GetBobs(true);
            bool isBobOlderThen30 = true;
            foreach (People bob in bobMan)
            {
                int age = DateTime.Now.Year - bob.DOB.Year;
                if (age < 30)
                { isBobOlderThen30 = false; }
            }

            Assert.True(isBobOlderThen30);

        }
    }
}
