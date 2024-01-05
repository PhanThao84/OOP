using System;
class Hinhhoc
{
    public double a,b,c,cd,cr,r,canh;
    public virtual void Chuvi()
    {
        Console.WriteLine("Chu vi : ");
    }
    public virtual void Dientich()
    {
        Console.WriteLine("Dien tich : ");
    }
}
class Hinhchunhat:Hinhhoc
{
    public override void Chuvi()
    {
         Console.WriteLine("Chu vi hcn : {0}",(cd+cr)*2);
    }
     public override void Dientich()
    {
        Console.WriteLine("Dien tich hcn : {0}",cd*cr);
    }
}
class Hinhtron:Hinhhoc
{
    public override void Chuvi()
    {
         Console.WriteLine("Chu vi hinhtron : {0}",2*Math.PI*r);
    }
     public override void Dientich()
    {
        Console.WriteLine("Dien tich hinhtron : {0}",Math.PI*Math.Pow(r,2));
    }
}
class Hinhtamgiac:Hinhhoc
{
    public override void Chuvi()
    {
         Console.WriteLine("Chu vi hinhtamgiac : {0}",a+b+c);
    }
     public override void Dientich()
    {
        double p = (a+b+c)/2;
        Console.WriteLine("Dien tich hinhtamgiac : {0}",Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
    }
}
class Hinhvuong:Hinhhoc
{
    public override void Chuvi()
    {
         Console.WriteLine("Chu vi hinhvuong : {0}",canh*4);
    }
     public override void Dientich()
    {
        Console.WriteLine("Dien tich hinhvuong : {0}",canh*canh);
    }
}
class Program 
{
    static void Main(string[] agrs)
    {
        Hinhchunhat hcn = new Hinhchunhat();
        Hinhtron ht1 = new Hinhtron();
        Hinhtamgiac tg = new Hinhtamgiac();
        Hinhvuong hv1 = new Hinhvuong();
        Console.Write("Nhap chieu dai hcn: ");
        double cd1 = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong hcn: ");
        double cr1 = double.Parse(Console.ReadLine());
        hcn.cd = cd1;
        hcn.cr=cr1;
        Console.Write("Nhap canh thu 1 cua tam giac : ");
        double a1 = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh thu 2 cua tam giac : ");
        double a2 = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh thu 3 cua tam giac : ");
        double a3 = double.Parse(Console.ReadLine());
        tg.a=a1;
        tg.b=a2;
        tg.c=a3;
        Console.Write("Nhap canh cua hinh vuong : ");
        double canh1 = double.Parse(Console.ReadLine());
        hv1.canh=canh1;
        Console.Write("Nhap ban kinh cua hinh tron: ");
        double r1= double.Parse(Console.ReadLine());
        ht1.r=r1;
        hcn.Chuvi();
        hcn.Dientich();
        ht1.Chuvi();
        ht1.Dientich();
        tg.Chuvi();
        tg.Dientich();
        hv1.Chuvi();
        hv1.Dientich();
    }
}