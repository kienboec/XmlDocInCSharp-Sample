// <copyright file="Logic.cs" company="KIENBOECK">
// Copyright (c) KIENBOECK. All rights reserved.
// </copyright>
// <author>Daniel Kienboeck</author>

namespace XmlDocInCSharp_Sample
{
    /// <summary>
    /// Here is the class for the logic.
    /// </summary>
    public class Logic
    {
        /// <summary>
        /// Gets or sets a value indicating whether we should force the magic.
        /// </summary>
        public bool ForceTheMagic { get; set; } = true;

        /// <summary>
        /// In "do the logic" the mystic input is converted to pure magic.
        /// </summary>
        /// <param name="input">Some mystic input.</param>
        /// <returns>Here the magic becomes true (plain text).</returns>
        public string DoTheLogic(string input)
        {
            if (this.ForceTheMagic)
            {
                return "magic";
            }

            return $"simsalabim only ({input})";
        }
    }
}
