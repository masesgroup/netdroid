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

namespace Android.Hardware.Lights
{
    #region Light
    public partial class Light
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_CAPABILITY_BRIGHTNESS"/>
        /// </summary>
        public static int LIGHT_CAPABILITY_BRIGHTNESS { get { if (!_LIGHT_CAPABILITY_BRIGHTNESSReady) { _LIGHT_CAPABILITY_BRIGHTNESSContent = SGetField<int>(LocalBridgeClazz, "LIGHT_CAPABILITY_BRIGHTNESS"); _LIGHT_CAPABILITY_BRIGHTNESSReady = true; } return _LIGHT_CAPABILITY_BRIGHTNESSContent; } }
        private static int _LIGHT_CAPABILITY_BRIGHTNESSContent = default;
        private static bool _LIGHT_CAPABILITY_BRIGHTNESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_CAPABILITY_COLOR_RGB"/>
        /// </summary>
        public static int LIGHT_CAPABILITY_COLOR_RGB { get { if (!_LIGHT_CAPABILITY_COLOR_RGBReady) { _LIGHT_CAPABILITY_COLOR_RGBContent = SGetField<int>(LocalBridgeClazz, "LIGHT_CAPABILITY_COLOR_RGB"); _LIGHT_CAPABILITY_COLOR_RGBReady = true; } return _LIGHT_CAPABILITY_COLOR_RGBContent; } }
        private static int _LIGHT_CAPABILITY_COLOR_RGBContent = default;
        private static bool _LIGHT_CAPABILITY_COLOR_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_CAPABILITY_RGB"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int LIGHT_CAPABILITY_RGB { get { if (!_LIGHT_CAPABILITY_RGBReady) { _LIGHT_CAPABILITY_RGBContent = SGetField<int>(LocalBridgeClazz, "LIGHT_CAPABILITY_RGB"); _LIGHT_CAPABILITY_RGBReady = true; } return _LIGHT_CAPABILITY_RGBContent; } }
        private static int _LIGHT_CAPABILITY_RGBContent = default;
        private static bool _LIGHT_CAPABILITY_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_TYPE_INPUT"/>
        /// </summary>
        public static int LIGHT_TYPE_INPUT { get { if (!_LIGHT_TYPE_INPUTReady) { _LIGHT_TYPE_INPUTContent = SGetField<int>(LocalBridgeClazz, "LIGHT_TYPE_INPUT"); _LIGHT_TYPE_INPUTReady = true; } return _LIGHT_TYPE_INPUTContent; } }
        private static int _LIGHT_TYPE_INPUTContent = default;
        private static bool _LIGHT_TYPE_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_TYPE_KEYBOARD_BACKLIGHT"/>
        /// </summary>
        public static int LIGHT_TYPE_KEYBOARD_BACKLIGHT { get { if (!_LIGHT_TYPE_KEYBOARD_BACKLIGHTReady) { _LIGHT_TYPE_KEYBOARD_BACKLIGHTContent = SGetField<int>(LocalBridgeClazz, "LIGHT_TYPE_KEYBOARD_BACKLIGHT"); _LIGHT_TYPE_KEYBOARD_BACKLIGHTReady = true; } return _LIGHT_TYPE_KEYBOARD_BACKLIGHTContent; } }
        private static int _LIGHT_TYPE_KEYBOARD_BACKLIGHTContent = default;
        private static bool _LIGHT_TYPE_KEYBOARD_BACKLIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_TYPE_MICROPHONE"/>
        /// </summary>
        public static int LIGHT_TYPE_MICROPHONE { get { if (!_LIGHT_TYPE_MICROPHONEReady) { _LIGHT_TYPE_MICROPHONEContent = SGetField<int>(LocalBridgeClazz, "LIGHT_TYPE_MICROPHONE"); _LIGHT_TYPE_MICROPHONEReady = true; } return _LIGHT_TYPE_MICROPHONEContent; } }
        private static int _LIGHT_TYPE_MICROPHONEContent = default;
        private static bool _LIGHT_TYPE_MICROPHONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#LIGHT_TYPE_PLAYER_ID"/>
        /// </summary>
        public static int LIGHT_TYPE_PLAYER_ID { get { if (!_LIGHT_TYPE_PLAYER_IDReady) { _LIGHT_TYPE_PLAYER_IDContent = SGetField<int>(LocalBridgeClazz, "LIGHT_TYPE_PLAYER_ID"); _LIGHT_TYPE_PLAYER_IDReady = true; } return _LIGHT_TYPE_PLAYER_IDContent; } }
        private static int _LIGHT_TYPE_PLAYER_IDContent = default;
        private static bool _LIGHT_TYPE_PLAYER_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#hasBrightnessControl()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasBrightnessControl()
        {
            return IExecuteWithSignature<bool>("hasBrightnessControl", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#hasRgbControl()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRgbControl()
        {
            return IExecuteWithSignature<bool>("hasRgbControl", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#getOrdinal()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrdinal()
        {
            return IExecuteWithSignature<int>("getOrdinal", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/lights/Light.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}