using System.Globalization;
namespace Ciclo1;

public enum Sexo { Masculino, Feminino }
public enum Time { Corinthians, Santos, SaoPaulo, Palmeiras, Outro }
public enum Area { Tecnologia, Exatas, Humanas, Outra }
public record Dados(string Nome, int AnoNascimento, Sexo Sexo, Time Time,
bool Trabalha, decimal Salario, bool CursaFaculdade, Area Area);
public record Resultado(decimal Total, string Memoria);
public static class SeguroSocial
{
    public static Resultado Calcular(Dados dados, int anoAtual)
    {
        if (string.IsNullOrWhiteSpace(dados.Nome))
            throw new ArgumentException("Informe o nome.");
        if (dados.AnoNascimento < 1 || dados.AnoNascimento > anoAtual)
            throw new ArgumentException("Informe um ano de nascimento válido, não futuro.");
        if (dados.Salario < 0)
            throw new ArgumentException("O salário não pode ser negativo.");
        if (!dados.Trabalha && dados.Salario != 0)
            throw new ArgumentException("Para quem não trabalha, informe salário zero.");
        if (!Enum.IsDefined(dados.Sexo) || !Enum.IsDefined(dados.Time) || !Enum.IsDefined(dados.Area))
            throw new ArgumentException("Seleção inválida.");
        // Restrições fictícias do enunciado, sem correspondência com fatos reais.
        if (dados.Sexo == Sexo.Masculino && dados.Time == Time.SaoPaulo)
            throw new ArgumentException(
            "Regra fictícia do exercício: masculino e São Paulo não podem ser combinados.");
        if (dados.AnoNascimento > 1970 && dados.Time == Time.Santos)
            throw new ArgumentException(
            "Regra fictícia do exercício: Santos exige nascimento até 1970.");
        if (dados.Salario > 1500m && dados.Time == Time.Corinthians)
            throw new ArgumentException(
            "Regra fictícia do exercício: Corinthians exige salário até R$ 1.500,00.");
        var cultura = CultureInfo.GetCultureInfo("pt-BR");
        var linhas = new List<string> { $"Participante: {dados.Nome.Trim()}",
$"Ano de referência: {anoAtual}" };
        decimal total = 0;
        void Somar(string descricao, decimal valor)
        {
            total += valor;
            linhas.Add($"{descricao}: {valor.ToString("C2", cultura)}");
        }
        // O formulário do enunciado solicita apenas o ano: idade aproximada.
        int idade = anoAtual - dados.AnoNascimento;
        Somar($"Idade aproximada ({idade} anos × R$ 100,00)", idade * 100m);
        Somar("Parcela por sexo", dados.Sexo == Sexo.Feminino ? 1500m : 1000m);
        Somar("Nascimento no século XX (1901 a 2000)",
        dados.AnoNascimento >= 1901 && dados.AnoNascimento <= 2000 ? 500m : 0m);
        decimal bonusTime = dados.Time switch
        {
            Time.Corinthians => 5000m,
            Time.Santos => 2000m,
            Time.SaoPaulo => 1000m,
            Time.Palmeiras => -100m,
            _ => 0m
        };
        Somar("Parcela por time", bonusTime);
        decimal bonusSalario = 0m;
        if (dados.Trabalha)
        {
            if (dados.Salario <= 2500m) bonusSalario = 2000m;
            else if (dados.Salario <= 4500m) bonusSalario = 1000m;
        }
        Somar("Bônus salarial (faixas não cumulativas)", bonusSalario);
        Somar("Cursando faculdade", dados.CursaFaculdade ? 5000m : 0m);
        decimal bonusArea = 0m;
        if (dados.CursaFaculdade)
        {
            bonusArea = dados.Area switch
            {
                Area.Tecnologia => 3000m,
                Area.Exatas => 2500m,
                Area.Humanas => 1000m,
                _ => 0m
            };
        }
        Somar("Bônus adicional da área", bonusArea);
        linhas.Add($"TOTAL: {total.ToString("C2", cultura)}");
        return new Resultado(total, string.Join(Environment.NewLine, linhas));
    }
}