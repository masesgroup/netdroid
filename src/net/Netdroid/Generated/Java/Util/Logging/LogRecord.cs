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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region LogRecord declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html"/>
    /// </summary>
    public partial class LogRecord : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.util.logging.LogRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LogRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LogRecord(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region LogRecord implementation
    public partial class LogRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#%3Cinit%3E(java.util.logging.Level,java.lang.String)"/>
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
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getThreadID()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetThreadID()
        {
            return IExecuteWithSignature<int>("getThreadID", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getParameters()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] GetParameters()
        {
            return IExecuteWithSignatureArray<object>("getParameters", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getLoggerName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLoggerName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLoggerName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getMessage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMessage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMessage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getResourceBundleName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetResourceBundleName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getResourceBundleName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getSourceClassName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSourceClassName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSourceClassName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getSourceMethodName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSourceMethodName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSourceMethodName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getThrown()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Throwable"/></returns>
        public Java.Lang.Throwable GetThrown()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getThrown", "()Ljava/lang/Throwable;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getInstant()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetInstant()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getInstant", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getLevel()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Level"/></returns>
        public Java.Util.Logging.Level GetLevel()
        {
            return IExecuteWithSignature<Java.Util.Logging.Level>("getLevel", "()Ljava/util/logging/Level;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setLongThreadID(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Logging.LogRecord"/></returns>
        public Java.Util.Logging.LogRecord SetLongThreadID(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Logging.LogRecord>("setLongThreadID", "(J)Ljava/util/logging/LogRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getResourceBundle()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public Java.Util.ResourceBundle GetResourceBundle()
        {
            return IExecuteWithSignature<Java.Util.ResourceBundle>("getResourceBundle", "()Ljava/util/ResourceBundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getLongThreadID()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLongThreadID()
        {
            return IExecuteWithSignature<long>("getLongThreadID", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMillis()
        {
            return IExecuteWithSignature<long>("getMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#getSequenceNumber()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSequenceNumber()
        {
            return IExecuteWithSignature<long>("getSequenceNumber", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setInstant(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        public void SetInstant(Java.Time.Instant arg0)
        {
            IExecuteWithSignature("setInstant", "(Ljava/time/Instant;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setLevel(java.util.logging.Level)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        public void SetLevel(Java.Util.Logging.Level arg0)
        {
            IExecuteWithSignature("setLevel", "(Ljava/util/logging/Level;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setLoggerName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetLoggerName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setLoggerName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setMessage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetMessage(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setMessage", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void SetMillis(long arg0)
        {
            IExecuteWithSignature("setMillis", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setParameters(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetParameters(object[] arg0)
        {
            IExecuteWithSignature("setParameters", "([Ljava/lang/Object;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setResourceBundle(java.util.ResourceBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.ResourceBundle"/></param>
        public void SetResourceBundle(Java.Util.ResourceBundle arg0)
        {
            IExecuteWithSignature("setResourceBundle", "(Ljava/util/ResourceBundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setResourceBundleName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetResourceBundleName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setResourceBundleName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setSequenceNumber(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetSequenceNumber(long arg0)
        {
            IExecuteWithSignature("setSequenceNumber", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setSourceClassName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSourceClassName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSourceClassName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setSourceMethodName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSourceMethodName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSourceMethodName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setThreadID(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetThreadID(int arg0)
        {
            IExecuteWithSignature("setThreadID", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogRecord.html#setThrown(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void SetThrown(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("setThrown", "(Ljava/lang/Throwable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}