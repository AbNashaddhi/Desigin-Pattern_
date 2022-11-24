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
        private IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
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
    //Extra Onion with order
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
    /// <summary>
    
    /// </summary>
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
