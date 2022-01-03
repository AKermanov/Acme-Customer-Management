namespace ACM.BuisnessLogic.Tests
{
    using NUnit.Framework;
    using ACM.BusinessLogic;
    public class CustomerTests
    {
        [Test]
        public void FullNameTestValid()
        {
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            var expected = "Baggins, Bilbo";
            var actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameFirstNameEmpty()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
            };

            var expected = "Baggins";
            var actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FullNameLastNameEmpty()
        {
            var customer = new Customer
            {
                FirstName = "Bilbo"
            };

            var expected = "Bilbo";
            var actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaticTest()
        {
            var customer1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount++;

            var customer2 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount++;

            var customer3 = new Customer
            {
                FirstName = "Marin"
            };
            Customer.InstanceCount++;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [Test]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}