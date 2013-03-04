﻿#region License
// IHelpCommandLineOptionFluent.cs
// Copyright (c) 2013, Simon Williams
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provide
// d that the following conditions are met:
// 
// Redistributions of source code must retain the above copyright notice, this list of conditions and the
// following disclaimer.
// 
// Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
// the following disclaimer in the documentation and/or other materials provided with the distribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED 
// WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
// TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.
#endregion

using System;

namespace Fclp
{
	/// <summary>
	/// Provides the fluent interface for setting up the help arguments.
	/// </summary>
	public interface IHelpCommandLineOptionFluent
	{
		/// <summary>
		/// Specifies the method to invoke with the formatted command line options when any of the setup 
		/// help arguments are found. If a callback is not required either do not call it, or specify <c>null</c>.
		/// </summary>
		/// <param name="callback">
		/// The callback to execute with the formatted command line options. 
		/// </param>
		/// <returns>A <see cref="ICommandLineOptionFluent{T}"/>.</returns>
		/// <remarks>
		/// An example use of this would be to write the provided <see cref="System.String"/> containing the formatted
		/// options directly to the console. If you would like to use a custom formatter you can do so by providing
		/// one using the <see cref="WithCustomFormatter"/> method.
		/// </remarks>
		IHelpCommandLineOptionFluent Callback(Action<string> callback);

		/// <summary>
		/// Registers a custom <see cref="ICommandLineOptionFormatter"/> to use to generate the help text.
		/// </summary>
		/// <param name="formatter">The custom formatter to use. This must not be <c>null</c>.</param>
		IHelpCommandLineOptionFluent WithCustomFormatter(ICommandLineOptionFormatter formatter);
	}
}