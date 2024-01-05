// using System;
// class Hinhtron
// {
//     public double r;
//     public double d
//     {
//         get{return 2*r;}
//     }
//     public double S
//     {
//         get{return Math.PI*Math.Pow(r,2);}
//     }
// }
// class hinhcau: Hinhtron
// {
//     public new double S
//     {
//         get{return 4*Math.PI*Math.Pow(r,2);}
//     }
//     public double V
//     {
//         get{return (4.0/3.0)*Math.PI*Math.Pow(r,3);}
//     }

//     public void Xuat()
//     {
//     Console.WriteLine("Dien tich hinh cau = {0}",S);
//     Console.WriteLine("The tich hinh cau = {0}",V);
//     }
// }
// class hinhtru: Hinhtron
// {
//     public double H;
//     public double Chuvihinhtru
//     {
//         get{return 2*Math.PI*r;}
//     }
//     public double Dientichxungquanh
//     {
//         get{return 2*Math.PI*r*H;}
//     }
//     public double Dientichtoanphan
//     {
//         get{return 2*Math.PI*r*(r+H);}
//     }
//     public double Thetich
//     {
//         get{return Math.PI*Math.Pow(r,2)*H;}
//     }
//     public void Xuathinhtru()
//     {
//         Console.WriteLine("Chu vi hinh tru = {0}",Chuvihinhtru);
//         Console.WriteLine("Dien tich xung quanh = {0}",Dientichxungquanh);
//         Console.WriteLine("Dien tich toan phan  = {0}",Dientichtoanphan);
//         Console.WriteLine("The tich = {0}",Thetich);
//     }
// }
// class Program 
// {
//     static void Main (string [] agrs)
//     {
//         hinhcau hinh1 = new hinhcau();
//         Console.Write("Nhap ban kinh cua hinh cau: ");
//         double a = double.Parse(Console.ReadLine());
//         hinh1.r=a;
//         hinhtru hinh2 = new hinhtru();
//         Console.Write("Nhap ban kinh cua +hinh tru: ");
//         double b= double.Parse(Console.ReadLine());
//         Console.Write("Nhap chieu cao cua hinh tru: ");
//         double h= double.Parse(Console.ReadLine());
//         hinh2.r=b;
//         hinh2.H=h;
//         hinh1.Xuat();
//         hinh2.Xuathinhtru();
//     }
// }
