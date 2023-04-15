using PRIORI_SERVICES_API.Model;
using PRIORI_SERVICES_API.Models.Dbos;
using System.Text.Json.Serialization;

namespace PRIORI_SERVICES_API.Models;
public class CarteiraInvestimento
{
    public CarteiraInvestimentoDbo toDbo(CarteiraInvestimento ct)
    {
        return new CarteiraInvestimentoDbo
        {
<<<<<<< HEAD
            return new CarteiraInvestimentoDbo
            {
                id_efetuacao = ct.id_efetuacao,
                id_cliente_carteira = ct.id_cliente_carteira,
                id_investimento = ct.id_investimento,
                rentabilidade_fixa = ct.rentabilidade_fixa,
                rentabilidade_variavel = ct.rentabilidade_variavel,
                valor_aplicado = ct.valor_aplicado,
                data_encerramento = ct.data_encerramento,
                data_efetuacao = ct.data_efetuacao,
                status = ct.status,
                saldo = ct.saldo
            };
        }
        public int id_efetuacao { get; set; }

        
        public int id_cliente_carteira { get; set; }

       
        public int id_investimento { get; set; }

        public Decimal rentabilidade_fixa { get; set; }
        public Decimal rentabilidade_variavel { get; set; }
        public DateTime data_efetuacao { get; set; }
        public Decimal valor_aplicado { get; set; }
        public DateTime ?data_encerramento { get; set; }
        public string ?status { get; set; }
        public Decimal saldo { get; set; }
=======
            id_efetuacao = ct.id_efetuacao,
            id_cliente_carteira = ct.id_cliente_carteira,
            id_investimento = ct.id_investimento,
            rentabilidade_fixa = ct.rentabilidade_fixa,
            rentabilidade_variavel = ct.rentabilidade_variavel,
            valor_aplicado = ct.valor_aplicado,
            data_encerramento = ct.data_encerramento,
            data_efetuacao = ct.data_efetuacao,
            status = ct.status,
            saldo = ct.saldo
        };
>>>>>>> 17ba24e6f57a99741d77f6b1890ce5cbf605d512
    }
    public int id_efetuacao { get; set; }

    [JsonIgnore]
    public Cliente? cliente { get; set; }
    public int id_cliente_carteira { get; set; }

    [JsonIgnore]
    public Investimento? investimento { get; set; }
    public int id_investimento { get; set; }

    public Decimal rentabilidade_fixa { get; set; }
    public Decimal rentabilidade_variavel { get; set; }
    public DateTime data_efetuacao { get; set; }
    public Decimal valor_aplicado { get; set; }
    public DateTime? data_encerramento { get; set; }
    public string? status { get; set; }
    public Decimal saldo { get; set; }
}
