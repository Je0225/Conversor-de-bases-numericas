using System;
using System.Windows.Forms;

namespace ConversorParaBinario {

  public partial class FormPrincipal : Form {

    private readonly String[] basesDisponíveis = { "Decimal", "Binário", "Octal", "Hexadecimal" };

    private String ValorInformado => tbValor.Text;

    public FormPrincipal() {
      InitializeComponent();
      foreach (String baseN in basesDisponíveis) {
        cbBaseDoValor.Items.Add(baseN);
        cbConverterPara.Items.Add(baseN);
      }
    }

    private String RegexEhVazio(String entrada, String mensagem) {
      if (entrada.Equals("")) {
        MessageBox.Show(mensagem);
        tbValor.Clear();
        tbValor.Focus();
        return "";
      }
      tbValor.Text = entrada;
      return entrada;
    }

    private void btnConverter_Click(object sender, EventArgs e) {
      String regex;
      String valorParaConverter;
      String mensagemDefault = @"Não é necessário realizar uma conversão";

      switch (cbBaseDoValor.SelectedIndex) {
        case 0:
          regex = Calculos.FazRegexDecimal(ValorInformado);
          valorParaConverter = RegexEhVazio(regex, "Informe um valor válido!");
          if (valorParaConverter.Equals("")) {
            return;
          }
          switch (cbConverterPara.SelectedIndex) {
            case 1:
              lblResult.Text = Calculos.DecimalParaQualquerBase(valorParaConverter, 2);
              break;
            case 2:
              lblResult.Text = Calculos.DecimalParaQualquerBase(valorParaConverter, 8);
              break;
            case 3:
              lblResult.Text = Calculos.DecimalParaQualquerBase(valorParaConverter, 16);
              break;
            default:
              MessageBox.Show(mensagemDefault);
              break;
          }
          break;
        case 1:
          regex = Calculos.FazRegexBinario(ValorInformado);
          valorParaConverter = RegexEhVazio(regex, "Números binários devem ser compostos somente pelos dígitos 0 e/ou 1");
          if (valorParaConverter.Equals("")) {
            return;
          }
          switch (cbConverterPara.SelectedIndex) {
            case 0:
              lblResult.Text = Calculos.QualquerBaseParaDecimal(valorParaConverter, 2);
              break;
            case 2:
              lblResult.Text = Calculos.BinarioParaOctal(valorParaConverter);
              break;
            case 3:

              lblResult.Text = Calculos.BinarioParaHexadecimal(valorParaConverter);
              break;
            default:
              MessageBox.Show(mensagemDefault);
              break;
          }
          break;
        case 2:
          regex = Calculos.FazRegexOctal(ValorInformado);
          valorParaConverter = RegexEhVazio(regex, "Números com base octal não podem conter os digitos 8 e 9");
          if (valorParaConverter.Equals("")) {
            return;
          }
          switch (cbConverterPara.SelectedIndex) {
            case 0:
              lblResult.Text = Calculos.QualquerBaseParaDecimal(valorParaConverter, 8);
              break;
            case 1:
              lblResult.Text = Calculos.OctalParaBinario(valorParaConverter);
              break;
            case 3:
              lblResult.Text = Calculos.OctalParaHexa(valorParaConverter);
              break;
            default:
              MessageBox.Show(mensagemDefault);
              break;
          }
          break;
        case 3:
          regex = Calculos.FazRegexHexadecimal(ValorInformado);
          valorParaConverter = RegexEhVazio(regex, "Números hexadecimais podem não conter letras diferentes de A,B,C,D,E e/ou F");
          if (valorParaConverter.Equals("")) {
            return;
          }
          switch (cbConverterPara.SelectedIndex) {
            case 0:
              lblResult.Text = Calculos.QualquerBaseParaDecimal(valorParaConverter, 16);
              break;
            case 1:
              lblResult.Text = Calculos.HexaParaBinarioOuOctal(valorParaConverter, 2);
              break;
            case 2:
              lblResult.Text = Calculos.HexaParaBinarioOuOctal(valorParaConverter, 8);
              break;
            default:
              MessageBox.Show(mensagemDefault);
              break;
          }
          break;
      }
    }

    private void btnLimpar_Click(object sender, EventArgs e) {
      tbValor.Clear();
      lblResult.Text = "";
      cbBaseDoValor.ResetText();
      cbConverterPara.ResetText();
      tbValor.Focus();
    }

    private void tbValor_KeyPress(object sender, KeyPressEventArgs e) {
      if (ValorInformado != "") {
        int.TryParse(Calculos.FazRegexDecimal(ValorInformado), out Int32 entrada);
        e.Handled = cbBaseDoValor.SelectedIndex == 1 && entrada == 0 && e.KeyChar != (Char)Keys.Back;
      }
    }

  }
}