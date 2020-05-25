using System.ComponentModel;

namespace IntelIntrinsicsGuide
{
	internal enum InstructionCategory
	{
		Undefined,
		[Description("Application-Targeted")]
		ApplicationTargeted,
		[Description("Arithmetic")]
		Arithmetic,
		[Description("Bit Manipulation")]
		BitManipulation,
		[Description("Cast")]
		Cast,
		[Description("Compare")]
		Compare,
		[Description("Convert")]
		Convert,
		[Description("Cryptography")]
		Cryptography,
		[Description("Elementary Math Functions")]
		ElementaryMathFunctions,
		[Description("General Support")]
		GeneralSupport,
		[Description("Load")]
		Load,
		[Description("Logical")]
		Logical,
		[Description("Mask")]
		Mask,
		[Description("Miscellaneous")]
		Miscellaneous,
		[Description("Move")]
		Move,
		[Description("OS-Targeted")]
		OSTargeted,
		[Description("Probability/Statistics")]
		ProbabilityStatistics,
		[Description("Random")]
		Random,
		[Description("Set")]
		Set,
		[Description("Shift")]
		Shift,
		[Description("Special Math Functions")]
		SpecialMathFunctions,
		[Description("Store")]
		Store,
		[Description("String Compare")]
		StringCompare,
		[Description("Swizzle")]
		Swizzle,
		[Description("Trigonometry")]
		Trigonometry
	}
}