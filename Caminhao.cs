public class Caminhao : Veiculo
{
    public Caminhao()
    {
        
    }
    public override void CalcularPedagio(int categoriaVeiculos)
    {
        base.CalcularPedagio(categoriaVeiculos);
        double taxaManutencao = 0.07;
        _precoPedagio += (_precoPedagio * taxaManutencao);
        base.CalcularDesconto();
    }
}