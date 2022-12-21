Console.WriteLine("Введите целое натуральное число");
string chislovstroke = Console.ReadLine();
double[] chislo = new double[chislovstroke.Length];
int n = int.Parse(chislovstroke);
int i = 0;
while(n>1)
{
    chislo[i] = n%10;
    n = n/10;
    i++;
}
static void vuvod(double[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+"; ");
    }
    Console.WriteLine(array[array.Length-1]);
}
vuvod(chislo);
static double[] umnojenie(double[] array)
{
    Console.WriteLine("Введите число k");
    double k = double.Parse(Console.ReadLine());
    for(int j = 0; j < array.Length; j++)
    {
        array[j] = array[j] *k;
    }
    return array;
}
vuvod(umnojenie(chislo));
static double srednee(double[] array)
{
    double s = 0;
    for(int j = 0; j < array.Length; j++)
    {
        s = s + array[j];
    }
    s = s/array.Length;
    return s;
}
Console.WriteLine(srednee(chislo));
static double summ(double[] array)
{
    double sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine(summ(chislo));
static double[] changeposition(double[] array)
{
    double[] copyarray = new double[array.Length];
    array.CopyTo(copyarray,0);
    if(copyarray.Length%2 == 1)
    {
        for(int i =0; i<copyarray.Length-2; )
        {
            double k = copyarray[i];
            copyarray[i] = copyarray[i+1];
            copyarray[i+1] = k;
            i = i +2;
        }
    }
    else
    {
        for(int i =0; i<copyarray.Length-1; )
        {
            double k = copyarray[i];
            copyarray[i] = copyarray[i+1];
            copyarray[i+1] = k;
            i = i +2;
        } 
    }
    return copyarray;
}
vuvod(changeposition(chislo));