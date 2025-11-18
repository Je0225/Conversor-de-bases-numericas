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
      Registry.Registra(new Decimal());
      Registry.Registra(new Binario());
      Registry.Registra(new Octal());
      Registry.Registra(new Hexadecimal());
    }

    static void RegistraRegexBases() {
      Registry.Registra(new RegexDecimal());
      Registry.Registra(new RegexBinario());
      Registry.Registra(new RegexOctal());
      Registry.Registra(new RegexHexadecimal());
    } 

    static void RegistraCalculos() {
      Registry.Registra(new DecimalParaQualquerBase());
      Registry.Registra(new QualquerBaseParaDecimal());
      Registry.Registra(new BinarioParaHexadecimal());
    }

  }
}
