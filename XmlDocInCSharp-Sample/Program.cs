// <copyright file="Program.cs" company="KIENBOECK">
// Copyright (c) KIENBOECK. All rights reserved.
// </copyright>
// <author>Daniel Kienboeck</author>
namespace XmlDocInCSharp_Sample
{
    using System;

    /// <summary>
    /// Class containing the entry point and starting the logic.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point.
        /// </summary>
        /// <param name="args">Arguments from command line.</param>
        public static void Main(string[] args)
        {
            // https://www.doxygen.nl/manual/starting.html
            // doxygen -g <config-file>
            // doxygen <config-file>
            // -----------------------------------------------
            // https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/EnableConfiguration.md
            Console.WriteLine(new Logic().DoTheLogic("mystic input"));
        }
    }
}
