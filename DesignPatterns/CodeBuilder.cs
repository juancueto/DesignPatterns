using System;
using System.Text;

namespace DesignPatterns
{
	public class FieldElement
	{
		public string NameType, FieldType;
		public List<FieldElement> Elements = new List<FieldElement>();
		
        public FieldElement()
        {

        }

        public FieldElement(string nameType, string fieldType)
        {
			this.NameType = nameType;
			this.FieldType = fieldType;
        }

		public override string ToString()
		{
			var sb = new StringBuilder();
            foreach (var item in Elements)
            {
				sb.AppendLine($"  public {item.FieldType} {item.NameType};");
            }
			return sb.ToString();
		}
	}

	public class CodeBuilder
	{
		public string className;
		private FieldElement root = new FieldElement();

		public CodeBuilder(string name)
		{
			this.className = name;
		}

		public CodeBuilder AddField(string fieldName, string fieldType)
		{
			var e = new FieldElement(fieldName, fieldType);
			root.Elements.Add(e);
			return this;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"public class {className}");
			sb.AppendLine("{");
			sb.Append(root.ToString());
			sb.Append("}");
			return sb.ToString();
		}

		//public void Clear()
		//{
		//	root = new FieldElement { na = className };
		//}
	}
}

