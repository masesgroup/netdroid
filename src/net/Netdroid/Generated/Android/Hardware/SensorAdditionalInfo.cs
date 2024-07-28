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

namespace Android.Hardware
{
    #region SensorAdditionalInfo
    public partial class SensorAdditionalInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#sensor"/>
        /// </summary>
        public Android.Hardware.Sensor sensor { get { if (!_sensorReady) { _sensorContent = IGetField<Android.Hardware.Sensor>("sensor"); _sensorReady = true; } return _sensorContent; } }
        private Android.Hardware.Sensor _sensorContent = default;
        private bool _sensorReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#floatValues"/>
        /// </summary>
        public float[] floatValues { get { if (!_floatValuesReady) { _floatValuesContent = IGetFieldArray<float>("floatValues"); _floatValuesReady = true; } return _floatValuesContent; } }
        private float[] _floatValuesContent = default;
        private bool _floatValuesReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#serial"/>
        /// </summary>
        public int serial { get { if (!_serialReady) { _serialContent = IGetField<int>("serial"); _serialReady = true; } return _serialContent; } }
        private int _serialContent = default;
        private bool _serialReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#type"/>
        /// </summary>
        public int type { get { if (!_typeReady) { _typeContent = IGetField<int>("type"); _typeReady = true; } return _typeContent; } }
        private int _typeContent = default;
        private bool _typeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#intValues"/>
        /// </summary>
        public int[] intValues { get { if (!_intValuesReady) { _intValuesContent = IGetFieldArray<int>("intValues"); _intValuesReady = true; } return _intValuesContent; } }
        private int[] _intValuesContent = default;
        private bool _intValuesReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_FRAME_BEGIN"/>
        /// </summary>
        public static int TYPE_FRAME_BEGIN { get { if (!_TYPE_FRAME_BEGINReady) { _TYPE_FRAME_BEGINContent = SGetField<int>(LocalBridgeClazz, "TYPE_FRAME_BEGIN"); _TYPE_FRAME_BEGINReady = true; } return _TYPE_FRAME_BEGINContent; } }
        private static int _TYPE_FRAME_BEGINContent = default;
        private static bool _TYPE_FRAME_BEGINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_FRAME_END"/>
        /// </summary>
        public static int TYPE_FRAME_END { get { if (!_TYPE_FRAME_ENDReady) { _TYPE_FRAME_ENDContent = SGetField<int>(LocalBridgeClazz, "TYPE_FRAME_END"); _TYPE_FRAME_ENDReady = true; } return _TYPE_FRAME_ENDContent; } }
        private static int _TYPE_FRAME_ENDContent = default;
        private static bool _TYPE_FRAME_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_INTERNAL_TEMPERATURE"/>
        /// </summary>
        public static int TYPE_INTERNAL_TEMPERATURE { get { if (!_TYPE_INTERNAL_TEMPERATUREReady) { _TYPE_INTERNAL_TEMPERATUREContent = SGetField<int>(LocalBridgeClazz, "TYPE_INTERNAL_TEMPERATURE"); _TYPE_INTERNAL_TEMPERATUREReady = true; } return _TYPE_INTERNAL_TEMPERATUREContent; } }
        private static int _TYPE_INTERNAL_TEMPERATUREContent = default;
        private static bool _TYPE_INTERNAL_TEMPERATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_SAMPLING"/>
        /// </summary>
        public static int TYPE_SAMPLING { get { if (!_TYPE_SAMPLINGReady) { _TYPE_SAMPLINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_SAMPLING"); _TYPE_SAMPLINGReady = true; } return _TYPE_SAMPLINGContent; } }
        private static int _TYPE_SAMPLINGContent = default;
        private static bool _TYPE_SAMPLINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_SENSOR_PLACEMENT"/>
        /// </summary>
        public static int TYPE_SENSOR_PLACEMENT { get { if (!_TYPE_SENSOR_PLACEMENTReady) { _TYPE_SENSOR_PLACEMENTContent = SGetField<int>(LocalBridgeClazz, "TYPE_SENSOR_PLACEMENT"); _TYPE_SENSOR_PLACEMENTReady = true; } return _TYPE_SENSOR_PLACEMENTContent; } }
        private static int _TYPE_SENSOR_PLACEMENTContent = default;
        private static bool _TYPE_SENSOR_PLACEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_UNTRACKED_DELAY"/>
        /// </summary>
        public static int TYPE_UNTRACKED_DELAY { get { if (!_TYPE_UNTRACKED_DELAYReady) { _TYPE_UNTRACKED_DELAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNTRACKED_DELAY"); _TYPE_UNTRACKED_DELAYReady = true; } return _TYPE_UNTRACKED_DELAYContent; } }
        private static int _TYPE_UNTRACKED_DELAYContent = default;
        private static bool _TYPE_UNTRACKED_DELAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorAdditionalInfo.html#TYPE_VEC3_CALIBRATION"/>
        /// </summary>
        public static int TYPE_VEC3_CALIBRATION { get { if (!_TYPE_VEC3_CALIBRATIONReady) { _TYPE_VEC3_CALIBRATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_VEC3_CALIBRATION"); _TYPE_VEC3_CALIBRATIONReady = true; } return _TYPE_VEC3_CALIBRATIONContent; } }
        private static int _TYPE_VEC3_CALIBRATIONContent = default;
        private static bool _TYPE_VEC3_CALIBRATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}