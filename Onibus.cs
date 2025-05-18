public class Onibus : Veiculo
{
    public Onibus() { }
    public override void CalcularPedagio(int categoriaVeiculos) {
        base.CalcularPedagio(categoriaVeiculos);
        double taxaManutencao = 0.05;
        _precoPedagio += (_precoPedagio * taxaManutencao);
        base.CalcularDesconto();
    }
}