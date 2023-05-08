using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{
    
    
        public abstract class HotDrink
        {
            public abstract string Milk
            {
                set; get;
            }
            public abstract string Sugar
            {
                set; get;
            }
            public virtual void Drink()//方法Drink()
            {
                Console.WriteLine("Drinking hotdrink!");
            }
            public abstract void AddMilk();//方法AddMilk()
            public abstract void AddSugar();
        }
        interface ICup //接口
        {
            string Color
            {
                get;
            }
            string Volume
            {
                get;
            }
            void Refill();
            void Wash();
        }
        public class CupOfCoffee : HotDrink, ICup
        {
            string milk, sugar, color, volume;
            public string BeanType
            {
                set { BeanType = value; }
                get { return BeanType; }
            }
            public override string Milk//override重写父类中的milk
            {
                set { milk = value; }
                get { return milk; }
            }
            public override string Sugar//override重写父类中的sugar
            {
                set { sugar = value; }
                get { return sugar; }
            }
            public string Color
            {
                get { return color; }
            }
            public string Volume
            {
                get { return volume; }
            }
            public override void Drink()
            {
                Console.WriteLine("Drink CupOfCoffee");
            }
            public override void AddMilk()
            {
                Console.WriteLine("Add milk to coffee!");
            }
            public override void AddSugar()
            {
                Console.WriteLine("Add sugar to coffee!");
            }
            public void Refill()
            {
                Console.WriteLine("Refill CupOfCoffee!");
            }
            public void Wash()
            {
                Console.WriteLine("Wash CupOfCoffee!");
            }
        }
        public class CupOfTea : HotDrink, ICup
        {
            string milk, sugar, color, volume;
            public string LeafType
            {
                set { LeafType = value; }
                get { return LeafType; }
            }
            public override string Milk//override重写父类中的milk
            {
                set { milk = value; }
                get { return milk; }
            }
            public override string Sugar//override重写父类中的sugar
            {
                set { sugar = value; }
                get { return sugar; }
            }
            public string Color
            {
                get { return color; }
            }
            public string Volume
            {
                get { return volume; }
            }
            public override void Drink()
            {
                Console.WriteLine("Drink CupOfTea");
            }
            public override void AddMilk()
            {
                Console.WriteLine("Add milk to tea!");
            }
            public override void AddSugar()
            {
                Console.WriteLine("Add sugar to tea!");
            }
            public void Refill()
            {
                Console.WriteLine("Refill CupOfTea!");
            }
            public void Wash()
            {
                Console.WriteLine("Wash CupOfTea!");
            }
        }
        class Test
        {
            static void AddMilk(HotDrink hd)
            {
                hd.AddMilk();
            }
            static void Drink(HotDrink hd)
            {
                hd.Drink();
            }
            static void Wash(ICup cup)
            {
                cup.Wash();
            }
            static void Main(string[] args)
            {
                CupOfCoffee coffee = new CupOfCoffee();
                AddMilk(coffee);
                Drink(coffee);
                Wash(coffee);
                CupOfTea tea = new CupOfTea();
                AddMilk(tea);
                Drink(tea);
                Wash(tea);
            }
        }
    

}
