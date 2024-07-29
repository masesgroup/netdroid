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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Health.Connect.Datatypes
{
    #region BloodPressureRecord
    public partial class BloodPressureRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#DIASTOLIC_AVG"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType DIASTOLIC_AVG { get { if (!_DIASTOLIC_AVGReady) { _DIASTOLIC_AVGContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "DIASTOLIC_AVG"); _DIASTOLIC_AVGReady = true; } return _DIASTOLIC_AVGContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _DIASTOLIC_AVGContent = default;
        private static bool _DIASTOLIC_AVGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#DIASTOLIC_MAX"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType DIASTOLIC_MAX { get { if (!_DIASTOLIC_MAXReady) { _DIASTOLIC_MAXContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "DIASTOLIC_MAX"); _DIASTOLIC_MAXReady = true; } return _DIASTOLIC_MAXContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _DIASTOLIC_MAXContent = default;
        private static bool _DIASTOLIC_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#DIASTOLIC_MIN"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType DIASTOLIC_MIN { get { if (!_DIASTOLIC_MINReady) { _DIASTOLIC_MINContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "DIASTOLIC_MIN"); _DIASTOLIC_MINReady = true; } return _DIASTOLIC_MINContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _DIASTOLIC_MINContent = default;
        private static bool _DIASTOLIC_MINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#SYSTOLIC_AVG"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SYSTOLIC_AVG { get { if (!_SYSTOLIC_AVGReady) { _SYSTOLIC_AVGContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SYSTOLIC_AVG"); _SYSTOLIC_AVGReady = true; } return _SYSTOLIC_AVGContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SYSTOLIC_AVGContent = default;
        private static bool _SYSTOLIC_AVGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#SYSTOLIC_MAX"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SYSTOLIC_MAX { get { if (!_SYSTOLIC_MAXReady) { _SYSTOLIC_MAXContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SYSTOLIC_MAX"); _SYSTOLIC_MAXReady = true; } return _SYSTOLIC_MAXContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SYSTOLIC_MAXContent = default;
        private static bool _SYSTOLIC_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#SYSTOLIC_MIN"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SYSTOLIC_MIN { get { if (!_SYSTOLIC_MINReady) { _SYSTOLIC_MINContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SYSTOLIC_MIN"); _SYSTOLIC_MINReady = true; } return _SYSTOLIC_MINContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SYSTOLIC_MINContent = default;
        private static bool _SYSTOLIC_MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#getDiastolic()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Pressure"/></returns>
        public Android.Health.Connect.Datatypes.Units.Pressure GetDiastolic()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Pressure>("getDiastolic", "()Landroid/health/connect/datatypes/units/Pressure;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#getSystolic()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Pressure"/></returns>
        public Android.Health.Connect.Datatypes.Units.Pressure GetSystolic()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Pressure>("getSystolic", "()Landroid/health/connect/datatypes/units/Pressure;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#getBodyPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBodyPosition()
        {
            return IExecuteWithSignature<int>("getBodyPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.html#getMeasurementLocation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementLocation()
        {
            return IExecuteWithSignature<int>("getMeasurementLocation", "()I");
        }

        #endregion

        #region Nested classes
        #region BloodPressureMeasurementLocation
        public partial class BloodPressureMeasurementLocation
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BloodPressureMeasurementLocation.html#BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARM"/>
            /// </summary>
            public static int BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARM { get { if (!_BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARMReady) { _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARMContent = SGetField<int>(LocalBridgeClazz, "BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARM"); _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARMReady = true; } return _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARMContent; } }
            private static int _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARMContent = default;
            private static bool _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_UPPER_ARMReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BloodPressureMeasurementLocation.html#BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRIST"/>
            /// </summary>
            public static int BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRIST { get { if (!_BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRISTReady) { _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRISTContent = SGetField<int>(LocalBridgeClazz, "BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRIST"); _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRISTReady = true; } return _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRISTContent; } }
            private static int _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRISTContent = default;
            private static bool _BLOOD_PRESSURE_MEASUREMENT_LOCATION_LEFT_WRISTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BloodPressureMeasurementLocation.html#BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARM"/>
            /// </summary>
            public static int BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARM { get { if (!_BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARMReady) { _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARMContent = SGetField<int>(LocalBridgeClazz, "BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARM"); _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARMReady = true; } return _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARMContent; } }
            private static int _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARMContent = default;
            private static bool _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_UPPER_ARMReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BloodPressureMeasurementLocation.html#BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRIST"/>
            /// </summary>
            public static int BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRIST { get { if (!_BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRISTReady) { _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRISTContent = SGetField<int>(LocalBridgeClazz, "BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRIST"); _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRISTReady = true; } return _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRISTContent; } }
            private static int _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRISTContent = default;
            private static bool _BLOOD_PRESSURE_MEASUREMENT_LOCATION_RIGHT_WRISTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BloodPressureMeasurementLocation.html#BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWN"/>
            /// </summary>
            public static int BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWN { get { if (!_BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWNReady) { _BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWN"); _BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWNReady = true; } return _BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWNContent; } }
            private static int _BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWNContent = default;
            private static bool _BLOOD_PRESSURE_MEASUREMENT_LOCATION_UNKNOWNReady = false; // this is used because in case of generics 

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

        #region BodyPosition
        public partial class BodyPosition
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BodyPosition.html#BODY_POSITION_LYING_DOWN"/>
            /// </summary>
            public static int BODY_POSITION_LYING_DOWN { get { if (!_BODY_POSITION_LYING_DOWNReady) { _BODY_POSITION_LYING_DOWNContent = SGetField<int>(LocalBridgeClazz, "BODY_POSITION_LYING_DOWN"); _BODY_POSITION_LYING_DOWNReady = true; } return _BODY_POSITION_LYING_DOWNContent; } }
            private static int _BODY_POSITION_LYING_DOWNContent = default;
            private static bool _BODY_POSITION_LYING_DOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BodyPosition.html#BODY_POSITION_RECLINING"/>
            /// </summary>
            public static int BODY_POSITION_RECLINING { get { if (!_BODY_POSITION_RECLININGReady) { _BODY_POSITION_RECLININGContent = SGetField<int>(LocalBridgeClazz, "BODY_POSITION_RECLINING"); _BODY_POSITION_RECLININGReady = true; } return _BODY_POSITION_RECLININGContent; } }
            private static int _BODY_POSITION_RECLININGContent = default;
            private static bool _BODY_POSITION_RECLININGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BodyPosition.html#BODY_POSITION_SITTING_DOWN"/>
            /// </summary>
            public static int BODY_POSITION_SITTING_DOWN { get { if (!_BODY_POSITION_SITTING_DOWNReady) { _BODY_POSITION_SITTING_DOWNContent = SGetField<int>(LocalBridgeClazz, "BODY_POSITION_SITTING_DOWN"); _BODY_POSITION_SITTING_DOWNReady = true; } return _BODY_POSITION_SITTING_DOWNContent; } }
            private static int _BODY_POSITION_SITTING_DOWNContent = default;
            private static bool _BODY_POSITION_SITTING_DOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BodyPosition.html#BODY_POSITION_STANDING_UP"/>
            /// </summary>
            public static int BODY_POSITION_STANDING_UP { get { if (!_BODY_POSITION_STANDING_UPReady) { _BODY_POSITION_STANDING_UPContent = SGetField<int>(LocalBridgeClazz, "BODY_POSITION_STANDING_UP"); _BODY_POSITION_STANDING_UPReady = true; } return _BODY_POSITION_STANDING_UPContent; } }
            private static int _BODY_POSITION_STANDING_UPContent = default;
            private static bool _BODY_POSITION_STANDING_UPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.BodyPosition.html#BODY_POSITION_UNKNOWN"/>
            /// </summary>
            public static int BODY_POSITION_UNKNOWN { get { if (!_BODY_POSITION_UNKNOWNReady) { _BODY_POSITION_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "BODY_POSITION_UNKNOWN"); _BODY_POSITION_UNKNOWNReady = true; } return _BODY_POSITION_UNKNOWNContent; } }
            private static int _BODY_POSITION_UNKNOWNContent = default;
            private static bool _BODY_POSITION_UNKNOWNReady = false; // this is used because in case of generics 

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

        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,int,android.health.connect.datatypes.units.Pressure,android.health.connect.datatypes.units.Pressure,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Android.Health.Connect.Datatypes.Units.Pressure"/></param>
            /// <param name="arg4"><see cref="Android.Health.Connect.Datatypes.Units.Pressure"/></param>
            /// <param name="arg5"><see cref="int"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, int arg2, Android.Health.Connect.Datatypes.Units.Pressure arg3, Android.Health.Connect.Datatypes.Units.Pressure arg4, int arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BloodPressureRecord"/></returns>
            public Android.Health.Connect.Datatypes.BloodPressureRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BloodPressureRecord>("build", "()Landroid/health/connect/datatypes/BloodPressureRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BloodPressureRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.BloodPressureRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BloodPressureRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/BloodPressureRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodPressureRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BloodPressureRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.BloodPressureRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BloodPressureRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/BloodPressureRecord$Builder;", arg0);
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