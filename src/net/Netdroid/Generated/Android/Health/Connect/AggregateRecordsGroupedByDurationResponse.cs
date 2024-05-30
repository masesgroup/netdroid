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
    #region AggregateRecordsGroupedByDurationResponse
    public partial class AggregateRecordsGroupedByDurationResponse
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
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getEndTime()"/> 
        /// </summary>
        public Java.Time.Instant EndTime
        {
            get { return IExecuteWithSignature<Java.Time.Instant>("getEndTime", "()Ljava/time/Instant;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getStartTime()"/> 
        /// </summary>
        public Java.Time.Instant StartTime
        {
            get { return IExecuteWithSignature<Java.Time.Instant>("getStartTime", "()Ljava/time/Instant;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getZoneOffset(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetZoneOffset(Android.Health.Connect.Datatypes.AggregationType arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getZoneOffset", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#get(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Android.Health.Connect.Datatypes.AggregationType arg0)
        {
            return IExecuteWithSignature("get", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AggregateRecordsGroupedByDurationResponse<T>
    public partial class AggregateRecordsGroupedByDurationResponse<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Health.Connect.AggregateRecordsGroupedByDurationResponse{T}"/> to <see cref="Android.Health.Connect.AggregateRecordsGroupedByDurationResponse"/>
        /// </summary>
        public static implicit operator Android.Health.Connect.AggregateRecordsGroupedByDurationResponse(Android.Health.Connect.AggregateRecordsGroupedByDurationResponse<T> t) => t.Cast<Android.Health.Connect.AggregateRecordsGroupedByDurationResponse>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getEndTime()"/> 
        /// </summary>
        public Java.Time.Instant EndTime
        {
            get { return IExecuteWithSignature<Java.Time.Instant>("getEndTime", "()Ljava/time/Instant;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getStartTime()"/> 
        /// </summary>
        public Java.Time.Instant StartTime
        {
            get { return IExecuteWithSignature<Java.Time.Instant>("getStartTime", "()Ljava/time/Instant;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#getZoneOffset(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetZoneOffset(Android.Health.Connect.Datatypes.AggregationType<T> arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getZoneOffset", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/AggregateRecordsGroupedByDurationResponse.html#get(android.health.connect.datatypes.AggregationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.AggregationType"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Get(Android.Health.Connect.Datatypes.AggregationType<T> arg0)
        {
            return IExecuteWithSignature<T>("get", "(Landroid/health/connect/datatypes/AggregationType;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}