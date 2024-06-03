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

namespace Android.Bluetooth
{
    #region BluetoothA2dp
    public partial class BluetoothA2dp
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#STATE_NOT_PLAYING"/>
        /// </summary>
        public static int STATE_NOT_PLAYING { get { if (!_STATE_NOT_PLAYINGReady) { _STATE_NOT_PLAYINGContent = SGetField<int>(LocalBridgeClazz, "STATE_NOT_PLAYING"); _STATE_NOT_PLAYINGReady = true; } return _STATE_NOT_PLAYINGContent; } }
        private static int _STATE_NOT_PLAYINGContent = default;
        private static bool _STATE_NOT_PLAYINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#STATE_PLAYING"/>
        /// </summary>
        public static int STATE_PLAYING { get { if (!_STATE_PLAYINGReady) { _STATE_PLAYINGContent = SGetField<int>(LocalBridgeClazz, "STATE_PLAYING"); _STATE_PLAYINGReady = true; } return _STATE_PLAYINGContent; } }
        private static int _STATE_PLAYINGContent = default;
        private static bool _STATE_PLAYINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#ACTION_CONNECTION_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_CONNECTION_STATE_CHANGED { get { if (!_ACTION_CONNECTION_STATE_CHANGEDReady) { _ACTION_CONNECTION_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CONNECTION_STATE_CHANGED"); _ACTION_CONNECTION_STATE_CHANGEDReady = true; } return _ACTION_CONNECTION_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_CONNECTION_STATE_CHANGEDContent = default;
        private static bool _ACTION_CONNECTION_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#ACTION_PLAYING_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_PLAYING_STATE_CHANGED { get { if (!_ACTION_PLAYING_STATE_CHANGEDReady) { _ACTION_PLAYING_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_PLAYING_STATE_CHANGED"); _ACTION_PLAYING_STATE_CHANGEDReady = true; } return _ACTION_PLAYING_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_PLAYING_STATE_CHANGEDContent = default;
        private static bool _ACTION_PLAYING_STATE_CHANGEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#isA2dpPlaying(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsA2dpPlaying(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<bool>("isA2dpPlaying", "(Landroid/bluetooth/BluetoothDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#getConnectionState(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#getConnectedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothA2dp.html#getDevicesMatchingConnectionStates(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
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