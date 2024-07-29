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
    #region TotalCaloriesBurnedRecord
    public partial class TotalCaloriesBurnedRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.html#ENERGY_TOTAL"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType ENERGY_TOTAL { get { if (!_ENERGY_TOTALReady) { _ENERGY_TOTALContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "ENERGY_TOTAL"); _ENERGY_TOTALReady = true; } return _ENERGY_TOTALContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _ENERGY_TOTALContent = default;
        private static bool _ENERGY_TOTALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.html#getEnergy()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Energy"/></returns>
        public Android.Health.Connect.Datatypes.Units.Energy GetEnergy()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Energy>("getEnergy", "()Landroid/health/connect/datatypes/units/Energy;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,java.time.Instant,android.health.connect.datatypes.units.Energy)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg3"><see cref="Android.Health.Connect.Datatypes.Units.Energy"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Java.Time.Instant arg2, Android.Health.Connect.Datatypes.Units.Energy arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord"/></returns>
            public Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord>("build", "()Landroid/health/connect/datatypes/TotalCaloriesBurnedRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.Builder.html#clearEndZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder ClearEndZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder>("clearEndZoneOffset", "()Landroid/health/connect/datatypes/TotalCaloriesBurnedRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.Builder.html#clearStartZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder ClearStartZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder>("clearStartZoneOffset", "()Landroid/health/connect/datatypes/TotalCaloriesBurnedRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.Builder.html#setEndZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder SetEndZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder>("setEndZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/TotalCaloriesBurnedRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/TotalCaloriesBurnedRecord.Builder.html#setStartZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder SetStartZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.TotalCaloriesBurnedRecord.Builder>("setStartZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/TotalCaloriesBurnedRecord$Builder;", arg0);
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