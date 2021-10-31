void FillRandom(int[] Arr_V1) // Заполняет массив случайными числами от 10 до 99.
{
    int L1 = Arr_V1.Length;
    for (int j1 = 0; j1 < L1;)
    {
        Arr_V1[j1] = new Random().Next(10, 100);
        ++j1;
    }
}

void PrintArray(int[] Arr_V2) // Печатает массив в терминале.
{
    int L2 = Arr_V2.Length;
    for (int j2 = 0; j2 < L2;)
    {
        Console.Write(Arr_V2[j2] + " ");
        ++j2;
    }
}

void AlwaysBiggerCut(int[] Arr_V3) // Занулят остаток массива после того как встретит первое число, которое нарушит порядок возрастания.
{
    int L3 = Arr_V3.Length;
    int max3 = Arr_V3[0];
    bool flag3 = false;
    for (int j3 = 1; j3 < L3;)
    {
        if (flag3 == false)
        {
            if (max3 < Arr_V3[j3])
            {
                max3 = Arr_V3[j3];
            }
            else
            {
                flag3 = true;
                Arr_V3[j3] = 0;
            }
        }
        else
        {
            Arr_V3[j3] = 0;
        }
        ++j3;
    }
}

void AlwaysBigger(int[] Arr_V4) // Зануляет все элементы, которые нарушают порядок возрастания.
{
    int L4 = Arr_V4.Length;
    int max4 = Arr_V4[0];
    for (int j4 = 1; j4 < L4;)
    {
        if (Arr_V4[j4] > max4)
        {
            max4 = Arr_V4[j4];
        }
        else
        {
            Arr_V4[j4] = 0;
        }
        ++j4;
    }
}

Console.WriteLine("Задайте длину массива.");
int N = Convert.ToInt32(Console.ReadLine());
int[] Arr_A = new int[N];
FillRandom(Arr_A);
Console.Write("Изначальный массив: ");
PrintArray(Arr_A);
AlwaysBigger(Arr_A);
Console.Write("Возрастающий массив: ");
PrintArray(Arr_A);