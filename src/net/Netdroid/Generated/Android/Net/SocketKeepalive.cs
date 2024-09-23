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

namespace Android.Net
{
    #region SocketKeepalive declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html"/>
    /// </summary>
    public partial class SocketKeepalive : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.net.SocketKeepalive";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SocketKeepalive class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SocketKeepalive() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SocketKeepalive class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SocketKeepalive(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region Callback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.Callback.html"/>
        /// </summary>
        public partial class Callback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback>
        {
            const string _bridgeClassName = "android.net.SocketKeepalive$Callback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Callback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region SocketKeepalive implementation
    public partial class SocketKeepalive
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_HARDWARE_ERROR"/>
        /// </summary>
        public static int ERROR_HARDWARE_ERROR { get { if (!_ERROR_HARDWARE_ERRORReady) { _ERROR_HARDWARE_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_HARDWARE_ERROR"); _ERROR_HARDWARE_ERRORReady = true; } return _ERROR_HARDWARE_ERRORContent; } }
        private static int _ERROR_HARDWARE_ERRORContent = default;
        private static bool _ERROR_HARDWARE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INSUFFICIENT_RESOURCES"/>
        /// </summary>
        public static int ERROR_INSUFFICIENT_RESOURCES { get { if (!_ERROR_INSUFFICIENT_RESOURCESReady) { _ERROR_INSUFFICIENT_RESOURCESContent = SGetField<int>(LocalBridgeClazz, "ERROR_INSUFFICIENT_RESOURCES"); _ERROR_INSUFFICIENT_RESOURCESReady = true; } return _ERROR_INSUFFICIENT_RESOURCESContent; } }
        private static int _ERROR_INSUFFICIENT_RESOURCESContent = default;
        private static bool _ERROR_INSUFFICIENT_RESOURCESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INVALID_INTERVAL"/>
        /// </summary>
        public static int ERROR_INVALID_INTERVAL { get { if (!_ERROR_INVALID_INTERVALReady) { _ERROR_INVALID_INTERVALContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_INTERVAL"); _ERROR_INVALID_INTERVALReady = true; } return _ERROR_INVALID_INTERVALContent; } }
        private static int _ERROR_INVALID_INTERVALContent = default;
        private static bool _ERROR_INVALID_INTERVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INVALID_IP_ADDRESS"/>
        /// </summary>
        public static int ERROR_INVALID_IP_ADDRESS { get { if (!_ERROR_INVALID_IP_ADDRESSReady) { _ERROR_INVALID_IP_ADDRESSContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_IP_ADDRESS"); _ERROR_INVALID_IP_ADDRESSReady = true; } return _ERROR_INVALID_IP_ADDRESSContent; } }
        private static int _ERROR_INVALID_IP_ADDRESSContent = default;
        private static bool _ERROR_INVALID_IP_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INVALID_LENGTH"/>
        /// </summary>
        public static int ERROR_INVALID_LENGTH { get { if (!_ERROR_INVALID_LENGTHReady) { _ERROR_INVALID_LENGTHContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_LENGTH"); _ERROR_INVALID_LENGTHReady = true; } return _ERROR_INVALID_LENGTHContent; } }
        private static int _ERROR_INVALID_LENGTHContent = default;
        private static bool _ERROR_INVALID_LENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INVALID_NETWORK"/>
        /// </summary>
        public static int ERROR_INVALID_NETWORK { get { if (!_ERROR_INVALID_NETWORKReady) { _ERROR_INVALID_NETWORKContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_NETWORK"); _ERROR_INVALID_NETWORKReady = true; } return _ERROR_INVALID_NETWORKContent; } }
        private static int _ERROR_INVALID_NETWORKContent = default;
        private static bool _ERROR_INVALID_NETWORKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INVALID_PORT"/>
        /// </summary>
        public static int ERROR_INVALID_PORT { get { if (!_ERROR_INVALID_PORTReady) { _ERROR_INVALID_PORTContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_PORT"); _ERROR_INVALID_PORTReady = true; } return _ERROR_INVALID_PORTContent; } }
        private static int _ERROR_INVALID_PORTContent = default;
        private static bool _ERROR_INVALID_PORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_INVALID_SOCKET"/>
        /// </summary>
        public static int ERROR_INVALID_SOCKET { get { if (!_ERROR_INVALID_SOCKETReady) { _ERROR_INVALID_SOCKETContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_SOCKET"); _ERROR_INVALID_SOCKETReady = true; } return _ERROR_INVALID_SOCKETContent; } }
        private static int _ERROR_INVALID_SOCKETContent = default;
        private static bool _ERROR_INVALID_SOCKETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_SOCKET_NOT_IDLE"/>
        /// </summary>
        public static int ERROR_SOCKET_NOT_IDLE { get { if (!_ERROR_SOCKET_NOT_IDLEReady) { _ERROR_SOCKET_NOT_IDLEContent = SGetField<int>(LocalBridgeClazz, "ERROR_SOCKET_NOT_IDLE"); _ERROR_SOCKET_NOT_IDLEReady = true; } return _ERROR_SOCKET_NOT_IDLEContent; } }
        private static int _ERROR_SOCKET_NOT_IDLEContent = default;
        private static bool _ERROR_SOCKET_NOT_IDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#ERROR_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_UNSUPPORTED { get { if (!_ERROR_UNSUPPORTEDReady) { _ERROR_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSUPPORTED"); _ERROR_UNSUPPORTEDReady = true; } return _ERROR_UNSUPPORTEDContent; } }
        private static int _ERROR_UNSUPPORTEDContent = default;
        private static bool _ERROR_UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#start(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Start(int arg0)
        {
            IExecuteWithSignature("start", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
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
            /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.Callback.html#onDataReceived()"/>
            /// </summary>
            public void OnDataReceived()
            {
                IExecuteWithSignature("onDataReceived", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.Callback.html#onError(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnError(int arg0)
            {
                IExecuteWithSignature("onError", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.Callback.html#onStarted()"/>
            /// </summary>
            public void OnStarted()
            {
                IExecuteWithSignature("onStarted", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/SocketKeepalive.Callback.html#onStopped()"/>
            /// </summary>
            public void OnStopped()
            {
                IExecuteWithSignature("onStopped", "()V");
            }
        
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