string OutProgression(int n){
    string s = "";
    if (n == 1) return s + "1";
    else {
        return n + ", " + OutProgression(n - 1);
    }
}

int GetNumber(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


System.Console.WriteLine(OutProgression(GetNumber("Введите число: ")));
