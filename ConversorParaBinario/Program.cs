using System;
using System.Windows.Forms;
using ConversorParaBinario.Bases;
using ConversorParaBinario.CalculosBases;
using ConversorParaBinario.RegexBases;
using Decimal = ConversorParaBinario.Bases.Decimal;

namespace ConversorParaBinario {
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      RegistraRegexBases();
      RegistraBases();
      RegistraCalculos();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormPrincipal());
    }

    static void RegistraBases() {
      Registry.Registrar<Decimal>(new Decimal());
      Registry.Registrar<Binario>(new Binario());
      Registry.Registrar<Octal>(new Octal());
      Registry.Registrar<Hexadecimal>(new Hexadecimal());
    }

    static void RegistraRegexBases() {
      Registry.Registrar<RegexDecimal>(new RegexDecimal());
      Registry.Registrar<RegexBinario>(new RegexBinario());
      Registry.Registrar<RegexOctal>(new RegexOctal());
      Registry.Registrar<RegexHexadecimal>(new RegexHexadecimal());
    }

    static void RegistraCalculos() {
      Registry.Registrar<DecimalParaQualquerBase>(new DecimalParaQualquerBase());
      Registry.Registrar<QualquerBaseParaDecimal>(new QualquerBaseParaDecimal());
      Registry.Registrar<BinarioParaHexadecimal>(new BinarioParaHexadecimal());
    }

  }
}
