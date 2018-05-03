using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace ACDtask
{
    static class Rikiavimas
    {
        public static string surikiuotiFaila(String orgFailoPavadinimas)
        {
            try
            {
                List<Eilute> visosEilutes = new List<Eilute>();
                string naujoFailoPavadinimas = "output.txt";

                string[] nuskaitytasFailas = File.ReadAllLines(orgFailoPavadinimas, Encoding.Default);
                foreach (string eil in nuskaitytasFailas)
                {
                    string[] eilutesZodziai = eil.Split('\t');
                    Eilute temp = new Eilute(eilutesZodziai);
                    visosEilutes.Add(temp);
                }

                //--surikiuojam duomenis--------------------------------------------------------------------------------------------------
                for (int j = 0; j < visosEilutes.Count - 1; j++)
                {
                    for (int i = 0; i < visosEilutes.Count - 1; i++)
                    {
                        string a = "";
                        string b = "";

                        for (int s = 0; s < visosEilutes[i].getZodziai().Length; s++)
                        {
                            a = visosEilutes[i].getZodziai()[s];
                            b = visosEilutes[i + 1].getZodziai()[s];

                            if (!a.Equals(b)) break;
                        }

                        int kurisDidesnis = raskDidesni(a, b);

                        if (kurisDidesnis == 1)
                        {
                            Eilute temp = visosEilutes[i];

                            visosEilutes[i] = visosEilutes[i + 1];
                            visosEilutes[i + 1] = temp;
                        }

                    }
                }

                //--rezultata issaugojam naujamr faile------------------------------------------------------------------------------------
                foreach (Eilute e in visosEilutes)
                {
                    string eilute = "";
                    foreach (string s in e.getZodziai())
                    {
                        eilute += s + "\t";
                    }


                    File.AppendAllText(naujoFailoPavadinimas, eilute + Environment.NewLine);
                }

                return naujoFailoPavadinimas;
            }
            catch (Exception e)
            {
                return "0";
            }
        }

        public static int raskDidesni(string a, string b)
        {
            int kurisDidesnis;

            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b)) kurisDidesnis = 0;
            else if (String.IsNullOrEmpty(a)) kurisDidesnis = 1;
            else if (String.IsNullOrEmpty(b)) kurisDidesnis = -1;
            else
            {
                NumberFormatInfo format = new NumberFormatInfo();
                format.NumberDecimalSeparator = ".";

                double aa;
                bool isNumericA = double.TryParse(a, NumberStyles.Any, format, out aa);
                double bb;
                bool isNumericB = double.TryParse(b, NumberStyles.Any, format, out bb);

                if (isNumericA && isNumericB)
                {
                    kurisDidesnis = aa.CompareTo(bb);

                }
                else if (!isNumericA && !isNumericB)
                {
                    kurisDidesnis = a.CompareTo(b);
                }
                else if (isNumericA) kurisDidesnis = -1;
                else kurisDidesnis = 1;
            }

            return kurisDidesnis;
        }
        
    }
}
