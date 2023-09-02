// See https://aka.ms/new-console-template for more information

// input 7 and 5

/*Output

77777
7777
777
77
7

*/

Console.WriteLine("Enter The number to be displayed:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter The initial numer in first line:");
int width = Convert.ToInt32(Console.ReadLine());

int height = width;

Console.WriteLine("Output:");

for (int row = 0; row < height; row++) 
{
    for (int column = 0; column < width; column++)
    {
        Console.Write(x);
    }
    Console.WriteLine();
    width--;
}


