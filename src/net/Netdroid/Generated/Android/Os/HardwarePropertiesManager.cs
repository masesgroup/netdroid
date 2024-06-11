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

namespace Android.Os
{
    #region HardwarePropertiesManager
    public partial class HardwarePropertiesManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#UNDEFINED_TEMPERATURE"/>
        /// </summary>
        public static float UNDEFINED_TEMPERATURE { get { if (!_UNDEFINED_TEMPERATUREReady) { _UNDEFINED_TEMPERATUREContent = SGetField<float>(LocalBridgeClazz, "UNDEFINED_TEMPERATURE"); _UNDEFINED_TEMPERATUREReady = true; } return _UNDEFINED_TEMPERATUREContent; } }
        private static float _UNDEFINED_TEMPERATUREContent = default;
        private static bool _UNDEFINED_TEMPERATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#DEVICE_TEMPERATURE_BATTERY"/>
        /// </summary>
        public static int DEVICE_TEMPERATURE_BATTERY { get { if (!_DEVICE_TEMPERATURE_BATTERYReady) { _DEVICE_TEMPERATURE_BATTERYContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TEMPERATURE_BATTERY"); _DEVICE_TEMPERATURE_BATTERYReady = true; } return _DEVICE_TEMPERATURE_BATTERYContent; } }
        private static int _DEVICE_TEMPERATURE_BATTERYContent = default;
        private static bool _DEVICE_TEMPERATURE_BATTERYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#DEVICE_TEMPERATURE_CPU"/>
        /// </summary>
        public static int DEVICE_TEMPERATURE_CPU { get { if (!_DEVICE_TEMPERATURE_CPUReady) { _DEVICE_TEMPERATURE_CPUContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TEMPERATURE_CPU"); _DEVICE_TEMPERATURE_CPUReady = true; } return _DEVICE_TEMPERATURE_CPUContent; } }
        private static int _DEVICE_TEMPERATURE_CPUContent = default;
        private static bool _DEVICE_TEMPERATURE_CPUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#DEVICE_TEMPERATURE_GPU"/>
        /// </summary>
        public static int DEVICE_TEMPERATURE_GPU { get { if (!_DEVICE_TEMPERATURE_GPUReady) { _DEVICE_TEMPERATURE_GPUContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TEMPERATURE_GPU"); _DEVICE_TEMPERATURE_GPUReady = true; } return _DEVICE_TEMPERATURE_GPUContent; } }
        private static int _DEVICE_TEMPERATURE_GPUContent = default;
        private static bool _DEVICE_TEMPERATURE_GPUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#DEVICE_TEMPERATURE_SKIN"/>
        /// </summary>
        public static int DEVICE_TEMPERATURE_SKIN { get { if (!_DEVICE_TEMPERATURE_SKINReady) { _DEVICE_TEMPERATURE_SKINContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TEMPERATURE_SKIN"); _DEVICE_TEMPERATURE_SKINReady = true; } return _DEVICE_TEMPERATURE_SKINContent; } }
        private static int _DEVICE_TEMPERATURE_SKINContent = default;
        private static bool _DEVICE_TEMPERATURE_SKINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#TEMPERATURE_CURRENT"/>
        /// </summary>
        public static int TEMPERATURE_CURRENT { get { if (!_TEMPERATURE_CURRENTReady) { _TEMPERATURE_CURRENTContent = SGetField<int>(LocalBridgeClazz, "TEMPERATURE_CURRENT"); _TEMPERATURE_CURRENTReady = true; } return _TEMPERATURE_CURRENTContent; } }
        private static int _TEMPERATURE_CURRENTContent = default;
        private static bool _TEMPERATURE_CURRENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#TEMPERATURE_SHUTDOWN"/>
        /// </summary>
        public static int TEMPERATURE_SHUTDOWN { get { if (!_TEMPERATURE_SHUTDOWNReady) { _TEMPERATURE_SHUTDOWNContent = SGetField<int>(LocalBridgeClazz, "TEMPERATURE_SHUTDOWN"); _TEMPERATURE_SHUTDOWNReady = true; } return _TEMPERATURE_SHUTDOWNContent; } }
        private static int _TEMPERATURE_SHUTDOWNContent = default;
        private static bool _TEMPERATURE_SHUTDOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#TEMPERATURE_THROTTLING"/>
        /// </summary>
        public static int TEMPERATURE_THROTTLING { get { if (!_TEMPERATURE_THROTTLINGReady) { _TEMPERATURE_THROTTLINGContent = SGetField<int>(LocalBridgeClazz, "TEMPERATURE_THROTTLING"); _TEMPERATURE_THROTTLINGReady = true; } return _TEMPERATURE_THROTTLINGContent; } }
        private static int _TEMPERATURE_THROTTLINGContent = default;
        private static bool _TEMPERATURE_THROTTLINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#TEMPERATURE_THROTTLING_BELOW_VR_MIN"/>
        /// </summary>
        public static int TEMPERATURE_THROTTLING_BELOW_VR_MIN { get { if (!_TEMPERATURE_THROTTLING_BELOW_VR_MINReady) { _TEMPERATURE_THROTTLING_BELOW_VR_MINContent = SGetField<int>(LocalBridgeClazz, "TEMPERATURE_THROTTLING_BELOW_VR_MIN"); _TEMPERATURE_THROTTLING_BELOW_VR_MINReady = true; } return _TEMPERATURE_THROTTLING_BELOW_VR_MINContent; } }
        private static int _TEMPERATURE_THROTTLING_BELOW_VR_MINContent = default;
        private static bool _TEMPERATURE_THROTTLING_BELOW_VR_MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#getCpuUsages()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.CpuUsageInfo"/></returns>
        public Android.Os.CpuUsageInfo[] GetCpuUsages()
        {
            return IExecuteWithSignatureArray<Android.Os.CpuUsageInfo>("getCpuUsages", "()[Landroid/os/CpuUsageInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#getDeviceTemperatures(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetDeviceTemperatures(int arg0, int arg1)
        {
            return IExecuteArray<float>("getDeviceTemperatures", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/HardwarePropertiesManager.html#getFanSpeeds()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetFanSpeeds()
        {
            return IExecuteWithSignatureArray<float>("getFanSpeeds", "()[F");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}