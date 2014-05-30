using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade10.Fixacao
{
    class IMC
    {
        public static string Imc(double altura, double peso, double media)
        {
            media = peso / Math.Pow(altura, 2);
            if (media < 17)
            {
                return "Muito abaixo do peso" + media;
            }
            else
                if (media >= 17 && media <= 18.49)
                {
                    return "Abaixo do peso" + media;
                }
                else
                    if (media >= 18.5 && media <= 24.99)
                    {
                        return "Peso normal" + media;
                    }
                    else
                        if (media >= 25 && media <= 29.99)
                        {
                            return "Acima do peso" + media;
                        }
                        else
                            if (media >= 30 && media <= 34.99)
                            {
                                return "Obesidade 1" + media;
                            }
                            else
                                if (media >= 35 && media <= 39.99)
                                {
                                    return "Obesidade 2(Severa)" + media;
                                }
                                else
                                    if (media > 40)
                                    {
                                        return "Obesidade morbida" + media;
                                    }
                                    else
                                        return "";
        }
        static void Main231(string[] args)
        {
            double media = 0;
            Console.WriteLine("Informe sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            string result = Imc(altura, peso, media);
            Console.WriteLine(result);
        }
    }
}
