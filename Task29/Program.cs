int[] array = new int[8];

for (int i = 0; i < 8; i++) {
    Console.WriteLine("Введите число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int j = 0; j < array.Length; j++) {
    if (j == 0) {
        Console.Write("[{0}, ", array[j]);
    }else if (j == array.Length - 1) {
        Console.WriteLine("{0}]", array[j]);
    } else {
        Console.Write("{0}, ", array[j]);
    }
}
