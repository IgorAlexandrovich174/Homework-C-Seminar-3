//Задача 19
//
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//
//14212 -> нет
//
//12821 -> да
//
//23432 -> да

System.Console.Write("Введите число: ");
string inputValue = System.Console.ReadLine();

for (int i = 0; i < inputValue.Length; i++) {
    if(inputValue[i] != inputValue[inputValue.Length - 1 - i]) {
        System.Console.WriteLine("Число не палиндром!");
        break;
    }
    
    if(i == inputValue.Length - 1) {
        System.Console.WriteLine("Число палиндром");
        break;
    }
}

