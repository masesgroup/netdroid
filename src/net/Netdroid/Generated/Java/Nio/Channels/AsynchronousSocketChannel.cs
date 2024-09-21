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

namespace Java.Nio.Channels
{
    #region AsynchronousSocketChannel declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html"/>
    /// </summary>
    public partial class AsynchronousSocketChannel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AsynchronousSocketChannel>
    {
        const string _bridgeClassName = "java.nio.channels.AsynchronousSocketChannel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AsynchronousSocketChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsynchronousSocketChannel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AsynchronousSocketChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsynchronousSocketChannel(params object[] args) : base(args) { }

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

    }
    #endregion

    #region AsynchronousSocketChannel implementation
    public partial class AsynchronousSocketChannel : Java.Nio.Channels.IAsynchronousByteChannel, Java.Nio.Channels.INetworkChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.AsynchronousSocketChannel"/> to <see cref="Java.Nio.Channels.AsynchronousByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.AsynchronousByteChannel(Java.Nio.Channels.AsynchronousSocketChannel t) => t.Cast<Java.Nio.Channels.AsynchronousByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.AsynchronousSocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.AsynchronousSocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#open()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousSocketChannel Open()
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousSocketChannel>(LocalBridgeClazz, "open", "()Ljava/nio/channels/AsynchronousSocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#open(java.nio.channels.AsynchronousChannelGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousSocketChannel Open(Java.Nio.Channels.AsynchronousChannelGroup arg0)
        {
            return SExecuteWithSignature<Java.Nio.Channels.AsynchronousSocketChannel>(LocalBridgeClazz, "open", "(Ljava/nio/channels/AsynchronousChannelGroup;)Ljava/nio/channels/AsynchronousSocketChannel;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#connect(java.net.SocketAddress,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        public void Connect<A, Arg2objectSuperA>(Java.Net.SocketAddress arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Void, Arg2objectSuperA> arg2) where Arg2objectSuperA : A
        {
            IExecute("connect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><typeparamref name="A"/></param>
        /// <param name="arg4"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg4objectSuperA"><typeparamref name="A"/></typeparam>
        public void Read<A, Arg4objectSuperA>(Java.Nio.ByteBuffer arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, A arg3, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg4objectSuperA> arg4) where Arg4objectSuperA : A
        {
            IExecute("read", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer[],int,int,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg5"><typeparamref name="A"/></param>
        /// <param name="arg6"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg6objectSuperA"><typeparamref name="A"/></typeparam>
        public void Read<A, Arg6objectSuperA>(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, long arg3, Java.Util.Concurrent.TimeUnit arg4, A arg5, Java.Nio.Channels.CompletionHandler<Java.Lang.Long, Arg6objectSuperA> arg6) where Arg6objectSuperA : A
        {
            IExecute("read", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><typeparamref name="A"/></param>
        /// <param name="arg4"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg4objectSuperA"><typeparamref name="A"/></typeparam>
        public void Write<A, Arg4objectSuperA>(Java.Nio.ByteBuffer arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, A arg3, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg4objectSuperA> arg4) where Arg4objectSuperA : A
        {
            IExecute("write", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer[],int,int,long,java.util.concurrent.TimeUnit,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg5"><typeparamref name="A"/></param>
        /// <param name="arg6"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg6objectSuperA"><typeparamref name="A"/></typeparam>
        public void Write<A, Arg6objectSuperA>(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, long arg3, Java.Util.Concurrent.TimeUnit arg4, A arg5, Java.Nio.Channels.CompletionHandler<Java.Lang.Long, Arg6objectSuperA> arg6) where Arg6objectSuperA : A
        {
            IExecute("write", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#getLocalAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.SocketAddress"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.SocketAddress GetLocalAddress()
        {
            return IExecuteWithSignature<Java.Net.SocketAddress>("getLocalAddress", "()Ljava/net/SocketAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#getRemoteAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.SocketAddress"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.SocketAddress GetRemoteAddress()
        {
            return IExecuteWithSignature<Java.Net.SocketAddress>("getRemoteAddress", "()Ljava/net/SocketAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#shutdownInput()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousSocketChannel ShutdownInput()
        {
            return IExecuteWithSignature<Java.Nio.Channels.AsynchronousSocketChannel>("shutdownInput", "()Ljava/nio/channels/AsynchronousSocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#shutdownOutput()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousSocketChannel ShutdownOutput()
        {
            return IExecuteWithSignature<Java.Nio.Channels.AsynchronousSocketChannel>("shutdownOutput", "()Ljava/nio/channels/AsynchronousSocketChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Integer> Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Integer>>("read", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Integer> Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Integer>>("write", "(Ljava/nio/ByteBuffer;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Void> Connect(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Void>>("connect", "(Ljava/net/SocketAddress;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#read(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        public void Read<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg2objectSuperA> arg2) where Arg2objectSuperA : A
        {
            IExecute("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#write(java.nio.ByteBuffer,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><typeparamref name="A"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg2objectSuperA"><typeparamref name="A"/></typeparam>
        public void Write<A, Arg2objectSuperA>(Java.Nio.ByteBuffer arg0, A arg1, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg2objectSuperA> arg2) where Arg2objectSuperA : A
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#provider()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Spi.AsynchronousChannelProvider"/></returns>
        public Java.Nio.Channels.Spi.AsynchronousChannelProvider Provider()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Spi.AsynchronousChannelProvider>("provider", "()Ljava/nio/channels/spi/AsynchronousChannelProvider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.NetworkChannel>("bind", "(Ljava/net/SocketAddress;)Ljava/nio/channels/NetworkChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousSocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
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