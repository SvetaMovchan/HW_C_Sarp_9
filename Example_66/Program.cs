/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void Print (string text){  
   Console.Write(text); 
}

int GetIntNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double SumAllDigit(int m, int n){
    if(m == n) return m;
    return m + SumAllDigit(m+1,n);
}

Print("Введите число M=> ");
int m = GetIntNum();
Print("Введите число N=> ");
int n = GetIntNum();
Console.WriteLine($"Сумма всех целых чисел в промежутке [{m},{n}] = {SumAllDigit(m, n)}");