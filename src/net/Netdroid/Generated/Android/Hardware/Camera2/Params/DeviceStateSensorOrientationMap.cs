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

namespace Android.Hardware.Camera2.Params
{
    #region DeviceStateSensorOrientationMap
    public partial class DeviceStateSensorOrientationMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DeviceStateSensorOrientationMap.html#FOLDED"/>
        /// </summary>
        public static long FOLDED { get { if (!_FOLDEDReady) { _FOLDEDContent = SGetField<long>(LocalBridgeClazz, "FOLDED"); _FOLDEDReady = true; } return _FOLDEDContent; } }
        private static long _FOLDEDContent = default;
        private static bool _FOLDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DeviceStateSensorOrientationMap.html#NORMAL"/>
        /// </summary>
        public static long NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<long>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
        private static long _NORMALContent = default;
        private static bool _NORMALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DeviceStateSensorOrientationMap.html#getSensorOrientation(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSensorOrientation(long arg0)
        {
            return IExecuteWithSignature<int>("getSensorOrientation", "(J)I", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DeviceStateSensorOrientationMap.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Hardware.Camera2.Params.DeviceStateSensorOrientationMap"/></returns>
            public Android.Hardware.Camera2.Params.DeviceStateSensorOrientationMap Build()
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.DeviceStateSensorOrientationMap>("build", "()Landroid/hardware/camera2/params/DeviceStateSensorOrientationMap;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DeviceStateSensorOrientationMap.Builder.html#addOrientationForState(long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.DeviceStateSensorOrientationMap.Builder"/></returns>
            public Android.Hardware.Camera2.Params.DeviceStateSensorOrientationMap.Builder AddOrientationForState(long arg0, long arg1)
            {
                return IExecute<Android.Hardware.Camera2.Params.DeviceStateSensorOrientationMap.Builder>("addOrientationForState", arg0, arg1);
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