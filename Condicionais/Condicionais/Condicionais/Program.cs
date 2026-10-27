// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estruturas condicionais!");


// Estrturas condicionais
// if simples/composto

//int numero = 5;

//if (numero >= 10)
//{
//    Console.WriteLine("O if foi executado com sucesso! ");
//}else
//{
//    Console.WriteLine("Fim do programa");
//}


//Console.WriteLine("Informe um número: ");
//int numero = int.Parse(Console.ReadLine());

//// if encadeado (if - else if - else)
//// se o número é negativo
//// se é positivo
//// ou se é neutro (0)

//if (numero < 0)
//{
//    Console.WriteLine($"O número: {numero} é negativo!"); //interpolação ou concatenação
//} else if ( numero > 0)
//{
//    Console.WriteLine($"O número: {numero} é positivo");    
//} else if (numero == 0)
//{
//    Console.WriteLine($"O número: {numero} é neutro!");
//}
//else
//{
//    Console.WriteLine("Número inválido!");
//}


// crie um programa que vai receber a idade e se possui
// titulo de eleitor para votar
// com base nas informações, verifique se a pessoa pode votar

// entrada de dados
//Console.WriteLine("informe a sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//Console.WriteLine("você tem titulo de eleitor ? s/n");
//char possuiTitulo = char.Parse(Console.ReadLine());

//// processamento de dados
//if (idade >= 18 && idade <= 70)
//{
//    Console.WriteLine("O voto é obrigatório!");

//    if (possuiTitulo != 's')
//    {
//        Console.WriteLine("Antes de votar você deve tirar o titulo de eleitor");
//    }

//} else if (idade < 16)
//{
//    // saída de dados
//    Console.WriteLine("A pessoa não pode votar!");
//} else
//{
//    Console.WriteLine("O voto é facultativo");
//}



//Leia uma nota de 0 a 10 (aceita decimais) sem deixar o programa quebrar.
//Use double.TryParse no lugar de double.Parse.
//• Texto que não é número → "Entrada inválida: digite um número"
//• Fora de 0 a 10 → "Nota fora da faixa (0 a 10)"
//• 9 ou mais → "Conceito A"; 7 ou mais → "Conceito B"; 5 ou mais → "Conceito C";
//abaixo de 5 → "Conceito D"


//Console.Write("Informe uma nota: ");
//string notainformada = Console.ReadLine();

//if (!double.TryParse(notainformada, out double notaFinal))
//{
//    Console.WriteLine("Entrada inválida, tente novamente digitando um número!");
//}

//if (notaFinal < 0 || notaFinal > 10)
//{
//    Console.WriteLine("Nota fora da faixa (0 a 10)");
//}

//if (notaFinal >= 9)
//{
//    Console.WriteLine("Conceito A");
//}
//else if (notaFinal >= 7)
//{
//    Console.WriteLine("Conceito B");
//}
//else if (notaFinal >= 5)
//{
//    Console.WriteLine("Conceito c");
//}
//else
//{
//    Console.WriteLine("Conceito D");
//}


//Leia a idade, se é estudante (s/n), o dia da semana (1 = domingo … 7 = sábado)
//e se a sessão é 3D (s/n). Calcule o preço:

//1.Preço base: R$ 40,00.
//2. Meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante.
//3. Às terças-feiras (dia 3), mais 20% de desconto sobre o valor já calculado.
//4. Sessão 3D: soma R$ 8,00 depois dos descontos.
//Idade fora de 0 a 120 → "Idade inválida". Dia fora de 1 a 7 → "Dia inválido".

//entrada de dados

//Console.Write("Idade: ");
//int idade = int.Parse(Console.ReadLine()!);

//Console.WriteLine("É estudante ? (s/n)");
//char estudante = char.Parse(Console.ReadLine()!.Trim().ToLower());

//Console.WriteLine("Dia da semana: (1- domingo, 2- segunda ...)");
//int diaSemana = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Sessão é em 3D? (s/n)");
//char sessao3d = char.Parse(Console.ReadLine()!.Trim().ToLower());


//// validações
//if (idade < 0 || idade > 120)
//{
//    Console.WriteLine("Idade invalida");
//    return;
//}

//if (diaSemana < 1 || diaSemana > 7)
//{
//    Console.WriteLine("Dia da semana invalido");
//    return;
//}

//decimal precoBase = 40.00m;


//if (idade < 12 || idade >= 60 || estudante == 's')
//{
//    //precoBase = precoBase * 0.50m;
//    precoBase *= 0.50m;
//}

//if (diaSemana == 3)
//{
//    precoBase *= 0.80m;
//    //precoBase = (precoBase * 20) / 100;
//}

//if (sessao3d == 's')
//{
//    precoBase += 8.00m;
//}


//Console.WriteLine($"O valor e de: R$ {Math.Round(precoBase, 2)} reais");


//Leia o limite da via e a velocidade medida (km/h, inteiros).
//Calcule o percentual acima do limite com
//(velocidade - limite) * 100.0 / limite e
//classifique com uma switch expression.
//Regras simplificadas, inspiradas no Código de Trânsito:

//• 0 % ou menos → "Dentro do limite"
//• até 20% → "Infração média"
//• acima de 20% até 50% → "Infração grave"
//• acima de 50% → "Infração gravíssima"
//Limite menor ou igual a 0, ou velocidade negativa → "Dados inválidos".

//entrada de dados
Console.WriteLine("Limite da via: ");
int limite = int.Parse(Console.ReadLine()!);

Console.WriteLine("Velocidade medida: ");
int velocidade = int.Parse(Console.ReadLine()!);

if (limite < 0 || velocidade < 0)
{
    Console.WriteLine("Dados são inválidos!");
    return;
}

double percentual = (velocidade - limite) * 100.0 / limite;

// utilizando switch expressions

string classificacao = percentual switch
{
   <= 0 => "Dentro do limite",
   <= 20 => "Infração média",
   <= 50 => "Infração grave",
    _ => "Infração gravíssima"
};

if (percentual <= 0)
{
    Console.WriteLine(classificacao);
} else
{
    Console.WriteLine($"{percentual:f1}% acima do limite da via: {classificacao}");
}