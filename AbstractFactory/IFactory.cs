namespace Assignment2.AbstractFactory
{
    public interface IFactory
    {
        public IAnimal CreateAnimal(string name);
    }
}