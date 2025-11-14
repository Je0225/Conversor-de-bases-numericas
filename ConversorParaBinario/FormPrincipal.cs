using System;
using System.Windows.Forms;
using ConversorParaBinario.Bases.Contratos;

namespace ConversorParaBinario {

  public partial class FormPrincipal : Form {

    private String ValorInformado => tbValor.Text.Trim();

    private IBase BaseAtual => (IBase)cbBaseDoValor.SelectedItem;

    private IBase BaseNova => (IBase)cbConverterPara.SelectedItem;

    private Calculador Calculador { get; }

    public FormPrincipal() {
      InitializeComponent();
      cbBaseDoValor.Items.AddRange(Registry.GetBases());
      cbConverterPara.Items.AddRange(Registry.GetBases());
      Calculador = new Calculador();
    }

    private void Converter() {
      lblResult.Text = Calculador.Calcular(BaseAtual, BaseNova, ValorInformado);
    }

    private void btnConverter_Click(Object sender, EventArgs e) {
      Converter();
    }

    private void ResetaCamposAoAlterarBaseAtual() {
      tbValor.Clear();
      tbValor.Select();
    }

    private void ManipulaTeclas(KeyPressEventArgs e) {
      e.Handled = BaseAtual == null;
      if (!e.Handled) {
        Boolean ehBackSpace = e.KeyChar == (Char)Keys.Back;
        String regex = BaseAtual?.Regex.FazRegex(e.KeyChar.ToString());
        e.Handled = !ehBackSpace && regex == "";
      }
    }

    private void PrecionouEnterNoTextBox(KeyEventArgs e) {
      if (e.KeyData == Keys.Enter) {
        if (BaseAtual != null && BaseNova != null) {
          String regex = BaseAtual?.Regex.FazRegex(ValorInformado);
          if (regex != "") {
            Converter();
          }
        }
      }
    }

    private void tbValor_KeyPress(Object sender, KeyPressEventArgs e) {
      ManipulaTeclas(e);
    }

    private void cbBaseDoValor_SelectedIndexChanged(object sender, EventArgs e) {
      ResetaCamposAoAlterarBaseAtual();
    }

    private void tbValor_KeyUp(object sender, KeyEventArgs e) {
      PrecionouEnterNoTextBox(e);
    }

  }
}