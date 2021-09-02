
namespace FactoryMethod
{
    public class PizzaCancha : Pizza
    {
        public PizzaCancha(string origen)
        {
            _descripcion = "cancha";
            _origen = origen;
        }
    }
}