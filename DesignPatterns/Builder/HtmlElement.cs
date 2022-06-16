using System;
using System.Text;

namespace DesignPatterns.Builder
{
	public class BasicHtmlElement
	{
		public void GetBasicHtmlElement ()
		{
			var hello = "hello";
			var sb = new StringBuilder();
			sb.Append("<p>");
			sb.Append(hello);
			sb.Append("</p>");
			Console.WriteLine(sb);
		}

		public void GetComplicatedHtmlElement()
		{
			var words = new[] { "hello", "world" };
			var sb = new StringBuilder();
			sb.Append("<ul>");
            foreach (var word in words)
            {
				sb.AppendFormat("<li>{0}</li>", word);
            }
			sb.Append("</ul>");
			Console.WriteLine(sb);
		}
	}

	public class HtmlElement
	{
		public string Name, Text;
		public List<HtmlElement> Elements = new List<HtmlElement>();
		private const int indentSize = 2;

        public HtmlElement()
        {

        }

        public HtmlElement(string name, string text)
        {
			Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
			Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
		}

		private string ToStringImpl(int indent)
		{
			var sb = new StringBuilder();
			var i = new string(' ', indentSize * indent);
			sb.AppendLine($"{i}<{Name}>");
			if (!string.IsNullOrWhiteSpace(Text))
			{
				sb.Append(new string(' ', indentSize * (indent + 1)));
				sb.AppendLine(Text);
			}

            foreach (var e in Elements)
            {
				sb.Append(e.ToStringImpl(indent + 1));
            }

			sb.AppendLine($"{i}</{Name}>");
			return sb.ToString();
		}

        public override string ToString()
        {
			return ToStringImpl(0);
        }
    }

	public class HtmlBuilder
	{
		private readonly string rootName;
		HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
			this.rootName = rootName;
			root.Name = rootName;			
        }

		public HtmlBuilder AddChild(string childName, string ChildText)
		{
			var e = new HtmlElement(childName, ChildText);
			root.Elements.Add(e);
			return this;
		}

        public override string ToString()
        {
			return root.ToString();
        }

		public void Clear()
		{
			root = new HtmlElement { Name = rootName };
		}
    }
}

