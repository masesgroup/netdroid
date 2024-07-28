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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Bluetooth
{
    #region BluetoothSocket
    public partial class BluetoothSocket
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#TYPE_L2CAP"/>
        /// </summary>
        public static int TYPE_L2CAP { get { if (!_TYPE_L2CAPReady) { _TYPE_L2CAPContent = SGetField<int>(LocalBridgeClazz, "TYPE_L2CAP"); _TYPE_L2CAPReady = true; } return _TYPE_L2CAPContent; } }
        private static int _TYPE_L2CAPContent = default;
        private static bool _TYPE_L2CAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#TYPE_RFCOMM"/>
        /// </summary>
        public static int TYPE_RFCOMM { get { if (!_TYPE_RFCOMMReady) { _TYPE_RFCOMMContent = SGetField<int>(LocalBridgeClazz, "TYPE_RFCOMM"); _TYPE_RFCOMMReady = true; } return _TYPE_RFCOMMContent; } }
        private static int _TYPE_RFCOMMContent = default;
        private static bool _TYPE_RFCOMMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#TYPE_SCO"/>
        /// </summary>
        public static int TYPE_SCO { get { if (!_TYPE_SCOReady) { _TYPE_SCOContent = SGetField<int>(LocalBridgeClazz, "TYPE_SCO"); _TYPE_SCOReady = true; } return _TYPE_SCOContent; } }
        private static int _TYPE_SCOContent = default;
        private static bool _TYPE_SCOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#getRemoteDevice()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothDevice"/></returns>
        public Android.Bluetooth.BluetoothDevice GetRemoteDevice()
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothDevice>("getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#getConnectionType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionType()
        {
            return IExecuteWithSignature<int>("getConnectionType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#getMaxReceivePacketSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxReceivePacketSize()
        {
            return IExecuteWithSignature<int>("getMaxReceivePacketSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#getMaxTransmitPacketSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxTransmitPacketSize()
        {
            return IExecuteWithSignature<int>("getMaxTransmitPacketSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#getInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#getOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream GetOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothSocket.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}