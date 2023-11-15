using System.ComponentModel;
using System.Globalization;

Console.WriteLine("1 : INTEIRO NEGATIVO?");
Console.WriteLine("2 : PAR OU IMPAR?");
Console.WriteLine("3 : SÃO MULTIPLOS?");
Console.WriteLine("4 : DURAÇÃO DO JOGO");
Console.WriteLine("5 : CONTA A PAGAR");
Console.WriteLine("6 : NUMERO DENTRO DE 0 100?");
Console.WriteLine("7 : QUAL QUADRANTE PERTENCE O PONTO?");
Console.WriteLine("8 : IMPOSTO");
Console.Write("\nOpção:");
int op = int.Parse(Console.ReadLine());
Console.Clear();
switch (op) {
    case 1:
        Console.Write("Digite numero: ");
        int neg = int.Parse(Console.ReadLine());
        if (neg < 0) {
            Console.WriteLine("NEGATIVO");
        }
        else {
            Console.WriteLine("NÃO NEGATIVO");
        }
        break;
    case 2:
        Console.Write("Digite numero: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            Console.WriteLine("PAR");
        }
        else {
            Console.WriteLine("IMPAR");
        }
        break;
    case 3:
        Console.WriteLine("Digite numeros:");
        string[] nums = Console.ReadLine().Split(' ');
        if (int.Parse(nums[0]) % int.Parse(nums[1]) == 0 || int.Parse(nums[1]) % int.Parse(nums[0]) == 0) {
            Console.WriteLine("Sao Multiplos");
        }
        else {
            Console.WriteLine("Nao sao Multiplos");
        }
        break;
    case 4:
        Console.WriteLine("Digite as horas:");
        string[] HRS = Console.ReadLine().Split(' ');
        int h1 = int.Parse(HRS[0]);
        int h2 = int.Parse(HRS[1]);
        if (h2 == h1) {
            Console.WriteLine("O JOGO DUROU 24 HORAS");

        }
        else if (h1 < h2) {
            Console.WriteLine($"O JOGO DUROU {h2 - h1} HORA(S)");

        }
        else {
            Console.WriteLine($"O JOGO DUROU {24 + h2 - h1} HORA(S)");
        }
        break;
    case 5:
        Console.WriteLine("1 : Cachorro Quente  R$4.00");
        Console.WriteLine("2 : X-Salada         R$4.50");
        Console.WriteLine("3 : X-Bacon          R$5.00");
        Console.WriteLine("4 : Torrada simples  R$2.00");
        Console.WriteLine("5 : Refrigerante     R$1.50");
        Console.WriteLine("Digite a opção e a quantidade(ex: 3 2): ");
        string[] ops = Console.ReadLine().Split(' ');
        int opcao = int.Parse(ops[0]);
        int qtd = int.Parse(ops[1]);
        switch (opcao) {
            case 1:
                Console.WriteLine($"\nTotal: R${(4.00f*qtd).ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 2:
                Console.WriteLine($"\nTotal: R${(4.50f * qtd).ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 3:
                Console.WriteLine($"\nTotal: R${(5.00f * qtd).ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 4:
                Console.WriteLine($"\nTotal: R${(2.00f * qtd).ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 5:
                Console.WriteLine($"\nTotal: R${(1.50f * qtd).ToString("F2", CultureInfo.InvariantCulture)}");
                break;

            default:
                break;
        }
        break;
    case 6:
        Console.Write("Digite o numero: ");
        float number = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        if (number<=25 && number>=0) {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (number > 25 && number < 50) {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (number > 50 && number < 75) {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (number > 75 && number <= 100){
            Console.WriteLine("Intervalo (75,100]");
        }
        else {
            Console.WriteLine("Fora de intervalo");
        }
        break;
    case 7:
        Console.Write("Digite os pontos: ");
        string[] numbers = Console.ReadLine().Split(' '); 
        float x = float.Parse(numbers[0], CultureInfo.InvariantCulture);
        float y = float.Parse(numbers[1], CultureInfo.InvariantCulture);
        if (x >0 && y>0) {
            Console.WriteLine("Q1");
        }
        else if (x<0 && y>0) {
            Console.WriteLine("Q2");

        }
        else if (x<0 && y<0) {
            Console.WriteLine("Q3");

        }
        else if (x>0 && y<0) {
            Console.WriteLine("Q4");
        }
        else {
            Console.WriteLine("Origem");
        }
        break;
    case 8: 
        Console.Write("Digite o Salário: ");
        float sal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float imposto = 0.0f;
        float aux = sal;
        if (sal>4500) {
            imposto += (aux-4500) * 28 / 100;
            aux = 4500;
        }
        if (sal>3000) {
            imposto += (aux - 3000) * 18 / 100;
            aux = 3000;

        }
        if (sal > 2000) {
            imposto += (aux - 2000) * 8 / 100;
            aux = 0;
        }
        if (imposto == 0.0f) {
            Console.WriteLine("Isento");
        }
        else {
            Console.WriteLine($"R${imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        break;
    default:
        break;
}