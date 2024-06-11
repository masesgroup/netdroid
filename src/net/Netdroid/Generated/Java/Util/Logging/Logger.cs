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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region Logger
    public partial class Logger
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#GLOBAL_LOGGER_NAME"/>
        /// </summary>
        public static Java.Lang.String GLOBAL_LOGGER_NAME { get { if (!_GLOBAL_LOGGER_NAMEReady) { _GLOBAL_LOGGER_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GLOBAL_LOGGER_NAME"); _GLOBAL_LOGGER_NAMEReady = true; } return _GLOBAL_LOGGER_NAMEContent; } }
        private static Java.Lang.String _GLOBAL_LOGGER_NAMEContent = default;
        private static bool _GLOBAL_LOGGER_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#global"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Util.Logging.Logger global { get { if (!_globalReady) { _globalContent = SGetField<Java.Util.Logging.Logger>(LocalBridgeClazz, "global"); _globalReady = true; } return _globalContent; } }
        private static Java.Util.Logging.Logger _globalContent = default;
        private static bool _globalReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getGlobal()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public static Java.Util.Logging.Logger GetGlobal()
        {
            return SExecuteWithSignature<Java.Util.Logging.Logger>(LocalBridgeClazz, "getGlobal", "()Ljava/util/logging/Logger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getAnonymousLogger()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public static Java.Util.Logging.Logger GetAnonymousLogger()
        {
            return SExecuteWithSignature<Java.Util.Logging.Logger>(LocalBridgeClazz, "getAnonymousLogger", "()Ljava/util/logging/Logger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getAnonymousLogger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public static Java.Util.Logging.Logger GetAnonymousLogger(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Logging.Logger>(LocalBridgeClazz, "getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getLogger(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public static Java.Util.Logging.Logger GetLogger(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Util.Logging.Logger>(LocalBridgeClazz, "getLogger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getLogger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public static Java.Util.Logging.Logger GetLogger(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Logging.Logger>(LocalBridgeClazz, "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getUseParentHandlers()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseParentHandlers()
        {
            return IExecuteWithSignature<bool>("getUseParentHandlers", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#isLoggable(java.util.logging.Level)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLoggable(Java.Util.Logging.Level arg0)
        {
            return IExecuteWithSignature<bool>("isLoggable", "(Ljava/util/logging/Level;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getResourceBundleName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetResourceBundleName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getResourceBundleName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Filter"/></returns>
        public Java.Util.Logging.Filter GetFilter()
        {
            return IExecuteWithSignature<Java.Util.Logging.Filter>("getFilter", "()Ljava/util/logging/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getHandlers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Handler"/></returns>
        public Java.Util.Logging.Handler[] GetHandlers()
        {
            return IExecuteWithSignatureArray<Java.Util.Logging.Handler>("getHandlers", "()[Ljava/util/logging/Handler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getLevel()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Level"/></returns>
        public Java.Util.Logging.Level GetLevel()
        {
            return IExecuteWithSignature<Java.Util.Logging.Level>("getLevel", "()Ljava/util/logging/Level;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getParent()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public Java.Util.Logging.Logger GetParent()
        {
            return IExecuteWithSignature<Java.Util.Logging.Logger>("getParent", "()Ljava/util/logging/Logger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#getResourceBundle()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public Java.Util.ResourceBundle GetResourceBundle()
        {
            return IExecuteWithSignature<Java.Util.ResourceBundle>("getResourceBundle", "()Ljava/util/ResourceBundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#addHandler(java.util.logging.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Handler"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void AddHandler(Java.Util.Logging.Handler arg0)
        {
            IExecuteWithSignature("addHandler", "(Ljava/util/logging/Handler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#config(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Config(Java.Lang.String arg0)
        {
            IExecuteWithSignature("config", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#config(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Config(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("config", "(Ljava/util/function/Supplier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#entering(java.lang.String,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void Entering(Java.Lang.String arg0, Java.Lang.String arg1, object arg2)
        {
            IExecute("entering", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#entering(java.lang.String,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void Entering(Java.Lang.String arg0, Java.Lang.String arg1, object[] arg2)
        {
            IExecute("entering", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#entering(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Entering(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("entering", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#exiting(java.lang.String,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void Exiting(Java.Lang.String arg0, Java.Lang.String arg1, object arg2)
        {
            IExecute("exiting", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#exiting(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Exiting(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("exiting", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#fine(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Fine(Java.Lang.String arg0)
        {
            IExecuteWithSignature("fine", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#fine(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Fine(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("fine", "(Ljava/util/function/Supplier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#finer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Finer(Java.Lang.String arg0)
        {
            IExecuteWithSignature("finer", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#finer(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Finer(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("finer", "(Ljava/util/function/Supplier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#finest(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Finest(Java.Lang.String arg0)
        {
            IExecuteWithSignature("finest", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#finest(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Finest(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("finest", "(Ljava/util/function/Supplier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#info(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Info(Java.Lang.String arg0)
        {
            IExecuteWithSignature("info", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#info(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Info(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("info", "(Ljava/util/function/Supplier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.Level,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void Log(Java.Util.Logging.Level arg0, Java.Lang.String arg1, object arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.Level,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void Log(Java.Util.Logging.Level arg0, Java.Lang.String arg1, object[] arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.Level,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        public void Log(Java.Util.Logging.Level arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.Level,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Log(Java.Util.Logging.Level arg0, Java.Lang.String arg1)
        {
            IExecute("log", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.Level,java.lang.Throwable,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Supplier"/></param>
        public void Log(Java.Util.Logging.Level arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1, Java.Util.Function.Supplier<Java.Lang.String> arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.Level,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        public void Log(Java.Util.Logging.Level arg0, Java.Util.Function.Supplier<Java.Lang.String> arg1)
        {
            IExecute("log", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#log(java.util.logging.LogRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.LogRecord"/></param>
        public void Log(Java.Util.Logging.LogRecord arg0)
        {
            IExecuteWithSignature("log", "(Ljava/util/logging/LogRecord;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public void Logp(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, object arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public void Logp(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, object[] arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Throwable"/></param>
        public void Logp(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, MASES.JCOBridge.C2JBridge.JVMBridgeException arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public void Logp(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecute("logp", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.Throwable,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg4"><see cref="Java.Util.Function.Supplier"/></param>
        public void Logp(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, MASES.JCOBridge.C2JBridge.JVMBridgeException arg3, Java.Util.Function.Supplier<Java.Lang.String> arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Supplier"/></param>
        public void Logp(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Function.Supplier<Java.Lang.String> arg3)
        {
            IExecute("logp", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        [global::System.Obsolete()]
        public void Logrb(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, object arg5)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        [global::System.Obsolete()]
        public void Logrb(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, object[] arg5)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Throwable"/></param>
        [global::System.Obsolete()]
        public void Logrb(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, MASES.JCOBridge.C2JBridge.JVMBridgeException arg5)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Logrb(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.util.ResourceBundle,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.ResourceBundle"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        public void Logrb(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.ResourceBundle arg3, Java.Lang.String arg4, params object[] arg5)
        {
            if (arg5.Length == 0) IExecute("logrb", arg0, arg1, arg2, arg3, arg4); else IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.util.ResourceBundle,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.ResourceBundle"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Throwable"/></param>
        public void Logrb(Java.Util.Logging.Level arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.ResourceBundle arg3, Java.Lang.String arg4, MASES.JCOBridge.C2JBridge.JVMBridgeException arg5)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.util.ResourceBundle,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Util.ResourceBundle"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        public void Logrb(Java.Util.Logging.Level arg0, Java.Util.ResourceBundle arg1, Java.Lang.String arg2, params object[] arg3)
        {
            if (arg3.Length == 0) IExecute("logrb", arg0, arg1, arg2); else IExecute("logrb", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.util.ResourceBundle,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <param name="arg1"><see cref="Java.Util.ResourceBundle"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Throwable"/></param>
        public void Logrb(Java.Util.Logging.Level arg0, Java.Util.ResourceBundle arg1, Java.Lang.String arg2, MASES.JCOBridge.C2JBridge.JVMBridgeException arg3)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#removeHandler(java.util.logging.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Handler"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void RemoveHandler(Java.Util.Logging.Handler arg0)
        {
            IExecuteWithSignature("removeHandler", "(Ljava/util/logging/Handler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#setFilter(java.util.logging.Filter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Filter"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void SetFilter(Java.Util.Logging.Filter arg0)
        {
            IExecuteWithSignature("setFilter", "(Ljava/util/logging/Filter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#setLevel(java.util.logging.Level)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Level"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void SetLevel(Java.Util.Logging.Level arg0)
        {
            IExecuteWithSignature("setLevel", "(Ljava/util/logging/Level;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#setParent(java.util.logging.Logger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Logger"/></param>
        public void SetParent(Java.Util.Logging.Logger arg0)
        {
            IExecuteWithSignature("setParent", "(Ljava/util/logging/Logger;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#setResourceBundle(java.util.ResourceBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.ResourceBundle"/></param>
        public void SetResourceBundle(Java.Util.ResourceBundle arg0)
        {
            IExecuteWithSignature("setResourceBundle", "(Ljava/util/ResourceBundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#setUseParentHandlers(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseParentHandlers(bool arg0)
        {
            IExecuteWithSignature("setUseParentHandlers", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#severe(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Severe(Java.Lang.String arg0)
        {
            IExecuteWithSignature("severe", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#severe(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Severe(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("severe", "(Ljava/util/function/Supplier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#throwing(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        public void Throwing(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            IExecute("throwing", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#warning(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Warning(Java.Lang.String arg0)
        {
            IExecuteWithSignature("warning", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/logging/Logger.html#warning(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        public void Warning(Java.Util.Function.Supplier<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("warning", "(Ljava/util/function/Supplier;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}