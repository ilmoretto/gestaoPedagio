public class Veiculo
{
    private string _placa;
    private int _qtdEixos;
    private int _tipo;
    private double _precoPedagio;
    private double _valorFinal;
    
    //===========Construtores===========
    public Veiculo() { }

    public Veiculo(string placa, int qtdEixos, int tipo, double precoPedagio)
    {
        setPlaca(placa);
        setQtdEixos(qtdEixos);
        setTipo(tipo);
        setPrecoPedagio(precoPedagio);
    }
    
    //=========Getters e Setters===========//
    public void setPlaca(string placa)
    {
        if (placa != null)
        {
            _placa = placa;
        }
        else
        {
            throw new Exception("É necessário informar a placa!");
        }
    }
    
    public string getPlaca()
    {
        return _placa;
    }

    public void setQtdEixos(int qtdEixos)
    {
        if (qtdEixos > 0)
        {
            _qtdEixos = qtdEixos;
        }
        else
        {
            throw new Exception("Quantidade inválida!");
        }
    }

    public int getQtdEixos()
    {
        return _qtdEixos;
    }

    public void setTipo(int tipo)
    {
        if (tipo > 0 && tipo <= 3)
        {
            _tipo = tipo;
        }
        else
        {
            throw new Exception("Tipo inválido!");
        }
    }

    public int getTipo()
    {
        return _tipo;
    }

    public void setPrecoPedagio(double precoPedagio)
    {
        if (precoPedagio > 0)
        {
            _precoPedagio = precoPedagio;
        }
        else
        {
            throw new Exception("O valor deve ser maior que zero!");
        }
    }

    public double getPrecoPedagio()
    {
        return _precoPedagio;
    }

    public double getValorFinal()
    {
        return _valorFinal;
    }
    
    //============Métodos===============//

    public void CalcularPedagio(int categoriaVeiulos)
    {
        switch (categoriaVeiulos)
        {
            case 1: //categoria passeio
                _precoPedagio = _qtdEixos * 3.00;
                _valorFinal = _precoPedagio;
                
                break;
                
            case 2: //categoria utilitários
                _precoPedagio = _qtdEixos * 3.50;
                _valorFinal = _precoPedagio + (_precoPedagio * 0.02);

                break;
            
            case 3://categoria ônibus
                _precoPedagio = _qtdEixos * 5.00;
                _valorFinal = _precoPedagio + (_precoPedagio * 0.05);

                break;
            
            case 4://categoria caminhão

                _precoPedagio = _qtdEixos * 7.00;
                _valorFinal = _precoPedagio + (_precoPedagio * 0.10);

                break;
        }
    }

    public void CalculoPedagio(int categoria, int qtdEixos)
    {
        
        _valorFinal = Calculo.CalcularPedagio(categoria, qtdEixos);

    }



}