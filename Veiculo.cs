public class Veiculo
{
    private string _placa;
    private int _qtdEixos;
    private int _tipo;
    protected double _precoPedagio;
    protected double _valorFinal;
    //===========Construtores===========
    public Veiculo() { }
    public Veiculo(string placa, int qtdEixos, int tipo) {
        setPlaca(placa);
        setQtdEixos(qtdEixos);
        setTipo(tipo);
    }
    //=========Getters e Setters===========//
    public void setPlaca(string placa) {
        if (placa != null) {
            _placa = placa;
        } else {
            throw new Exception("É necessário informar a placa!");
        }
    }
    public string getPlaca() {
        return _placa;
    }
    public void setQtdEixos(int qtdEixos) {
        if (qtdEixos > 0) {
            _qtdEixos = qtdEixos;
        } else {
            throw new Exception("Quantidade inválida!");
        }
    }
    public int getQtdEixos() {
        return _qtdEixos;
    }
    public void setTipo(int tipo) {
        _tipo = tipo;
    }
    public int getTipo() {
        return _tipo;
    }

    public void setPrecoPedagio(double precoPedagio) {
        _precoPedagio = precoPedagio;
    }
    public double getPrecoPedagio() {
        return _precoPedagio;
    }
    public double getValorFinal() {
        return _valorFinal;
    }
    //============Métodos===============//
    public virtual void CalcularPedagio(int categoriaVeiulos) {
        double valorBase = 0;
        switch (categoriaVeiulos) {
            case 1: //categoria passeio
                valorBase = 3.00;
                break;
            case 2: //categoria utilitários
                valorBase = 3.50;
                break;
            case 3://categoria ônibus
                valorBase = 5.00;
                break;
            case 4://categoria caminhão
                valorBase = 7.00;
                break;
            default:
                throw new Exception("Categoria de veículos não encontrada!");
        }
        _precoPedagio = valorBase * _qtdEixos;
        Console.Clear();
        Console.WriteLine("==========|TIPO DE VEÍCULO|==========");
        Console.WriteLine("1 - Pessoa Física");
        Console.WriteLine("2 - Pessoa Jurídica");
        Console.WriteLine("3 - Veiculo Oficial");
        Console.Write("Selecione uma opção: ");
        _tipo = Convert.ToInt32(Console.ReadLine());

    }

    public void CalcularDesconto() {
        double descontoBase = 0;
        if (_tipo == 1) {
            Console.WriteLine("\nDesconto não aplicável!");
        } else if (_tipo == 2) {
            Console.WriteLine("\nPessoa Jurídica: 5% off");
            descontoBase = 0.05;
        } else if (_tipo == 3) {
            Console.WriteLine("\nVeículo oficial: Cobrança não aplicável.");
            descontoBase = 1;
        } else {
            throw new Exception("Tipo de veículo inválido!");
        }
        _valorFinal = _precoPedagio - (_precoPedagio * descontoBase);
        if (_tipo != 1)
            Console.WriteLine("\nValor parcial: " + _precoPedagio.ToString("C2"));
        Console.WriteLine("Valor do Pedágio: " + _valorFinal.ToString("C2"));
    }
}