namespace person{
    class Person{
        private string name;
        private DateTime date_of_birth;
        public string Name{
            get {return name;}
        }
        public DateTime Year{
            get {return date_of_birth;}
        }
        public Person(){
            name = "Unknown";
            date_of_birth = DateTime.MinValue;
        }
        public Person(string obj_name, DateTime obj_year){
            name = obj_name;
            date_of_birth = obj_year;
        }
        public  int Age(){
            DateTime cuurent_date = DateTime.Now;
            return cuurent_date.Year - date_of_birth.Year;
        }
        public void ChangeName(string new_name){
            name = new_name;
        }
        public void Input(){
            Console.Write("Enter the name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your date of birth: ");
            date_of_birth = Convert.ToDateTime(Console.ReadLine());
        }
        public void Output(){
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Year of birth: {date_of_birth}");
            Console.WriteLine($"Age of {name}: {Age()}");
        }
        


    }
    class Program{
        static void Main(string[] args){
            Person Alex = new Person("Oleksandr", DateTime.Parse("2006-03-08"));
            Person Igor = new Person("Igor", DateTime.Parse("1989-03-01"));
            Person Andrew = new Person();
            Person Vika = new Person();
            Person Sofia = new Person("Sofia", DateTime.Parse("2009-09-27"));
            Person Max = new Person("Max", DateTime.Parse("2013-08-24"));

            
            
            

            Person[] arr = {Alex,Igor,Andrew,Vika,Sofia,Max};
            foreach(Person personality in arr){
                if (personality.Age() < 16){
                    personality.ChangeName("Very Young");
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Same name: {arr[i].Name}");
                        arr[i].Output();
                        arr[j].Output();
                    }
                }
            }

        }
    }
 }
