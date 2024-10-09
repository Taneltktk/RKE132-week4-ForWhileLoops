
//While tsükkel kestab nii kaua kuni muutuja väärtus on kas õige või vale vastavalt soovitule.

Random random = new Random();
int cpuRandom;

bool loopActive = true; //bool = true/false

while (loopActive)
{
    cpuRandom=random.Next(1, 4);
    //Console.WriteLine($"Cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess! Enter a number 1 - 3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("You won't get lucky twice, pal!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Way off, try again!");
    }
}
Console.WriteLine("Tuleb minna, kartulid on vaja üles võtta. Nägens!");