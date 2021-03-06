﻿using System.ComponentModel;
using System.Drawing;

namespace IntelIntrinsicsGuide
{
	internal enum InstructionSet 
	{
		[UniqueColor(nameof(Color.Black))]
		Undefined,
		[Description("MMX")]
		[UniqueColor(nameof(Color.Gold))]
		MMX,
		[Description("SSE")]
		[UniqueColor(nameof(Color.LawnGreen))]
		SSE,
		[Description("SSE2")]
		[UniqueColor(nameof(Color.OliveDrab))]
		SSE2,
		[Description("SSE3")]
		[UniqueColor(nameof(Color.DarkGreen))]
		SSE3,
		[Description("SSSE3")]
		[UniqueColor(nameof(Color.LightSeaGreen))]
		SSSE3,
		[Description("SSE4.1")]
		[UniqueColor(nameof(Color.SteelBlue))]
		SSE41,
		[Description("SSE4.2")]
		[UniqueColor(nameof(Color.Blue))]
		SSE42,
		[Description("AVX")]
		[UniqueColor(nameof(Color.DarkOrchid))]
		AVX,
		[Description("AVX2")]
		[UniqueColor(nameof(Color.Fuchsia))]
		AVX2,
		[Description("FMA")]
		[UniqueColor(nameof(Color.PaleVioletRed))]
		FMA,
		[Description("AVX-512")]
		[UniqueColor(nameof(Color.Red))]
		AVX512,
		[Description("KNC")]
		[UniqueColor(nameof(Color.SaddleBrown))]
		KNC,
		[Description("AVX-512/KNC")]
		[UniqueColor(nameof(Color.Coral))]
		AVX512KNC,
		[Description("SVML")]
		[UniqueColor(nameof(Color.SlateGray))]
		SVML,
		[Description("SVML/KNC")]
		[UniqueColor(nameof(Color.DarkSlateGray))]
		SVMLKNC,
		[Description("Other")]
		[UniqueColor(nameof(Color.Black))]
		Other
	}
}