using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desigin_Patterns.Decorate_Pattern
{
    //Concreate Implemation
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "Order To Pizza";
        }
    }

    //Base Decorator
    public class PizzaDecorator : IPizza
    {
        private IPizza _Pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _Pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            return _Pizza.GetPizzaType();
        }
    }
    /// <summary>
    /// Concrete Decator 
    /// Like Adding Extra items
    /// </summary>
    public class CheeseDecator:PizzaDecorator
    {
        public CheeseDecator(IPizza pizza):base(pizza)
        {

        }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n Extra Chesee____";
            return type;

        }

    }
    public class OnionDecator:PizzaDecorator
    {
        public OnionDecator(IPizza pizza):base(pizza)
        {

        }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n Extra Onion";
            return type;
        }
    }
    public class TomotoDecator : PizzaDecorator
    {
        public TomotoDecator(IPizza pizza) : base(pizza)
        {

        }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n Extra Onion";
            return type;
        }
    }
}
