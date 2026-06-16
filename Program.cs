namespace Class_0616_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel hander = new MyDel(MyMath.Add);
            hander += new MyDel(MyMath.Sub);
            hander += new MyDel(MyMath.Mul);
            hander += new MyDel(MyMath.Div);
            hander -= new MyDel(MyMath.Add);
            hander -= new MyDel(MyMath.Sub);

            hander(20,30);
            Console.WriteLine(MyMath.str);

            MyMath.str = "";
            hander(15,14);
            Console.WriteLine(MyMath.str);
        }
    }
}
