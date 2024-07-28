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

namespace Android.Health.Connect.Datatypes
{
    #region IntermenstrualBleedingRecord
    public partial class IntermenstrualBleedingRecord
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

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/IntermenstrualBleedingRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/IntermenstrualBleedingRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord"/></returns>
            public Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord>("build", "()Landroid/health/connect/datatypes/IntermenstrualBleedingRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/IntermenstrualBleedingRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/IntermenstrualBleedingRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/IntermenstrualBleedingRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.IntermenstrualBleedingRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/IntermenstrualBleedingRecord$Builder;", arg0);
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