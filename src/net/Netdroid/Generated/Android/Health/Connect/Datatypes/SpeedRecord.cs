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
    #region SpeedRecord
    public partial class SpeedRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.html#SPEED_AVG"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SPEED_AVG { get { if (!_SPEED_AVGReady) { _SPEED_AVGContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SPEED_AVG"); _SPEED_AVGReady = true; } return _SPEED_AVGContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SPEED_AVGContent = default;
        private static bool _SPEED_AVGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.html#SPEED_MAX"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SPEED_MAX { get { if (!_SPEED_MAXReady) { _SPEED_MAXContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SPEED_MAX"); _SPEED_MAXReady = true; } return _SPEED_MAXContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SPEED_MAXContent = default;
        private static bool _SPEED_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.html#SPEED_MIN"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SPEED_MIN { get { if (!_SPEED_MINReady) { _SPEED_MINContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SPEED_MIN"); _SPEED_MINReady = true; } return _SPEED_MINContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SPEED_MINContent = default;
        private static bool _SPEED_MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.html#getSamples()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.Datatypes.SpeedRecord.SpeedRecordSample> GetSamples()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.SpeedRecord.SpeedRecordSample>>("getSamples", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,java.time.Instant,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg3"><see cref="Java.Util.List"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Java.Time.Instant arg2, Java.Util.List<Android.Health.Connect.Datatypes.SpeedRecord.SpeedRecordSample> arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SpeedRecord"/></returns>
            public Android.Health.Connect.Datatypes.SpeedRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SpeedRecord>("build", "()Landroid/health/connect/datatypes/SpeedRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.Builder.html#clearEndZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SpeedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SpeedRecord.Builder ClearEndZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SpeedRecord.Builder>("clearEndZoneOffset", "()Landroid/health/connect/datatypes/SpeedRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.Builder.html#clearStartZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SpeedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SpeedRecord.Builder ClearStartZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SpeedRecord.Builder>("clearStartZoneOffset", "()Landroid/health/connect/datatypes/SpeedRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.Builder.html#setEndZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SpeedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SpeedRecord.Builder SetEndZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SpeedRecord.Builder>("setEndZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/SpeedRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.Builder.html#setStartZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SpeedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SpeedRecord.Builder SetStartZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SpeedRecord.Builder>("setStartZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/SpeedRecord$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SpeedRecordSample
        public partial class SpeedRecordSample
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.SpeedRecordSample.html#%3Cinit%3E(android.health.connect.datatypes.units.Velocity,java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Velocity"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            public SpeedRecordSample(Android.Health.Connect.Datatypes.Units.Velocity arg0, Java.Time.Instant arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.SpeedRecordSample.html#getSpeed()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Velocity"/></returns>
            public Android.Health.Connect.Datatypes.Units.Velocity GetSpeed()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Velocity>("getSpeed", "()Landroid/health/connect/datatypes/units/Velocity;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.SpeedRecordSample.html#getTime()"/>
            /// </summary>
            /// <returns><see cref="Java.Time.Instant"/></returns>
            public Java.Time.Instant GetTime()
            {
                return IExecuteWithSignature<Java.Time.Instant>("getTime", "()Ljava/time/Instant;");
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