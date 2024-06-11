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

namespace Android.Net.Wifi.Rtt
{
    #region WifiRttManager
    public partial class WifiRttManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#ACTION_WIFI_RTT_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_WIFI_RTT_STATE_CHANGED { get { if (!_ACTION_WIFI_RTT_STATE_CHANGEDReady) { _ACTION_WIFI_RTT_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_WIFI_RTT_STATE_CHANGED"); _ACTION_WIFI_RTT_STATE_CHANGEDReady = true; } return _ACTION_WIFI_RTT_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_WIFI_RTT_STATE_CHANGEDContent = default;
        private static bool _ACTION_WIFI_RTT_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#CHARACTERISTICS_KEY_BOOLEAN_LCI"/>
        /// </summary>
        public static Java.Lang.String CHARACTERISTICS_KEY_BOOLEAN_LCI { get { if (!_CHARACTERISTICS_KEY_BOOLEAN_LCIReady) { _CHARACTERISTICS_KEY_BOOLEAN_LCIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHARACTERISTICS_KEY_BOOLEAN_LCI"); _CHARACTERISTICS_KEY_BOOLEAN_LCIReady = true; } return _CHARACTERISTICS_KEY_BOOLEAN_LCIContent; } }
        private static Java.Lang.String _CHARACTERISTICS_KEY_BOOLEAN_LCIContent = default;
        private static bool _CHARACTERISTICS_KEY_BOOLEAN_LCIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#CHARACTERISTICS_KEY_BOOLEAN_LCR"/>
        /// </summary>
        public static Java.Lang.String CHARACTERISTICS_KEY_BOOLEAN_LCR { get { if (!_CHARACTERISTICS_KEY_BOOLEAN_LCRReady) { _CHARACTERISTICS_KEY_BOOLEAN_LCRContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHARACTERISTICS_KEY_BOOLEAN_LCR"); _CHARACTERISTICS_KEY_BOOLEAN_LCRReady = true; } return _CHARACTERISTICS_KEY_BOOLEAN_LCRContent; } }
        private static Java.Lang.String _CHARACTERISTICS_KEY_BOOLEAN_LCRContent = default;
        private static bool _CHARACTERISTICS_KEY_BOOLEAN_LCRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTT"/>
        /// </summary>
        public static Java.Lang.String CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTT { get { if (!_CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTTReady) { _CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTT"); _CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTTReady = true; } return _CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTTContent; } }
        private static Java.Lang.String _CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTTContent = default;
        private static bool _CHARACTERISTICS_KEY_BOOLEAN_ONE_SIDED_RTTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDER"/>
        /// </summary>
        public static Java.Lang.String CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDER { get { if (!_CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDERReady) { _CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDER"); _CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDERReady = true; } return _CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDERContent; } }
        private static Java.Lang.String _CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDERContent = default;
        private static bool _CHARACTERISTICS_KEY_BOOLEAN_STA_RESPONDERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#getRttCharacteristics()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetRttCharacteristics()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getRttCharacteristics", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#isAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAvailable()
        {
            return IExecuteWithSignature<bool>("isAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/WifiRttManager.html#startRanging(android.net.wifi.rtt.RangingRequest,java.util.concurrent.Executor,android.net.wifi.rtt.RangingResultCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Rtt.RangingRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Net.Wifi.Rtt.RangingResultCallback"/></param>
        public void StartRanging(Android.Net.Wifi.Rtt.RangingRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Net.Wifi.Rtt.RangingResultCallback arg2)
        {
            IExecute("startRanging", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}