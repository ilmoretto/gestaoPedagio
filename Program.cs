Console.WriteLine("==========|PEDÁGIO|==========");
Console.WriteLine("1 - Veículo de Passeio");
Console.WriteLine("2 - Veículo Utilitário");
Console.WriteLine("3 - Ônibus");
Console.WriteLine("4 - Caminhão");
Console.WriteLine("0 - Sair");
Console.Write("Selecione uma opcao: ");
int opcaoMenu = Convert.ToInt32(Console.ReadLine());
switch (opcaoMenu) {
    case 0:
        Console.WriteLine("Encerrando programa...");

        break;
    case 1:
        VeiculoDePasseio();

        break;
    case 2:
        VeiculosUtilitarios();

        break;
    case 3:
        CategoriaOnibus();

        break;
    case 4:
        CategoriaCaminhao();

        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

void VeiculoDePasseio() {
    try {
        Console.Clear();
        VeiculoDePasseio v1 = new VeiculoDePasseio();
        Console.WriteLine("==========|VEÍCULO DE PASSEIO|==========");
        Console.Write("Informe a placa: ");
        v1.setPlaca(Console.ReadLine());
        Console.Write("Informe a quantidade de eixos: ");
        v1.setQtdEixos(Convert.ToInt32(Console.ReadLine()));

        v1.CalcularPedagio(1);
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }

}

void VeiculosUtilitarios() {
    try {
        Console.Clear();
        VeiculoUtilitario v2 = new VeiculoUtilitario();
        Console.WriteLine("==========|VEÍCULO UTILITÁRIO|==========");
        Console.Write("Informe a placa: ");
        v2.setPlaca(Console.ReadLine());
        Console.Write("Informe a quantidade de eixos: ");
        v2.setQtdEixos(Convert.ToInt32(Console.ReadLine()));

        v2.CalcularPedagio(2);
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }

}

void CategoriaOnibus() {
    try {
        Console.Clear();
        Onibus onibus = new Onibus();
        Console.WriteLine("==========|ÔNIBUS|==========");
        Console.Write("Informe a placa: ");
        onibus.setPlaca(Console.ReadLine());
        Console.Write("Informe a quantidade de eixos: ");
        onibus.setQtdEixos(Convert.ToInt32(Console.ReadLine()));

        onibus.CalcularPedagio(3);
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }

}

void CategoriaCaminhao() {
    try {
        Console.Clear();
        Caminhao caminhao = new Caminhao();
        Console.WriteLine("==========|Caminhão|==========");
        Console.Write("Informe a placa: ");
        caminhao.setPlaca(Console.ReadLine());
        Console.Write("Informe a quantidade de eixos: ");
        caminhao.setQtdEixos(Convert.ToInt32(Console.ReadLine()));

        caminhao.CalcularPedagio(4);
    } catch (Exception ex) {
        Console.WriteLine(ex);
    }
}