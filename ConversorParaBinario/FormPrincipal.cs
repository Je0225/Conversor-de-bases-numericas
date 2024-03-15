using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConversorParaBinario {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            cbBaseDoValor.Items.Add("Decimal");
            cbBaseDoValor.Items.Add("Binário");
            cbBaseDoValor.Items.Add("Octal");
            cbBaseDoValor.Items.Add("Hexadecimal");

            cbConverterPara.Items.Add("Decimal");
            cbConverterPara.Items.Add("Binário");
            cbConverterPara.Items.Add("Octal");
            cbConverterPara.Items.Add("Hexadecimal");
        }

        private void btnConverter_Click(object sender, EventArgs e) {

            String DeixaSoNumeros() {
                string valor = tbValor.Text.Trim().ToUpper();
                valor = Regex.Replace(tbValor.Text, @"[^\d]", "");
                if (valor.Length == 0) {
                    MessageBox.Show("Não há nenhum dígito válido para a conversão");
                    tbValor.Clear();
                    tbValor.Focus();
                    return "";
                } else {
                    tbValor.Text = valor;
                    return valor;
                }
            }

            String ValidaEntradaBinario() {
                string valor = DeixaSoNumeros();
                foreach (char digito in valor) {
                    if (digito != '0' && digito != '1') {
                        MessageBox.Show("Números binários devem ser compostos somente pelos dígitos 0 e/ou 1");
                        tbValor.Clear();
                        tbValor.Focus();
                        return  "";
                    } 
                }
                return valor;
            }

            String ValidaEntradaOctal() {
                string valor = DeixaSoNumeros();
                foreach (char digito in valor) {
                    if (digito == '8' || digito == '9') {
                        MessageBox.Show("Números com base octal não podem conter os digitos 8 e 9");
                        tbValor.Clear();
                        tbValor.Focus();
                        return "";
                    }
                }
                return valor;
            }

            String ValidaEntradaHexa() {
                string valor = tbValor.Text.ToUpper().Trim();
                foreach (char digito in valor) {
                    if (Char.IsLetter(digito)) {
                        if (digito != 'A' && 
                            digito != 'B' && 
                            digito != 'C' && 
                            digito != 'D' && 
                            digito != 'E' && 
                            digito != 'F') {
                            MessageBox.Show("Números hexadecimais podem não conter letras diferentes de A,B,C,D,E e/ou F");
                            tbValor.Clear();
                            tbValor.Focus();
                            return "";
                        }
                    }
                }
                return valor;
            }

                switch (cbBaseDoValor.SelectedIndex) {
                    case 0:
                        switch (cbConverterPara.SelectedIndex) {
                            case 1:
                                lblResult.Text = Calculos.DecimalParaQualquerBase(DeixaSoNumeros(), 2);
                                break;
                            case 2:
                                lblResult.Text = Calculos.DecimalParaQualquerBase(DeixaSoNumeros(), 8);
                                break;
                            case 3:
                                lblResult.Text = Calculos.DecimalParaQualquerBase(DeixaSoNumeros(), 16);
                                break;
                            default:
                                MessageBox.Show("Não é necessário realizar uma conversão");
                                break;
                        }
                        break;
                    case 1:
                        switch (cbConverterPara.SelectedIndex) {
                            case 0:
                                lblResult.Text = Calculos.QualquerBaseParaDecimal(ValidaEntradaBinario(), 2);
                                break;
                            case 2:
                            //lblResult.Text = Calculos.BinParaOctal(ValidaEntradaBinário());
                            lblResult.Text = Calculos.BinarioParaOctal(ValidaEntradaBinario());
                                break;
                            case 3:
                            //lblResult.Text = Calculos.BinarioParaHexadecimal(ValidaEntradaBinário());
                            lblResult.Text = Calculos.BinarioParaHexadecimal(ValidaEntradaBinario());
                                break;
                            default:
                                MessageBox.Show("Não é necessário realizar uma conversão");
                                break;
                        }
                        break;
                    case 2:
                        switch (cbConverterPara.SelectedIndex) {
                            case 0:
                                lblResult.Text = Calculos.QualquerBaseParaDecimal(ValidaEntradaOctal(), 8);
                                break;
                            case 1:
                                lblResult.Text = Calculos.OctalParaBinario(ValidaEntradaOctal());
                                break;
                            case 3:
                                lblResult.Text = Calculos.OctalParaHexa(ValidaEntradaOctal());
                                break;
                            default:
                                MessageBox.Show("Não é necessário realizar uma conversão");
                                break;
                        }
                        break;
                    case 3:
                        switch (cbConverterPara.SelectedIndex) {
                            case 0:
                                lblResult.Text = Calculos.QualquerBaseParaDecimal(ValidaEntradaHexa(),16);
                                break;
                            case 1:
                                lblResult.Text = Calculos.HexaParaBinarioOuOctal(ValidaEntradaHexa(), 2);
                                break;
                            case 2:
                                lblResult.Text = Calculos.HexaParaBinarioOuOctal(ValidaEntradaHexa(), 8);
                                break;
                            default:
                                MessageBox.Show("Não é necessário realizar uma conversão");
                                break;
                        }
                        break;
                }
            }

        private void btnLimpar_Click(object sender, EventArgs e) {
            tbValor.Clear();
            lblResult.Text = "";
            tbValor.Focus();
        }
    }

    }