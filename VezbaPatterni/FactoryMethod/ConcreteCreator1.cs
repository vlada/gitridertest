namespace VezbaPatterni.FactoryMethod
{
    public interface ICreator
    {
        IProduct Create();
    }

    public class ConcreteCreator1 : ICreator
    {
        public IProduct Create()
        {
            return new Product1();
        } 
    }
}