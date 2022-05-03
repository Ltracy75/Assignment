var total = 0;

for (var index = 1; index <= 50; index++)
    {
    if (index % 5 == 0 || index % 7 == 0)
        {
        total = total + index;
        }



    }
    Console.WriteLine($"Total is {total}");