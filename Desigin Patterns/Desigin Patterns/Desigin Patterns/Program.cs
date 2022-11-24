using Desigin_Patterns.AdpatarPattern;
using Desigin_Patterns.Decorate_Pattern;
using Desigin_Patterns.Observer;
using Desigin_Patterns.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desigin_Patterns.FactoryPattern;

namespace Desigin_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Decorate_Pattern 
            ///Mix and match extra items
            IPizza pizza = new Pizza();
            IPizza cheese = new CheeseDecator(pizza);
            IPizza onion = new OnionDecator(cheese);
            IPizza tomoto = new TomotoDecator(onion);
            Console.WriteLine(tomoto.GetPizzaType());
            Console.ReadLine();

            //Adapter
            string[,] employeesArray = new string[5, 4]
            {
                {"101","Chinna","SE","25000"},
                {"102","Rahul","SE","20000"},
                {"103","Rakhi","SSE","15000"},
                {"104","Pam","SE","48000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.WriteLine("End of Adapter");

            //observer
            Subject onePlus = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            //User Chinna will be created and user1 object will be registered to the subject
            OBSERVER user1 = new OBSERVER("Chinna", onePlus);
            OBSERVER user2 = new OBSERVER("Nashaddhi", onePlus);
            OBSERVER user3 = new OBSERVER("Haseena", onePlus);

            Console.WriteLine("One Puls  Mobile current state : " + onePlus.getAvailability());
            Console.WriteLine();
            // Now product is available
            onePlus.setAvailability("Available");

            Console.WriteLine("End of Observer");

            //singleton
            Singleton parent = Singleton.GetInstance;
            parent.PrintDetails("From Parent");
            Singleton child = Singleton.GetInstance;
            child.PrintDetails("From Child");
            Console.WriteLine("End of Singleton");

            //factory
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type____");
            }
            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("CardType:" + creditCard.GetCardType());
                Console.WriteLine("Credit Limit:" + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge:" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type____");

            }

        }
    }
}
