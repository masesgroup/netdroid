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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Bluetooth
{
    #region BluetoothHealth
    public partial class BluetoothHealth
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#APP_CONFIG_REGISTRATION_FAILURE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int APP_CONFIG_REGISTRATION_FAILURE { get { if (!_APP_CONFIG_REGISTRATION_FAILUREReady) { _APP_CONFIG_REGISTRATION_FAILUREContent = SGetField<int>(LocalBridgeClazz, "APP_CONFIG_REGISTRATION_FAILURE"); _APP_CONFIG_REGISTRATION_FAILUREReady = true; } return _APP_CONFIG_REGISTRATION_FAILUREContent; } }
        private static int _APP_CONFIG_REGISTRATION_FAILUREContent = default;
        private static bool _APP_CONFIG_REGISTRATION_FAILUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#APP_CONFIG_REGISTRATION_SUCCESS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int APP_CONFIG_REGISTRATION_SUCCESS { get { if (!_APP_CONFIG_REGISTRATION_SUCCESSReady) { _APP_CONFIG_REGISTRATION_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "APP_CONFIG_REGISTRATION_SUCCESS"); _APP_CONFIG_REGISTRATION_SUCCESSReady = true; } return _APP_CONFIG_REGISTRATION_SUCCESSContent; } }
        private static int _APP_CONFIG_REGISTRATION_SUCCESSContent = default;
        private static bool _APP_CONFIG_REGISTRATION_SUCCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#APP_CONFIG_UNREGISTRATION_FAILURE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int APP_CONFIG_UNREGISTRATION_FAILURE { get { if (!_APP_CONFIG_UNREGISTRATION_FAILUREReady) { _APP_CONFIG_UNREGISTRATION_FAILUREContent = SGetField<int>(LocalBridgeClazz, "APP_CONFIG_UNREGISTRATION_FAILURE"); _APP_CONFIG_UNREGISTRATION_FAILUREReady = true; } return _APP_CONFIG_UNREGISTRATION_FAILUREContent; } }
        private static int _APP_CONFIG_UNREGISTRATION_FAILUREContent = default;
        private static bool _APP_CONFIG_UNREGISTRATION_FAILUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#APP_CONFIG_UNREGISTRATION_SUCCESS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int APP_CONFIG_UNREGISTRATION_SUCCESS { get { if (!_APP_CONFIG_UNREGISTRATION_SUCCESSReady) { _APP_CONFIG_UNREGISTRATION_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "APP_CONFIG_UNREGISTRATION_SUCCESS"); _APP_CONFIG_UNREGISTRATION_SUCCESSReady = true; } return _APP_CONFIG_UNREGISTRATION_SUCCESSContent; } }
        private static int _APP_CONFIG_UNREGISTRATION_SUCCESSContent = default;
        private static bool _APP_CONFIG_UNREGISTRATION_SUCCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#CHANNEL_TYPE_RELIABLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int CHANNEL_TYPE_RELIABLE { get { if (!_CHANNEL_TYPE_RELIABLEReady) { _CHANNEL_TYPE_RELIABLEContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_TYPE_RELIABLE"); _CHANNEL_TYPE_RELIABLEReady = true; } return _CHANNEL_TYPE_RELIABLEContent; } }
        private static int _CHANNEL_TYPE_RELIABLEContent = default;
        private static bool _CHANNEL_TYPE_RELIABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#CHANNEL_TYPE_STREAMING"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int CHANNEL_TYPE_STREAMING { get { if (!_CHANNEL_TYPE_STREAMINGReady) { _CHANNEL_TYPE_STREAMINGContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_TYPE_STREAMING"); _CHANNEL_TYPE_STREAMINGReady = true; } return _CHANNEL_TYPE_STREAMINGContent; } }
        private static int _CHANNEL_TYPE_STREAMINGContent = default;
        private static bool _CHANNEL_TYPE_STREAMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#SINK_ROLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SINK_ROLE { get { if (!_SINK_ROLEReady) { _SINK_ROLEContent = SGetField<int>(LocalBridgeClazz, "SINK_ROLE"); _SINK_ROLEReady = true; } return _SINK_ROLEContent; } }
        private static int _SINK_ROLEContent = default;
        private static bool _SINK_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#SOURCE_ROLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SOURCE_ROLE { get { if (!_SOURCE_ROLEReady) { _SOURCE_ROLEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_ROLE"); _SOURCE_ROLEReady = true; } return _SOURCE_ROLEContent; } }
        private static int _SOURCE_ROLEContent = default;
        private static bool _SOURCE_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#STATE_CHANNEL_CONNECTED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATE_CHANNEL_CONNECTED { get { if (!_STATE_CHANNEL_CONNECTEDReady) { _STATE_CHANNEL_CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CHANNEL_CONNECTED"); _STATE_CHANNEL_CONNECTEDReady = true; } return _STATE_CHANNEL_CONNECTEDContent; } }
        private static int _STATE_CHANNEL_CONNECTEDContent = default;
        private static bool _STATE_CHANNEL_CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#STATE_CHANNEL_CONNECTING"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATE_CHANNEL_CONNECTING { get { if (!_STATE_CHANNEL_CONNECTINGReady) { _STATE_CHANNEL_CONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_CHANNEL_CONNECTING"); _STATE_CHANNEL_CONNECTINGReady = true; } return _STATE_CHANNEL_CONNECTINGContent; } }
        private static int _STATE_CHANNEL_CONNECTINGContent = default;
        private static bool _STATE_CHANNEL_CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#STATE_CHANNEL_DISCONNECTED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATE_CHANNEL_DISCONNECTED { get { if (!_STATE_CHANNEL_DISCONNECTEDReady) { _STATE_CHANNEL_DISCONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CHANNEL_DISCONNECTED"); _STATE_CHANNEL_DISCONNECTEDReady = true; } return _STATE_CHANNEL_DISCONNECTEDContent; } }
        private static int _STATE_CHANNEL_DISCONNECTEDContent = default;
        private static bool _STATE_CHANNEL_DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#STATE_CHANNEL_DISCONNECTING"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATE_CHANNEL_DISCONNECTING { get { if (!_STATE_CHANNEL_DISCONNECTINGReady) { _STATE_CHANNEL_DISCONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_CHANNEL_DISCONNECTING"); _STATE_CHANNEL_DISCONNECTINGReady = true; } return _STATE_CHANNEL_DISCONNECTINGContent; } }
        private static int _STATE_CHANNEL_DISCONNECTINGContent = default;
        private static bool _STATE_CHANNEL_DISCONNECTINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#getMainChannelFd(android.bluetooth.BluetoothDevice,android.bluetooth.BluetoothHealthAppConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothHealthAppConfiguration"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        [global::System.Obsolete()]
        public Android.Os.ParcelFileDescriptor GetMainChannelFd(Android.Bluetooth.BluetoothDevice arg0, Android.Bluetooth.BluetoothHealthAppConfiguration arg1)
        {
            return IExecute<Android.Os.ParcelFileDescriptor>("getMainChannelFd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#connectChannelToSource(android.bluetooth.BluetoothDevice,android.bluetooth.BluetoothHealthAppConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothHealthAppConfiguration"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool ConnectChannelToSource(Android.Bluetooth.BluetoothDevice arg0, Android.Bluetooth.BluetoothHealthAppConfiguration arg1)
        {
            return IExecute<bool>("connectChannelToSource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#disconnectChannel(android.bluetooth.BluetoothDevice,android.bluetooth.BluetoothHealthAppConfiguration,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothHealthAppConfiguration"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool DisconnectChannel(Android.Bluetooth.BluetoothDevice arg0, Android.Bluetooth.BluetoothHealthAppConfiguration arg1, int arg2)
        {
            return IExecute<bool>("disconnectChannel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#registerSinkAppConfiguration(java.lang.String,int,android.bluetooth.BluetoothHealthCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Bluetooth.BluetoothHealthCallback"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool RegisterSinkAppConfiguration(Java.Lang.String arg0, int arg1, Android.Bluetooth.BluetoothHealthCallback arg2)
        {
            return IExecute<bool>("registerSinkAppConfiguration", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#unregisterAppConfiguration(android.bluetooth.BluetoothHealthAppConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothHealthAppConfiguration"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool UnregisterAppConfiguration(Android.Bluetooth.BluetoothHealthAppConfiguration arg0)
        {
            return IExecuteWithSignature<bool>("unregisterAppConfiguration", "(Landroid/bluetooth/BluetoothHealthAppConfiguration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#getConnectionState(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#getConnectedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHealth.html#getDevicesMatchingConnectionStates(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}