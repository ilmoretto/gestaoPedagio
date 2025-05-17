Console.WriteLine("==========|PEDÁGIO|==========");
Console.WriteLine("1 - Veículo de Passeio");
Console.WriteLine("2 - Veículo Utilitário");
Console.WriteLine("3 - Ônibus");
Console.WriteLine("4 - Caminhão");
Console.WriteLine("0 - Sair");
Console.Write("Selecione uma opcao: ");
int opcaoMenu = Convert.ToInt32(Console.ReadLine());
switch (opcaoMenu)
{
    case 0:

        break;
    case 1:

        break;
    case 2:

        break;
    case 3:

        break;
    case 4:

        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

void VeiculoDePasseio()
{
    Console.WriteLine("==========|VEÍCULO DE PASSEIO|==========");
    Console.Write("Informe a placa: ");
    string placa = Console.ReadLine();
    Console.Write("Informe a quantidade de eixos: ");
    int qtdEixos = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine("==========|TIPO DE VEÍCULO|==========");
    Console.WriteLine("1 - Pessoa Física");
    Console.WriteLine("2 - Pessoa Jurídica");
    Console.WriteLine("3 - Veiculo Oficial");
    
    

}