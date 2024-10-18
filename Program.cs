string mês = "";
int dias = 0;
Console.Clear();

Console.WriteLine("--------------------------");
Console.WriteLine("Dias de cada mês do ano");
Console.WriteLine("--------------------------\n");

Console.Write("Por favor, digite o mês por extenso:");
mês = Console.ReadLine()!.ToUpper();

switch(mês)
{
    case "JANEIRO":
    case "ABRIL":
    case "JUNHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
      dias = 31;
      break;

     case "FEVEREIRO":
      dias = 28;
      break;
 
    case "MARCO":
    case "MAIO":
    case "JULHO":
    case "SETEMBRO":
    case "NOVEMBRO":
      dias = 30;
      break;

    default:
        Console.WriteLine("Mês inválido. Digite novamente.");
        break;
}

if (dias > 0)
{
  Console.WriteLine($"O mês de {mês} possuí {dias} dias.");
}
