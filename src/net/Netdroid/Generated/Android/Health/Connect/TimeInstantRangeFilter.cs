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

namespace Android.Health.Connect
{
    #region TimeInstantRangeFilter
    public partial class TimeInstantRangeFilter
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
        /// <see href="https://developer.android.com/reference/android/health/connect/TimeInstantRangeFilter.html#isBounded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBounded()
        {
            return IExecuteWithSignature<bool>("isBounded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/TimeInstantRangeFilter.html#getEndTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetEndTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getEndTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/TimeInstantRangeFilter.html#getStartTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetStartTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getStartTime", "()Ljava/time/Instant;");
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
            /// <see href="https://developer.android.com/reference/android/health/connect/TimeInstantRangeFilter.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.TimeInstantRangeFilter"/></returns>
            public Android.Health.Connect.TimeInstantRangeFilter Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.TimeInstantRangeFilter>("build", "()Landroid/health/connect/TimeInstantRangeFilter;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/TimeInstantRangeFilter.Builder.html#setEndTime(java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Health.Connect.TimeInstantRangeFilter.Builder"/></returns>
            public Android.Health.Connect.TimeInstantRangeFilter.Builder SetEndTime(Java.Time.Instant arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.TimeInstantRangeFilter.Builder>("setEndTime", "(Ljava/time/Instant;)Landroid/health/connect/TimeInstantRangeFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/TimeInstantRangeFilter.Builder.html#setStartTime(java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Health.Connect.TimeInstantRangeFilter.Builder"/></returns>
            public Android.Health.Connect.TimeInstantRangeFilter.Builder SetStartTime(Java.Time.Instant arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.TimeInstantRangeFilter.Builder>("setStartTime", "(Ljava/time/Instant;)Landroid/health/connect/TimeInstantRangeFilter$Builder;", arg0);
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