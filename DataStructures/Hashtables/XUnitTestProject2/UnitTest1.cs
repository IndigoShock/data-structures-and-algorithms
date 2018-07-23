using System;
using Xunit;
using Hashtables;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Insertion()
        {
            //Act
            Hashtable ht = new Hashtable();

            //Arrange
            ht.Add(5, "time");
            ht.Add(10, "to");
            ht.Add(15, "get");
            ht.Add(20, "paid");

            var hashtableValue = ht.Find("time");

            //Assert
            Assert.Equal(5, hashtableValue);
        }

        [Fact]
        public void Contains()
        {
            //Act
            Hashtable ht = new Hashtable();

            //Arrange
            ht.Add(5, "time");
            ht.Add(10, "to");
            ht.Add(15, "get");
            ht.Add(20, "paid");

            //Assert
            Assert.True(ht.Contains("time"));
        }

        [Theory]
        [InlineData (10, "dads")]
        public void Collision1(int value, string key)
        {
            //Act
            Hashtable ht = new Hashtable();

            //Arrange
            ht.Add(5, "time");
            ht.Add(10, "to");
            ht.Add(15, "get");
            ht.Add(20, "paid");
            ht.Add(value, key);

            //Assert
            Assert.True(ht.Contains("dads"));
        }

        [Theory]
        [InlineData(12, "paid")]
        public void Collision2(int value, string key)
        {
            //Act
            Hashtable ht = new Hashtable();

            //Arrange
            ht.Add(5, "time");
            ht.Add(10, "to");
            ht.Add(15, "get");
            ht.Add(20, "paid");
            ht.Add(value, key);

            //Assert
            Assert.True(ht.Contains("paid"));
        }
    }
}
