namespace StudyGenericConstraintsLibrary
{
    //Generic constraint the class validates the type using "where T:typename"
    public class GenericClass1<T> where T :struct
    {
        public T Msg;

        public void GenericMethod(T p1)
        {
            Console.WriteLine($"Message = {Msg} ");
            Console.WriteLine($"First Parameter= {p1}");
            


        }

    }



    public class GenericClass<T,X> where T: class where X : class
    {
     public T Msg;

        public void GenericMethod(T p1, X p2,X p3)
        {
            Console.WriteLine($"Message = {Msg} ");
            Console.WriteLine($"First Parameter= {p1}");
            Console.WriteLine($"Second Parameter= {p2}");
            Console.WriteLine($"Third Parameter= {p3}");


        }

    }
}
