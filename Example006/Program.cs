//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write ("Enter size array: ");
int size = Convert.ToInt32 (Console.ReadLine());

double [] randomArray = new double [size];

void FillArray (double [] randomArray){
    for (int i = 0; i < size; i ++){
        randomArray [i] = new Random (). NextDouble () * 100.00;
        Console.Write (randomArray [i] + " ");
        }
}

void FindDiff (double [] randomArray){
int index = 0;
double max = randomArray [0];
double min = randomArray [0];
double result = 0;
while (index < randomArray.Length){
    if (randomArray [index] > max){
        max = randomArray [index];
    }
    if (randomArray [index] < min){
        min = randomArray [index];
        }
        index ++;
}
result = max - min;
Console.WriteLine ();
Console.WriteLine ($"Difference between max & min = {result}");
}

FillArray (randomArray);
FindDiff (randomArray);
