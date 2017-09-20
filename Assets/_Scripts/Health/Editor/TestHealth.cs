using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class TestHealth
    {
		[Test]
		public void TestReturnsOneWhenCreated()
		{
			// Arrange
			Health h = new Health ();
			float expectedResult = 1;

			// Act
			float result = h.GetHealth ();

			// Assert
			Assert.AreEqual (result, expectedResult);
		}		

		[Test]
		public void TestReturnsFalseWhenAddNegativeValue()
		{
			// Arrange
			Health h = new Health ();
			float healthToAdd = -1;
			bool expectedResult = false;
			
			// Act
			bool result = h.AddHealth (healthToAdd);
			
			// Assert
			Assert.AreEqual (result, expectedResult);
		}

		[Test]
		public void TestReturnsZeroWhenKilled()
		{
			// Arrange
			Health h = new Health();
            float expectedResult = 0;

            // Act
            h.KillCharacter();
            float result = h.GetHealth();

			// Assert
			Assert.AreEqual(expectedResult, result);
		}


	}
}