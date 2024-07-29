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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region LogManager
    public partial class LogManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#LOGGING_MXBEAN_NAME"/>
        /// </summary>
        public static Java.Lang.String LOGGING_MXBEAN_NAME { get { if (!_LOGGING_MXBEAN_NAMEReady) { _LOGGING_MXBEAN_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOGGING_MXBEAN_NAME"); _LOGGING_MXBEAN_NAMEReady = true; } return _LOGGING_MXBEAN_NAMEContent; } }
        private static Java.Lang.String _LOGGING_MXBEAN_NAMEContent = default;
        private static bool _LOGGING_MXBEAN_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#getLogManager()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.LogManager"/></returns>
        public static Java.Util.Logging.LogManager GetLogManager()
        {
            return SExecuteWithSignature<Java.Util.Logging.LogManager>(LocalBridgeClazz, "getLogManager", "()Ljava/util/logging/LogManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#getLoggingMXBean()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.LoggingMXBean"/></returns>
        [global::System.Obsolete()]
        public static Java.Util.Logging.LoggingMXBean GetLoggingMXBean()
        {
            return SExecuteWithSignature<Java.Util.Logging.LoggingMXBean>(LocalBridgeClazz, "getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#addLogger(java.util.logging.Logger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Logger"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddLogger(Java.Util.Logging.Logger arg0)
        {
            return IExecuteWithSignature<bool>("addLogger", "(Ljava/util/logging/Logger;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#getLoggerNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Lang.String> GetLoggerNames()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("getLoggerNames", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#getLogger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public Java.Util.Logging.Logger GetLogger(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Logging.Logger>("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#addConfigurationListener(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Logging.LogManager"/></returns>
        public Java.Util.Logging.LogManager AddConfigurationListener(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Java.Util.Logging.LogManager>("addConfigurationListener", "(Ljava/lang/Runnable;)Ljava/util/logging/LogManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#checkAccess()"/>
        /// </summary>
        /// <exception cref="Java.Lang.SecurityException"/>
        [global::System.Obsolete()]
        public void CheckAccess()
        {
            IExecuteWithSignature("checkAccess", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#readConfiguration()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ReadConfiguration()
        {
            IExecuteWithSignature("readConfiguration", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#readConfiguration(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ReadConfiguration(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("readConfiguration", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#removeConfigurationListener(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void RemoveConfigurationListener(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("removeConfigurationListener", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#updateConfiguration(java.io.InputStream,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UpdateConfiguration(Java.Io.InputStream arg0, Java.Util.Function.Function<Java.Lang.String, Java.Util.Function.BiFunction<Java.Lang.String, Java.Lang.String, Java.Lang.String>> arg1)
        {
            IExecute("updateConfiguration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/LogManager.html#updateConfiguration(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UpdateConfiguration(Java.Util.Function.Function<Java.Lang.String, Java.Util.Function.BiFunction<Java.Lang.String, Java.Lang.String, Java.Lang.String>> arg0)
        {
            IExecuteWithSignature("updateConfiguration", "(Ljava/util/function/Function;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}