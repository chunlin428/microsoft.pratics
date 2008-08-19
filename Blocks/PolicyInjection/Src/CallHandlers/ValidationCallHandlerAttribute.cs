//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Policy Injection Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers
{
    /// <summary>
    /// An attribute that applies the <see cref="ValidationCallHandler"/> to its target.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class ValidationCallHandlerAttribute : HandlerAttribute
    {
        private string ruleSet;
        private SpecificationSource specificationSource;

        /// <summary>
        /// Constructs a new <see cref="ValidationCallHandlerAttribute"/> that uses the
        /// default ruleset.
        /// </summary>
        public ValidationCallHandlerAttribute() : this(string.Empty)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="ValidationCallHandlerAttribute"/> that uses the
        /// given ruleset.
        /// </summary>
        /// <param name="ruleSet">Ruleset name to use.</param>
        public ValidationCallHandlerAttribute(string ruleSet)
        {
            this.ruleSet = ruleSet;
            this.specificationSource = SpecificationSource.Both;
        }

        /// <summary>
        /// <see cref="SpecificationSource"/> determining where to get validation rules.
        /// </summary>
        /// <value>specification source.</value>
        public SpecificationSource SpecificationSource
        {
            get { return specificationSource; }
            set { specificationSource = value; }
        }

        /// <summary>
        /// Derived classes implement this method. When called, it
        /// creates a new call handler as specified in the attribute
        /// configuration.
        /// </summary>
        /// <returns>A new call handler object.</returns>
        public override ICallHandler CreateHandler()
        {
            return new ValidationCallHandler(ruleSet, specificationSource, Order);
        }
    }
}
