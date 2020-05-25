using System;
using System.Collections.Generic;
using IntelIntrinsicsGuide.Controls.HtmlRenderer.Core.Utils;

namespace IntelIntrinsicsGuide.Controls.HtmlRenderer.Core.Dom
{
    /// <summary>
    /// Used to make space on vertical cell combination
    /// </summary>
    internal sealed class CssSpacingBox : CssBox
    {
	    /// <summary>
        /// the index of the row where box starts
        /// </summary>
        private readonly int _startRow;

        /// <summary>
        /// the index of the row where box ends
        /// </summary>
        private readonly int _endRow;


        public CssSpacingBox(CssBox tableBox, ref CssBox extendedBox, int startRow)
            : base(tableBox, new HtmlTag("none", false, new Dictionary<string, string> { { "colspan", "1" } }))
        {
            ExtendedBox = extendedBox;
            Display = CssConstants.None;

            _startRow = startRow;
            _endRow = startRow + Int32.Parse(extendedBox.GetAttribute("rowspan", "1")) - 1;
        }

        public CssBox ExtendedBox { get; }

        /// <summary>
        /// Gets the index of the row where box starts
        /// </summary>
        public int StartRow => _startRow;

        /// <summary>
        /// Gets the index of the row where box ends
        /// </summary>
        public int EndRow => _endRow;
    }
}