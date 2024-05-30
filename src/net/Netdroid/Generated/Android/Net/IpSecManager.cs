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
    #region IpSecManager
    public partial class IpSecManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#DIRECTION_IN"/>
        /// </summary>
        public static int DIRECTION_IN { get { if (!_DIRECTION_INReady) { _DIRECTION_INContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_IN"); _DIRECTION_INReady = true; } return _DIRECTION_INContent; } }
        private static int _DIRECTION_INContent = default;
        private static bool _DIRECTION_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#DIRECTION_OUT"/>
        /// </summary>
        public static int DIRECTION_OUT { get { if (!_DIRECTION_OUTReady) { _DIRECTION_OUTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_OUT"); _DIRECTION_OUTReady = true; } return _DIRECTION_OUTContent; } }
        private static int _DIRECTION_OUTContent = default;
        private static bool _DIRECTION_OUTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#allocateSecurityParameterIndex(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.IpSecManager.SecurityParameterIndex"/></returns>
        /// <exception cref="Android.Net.IpSecManager.ResourceUnavailableException"/>
        /// <exception cref="Android.Net.IpSecManager.SpiUnavailableException"/>
        public Android.Net.IpSecManager.SecurityParameterIndex AllocateSecurityParameterIndex(Java.Net.InetAddress arg0, int arg1)
        {
            return IExecute<Android.Net.IpSecManager.SecurityParameterIndex>("allocateSecurityParameterIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#allocateSecurityParameterIndex(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Android.Net.IpSecManager.SecurityParameterIndex"/></returns>
        /// <exception cref="Android.Net.IpSecManager.ResourceUnavailableException"/>
        public Android.Net.IpSecManager.SecurityParameterIndex AllocateSecurityParameterIndex(Java.Net.InetAddress arg0)
        {
            return IExecuteWithSignature<Android.Net.IpSecManager.SecurityParameterIndex>("allocateSecurityParameterIndex", "(Ljava/net/InetAddress;)Landroid/net/IpSecManager$SecurityParameterIndex;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#openUdpEncapsulationSocket()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.IpSecManager.UdpEncapsulationSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Android.Net.IpSecManager.ResourceUnavailableException"/>
        public Android.Net.IpSecManager.UdpEncapsulationSocket OpenUdpEncapsulationSocket()
        {
            return IExecuteWithSignature<Android.Net.IpSecManager.UdpEncapsulationSocket>("openUdpEncapsulationSocket", "()Landroid/net/IpSecManager$UdpEncapsulationSocket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#openUdpEncapsulationSocket(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.IpSecManager.UdpEncapsulationSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Android.Net.IpSecManager.ResourceUnavailableException"/>
        public Android.Net.IpSecManager.UdpEncapsulationSocket OpenUdpEncapsulationSocket(int arg0)
        {
            return IExecuteWithSignature<Android.Net.IpSecManager.UdpEncapsulationSocket>("openUdpEncapsulationSocket", "(I)Landroid/net/IpSecManager$UdpEncapsulationSocket;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#applyTransportModeTransform(java.io.FileDescriptor,int,android.net.IpSecTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Net.IpSecTransform"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ApplyTransportModeTransform(Java.Io.FileDescriptor arg0, int arg1, Android.Net.IpSecTransform arg2)
        {
            IExecute("applyTransportModeTransform", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#applyTransportModeTransform(java.net.DatagramSocket,int,android.net.IpSecTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocket"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Net.IpSecTransform"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ApplyTransportModeTransform(Java.Net.DatagramSocket arg0, int arg1, Android.Net.IpSecTransform arg2)
        {
            IExecute("applyTransportModeTransform", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#applyTransportModeTransform(java.net.Socket,int,android.net.IpSecTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Net.IpSecTransform"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ApplyTransportModeTransform(Java.Net.Socket arg0, int arg1, Android.Net.IpSecTransform arg2)
        {
            IExecute("applyTransportModeTransform", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#removeTransportModeTransforms(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveTransportModeTransforms(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("removeTransportModeTransforms", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#removeTransportModeTransforms(java.net.DatagramSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveTransportModeTransforms(Java.Net.DatagramSocket arg0)
        {
            IExecuteWithSignature("removeTransportModeTransforms", "(Ljava/net/DatagramSocket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecManager.html#removeTransportModeTransforms(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveTransportModeTransforms(Java.Net.Socket arg0)
        {
            IExecuteWithSignature("removeTransportModeTransforms", "(Ljava/net/Socket;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ResourceUnavailableException
        public partial class ResourceUnavailableException
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

        #region SecurityParameterIndex
        public partial class SecurityParameterIndex
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
            /// <see href="https://developer.android.com/reference/android/net/IpSecManager.SecurityParameterIndex.html#getSpi()"/> 
            /// </summary>
            public int Spi
            {
                get { return IExecuteWithSignature<int>("getSpi", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecManager.SecurityParameterIndex.html#close()"/>
            /// </summary>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SpiUnavailableException
        public partial class SpiUnavailableException
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

        #region UdpEncapsulationSocket
        public partial class UdpEncapsulationSocket
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
            /// <see href="https://developer.android.com/reference/android/net/IpSecManager.UdpEncapsulationSocket.html#getFileDescriptor()"/> 
            /// </summary>
            public Java.Io.FileDescriptor FileDescriptor
            {
                get { return IExecuteWithSignature<Java.Io.FileDescriptor>("getFileDescriptor", "()Ljava/io/FileDescriptor;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecManager.UdpEncapsulationSocket.html#getPort()"/> 
            /// </summary>
            public int Port
            {
                get { return IExecuteWithSignature<int>("getPort", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecManager.UdpEncapsulationSocket.html#close()"/>
            /// </summary>
            /// <exception cref="Java.Io.IOException"/>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
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