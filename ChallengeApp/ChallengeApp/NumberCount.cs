using System.Diagnostics.Metrics;

int number = 1999999;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] count = new int[10];

//for (int i = 0; count.length > i; i++)
//{
//    count[i] = 0;
//    console.writeline(count[i]);
//}

foreach (char letter in letters)
{
    if (letter == '0')
    {
        count[0]++;
    }
    else if (letter == '1')
    {
        count[1]++;
    }
    else if (letter == '2')
    {
        count[2]++;
    }
    else if (letter == '3')
    {
        count[3]++;
    }
    else if (letter == '4')
    {
        count[4]++;
    }
    else if (letter == '5')
    {
        count[5]++;
    }
    else if (letter == '6')
    {
        count[6]++;
    }
    else if (letter == '7')
    {
        count[7]++;
    }
    else if (letter == '8')
    {
        count[8]++;
    }
    else
    {
        count[9]++;
    }
}


for (int i = 0; count.Length > i; i++)
{
    Console.WriteLine(i + " => " + count[i]);
}