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

namespace Android.Net
{
    #region LocalSocket
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
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getAncillaryFileDescriptors()"/> 
        /// </summary>
        public Java.Io.FileDescriptor[] AncillaryFileDescriptors
        {
            get { return IExecuteWithSignatureArray<Java.Io.FileDescriptor>("getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getFileDescriptor()"/> 
        /// </summary>
        public Java.Io.FileDescriptor FileDescriptor
        {
            get { return IExecuteWithSignature<Java.Io.FileDescriptor>("getFileDescriptor", "()Ljava/io/FileDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getLocalSocketAddress()"/> 
        /// </summary>
        public Android.Net.LocalSocketAddress LocalSocketAddress
        {
            get { return IExecuteWithSignature<Android.Net.LocalSocketAddress>("getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getPeerCredentials()"/> 
        /// </summary>
        public Android.Net.Credentials PeerCredentials
        {
            get { return IExecuteWithSignature<Android.Net.Credentials>("getPeerCredentials", "()Landroid/net/Credentials;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getReceiveBufferSize()"/> <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        public int ReceiveBufferSize
        {
            get { return IExecuteWithSignature<int>("getReceiveBufferSize", "()I"); } set { IExecuteWithSignature("setReceiveBufferSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getRemoteSocketAddress()"/> 
        /// </summary>
        public Android.Net.LocalSocketAddress RemoteSocketAddress
        {
            get { return IExecuteWithSignature<Android.Net.LocalSocketAddress>("getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getSendBufferSize()"/> <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setSendBufferSize(int)"/>
        /// </summary>
        public int SendBufferSize
        {
            get { return IExecuteWithSignature<int>("getSendBufferSize", "()I"); } set { IExecuteWithSignature("setSendBufferSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LocalSocket.html#getSoTimeout()"/> <see href="https://developer.android.com/reference/android/net/LocalSocket.html#setSoTimeout(int)"/>
        /// </summary>
        public int SoTimeout
        {
            get { return IExecuteWithSignature<int>("getSoTimeout", "()I"); } set { IExecuteWithSignature("setSoTimeout", "(I)V", value); }
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
            IExecute("connect", arg0, arg1);
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