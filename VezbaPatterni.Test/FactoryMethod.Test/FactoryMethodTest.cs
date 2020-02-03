using FluentAssertions;
using NUnit.Framework;
using VezbaPatterni.FactoryMethod;

namespace VezbaPatterni.Test.FactoryMethod.Test
{
    [TestFixture]
    public class FactoryMethodTest
    {

        [Test]
        public void ClientTest()
        {
            var clientApp = new ClientApp(new ConcreteCreator1());
            clientApp.Operation();
            
            
            var clientApp2 = new ClientApp(new ConcreteCreator2());
            clientApp2.Operation();

            clientApp.Should().NotBeNull();


        }


    }
}