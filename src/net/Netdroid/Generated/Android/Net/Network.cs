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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net
{
    #region Network
    public partial class Network
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#fromNetworkHandle(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Net.Network"/></returns>
        public static Android.Net.Network FromNetworkHandle(long arg0)
        {
            return SExecuteWithSignature<Android.Net.Network>(LocalBridgeClazz, "fromNetworkHandle", "(J)Landroid/net/Network;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#getByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public Java.Net.InetAddress GetByName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#getAllByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public Java.Net.InetAddress[] GetAllByName(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Net.InetAddress>("getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#openConnection(java.net.URL,java.net.Proxy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Net.Proxy"/></param>
        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection(Java.Net.URL arg0, Java.Net.Proxy arg1)
        {
            return IExecute<Java.Net.URLConnection>("openConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#openConnection(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Java.Net.URLConnection>("openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#getSocketFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.SocketFactory"/></returns>
        public Javax.Net.SocketFactory GetSocketFactory()
        {
            return IExecuteWithSignature<Javax.Net.SocketFactory>("getSocketFactory", "()Ljavax/net/SocketFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#getNetworkHandle()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetNetworkHandle()
        {
            return IExecuteWithSignature<long>("getNetworkHandle", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#bindSocket(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void BindSocket(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("bindSocket", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#bindSocket(java.net.DatagramSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void BindSocket(Java.Net.DatagramSocket arg0)
        {
            IExecuteWithSignature("bindSocket", "(Ljava/net/DatagramSocket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#bindSocket(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void BindSocket(Java.Net.Socket arg0)
        {
            IExecuteWithSignature("bindSocket", "(Ljava/net/Socket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/Network.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}