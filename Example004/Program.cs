//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

void FillArray (int [] digits)
{
    int length = digits.Length;
    int index = 0;
    while (index < length)
    {
        digits [index] = new Random ().Next (1, 100);
        index ++;
    }
}

void PrintArray (int [] array){
    for (int index = 0; index < array.Length; index ++){
        Console.Write (array [index]+" ");
    }
    Console.WriteLine();
}

int [] array = new int [10];
FillArray (array);
PrintArray (array);

int index = 0;
int count = 0;
int n = array.Length;

void CountArray (int [] array) {
    if (array [index]>=20 && array [index] <= 90){
    count ++;
    index ++;
    }
    else {
        index ++;
    }
    }
while (index < n) {
    CountArray (array);
}
Console.WriteLine ();
Console.WriteLine (count);