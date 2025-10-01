//foreach
/*
string[] cities={"milano" , "roma" , "budapeste" , "varsova"};

foreach(string x in cities)
{
    Console.WriteLine(x);
}
*/

//foreach listlerle birlikte çalışabilir.
/*
List<int> numbers= new List<int>()
{
    1,2,3,4,5
};

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
*/

/*
Console.WriteLine("sınıfınızda kaç öğrenci var:");
int studentCount=int.Parse(Console.ReadLine());

 //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
string[] studentNames= new string[studentCount];
double[] studentExamAvg= new double[studentCount];

for(int i=0; i<studentCount ; i++)
{
    Console.Write($"{i+1}. öğrencinin ismini giriniz.");
    studentNames[i] = Console.ReadLine();

    double totalExamResult=0;

    //her öğrenci için 3 sınav notu girişi

    for (int j=0 ; j<3 ; j++)
    {
        Console.Write($"{studentNames[i]} isimli  öğrencinin {j+1}. sınav notunu giriniz:");
        double value=double.Parse(Console.ReadLine());
        totalExamResult+= value;
    }
    studentExamAvg[i]= totalExamResult/3;
}
for(int i=0; i<studentCount ; i++)
{
    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

    if(studentExamAvg[i]>=50)
    {
        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
    }
    else
    {
        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
    }
}  
*/

//DERS 8

// geriye değer döndürmeyen string parametreli metotlar

void CustomerCard(string name , string surname)
{
    Console.WriteLine("Müşteri: " + name + " " + surname);
}
CustomerCard("Mehmet" , "Yıldız");
CustomerCard("Ayşe" , "Kaya");

Console.Read();

// geriye değer döndürmeyen int parametreli metotlar

void Sum(int number1 , int number2 , int number3)
{
    int result= number1 + number2 + number3;
    Console.WriteLine(result);
}
Sum(4,5,6);

// geriye değer döndüren metotlar

string StudentCard()
{
    string name= "Ali";
    string surname= "Kaya";
    return name + " " + surname;
}
Console.WriteLine(StudentCard());

// geriye değer döndüren string parametreli metotlar

string countryCard(string countryName , string capital)
{
    string cardInfo="ülke:" + countryName + " - başkent: " + capital;
    return cardInfo;
}
string x,y;
Console.Write("ülke adını giriniz:");
x=Console.ReadLine();

Console.Write("başkemti giriniz:");
y=Console.ReadLine();

// geriye değer döndüren int parametreli metotlar

string examResult(string student , int exam1 , int exam2 , int exam3);
int result=(exam1 + exam2 + exam3) /3;
if(result>=50)
{
    return "öğrenci sınavı geçti."
}
    else 
    {
       return "öğrenci başarısız oldu." 
    }
Console.WriteLine(examResult("Ali" , 25 , 41 , 85));
Console.WriteLine(examResult("Ayşe" , 30 , 60 , 90));
