#region License

// Copyright Jeremy Skinner (http://www.jeremyskinner.co.uk) and Contributors
// 
// Licensed under the Microsoft Public License. You may
// obtain a copy of the license at:
// 
// http://www.microsoft.com/opensource/licenses.mspx
// 
// By using this source code in any fashion, you are agreeing
// to be bound by the terms of the Microsoft Public License.
// 
// You must not remove this notice, or any other, from this software.

#endregion

namespace Phantom.Core.Builtins {
	using System;
	using System.Collections.Generic;
	using System.Runtime.CompilerServices;

	[CompilerGlobalScope]
	public static class UtilityFunctions {
		/// Gets an environment variable
		/// </summary>
		/// <param name="variableName">Name of the variable</param>
		/// <returns>The variable's value</returns>
		public static string env(string variableName) {
			return Environment.GetEnvironmentVariable(variableName);
		}

		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
			foreach (var item in source) {
				action(item);
			}
		}
	}
}