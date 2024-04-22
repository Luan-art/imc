string genero;
double peso = 0, altura = 0, IMC = 0;

do
{
    Console.WriteLine("Informe seu peso em quilos: ");
    peso = double.Parse(Console.ReadLine());
} while (peso <= 0);

do
{
    Console.WriteLine("Informe sua altura em Metros: ");
    altura = double.Parse(Console.ReadLine());
} while (altura <= 0);

do
{
    Console.WriteLine("Digite seu gênero [F/M]:");
    genero = Console.ReadLine();
} while (genero != "F" && genero != "M");

IMC = peso / (altura * altura);

switch (genero)
{
    case "F":
        if (IMC < 19.1)
            Console.WriteLine("Abaixo do peso");
        else if (IMC < 25.8)
            Console.WriteLine("Peso Ideal");
        else if (IMC < 27.3)
            Console.WriteLine("Pouco acima do peso");
        else if (IMC < 32.3)
            Console.WriteLine("Acima do peso");
        else
            Console.WriteLine("Obesidade");

        break;

    case "M":
        if (IMC < 20.7)
            Console.WriteLine("Abaixo do peso");
        else if (IMC < 26.4)
            Console.WriteLine("Peso Ideal");      
        else if (IMC < 27.8)            
            Console.WriteLine("Pouco acima do peso");            
        else if (IMC < 31.1)  
            Console.WriteLine("Acima do peso");    
        else
            Console.WriteLine("Obesidade");
    break;

    default:
        Console.WriteLine("Genêro não abrangido");
    break;
}
