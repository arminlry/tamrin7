//armin liryaee
//tamrin7
using System.Globalization;

List<Student> students = new List<Student>();
StreamReader sr = new StreamReader(@"C:\Users\Persian\Desktop\vs s\tamrin7\name.txt");
while (!sr.EndOfStream)
{
    var line = sr.ReadLine();
    Student student = new Student();
    student.Fname = line.Split(',')[0];
    student.Lname = line.Split(',')[1];
    student.pishrafte1 = Convert.ToDouble(line.Split(',')[2]);
    student.pishrafte2 = Convert.ToDouble(line.Split(',')[3]);
    student.sheygaraei = Convert.ToDouble(line.Split(',')[4]);
    student.systemamel = Convert.ToDouble(line.Split(',')[5]);
    student.algoritm = Convert.ToDouble(line.Split(',')[6]);
    student.riazi = Convert.ToDouble(line.Split(',')[7]);
    student.kargah = Convert.ToDouble(line.Split(',')[8]);
    student.tarbiatbadani = Convert.ToDouble(line.Split(',')[9]);
    student.zabankhareji = Convert.ToDouble(line.Split(',')[0xA]);
    student.tafsir = Convert.ToDouble(line.Split(',')[0xB]);

    students.Add(student);
}
do
{
    Console.WriteLine("gozine mored nazar ra vared konid(adad aval har gozine)");
    Console.WriteLine("1- miangin kole nomarat har daneshjo ");
    Console.WriteLine("2- miangin dorus 2 setare");
    Console.WriteLine("3- miangin dorus 1 setare");
    Console.WriteLine("4- miangin dorus 0 setare");
    Console.WriteLine("5- taein nomarat aval har daneshjo ");
    Console.WriteLine("6- namayesh nam va har 4 noe moadel");
    Console.WriteLine("7- namayesh be tartib moadel kol");
    Console.WriteLine("8- namayesh be tartib moadel dorus**");
    Console.WriteLine("9- namayesh be tartib moadel dorus*");
    Console.WriteLine("10- namayesh be tartib moadel dorus");
    Console.WriteLine("11- namayesh be surat grade");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 1)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.TotalAveragekol()); }
    }
    else if (x == 2)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.TotalAveragedorus2setare()); }
    }
    else if (x == 3)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.TotalAveragedorus1setare()); }
    }
    else if (x == 4)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.TotalAveragedorus()); }
    }
    /* else if (x == 5)
     {
         foreach (var student in students)
         { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.taeinadadaval()); }
          }
    */
    else if (x == 6)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + "\n" + "moadel kole:" + student.TotalAveragekol() + "\n" + "moadel dorus**:" + student.TotalAveragedorus2setare() + "\n" + "moadel dorus*:" + student.TotalAveragedorus1setare() + "\n" + "moadel dorus:" + student.TotalAveragedorus()); }
    }
    else if (x == 7)
    {
        foreach (var student in students)

            Console.WriteLine(student.Fname + " " + student.Lname + " " + student.sortmianginkol(student.TotalAveragekol()));
    }
    else if (x == 8)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.sortmiangindorus2()); }
    }
    else if (x == 9)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.sortmiangindorus1()); }
    }
    else if (x == 10)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.sortmiangindorus()); }
    }
    else if (x == 11)
    {
        foreach (var student in students)
        { Console.WriteLine(student.Fname + " " + student.Lname + " " + student.GradeExp(student.TotalAveragekol())); }

    }


    Console.WriteLine("darkhast digari darid?(y=bale)");
} while (Console.ReadLine() == "y");


class Student
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public double pishrafte1 { get; set; }
    public double pishrafte2 { get; set; }
    public double sheygaraei { get; set; }
    public double systemamel { get; set; }
    public double algoritm { get; set; }
    public double riazi { get; set; }
    public double kargah { get; set; }
    public double tarbiatbadani { get; set; }
    public double zabankhareji { get; set; }
    public double tafsir { get; set; }
    public double TotalAveragekol()
    { return ((riazi * 2 + zabankhareji * 2 + kargah + tarbiatbadani + tafsir + systemamel * 3 + algoritm * 3 + pishrafte1 * 3 + pishrafte2 * 3 + sheygaraei * 3) / 22); }
    public double TotalAveragedorus2setare()
    { return ((pishrafte1 * 3 + pishrafte2 * 3 + sheygaraei * 3) / 9); }
    public double TotalAveragedorus1setare()
    { return ((systemamel * 3 + algoritm * 3) / 6); }
    public double TotalAveragedorus()
    { return ((riazi * 2 + zabankhareji * 2 + kargah + tarbiatbadani + tafsir) / 7); }


    /*public double taeinadadaval()
     {
         foreach (var pishrafte1 in Student)
             for (int i = 2; i < pishrafte1; i++)
             {
                 for (int i = 2; i <= Math.Sqrt(pishrafte1); i++)
                 {
                     if (pishrafte1 % i == 0)



                         return (taeinadadaval);
                 }
             }

     }*/

    public double sortmianginkol(double results)
    {

       // double results = TotalAveragekol();

       // Array.Sort(results);
        double averages = results;
             return averages;                    
    }

    
    public double sortmiangindorus2()
    {
        { return ((riazi * 2 + zabankhareji * 2 + kargah + tarbiatbadani + tafsir + systemamel * 3 + algoritm * 3 + pishrafte1 * 3 + pishrafte2 * 3 + sheygaraei * 3) / 22); }
    }
    public double sortmiangindorus1()
    {
        { return ((riazi * 2 + zabankhareji * 2 + kargah + tarbiatbadani + tafsir + systemamel * 3 + algoritm * 3 + pishrafte1 * 3 + pishrafte2 * 3 + sheygaraei * 3) / 22); }
    }
    public double sortmiangindorus()
    {
        { return ((riazi * 2 + zabankhareji * 2 + kargah + tarbiatbadani + tafsir + systemamel * 3 + algoritm * 3 + pishrafte1 * 3 + pishrafte2 * 3 + sheygaraei * 3) / 22); }
    }
    public char GradeExp(double student) => TotalAveragekol() switch
    {
        double n when n > 20 || n < 0 => throw new ArgumentOutOfRangeException(),
        >= 17 => 'A',                            
        >= 15 => 'B',                            
        >= 13 => 'C',                            
        >= 10 => 'D',                            
        >= 7 => 'E',                             
        >= 3 => 'F',                             
        >= 0 => 'G',                             
        _ => throw new ArgumentOutOfRangeException()
    };

}
