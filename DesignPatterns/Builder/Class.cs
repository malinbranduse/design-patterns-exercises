using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Class
    {
        private const int indentSize = 2;
        public string Accessor { get; set; }
        public string Name { get; set; }
        public IList<Field> Fields { get; set; }

        public Class(string name, string accessor)
        {
            Name = name;
            Accessor = accessor;
            Fields = new List<Field>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0} class {1}", Accessor, Name).AppendLine()
              .AppendLine("{");

            foreach (var field in Fields)
            {
                var indent = new string(' ', indentSize);
                sb.Append(indent).Append(field).AppendLine();
            }

            sb.Append("}");

            return sb.ToString();
        }
    }
}
