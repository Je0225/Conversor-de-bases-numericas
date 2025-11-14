using System;
using System.Text.RegularExpressions;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.RegexBases {

  internal class RegexHexadecimal : IBaseRegex {

    public String FazRegex(String entrada) {
      return Regex.Replace(entrada, @"[^\dA-Fa-f]", "").ToUpper();
    }

  }

}