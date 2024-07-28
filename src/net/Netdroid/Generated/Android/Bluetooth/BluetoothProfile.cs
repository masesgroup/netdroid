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
    #region IBluetoothProfile
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBluetoothProfile
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BluetoothProfile
    public partial class BluetoothProfile : Android.Bluetooth.IBluetoothProfile
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#A2DP"/>
        /// </summary>
        public static int A2DP { get { if (!_A2DPReady) { _A2DPContent = SGetField<int>(LocalBridgeClazz, "A2DP"); _A2DPReady = true; } return _A2DPContent; } }
        private static int _A2DPContent = default;
        private static bool _A2DPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#CSIP_SET_COORDINATOR"/>
        /// </summary>
        public static int CSIP_SET_COORDINATOR { get { if (!_CSIP_SET_COORDINATORReady) { _CSIP_SET_COORDINATORContent = SGetField<int>(LocalBridgeClazz, "CSIP_SET_COORDINATOR"); _CSIP_SET_COORDINATORReady = true; } return _CSIP_SET_COORDINATORContent; } }
        private static int _CSIP_SET_COORDINATORContent = default;
        private static bool _CSIP_SET_COORDINATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#GATT"/>
        /// </summary>
        public static int GATT { get { if (!_GATTReady) { _GATTContent = SGetField<int>(LocalBridgeClazz, "GATT"); _GATTReady = true; } return _GATTContent; } }
        private static int _GATTContent = default;
        private static bool _GATTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#GATT_SERVER"/>
        /// </summary>
        public static int GATT_SERVER { get { if (!_GATT_SERVERReady) { _GATT_SERVERContent = SGetField<int>(LocalBridgeClazz, "GATT_SERVER"); _GATT_SERVERReady = true; } return _GATT_SERVERContent; } }
        private static int _GATT_SERVERContent = default;
        private static bool _GATT_SERVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#HAP_CLIENT"/>
        /// </summary>
        public static int HAP_CLIENT { get { if (!_HAP_CLIENTReady) { _HAP_CLIENTContent = SGetField<int>(LocalBridgeClazz, "HAP_CLIENT"); _HAP_CLIENTReady = true; } return _HAP_CLIENTContent; } }
        private static int _HAP_CLIENTContent = default;
        private static bool _HAP_CLIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#HEADSET"/>
        /// </summary>
        public static int HEADSET { get { if (!_HEADSETReady) { _HEADSETContent = SGetField<int>(LocalBridgeClazz, "HEADSET"); _HEADSETReady = true; } return _HEADSETContent; } }
        private static int _HEADSETContent = default;
        private static bool _HEADSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#HEALTH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int HEALTH { get { if (!_HEALTHReady) { _HEALTHContent = SGetField<int>(LocalBridgeClazz, "HEALTH"); _HEALTHReady = true; } return _HEALTHContent; } }
        private static int _HEALTHContent = default;
        private static bool _HEALTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#HEARING_AID"/>
        /// </summary>
        public static int HEARING_AID { get { if (!_HEARING_AIDReady) { _HEARING_AIDContent = SGetField<int>(LocalBridgeClazz, "HEARING_AID"); _HEARING_AIDReady = true; } return _HEARING_AIDContent; } }
        private static int _HEARING_AIDContent = default;
        private static bool _HEARING_AIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#HID_DEVICE"/>
        /// </summary>
        public static int HID_DEVICE { get { if (!_HID_DEVICEReady) { _HID_DEVICEContent = SGetField<int>(LocalBridgeClazz, "HID_DEVICE"); _HID_DEVICEReady = true; } return _HID_DEVICEContent; } }
        private static int _HID_DEVICEContent = default;
        private static bool _HID_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#LE_AUDIO"/>
        /// </summary>
        public static int LE_AUDIO { get { if (!_LE_AUDIOReady) { _LE_AUDIOContent = SGetField<int>(LocalBridgeClazz, "LE_AUDIO"); _LE_AUDIOReady = true; } return _LE_AUDIOContent; } }
        private static int _LE_AUDIOContent = default;
        private static bool _LE_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#SAP"/>
        /// </summary>
        public static int SAP { get { if (!_SAPReady) { _SAPContent = SGetField<int>(LocalBridgeClazz, "SAP"); _SAPReady = true; } return _SAPContent; } }
        private static int _SAPContent = default;
        private static bool _SAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#STATE_CONNECTED"/>
        /// </summary>
        public static int STATE_CONNECTED { get { if (!_STATE_CONNECTEDReady) { _STATE_CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTED"); _STATE_CONNECTEDReady = true; } return _STATE_CONNECTEDContent; } }
        private static int _STATE_CONNECTEDContent = default;
        private static bool _STATE_CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#STATE_CONNECTING"/>
        /// </summary>
        public static int STATE_CONNECTING { get { if (!_STATE_CONNECTINGReady) { _STATE_CONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTING"); _STATE_CONNECTINGReady = true; } return _STATE_CONNECTINGContent; } }
        private static int _STATE_CONNECTINGContent = default;
        private static bool _STATE_CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#STATE_DISCONNECTED"/>
        /// </summary>
        public static int STATE_DISCONNECTED { get { if (!_STATE_DISCONNECTEDReady) { _STATE_DISCONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_DISCONNECTED"); _STATE_DISCONNECTEDReady = true; } return _STATE_DISCONNECTEDContent; } }
        private static int _STATE_DISCONNECTEDContent = default;
        private static bool _STATE_DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#STATE_DISCONNECTING"/>
        /// </summary>
        public static int STATE_DISCONNECTING { get { if (!_STATE_DISCONNECTINGReady) { _STATE_DISCONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_DISCONNECTING"); _STATE_DISCONNECTINGReady = true; } return _STATE_DISCONNECTINGContent; } }
        private static int _STATE_DISCONNECTINGContent = default;
        private static bool _STATE_DISCONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#EXTRA_PREVIOUS_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREVIOUS_STATE { get { if (!_EXTRA_PREVIOUS_STATEReady) { _EXTRA_PREVIOUS_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREVIOUS_STATE"); _EXTRA_PREVIOUS_STATEReady = true; } return _EXTRA_PREVIOUS_STATEContent; } }
        private static Java.Lang.String _EXTRA_PREVIOUS_STATEContent = default;
        private static bool _EXTRA_PREVIOUS_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#EXTRA_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_STATE { get { if (!_EXTRA_STATEReady) { _EXTRA_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_STATE"); _EXTRA_STATEReady = true; } return _EXTRA_STATEContent; } }
        private static Java.Lang.String _EXTRA_STATEContent = default;
        private static bool _EXTRA_STATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#getConnectionState(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#getConnectedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.html#getDevicesMatchingConnectionStates(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes
        #region ServiceListener
        public partial class ServiceListener
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
            /// Handlers initializer for <see cref="ServiceListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onServiceConnected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnServiceConnectedEventHandler));
                AddEventHandler("onServiceDisconnected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnServiceDisconnectedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.ServiceListener.html#onServiceConnected(int,android.bluetooth.BluetoothProfile)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnServiceConnected"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int, Android.Bluetooth.BluetoothProfile> OnOnServiceConnected { get; set; } = null;

            void OnServiceConnectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnServiceConnected != null) ? OnOnServiceConnected : OnServiceConnected;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Bluetooth.BluetoothProfile>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.ServiceListener.html#onServiceConnected(int,android.bluetooth.BluetoothProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothProfile"/></param>
            public virtual void OnServiceConnected(int arg0, Android.Bluetooth.BluetoothProfile arg1)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.ServiceListener.html#onServiceDisconnected(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnServiceDisconnected"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnServiceDisconnected { get; set; } = null;

            void OnServiceDisconnectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnServiceDisconnected != null) ? OnOnServiceDisconnected : OnServiceDisconnected;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.ServiceListener.html#onServiceDisconnected(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnServiceDisconnected(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ServiceListenerDirect
        public partial class ServiceListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.ServiceListener.html#onServiceConnected(int,android.bluetooth.BluetoothProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothProfile"/></param>
            public override void OnServiceConnected(int arg0, Android.Bluetooth.BluetoothProfile arg1)
            {
                IExecute("onServiceConnected", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothProfile.ServiceListener.html#onServiceDisconnected(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnServiceDisconnected(int arg0)
            {
                IExecuteWithSignature("onServiceDisconnected", "(I)V", arg0);
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