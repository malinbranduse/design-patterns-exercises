
namespace Builder
{
    public class CodeBuilder
    {
        private string className;
        private Class Class;

        public CodeBuilder(string className, string accessor = "public")
        {
            this.className = className;
            this.Class = new Class(className, accessor);
        }

        public CodeBuilder AddField(string name, string type, string accessor = "public")
        {
            this.Class.Fields.Add(new Field(name, type, accessor));
            return this;
        }

        public override string ToString()
        {
            return Class.ToString();
        }
    }
}
