class Program
{
    static void Main()
    {
        var linhas = new List<string>
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        };

        int comprimento = linhas[0].Length;
        char[] gama = new char[comprimento];

        for (int i = 0; i < comprimento; i++)
        {
            int count0 = 0;
            int count1 = 0;

            foreach (var linha in linhas)
            {
                if (linha[i] == '0') count0++;
                else count1++;
            }

            gama[i] = count1 >= count0 ? '1' : '0'; 
        }

        string gamaStr = new string(gama);
        string betaStr = new string(gama.Select(b => b == '0' ? '1' : '0').ToArray());

        Console.WriteLine($"Gama: {gamaStr}");
        Console.WriteLine($"Beta: {betaStr}");

        int gamaDecimal = Convert.ToInt32(gamaStr, 2);
        int betaDecimal = Convert.ToInt32(betaStr, 2);

        Console.WriteLine($"Gama decimal: {gamaDecimal}");
        Console.WriteLine($"Beta decimal: {betaDecimal}");
        
        Console.WriteLine($"Valor da luz: {gamaDecimal*betaDecimal}");
    }
}