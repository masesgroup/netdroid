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

namespace Android.Devicelock
{
    #region DeviceId
    public partial class DeviceId
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/devicelock/DeviceId.html#DEVICE_ID_TYPE_IMEI"/>
        /// </summary>
        public static int DEVICE_ID_TYPE_IMEI { get { if (!_DEVICE_ID_TYPE_IMEIReady) { _DEVICE_ID_TYPE_IMEIContent = SGetField<int>(LocalBridgeClazz, "DEVICE_ID_TYPE_IMEI"); _DEVICE_ID_TYPE_IMEIReady = true; } return _DEVICE_ID_TYPE_IMEIContent; } }
        private static int _DEVICE_ID_TYPE_IMEIContent = default;
        private static bool _DEVICE_ID_TYPE_IMEIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/devicelock/DeviceId.html#DEVICE_ID_TYPE_MEID"/>
        /// </summary>
        public static int DEVICE_ID_TYPE_MEID { get { if (!_DEVICE_ID_TYPE_MEIDReady) { _DEVICE_ID_TYPE_MEIDContent = SGetField<int>(LocalBridgeClazz, "DEVICE_ID_TYPE_MEID"); _DEVICE_ID_TYPE_MEIDReady = true; } return _DEVICE_ID_TYPE_MEIDContent; } }
        private static int _DEVICE_ID_TYPE_MEIDContent = default;
        private static bool _DEVICE_ID_TYPE_MEIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/devicelock/DeviceId.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/devicelock/DeviceId.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}