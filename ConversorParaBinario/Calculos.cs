using System;
using System.Text.RegularExpressions;

namespace ConversorParaBinario {

    public static class Calculos {

        public static String DecimalParaQualquerBase(String valor, int baseResuldaConversao) {
            int val = valor.Length == 0 ? 0 : Convert.ToInt32(valor);
            String res = "";
            while (val > 0) {
                int mod = val % baseResuldaConversao;
                val = val / baseResuldaConversao;
                var modString = mod.ToString();
                if (mod > 9) {
                    switch (modString) {
                        case "10":
                            modString = "A";
                            break;
                        case "11":
                            modString = "B";
                            break;
                        case "12":
                            modString = "C";
                            break;
                        case "13":
                            modString = "D";
                            break;
                        case "14":
                            modString = "E";
                            break;
                        case "15":
                            modString = "F";
                            break;
                    }
                }
                res = $"{modString}{res}";
            }
            return res;
        }

        public static String QualquerBaseParaDecimal(String valor, int BaseValor) {
            string d = "";
            int j = 0;
            double res = 0;

            for (int i = valor.Length - 1; i >= 0; i--) {
                if (Char.IsLetter(valor[i])) {
                    switch (valor[i].ToString()) {
                        case "A":
                            d = "10";
                            break;
                        case "B":
                            d = "11";
                            break;
                        case "C":
                            d = "12";
                            break;
                        case "D":
                            d = "13";
                            break;
                        case "E":
                            d = "14";
                            break;
                        case "F":
                            d = "15";
                            break;
                    }
                    Int32 n = Convert.ToInt32(d);
                    res = res + (n * Math.Pow(BaseValor, j));
                    j++;
                } else {
                    Int32 n = Convert.ToInt32(valor[i].ToString());
                    res = res + (n * Math.Pow(BaseValor, j));
                    j++;
                }
            }
            return res.ToString();
        }

        /*public static String BinParaOctal(String valor) {
            string n = "";
            string result = "";
            for (int i = valor.Length - 1; i >= -1;) {
                if (n.Length != 3 && i >= 0) {
                    n = valor[i] + n;
                    i--;
                } else if (i == -1) {
                    result = QualquerBaseParaDecimal(n, 2) + result;
                    break;
                } else {
                    result = QualquerBaseParaDecimal(n, 2) + result;
                    n = "";
                }
            }
            return result;
        }*/

        public static String BinarioParaOctal(String valor) {
            // binário para decimal
            string dec = QualquerBaseParaDecimal(valor, 2);
            //decimal para octal
            String res = DecimalParaQualquerBase(dec, 8);
            return res;
        }

        /* public static String BinarioParaHexadecimal(String valor) {
             int d = 0;
             string bin = "";
             string dec = "";
             string res = "";
             for (int i = valor.Length - 1; i > 0;) {
                 if (bin.Length != 4) {
                     bin = valor[i] + bin;
                     i--;
                 }
                 if (i == -1 || bin.Length == 4) {
                     dec = QualquerBaseParaDecimal(bin, 2);
                     d = Convert.ToInt32(dec);
                     if (d > 9) {
                         switch (d) {
                             case 10:
                                 dec = "A";
                                 break;
                             case 11:
                                 dec = "B";
                                 break;
                             case 12:
                                 dec = "C";
                                 break;
                             case 13:
                                 dec = "D";
                                 break;
                             case 14:
                                 dec = "E";
                                 break;
                             case 15:
                                 dec = "F";
                                 break;
                         }
                     }
                     res = $"{dec}{res}";
                     bin = "";
                 }
             }
             return res;
         }*/

        public static String BinarioParaHexadecimal(String valor) {
            string n = "";
            int d = 0;
            string bin = "";
            string dec = "";
            string res = "";

            while (valor.Length > 0) {

                Int32 tamanho = Math.Min(4, valor.Length);

                n = valor.Substring(valor.Length - tamanho, tamanho);
                valor = valor.Remove(valor.Length - tamanho, tamanho);

                dec = QualquerBaseParaDecimal(n, 2);
                d = Convert.ToInt32(dec);
                if (d > 9) {
                    switch (d) {
                        case 10:
                            dec = "A";
                            break;
                        case 11:
                            dec = "B";
                            break;
                        case 12:
                            dec = "C";
                            break;
                        case 13:
                            dec = "D";
                            break;
                        case 14:
                            dec = "E";
                            break;
                        case 15:
                            dec = "F";
                            break;
                    }
                }
                res = $"{dec}{res}";
                bin = "";
            }
            return res;
        }

        public static String OctalParaBinario(String valor) {
            // octal para decimal
            String n = QualquerBaseParaDecimal(valor, 8);
            // decimal para binario;
            String res = DecimalParaQualquerBase(n, 2);
            return res;
        }

        public static String OctalParaHexa(string valor) {
            // octal para decimal
            string dec = QualquerBaseParaDecimal(valor, 8);
            //decimal para hexadecimal
            string hex = DecimalParaQualquerBase(dec, 16);

            return hex;
        }

        public static String HexaParaBinarioOuOctal(String valor, Int32 BaseBinOuOctal) {
            // hexadecimal para decimal
            string res = QualquerBaseParaDecimal(valor,16);
            // hexadecimal para octal ou binário
            res = DecimalParaQualquerBase(res, BaseBinOuOctal);
            return res;
        }

    }

}