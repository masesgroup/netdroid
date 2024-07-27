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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View
{
    #region InputDevice
    public partial class InputDevice
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#KEYBOARD_TYPE_ALPHABETIC"/>
        /// </summary>
        public static int KEYBOARD_TYPE_ALPHABETIC { get { if (!_KEYBOARD_TYPE_ALPHABETICReady) { _KEYBOARD_TYPE_ALPHABETICContent = SGetField<int>(LocalBridgeClazz, "KEYBOARD_TYPE_ALPHABETIC"); _KEYBOARD_TYPE_ALPHABETICReady = true; } return _KEYBOARD_TYPE_ALPHABETICContent; } }
        private static int _KEYBOARD_TYPE_ALPHABETICContent = default;
        private static bool _KEYBOARD_TYPE_ALPHABETICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#KEYBOARD_TYPE_NON_ALPHABETIC"/>
        /// </summary>
        public static int KEYBOARD_TYPE_NON_ALPHABETIC { get { if (!_KEYBOARD_TYPE_NON_ALPHABETICReady) { _KEYBOARD_TYPE_NON_ALPHABETICContent = SGetField<int>(LocalBridgeClazz, "KEYBOARD_TYPE_NON_ALPHABETIC"); _KEYBOARD_TYPE_NON_ALPHABETICReady = true; } return _KEYBOARD_TYPE_NON_ALPHABETICContent; } }
        private static int _KEYBOARD_TYPE_NON_ALPHABETICContent = default;
        private static bool _KEYBOARD_TYPE_NON_ALPHABETICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#KEYBOARD_TYPE_NONE"/>
        /// </summary>
        public static int KEYBOARD_TYPE_NONE { get { if (!_KEYBOARD_TYPE_NONEReady) { _KEYBOARD_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "KEYBOARD_TYPE_NONE"); _KEYBOARD_TYPE_NONEReady = true; } return _KEYBOARD_TYPE_NONEContent; } }
        private static int _KEYBOARD_TYPE_NONEContent = default;
        private static bool _KEYBOARD_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_ORIENTATION"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_ORIENTATION { get { if (!_MOTION_RANGE_ORIENTATIONReady) { _MOTION_RANGE_ORIENTATIONContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_ORIENTATION"); _MOTION_RANGE_ORIENTATIONReady = true; } return _MOTION_RANGE_ORIENTATIONContent; } }
        private static int _MOTION_RANGE_ORIENTATIONContent = default;
        private static bool _MOTION_RANGE_ORIENTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_PRESSURE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_PRESSURE { get { if (!_MOTION_RANGE_PRESSUREReady) { _MOTION_RANGE_PRESSUREContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_PRESSURE"); _MOTION_RANGE_PRESSUREReady = true; } return _MOTION_RANGE_PRESSUREContent; } }
        private static int _MOTION_RANGE_PRESSUREContent = default;
        private static bool _MOTION_RANGE_PRESSUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_SIZE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_SIZE { get { if (!_MOTION_RANGE_SIZEReady) { _MOTION_RANGE_SIZEContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_SIZE"); _MOTION_RANGE_SIZEReady = true; } return _MOTION_RANGE_SIZEContent; } }
        private static int _MOTION_RANGE_SIZEContent = default;
        private static bool _MOTION_RANGE_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_TOOL_MAJOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_TOOL_MAJOR { get { if (!_MOTION_RANGE_TOOL_MAJORReady) { _MOTION_RANGE_TOOL_MAJORContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_TOOL_MAJOR"); _MOTION_RANGE_TOOL_MAJORReady = true; } return _MOTION_RANGE_TOOL_MAJORContent; } }
        private static int _MOTION_RANGE_TOOL_MAJORContent = default;
        private static bool _MOTION_RANGE_TOOL_MAJORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_TOOL_MINOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_TOOL_MINOR { get { if (!_MOTION_RANGE_TOOL_MINORReady) { _MOTION_RANGE_TOOL_MINORContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_TOOL_MINOR"); _MOTION_RANGE_TOOL_MINORReady = true; } return _MOTION_RANGE_TOOL_MINORContent; } }
        private static int _MOTION_RANGE_TOOL_MINORContent = default;
        private static bool _MOTION_RANGE_TOOL_MINORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_TOUCH_MAJOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_TOUCH_MAJOR { get { if (!_MOTION_RANGE_TOUCH_MAJORReady) { _MOTION_RANGE_TOUCH_MAJORContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_TOUCH_MAJOR"); _MOTION_RANGE_TOUCH_MAJORReady = true; } return _MOTION_RANGE_TOUCH_MAJORContent; } }
        private static int _MOTION_RANGE_TOUCH_MAJORContent = default;
        private static bool _MOTION_RANGE_TOUCH_MAJORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_TOUCH_MINOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_TOUCH_MINOR { get { if (!_MOTION_RANGE_TOUCH_MINORReady) { _MOTION_RANGE_TOUCH_MINORContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_TOUCH_MINOR"); _MOTION_RANGE_TOUCH_MINORReady = true; } return _MOTION_RANGE_TOUCH_MINORContent; } }
        private static int _MOTION_RANGE_TOUCH_MINORContent = default;
        private static bool _MOTION_RANGE_TOUCH_MINORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_X"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_X { get { if (!_MOTION_RANGE_XReady) { _MOTION_RANGE_XContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_X"); _MOTION_RANGE_XReady = true; } return _MOTION_RANGE_XContent; } }
        private static int _MOTION_RANGE_XContent = default;
        private static bool _MOTION_RANGE_XReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#MOTION_RANGE_Y"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MOTION_RANGE_Y { get { if (!_MOTION_RANGE_YReady) { _MOTION_RANGE_YContent = SGetField<int>(LocalBridgeClazz, "MOTION_RANGE_Y"); _MOTION_RANGE_YReady = true; } return _MOTION_RANGE_YContent; } }
        private static int _MOTION_RANGE_YContent = default;
        private static bool _MOTION_RANGE_YReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_ANY"/>
        /// </summary>
        public static int SOURCE_ANY { get { if (!_SOURCE_ANYReady) { _SOURCE_ANYContent = SGetField<int>(LocalBridgeClazz, "SOURCE_ANY"); _SOURCE_ANYReady = true; } return _SOURCE_ANYContent; } }
        private static int _SOURCE_ANYContent = default;
        private static bool _SOURCE_ANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_BLUETOOTH_STYLUS"/>
        /// </summary>
        public static int SOURCE_BLUETOOTH_STYLUS { get { if (!_SOURCE_BLUETOOTH_STYLUSReady) { _SOURCE_BLUETOOTH_STYLUSContent = SGetField<int>(LocalBridgeClazz, "SOURCE_BLUETOOTH_STYLUS"); _SOURCE_BLUETOOTH_STYLUSReady = true; } return _SOURCE_BLUETOOTH_STYLUSContent; } }
        private static int _SOURCE_BLUETOOTH_STYLUSContent = default;
        private static bool _SOURCE_BLUETOOTH_STYLUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_BUTTON"/>
        /// </summary>
        public static int SOURCE_CLASS_BUTTON { get { if (!_SOURCE_CLASS_BUTTONReady) { _SOURCE_CLASS_BUTTONContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_BUTTON"); _SOURCE_CLASS_BUTTONReady = true; } return _SOURCE_CLASS_BUTTONContent; } }
        private static int _SOURCE_CLASS_BUTTONContent = default;
        private static bool _SOURCE_CLASS_BUTTONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_JOYSTICK"/>
        /// </summary>
        public static int SOURCE_CLASS_JOYSTICK { get { if (!_SOURCE_CLASS_JOYSTICKReady) { _SOURCE_CLASS_JOYSTICKContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_JOYSTICK"); _SOURCE_CLASS_JOYSTICKReady = true; } return _SOURCE_CLASS_JOYSTICKContent; } }
        private static int _SOURCE_CLASS_JOYSTICKContent = default;
        private static bool _SOURCE_CLASS_JOYSTICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_MASK"/>
        /// </summary>
        public static int SOURCE_CLASS_MASK { get { if (!_SOURCE_CLASS_MASKReady) { _SOURCE_CLASS_MASKContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_MASK"); _SOURCE_CLASS_MASKReady = true; } return _SOURCE_CLASS_MASKContent; } }
        private static int _SOURCE_CLASS_MASKContent = default;
        private static bool _SOURCE_CLASS_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_NONE"/>
        /// </summary>
        public static int SOURCE_CLASS_NONE { get { if (!_SOURCE_CLASS_NONEReady) { _SOURCE_CLASS_NONEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_NONE"); _SOURCE_CLASS_NONEReady = true; } return _SOURCE_CLASS_NONEContent; } }
        private static int _SOURCE_CLASS_NONEContent = default;
        private static bool _SOURCE_CLASS_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_POINTER"/>
        /// </summary>
        public static int SOURCE_CLASS_POINTER { get { if (!_SOURCE_CLASS_POINTERReady) { _SOURCE_CLASS_POINTERContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_POINTER"); _SOURCE_CLASS_POINTERReady = true; } return _SOURCE_CLASS_POINTERContent; } }
        private static int _SOURCE_CLASS_POINTERContent = default;
        private static bool _SOURCE_CLASS_POINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_POSITION"/>
        /// </summary>
        public static int SOURCE_CLASS_POSITION { get { if (!_SOURCE_CLASS_POSITIONReady) { _SOURCE_CLASS_POSITIONContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_POSITION"); _SOURCE_CLASS_POSITIONReady = true; } return _SOURCE_CLASS_POSITIONContent; } }
        private static int _SOURCE_CLASS_POSITIONContent = default;
        private static bool _SOURCE_CLASS_POSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_CLASS_TRACKBALL"/>
        /// </summary>
        public static int SOURCE_CLASS_TRACKBALL { get { if (!_SOURCE_CLASS_TRACKBALLReady) { _SOURCE_CLASS_TRACKBALLContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLASS_TRACKBALL"); _SOURCE_CLASS_TRACKBALLReady = true; } return _SOURCE_CLASS_TRACKBALLContent; } }
        private static int _SOURCE_CLASS_TRACKBALLContent = default;
        private static bool _SOURCE_CLASS_TRACKBALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_DPAD"/>
        /// </summary>
        public static int SOURCE_DPAD { get { if (!_SOURCE_DPADReady) { _SOURCE_DPADContent = SGetField<int>(LocalBridgeClazz, "SOURCE_DPAD"); _SOURCE_DPADReady = true; } return _SOURCE_DPADContent; } }
        private static int _SOURCE_DPADContent = default;
        private static bool _SOURCE_DPADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_GAMEPAD"/>
        /// </summary>
        public static int SOURCE_GAMEPAD { get { if (!_SOURCE_GAMEPADReady) { _SOURCE_GAMEPADContent = SGetField<int>(LocalBridgeClazz, "SOURCE_GAMEPAD"); _SOURCE_GAMEPADReady = true; } return _SOURCE_GAMEPADContent; } }
        private static int _SOURCE_GAMEPADContent = default;
        private static bool _SOURCE_GAMEPADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_HDMI"/>
        /// </summary>
        public static int SOURCE_HDMI { get { if (!_SOURCE_HDMIReady) { _SOURCE_HDMIContent = SGetField<int>(LocalBridgeClazz, "SOURCE_HDMI"); _SOURCE_HDMIReady = true; } return _SOURCE_HDMIContent; } }
        private static int _SOURCE_HDMIContent = default;
        private static bool _SOURCE_HDMIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_JOYSTICK"/>
        /// </summary>
        public static int SOURCE_JOYSTICK { get { if (!_SOURCE_JOYSTICKReady) { _SOURCE_JOYSTICKContent = SGetField<int>(LocalBridgeClazz, "SOURCE_JOYSTICK"); _SOURCE_JOYSTICKReady = true; } return _SOURCE_JOYSTICKContent; } }
        private static int _SOURCE_JOYSTICKContent = default;
        private static bool _SOURCE_JOYSTICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_KEYBOARD"/>
        /// </summary>
        public static int SOURCE_KEYBOARD { get { if (!_SOURCE_KEYBOARDReady) { _SOURCE_KEYBOARDContent = SGetField<int>(LocalBridgeClazz, "SOURCE_KEYBOARD"); _SOURCE_KEYBOARDReady = true; } return _SOURCE_KEYBOARDContent; } }
        private static int _SOURCE_KEYBOARDContent = default;
        private static bool _SOURCE_KEYBOARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_MOUSE"/>
        /// </summary>
        public static int SOURCE_MOUSE { get { if (!_SOURCE_MOUSEReady) { _SOURCE_MOUSEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_MOUSE"); _SOURCE_MOUSEReady = true; } return _SOURCE_MOUSEContent; } }
        private static int _SOURCE_MOUSEContent = default;
        private static bool _SOURCE_MOUSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_MOUSE_RELATIVE"/>
        /// </summary>
        public static int SOURCE_MOUSE_RELATIVE { get { if (!_SOURCE_MOUSE_RELATIVEReady) { _SOURCE_MOUSE_RELATIVEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_MOUSE_RELATIVE"); _SOURCE_MOUSE_RELATIVEReady = true; } return _SOURCE_MOUSE_RELATIVEContent; } }
        private static int _SOURCE_MOUSE_RELATIVEContent = default;
        private static bool _SOURCE_MOUSE_RELATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_ROTARY_ENCODER"/>
        /// </summary>
        public static int SOURCE_ROTARY_ENCODER { get { if (!_SOURCE_ROTARY_ENCODERReady) { _SOURCE_ROTARY_ENCODERContent = SGetField<int>(LocalBridgeClazz, "SOURCE_ROTARY_ENCODER"); _SOURCE_ROTARY_ENCODERReady = true; } return _SOURCE_ROTARY_ENCODERContent; } }
        private static int _SOURCE_ROTARY_ENCODERContent = default;
        private static bool _SOURCE_ROTARY_ENCODERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_SENSOR"/>
        /// </summary>
        public static int SOURCE_SENSOR { get { if (!_SOURCE_SENSORReady) { _SOURCE_SENSORContent = SGetField<int>(LocalBridgeClazz, "SOURCE_SENSOR"); _SOURCE_SENSORReady = true; } return _SOURCE_SENSORContent; } }
        private static int _SOURCE_SENSORContent = default;
        private static bool _SOURCE_SENSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_STYLUS"/>
        /// </summary>
        public static int SOURCE_STYLUS { get { if (!_SOURCE_STYLUSReady) { _SOURCE_STYLUSContent = SGetField<int>(LocalBridgeClazz, "SOURCE_STYLUS"); _SOURCE_STYLUSReady = true; } return _SOURCE_STYLUSContent; } }
        private static int _SOURCE_STYLUSContent = default;
        private static bool _SOURCE_STYLUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_TOUCH_NAVIGATION"/>
        /// </summary>
        public static int SOURCE_TOUCH_NAVIGATION { get { if (!_SOURCE_TOUCH_NAVIGATIONReady) { _SOURCE_TOUCH_NAVIGATIONContent = SGetField<int>(LocalBridgeClazz, "SOURCE_TOUCH_NAVIGATION"); _SOURCE_TOUCH_NAVIGATIONReady = true; } return _SOURCE_TOUCH_NAVIGATIONContent; } }
        private static int _SOURCE_TOUCH_NAVIGATIONContent = default;
        private static bool _SOURCE_TOUCH_NAVIGATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_TOUCHPAD"/>
        /// </summary>
        public static int SOURCE_TOUCHPAD { get { if (!_SOURCE_TOUCHPADReady) { _SOURCE_TOUCHPADContent = SGetField<int>(LocalBridgeClazz, "SOURCE_TOUCHPAD"); _SOURCE_TOUCHPADReady = true; } return _SOURCE_TOUCHPADContent; } }
        private static int _SOURCE_TOUCHPADContent = default;
        private static bool _SOURCE_TOUCHPADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_TOUCHSCREEN"/>
        /// </summary>
        public static int SOURCE_TOUCHSCREEN { get { if (!_SOURCE_TOUCHSCREENReady) { _SOURCE_TOUCHSCREENContent = SGetField<int>(LocalBridgeClazz, "SOURCE_TOUCHSCREEN"); _SOURCE_TOUCHSCREENReady = true; } return _SOURCE_TOUCHSCREENContent; } }
        private static int _SOURCE_TOUCHSCREENContent = default;
        private static bool _SOURCE_TOUCHSCREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_TRACKBALL"/>
        /// </summary>
        public static int SOURCE_TRACKBALL { get { if (!_SOURCE_TRACKBALLReady) { _SOURCE_TRACKBALLContent = SGetField<int>(LocalBridgeClazz, "SOURCE_TRACKBALL"); _SOURCE_TRACKBALLReady = true; } return _SOURCE_TRACKBALLContent; } }
        private static int _SOURCE_TRACKBALLContent = default;
        private static bool _SOURCE_TRACKBALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#SOURCE_UNKNOWN"/>
        /// </summary>
        public static int SOURCE_UNKNOWN { get { if (!_SOURCE_UNKNOWNReady) { _SOURCE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SOURCE_UNKNOWN"); _SOURCE_UNKNOWNReady = true; } return _SOURCE_UNKNOWNContent; } }
        private static int _SOURCE_UNKNOWNContent = default;
        private static bool _SOURCE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getDevice(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.InputDevice"/></returns>
        public static Android.View.InputDevice GetDevice(int arg0)
        {
            return SExecuteWithSignature<Android.View.InputDevice>(LocalBridgeClazz, "getDevice", "(I)Landroid/view/InputDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getDeviceIds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int[] GetDeviceIds()
        {
            return SExecuteWithSignatureArray<int>(LocalBridgeClazz, "getDeviceIds", "()[I");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getBatteryState()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.BatteryState"/></returns>
        public Android.Hardware.BatteryState GetBatteryState()
        {
            return IExecuteWithSignature<Android.Hardware.BatteryState>("getBatteryState", "()Landroid/hardware/BatteryState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getLightsManager()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Lights.LightsManager"/></returns>
        public Android.Hardware.Lights.LightsManager GetLightsManager()
        {
            return IExecuteWithSignature<Android.Hardware.Lights.LightsManager>("getLightsManager", "()Landroid/hardware/lights/LightsManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getSensorManager()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.SensorManager"/></returns>
        public Android.Hardware.SensorManager GetSensorManager()
        {
            return IExecuteWithSignature<Android.Hardware.SensorManager>("getSensorManager", "()Landroid/hardware/SensorManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getVibrator()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Vibrator"/></returns>
        [global::System.Obsolete()]
        public Android.Os.Vibrator GetVibrator()
        {
            return IExecuteWithSignature<Android.Os.Vibrator>("getVibrator", "()Landroid/os/Vibrator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getVibratorManager()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.VibratorManager"/></returns>
        public Android.Os.VibratorManager GetVibratorManager()
        {
            return IExecuteWithSignature<Android.Os.VibratorManager>("getVibratorManager", "()Landroid/os/VibratorManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getMotionRange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.InputDevice.MotionRange"/></returns>
        public Android.View.InputDevice.MotionRange GetMotionRange(int arg0, int arg1)
        {
            return IExecute<Android.View.InputDevice.MotionRange>("getMotionRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getMotionRange(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.InputDevice.MotionRange"/></returns>
        public Android.View.InputDevice.MotionRange GetMotionRange(int arg0)
        {
            return IExecuteWithSignature<Android.View.InputDevice.MotionRange>("getMotionRange", "(I)Landroid/view/InputDevice$MotionRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getKeyCharacterMap()"/>
        /// </summary>
        /// <returns><see cref="Android.View.KeyCharacterMap"/></returns>
        public Android.View.KeyCharacterMap GetKeyCharacterMap()
        {
            return IExecuteWithSignature<Android.View.KeyCharacterMap>("getKeyCharacterMap", "()Landroid/view/KeyCharacterMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#hasMicrophone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMicrophone()
        {
            return IExecuteWithSignature<bool>("hasMicrophone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#isExternal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExternal()
        {
            return IExecuteWithSignature<bool>("isExternal", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#isVirtual()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVirtual()
        {
            return IExecuteWithSignature<bool>("isVirtual", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#supportsSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsSource(int arg0)
        {
            return IExecuteWithSignature<bool>("supportsSource", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#hasKeys(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool[] HasKeys(params int[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<bool>("hasKeys", "([I)[Z"); else return IExecuteWithSignatureArray<bool>("hasKeys", "([I)[Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getControllerNumber()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetControllerNumber()
        {
            return IExecuteWithSignature<int>("getControllerNumber", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getKeyboardType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetKeyboardType()
        {
            return IExecuteWithSignature<int>("getKeyboardType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getKeyCodeForKeyLocation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetKeyCodeForKeyLocation(int arg0)
        {
            return IExecuteWithSignature<int>("getKeyCodeForKeyLocation", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getProductId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProductId()
        {
            return IExecuteWithSignature<int>("getProductId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getSources()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSources()
        {
            return IExecuteWithSignature<int>("getSources", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getVendorId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVendorId()
        {
            return IExecuteWithSignature<int>("getVendorId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescriptor()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescriptor", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#getMotionRanges()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.InputDevice.MotionRange> GetMotionRanges()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.InputDevice.MotionRange>>("getMotionRanges", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputDevice.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region MotionRange
        public partial class MotionRange
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
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#isFromSource(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsFromSource(int arg0)
            {
                return IExecuteWithSignature<bool>("isFromSource", "(I)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getFlat()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetFlat()
            {
                return IExecuteWithSignature<float>("getFlat", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getFuzz()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetFuzz()
            {
                return IExecuteWithSignature<float>("getFuzz", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getMax()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetMax()
            {
                return IExecuteWithSignature<float>("getMax", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getMin()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetMin()
            {
                return IExecuteWithSignature<float>("getMin", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getRange()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetRange()
            {
                return IExecuteWithSignature<float>("getRange", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getResolution()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetResolution()
            {
                return IExecuteWithSignature<float>("getResolution", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getAxis()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetAxis()
            {
                return IExecuteWithSignature<int>("getAxis", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.MotionRange.html#getSource()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetSource()
            {
                return IExecuteWithSignature<int>("getSource", "()I");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ViewBehavior
        public partial class ViewBehavior
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
            /// <see href="https://developer.android.com/reference/android/view/InputDevice.ViewBehavior.html#shouldSmoothScroll(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ShouldSmoothScroll(int arg0, int arg1)
            {
                return IExecute<bool>("shouldSmoothScroll", arg0, arg1);
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