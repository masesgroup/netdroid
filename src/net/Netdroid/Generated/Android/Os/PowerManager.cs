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

namespace Android.Os
{
    #region PowerManager
    public partial class PowerManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFF"/>
        /// </summary>
        public static int LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFF { get { if (!_LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFFReady) { _LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFFContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFF"); _LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFFReady = true; } return _LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFFContent; } }
        private static int _LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFFContent = default;
        private static bool _LOCATION_MODE_ALL_DISABLED_WHEN_SCREEN_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOCATION_MODE_FOREGROUND_ONLY"/>
        /// </summary>
        public static int LOCATION_MODE_FOREGROUND_ONLY { get { if (!_LOCATION_MODE_FOREGROUND_ONLYReady) { _LOCATION_MODE_FOREGROUND_ONLYContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MODE_FOREGROUND_ONLY"); _LOCATION_MODE_FOREGROUND_ONLYReady = true; } return _LOCATION_MODE_FOREGROUND_ONLYContent; } }
        private static int _LOCATION_MODE_FOREGROUND_ONLYContent = default;
        private static bool _LOCATION_MODE_FOREGROUND_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFF"/>
        /// </summary>
        public static int LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFF { get { if (!_LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFFReady) { _LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFFContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFF"); _LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFFReady = true; } return _LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFFContent; } }
        private static int _LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFFContent = default;
        private static bool _LOCATION_MODE_GPS_DISABLED_WHEN_SCREEN_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOCATION_MODE_NO_CHANGE"/>
        /// </summary>
        public static int LOCATION_MODE_NO_CHANGE { get { if (!_LOCATION_MODE_NO_CHANGEReady) { _LOCATION_MODE_NO_CHANGEContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MODE_NO_CHANGE"); _LOCATION_MODE_NO_CHANGEReady = true; } return _LOCATION_MODE_NO_CHANGEContent; } }
        private static int _LOCATION_MODE_NO_CHANGEContent = default;
        private static bool _LOCATION_MODE_NO_CHANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFF"/>
        /// </summary>
        public static int LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFF { get { if (!_LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFFReady) { _LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFFContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFF"); _LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFFReady = true; } return _LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFFContent; } }
        private static int _LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFFContent = default;
        private static bool _LOCATION_MODE_THROTTLE_REQUESTS_WHEN_SCREEN_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALL"/>
        /// </summary>
        public static int LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALL { get { if (!_LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALLReady) { _LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALLContent = SGetField<int>(LocalBridgeClazz, "LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALL"); _LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALLReady = true; } return _LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALLContent; } }
        private static int _LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALLContent = default;
        private static bool _LOW_POWER_STANDBY_ALLOWED_REASON_ONGOING_CALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLIST"/>
        /// </summary>
        public static int LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLIST { get { if (!_LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLISTReady) { _LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLISTContent = SGetField<int>(LocalBridgeClazz, "LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLIST"); _LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLISTReady = true; } return _LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLISTContent; } }
        private static int _LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLISTContent = default;
        private static bool _LOW_POWER_STANDBY_ALLOWED_REASON_TEMP_POWER_SAVE_ALLOWLISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTION"/>
        /// </summary>
        public static int LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTION { get { if (!_LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTIONReady) { _LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTIONContent = SGetField<int>(LocalBridgeClazz, "LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTION"); _LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTIONReady = true; } return _LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTIONContent; } }
        private static int _LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTIONContent = default;
        private static bool _LOW_POWER_STANDBY_ALLOWED_REASON_VOICE_INTERACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#ON_AFTER_RELEASE"/>
        /// </summary>
        public static int ON_AFTER_RELEASE { get { if (!_ON_AFTER_RELEASEReady) { _ON_AFTER_RELEASEContent = SGetField<int>(LocalBridgeClazz, "ON_AFTER_RELEASE"); _ON_AFTER_RELEASEReady = true; } return _ON_AFTER_RELEASEContent; } }
        private static int _ON_AFTER_RELEASEContent = default;
        private static bool _ON_AFTER_RELEASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#PARTIAL_WAKE_LOCK"/>
        /// </summary>
        public static int PARTIAL_WAKE_LOCK { get { if (!_PARTIAL_WAKE_LOCKReady) { _PARTIAL_WAKE_LOCKContent = SGetField<int>(LocalBridgeClazz, "PARTIAL_WAKE_LOCK"); _PARTIAL_WAKE_LOCKReady = true; } return _PARTIAL_WAKE_LOCKContent; } }
        private static int _PARTIAL_WAKE_LOCKContent = default;
        private static bool _PARTIAL_WAKE_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#PROXIMITY_SCREEN_OFF_WAKE_LOCK"/>
        /// </summary>
        public static int PROXIMITY_SCREEN_OFF_WAKE_LOCK { get { if (!_PROXIMITY_SCREEN_OFF_WAKE_LOCKReady) { _PROXIMITY_SCREEN_OFF_WAKE_LOCKContent = SGetField<int>(LocalBridgeClazz, "PROXIMITY_SCREEN_OFF_WAKE_LOCK"); _PROXIMITY_SCREEN_OFF_WAKE_LOCKReady = true; } return _PROXIMITY_SCREEN_OFF_WAKE_LOCKContent; } }
        private static int _PROXIMITY_SCREEN_OFF_WAKE_LOCKContent = default;
        private static bool _PROXIMITY_SCREEN_OFF_WAKE_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#RELEASE_FLAG_WAIT_FOR_NO_PROXIMITY"/>
        /// </summary>
        public static int RELEASE_FLAG_WAIT_FOR_NO_PROXIMITY { get { if (!_RELEASE_FLAG_WAIT_FOR_NO_PROXIMITYReady) { _RELEASE_FLAG_WAIT_FOR_NO_PROXIMITYContent = SGetField<int>(LocalBridgeClazz, "RELEASE_FLAG_WAIT_FOR_NO_PROXIMITY"); _RELEASE_FLAG_WAIT_FOR_NO_PROXIMITYReady = true; } return _RELEASE_FLAG_WAIT_FOR_NO_PROXIMITYContent; } }
        private static int _RELEASE_FLAG_WAIT_FOR_NO_PROXIMITYContent = default;
        private static bool _RELEASE_FLAG_WAIT_FOR_NO_PROXIMITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_CRITICAL"/>
        /// </summary>
        public static int THERMAL_STATUS_CRITICAL { get { if (!_THERMAL_STATUS_CRITICALReady) { _THERMAL_STATUS_CRITICALContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_CRITICAL"); _THERMAL_STATUS_CRITICALReady = true; } return _THERMAL_STATUS_CRITICALContent; } }
        private static int _THERMAL_STATUS_CRITICALContent = default;
        private static bool _THERMAL_STATUS_CRITICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_EMERGENCY"/>
        /// </summary>
        public static int THERMAL_STATUS_EMERGENCY { get { if (!_THERMAL_STATUS_EMERGENCYReady) { _THERMAL_STATUS_EMERGENCYContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_EMERGENCY"); _THERMAL_STATUS_EMERGENCYReady = true; } return _THERMAL_STATUS_EMERGENCYContent; } }
        private static int _THERMAL_STATUS_EMERGENCYContent = default;
        private static bool _THERMAL_STATUS_EMERGENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_LIGHT"/>
        /// </summary>
        public static int THERMAL_STATUS_LIGHT { get { if (!_THERMAL_STATUS_LIGHTReady) { _THERMAL_STATUS_LIGHTContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_LIGHT"); _THERMAL_STATUS_LIGHTReady = true; } return _THERMAL_STATUS_LIGHTContent; } }
        private static int _THERMAL_STATUS_LIGHTContent = default;
        private static bool _THERMAL_STATUS_LIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_MODERATE"/>
        /// </summary>
        public static int THERMAL_STATUS_MODERATE { get { if (!_THERMAL_STATUS_MODERATEReady) { _THERMAL_STATUS_MODERATEContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_MODERATE"); _THERMAL_STATUS_MODERATEReady = true; } return _THERMAL_STATUS_MODERATEContent; } }
        private static int _THERMAL_STATUS_MODERATEContent = default;
        private static bool _THERMAL_STATUS_MODERATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_NONE"/>
        /// </summary>
        public static int THERMAL_STATUS_NONE { get { if (!_THERMAL_STATUS_NONEReady) { _THERMAL_STATUS_NONEContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_NONE"); _THERMAL_STATUS_NONEReady = true; } return _THERMAL_STATUS_NONEContent; } }
        private static int _THERMAL_STATUS_NONEContent = default;
        private static bool _THERMAL_STATUS_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_SEVERE"/>
        /// </summary>
        public static int THERMAL_STATUS_SEVERE { get { if (!_THERMAL_STATUS_SEVEREReady) { _THERMAL_STATUS_SEVEREContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_SEVERE"); _THERMAL_STATUS_SEVEREReady = true; } return _THERMAL_STATUS_SEVEREContent; } }
        private static int _THERMAL_STATUS_SEVEREContent = default;
        private static bool _THERMAL_STATUS_SEVEREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#THERMAL_STATUS_SHUTDOWN"/>
        /// </summary>
        public static int THERMAL_STATUS_SHUTDOWN { get { if (!_THERMAL_STATUS_SHUTDOWNReady) { _THERMAL_STATUS_SHUTDOWNContent = SGetField<int>(LocalBridgeClazz, "THERMAL_STATUS_SHUTDOWN"); _THERMAL_STATUS_SHUTDOWNReady = true; } return _THERMAL_STATUS_SHUTDOWNContent; } }
        private static int _THERMAL_STATUS_SHUTDOWNContent = default;
        private static bool _THERMAL_STATUS_SHUTDOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#ACTION_DEVICE_IDLE_MODE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_DEVICE_IDLE_MODE_CHANGED { get { if (!_ACTION_DEVICE_IDLE_MODE_CHANGEDReady) { _ACTION_DEVICE_IDLE_MODE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DEVICE_IDLE_MODE_CHANGED"); _ACTION_DEVICE_IDLE_MODE_CHANGEDReady = true; } return _ACTION_DEVICE_IDLE_MODE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_DEVICE_IDLE_MODE_CHANGEDContent = default;
        private static bool _ACTION_DEVICE_IDLE_MODE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGED { get { if (!_ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGEDReady) { _ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGED"); _ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGEDReady = true; } return _ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGEDContent = default;
        private static bool _ACTION_DEVICE_LIGHT_IDLE_MODE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#ACTION_LOW_POWER_STANDBY_ENABLED_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_LOW_POWER_STANDBY_ENABLED_CHANGED { get { if (!_ACTION_LOW_POWER_STANDBY_ENABLED_CHANGEDReady) { _ACTION_LOW_POWER_STANDBY_ENABLED_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_LOW_POWER_STANDBY_ENABLED_CHANGED"); _ACTION_LOW_POWER_STANDBY_ENABLED_CHANGEDReady = true; } return _ACTION_LOW_POWER_STANDBY_ENABLED_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_LOW_POWER_STANDBY_ENABLED_CHANGEDContent = default;
        private static bool _ACTION_LOW_POWER_STANDBY_ENABLED_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#ACTION_LOW_POWER_STANDBY_POLICY_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_LOW_POWER_STANDBY_POLICY_CHANGED { get { if (!_ACTION_LOW_POWER_STANDBY_POLICY_CHANGEDReady) { _ACTION_LOW_POWER_STANDBY_POLICY_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_LOW_POWER_STANDBY_POLICY_CHANGED"); _ACTION_LOW_POWER_STANDBY_POLICY_CHANGEDReady = true; } return _ACTION_LOW_POWER_STANDBY_POLICY_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_LOW_POWER_STANDBY_POLICY_CHANGEDContent = default;
        private static bool _ACTION_LOW_POWER_STANDBY_POLICY_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#ACTION_POWER_SAVE_MODE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_POWER_SAVE_MODE_CHANGED { get { if (!_ACTION_POWER_SAVE_MODE_CHANGEDReady) { _ACTION_POWER_SAVE_MODE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_POWER_SAVE_MODE_CHANGED"); _ACTION_POWER_SAVE_MODE_CHANGEDReady = true; } return _ACTION_POWER_SAVE_MODE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_POWER_SAVE_MODE_CHANGEDContent = default;
        private static bool _ACTION_POWER_SAVE_MODE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBY"/>
        /// </summary>
        public static Java.Lang.String FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBY { get { if (!_FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBYReady) { _FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBY"); _FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBYReady = true; } return _FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBYContent; } }
        private static Java.Lang.String _FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBYContent = default;
        private static bool _FEATURE_WAKE_ON_LAN_IN_LOW_POWER_STANDBYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#getBatteryDischargePrediction()"/> 
        /// </summary>
        public Java.Time.Duration BatteryDischargePrediction
        {
            get { return IExecuteWithSignature<Java.Time.Duration>("getBatteryDischargePrediction", "()Ljava/time/Duration;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#getCurrentThermalStatus()"/> 
        /// </summary>
        public int CurrentThermalStatus
        {
            get { return IExecuteWithSignature<int>("getCurrentThermalStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#getLocationPowerSaveMode()"/> 
        /// </summary>
        public int LocationPowerSaveMode
        {
            get { return IExecuteWithSignature<int>("getLocationPowerSaveMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#newWakeLock(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.PowerManager.WakeLock"/></returns>
        public Android.Os.PowerManager.WakeLock NewWakeLock(int arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Os.PowerManager.WakeLock>("newWakeLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isAllowedInLowPowerStandby(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllowedInLowPowerStandby(int arg0)
        {
            return IExecuteWithSignature<bool>("isAllowedInLowPowerStandby", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isAllowedInLowPowerStandby(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllowedInLowPowerStandby(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isAllowedInLowPowerStandby", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isBatteryDischargePredictionPersonalized()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBatteryDischargePredictionPersonalized()
        {
            return IExecuteWithSignature<bool>("isBatteryDischargePredictionPersonalized", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isDeviceIdleMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceIdleMode()
        {
            return IExecuteWithSignature<bool>("isDeviceIdleMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isDeviceLightIdleMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceLightIdleMode()
        {
            return IExecuteWithSignature<bool>("isDeviceLightIdleMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isExemptFromLowPowerStandby()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExemptFromLowPowerStandby()
        {
            return IExecuteWithSignature<bool>("isExemptFromLowPowerStandby", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isIgnoringBatteryOptimizations(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsIgnoringBatteryOptimizations(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isIgnoringBatteryOptimizations", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isInteractive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInteractive()
        {
            return IExecuteWithSignature<bool>("isInteractive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isLowPowerStandbyEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLowPowerStandbyEnabled()
        {
            return IExecuteWithSignature<bool>("isLowPowerStandbyEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isPowerSaveMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPowerSaveMode()
        {
            return IExecuteWithSignature<bool>("isPowerSaveMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isRebootingUserspaceSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRebootingUserspaceSupported()
        {
            return IExecuteWithSignature<bool>("isRebootingUserspaceSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isSustainedPerformanceModeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSustainedPerformanceModeSupported()
        {
            return IExecuteWithSignature<bool>("isSustainedPerformanceModeSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#isWakeLockLevelSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsWakeLockLevelSupported(int arg0)
        {
            return IExecuteWithSignature<bool>("isWakeLockLevelSupported", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#getThermalHeadroom(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetThermalHeadroom(int arg0)
        {
            return IExecuteWithSignature<float>("getThermalHeadroom", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#addThermalStatusListener(android.os.PowerManager.OnThermalStatusChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.PowerManager.OnThermalStatusChangedListener"/></param>
        public void AddThermalStatusListener(Android.Os.PowerManager.OnThermalStatusChangedListener arg0)
        {
            IExecuteWithSignature("addThermalStatusListener", "(Landroid/os/PowerManager$OnThermalStatusChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#addThermalStatusListener(java.util.concurrent.Executor,android.os.PowerManager.OnThermalStatusChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.PowerManager.OnThermalStatusChangedListener"/></param>
        public void AddThermalStatusListener(Java.Util.Concurrent.Executor arg0, Android.Os.PowerManager.OnThermalStatusChangedListener arg1)
        {
            IExecute("addThermalStatusListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#reboot(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Reboot(Java.Lang.String arg0)
        {
            IExecuteWithSignature("reboot", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PowerManager.html#removeThermalStatusListener(android.os.PowerManager.OnThermalStatusChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.PowerManager.OnThermalStatusChangedListener"/></param>
        public void RemoveThermalStatusListener(Android.Os.PowerManager.OnThermalStatusChangedListener arg0)
        {
            IExecuteWithSignature("removeThermalStatusListener", "(Landroid/os/PowerManager$OnThermalStatusChangedListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnThermalStatusChangedListener
        public partial class OnThermalStatusChangedListener
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
            /// Handlers initializer for <see cref="OnThermalStatusChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onThermalStatusChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnThermalStatusChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/PowerManager.OnThermalStatusChangedListener.html#onThermalStatusChanged(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnThermalStatusChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<int> OnOnThermalStatusChanged { get; set; } = null;

            void OnThermalStatusChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnThermalStatusChanged != null) ? OnOnThermalStatusChanged : OnThermalStatusChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.OnThermalStatusChangedListener.html#onThermalStatusChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnThermalStatusChanged(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnThermalStatusChangedListenerDirect
        public partial class OnThermalStatusChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.OnThermalStatusChangedListener.html#onThermalStatusChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnThermalStatusChanged(int arg0)
            {
                IExecuteWithSignature("onThermalStatusChanged", "(I)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region WakeLock
        public partial class WakeLock
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
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#isHeld()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsHeld()
            {
                return IExecuteWithSignature<bool>("isHeld", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#acquire()"/>
            /// </summary>
            public void Acquire()
            {
                IExecuteWithSignature("acquire", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#acquire(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void Acquire(long arg0)
            {
                IExecuteWithSignature("acquire", "(J)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#release()"/>
            /// </summary>
            public void Release()
            {
                IExecuteWithSignature("release", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#release(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void Release(int arg0)
            {
                IExecuteWithSignature("release", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#setReferenceCounted(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetReferenceCounted(bool arg0)
            {
                IExecuteWithSignature("setReferenceCounted", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#setStateListener(java.util.concurrent.Executor,android.os.PowerManager.WakeLockStateListener)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
            /// <param name="arg1"><see cref="Android.Os.PowerManager.WakeLockStateListener"/></param>
            public void SetStateListener(Java.Util.Concurrent.Executor arg0, Android.Os.PowerManager.WakeLockStateListener arg1)
            {
                IExecute("setStateListener", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLock.html#setWorkSource(android.os.WorkSource)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.WorkSource"/></param>
            public void SetWorkSource(Android.Os.WorkSource arg0)
            {
                IExecuteWithSignature("setWorkSource", "(Landroid/os/WorkSource;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region WakeLockStateListener
        public partial class WakeLockStateListener
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
            /// Handlers initializer for <see cref="WakeLockStateListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onStateChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnStateChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLockStateListener.html#onStateChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnStateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<bool> OnOnStateChanged { get; set; } = null;

            void OnStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnStateChanged != null) ? OnOnStateChanged : OnStateChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLockStateListener.html#onStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnStateChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region WakeLockStateListenerDirect
        public partial class WakeLockStateListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/os/PowerManager.WakeLockStateListener.html#onStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnStateChanged(bool arg0)
            {
                IExecuteWithSignature("onStateChanged", "(Z)V", arg0);
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