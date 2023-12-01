// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

void FillArray (int [] digits)
{
    int length = digits.Length;
    int index = 0;
    while (index < length)
    {
        digits [index] = new Random ().Next (1, 50);
        index ++;
    }
}

void PrintArray (int [] array){
    for (int index = 0; index < array.Length; index ++){
        Console.Write (array [index]+" ");
    }
    Console.WriteLine();
}

void FindEvenNums (int [] array){
    int index = 0;
    int count = 0;
    int n = array.Length;

while (index < n) {
    if (array [index] % 2 == 0){
        count ++;
        index ++;
    }
    else {
        index ++;
        }
    }
Console.WriteLine ();
Console.WriteLine (count);
}

int [] array = new int [10];
FillArray (array);
PrintArray (array);
FindEvenNums (array);


