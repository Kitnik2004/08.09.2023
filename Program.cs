static float ConvertToCurrencyUSD(float amount, string Currency)
{
    switch (Currency)
    {

        case ("RUB"):
            {
                amount *= 0.010f;
                break;
            }
        case ("EUR"):
            {
                amount *= 1.07f;
                break;
            }
        case ("KZT"):
            {
                amount *= 0.0022f;
                break;
            }
        case ("USD"):
            {
                amount *= 1f;
                break;
            }
        default:
            {
                Console.WriteLine("Неверно введена валюта или она отсутсвует вовсе");
            }
            break;
    }
    return amount;
}
static float ConvertToCurrencyKZT(float amount, string Currency)
{
    switch (Currency)
    {

        case ("RUB"):
            {
                amount *= 4.72f;
                break;
            }
        case ("EUR"):
            {
                amount *= 498.54f;
                break;
            }
        case ("KZT"):
            {
                amount *= 1f;
                break;
            }
        case ("USD"):
            {
                amount *= 465.02f;
                break;
            }
        default:
            {
                Console.WriteLine("Неверно введена валюта или она отсутсвует вовсе");
            }
            break;
    }
    return amount;
}
static float ConvertToCurrencyRUB(float amount, string Currency)
{
    switch (Currency)
    {

        case ("RUB"):
            {
                amount *= 1f;
                break;
            }
        case ("EUR"):
            {
                amount *= 105.60f;
                break;
            }
        case ("KZT"):
            {
                amount *= 0.21f;
                break;
            }
        case ("USD"):
            {
                amount *= 98.45f;
                break;
            }
        default:
            {
                Console.WriteLine("Неверно введена валюта или она отсутсвует вовсе");
            }
            break;
    }
    return amount;
}
static float ConvertToCurrencyEUR(float amount, string Currency)
{
    switch (Currency)
    {

        case ("RUB"):
            {
                amount *= 0.0095f;
                break;
            }
        case ("EUR"):
            {
                amount *= 1f;
                break;
            }
        case ("KZT"):
            {
                amount *= 0.0020f;
                break;
            }
        case ("USD"):
            {
                amount *= 0.83f;
                break;
            }
        default:
            {
                Console.WriteLine("Неверно введена валюта или она отсутсвует вовсе");
            }
            break;
    }
    return amount;
}

Console.WriteLine("Введите название вашей валюты в международном виде (USD, EUR, KZT, RUB)");
string Currency = Console.ReadLine();
Console.WriteLine("Введите название валюты в которую нужно перевести в международном виде (USD, EUR, KZT, RUB)");
string Currency_Trans = Console.ReadLine();
Console.WriteLine("Введите кол-во валюты");
float amount = float.Parse(Console.ReadLine());
float Final_amount;

if (amount > 0 && Currency != null && Currency_Trans != null)
{
    if (Currency_Trans == "USD")
    {
        Final_amount = ConvertToCurrencyUSD(amount, Currency);
        Console.WriteLine("{0} {1} = {2} {3}", amount, Currency, Final_amount, Currency_Trans);
    }
    else if (Currency_Trans == "KZT")
    {
        Final_amount = ConvertToCurrencyKZT(amount, Currency);
        Console.WriteLine("{0} {1} = {2} {3}", amount, Currency, Final_amount, Currency_Trans);
    }
    else if (Currency_Trans == "EUR")
    {
        Final_amount = ConvertToCurrencyEUR(amount, Currency);
        Console.WriteLine("{0} {1} = {2} {3}", amount, Currency, Final_amount, Currency_Trans);
    }
    else if (Currency_Trans == "RUB")
    {
        Final_amount = ConvertToCurrencyRUB(amount, Currency);
        Console.WriteLine("{0} {1} = {2} {3}", amount, Currency, Final_amount, Currency_Trans);
    }
    else
    {
        Console.WriteLine("Error");
    }
}
else 
{ 
    Console.WriteLine("Error"); 
}