Veiculo v1 = new Veiculo();
v1.setQtdEixos(10);

VeiculoUtilitario v = new VeiculoUtilitario();
v.setQtdEixos(10);
v.setTipo(1);
v.CalcularPedagio(2);
Console.WriteLine("\nPedagio Utilitarios: " + v.getPrecoPedagio());
Console.WriteLine("Pedagio final: " + v.getValorFinal());

Onibus o = new Onibus();
o.setQtdEixos(10);
o.setTipo(1);
o.CalcularPedagio(2);
Console.WriteLine("\nPedagio ônibus: " + o.getPrecoPedagio());
Console.WriteLine("Pedagio final: " + o.getValorFinal());

VeiculoDePasseio veiculoPasseio = new VeiculoDePasseio();
veiculoPasseio.setQtdEixos(10);
veiculoPasseio.setTipo(1);
veiculoPasseio.CalcularPedagio(1);
Console.WriteLine("\nPedagio Passeio: " + veiculoPasseio.getPrecoPedagio());
Console.WriteLine("Pedagio final: " + veiculoPasseio.getValorFinal());

Caminhao caminhao = new Caminhao();
caminhao.setQtdEixos(10);
caminhao.setTipo(3);
caminhao.CalcularPedagio(4);
Console.WriteLine("\nPedagio caminhão: " + caminhao.getPrecoPedagio());
Console.WriteLine("Pedagio final: " + caminhao.getValorFinal());
