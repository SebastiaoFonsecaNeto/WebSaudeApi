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
            var builder = new StringBuilder();
            var index = 0;
            foreach (var character in data)
            {
                builder.Clear();
                crip +=
                    builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)))).ToString() +
                    CaracterEspecial(random) + id[index] + character;
                index++;
            }

            return crip;
        }

        private static char CaracterEspecial(Random rng)
        {
            const string characterDisponivel = "!#$%&*-+^~";
            var index = rng.Next(characterDisponivel.Length);
            return characterDisponivel[index];
        }
    }
}