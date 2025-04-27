//task1
//int n= Convert.ToInt32(Console.ReadLine());
//int result = 1;
//while (n>0)
//{
//    int a = n % 10;
//    result *= a;
//    n = n / 10;
//}
//Console.WriteLine(result); 
//task2
//int m1 = Convert.ToInt32(Console.ReadLine());
//int m2 = Convert.ToInt32(Console.ReadLine());
//int m3 = Convert.ToInt32(Console.ReadLine());
//if (m1 < m2 && m1 < m3)
//{
//    Console.WriteLine("Qiymet "+(m2+m3));
//}else if (m2 < m1 && m2 < m3)
//{
//    Console.WriteLine("Qiymet "+(m3 + m1));
//}else
//    Console.WriteLine("Qiymet " + (m2 + m1));
//task3
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 3 ==0 && a%2 ==0)
//{
//    Console.WriteLine("3-e bolunur cutdur");

//}else if (a % 3 ==0 && a%2 != 0)
//{
//    Console.WriteLine("3-e bolunur tekdir");
//}else
//    Console.WriteLine("3-e bolunmur");
//
//task4
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 2; i < n; i++)
//{
//    if (n % i == 0 )
//    {
//        Console.WriteLine("Eded murekkebdir");
//        return;

//    }
//}
//Console.WriteLine("Eded sadedir");
//
//task5
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//int z = Convert.ToInt32(Console.ReadLine());
//if (x > y && z > y)
//{
//    Console.WriteLine("en kicik eded: " + y);
//}else if (x < y && x < z)
//{
//    Console.WriteLine("en kicik eded: " + x);
//}else
//    Console.WriteLine("en kicik eded: " + z);
//
//task6
//int n = Convert.ToInt32(Console.ReadLine());
//if (n % 21 == 0)
//{
//    Console.WriteLine("n ededi 3-e ve 7-ye bolunur");
//}
//else
//    Console.WriteLine("Bolunmur");
//
//task7
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//int say = 0;
//if (a > 0)
//    say++;
//
//if (b > 0)
//    say++;
//
//if (c > 0)
//    say++;
//
//Console.WriteLine("Musbet ededlerin sayi: "+say);
//
//task8
//int m=Convert.ToInt32(Console.ReadLine());
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = m; i < n; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);
//
//task9
//int m = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//for (int i = 1; i < m; i++)
//{
//    if(i %15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);  
//
//task10
//int m = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//int count = 0;
//double average;
//for (int i = 1; i < m; i++)
//{
//    if (i %21 == 0)
//    {
//        sum += i;
//        count++;

//    }
//}
//if (count > 0)
//{
//    average = (double)sum / count;
//    Console.WriteLine("Ededi orta: " + average);
//}
//else
//    Console.WriteLine("21-e bolunen eded yoxdur");
//
//task11
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//while (n > 0)
//{
//    sum += (n % 10);
//    n /= 10;
//}
//Console.WriteLine(sum);