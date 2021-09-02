
namespace FactoryMethod
{
    public class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string origen)
        {
            _descripcion = "napolitana!";
            _origen = origen;
        }
    }
}