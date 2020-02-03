namespace VezbaPatterni.FactoryMethod
{
    public class ConcreteCreator2 : ICreator
    {
        public IProduct Create()
        {
            return new Product2();
        } 
    }
}