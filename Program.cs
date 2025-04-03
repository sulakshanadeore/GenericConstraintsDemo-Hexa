using StudyGenericConstraintsLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        GenericClass<string,string> emp=new GenericClass<string,string>();
        emp.Msg = "Welcome";
        Employee emp1=new Employee();
        emp1.Name = "Akshay";
        emp1.City = "Pune";
        
        Employee emp2=new Employee();
        emp2.Name = "Smita";
        emp2.City = "Mumbai";

        emp.GenericMethod(emp.Msg,emp2.City, emp2.Name);
        Console.WriteLine("-------------");
        emp.GenericMethod(emp.Msg, emp1.City, emp1.Name);

        GenericClass1<float> objgen = new GenericClass1<float>();
        objgen.Msg = 1.33f;
        objgen.GenericMethod(3.14f);


        //GenericClass<string> gc=new GenericClass<string>();
        //gc.Msg = "Welcome here";
        //gc.GenericMethod("Hello", "World");
    }
}