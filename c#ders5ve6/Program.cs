//yıldızlarla dik üçgen

/* 
for (int i=1; i<=5 ; i++)
{
    for(int j=1 ; j<=i ; j++) //satırdaki yıldız
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
 */

//ters dik üçgen
/*
for(int i=5 ; i>=1 ; i--)
{
    for(int j=1 ; j<=i ; j++) //1. satırda 1den 5e kadar yıldız , 2.satırda 1den 4e kadar... 
    {
       Console.Write("*");
    }
    Console.WriteLine();
}
*/

//baklava dilimi

/*
        int n = 5; // Baklavanın yarı yüksekliği

        // Üst üçgen
        for (int i = 1; i <= n; i++)
        {
            // Boşluklar
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Yıldızlar
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Alt üçgen
        for (int i = n - 1; i >= 1; i--)
        {
            // Boşluklar
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Yıldızlar
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
*/
//DERS 6
//dizilerde kullanıcıdan değer alma

string[] cities= new string[5];
for(int i=0 ; i<cities.Length ; i++)
{
    Console.Write($"lütfen {i+1}. şehri giriniz:");
    cities[i]= Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("-------");

for(int i=0 ; i<cities.Length ; i++)
{
    Console.WriteLine(cities[i]);
}
