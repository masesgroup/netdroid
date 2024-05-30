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

namespace Android.Health.Connect
{
    #region LocalTimeRangeFilter
    public partial class LocalTimeRangeFilter
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
        /// <see href="https://developer.android.com/reference/android/health/connect/LocalTimeRangeFilter.html#getEndTime()"/> 
        /// </summary>
        public Java.Time.LocalDateTime EndTime
        {
            get { return IExecuteWithSignature<Java.Time.LocalDateTime>("getEndTime", "()Ljava/time/LocalDateTime;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/LocalTimeRangeFilter.html#getStartTime()"/> 
        /// </summary>
        public Java.Time.LocalDateTime StartTime
        {
            get { return IExecuteWithSignature<Java.Time.LocalDateTime>("getStartTime", "()Ljava/time/LocalDateTime;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/LocalTimeRangeFilter.html#isBounded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBounded()
        {
            return IExecuteWithSignature<bool>("isBounded", "()Z");
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
            /// <see href="https://developer.android.com/reference/android/health/connect/LocalTimeRangeFilter.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.LocalTimeRangeFilter"/></returns>
            public Android.Health.Connect.LocalTimeRangeFilter Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.LocalTimeRangeFilter>("build", "()Landroid/health/connect/LocalTimeRangeFilter;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/LocalTimeRangeFilter.Builder.html#setEndTime(java.time.LocalDateTime)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
            /// <returns><see cref="Android.Health.Connect.LocalTimeRangeFilter.Builder"/></returns>
            public Android.Health.Connect.LocalTimeRangeFilter.Builder SetEndTime(Java.Time.LocalDateTime arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.LocalTimeRangeFilter.Builder>("setEndTime", "(Ljava/time/LocalDateTime;)Landroid/health/connect/LocalTimeRangeFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/LocalTimeRangeFilter.Builder.html#setStartTime(java.time.LocalDateTime)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
            /// <returns><see cref="Android.Health.Connect.LocalTimeRangeFilter.Builder"/></returns>
            public Android.Health.Connect.LocalTimeRangeFilter.Builder SetStartTime(Java.Time.LocalDateTime arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.LocalTimeRangeFilter.Builder>("setStartTime", "(Ljava/time/LocalDateTime;)Landroid/health/connect/LocalTimeRangeFilter$Builder;", arg0);
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