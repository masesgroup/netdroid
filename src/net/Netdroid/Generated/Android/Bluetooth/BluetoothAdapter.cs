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
    #region BluetoothAdapter
    public partial class BluetoothAdapter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static int _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#SCAN_MODE_CONNECTABLE"/>
        /// </summary>
        public static int SCAN_MODE_CONNECTABLE { get { if (!_SCAN_MODE_CONNECTABLEReady) { _SCAN_MODE_CONNECTABLEContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_CONNECTABLE"); _SCAN_MODE_CONNECTABLEReady = true; } return _SCAN_MODE_CONNECTABLEContent; } }
        private static int _SCAN_MODE_CONNECTABLEContent = default;
        private static bool _SCAN_MODE_CONNECTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#SCAN_MODE_CONNECTABLE_DISCOVERABLE"/>
        /// </summary>
        public static int SCAN_MODE_CONNECTABLE_DISCOVERABLE { get { if (!_SCAN_MODE_CONNECTABLE_DISCOVERABLEReady) { _SCAN_MODE_CONNECTABLE_DISCOVERABLEContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_CONNECTABLE_DISCOVERABLE"); _SCAN_MODE_CONNECTABLE_DISCOVERABLEReady = true; } return _SCAN_MODE_CONNECTABLE_DISCOVERABLEContent; } }
        private static int _SCAN_MODE_CONNECTABLE_DISCOVERABLEContent = default;
        private static bool _SCAN_MODE_CONNECTABLE_DISCOVERABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#SCAN_MODE_NONE"/>
        /// </summary>
        public static int SCAN_MODE_NONE { get { if (!_SCAN_MODE_NONEReady) { _SCAN_MODE_NONEContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_NONE"); _SCAN_MODE_NONEReady = true; } return _SCAN_MODE_NONEContent; } }
        private static int _SCAN_MODE_NONEContent = default;
        private static bool _SCAN_MODE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_CONNECTED"/>
        /// </summary>
        public static int STATE_CONNECTED { get { if (!_STATE_CONNECTEDReady) { _STATE_CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTED"); _STATE_CONNECTEDReady = true; } return _STATE_CONNECTEDContent; } }
        private static int _STATE_CONNECTEDContent = default;
        private static bool _STATE_CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_CONNECTING"/>
        /// </summary>
        public static int STATE_CONNECTING { get { if (!_STATE_CONNECTINGReady) { _STATE_CONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTING"); _STATE_CONNECTINGReady = true; } return _STATE_CONNECTINGContent; } }
        private static int _STATE_CONNECTINGContent = default;
        private static bool _STATE_CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_DISCONNECTED"/>
        /// </summary>
        public static int STATE_DISCONNECTED { get { if (!_STATE_DISCONNECTEDReady) { _STATE_DISCONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_DISCONNECTED"); _STATE_DISCONNECTEDReady = true; } return _STATE_DISCONNECTEDContent; } }
        private static int _STATE_DISCONNECTEDContent = default;
        private static bool _STATE_DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_DISCONNECTING"/>
        /// </summary>
        public static int STATE_DISCONNECTING { get { if (!_STATE_DISCONNECTINGReady) { _STATE_DISCONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_DISCONNECTING"); _STATE_DISCONNECTINGReady = true; } return _STATE_DISCONNECTINGContent; } }
        private static int _STATE_DISCONNECTINGContent = default;
        private static bool _STATE_DISCONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_OFF"/>
        /// </summary>
        public static int STATE_OFF { get { if (!_STATE_OFFReady) { _STATE_OFFContent = SGetField<int>(LocalBridgeClazz, "STATE_OFF"); _STATE_OFFReady = true; } return _STATE_OFFContent; } }
        private static int _STATE_OFFContent = default;
        private static bool _STATE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_ON"/>
        /// </summary>
        public static int STATE_ON { get { if (!_STATE_ONReady) { _STATE_ONContent = SGetField<int>(LocalBridgeClazz, "STATE_ON"); _STATE_ONReady = true; } return _STATE_ONContent; } }
        private static int _STATE_ONContent = default;
        private static bool _STATE_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_TURNING_OFF"/>
        /// </summary>
        public static int STATE_TURNING_OFF { get { if (!_STATE_TURNING_OFFReady) { _STATE_TURNING_OFFContent = SGetField<int>(LocalBridgeClazz, "STATE_TURNING_OFF"); _STATE_TURNING_OFFReady = true; } return _STATE_TURNING_OFFContent; } }
        private static int _STATE_TURNING_OFFContent = default;
        private static bool _STATE_TURNING_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#STATE_TURNING_ON"/>
        /// </summary>
        public static int STATE_TURNING_ON { get { if (!_STATE_TURNING_ONReady) { _STATE_TURNING_ONContent = SGetField<int>(LocalBridgeClazz, "STATE_TURNING_ON"); _STATE_TURNING_ONReady = true; } return _STATE_TURNING_ONContent; } }
        private static int _STATE_TURNING_ONContent = default;
        private static bool _STATE_TURNING_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_CONNECTION_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_CONNECTION_STATE_CHANGED { get { if (!_ACTION_CONNECTION_STATE_CHANGEDReady) { _ACTION_CONNECTION_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CONNECTION_STATE_CHANGED"); _ACTION_CONNECTION_STATE_CHANGEDReady = true; } return _ACTION_CONNECTION_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_CONNECTION_STATE_CHANGEDContent = default;
        private static bool _ACTION_CONNECTION_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_DISCOVERY_FINISHED"/>
        /// </summary>
        public static Java.Lang.String ACTION_DISCOVERY_FINISHED { get { if (!_ACTION_DISCOVERY_FINISHEDReady) { _ACTION_DISCOVERY_FINISHEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DISCOVERY_FINISHED"); _ACTION_DISCOVERY_FINISHEDReady = true; } return _ACTION_DISCOVERY_FINISHEDContent; } }
        private static Java.Lang.String _ACTION_DISCOVERY_FINISHEDContent = default;
        private static bool _ACTION_DISCOVERY_FINISHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_DISCOVERY_STARTED"/>
        /// </summary>
        public static Java.Lang.String ACTION_DISCOVERY_STARTED { get { if (!_ACTION_DISCOVERY_STARTEDReady) { _ACTION_DISCOVERY_STARTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DISCOVERY_STARTED"); _ACTION_DISCOVERY_STARTEDReady = true; } return _ACTION_DISCOVERY_STARTEDContent; } }
        private static Java.Lang.String _ACTION_DISCOVERY_STARTEDContent = default;
        private static bool _ACTION_DISCOVERY_STARTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_LOCAL_NAME_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_LOCAL_NAME_CHANGED { get { if (!_ACTION_LOCAL_NAME_CHANGEDReady) { _ACTION_LOCAL_NAME_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_LOCAL_NAME_CHANGED"); _ACTION_LOCAL_NAME_CHANGEDReady = true; } return _ACTION_LOCAL_NAME_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_LOCAL_NAME_CHANGEDContent = default;
        private static bool _ACTION_LOCAL_NAME_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_REQUEST_DISCOVERABLE"/>
        /// </summary>
        public static Java.Lang.String ACTION_REQUEST_DISCOVERABLE { get { if (!_ACTION_REQUEST_DISCOVERABLEReady) { _ACTION_REQUEST_DISCOVERABLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_REQUEST_DISCOVERABLE"); _ACTION_REQUEST_DISCOVERABLEReady = true; } return _ACTION_REQUEST_DISCOVERABLEContent; } }
        private static Java.Lang.String _ACTION_REQUEST_DISCOVERABLEContent = default;
        private static bool _ACTION_REQUEST_DISCOVERABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_REQUEST_ENABLE"/>
        /// </summary>
        public static Java.Lang.String ACTION_REQUEST_ENABLE { get { if (!_ACTION_REQUEST_ENABLEReady) { _ACTION_REQUEST_ENABLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_REQUEST_ENABLE"); _ACTION_REQUEST_ENABLEReady = true; } return _ACTION_REQUEST_ENABLEContent; } }
        private static Java.Lang.String _ACTION_REQUEST_ENABLEContent = default;
        private static bool _ACTION_REQUEST_ENABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_SCAN_MODE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_SCAN_MODE_CHANGED { get { if (!_ACTION_SCAN_MODE_CHANGEDReady) { _ACTION_SCAN_MODE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SCAN_MODE_CHANGED"); _ACTION_SCAN_MODE_CHANGEDReady = true; } return _ACTION_SCAN_MODE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_SCAN_MODE_CHANGEDContent = default;
        private static bool _ACTION_SCAN_MODE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#ACTION_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_STATE_CHANGED { get { if (!_ACTION_STATE_CHANGEDReady) { _ACTION_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_STATE_CHANGED"); _ACTION_STATE_CHANGEDReady = true; } return _ACTION_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_STATE_CHANGEDContent = default;
        private static bool _ACTION_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_CONNECTION_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CONNECTION_STATE { get { if (!_EXTRA_CONNECTION_STATEReady) { _EXTRA_CONNECTION_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CONNECTION_STATE"); _EXTRA_CONNECTION_STATEReady = true; } return _EXTRA_CONNECTION_STATEContent; } }
        private static Java.Lang.String _EXTRA_CONNECTION_STATEContent = default;
        private static bool _EXTRA_CONNECTION_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_DISCOVERABLE_DURATION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_DISCOVERABLE_DURATION { get { if (!_EXTRA_DISCOVERABLE_DURATIONReady) { _EXTRA_DISCOVERABLE_DURATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DISCOVERABLE_DURATION"); _EXTRA_DISCOVERABLE_DURATIONReady = true; } return _EXTRA_DISCOVERABLE_DURATIONContent; } }
        private static Java.Lang.String _EXTRA_DISCOVERABLE_DURATIONContent = default;
        private static bool _EXTRA_DISCOVERABLE_DURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_LOCAL_NAME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LOCAL_NAME { get { if (!_EXTRA_LOCAL_NAMEReady) { _EXTRA_LOCAL_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LOCAL_NAME"); _EXTRA_LOCAL_NAMEReady = true; } return _EXTRA_LOCAL_NAMEContent; } }
        private static Java.Lang.String _EXTRA_LOCAL_NAMEContent = default;
        private static bool _EXTRA_LOCAL_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_PREVIOUS_CONNECTION_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREVIOUS_CONNECTION_STATE { get { if (!_EXTRA_PREVIOUS_CONNECTION_STATEReady) { _EXTRA_PREVIOUS_CONNECTION_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREVIOUS_CONNECTION_STATE"); _EXTRA_PREVIOUS_CONNECTION_STATEReady = true; } return _EXTRA_PREVIOUS_CONNECTION_STATEContent; } }
        private static Java.Lang.String _EXTRA_PREVIOUS_CONNECTION_STATEContent = default;
        private static bool _EXTRA_PREVIOUS_CONNECTION_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_PREVIOUS_SCAN_MODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREVIOUS_SCAN_MODE { get { if (!_EXTRA_PREVIOUS_SCAN_MODEReady) { _EXTRA_PREVIOUS_SCAN_MODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREVIOUS_SCAN_MODE"); _EXTRA_PREVIOUS_SCAN_MODEReady = true; } return _EXTRA_PREVIOUS_SCAN_MODEContent; } }
        private static Java.Lang.String _EXTRA_PREVIOUS_SCAN_MODEContent = default;
        private static bool _EXTRA_PREVIOUS_SCAN_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_PREVIOUS_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREVIOUS_STATE { get { if (!_EXTRA_PREVIOUS_STATEReady) { _EXTRA_PREVIOUS_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREVIOUS_STATE"); _EXTRA_PREVIOUS_STATEReady = true; } return _EXTRA_PREVIOUS_STATEContent; } }
        private static Java.Lang.String _EXTRA_PREVIOUS_STATEContent = default;
        private static bool _EXTRA_PREVIOUS_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_SCAN_MODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SCAN_MODE { get { if (!_EXTRA_SCAN_MODEReady) { _EXTRA_SCAN_MODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SCAN_MODE"); _EXTRA_SCAN_MODEReady = true; } return _EXTRA_SCAN_MODEContent; } }
        private static Java.Lang.String _EXTRA_SCAN_MODEContent = default;
        private static bool _EXTRA_SCAN_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#EXTRA_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_STATE { get { if (!_EXTRA_STATEReady) { _EXTRA_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_STATE"); _EXTRA_STATEReady = true; } return _EXTRA_STATEContent; } }
        private static Java.Lang.String _EXTRA_STATEContent = default;
        private static bool _EXTRA_STATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#checkBluetoothAddress(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool CheckBluetoothAddress(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "checkBluetoothAddress", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getDefaultAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothAdapter"/></returns>
        [global::System.Obsolete()]
        public static Android.Bluetooth.BluetoothAdapter GetDefaultAdapter()
        {
            return SExecuteWithSignature<Android.Bluetooth.BluetoothAdapter>(LocalBridgeClazz, "getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getRemoteDevice(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothDevice"/></returns>
        public Android.Bluetooth.BluetoothDevice GetRemoteDevice(byte[] arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothDevice>("getRemoteDevice", "([B)Landroid/bluetooth/BluetoothDevice;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getRemoteDevice(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothDevice"/></returns>
        public Android.Bluetooth.BluetoothDevice GetRemoteDevice(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothDevice>("getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getRemoteLeDevice(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothDevice"/></returns>
        public Android.Bluetooth.BluetoothDevice GetRemoteLeDevice(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Android.Bluetooth.BluetoothDevice>("getRemoteLeDevice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#listenUsingInsecureL2capChannel()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Bluetooth.BluetoothServerSocket ListenUsingInsecureL2capChannel()
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothServerSocket>("listenUsingInsecureL2capChannel", "()Landroid/bluetooth/BluetoothServerSocket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#listenUsingInsecureRfcommWithServiceRecord(java.lang.String,java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Bluetooth.BluetoothServerSocket ListenUsingInsecureRfcommWithServiceRecord(Java.Lang.String arg0, Java.Util.UUID arg1)
        {
            return IExecute<Android.Bluetooth.BluetoothServerSocket>("listenUsingInsecureRfcommWithServiceRecord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#listenUsingL2capChannel()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Bluetooth.BluetoothServerSocket ListenUsingL2capChannel()
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothServerSocket>("listenUsingL2capChannel", "()Landroid/bluetooth/BluetoothServerSocket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#listenUsingRfcommWithServiceRecord(java.lang.String,java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Bluetooth.BluetoothServerSocket ListenUsingRfcommWithServiceRecord(Java.Lang.String arg0, Java.Util.UUID arg1)
        {
            return IExecute<Android.Bluetooth.BluetoothServerSocket>("listenUsingRfcommWithServiceRecord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getBluetoothLeAdvertiser()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.Le.BluetoothLeAdvertiser"/></returns>
        public Android.Bluetooth.Le.BluetoothLeAdvertiser GetBluetoothLeAdvertiser()
        {
            return IExecuteWithSignature<Android.Bluetooth.Le.BluetoothLeAdvertiser>("getBluetoothLeAdvertiser", "()Landroid/bluetooth/le/BluetoothLeAdvertiser;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getBluetoothLeScanner()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.Le.BluetoothLeScanner"/></returns>
        public Android.Bluetooth.Le.BluetoothLeScanner GetBluetoothLeScanner()
        {
            return IExecuteWithSignature<Android.Bluetooth.Le.BluetoothLeScanner>("getBluetoothLeScanner", "()Landroid/bluetooth/le/BluetoothLeScanner;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#cancelDiscovery()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CancelDiscovery()
        {
            return IExecuteWithSignature<bool>("cancelDiscovery", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#disable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Disable()
        {
            return IExecuteWithSignature<bool>("disable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#enable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Enable()
        {
            return IExecuteWithSignature<bool>("enable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getProfileProxy(android.content.Context,android.bluetooth.BluetoothProfile.ServiceListener,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothProfile.ServiceListener"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetProfileProxy(Android.Content.Context arg0, Android.Bluetooth.BluetoothProfile.ServiceListener arg1, int arg2)
        {
            return IExecute<bool>("getProfileProxy", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isDiscovering()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDiscovering()
        {
            return IExecuteWithSignature<bool>("isDiscovering", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLe2MPhySupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLe2MPhySupported()
        {
            return IExecuteWithSignature<bool>("isLe2MPhySupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLeCodedPhySupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeCodedPhySupported()
        {
            return IExecuteWithSignature<bool>("isLeCodedPhySupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLeExtendedAdvertisingSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeExtendedAdvertisingSupported()
        {
            return IExecuteWithSignature<bool>("isLeExtendedAdvertisingSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLePeriodicAdvertisingSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLePeriodicAdvertisingSupported()
        {
            return IExecuteWithSignature<bool>("isLePeriodicAdvertisingSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isMultipleAdvertisementSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMultipleAdvertisementSupported()
        {
            return IExecuteWithSignature<bool>("isMultipleAdvertisementSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isOffloadedFilteringSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOffloadedFilteringSupported()
        {
            return IExecuteWithSignature<bool>("isOffloadedFilteringSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isOffloadedScanBatchingSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOffloadedScanBatchingSupported()
        {
            return IExecuteWithSignature<bool>("isOffloadedScanBatchingSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#setName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("setName", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#startDiscovery()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool StartDiscovery()
        {
            return IExecuteWithSignature<bool>("startDiscovery", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#startLeScan(android.bluetooth.BluetoothAdapter.LeScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothAdapter.LeScanCallback"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool StartLeScan(Android.Bluetooth.BluetoothAdapter.LeScanCallback arg0)
        {
            return IExecuteWithSignature<bool>("startLeScan", "(Landroid/bluetooth/BluetoothAdapter$LeScanCallback;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#startLeScan(java.util.UUID[],android.bluetooth.BluetoothAdapter.LeScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothAdapter.LeScanCallback"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool StartLeScan(Java.Util.UUID[] arg0, Android.Bluetooth.BluetoothAdapter.LeScanCallback arg1)
        {
            return IExecute<bool>("startLeScan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getLeMaximumAdvertisingDataLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLeMaximumAdvertisingDataLength()
        {
            return IExecuteWithSignature<int>("getLeMaximumAdvertisingDataLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getMaxConnectedAudioDevices()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxConnectedAudioDevices()
        {
            return IExecuteWithSignature<int>("getMaxConnectedAudioDevices", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getProfileConnectionState(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetProfileConnectionState(int arg0)
        {
            return IExecuteWithSignature<int>("getProfileConnectionState", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getScanMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScanMode()
        {
            return IExecuteWithSignature<int>("getScanMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLeAudioBroadcastAssistantSupported()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IsLeAudioBroadcastAssistantSupported()
        {
            return IExecuteWithSignature<int>("isLeAudioBroadcastAssistantSupported", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLeAudioBroadcastSourceSupported()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IsLeAudioBroadcastSourceSupported()
        {
            return IExecuteWithSignature<int>("isLeAudioBroadcastSourceSupported", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#isLeAudioSupported()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IsLeAudioSupported()
        {
            return IExecuteWithSignature<int>("isLeAudioSupported", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getDiscoverableTimeout()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GetDiscoverableTimeout()
        {
            return IExecuteWithSignature<Java.Time.Duration>("getDiscoverableTimeout", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#getBondedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Bluetooth.BluetoothDevice> GetBondedDevices()
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Bluetooth.BluetoothDevice>>("getBondedDevices", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#closeProfileProxy(int,android.bluetooth.BluetoothProfile)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothProfile"/></param>
        public void CloseProfileProxy(int arg0, Android.Bluetooth.BluetoothProfile arg1)
        {
            IExecute("closeProfileProxy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.html#stopLeScan(android.bluetooth.BluetoothAdapter.LeScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothAdapter.LeScanCallback"/></param>
        [global::System.Obsolete()]
        public void StopLeScan(Android.Bluetooth.BluetoothAdapter.LeScanCallback arg0)
        {
            IExecuteWithSignature("stopLeScan", "(Landroid/bluetooth/BluetoothAdapter$LeScanCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region LeScanCallback
        public partial class LeScanCallback
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothAdapter.LeScanCallback.html#onLeScan(android.bluetooth.BluetoothDevice,int,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            public void OnLeScan(Android.Bluetooth.BluetoothDevice arg0, int arg1, byte[] arg2)
            {
                IExecute("onLeScan", arg0, arg1, arg2);
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