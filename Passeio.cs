public class VeiculoDePasseio : Veiculo
{
    public VeiculoDePasseio() { }
    public override void CalcularPedagio(int categoriaVeiculos) {
        base.CalcularPedagio(categoriaVeiculos);
        double taxaManutencao = 0;
        _precoPedagio += (_precoPedagio * taxaManutencao);
        base.CalcularDesconto();
    }
}