using System.Text.RegularExpressions;

namespace class_car
{
    class Car{
        string name;
        string color;
        double price;
        const string CompanyName = "ECO-CYBER";
        public Car(){
            name = "Wolksvagen";
            color = "grey";
            price = 10000;
        }
        public Car(string name_obj, string color_obj, int price_obj){
            name = name_obj;
            color = color_obj;
            price = price_obj;
        }
        public void Input(){
            Console.WriteLine($"Enter the model of car,\nthen color of car\nand then price of car: ");
            name =  Convert.ToString(Console.ReadLine());
            color = Convert.ToString(Console.ReadLine());
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void Print(){
            Console.WriteLine($"model of car: {name}");
            Console.WriteLine($"color of car:{color}");
            Console.WriteLine($"price of car: {price}");
        }
        public void ChangePrice(double x){
            double percentage = 100;
            price = price - ((x*price)/percentage);
        }
        static void Main(string[] args){
            Car ford = new Car("ford","grey",7500);
            ford.Input();
            ford.ChangePrice(90);
            ford.Print();
        }

    }
}