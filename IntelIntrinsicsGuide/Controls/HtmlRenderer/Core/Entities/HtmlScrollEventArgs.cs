// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they begin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

using System;
using IntelIntrinsicsGuide.Controls.HtmlRenderer.Adapters.Entities;

namespace IntelIntrinsicsGuide.Controls.HtmlRenderer.Core.Entities
{
    /// <summary>
    /// Raised when Html Renderer request scroll to specific location.<br/>
    /// This can occur on document anchor click.
    /// </summary>
    public sealed class HtmlScrollEventArgs : EventArgs
    {
        /// <summary>
        /// the location to scroll to
        /// </summary>
        private readonly RPoint _location;

        /// <summary>
        /// Init.
        /// </summary>
        /// <param name="location">the location to scroll to</param>
        public HtmlScrollEventArgs(RPoint location)
        {
            _location = location;
        }

        /// <summary>
        /// the x location to scroll to
        /// </summary>
        public double X => _location.X;

        /// <summary>
        /// the x location to scroll to
        /// </summary>
        public double Y => _location.Y;

        public override string ToString()
        {
            return $"Location: {_location}";
        }
    }
}