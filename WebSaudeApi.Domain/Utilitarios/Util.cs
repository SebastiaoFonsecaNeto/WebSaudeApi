using System;
using System.Text;

namespace WebSaude.Domain.Utilitarios
{
    public class Util
    {
        public static string GeraHash(string id)
        {
            var data = DateTime.Now.ToString("ddMMyyyyhhmmss");

            var crip = string.Empty;
            var random = new Random();
            foreach (var character in data)
            {
                crip += CaracterComum(random.NextDouble()) + Numerico(random) + CaracterEspecial(random) +
                        CaracterComum(random.NextDouble()) + Numerico(random) + CaracterEspecial(random) +
                        character;
            }

            return crip + "id" + id;
        }

        private static string CaracterComum(double random)
        {
            var builder = new StringBuilder();
            return builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26*random + 65)))).ToString();
        }

        private static char CaracterEspecial(Random random)
        {
            const string characterDisponivel = "!#$%&*-+^~";
            var index = random.Next(characterDisponivel.Length);
            return characterDisponivel[index];
        }

        private static char Numerico(Random random)
        {
            const string characterDisponivel = "1234567890";
            var index = random.Next(characterDisponivel.Length);
            return characterDisponivel[index];
        }
    }
}