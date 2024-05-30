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
    #region SpeedRecord
    public partial class SpeedRecord
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.html#getSamples()"/> 
        /// </summary>
        public Java.Util.List<Android.Health.Connect.Datatypes.SpeedRecord.SpeedRecordSample> Samples
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.SpeedRecord.SpeedRecordSample>>("getSamples", "()Ljava/util/List;"); }
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
            public Android.Health.Connect.Datatypes.Units.Velocity Speed
            {
                get { return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Velocity>("getSpeed", "()Landroid/health/connect/datatypes/units/Velocity;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SpeedRecord.SpeedRecordSample.html#getTime()"/> 
            /// </summary>
            public Java.Time.Instant Time
            {
                get { return IExecuteWithSignature<Java.Time.Instant>("getTime", "()Ljava/time/Instant;"); }
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