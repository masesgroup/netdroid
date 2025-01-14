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

namespace Java.Net
{
    #region DatagramSocket declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html"/>
    /// </summary>
    public partial class DatagramSocket : Java.Io.Closeable
    {
        const string _bridgeClassName = "java.net.DatagramSocket";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DatagramSocket() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DatagramSocket(params object[] args) : base(args) { }
    
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

    #region DatagramSocket implementation
    public partial class DatagramSocket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#%3Cinit%3E(int,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Net.InetAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public DatagramSocket(int arg0, Java.Net.InetAddress arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public DatagramSocket(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#%3Cinit%3E(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public DatagramSocket(Java.Net.SocketAddress arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocketImplFactory"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static void SetDatagramSocketImplFactory(Java.Net.DatagramSocketImplFactory arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Net.DatagramSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.DatagramSocket SetOption<T>(Java.Net.SocketOption<T> arg0, T arg1)
        {
            return IExecuteWithSignature<Java.Net.DatagramSocket>("setOption", "(Ljava/net/SocketOption;Ljava/lang/Object;)Ljava/net/DatagramSocket;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getOption(java.net.SocketOption)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public T GetOption<T>(Java.Net.SocketOption<T> arg0)
        {
            return IExecuteWithSignature<T>("getOption", "(Ljava/net/SocketOption;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getBroadcast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool GetBroadcast()
        {
            return IExecuteWithSignature<bool>("getBroadcast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getReuseAddress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool GetReuseAddress()
        {
            return IExecuteWithSignature<bool>("getReuseAddress", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#isBound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecuteWithSignature<bool>("isBound", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getLocalPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLocalPort()
        {
            return IExecuteWithSignature<int>("getLocalPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getReceiveBufferSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public int GetReceiveBufferSize()
        {
            return IExecuteWithSignature<int>("getReceiveBufferSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getSendBufferSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public int GetSendBufferSize()
        {
            return IExecuteWithSignature<int>("getSendBufferSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getSoTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public int GetSoTimeout()
        {
            return IExecuteWithSignature<int>("getSoTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getTrafficClass()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public int GetTrafficClass()
        {
            return IExecuteWithSignature<int>("getTrafficClass", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getInetAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress GetInetAddress()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("getInetAddress", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getLocalAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress GetLocalAddress()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("getLocalAddress", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getLocalSocketAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.SocketAddress"/></returns>
        public Java.Net.SocketAddress GetLocalSocketAddress()
        {
            return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalSocketAddress", "()Ljava/net/SocketAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getRemoteSocketAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.SocketAddress"/></returns>
        public Java.Net.SocketAddress GetRemoteSocketAddress()
        {
            return IExecuteWithSignature<Java.Net.SocketAddress>("getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#getChannel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        public Java.Nio.Channels.DatagramChannel GetChannel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.DatagramChannel>("getChannel", "()Ljava/nio/channels/DatagramChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#supportedOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Net.SocketOption<object>> SupportedOptions()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Net.SocketOption<object>>>("supportedOptions", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void Bind(Java.Net.SocketAddress arg0)
        {
            IExecuteWithSignature("bind", "(Ljava/net/SocketAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#connect(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Connect(Java.Net.InetAddress arg0, int arg1)
        {
            IExecuteWithSignature("connect", "(Ljava/net/InetAddress;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void Connect(Java.Net.SocketAddress arg0)
        {
            IExecuteWithSignature("connect", "(Ljava/net/SocketAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#joinGroup(java.net.SocketAddress,java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void JoinGroup(Java.Net.SocketAddress arg0, Java.Net.NetworkInterface arg1)
        {
            IExecuteWithSignature("joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#leaveGroup(java.net.SocketAddress,java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void LeaveGroup(Java.Net.SocketAddress arg0, Java.Net.NetworkInterface arg1)
        {
            IExecuteWithSignature("leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#receive(java.net.DatagramPacket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramPacket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Receive(Java.Net.DatagramPacket arg0)
        {
            IExecuteWithSignature("receive", "(Ljava/net/DatagramPacket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#send(java.net.DatagramPacket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramPacket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Send(Java.Net.DatagramPacket arg0)
        {
            IExecuteWithSignature("send", "(Ljava/net/DatagramPacket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setBroadcast(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetBroadcast(bool arg0)
        {
            IExecuteWithSignature("setBroadcast", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetReceiveBufferSize(int arg0)
        {
            IExecuteWithSignature("setReceiveBufferSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setReuseAddress(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetReuseAddress(bool arg0)
        {
            IExecuteWithSignature("setReuseAddress", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setSendBufferSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetSendBufferSize(int arg0)
        {
            IExecuteWithSignature("setSendBufferSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setSoTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetSoTimeout(int arg0)
        {
            IExecuteWithSignature("setSoTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/DatagramSocket.html#setTrafficClass(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetTrafficClass(int arg0)
        {
            IExecuteWithSignature("setTrafficClass", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}