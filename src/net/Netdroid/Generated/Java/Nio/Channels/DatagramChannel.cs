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
    #region DatagramChannel
    public partial class DatagramChannel : Java.Nio.Channels.IByteChannel, Java.Nio.Channels.IScatteringByteChannel, Java.Nio.Channels.IGatheringByteChannel, Java.Nio.Channels.IMulticastChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.DatagramChannel"/> to <see cref="Java.Nio.Channels.ByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ByteChannel(Java.Nio.Channels.DatagramChannel t) => t.Cast<Java.Nio.Channels.ByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.DatagramChannel"/> to <see cref="Java.Nio.Channels.ScatteringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ScatteringByteChannel(Java.Nio.Channels.DatagramChannel t) => t.Cast<Java.Nio.Channels.ScatteringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.DatagramChannel"/> to <see cref="Java.Nio.Channels.GatheringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.GatheringByteChannel(Java.Nio.Channels.DatagramChannel t) => t.Cast<Java.Nio.Channels.GatheringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.DatagramChannel"/> to <see cref="Java.Nio.Channels.MulticastChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.MulticastChannel(Java.Nio.Channels.DatagramChannel t) => t.Cast<Java.Nio.Channels.MulticastChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#open()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.DatagramChannel Open()
        {
            return SExecuteWithSignature<Java.Nio.Channels.DatagramChannel>(LocalBridgeClazz, "open", "()Ljava/nio/channels/DatagramChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#open(java.net.ProtocolFamily)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ProtocolFamily"/></param>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.DatagramChannel Open(Java.Net.ProtocolFamily arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.DatagramChannel>(LocalBridgeClazz, "open", "(Ljava/net/ProtocolFamily;)Ljava/nio/channels/DatagramChannel;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#getRemoteAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteAddress
        {
            get { return IExecuteWithSignature<Java.Net.SocketAddress>("getRemoteAddress", "()Ljava/net/SocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("read", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#send(java.nio.ByteBuffer,java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Send(Java.Nio.ByteBuffer arg0, Java.Net.SocketAddress arg1)
        {
            return IExecute<int>("send", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("write", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#socket()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.DatagramSocket"/></returns>
        public Java.Net.DatagramSocket Socket()
        {
            return IExecuteWithSignature<Java.Net.DatagramSocket>("socket", "()Ljava/net/DatagramSocket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#receive(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Net.SocketAddress"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.SocketAddress Receive(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Net.SocketAddress>("receive", "(Ljava/nio/ByteBuffer;)Ljava/net/SocketAddress;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.DatagramChannel Connect(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.DatagramChannel>("connect", "(Ljava/net/SocketAddress;)Ljava/nio/channels/DatagramChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#disconnect()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.DatagramChannel Disconnect()
        {
            return IExecuteWithSignature<Java.Nio.Channels.DatagramChannel>("disconnect", "()Ljava/nio/channels/DatagramChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#read(java.nio.ByteBuffer[],int,int)"/>
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
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#write(java.nio.ByteBuffer[],int,int)"/>
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
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#read(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("read", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#write(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecuteWithSignature<long>("write", "([Ljava/nio/ByteBuffer;)J", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/channels/DatagramChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
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