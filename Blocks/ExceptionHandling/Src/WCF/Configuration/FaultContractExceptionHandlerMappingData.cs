//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Exception Handling Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.WCF.Configuration
{
	/// <summary>
	/// Represents a mapping for a fault contract property from either an exception property or a GUID.
	/// </summary>
	public class FaultContractExceptionHandlerMappingData : NamedConfigurationElement
	{
		/// <summary>
		/// Initializes a new instance of class <see cref="FaultContractExceptionHandlerMappingData"/>.
		/// </summary>
		public FaultContractExceptionHandlerMappingData()
		{ }

		/// <summary>
		/// Initializes a new instance of class <see cref="FaultContractExceptionHandlerMappingData"/> with a name and a source.
		/// </summary>
		/// <param name="name">The name of the configuration element.</param>
		/// <param name="source">The source for the property mapping.</param>
		public FaultContractExceptionHandlerMappingData(string name, string source)
		{
			this.Name = name;
			this.Source = source;
		}

		private const string SourcePropertyName = "source";
		/// <summary>
		/// Gets or sets the source for the fault contract property.
		/// </summary>
		/// <value>Either the name of the source property in the exception or a GUID.</value>
		[ConfigurationProperty(SourcePropertyName)]
		public string Source
		{
			get { return (string)this[SourcePropertyName]; }
			set { this[SourcePropertyName] = value; }
		}
	}
}
