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

namespace Android.Health.Connect.Datatypes
{
    #region FloorsClimbedRecord
    public partial class FloorsClimbedRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.html#FLOORS_CLIMBED_TOTAL"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType FLOORS_CLIMBED_TOTAL { get { if (!_FLOORS_CLIMBED_TOTALReady) { _FLOORS_CLIMBED_TOTALContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "FLOORS_CLIMBED_TOTAL"); _FLOORS_CLIMBED_TOTALReady = true; } return _FLOORS_CLIMBED_TOTALContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _FLOORS_CLIMBED_TOTALContent = default;
        private static bool _FLOORS_CLIMBED_TOTALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.html#getFloors()"/> 
        /// </summary>
        public double Floors
        {
            get { return IExecuteWithSignature<double>("getFloors", "()D"); }
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,java.time.Instant,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Java.Time.Instant arg2, double arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.FloorsClimbedRecord"/></returns>
            public Android.Health.Connect.Datatypes.FloorsClimbedRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.FloorsClimbedRecord>("build", "()Landroid/health/connect/datatypes/FloorsClimbedRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.Builder.html#clearEndZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder ClearEndZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder>("clearEndZoneOffset", "()Landroid/health/connect/datatypes/FloorsClimbedRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.Builder.html#clearStartZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder ClearStartZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder>("clearStartZoneOffset", "()Landroid/health/connect/datatypes/FloorsClimbedRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.Builder.html#setEndZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder SetEndZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder>("setEndZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/FloorsClimbedRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/FloorsClimbedRecord.Builder.html#setStartZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder SetStartZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.FloorsClimbedRecord.Builder>("setStartZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/FloorsClimbedRecord$Builder;", arg0);
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