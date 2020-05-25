using System.Collections.Generic;

namespace IntelIntrinsicsGuide.Core
{
	public interface IIntrinsicInfo
	{
		string Name { get; }
		string ReturnType { get; }
		IEnumerable<IIntrinsicIParameter> Parameters { get; }
	}
}