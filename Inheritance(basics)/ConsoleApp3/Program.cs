// See https://aka.ms/new-console-template for more information

namespace Shapes{
    public abstract class Shape{
        public abstract double  CalcualteArea();
        public abstract double  CalcualtePerimeter();
    }
    class Circle(double rad):Shape{
        double Radius {get;} = rad;
        public override double CalcualteArea()
        {
            return (Radius*Radius)*Math.PI;
        }
        public override double CalcualtePerimeter()
        {
            return 2*(Math.PI * Radius);
        }
    }
    class Rectangle(double w, double h): Shape{
        double Width{get;} = w;
        double Height{get;} = h;
        public override double CalcualteArea()
        {
            return Width*Height;
        }
        public override double CalcualtePerimeter()
        {
            return(Width + Height) * 2;
        }
    }
    class Program{
        static void Main(string[] args){
            Circle c1 = new Circle(12);
            c1.CalcualteArea();
            c1.CalcualtePerimeter();
            
            Rectangle r1 = new Rectangle(10,10);
            Console.Write(r1.CalcualteArea());
            r1.CalcualtePerimeter();
        }
    }

}
namespace Fruits{
    public abstract class Fruit{
        public string Name;
        public Fruit(string name){
            Name = name;
        }
        public abstract string Describe();
    }
    class Apple:Fruit{
        public string Variety;
        public string Color;
        public Apple(string variety,string color): base("Apple"){
            Variety = variety;
            Color = color;
        }
        public override string Describe()
        {
            return $"This is a {Color} {Variety} Apple.";
        }
    }
    class Pear:Fruit{
        public string Variety;
        public string Color;
        public Pear(string variety, string color):base("Pear"){
            Variety = variety;
            Color = color;
        }
        public override string Describe()
        {
            return $"This is a {Color} {Variety} Apple.";
        }
    }
}
namespace Animals{
    abstract public class Animal{
        public float Weight {get;set;}
        public string Color {get;set;}
        public Animal(float weight, string color){
            this.Weight = weight;
            this.Color = color;
        }
        public abstract string MakeSound();
    }
    public abstract class AnimalWithTail:Animal{
        public float TailLength{get;set;}
        public AnimalWithTail(string color, float weight, float tailLength):base(weight,color){
            this.TailLength = tailLength;
        }
    }
    public class Cat:AnimalWithTail{
        public Cat(string color, float weight, float tailLength):base(color,weight,tailLength){}
        private string Purr(){
            return "purrrrrrrr";
        }
        private string Meow(){
            return "meow";
        }
        public override string MakeSound()
        {
            string pr = Purr();
            string mw = Meow();
            return pr + mw;
        }
        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
    public class Dog:AnimalWithTail{
        public Dog(string color, float weight, float tailLength): base(color,weight,tailLength){}
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
}