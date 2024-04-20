string genero;
float peso = 0, altura = 0, IMC = 0;

do
{
    Console.WriteLine("Iforme seu peso em quilos: ");
    peso = float.Parse(Console.ReadLine());

} while (peso <= 0);

do
{
    Console.WriteLine("Iforme sua altura em Metros: ");
    altura = float.Parse(Console.ReadLine());

} while (altura <= 0);

do
{
    Console.WriteLine("Digite seu gênero [F/M]:");
    genero = Console.ReadLine();

} while (genero != "F" && genero != "M");

IMC = peso / (altura * altura);

if (IMC < 17)
{
    Console.WriteLine("Muito abaixo do peso");
}
else
{
    if (IMC < 18.5)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else
    {
        if (IMC < 24.9)
        {
            Console.WriteLine("Peso Normal");
        }
        else
        {
            if (IMC < 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                if(IMC < 34.3)
                {
                    Console.WriteLine("Obesidade | ");
                }
                else
                {
                    if(IMC < 39.9)
                    {
                        Console.WriteLine("Obesidade ||");

                    }
                    else
                    {
                        Console.WriteLine("Obesidade |||");

                    }
                }
            }
        }
    }
    
}