using System ; 

namespace Static_class_and_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan sayisi     : {0}" , employee.Thenumberofemployee) ;
 
            employee employee1 = new employee ("Baris", "Demirkap" , "Test Team") ; 

            Console.WriteLine("Calisan sayisi     : {0}" , employee.Thenumberofemployee) ;
            employee employee1 = new employee ("Deniz", "Arda" , "Test Team") ; 
            employee employee1 = new employee ("Ismail", "Canatan" , "Test Team") ; 

            Console.WriteLine("toplama islemi sonucu    :{0}", operations.Sum(100,200)) ;
            Console.WriteLine("Cikarma islemi sonucu    :{0}", operations.Subtraction(100,200)) ;




        }
    }

    class employee
    {
        private static int thenumberofemployee ;

        public static int Thenumberofemployee { get => thenumberofemployee; set => thenumberofemployee = value; }

        private string Name;
        private string SurName;
        private string Department;


        static employee () 
        {
           Thenumberofemployee=0 ;

        }
        public employee(string name, string surName, string department)
        {
            this.Name = name ;
            this.SurName = surName ;
            this.Department = department ;
            thenumberofemployee++ ;

        }



    }

    static class operations
    {
        public static long Sum (int number1, int number2) 
        {
            return number1+number2 ;

        }
        public static long Subtraction (int number1, int number2) 
        {
            return number1-number2 ;

        }

    }
}