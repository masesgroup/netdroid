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

namespace Android.Util
{
    #region Log declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/Log.html"/>
    /// </summary>
    public partial class Log : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Log>
    {
        const string _bridgeClassName = "android.util.Log";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Log() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Log(params object[] args) : base(args) { }
    
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

    #region Log implementation
    public partial class Log
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#ASSERT"/>
        /// </summary>
        public static int ASSERT { get { if (!_ASSERTReady) { _ASSERTContent = SGetField<int>(LocalBridgeClazz, "ASSERT"); _ASSERTReady = true; } return _ASSERTContent; } }
        private static int _ASSERTContent = default;
        private static bool _ASSERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#DEBUG"/>
        /// </summary>
        public static int DEBUG { get { if (!_DEBUGReady) { _DEBUGContent = SGetField<int>(LocalBridgeClazz, "DEBUG"); _DEBUGReady = true; } return _DEBUGContent; } }
        private static int _DEBUGContent = default;
        private static bool _DEBUGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static int _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#INFO"/>
        /// </summary>
        public static int INFO { get { if (!_INFOReady) { _INFOContent = SGetField<int>(LocalBridgeClazz, "INFO"); _INFOReady = true; } return _INFOContent; } }
        private static int _INFOContent = default;
        private static bool _INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#VERBOSE"/>
        /// </summary>
        public static int VERBOSE { get { if (!_VERBOSEReady) { _VERBOSEContent = SGetField<int>(LocalBridgeClazz, "VERBOSE"); _VERBOSEReady = true; } return _VERBOSEContent; } }
        private static int _VERBOSEContent = default;
        private static bool _VERBOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#WARN"/>
        /// </summary>
        public static int WARN { get { if (!_WARNReady) { _WARNContent = SGetField<int>(LocalBridgeClazz, "WARN"); _WARNReady = true; } return _WARNContent; } }
        private static int _WARNContent = default;
        private static bool _WARNReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#d(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int d(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "d", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#d(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int d(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "d", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#e(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int e(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "e", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#e(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int e(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "e", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#i(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int i(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "i", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#i(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int i(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "i", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#println(int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Println(int arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "println", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#v(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int v(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "v", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#v(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int v(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "v", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#w(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int w(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "w", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#w(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int w(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "w", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#w(java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int w(Java.Lang.String arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "w", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#wtf(java.lang.String,java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Wtf(Java.Lang.String arg0, Java.Lang.String arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "wtf", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#wtf(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Wtf(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "wtf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#wtf(java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Wtf(Java.Lang.String arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "wtf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#getStackTraceString(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetStackTraceString(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Log.html#isLoggable(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLoggable(Java.Lang.String arg0, int arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isLoggable", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}