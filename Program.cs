Veiculo v1 = new Veiculo();
v1.setQtdEixos(10);
v1.CalculoPedagio(1, 5);
Console.WriteLine("Preço pedágio: " + v1.getValorFinal().ToString("C2"));