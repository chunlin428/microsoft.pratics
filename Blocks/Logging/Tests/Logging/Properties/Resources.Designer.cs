﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Logging.Tests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create type &apos;{0}&apos;..
        /// </summary>
        internal static string ActivatorCacheCannotCreateType {
            get {
                return ResourceManager.GetString("ActivatorCacheCannotCreateType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application.
        /// </summary>
        internal static string ApplicationLogName {
            get {
                return ResourceManager.GetString("ApplicationLogName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The category &apos;{0}&apos; in the message is not found in configuration. The default category &apos;{1}&apos; is used instead to process the message..
        /// </summary>
        internal static string CategoryNotFound {
            get {
                return ResourceManager.GetString("CategoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ActivityId.
        /// </summary>
        internal static string ComPlusInfo_ActivityId {
            get {
                return ResourceManager.GetString("ComPlusInfo_ActivityId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ApplicationId.
        /// </summary>
        internal static string ComPlusInfo_ApplicationId {
            get {
                return ResourceManager.GetString("ComPlusInfo_ApplicationId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DirectCallerAccountName.
        /// </summary>
        internal static string ComPlusInfo_DirectCallerAccountName {
            get {
                return ResourceManager.GetString("ComPlusInfo_DirectCallerAccountName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OriginalCallerAccountName.
        /// </summary>
        internal static string ComPlusInfo_OriginalCallerAccountName {
            get {
                return ResourceManager.GetString("ComPlusInfo_OriginalCallerAccountName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TransactionID.
        /// </summary>
        internal static string ComPlusInfo_TransactionID {
            get {
                return ResourceManager.GetString("ComPlusInfo_TransactionID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 	at .
        /// </summary>
        internal static string DebugInfo_SchemaHelperAtString {
            get {
                return ResourceManager.GetString("DebugInfo_SchemaHelperAtString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 	in {0}: line {1}.
        /// </summary>
        internal static string DebugInfo_SchemaHelperLine {
            get {
                return ResourceManager.GetString("DebugInfo_SchemaHelperLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;UnknownType&gt;.
        /// </summary>
        internal static string DebugInfo_SchemaHelperUnknownType {
            get {
                return ResourceManager.GetString("DebugInfo_SchemaHelperUnknownType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StackTrace.
        /// </summary>
        internal static string DebugInfo_StackTrace {
            get {
                return ResourceManager.GetString("DebugInfo_StackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to process stack trace..
        /// </summary>
        internal static string DebugInfo_StackTraceException {
            get {
                return ResourceManager.GetString("DebugInfo_StackTraceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insufficient privilege to generate stack trace..
        /// </summary>
        internal static string DebugInfo_StackTraceSecurityException {
            get {
                return ResourceManager.GetString("DebugInfo_StackTraceSecurityException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to log message to the default log destination..
        /// </summary>
        internal static string DefaultLogDestinationFailed {
            get {
                return ResourceManager.GetString("DefaultLogDestinationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while the Distributor was processing the message.  Please check your configuration files for errors or typos.  Verify that your sinks are reachable (queues exist, permissions are set, database exists, etc...).
        /// </summary>
        internal static string DefaultLogDestinationMessage {
            get {
                return ResourceManager.GetString("DefaultLogDestinationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Backup Sink.
        /// </summary>
        internal static string DefaultLogDestinationSinkName {
            get {
                return ResourceManager.GetString("DefaultLogDestinationSinkName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp: {timestamp}{newline}Message: {message}{newline}Category: {category}{newline}Priority: {priority}{newline}EventId: {eventid}{newline}Severity: {severity}{newline}Title:{title}{newline}Machine: {machine}{newline}App Domain: {appDomain}{newline}ProcessId: {processId}{newline}Process Name: {processName}{newline}Thread Name: {threadName}{newline}Win32 ThreadId:{win32ThreadId}{newline}Extended Properties: {dictionary({key} - {value}{newline})}.
        /// </summary>
        internal static string DefaultTextFormat {
            get {
                return ResourceManager.GetString("DefaultTextFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message: 
        ///.
        /// </summary>
        internal static string DistEventLoggerMessagePrefix {
            get {
                return ResourceManager.GetString("DistEventLoggerMessagePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Summary for.
        /// </summary>
        internal static string DistEventLoggerSummary {
            get {
                return ResourceManager.GetString("DistEventLoggerSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Distribution Strategies.
        /// </summary>
        internal static string DistributionStrategyFactoryName {
            get {
                return ResourceManager.GetString("DistributionStrategyFactoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Distributor Service.
        /// </summary>
        internal static string DistributorEventLoggerDefaultApplicationName {
            get {
                return ResourceManager.GetString("DistributorEventLoggerDefaultApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-Mail Sink is missing one of these keys in the Distributor&apos;s XML file: ToAddress, FromAddress, and/or SmtpServer..
        /// </summary>
        internal static string EmailSinkMissingParameters {
            get {
                return ResourceManager.GetString("EmailSinkMissingParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied to the event log &apos;{0}&apos;..
        /// </summary>
        internal static string EventLogAccessDenied {
            get {
                return ResourceManager.GetString("EventLogAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event Log Sink is missing the key -EventSourceName- in the Distributor&apos;s configuration file..
        /// </summary>
        internal static string EventLogSinkMissingEventSource {
            get {
                return ResourceManager.GetString("EventLogSinkMissingEventSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default category &apos;{0}&apos; is not defined in Logging Distributor configuration..
        /// </summary>
        internal static string ExceptionCannotLoadDefaultCategory {
            get {
                return ResourceManager.GetString("ExceptionCannotLoadDefaultCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default formatter &apos;{0}&apos; is not defined in Logging Distributor configuration..
        /// </summary>
        internal static string ExceptionCannotLoadDefaultFormatter {
            get {
                return ResourceManager.GetString("ExceptionCannotLoadDefaultFormatter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name for the CategoryFilterData can not be null..
        /// </summary>
        internal static string ExceptionCategoryFilterDataName {
            get {
                return ResourceManager.GetString("ExceptionCategoryFilterDataName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The category &apos;{0}&apos; is not defined in the Logging Distributor configuration..
        /// </summary>
        internal static string ExceptionCategoryNotDefined {
            get {
                return ResourceManager.GetString("ExceptionCategoryNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sink for the DestinationData can not be null..
        /// </summary>
        internal static string ExceptionDestinationDataName {
            get {
                return ResourceManager.GetString("ExceptionDestinationDataName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value {0} is not defined for {1}. .
        /// </summary>
        internal static string ExceptionEnumNotDefined {
            get {
                return ResourceManager.GetString("ExceptionEnumNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log writer failed to acquire lock while updating configuration..
        /// </summary>
        internal static string ExceptionFailedToAcquireLockToUpdate {
            get {
                return ResourceManager.GetString("ExceptionFailedToAcquireLockToUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log writer failed to acquire lock while writing log entry..
        /// </summary>
        internal static string ExceptionFailedToAcquireLockToWriteLog {
            get {
                return ResourceManager.GetString("ExceptionFailedToAcquireLockToWriteLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The formatter &apos;{0}&apos; is not defined in the Logging Distributor configuration..
        /// </summary>
        internal static string ExceptionFormatterNotDefined {
            get {
                return ResourceManager.GetString("ExceptionFormatterNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSMQ Sink is missing this key in the Distributor&apos;s configuration file: QueuePath.
        /// </summary>
        internal static string ExceptionMsmqSinkMissingConfiguration {
            get {
                return ResourceManager.GetString("ExceptionMsmqSinkMissingConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSMQ Strategy is missing this key in the Distributor&apos;s configuration file: QueuePath.
        /// </summary>
        internal static string ExceptionMsmqStrategyMissingConfiguration {
            get {
                return ResourceManager.GetString("ExceptionMsmqStrategyMissingConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested distribution strategy &apos;{0}&apos; is not defined in the current configuration..
        /// </summary>
        internal static string ExceptionNoDistributionStragegy {
            get {
                return ResourceManager.GetString("ExceptionNoDistributionStragegy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested log sink &apos;{0}&apos; is not defined in the current configuration..
        /// </summary>
        internal static string ExceptionNoSinkDefined {
            get {
                return ResourceManager.GetString("ExceptionNoSinkDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Distributor Settings does not have any log sinks defined in configuration..
        /// </summary>
        internal static string ExceptionNoSinksDefined {
            get {
                return ResourceManager.GetString("ExceptionNoSinksDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Logging Settings does not have any distribution strategies defined in configuration..
        /// </summary>
        internal static string ExceptionNoStrategiesDefined {
            get {
                return ResourceManager.GetString("ExceptionNoStrategiesDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value provided is not defined for Severity.
        /// </summary>
        internal static string ExceptionSeverityNotDefined {
            get {
                return ResourceManager.GetString("ExceptionSeverityNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read system property. Error message: {0}.
        /// </summary>
        internal static string ExtendedPropertyError {
            get {
                return ResourceManager.GetString("ExtendedPropertyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flat File Sink is missing one of these keys in the Distributor&apos;s configuration file: FilePath and/or FileName.
        /// </summary>
        internal static string FileSinkMissingConfiguration {
            get {
                return ResourceManager.GetString("FileSinkMissingConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluation of filter &apos;{0}&apos; failed and the filter will be ignored. See summary information below for more information. Should this problem persist, stop the service and check the configuration file(s) for possible error(s) in the configuration of the categories and sinks..
        /// </summary>
        internal static string FilterEvaluationFailed {
            get {
                return ResourceManager.GetString("FilterEvaluationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log Formatter Factory.
        /// </summary>
        internal static string FormatterFactoryName {
            get {
                return ResourceManager.GetString("FormatterFactoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Logging Service.
        /// </summary>
        internal static string InstrumentationCounterCategory {
            get {
                return ResourceManager.GetString("InstrumentationCounterCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Logging Service application performance counters..
        /// </summary>
        internal static string InstrumentationCounterCategoryHelp {
            get {
                return ResourceManager.GetString("InstrumentationCounterCategoryHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Logging Service.
        /// </summary>
        internal static string InstrumentationEventSource {
            get {
                return ResourceManager.GetString("InstrumentationEventSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read intrinsic property.  Error message: {0}.
        /// </summary>
        internal static string IntrinsicPropertyError {
            get {
                return ResourceManager.GetString("IntrinsicPropertyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error logging with &apos;{0}&apos; sink from configuration. The default log sink will be used instead to process the message..
        /// </summary>
        internal static string InvalidSink {
            get {
                return ResourceManager.GetString("InvalidSink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Message: 
        ///{0}.
        /// </summary>
        internal static string InvalidSinkMessage {
            get {
                return ResourceManager.GetString("InvalidSinkMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AuthenticationType.
        /// </summary>
        internal static string ManagedSecurity_AuthenticationType {
            get {
                return ResourceManager.GetString("ManagedSecurity_AuthenticationType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IdentityName.
        /// </summary>
        internal static string ManagedSecurity_IdentityName {
            get {
                return ResourceManager.GetString("ManagedSecurity_IdentityName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IsAuthenticated.
        /// </summary>
        internal static string ManagedSecurity_IsAuthenticated {
            get {
                return ResourceManager.GetString("ManagedSecurity_IsAuthenticated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no explicit mapping for the categories &apos;{0}&apos;..
        /// </summary>
        internal static string MissingCategories {
            get {
                return ResourceManager.GetString("MissingCategories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default formatter is missing from the configuration file.  The entry will be written using a TextFormatter and an embedded template..
        /// </summary>
        internal static string MissingDefaultFormatter {
            get {
                return ResourceManager.GetString("MissingDefaultFormatter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Distributor: # of Logs to Default Sink/Sec.
        /// </summary>
        internal static string NumLogsDefaultSinkSec {
            get {
                return ResourceManager.GetString("NumLogsDefaultSinkSec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of logs per second distributed by the Log Distributor to the Default Log Sink (EventLog)..
        /// </summary>
        internal static string NumLogsDefaultSinkSecMsg {
            get {
                return ResourceManager.GetString("NumLogsDefaultSinkSecMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Distributor: # of Logs Distributed/Sec.
        /// </summary>
        internal static string NumLogsDistributedSec {
            get {
                return ResourceManager.GetString("NumLogsDistributedSec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of logs distributed per second by the Log Distributor..
        /// </summary>
        internal static string NumLogsDistributedSecMsg {
            get {
                return ResourceManager.GetString("NumLogsDistributedSecMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client: # of Logs Written/Sec.
        /// </summary>
        internal static string NumLogsWrittenSec {
            get {
                return ResourceManager.GetString("NumLogsWrittenSec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of logs per second written by client using the Enterprise Library Logging Block..
        /// </summary>
        internal static string NumLogsWrittenSecMsg {
            get {
                return ResourceManager.GetString("NumLogsWrittenSecMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing of the message failed. See summary information below for more information. Should this problem persist, stop the service and check the configuration file(s) for possible error(s) in the configuration of the categories and sinks..
        /// </summary>
        internal static string ProcessMessageFailed {
            get {
                return ResourceManager.GetString("ProcessMessageFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProcessQueueMessage - additional information.
        /// </summary>
        internal static string ProcessMessageFailed2 {
            get {
                return ResourceManager.GetString("ProcessMessageFailed2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Message: 
        ///{0}SinkFactoryName = Log Sink.
        /// </summary>
        internal static string ProcessMessageFailed3 {
            get {
                return ResourceManager.GetString("ProcessMessageFailed3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log Sink Factory.
        /// </summary>
        internal static string SinkFactoryName {
            get {
                return ResourceManager.GetString("SinkFactoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sink failed because: {0}..
        /// </summary>
        internal static string SinkFailure {
            get {
                return ResourceManager.GetString("SinkFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End Trace: Activity &apos;{0}&apos; in method &apos;{1}&apos; at {2} ticks (elapsed time: {3} seconds).
        /// </summary>
        internal static string Tracer_EndMessageFormat {
            get {
                return ResourceManager.GetString("Tracer_EndMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Trace: Activity &apos;{0}&apos; in method &apos;{1}&apos; at {2} ticks.
        /// </summary>
        internal static string Tracer_StartMessageFormat {
            get {
                return ResourceManager.GetString("Tracer_StartMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracing to LogSource &apos;{0}&apos; failed. Processing for other sources will continue. See summary information below for more information. Should this problem persist, stop the service and check the configuration file(s) for possible error(s) in the configuration of the categories and sinks..
        /// </summary>
        internal static string TraceSourceFailed {
            get {
                return ResourceManager.GetString("TraceSourceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error has occurred..
        /// </summary>
        internal static string UnknownError {
            get {
                return ResourceManager.GetString("UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CurrentUser.
        /// </summary>
        internal static string UnmanagedSecurity_CurrentUser {
            get {
                return ResourceManager.GetString("UnmanagedSecurity_CurrentUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProcessAccountName.
        /// </summary>
        internal static string UnmanagedSecurity_ProcessAccountName {
            get {
                return ResourceManager.GetString("UnmanagedSecurity_ProcessAccountName", resourceCulture);
            }
        }
    }
}
