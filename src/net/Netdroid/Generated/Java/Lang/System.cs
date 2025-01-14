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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region System declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/lang/System.html"/>
    /// </summary>
    public partial class System : MASES.JCOBridge.C2JBridge.JVMBridgeBase<System>
    {
        const string _bridgeClassName = "java.lang.System";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public System() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public System(params object[] args) : base(args) { }
    
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

    #region System implementation
    public partial class System
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#in"/>
        /// </summary>
        public static Java.Io.InputStream inField { get { if (!_inFieldReady) { _inFieldContent = SGetField<Java.Io.InputStream>(LocalBridgeClazz, "in"); _inFieldReady = true; } return _inFieldContent; } }
        private static Java.Io.InputStream _inFieldContent = default;
        private static bool _inFieldReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#err"/>
        /// </summary>
        public static Java.Io.PrintStream err { get { if (!_errReady) { _errContent = SGetField<Java.Io.PrintStream>(LocalBridgeClazz, "err"); _errReady = true; } return _errContent; } }
        private static Java.Io.PrintStream _errContent = default;
        private static bool _errReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#out"/>
        /// </summary>
        public static Java.Io.PrintStream outField { get { if (!_outFieldReady) { _outFieldContent = SGetField<Java.Io.PrintStream>(LocalBridgeClazz, "out"); _outFieldReady = true; } return _outFieldContent; } }
        private static Java.Io.PrintStream _outFieldContent = default;
        private static bool _outFieldReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#console()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Console"/></returns>
        public static Java.Io.Console Console()
        {
            return SExecuteWithSignature<Java.Io.Console>(LocalBridgeClazz, "console", "()Ljava/io/Console;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#getSecurityManager()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.SecurityManager"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.SecurityManager GetSecurityManager()
        {
            return SExecuteWithSignature<Java.Lang.SecurityManager>(LocalBridgeClazz, "getSecurityManager", "()Ljava/lang/SecurityManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#clearProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ClearProperty(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "clearProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#getenv(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Getenv(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getenv", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#getProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetProperty(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#lineSeparator()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String LineSeparator()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "lineSeparator", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#setProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String SetProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#inheritedChannel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.Channel InheritedChannel()
        {
            return SExecuteWithSignature<Java.Nio.Channels.Channel>(LocalBridgeClazz, "inheritedChannel", "()Ljava/nio/channels/Channel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#getenv()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, Java.Lang.String> Getenv()
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>(LocalBridgeClazz, "getenv", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Properties"/></returns>
        public static Java.Util.Properties GetProperties()
        {
            return SExecuteWithSignature<Java.Util.Properties>(LocalBridgeClazz, "getProperties", "()Ljava/util/Properties;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#identityHashCode(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public static int IdentityHashCode(object arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "identityHashCode", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#mapLibraryName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String MapLibraryName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#currentTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long CurrentTimeMillis()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "currentTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#nanoTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long NanoTime()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "nanoTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#arraycopy(java.lang.Object,int,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void Arraycopy(object arg0, int arg1, object arg2, int arg3, int arg4)
        {
            SExecuteWithSignature(LocalBridgeClazz, "arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#exit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void Exit(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "exit", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#gc()"/>
        /// </summary>
        public static void Gc()
        {
            SExecuteWithSignature(LocalBridgeClazz, "gc", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#load(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Load(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "load", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#loadLibrary(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void LoadLibrary(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "loadLibrary", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#runFinalization()"/>
        /// </summary>
        public static void RunFinalization()
        {
            SExecuteWithSignature(LocalBridgeClazz, "runFinalization", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#setErr(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public static void SetErr(Java.Io.PrintStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setErr", "(Ljava/io/PrintStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#setIn(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public static void SetIn(Java.Io.InputStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setIn", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#setOut(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public static void SetOut(Java.Io.PrintStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setOut", "(Ljava/io/PrintStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#setProperties(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public static void SetProperties(Java.Util.Properties arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setProperties", "(Ljava/util/Properties;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/System.html#setSecurityManager(java.lang.SecurityManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.SecurityManager"/></param>
        [global::System.Obsolete()]
        public static void SetSecurityManager(Java.Lang.SecurityManager arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setSecurityManager", "(Ljava/lang/SecurityManager;)V", arg0);
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