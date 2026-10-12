using System.ComponentModel;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace Ciclo1;

public partial class FormPrincipal : Form
{
    private readonly CultureInfo cultura = CultureInfo.GetCultureInfo("pt-BR");
    private string memoria = "";
    public FormPrincipal()
    {
        InitializeComponent();
    }
    private void EntradaAlterada(object? sender, EventArgs e) => LimparResultado();
    private void FaculdadeAlterada(object? sender, EventArgs e)
    {
        if (!chkFaculdade.Checked)
        {
            rdoTecnologia.Checked = false;
            rdoExatas.Checked = false;
            rdoHumanas.Checked = false;
        }
        LimparResultado();
    }
    private void AreaAlterada(object? sender, EventArgs e)
    {
        if (sender is RadioButton opcao && opcao.Checked)
            chkFaculdade.Checked = true;
        LimparResultado();
    }
    private void MostrarMemoria(object? sender, EventArgs e)
    {
        if (memoria.Length > 0)
            MessageBox.Show(this, memoria, "Memória do cálculo", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
    private bool LerSalario(out decimal salario) => decimal.TryParse(txtSalario.Text,
    NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite |
    NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, cultura, out salario);
    private void ValidarCampo(object? sender, CancelEventArgs e)
    {
        string mensagem = "";
        if (sender == txtNome && string.IsNullOrWhiteSpace(txtNome.Text)) mensagem = "Informe o nome.";
        if (sender == txtAno && (!int.TryParse(txtAno.Text, out int ano) || ano < 1 || ano >
        DateTime.Today.Year))
            mensagem = "Informe um ano válido, não futuro.";
        if (sender == txtSalario && (!LerSalario(out decimal salario) || salario < 0))
            mensagem = "Use um valor não negativo, sem R$ ou pontos de milhar (ex.: 2500,50).";
        if (sender is Control controle) erros.SetError(controle, mensagem);
        e.Cancel = mensagem.Length > 0;
    }
    private void LimparResultado()
    {
        lblTotal.Text = "R$ ???????,??";
        memoria = "";
    }
    private void Calcular(object? sender, EventArgs e)
    {
        LimparResultado();
        if (!ValidateChildren()) return;
        if ((!rdoMasculino.Checked && !rdoFeminino.Checked) ||
        (!rdoCorinthians.Checked && !rdoSaoPaulo.Checked && !rdoSantos.Checked &&
        !rdoPalmeiras.Checked) ||
        (chkFaculdade.Checked && !rdoTecnologia.Checked && !rdoExatas.Checked &&
        !rdoHumanas.Checked))
        {
            MessageBox.Show(this, "Selecione sexo, time e, se cursa faculdade, a área.",
            "Dados incompletos");
            return;
        }
        int.TryParse(txtAno.Text, out int ano);
        LerSalario(out decimal salario);
        Sexo sexo = rdoMasculino.Checked ? Sexo.Masculino : Sexo.Feminino;
        Time time = rdoCorinthians.Checked ? Time.Corinthians :
        rdoSaoPaulo.Checked ? Time.SaoPaulo : rdoSantos.Checked ? Time.Santos : Time.Palmeiras;
        Area area = rdoTecnologia.Checked ? Area.Tecnologia :
        rdoExatas.Checked ? Area.Exatas : rdoHumanas.Checked ? Area.Humanas : Area.Outra;
        var dados = new Dados(txtNome.Text, ano, sexo, time, salario > 0m, salario,
        chkFaculdade.Checked, area);
        try
        {
            Resultado resultado = SeguroSocial.Calcular(dados, DateTime.Today.Year);
            lblTotal.Text = resultado.Total.ToString("C2", cultura);
            memoria = resultado.Memoria;
        }
        catch (ArgumentException erro)
        {
            MessageBox.Show(this, erro.Message, "Verifique os dados", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }
    }
}
