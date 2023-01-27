/*string[] array1 = new string[5] {"225", "58", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2){
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }

}
void ShowArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
ShowArray(array2);*/

//Сначала объявляется два массива: изначальный и второй такой же длинны.
// Затем идет метод, в котором цикл соразмерен длине массива, внутри цикла идет проверка условия(<= 3), 
//если да, то элемент первого массива заносится в count элемент второго массива.
//После присвоения переменная count увеличивается на 1 и возвращается к циклу for, 
//в котором i  увеличивается на 1. И так проверяется до конца )