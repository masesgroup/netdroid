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
    #region SocketChannel
    public partial class SocketChannel : Java.Nio.Channels.IByteChannel, Java.Nio.Channels.IScatteringByteChannel, Java.Nio.Channels.IGatheringByteChannel, Java.Nio.Channels.INetworkChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.ByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ByteChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.ByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.ScatteringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ScatteringByteChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.ScatteringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.GatheringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.GatheringByteChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.GatheringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#open()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.SocketChannel Open()
        {
            return SExecuteWithSignature<Java.Nio.Channels.SocketChannel>(LocalBridgeClazz, "open", "()Ljava/nio/channels/SocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#open(java.net.ProtocolFamily)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ProtocolFamily"/></param>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.SocketChannel Open(Java.Net.ProtocolFamily arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.SocketChannel>(LocalBridgeClazz, "open", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/SocketChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#open(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.SocketChannel Open(Java.Net.SocketAddress arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.SocketChannel>(LocalBridgeClazz, "open", "(Ljava/net/SocketAddress;)Ljava/nio/channels/SocketChannel;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#getRemoteAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getRemoteAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool Connect(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<bool>("connect", "(Ljava/net/SocketAddress;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#finishConnect()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool FinishConnect()
        {
            return IExecuteWithSignature<bool>("finishConnect", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#isConnectionPending()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnectionPending()
        {
            return IExecuteWithSignature<bool>("isConnectionPending", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#socket()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        public Java.Net.Socket Socket()
        {
            return IExecuteWithSignature<Java.Net.Socket>("socket", "()Ljava/net/Socket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#shutdownInput()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel ShutdownInput()
        {
            return IExecuteWithSignature<Java.Nio.Channels.SocketChannel>("shutdownInput", "()Ljava/nio/channels/SocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#shutdownOutput()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel ShutdownOutput()
        {
            return IExecuteWithSignature<Java.Nio.Channels.SocketChannel>("shutdownOutput", "()Ljava/nio/channels/SocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#read(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#write(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#read(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("read", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#write(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("write", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/SocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
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