// 



void ShowArray(string[] array, string title){
    Console.WriteLine(title);
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

string[] inputArray(){

    Console.Write("Введите количество строк: ");
    int size = Convert.ToInt32(Console.ReadLine());



    string[] result = new string[size];

    for(int i = 0; i < size; i++){
        Console.Write($"Введите строку {i}: ");
        result[i] = Console.ReadLine();
    }

    return result;
}


string[] srcArray = inputArray();
ShowArray(srcArray, "Исходный массив");
