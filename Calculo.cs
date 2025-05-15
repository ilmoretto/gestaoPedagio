public static class Calculo
{
    public static double CalcularPedagio(int categoriaVeiulos, int qtdEixos)
    {
        double precoBase = 0;
        double taxaManutencao = 0;
        double precoPedagio = 0;
        double valorFinal = 0;
        
        switch (categoriaVeiulos)
        {
            case 1: //categoria passeio
                precoBase = 3;
                taxaManutencao = 0;
                
                break;
                
            case 2: //categoria utilitários
                precoBase =  3.50;
                taxaManutencao = 0.02;

                break;
            
            case 3://categoria ônibus
                precoBase = 5.00;
                taxaManutencao = 0.05;

                break;
            
            case 4://categoria caminhão

                precoBase = 7.00;
                taxaManutencao =  0.10;

                break;
            
            default:
                throw new Exception("Categoria inválida!");
        }
        precoPedagio = precoBase * qtdEixos;
        valorFinal = precoPedagio + (precoPedagio * taxaManutencao);
        return valorFinal;

    }
    
    
    
    
}