//PROGRAMA PARA CALCULAR MÉDIA DE CINCO NOTAS:
//USAR CONSOLE.READLINE PARA LER A ENTRADA DAS NOTAS 
//USAR SAÍDA DE DADOS FORMATADA COM INTERPOLAÇÃO

// ENTRADA DE DADOS
//1. informação na tela
//2. entrada de dados  x5
Console.WriteLine("Informe a primeira nota: "); 
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a quarta nota: ");
double nota4 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a quinta nota: ");
double nota5 = double.Parse(Console.ReadLine());

// PROCESSAMENTO DOS DADOS
//3. soma das notas / qtd_notas
double mediaNotas = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

// SAÍDA DE DADOS
//4. exibição dos dados (writeline)
Console.WriteLine($"A média das 5 notas é de: {mediaNotas}");

//1. conversão de dados (arredondamento) -> Math.Round
Console.WriteLine($"A média das 5 notas é de: {Math.Round(mediaNotas)}");

//2. conversão de dados (arredondamento) -> ToString
Console.WriteLine($"A média das 5 notas é de: {mediaNotas.ToString("F0")}");

//2. conversão de dados (arredondamento) -> ToString
Console.WriteLine($"A média das 5 notas é de: {mediaNotas:F2}");