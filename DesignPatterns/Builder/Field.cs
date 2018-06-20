using System.Text;

namespace Builder
{
    public class Field
    {
        public string Accessor { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Field(string name, string type, string accessor)
        {
            Name = name;
            Type = type;
            Accessor = accessor;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} ", Accessor)
              .AppendFormat("{0} ", Type)
              .AppendFormat("{0};", Name);

            return sb.ToString();
        }
    }
}
