using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class HotelGuestSystemTests
    {
        private HotelGuestSystem hotel;

        [SetUp]
        public void SetUp()
        {
            hotel = new HotelGuestSystem();
        }

        [Test]
        public void Test_Constructor_CheckInitialEmptyGuestCollectionAndCount()
        {
            // Assert
            Assert.That(hotel.GuestsCount, Is.EqualTo(0));
            CollectionAssert.IsEmpty((hotel.GetAllGuests()));
        }

        [Test]
        public void Test_RegisterGuest_ValidGuestName_AddNewGuest()
        {
            // Arrange
            string input = "New Guest";
            List<string> expected = new List<string>() { "New Guest" };

            // Act
            hotel.RegisterGuest(input);

            // Assert
            CollectionAssert.AreEqual(expected, (hotel.GetAllGuests()));
            Assert.That(hotel.GetAllGuests(), Is.Not.Empty);
            Assert.That(hotel.GetAllGuests().Count, Is.EqualTo(1));
        }

        [TestCase("")]
        [TestCase("   ")]
        [TestCase(null)]
        public void Test_RegisterGuest_NullOrEmptyGuestName_ThrowsArgumentException(string input)
        {
            // Arrange
            List<string> expected = new List<string>() { "New Guest" };

            // Act & Assert
            Assert.That(() => hotel.RegisterGuest(input), Throws.TypeOf<ArgumentException>());
            var ex = Assert.Throws<ArgumentException>(() => hotel.RegisterGuest(input));
            Assert.That(ex.Message, Is.EqualTo("Guest name cannot be empty or whitespace."));
        }

        [Test]
        public void Test_RemoveGuest_ValidGuestName_RemoveFirstGuestName()
        {
            // Arrange
            string input1 = "New Guest";
            string input2 = "Second Guest";
            List<string> expected = new List<string>() { "Second Guest" };
            hotel.RegisterGuest(input1);
            hotel.RegisterGuest(input2);

            // Act
            hotel.RemoveGuest(input1);

            // Assert
            CollectionAssert.AreEqual(expected, (hotel.GetAllGuests()));
            Assert.That(hotel.GetAllGuests().Count, Is.EqualTo(1));
            Assert.That(hotel.GetAllGuests(), Is.Not.Empty);
        }

        [TestCase("")]
        [TestCase("   ")]
        [TestCase(null)]
        public void Test_RemoveGuest_NullOrEmptyGuestName_ThrowsArgumentException(string remove)
        {
            string add = "New Guest";
            List<string> expected = new List<string>() { };
            hotel.RegisterGuest(add);

            // Act & Assert
            Assert.That(() => hotel.RemoveGuest(remove), Throws.TypeOf<ArgumentException>());
            var ex = Assert.Throws<ArgumentException>(() => hotel.RemoveGuest(remove));
            Assert.That(ex.Message, Is.EqualTo("Guest not found in the system."));
        }
            
        [Test]
        public void Test_GetAllGuests_RegisteredAndRemovedGuests_ReturnsExpectedGuestCollection()
        {
            // Arrange
            string input1 = "New Guest";
            string input2 = "Second Guest";
            string input3 = "Third Guest";
            string input4 = "Fourth Guest";
            string input5 = "Fifth Guest";
            List<string> expected = new List<string>() { "New Guest", "Third Guest", "Fifth Guest" };

            // Act
            hotel.RegisterGuest(input1);
            hotel.RegisterGuest(input2);
            hotel.RegisterGuest(input3);
            hotel.RegisterGuest(input4);
            hotel.RegisterGuest(input5);
            hotel.RemoveGuest(input2);
            hotel.RemoveGuest(input4);

            // Assert
            CollectionAssert.AreEqual(expected, (hotel.GetAllGuests()));
            Assert.That(hotel.GetAllGuests().Count, Is.EqualTo(3));
            Assert.That(hotel.GetAllGuests(), Is.Not.Empty);
        }
    }
}

