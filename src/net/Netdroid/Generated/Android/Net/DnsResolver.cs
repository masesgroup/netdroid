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

namespace Android.Net
{
    #region DnsResolver declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html"/>
    /// </summary>
    public partial class DnsResolver : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DnsResolver>
    {
        const string _bridgeClassName = "android.net.DnsResolver";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DnsResolver() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DnsResolver(params object[] args) : base(args) { }
    
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
        #region Callback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.Callback.html"/>
        /// </summary>
        public partial class Callback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback>
        {
            const string _bridgeClassName = "android.net.DnsResolver$Callback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region Callback<T> declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.Callback.html"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public partial class Callback<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback<T>>
        {
            const string _bridgeClassName = "android.net.DnsResolver$Callback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region DnsException declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.DnsException.html"/>
        /// </summary>
        public partial class DnsException : Java.Lang.Exception
        {
            const string _bridgeClassName = "android.net.DnsResolver$DnsException";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region DnsResolver implementation
    public partial class DnsResolver
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#CLASS_IN"/>
        /// </summary>
        public static int CLASS_IN { get { if (!_CLASS_INReady) { _CLASS_INContent = SGetField<int>(LocalBridgeClazz, "CLASS_IN"); _CLASS_INReady = true; } return _CLASS_INContent; } }
        private static int _CLASS_INContent = default;
        private static bool _CLASS_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#ERROR_PARSE"/>
        /// </summary>
        public static int ERROR_PARSE { get { if (!_ERROR_PARSEReady) { _ERROR_PARSEContent = SGetField<int>(LocalBridgeClazz, "ERROR_PARSE"); _ERROR_PARSEReady = true; } return _ERROR_PARSEContent; } }
        private static int _ERROR_PARSEContent = default;
        private static bool _ERROR_PARSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#ERROR_SYSTEM"/>
        /// </summary>
        public static int ERROR_SYSTEM { get { if (!_ERROR_SYSTEMReady) { _ERROR_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "ERROR_SYSTEM"); _ERROR_SYSTEMReady = true; } return _ERROR_SYSTEMContent; } }
        private static int _ERROR_SYSTEMContent = default;
        private static bool _ERROR_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#FLAG_EMPTY"/>
        /// </summary>
        public static int FLAG_EMPTY { get { if (!_FLAG_EMPTYReady) { _FLAG_EMPTYContent = SGetField<int>(LocalBridgeClazz, "FLAG_EMPTY"); _FLAG_EMPTYReady = true; } return _FLAG_EMPTYContent; } }
        private static int _FLAG_EMPTYContent = default;
        private static bool _FLAG_EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#FLAG_NO_CACHE_LOOKUP"/>
        /// </summary>
        public static int FLAG_NO_CACHE_LOOKUP { get { if (!_FLAG_NO_CACHE_LOOKUPReady) { _FLAG_NO_CACHE_LOOKUPContent = SGetField<int>(LocalBridgeClazz, "FLAG_NO_CACHE_LOOKUP"); _FLAG_NO_CACHE_LOOKUPReady = true; } return _FLAG_NO_CACHE_LOOKUPContent; } }
        private static int _FLAG_NO_CACHE_LOOKUPContent = default;
        private static bool _FLAG_NO_CACHE_LOOKUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#FLAG_NO_CACHE_STORE"/>
        /// </summary>
        public static int FLAG_NO_CACHE_STORE { get { if (!_FLAG_NO_CACHE_STOREReady) { _FLAG_NO_CACHE_STOREContent = SGetField<int>(LocalBridgeClazz, "FLAG_NO_CACHE_STORE"); _FLAG_NO_CACHE_STOREReady = true; } return _FLAG_NO_CACHE_STOREContent; } }
        private static int _FLAG_NO_CACHE_STOREContent = default;
        private static bool _FLAG_NO_CACHE_STOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#FLAG_NO_RETRY"/>
        /// </summary>
        public static int FLAG_NO_RETRY { get { if (!_FLAG_NO_RETRYReady) { _FLAG_NO_RETRYContent = SGetField<int>(LocalBridgeClazz, "FLAG_NO_RETRY"); _FLAG_NO_RETRYReady = true; } return _FLAG_NO_RETRYContent; } }
        private static int _FLAG_NO_RETRYContent = default;
        private static bool _FLAG_NO_RETRYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#TYPE_A"/>
        /// </summary>
        public static int TYPE_A { get { if (!_TYPE_AReady) { _TYPE_AContent = SGetField<int>(LocalBridgeClazz, "TYPE_A"); _TYPE_AReady = true; } return _TYPE_AContent; } }
        private static int _TYPE_AContent = default;
        private static bool _TYPE_AReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#TYPE_AAAA"/>
        /// </summary>
        public static int TYPE_AAAA { get { if (!_TYPE_AAAAReady) { _TYPE_AAAAContent = SGetField<int>(LocalBridgeClazz, "TYPE_AAAA"); _TYPE_AAAAReady = true; } return _TYPE_AAAAContent; } }
        private static int _TYPE_AAAAContent = default;
        private static bool _TYPE_AAAAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.DnsResolver"/></returns>
        public static Android.Net.DnsResolver GetInstance()
        {
            return SExecuteWithSignature<Android.Net.DnsResolver>(LocalBridgeClazz, "getInstance", "()Landroid/net/DnsResolver;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#query(android.net.Network,java.lang.String,int,int,java.util.concurrent.Executor,android.os.CancellationSignal,android.net.DnsResolver.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Network"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg5"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg6"><see cref="Android.Net.DnsResolver.Callback"/></param>
        /// <typeparam name="Arg6objectSuperJava_Util_List_Java_Net_InetAddress_"><see cref="Java.Util.List{Java.Net.InetAddress}"/></typeparam>
        public void Query<Arg6objectSuperJava_Util_List_Java_Net_InetAddress_>(Android.Net.Network arg0, Java.Lang.String arg1, int arg2, int arg3, Java.Util.Concurrent.Executor arg4, Android.Os.CancellationSignal arg5, Android.Net.DnsResolver.Callback<Arg6objectSuperJava_Util_List_Java_Net_InetAddress_> arg6) where Arg6objectSuperJava_Util_List_Java_Net_InetAddress_ : Java.Util.List<Java.Net.InetAddress>
        {
            IExecuteWithSignature("query", "(Landroid/net/Network;Ljava/lang/String;IILjava/util/concurrent/Executor;Landroid/os/CancellationSignal;Landroid/net/DnsResolver$Callback;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#query(android.net.Network,java.lang.String,int,java.util.concurrent.Executor,android.os.CancellationSignal,android.net.DnsResolver.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Network"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg5"><see cref="Android.Net.DnsResolver.Callback"/></param>
        /// <typeparam name="Arg5objectSuperJava_Util_List_Java_Net_InetAddress_"><see cref="Java.Util.List{Java.Net.InetAddress}"/></typeparam>
        public void Query<Arg5objectSuperJava_Util_List_Java_Net_InetAddress_>(Android.Net.Network arg0, Java.Lang.String arg1, int arg2, Java.Util.Concurrent.Executor arg3, Android.Os.CancellationSignal arg4, Android.Net.DnsResolver.Callback<Arg5objectSuperJava_Util_List_Java_Net_InetAddress_> arg5) where Arg5objectSuperJava_Util_List_Java_Net_InetAddress_ : Java.Util.List<Java.Net.InetAddress>
        {
            IExecuteWithSignature("query", "(Landroid/net/Network;Ljava/lang/String;ILjava/util/concurrent/Executor;Landroid/os/CancellationSignal;Landroid/net/DnsResolver$Callback;)V", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#rawQuery(android.net.Network,byte[],int,java.util.concurrent.Executor,android.os.CancellationSignal,android.net.DnsResolver.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Network"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg5"><see cref="Android.Net.DnsResolver.Callback"/></param>
        public void RawQuery(Android.Net.Network arg0, byte[] arg1, int arg2, Java.Util.Concurrent.Executor arg3, Android.Os.CancellationSignal arg4, Android.Net.DnsResolver.Callback<byte[]> arg5)
        {
            IExecuteWithSignature("rawQuery", "(Landroid/net/Network;[BILjava/util/concurrent/Executor;Landroid/os/CancellationSignal;Landroid/net/DnsResolver$Callback;)V", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/DnsResolver.html#rawQuery(android.net.Network,java.lang.String,int,int,int,java.util.concurrent.Executor,android.os.CancellationSignal,android.net.DnsResolver.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Network"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg6"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg7"><see cref="Android.Net.DnsResolver.Callback"/></param>
        public void RawQuery(Android.Net.Network arg0, Java.Lang.String arg1, int arg2, int arg3, int arg4, Java.Util.Concurrent.Executor arg5, Android.Os.CancellationSignal arg6, Android.Net.DnsResolver.Callback<byte[]> arg7)
        {
            IExecuteWithSignature("rawQuery", "(Landroid/net/Network;Ljava/lang/String;IIILjava/util/concurrent/Executor;Landroid/os/CancellationSignal;Landroid/net/DnsResolver$Callback;)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    
        #endregion
    
        #region Nested classes
        #region Callback implementation
        public partial class Callback
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/DnsResolver.Callback.html#onAnswer(java.lang.Object,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnAnswer(object arg0, int arg1)
            {
                IExecuteWithSignature("onAnswer", "(Ljava/lang/Object;I)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/DnsResolver.Callback.html#onError(android.net.DnsResolver.DnsException)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.DnsResolver.DnsException"/></param>
            public void OnError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                IExecuteWithSignature("onError", "(Landroid/net/DnsResolver$DnsException;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Callback<T> implementation
        public partial class Callback<T>
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Net.DnsResolver.Callback{T}"/> to <see cref="Android.Net.DnsResolver.Callback"/>
            /// </summary>
            public static implicit operator Android.Net.DnsResolver.Callback(Android.Net.DnsResolver.Callback<T> t) => t.Cast<Android.Net.DnsResolver.Callback>();
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/DnsResolver.Callback.html#onAnswer(java.lang.Object,int)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="T"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnAnswer(T arg0, int arg1)
            {
                IExecuteWithSignature("onAnswer", "(Ljava/lang/Object;I)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/DnsResolver.Callback.html#onError(android.net.DnsResolver.DnsException)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.DnsResolver.DnsException"/></param>
            public void OnError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                IExecuteWithSignature("onError", "(Landroid/net/DnsResolver$DnsException;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region DnsException implementation
        public partial class DnsException
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}