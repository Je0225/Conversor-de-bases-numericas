using System;
using System.Text.RegularExpressions;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.RegexBases {

  internal class RegexBinario: IBaseRegex {

    public String FazRegex(String entrada) {
      return Regex.Replace(entrada, @"[^01]", "");
    }

  }

}