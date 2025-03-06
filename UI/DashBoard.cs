using static UI.Utils.TabelaExtencoes;

namespace EmbeddedForms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            TabelaAtividadesRecentes.DesabilitarGeracaoAutomaticaColunas();

            AdicionarDadosFicticios();
        }

        private void AdicionarDadosFicticios()
        {
            var datas = new List<Object>()
            {
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(500, 2000)).ToString("F2"), Descricao = "Moto"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 5000)).ToString("F2"), Descricao = "Aplicação"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(50, 1000)).ToString("F2"), Descricao = "Supermercado"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(200, 1500)).ToString("F2"), Descricao = "Combustível"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Despesas", Valor = (new Random().Next(100, 3000)).ToString("F2"), Descricao = "Reforma"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(50, 1200)).ToString("F2"), Descricao = "Lazer"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(10, 800)).ToString("F2"), Descricao = "Almoço"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Despesas", Valor = (new Random().Next(200, 3000)).ToString("F2"), Descricao = "Curso"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(500, 1500)).ToString("F2"), Descricao = "Conta de Luz"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 4000)).ToString("F2"), Descricao = "Fundo de Aposentadoria"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(150, 1000)).ToString("F2"), Descricao = "Internet"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Despesas", Valor = (new Random().Next(300, 3000)).ToString("F2"), Descricao = "Medicamentos"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 1000)).ToString("F2"), Descricao = "Manutenção Carro"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(200, 800)).ToString("F2"), Descricao = "Educação"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(500, 4000)).ToString("F2"), Descricao = "Compra de Ações"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 1200)).ToString("F2"), Descricao = "Viagem"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(10, 300)).ToString("F2"), Descricao = "Café"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 2000)).ToString("F2"), Descricao = "Imóveis"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(500, 5000)).ToString("F2"), Descricao = "Reforma"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 2000)).ToString("F2"), Descricao = "Hospedagem"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(150, 3000)).ToString("F2"), Descricao = "Fundo Imobiliário"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(150, 2000)).ToString("F2"), Descricao = "Parque de Diversões"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 5000)).ToString("F2"), Descricao = "Carro"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(10, 600)).ToString("F2"), Descricao = "Restaurante"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 1500)).ToString("F2"), Descricao = "Banco"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 1500)).ToString("F2"), Descricao = "Farmácia"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Despesas", Valor = (new Random().Next(50, 2000)).ToString("F2"), Descricao = "TV a Cabo"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 1000)).ToString("F2"), Descricao = "Telefone"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(200, 5000)).ToString("F2"), Descricao = "Fundo de Renda Fixa"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(200, 3000)).ToString("F2"), Descricao = "Jardim"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 2500)).ToString("F2"), Descricao = "Seguros"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(50, 1000)).ToString("F2"), Descricao = "Previdência"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 2500)).ToString("F2"), Descricao = "Viagem"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(50, 500)).ToString("F2"), Descricao = "Presentes"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 2000)).ToString("F2"), Descricao = "Plano de Saúde"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(100, 1000)).ToString("F2"), Descricao = "Assinaturas"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(500, 1000)).ToString("F2"), Descricao = "Cartão de Crédito"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(50, 5000)).ToString("F2"), Descricao = "Reserva de Emergência"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(200, 1000)).ToString("F2"), Descricao = "Aluguel"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 3000)).ToString("F2"), Descricao = "Compra de Imóveis"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(10, 300)).ToString("F2"), Descricao = "Serviços de Entrega"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(200, 2000)).ToString("F2"), Descricao = "Educacional"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 1000)).ToString("F2"), Descricao = "Compra de Ações"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(200, 3000)).ToString("F2"), Descricao = "Internet"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(10, 1500)).ToString("F2"), Descricao = "Uber"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(500, 4000)).ToString("F2"), Descricao = "Compra de Imóveis"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(150, 2000)).ToString("F2"), Descricao = "Saúde"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Corrente", Categoria = "Despesas", Valor = (new Random().Next(50, 5000)).ToString("F2"), Descricao = "Transporte"},
                new {Data = DateTime.Now.ToShortDateString(), Conta = "Poupança", Categoria = "Investimentos", Valor = (new Random().Next(100, 1000)).ToString("F2"), Descricao = "Imóveis"}

            };

            TabelaAtividadesRecentes.DataSource = datas;
        }
    }
}
