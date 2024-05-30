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

namespace Java.Nio.Channels
{
    #region ServerSocketChannel
    public partial class ServerSocketChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.ServerSocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.ServerSocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#open()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.ServerSocketChannel Open()
        {
            return SExecuteWithSignature<Java.Nio.Channels.ServerSocketChannel>(LocalBridgeClazz, "open", "()Ljava/nio/channels/ServerSocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#open(java.net.ProtocolFamily)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ProtocolFamily"/></param>
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.ServerSocketChannel Open(Java.Net.ProtocolFamily arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.ServerSocketChannel>(LocalBridgeClazz, "open", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/ServerSocketChannel;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#socket()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.ServerSocket"/></returns>
        public Java.Net.ServerSocket Socket()
        {
            return IExecuteWithSignature<Java.Net.ServerSocket>("socket", "()Ljava/net/ServerSocket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#bind(java.net.SocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.ServerSocketChannel Bind(Java.Net.SocketAddress arg0, int arg1)
        {
            return IExecute<Java.Nio.Channels.ServerSocketChannel>("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#accept()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel Accept()
        {
            return IExecuteWithSignature<Java.Nio.Channels.SocketChannel>("accept", "()Ljava/nio/channels/SocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/ServerSocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel SetOption(Java.Net.SocketOption arg0, object arg1)
        {
            return IExecute<Java.Nio.Channels.NetworkChannel>("setOption", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}