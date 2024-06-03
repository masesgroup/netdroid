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
    #region BluetoothHeadset
    public partial class BluetoothHeadset
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#AT_CMD_TYPE_ACTION"/>
        /// </summary>
        public static int AT_CMD_TYPE_ACTION { get { if (!_AT_CMD_TYPE_ACTIONReady) { _AT_CMD_TYPE_ACTIONContent = SGetField<int>(LocalBridgeClazz, "AT_CMD_TYPE_ACTION"); _AT_CMD_TYPE_ACTIONReady = true; } return _AT_CMD_TYPE_ACTIONContent; } }
        private static int _AT_CMD_TYPE_ACTIONContent = default;
        private static bool _AT_CMD_TYPE_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#AT_CMD_TYPE_BASIC"/>
        /// </summary>
        public static int AT_CMD_TYPE_BASIC { get { if (!_AT_CMD_TYPE_BASICReady) { _AT_CMD_TYPE_BASICContent = SGetField<int>(LocalBridgeClazz, "AT_CMD_TYPE_BASIC"); _AT_CMD_TYPE_BASICReady = true; } return _AT_CMD_TYPE_BASICContent; } }
        private static int _AT_CMD_TYPE_BASICContent = default;
        private static bool _AT_CMD_TYPE_BASICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#AT_CMD_TYPE_READ"/>
        /// </summary>
        public static int AT_CMD_TYPE_READ { get { if (!_AT_CMD_TYPE_READReady) { _AT_CMD_TYPE_READContent = SGetField<int>(LocalBridgeClazz, "AT_CMD_TYPE_READ"); _AT_CMD_TYPE_READReady = true; } return _AT_CMD_TYPE_READContent; } }
        private static int _AT_CMD_TYPE_READContent = default;
        private static bool _AT_CMD_TYPE_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#AT_CMD_TYPE_SET"/>
        /// </summary>
        public static int AT_CMD_TYPE_SET { get { if (!_AT_CMD_TYPE_SETReady) { _AT_CMD_TYPE_SETContent = SGetField<int>(LocalBridgeClazz, "AT_CMD_TYPE_SET"); _AT_CMD_TYPE_SETReady = true; } return _AT_CMD_TYPE_SETContent; } }
        private static int _AT_CMD_TYPE_SETContent = default;
        private static bool _AT_CMD_TYPE_SETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#AT_CMD_TYPE_TEST"/>
        /// </summary>
        public static int AT_CMD_TYPE_TEST { get { if (!_AT_CMD_TYPE_TESTReady) { _AT_CMD_TYPE_TESTContent = SGetField<int>(LocalBridgeClazz, "AT_CMD_TYPE_TEST"); _AT_CMD_TYPE_TESTReady = true; } return _AT_CMD_TYPE_TESTContent; } }
        private static int _AT_CMD_TYPE_TESTContent = default;
        private static bool _AT_CMD_TYPE_TESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#STATE_AUDIO_CONNECTED"/>
        /// </summary>
        public static int STATE_AUDIO_CONNECTED { get { if (!_STATE_AUDIO_CONNECTEDReady) { _STATE_AUDIO_CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_AUDIO_CONNECTED"); _STATE_AUDIO_CONNECTEDReady = true; } return _STATE_AUDIO_CONNECTEDContent; } }
        private static int _STATE_AUDIO_CONNECTEDContent = default;
        private static bool _STATE_AUDIO_CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#STATE_AUDIO_CONNECTING"/>
        /// </summary>
        public static int STATE_AUDIO_CONNECTING { get { if (!_STATE_AUDIO_CONNECTINGReady) { _STATE_AUDIO_CONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_AUDIO_CONNECTING"); _STATE_AUDIO_CONNECTINGReady = true; } return _STATE_AUDIO_CONNECTINGContent; } }
        private static int _STATE_AUDIO_CONNECTINGContent = default;
        private static bool _STATE_AUDIO_CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#STATE_AUDIO_DISCONNECTED"/>
        /// </summary>
        public static int STATE_AUDIO_DISCONNECTED { get { if (!_STATE_AUDIO_DISCONNECTEDReady) { _STATE_AUDIO_DISCONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_AUDIO_DISCONNECTED"); _STATE_AUDIO_DISCONNECTEDReady = true; } return _STATE_AUDIO_DISCONNECTEDContent; } }
        private static int _STATE_AUDIO_DISCONNECTEDContent = default;
        private static bool _STATE_AUDIO_DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#ACTION_AUDIO_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_AUDIO_STATE_CHANGED { get { if (!_ACTION_AUDIO_STATE_CHANGEDReady) { _ACTION_AUDIO_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_AUDIO_STATE_CHANGED"); _ACTION_AUDIO_STATE_CHANGEDReady = true; } return _ACTION_AUDIO_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_AUDIO_STATE_CHANGEDContent = default;
        private static bool _ACTION_AUDIO_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#ACTION_CONNECTION_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_CONNECTION_STATE_CHANGED { get { if (!_ACTION_CONNECTION_STATE_CHANGEDReady) { _ACTION_CONNECTION_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CONNECTION_STATE_CHANGED"); _ACTION_CONNECTION_STATE_CHANGEDReady = true; } return _ACTION_CONNECTION_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_CONNECTION_STATE_CHANGEDContent = default;
        private static bool _ACTION_CONNECTION_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#ACTION_VENDOR_SPECIFIC_HEADSET_EVENT"/>
        /// </summary>
        public static Java.Lang.String ACTION_VENDOR_SPECIFIC_HEADSET_EVENT { get { if (!_ACTION_VENDOR_SPECIFIC_HEADSET_EVENTReady) { _ACTION_VENDOR_SPECIFIC_HEADSET_EVENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_VENDOR_SPECIFIC_HEADSET_EVENT"); _ACTION_VENDOR_SPECIFIC_HEADSET_EVENTReady = true; } return _ACTION_VENDOR_SPECIFIC_HEADSET_EVENTContent; } }
        private static Java.Lang.String _ACTION_VENDOR_SPECIFIC_HEADSET_EVENTContent = default;
        private static bool _ACTION_VENDOR_SPECIFIC_HEADSET_EVENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS { get { if (!_EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGSReady) { _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS"); _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGSReady = true; } return _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGSContent; } }
        private static Java.Lang.String _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGSContent = default;
        private static bool _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD { get { if (!_EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMDReady) { _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD"); _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMDReady = true; } return _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMDContent; } }
        private static Java.Lang.String _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMDContent = default;
        private static bool _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE { get { if (!_EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPEReady) { _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE"); _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPEReady = true; } return _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPEContent; } }
        private static Java.Lang.String _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPEContent = default;
        private static bool _EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#VENDOR_RESULT_CODE_COMMAND_ANDROID"/>
        /// </summary>
        public static Java.Lang.String VENDOR_RESULT_CODE_COMMAND_ANDROID { get { if (!_VENDOR_RESULT_CODE_COMMAND_ANDROIDReady) { _VENDOR_RESULT_CODE_COMMAND_ANDROIDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VENDOR_RESULT_CODE_COMMAND_ANDROID"); _VENDOR_RESULT_CODE_COMMAND_ANDROIDReady = true; } return _VENDOR_RESULT_CODE_COMMAND_ANDROIDContent; } }
        private static Java.Lang.String _VENDOR_RESULT_CODE_COMMAND_ANDROIDContent = default;
        private static bool _VENDOR_RESULT_CODE_COMMAND_ANDROIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY"/>
        /// </summary>
        public static Java.Lang.String VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY { get { if (!_VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORYReady) { _VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY"); _VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORYReady = true; } return _VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORYContent; } }
        private static Java.Lang.String _VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORYContent = default;
        private static bool _VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#isAudioConnected(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAudioConnected(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<bool>("isAudioConnected", "(Landroid/bluetooth/BluetoothDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#isNoiseReductionSupported(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNoiseReductionSupported(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<bool>("isNoiseReductionSupported", "(Landroid/bluetooth/BluetoothDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#isVoiceRecognitionSupported(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoiceRecognitionSupported(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<bool>("isVoiceRecognitionSupported", "(Landroid/bluetooth/BluetoothDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#sendVendorSpecificResultCode(android.bluetooth.BluetoothDevice,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendVendorSpecificResultCode(Android.Bluetooth.BluetoothDevice arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<bool>("sendVendorSpecificResultCode", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#startVoiceRecognition(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartVoiceRecognition(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<bool>("startVoiceRecognition", "(Landroid/bluetooth/BluetoothDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#stopVoiceRecognition(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StopVoiceRecognition(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<bool>("stopVoiceRecognition", "(Landroid/bluetooth/BluetoothDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#getConnectionState(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#getConnectedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothHeadset.html#getDevicesMatchingConnectionStates(int[])"/>
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