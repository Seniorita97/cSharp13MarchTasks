//#region Task1
//int[] arr = { 3, 6, 4, 11, 9, 12, 7, -17 };
//int count = 0;
//foreach (var item in arr)
//{
//    if (item % 2 != 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Tek ededlerin sayi {count}");
//#endregion


//#region Task2                                        
//int[] arr = { 3, 6, 4, 11, 9, 12, 7, -2 };
//int min = arr[0];
//int max = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(min + max);

//---------------------------------------2-ci yol--------------------

//int[] arr = { 3, 6, 4, 11, 9, 12, 7, -2 };
//int[] newArr = new int[arr.Length];
//arr.CopyTo(newArr, 0 );
//for ( int i = 0; i < newArr.Length; i++)
//{
//    for ( int j = 0; j < newArr.Length - 1 - i; j++)
//    {
//       if (newArr[j] > newArr[j + 1])
//        {
//            int temp = newArr[j];
//            newArr[j] = newArr[j + 1];
//            newArr[j + 1] = temp;
//        }
//    }
//}
//Console.WriteLine(newArr[0] + newArr[newArr.Length - 1]);

//#endregion

//#region Task5
//int[] arr = { 3, 6, 4, 11, 9, 12, 7, -17 };
//int evensSUM = 0;
//int oddsSum = 0;
//foreach (int i in arr)
//{
//    if(i % 2 == 0)
//    { evensSUM += i;}
//    else
//    {oddsSum += i; }
//}
//Console.WriteLine($"Tek ededlerin cemi{oddsSum}" + " " +
//    $"Cut ededlerin cemi{evensSUM}");
//#endregion

//#region Task3
//int[] arr = { 3, 6, 4, 11, 9, 12, 7, };
//int min = arr[0];
//int max = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max - min);
//#endregion

#region Task4

//int[] arr = { 3, 6, 4, 11, 9, 12, 7, -2 };

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length - 1 - i; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int temp = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = temp;
//        }
//    }
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
#endregion