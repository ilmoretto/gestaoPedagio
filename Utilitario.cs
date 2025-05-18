public class VeiculoUtilitario : Veiculo
{
    public VeiculoUtilitario() { }
    public override void CalcularPedagio(int categoriaVeiculos) {
        base.CalcularPedagio(categoriaVeiculos);
        double taxaManutencao = 0.02;
        _precoPedagio += (_precoPedagio * taxaManutencao);
        base.CalcularDesconto();
    }
}