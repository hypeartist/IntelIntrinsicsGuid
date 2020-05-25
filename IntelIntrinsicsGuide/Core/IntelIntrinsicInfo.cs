using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace IntelIntrinsicsGuide.Core
{
	public class IntelIntrinsicInfo : IIntrinsicInfo
	{
		private IntelIntrinsicInfo(XmlNode node)
		{
			Technology = node.Attributes?.GetNamedItem("tech")?.Value;
			ReturnType = node.Attributes?.GetNamedItem("rettype")?.Value;
			Name = node.Attributes?.GetNamedItem("name")?.Value.ToLower();
			Types = node.SelectNodes(@"type")?.Cast<XmlNode>().Select(n => n.InnerText).ToList();
			CPUIDs = node.SelectNodes(@"CPUID")?.Cast<XmlNode>().Select(n => n.InnerText).ToList();
			Categories = node.SelectNodes(@"category")?.Cast<XmlNode>().Select(n => n.InnerText).ToList();
			Parameters = node.SelectNodes(@"parameter")?.Cast<XmlNode>().Select(n => new IntrinsicIParameter(n.Attributes?.GetNamedItem("varname")?.Value, n.Attributes?.GetNamedItem("type")?.Value, n.Attributes?.GetNamedItem("hint")?.Value)).ToList();
			Description = node.SelectNodes(@"description")?.Cast<XmlNode>().Select(n => n.InnerText).FirstOrDefault();
			Operations = node.SelectNodes(@"operation")?.Cast<XmlNode>().Select(n => new Operation(n.InnerText, n.Attributes?.GetNamedItem("validate")?.Value?.ToLower() != "false")).ToList();
			Instructions = node.SelectNodes(@"instruction")?.Cast<XmlNode>().Select(n => new X86Instruction(n.Attributes?.GetNamedItem("name")?.Value, n.Attributes?.GetNamedItem("form")?.Value, n.Attributes?.GetNamedItem("xed") != null)).ToList();
			Sequence = node.Attributes?.GetNamedItem("sequence")?.Value?.ToLower() == "true";
			VEX = node.Attributes?.GetNamedItem("vexEq")?.Value?.ToLower() == "true";
			Header = node.SelectNodes(@"header")?.Cast<XmlNode>().Select(n => n.InnerText).FirstOrDefault();
		}

		public string Description { get; }

		public string Header { get; }

		public IEnumerable<string> Types { get; }

		public IEnumerable<string> CPUIDs { get; }

		public IEnumerable<string> Categories { get; }

		public IEnumerable<IIntrinsicIParameter> Parameters { get; }

		public IEnumerable<Operation> Operations { get; }

		public IEnumerable<X86Instruction> Instructions { get; }

		public string InstructionsAsText => string.Join(", ", Instructions.Select(i => i.ToString()));

		public string Technology { get; }

		public string ReturnType { get; }

		public string Name { get; }

		public bool Sequence { get; }

		public bool VEX { get; }

		public static async Task<IEnumerable<IntelIntrinsicInfo>> Collect()
		{
			var data = new List<IntelIntrinsicInfo>();
			await Task.Run(() =>
			{
				var xml = new XmlDocument();
				xml.LoadXml(Properties.Resources.software_intel_com_IntrinsicsGuide_data_3_4_6);
				data = xml.SelectNodes(@"//intrinsic")?.Cast<XmlNode>().Select(n => new IntelIntrinsicInfo(n)).ToList();
			});
			return data;
		}

		public sealed class X86Instruction
		{
			internal X86Instruction(string name, string form, bool xed)
			{
				Name = name;
				Form = form;
				Xed = xed;
			}

			public string Name { get; }

			public string Form { get; }

			public bool Xed { get; }

			public override string ToString() => $"{Name} {Form}";
		}

		public sealed class IntrinsicIParameter : IIntrinsicIParameter
		{
			internal IntrinsicIParameter(string name, string type, string hint)
			{
				Name = name;
				Type = type;
				Hint = hint;
			}

			public string Name { get; }

			public string Type { get; }

			public string Hint { get; }
		}

		public sealed class Operation
		{
			internal Operation(string description, bool validate)
			{
				Description = description;
				Validate = validate;
			}

			public bool Validate { get; }

			public string Description { get; }
		}
	}
}
