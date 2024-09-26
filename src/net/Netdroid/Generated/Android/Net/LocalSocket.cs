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
    #region LocalSocket declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html"/>
    /// </summary>
    public partial class LocalSocket : Java.Io.Closeable
    {
        const string _bridgeClassName = "android.net.LocalSocket";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LocalSocket() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LocalSocket(params object[] args) : base(args) { }

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

    #region LocalSocket implementation
    public partial class LocalSocket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public LocalSocket(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#SOCKET_DGRAM"/>
        /// </summary>
        public static int SOCKET_DGRAM { get { if (!_SOCKET_DGRAMReady) { _SOCKET_DGRAMContent = SGetField<int>(LocalBridgeClazz, "SOCKET_DGRAM"); _SOCKET_DGRAMReady = true; } return _SOCKET_DGRAMContent; } }
        private static int _SOCKET_DGRAMContent = default;
        private static bool _SOCKET_DGRAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#SOCKET_SEQPACKET"/>
        /// </summary>
        public static int SOCKET_SEQPACKET { get { if (!_SOCKET_SEQPACKETReady) { _SOCKET_SEQPACKETContent = SGetField<int>(LocalBridgeClazz, "SOCKET_SEQPACKET"); _SOCKET_SEQPACKETReady = true; } return _SOCKET_SEQPACKETContent; } }
        private static int _SOCKET_SEQPACKETContent = default;
        private static bool _SOCKET_SEQPACKETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#SOCKET_STREAM"/>
        /// </summary>
        public static int SOCKET_STREAM { get { if (!_SOCKET_STREAMReady) { _SOCKET_STREAMContent = SGetField<int>(LocalBridgeClazz, "SOCKET_STREAM"); _SOCKET_STREAMReady = true; } return _SOCKET_STREAMContent; } }
        private static int _SOCKET_STREAMContent = default;
        private static bool _SOCKET_STREAMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getPeerCredentials()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Credentials"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Net.Credentials GetPeerCredentials()
        {
            return IExecuteWithSignature<Android.Net.Credentials>("getPeerCredentials", "()Landroid/net/Credentials;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getLocalSocketAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.LocalSocketAddress"/></returns>
        public Android.Net.LocalSocketAddress GetLocalSocketAddress()
        {
            return IExecuteWithSignature<Android.Net.LocalSocketAddress>("getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getRemoteSocketAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.LocalSocketAddress"/></returns>
        public Android.Net.LocalSocketAddress GetRemoteSocketAddress()
        {
            return IExecuteWithSignature<Android.Net.LocalSocketAddress>("getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#isInputShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInputShutdown()
        {
            return IExecuteWithSignature<bool>("isInputShutdown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#isOutputShutdown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputShutdown()
        {
            return IExecuteWithSignature<bool>("isOutputShutdown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getReceiveBufferSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetReceiveBufferSize()
        {
            return IExecuteWithSignature<int>("getReceiveBufferSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getSendBufferSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetSendBufferSize()
        {
            return IExecuteWithSignature<int>("getSendBufferSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getSoTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetSoTimeout()
        {
            return IExecuteWithSignature<int>("getSoTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getFileDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileDescriptor"/></returns>
        public Java.Io.FileDescriptor GetFileDescriptor()
        {
            return IExecuteWithSignature<Java.Io.FileDescriptor>("getFileDescriptor", "()Ljava/io/FileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getAncillaryFileDescriptors()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.FileDescriptor[] GetAncillaryFileDescriptors()
        {
            return IExecuteWithSignatureArray<Java.Io.FileDescriptor>("getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream GetOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#isBound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecuteWithSignature<bool>("isBound", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#bind(android.net.LocalSocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.LocalSocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Bind(Android.Net.LocalSocketAddress arg0)
        {
            IExecuteWithSignature("bind", "(Landroid/net/LocalSocketAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#connect(android.net.LocalSocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.LocalSocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Android.Net.LocalSocketAddress arg0, int arg1)
        {
            IExecuteWithSignature("connect", "(Landroid/net/LocalSocketAddress;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#connect(android.net.LocalSocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.LocalSocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Android.Net.LocalSocketAddress arg0)
        {
            IExecuteWithSignature("connect", "(Landroid/net/LocalSocketAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setFileDescriptorsForSend(java.io.FileDescriptor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        public void SetFileDescriptorsForSend(Java.Io.FileDescriptor[] arg0)
        {
            IExecuteWithSignature("setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetReceiveBufferSize(int arg0)
        {
            IExecuteWithSignature("setReceiveBufferSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setSendBufferSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSendBufferSize(int arg0)
        {
            IExecuteWithSignature("setSendBufferSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setSoTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSoTimeout(int arg0)
        {
            IExecuteWithSignature("setSoTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#shutdownInput()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownInput()
        {
            IExecuteWithSignature("shutdownInput", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#shutdownOutput()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownOutput()
        {
            IExecuteWithSignature("shutdownOutput", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}