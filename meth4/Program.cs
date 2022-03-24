Console.WriteLine("введите размер массива");
int razm = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[razm];
Random rnd = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(-100,100);
}
for (int i=0;i<mas.Length;i++)
{
    Console.Write(mas[i] + "\t");
}
Console.WriteLine();
int srzn = srznachelem(mas);
int kolv = kolvo(mas);
Console.WriteLine("Средне арифметическое:"+ srzn);
Console.WriteLine("количество элементов:"+ kolv);
int uebs = 0;
for (int i= 0; i<mas.Length;i++)
{
    if (mas[i] > srzn) uebs++;
}
Console.WriteLine("Количество уебанов русланов:"+ uebs);

static int srznachelem(int[] arr)
{          
    int elem = 0;
    for (int i=0; i<arr.Length; i++)
    {
        elem += arr[i];
    }
    int kolvo = arr.Length ;
    int srznach = elem / kolvo;
    return srznach;
            
}
static int kolvo(int[] arr)
{
    int kolvo = arr.Length;
    return kolvo;
}