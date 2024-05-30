/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region LogRecord
    public partial class LogRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#%3Cinit%3E(java.util.logging.Level,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public LogRecord(Java.Util.Logging.Level arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getInstant()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setInstant(java.time.Instant)"/>
        /// </summary>
        public Java.Time.Instant Instant
        {
            get { return IExecuteWithSignature<Java.Time.Instant>("getInstant", "()Ljava/time/Instant;"); } set { IExecuteWithSignature("setInstant", "(Ljava/time/Instant;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getLevel()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setLevel(java.util.logging.Level)"/>
        /// </summary>
        public Java.Util.Logging.Level Level
        {
            get { return IExecuteWithSignature<Java.Util.Logging.Level>("getLevel", "()Ljava/util/logging/Level;"); } set { IExecuteWithSignature("setLevel", "(Ljava/util/logging/Level;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getLoggerName()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setLoggerName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String LoggerName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLoggerName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setLoggerName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getLongThreadID()"/> 
        /// </summary>
        public long LongThreadID
        {
            get { return IExecuteWithSignature<long>("getLongThreadID", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getMessage()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setMessage(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Message
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMessage", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setMessage", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getMillis()"/> 
        /// </summary>
        public long Millis
        {
            get { return IExecuteWithSignature<long>("getMillis", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getParameters()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setParameters(java.lang.Object[])"/>
        /// </summary>
        public object[] Parameters
        {
            get { return IExecuteWithSignatureArray<object>("getParameters", "()[Ljava/lang/Object;"); } set { IExecuteWithSignature("setParameters", "([Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getResourceBundle()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setResourceBundle(java.util.ResourceBundle)"/>
        /// </summary>
        public Java.Util.ResourceBundle ResourceBundle
        {
            get { return IExecuteWithSignature<Java.Util.ResourceBundle>("getResourceBundle", "()Ljava/util/ResourceBundle;"); } set { IExecuteWithSignature("setResourceBundle", "(Ljava/util/ResourceBundle;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getResourceBundleName()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setResourceBundleName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ResourceBundleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getResourceBundleName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setResourceBundleName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getSequenceNumber()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setSequenceNumber(long)"/>
        /// </summary>
        public long SequenceNumber
        {
            get { return IExecuteWithSignature<long>("getSequenceNumber", "()J"); } set { IExecuteWithSignature("setSequenceNumber", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getSourceClassName()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setSourceClassName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SourceClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSourceClassName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSourceClassName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getSourceMethodName()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setSourceMethodName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SourceMethodName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSourceMethodName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSourceMethodName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#getThrown()"/> <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setThrown(java.lang.Throwable)"/>
        /// </summary>
        public Java.Lang.Throwable Thrown
        {
            get { var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getThrown", "()Ljava/lang/Throwable;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); } set { IExecuteWithSignature("setThrown", "(Ljava/lang/Throwable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.logging/java/util/logging/LogRecord.html#setLongThreadID(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Logging.LogRecord"/></returns>
        public Java.Util.Logging.LogRecord SetLongThreadID(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Logging.LogRecord>("setLongThreadID", "(J)Ljava/util/logging/LogRecord;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}