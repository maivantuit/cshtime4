using System;

namespace Cop12_BaiTaiLan4
{
    interface IPoint
    {
        int Point
        {            
            get;            
        }
        int PointNumber();        
    }
    public abstract class Figure : IPoint
    {
        // fields:
        protected int height;
        protected int weight;
        protected string name;        
        // constructors:
        public Figure() { }
        public Figure(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }
        public Figure(int height, int weight, string name) : this(height, weight)
        {
            this.name = name;
        }
        // methods input and output:
        public virtual void Input()
        {
            Console.Write("Input height: ");
            height = Int32.Parse(Console.ReadLine());
            Console.Write("Input weight: ");
            weight = Int32.Parse(Console.ReadLine());
            Console.Write("Input name figure: ");
            name = Console.ReadLine();
        }        
        public virtual void Output()
        {            
            Console.WriteLine("\n{0,-10} {1,-10} {2,-10} {3, -10}", name, height, weight, TinhDienTich());
        }
        // properties:
        public int ChieuDai
        {
            set
            {
                this.height = value;
            }
            get
            {
                return height;
            }
        }
        public int ChieuRong
        {
            set
            {
                this.weight = value;
            }
            get
            {
                return weight;
            }
        }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }

        public int Point => throw new NotImplementedException();

        // methods:
        public virtual void NameHinh()
        {
            Console.WriteLine("Name figure " + name);
        }
        public abstract double TinhDienTich();

        public int PointNumber()
        {
            throw new NotImplementedException();
        }
    }
    public class Rectagle : Figure
    {
        public Rectagle()
        {
        }
        public Rectagle(int height, int weight, string name) : base(height, weight, name)
        {

        }
        public override void NameHinh()
        {
            base.NameHinh();
        }
        public override void Input()
        {
            base.Input();
        }
        public override void Output()
        {
            base.Output();
        }
        public override double TinhDienTich()
        {
            return height * weight;
        }
    }
    public class Square : Figure
    {
        public Square()
        {
        }
        public Square(int height, int weight, string name) : base(height, weight, name)
        {

        }
        public override void NameHinh()
        {
            base.NameHinh();
        }
        // methods FillSquare:
        public void FillSquare()
        {
            //Console.WriteLine();
        }
        public override void Input()
        {
            Console.Write("Input weight: ");
            weight = Int32.Parse(Console.ReadLine());
            Console.Write("Input name figure: ");
            name = Console.ReadLine();
        }
        public override void Output()
        {
            Console.WriteLine("\n{0,-10} {1,-10} {2,-10}", name, weight, TinhDienTich());
        }
        public override double TinhDienTich()
        {
            return Math.Pow(weight,2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectagle[] listRec = null;
            Square[] listSqu = null;
            int n; // number figure
            int luachon = 0;
            do
            {
                Console.WriteLine("-------------------C#-------------------");
                Console.WriteLine("1. Create instances(obj) Rectagle and Square");
                Console.WriteLine("2. Create list rectagle figure and display info");
                Console.WriteLine("3. Create list square figure and display info");
                Console.WriteLine("4. Exit");
                Console.Write("Please, input choice: ");
                luachon = Int32.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:

                        Rectagle r1 = new Rectagle();
                        r1.ChieuDai = 5;
                        r1.ChieuRong = 10;
                        r1.Name = " is Rectagle";
                        r1.NameHinh();
                        double S1 = r1.TinhDienTich();
                        Console.WriteLine("Area of Rectagle: " + S1);

                        Square s1 = new Square();                        
                        s1.ChieuRong = 15;
                        s1.Name = "is Square";
                        s1.NameHinh();
                        double S2 = s1.TinhDienTich();
                        Console.WriteLine("Area of Square: " + S2);
                        break;

                    case 2:
                        Console.Write("Input number rectagle figure: ");
                        n = Int32.Parse(Console.ReadLine());
                        listRec = new Rectagle[n];// cấp phát động n elements rectagle
                        for (int i = 0; i < listRec.Length; i++)
                        {
                            Console.WriteLine("Input rectagle number {0}: ", i+1 );
                            listRec[i] = new Rectagle();
                            listRec[i].Input();
                        }
                        Console.WriteLine("---Rectagles after input: ");
                        Console.WriteLine("\n{0,-10} {1,-10} {2,-10} {3, -10}", "Name", "Height", "Weight", "Area");
                        for (int i = 0; i < listRec.Length; i++)
                        {                            
                            listRec[i].Output();
                        }
                        break;
                    case 3:
                        Console.Write("Input number square figure: ");
                        n = Int32.Parse(Console.ReadLine());
                        listSqu = new Square[n];// cấp phát động n elements square
                        for (int i = 0; i < listSqu.Length; i++)
                        {
                            Console.WriteLine("Input square number {0}: ", i+1 );
                            listSqu[i] = new Square();
                            listSqu[i].Input();
                        }
                        Console.WriteLine("---Squares after input: ");
                        Console.WriteLine("\n{0,-10} {1,-10} {2,-10}", "Name", "Weight", "Area");
                        for (int i = 0; i < listSqu.Length; i++)
                        {                            
                            listSqu[i].Output();
                        }
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                }
            } while (luachon != 4);


            Console.ReadLine();
        }
    }
}
