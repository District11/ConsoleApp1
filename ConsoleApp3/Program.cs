
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] arg)
        {
            Figure triangle = new Figure(new Pointer(3,5, "A"), new Pointer(3, 10, "B"), new Pointer(5,6,"C"));
            triangle.PerimetrCalculet();
            Figure square = new Figure(new Pointer(4,7, "A"), new Pointer(6,7,"B"), new Pointer(7,8,"C"), new Pointer(8,9,"D"));
            square.PerimetrCalculet();
            Figure pentagon = new Figure(new Pointer(2,3, "A"), new Pointer(3,6,"B"), new Pointer(5,5,"C"), new Pointer(6,9,"D"), new Pointer(4,6,"E"));
            pentagon.PerimetrCalculet();
        }
    }
}