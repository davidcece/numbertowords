
using System;
using System.Numerics;

namespace Exercise01
{
    public static class NumberExtension
    {

        private static Dictionary<string, string> _ones = new Dictionary<string, string>
        {
            {"1","One" },{"2","Two"},{"3","Three"},{"4","Four" },{"5","Five"},
            {"6","Six"},{"7","Seven" },{"8","Eight"},{"9","Nine"}
        };

        private static Dictionary<string, string> _teens = new Dictionary<string, string>
        {
            {"10","Ten" },{"11","Eleven" },{"12","Twelve"},{"13","Thirteen"},{"14","Fourteen" },
            {"15","Fifteen"},{"16","Sixteen"},{"17","Seventeen" },{"18","Eighteen"},{"19","Nineteen"}
        };

        private static Dictionary<string, string> _tens = new Dictionary<string, string>
        {
            {"20","Twenty" },{"30","Thirty" },{"40","Fourty"},{"50","Fifty"},
            {"60","Sixty" },{"70","Seventy"},{"80","Eighty" },{"90","Ninety"}
        };

        public static string getOnes(string num)
        {
            string result = String.Empty;
            if (_ones.ContainsKey(num))
            {
                result = _ones[num];
            }
            return result;
        }

        public static string getTens(string num)
        {
            num=num.PadLeft(2, '0');
            int number = int.Parse(num);
            if (number==0)
            {
                return string.Empty;
            }

            string result;
            if (_teens.ContainsKey(num))
            {
                result = _teens[num];
            }
            else if (_tens.ContainsKey(num))
            {
                result=_tens[num];
            }
            else
            {
                result = getTens(num[..1] + "0") + "-" + getOnes(num[1..]);
            }

            return result.Trim().Trim('-');
        }

        public static string getHundreds(string num)
        {
            num=num.PadLeft(3, '0');
            string hundreds;
            string ones = getOnes(num[..1]);
            string tens = getTens(num[1..]);

            if (ones.Length>0)
            {
                if (tens.Length>0)
                {
                    hundreds= string.Format("{0} Hundred and {1}", ones, tens);
                }
                else
                {
                    hundreds= string.Format("{0} Hundred", ones);
                }
            }
            else
            {
                hundreds=tens;
            }

            return hundreds;
        }

        public static string ToWords(this BigInteger num)
        {
            string number = num.ToString();
            return ConvertNumberToWords(number);
        }

        public static string ToWords(this int num)
        {
            string number = num.ToString();
            return ConvertNumberToWords(number);
        }

        public static string ToWords(this long num)
        {
            string number = num.ToString();
            return ConvertNumberToWords(number);
        }

        public static string ConvertNumberToWords(string number)
        {
            number=number.Replace(",", "");

            bool done = false;
            string result = string.Empty;
            string top;
            int mod;


            while (!done)
            {
                top = string.Empty;
                int len = number.Length;

                if (len>3)
                {
                    mod = len%3;
                    mod=mod==0 ? 3 : mod;
                    top = number[..mod];
                    number=number[mod..];
                }


                switch (len)
                {
                    case 1:
                        result=string.Format("{0} {1}", result, getOnes(number));
                        done=true;
                        break;
                    case 2:
                        result=string.Format("{0} {1}", result, getTens(number));
                        done=true;
                        break;
                    case 3:

                        if (result.Length>0)
                        {
                            string and = " ";
                            int num = int.Parse(number);
                            if (num>0&&num<100)
                            {
                                and=" and ";
                            }
                            result=string.Format("{0}{1}{2}", result, and, getHundreds(number));
                        }
                        else
                        {
                            result=string.Format("{0} {1}", result, getHundreds(number));
                        }

                        done=true;
                        break;
                    case 4://thousands    
                    case 5:
                    case 6:
                        result=formatResult(result, top, "Thousand");
                        break;
                    case 7://millions  
                    case 8:
                    case 9:
                        result=formatResult(result, top, "Million");
                        break;
                    case 10://Billions   
                    case 11:
                    case 12:
                        result=formatResult(result, top, "Billion");
                        break;
                    case 13://Trillion   
                    case 14:
                    case 15:
                        result=formatResult(result, top, "Trillion");
                        break;
                    case 16://Quadrillion   
                    case 17:
                    case 18:
                        result=formatResult(result, top, "Quadrillion");
                        break;
                    case 19://Quintillion   
                    case 20:
                    case 21:
                        result=formatResult(result, top, "Quintillion");
                        break;
                    case 22://Sextillion   
                    case 23:
                    case 24:
                        result=formatResult(result, top, "Sextillion");
                        break;
                    case 25://Septillion   
                    case 26:
                    case 27:
                        result=formatResult(result, top, "Septillion");
                        break;
                    case 28://Octillion   
                    case 29:
                    case 30:
                        result=formatResult(result, top, "Octillion");
                        break;
                    case 31://Nonillion   
                    case 32:
                    case 33:
                        result=formatResult(result, top, "Nonillion");
                        break;
                    case 34://Decillion   
                    case 35:
                    case 36:
                        result=formatResult(result, top, "Decillion");
                        break;
                    case 37://Undecillion   
                    case 38:
                    case 39:
                        result=formatResult(result, top, "Undecillion");
                        break;
                    case 40://Duodecillion   
                    case 41:
                    case 42:
                        result=formatResult(result, top, "Duodecillion");
                        break;
                    case 43://Tredecillion   
                    case 44:
                    case 45:
                        result=formatResult(result, top, "Tredecillion");
                        break;
                    case 46://Quattuordecillion   
                    case 47:
                    case 48:
                        result=formatResult(result, top, "Quattuordecillion");
                        break;
                    case 49://Quindecillion   
                    case 50:
                    case 51:
                        result=formatResult(result, top, "Quindecillion");
                        break;
                    case 52://Sexdecillion   
                    case 53:
                    case 54:
                        result=formatResult(result, top, "Sexdecillion");
                        break;
                    case 55://Septemdecillion   
                    case 56:
                    case 57:
                        result=formatResult(result, top, "Septemdecillion");
                        break;
                    case 58://Octodecillion   
                    case 59:
                    case 60:
                        result=formatResult(result, top, "Octodecillion");
                        break;
                    case 61://Novemdecillion   
                    case 62:
                    case 63:
                        result=formatResult(result, top, "Novemdecillion");
                        break;
                    case 64://Vigintillion   
                    case 65:
                    case 66:
                        result=formatResult(result, top, "Vigintillion");
                        break;
                    case 67://Unvigintillion   
                    case 68:
                    case 69:
                        result=formatResult(result, top, "Unvigintillion");
                        break;
                    case 70://Duovigintillion   
                    case 71:
                    case 72:
                        result=formatResult(result, top, "Duovigintillion");
                        break;
                    case 73://Trevigintillion   
                    case 74:
                    case 75:
                        result=formatResult(result, top, "Trevigintillion");
                        break;
                    case 76://Quattuorvigintillion   
                    case 77:
                    case 78:
                        result=formatResult(result, top, "Quattuorvigintillion");
                        break;
                    case 79://Quinvigintillion   
                    case 80:
                    case 81:
                        result=formatResult(result, top, "Quinvigintillion");
                        break;
                    case 82://Sexvigintillion   
                    case 83:
                    case 84:
                        result=formatResult(result, top, "Sexvigintillion");
                        break;
                    case 85://Septvigintillion   
                    case 86:
                    case 87:
                        result=formatResult(result, top, "Septvigintillion");
                        break;
                    case 88://Octovigintillion   
                    case 89:
                    case 90:
                        result=formatResult(result, top, "Octovigintillion");
                        break;
                    case 91://Nonvigintillion   
                    case 92:
                    case 93:
                        result=formatResult(result, top, "Nonvigintillion");
                        break;
                    case 94://Trigintillion   
                    case 95:
                    case 96:
                        result=formatResult(result, top, "Trigintillion");
                        break;
                    case 97://Untrigintillion   
                    case 98:
                    case 99:
                        result=formatResult(result, top, "Untrigintillion");
                        break;
                    case 100://Duotrigintillion   
                    case 101:
                    case 102:
                        result=formatResult(result, top, "Duotrigintillion");
                        break;
                    default:
                        done = true;
                        break;
                }


            }

            return result.Trim().Trim(',');
        }

        private static string formatResult(string result, string top, string place)
        {
            string hundreds = getHundreds(top);
            if (hundreds.Length>0)
            {
                result = string.Format("{0} {1} {2},", result, hundreds, place);
            }
            return result;
        }
    }
}
