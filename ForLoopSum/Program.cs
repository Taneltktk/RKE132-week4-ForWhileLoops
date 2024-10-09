
//for (int i = 0; i < 0; i++) //i++ on sama mis i + 1
//{
//    Console.WriteLine($"i = {i}");
//}


//for (int i = 10; i > 0; i--) //i-- on sama mis i - 1
//{
//    Console.WriteLine($"i = {i}");
//}

int sum = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += i;
}
Console.WriteLine($"Total final {sum}");