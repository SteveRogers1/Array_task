bool flag;
int lines = 0;
int columns = 0;
int sum = 0;

do
{
    try
    {
        Console.WriteLine("Enter array number of lines: ");
        lines = Convert.ToInt32(Console.ReadLine());
        flag = true;
    }
    catch
    {
        flag = false;
        Console.WriteLine("Error!");
    }
}
while (flag != true);

do
{
    try
    {
        Console.WriteLine("Enter array number of columns: ");
        columns = Convert.ToInt32(Console.ReadLine());
        flag = true;
    }
    catch
    {
        flag = false;
        Console.WriteLine("Error!");
    }
}
while (flag != true);

int[,] array = new int[lines, columns];

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {       
        do
        {
            try
            {
                Console.WriteLine("Enter element value " + i + "," + j);
                array[i, j] = Convert.ToInt32(Console.ReadLine());
                flag = true;
            }
            catch
            {
                flag = false;
                Console.WriteLine("Error!");
            }
        }
        while (flag != true);
    }
}

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write("{0,3}", array[i, j] + "\t");
    }
    Console.WriteLine();
}

//diagonal sum
for (int i = 0; i < lines; i++)
{
        sum += array[i, i]; 
}
Console.WriteLine("diagonal sum = " + sum);
