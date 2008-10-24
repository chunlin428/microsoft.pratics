﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Validation Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Practices.EnterpriseLibrary.Validation.Properties;
using Microsoft.Practices.EnterpriseLibrary.Validation.Tests.TestClasses;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Tests
{
    [TestClass]
    public class NotNullValidatorFixture
    {
        [TestMethod]
        public void NonNegatedValidatorReturnsSuccessForNonNullReference()
        {
            Validator validator = new NotNullValidator();

            ValidationResults validationResults = validator.Validate("value");

            Assert.IsTrue(validationResults.IsValid);
        }

        [TestMethod]
        public void NegatedValidatorReturnsFailureForNonNullReference()
        {
            Validator validator = new NotNullValidator(true);

            ValidationResults validationResults = validator.Validate("value");

            Assert.IsFalse(validationResults.IsValid);
            IList<ValidationResult> resultsList = ValidationTestHelper.GetResultsList(validationResults);
            Assert.AreEqual(1, resultsList.Count);
            Assert.AreEqual(Resources.NonNullNegatedValidatorDefaultMessageTemplate, resultsList[0].Message);
        }

        [TestMethod]
        public void NonNegatedValidatorReturnsFailureForNullReference()
        {
            Validator validator = new NotNullValidator();

            ValidationResults validationResults = validator.Validate(null);

            Assert.IsFalse(validationResults.IsValid);
            IList<ValidationResult> resultsList = ValidationTestHelper.GetResultsList(validationResults);
            Assert.AreEqual(1, resultsList.Count);
            Assert.AreEqual(Resources.NonNullNonNegatedValidatorDefaultMessageTemplate, resultsList[0].Message);
        }

        [TestMethod]
        public void NegatedValidatorReturnsSuccessForNullReference()
        {
            Validator validator = new NotNullValidator(true);

            ValidationResults validationResults = validator.Validate(null);

            Assert.IsTrue(validationResults.IsValid);
        }

        [TestMethod]
        public void ReturnsFailureWithOverriddenMessageForNullReference()
        {
            string message = "overriden message";

            Validator validator = new NotNullValidator(message);

            ValidationResults validationResults = validator.Validate(null);

            Assert.IsFalse(validationResults.IsValid);
            IList<ValidationResult> resultsList = ValidationTestHelper.GetResultsList(validationResults);
            Assert.AreEqual(1, resultsList.Count);
            Assert.AreEqual(message, resultsList[0].Message);
        }

        [TestMethod]
        public void CreatingInstanceWithoutMessageTemplateUsesDefaultTemplate()
        {
            NotNullValidator validator = new NotNullValidator();

            Assert.AreEqual(Resources.NonNullNonNegatedValidatorDefaultMessageTemplate, validator.MessageTemplate);
            Assert.AreEqual(false, validator.Negated);
        }

        [TestMethod]
        public void CreatingInstanceWithMessageTemplateUsesProvidedTemplate()
        {
            NotNullValidator validator = new NotNullValidator("message template override");

            Assert.AreEqual("message template override", validator.MessageTemplate);
            Assert.AreEqual(false, validator.Negated);
        }

        [TestMethod]
        public void CreatingInstanceWithNegated()
        {
            NotNullValidator validator = new NotNullValidator(true);

            Assert.AreEqual(Resources.NonNullNegatedValidatorDefaultMessageTemplate, validator.MessageTemplate);
            Assert.AreEqual(true, validator.Negated);
        }

        [TestMethod]
        public void CreatingInstanceWithNonNegated()
        {
            NotNullValidator validator = new NotNullValidator(false);

            Assert.AreEqual(Resources.NonNullNonNegatedValidatorDefaultMessageTemplate, validator.MessageTemplate);
            Assert.AreEqual(false, validator.Negated);
        }

        [TestMethod]
        public void CreatingInstanceWithMessageTemplateUsesProvidedTemplateAndNnegated()
        {
            NotNullValidator validator = new NotNullValidator(true, "message template override");

            Assert.AreEqual("message template override", validator.MessageTemplate);
            Assert.AreEqual(true, validator.Negated);
        }

        [TestMethod]
        public void CreatingInstanceWithNullMessageTemplateUsesDefaultTemplate()
        {
            NotNullValidator validator = new NotNullValidator(null);

            Assert.AreEqual(Resources.NonNullNonNegatedValidatorDefaultMessageTemplate, validator.MessageTemplate);
            Assert.AreEqual(false, validator.Negated);
        }

        [TestMethod]
        public void ResourceValuesHaveBeenDefined()
        {
            Assert.IsFalse(string.IsNullOrEmpty(Resources.NonNullNegatedValidatorDefaultMessageTemplate));
            Assert.IsFalse(string.IsNullOrEmpty(Resources.NonNullNonNegatedValidatorDefaultMessageTemplate));
        }

        [TestMethod]
        public void SuppliesAppropriateParametersToMessageTemplate()
        {
            NotNullValidator validator = new NotNullValidator();
            validator.MessageTemplate = "{0}|{1}|{2}";
            validator.Tag = "tag";
            object target = null;
            string key = "key";

            ValidationResults validationResults = new ValidationResults();
            validator.DoValidate(target, null, key, validationResults);

            Assert.IsFalse(validationResults.IsValid);
            ValidationResult validationResult = ValidationTestHelper.GetResultsList(validationResults)[0];
            Match match = TemplateStringTester.Match(validator.MessageTemplate, validationResult.Message);
            Assert.IsTrue(match.Success);
            Assert.IsTrue(match.Groups["param0"].Success);
            Assert.AreEqual("", match.Groups["param0"].Value);
            Assert.IsTrue(match.Groups["param1"].Success);
            Assert.AreEqual(key, match.Groups["param1"].Value);
            Assert.IsTrue(match.Groups["param2"].Success);
            Assert.AreEqual(validator.Tag, match.Groups["param2"].Value);
        }

        public void SuppliesAppropriateParametersToDefaultMessage()
        {
            NotNullValidator validator = new NotNullValidator();
            validator.Tag = "tag";
            object target = null;
            string key = "key";

            ValidationResults validationResults = new ValidationResults();
            validator.DoValidate(target, null, key, validationResults);

            Assert.IsFalse(validationResults.IsValid);
            ValidationResult validationResult = ValidationTestHelper.GetResultsList(validationResults)[0];
            Match match = TemplateStringTester.Match(validator.MessageTemplate, validationResult.Message);
            Assert.IsTrue(match.Success);
            Assert.IsFalse(match.Groups["param0"].Success);
            Assert.IsFalse(match.Groups["param1"].Success);
            Assert.IsFalse(match.Groups["param2"].Success);
        }

        public void SuppliesAppropriateParametersToDefaultNegatedMessage()
        {
            NotNullValidator validator = new NotNullValidator(true);
            validator.Tag = "tag";
            object target = "not null";
            string key = "key";

            ValidationResults validationResults = new ValidationResults();
            validator.DoValidate(target, null, key, validationResults);

            Assert.IsFalse(validationResults.IsValid);
            ValidationResult validationResult = ValidationTestHelper.GetResultsList(validationResults)[0];
            Match match = TemplateStringTester.Match(validator.MessageTemplate, validationResult.Message);
            Assert.IsTrue(match.Success);
            Assert.IsFalse(match.Groups["param0"].Success);
            Assert.IsFalse(match.Groups["param1"].Success);
            Assert.IsFalse(match.Groups["param2"].Success);
        }
    }
}