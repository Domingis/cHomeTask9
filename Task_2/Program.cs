int GetNumber(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumMtoN(int m, int n){
    if (m == n) return m;
    else return n + SumMtoN(m, n-1);
}

System.Console.WriteLine(SumMtoN(GetNumber("Введите первое число: "),
                                    GetNumber("Введите первое число: ")));