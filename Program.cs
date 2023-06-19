// Задача 64

// class MainClass {
//     static void Main(string[] args) {
//         Console.WriteLine ("Введите число N:");
//         int n = int.Parse(Console.ReadLine());
//         Console.Write(n);
//         PrintNumbersDown(n-1);
//     }

//     static void PrintNumbersDown(int n) {
//         if (n >= 1){
//             Console.Write(","+ n);
//             PrintNumbersDown(n-1);
//         }
//     }
// }

// Задача 66
// class MainClass{
//     static void Main (string[] args){
//         Console.WriteLine ("Введите число M:");
//         int m = int.Parse(Console.ReadLine());
//         Console.WriteLine ("Введите число N:");
//         int n = int.Parse(Console.ReadLine());
//         int sum = 0;
//         for(int i = m; i <= n; i++){
//             sum += i;
//         }
//         Console.WriteLine("Сумма натуральных элементов от{0} до {1} = {2}", m, n, sum);
//     }
 
// }

// Задача 68
// class GFG
// {
 
//     static int ack(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if((m > 0) && (n == 0))
//         {
//             return ack(m - 1, 1);
//         }
//         else if((m > 0) && (n > 0))
//         {
//             return ack(m - 1, ack(m, n - 1));
//         }else
//         return n + 1;
//     }
 

//     public static void Main()
//     {
         
//         Console.WriteLine(ack(2, 3));
//     }
// }