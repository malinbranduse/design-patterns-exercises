using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    public class Sentence
    {
        private string[] words;
        private Dictionary<int, WordToken> tokens = new Dictionary<int, WordToken>();

        public Sentence(string plainText)
        {
            words = plainText.Split(' ');
        }

        public WordToken this[int index]
        {
            get
            {
                var wt = new WordToken();
                tokens.Add(index, wt);
                return tokens[index];
            }
        }

        public override string ToString()
        {
            return string.Join(
                " ",
                words.Select((w, i) =>
                    tokens.ContainsKey(i) && tokens[i].Capitalize
                        ? w.ToUpperInvariant()
                        : w)
            );
        }
    }
}
