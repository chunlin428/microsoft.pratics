//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Common.Tests.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Tests.TraceListeners.Configuration
{
    [TestClass]
    public class TextWriterTraceListenerConfigurationFixture
    {
        IBuilderContext context;
        ConfigurationReflectionCache reflectionCache;

        [TestInitialize]
        public void SetUp()
        {
            AppDomain.CurrentDomain.SetData("APPBASE", Environment.CurrentDirectory);
			context = new BuilderContext(new StrategyChain(), null, null, new PolicyList(), null, null);
            reflectionCache = new ConfigurationReflectionCache();
        }

        [TestMethod]
        public void CanCreateInstanceFromGivenName()
        {
            SystemDiagnosticsTraceListenerData listenerData
                = new SystemDiagnosticsTraceListenerData("listener", typeof(TextWriterTraceListener), "log.txt");
            listenerData.TraceOutputOptions = TraceOptions.Callstack;

            MockLogObjectsHelper helper = new MockLogObjectsHelper();
            helper.loggingSettings.TraceListeners.Add(listenerData);

            TraceListener listener = TraceListenerCustomFactory.Instance.Create(context, "listener", helper.configurationSource, reflectionCache);

            Assert.IsNotNull(listener);
            Assert.AreEqual(listener.GetType(), typeof(TextWriterTraceListener));
            Assert.AreEqual("listener", listener.Name);
            Assert.AreEqual(TraceOptions.Callstack, listener.TraceOutputOptions);
        }

        [TestMethod]
        public void CanCreateInstanceFromGivenConfiguration()
        {
            SystemDiagnosticsTraceListenerData listenerData
                = new SystemDiagnosticsTraceListenerData("listener", typeof(TextWriterTraceListener), "log.txt");
            listenerData.TraceOutputOptions = TraceOptions.Callstack;

            MockLogObjectsHelper helper = new MockLogObjectsHelper();

            TraceListener listener = TraceListenerCustomFactory.Instance.Create(context, listenerData, helper.configurationSource, reflectionCache);

            Assert.IsNotNull(listener);
            Assert.AreEqual(listener.GetType(), typeof(TextWriterTraceListener));
            Assert.AreEqual("listener", listener.Name);
            Assert.AreEqual(TraceOptions.Callstack, listener.TraceOutputOptions);
        }

        [TestMethod]
        public void CanCreateInstanceFromConfigurationFile()
        {
            SystemDiagnosticsTraceListenerData listenerData
                = new SystemDiagnosticsTraceListenerData("listener", typeof(TextWriterTraceListener), "log.txt");
            listenerData.TraceOutputOptions = TraceOptions.Callstack;

            LoggingSettings loggingSettings = new LoggingSettings();
            loggingSettings.TraceListeners.Add(listenerData);

            TraceListener listener
                = TraceListenerCustomFactory.Instance.Create(context, "listener", CommonUtil.SaveSectionsAndGetConfigurationSource(loggingSettings), reflectionCache);

            Assert.IsNotNull(listener);
            Assert.AreEqual(listener.GetType(), typeof(TextWriterTraceListener));
            Assert.AreEqual(TraceOptions.Callstack, listener.TraceOutputOptions);
        }
    }
}