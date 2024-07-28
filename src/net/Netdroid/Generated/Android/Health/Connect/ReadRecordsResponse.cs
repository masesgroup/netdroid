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
    #region ReadRecordsResponse
    public partial class ReadRecordsResponse
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
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsResponse.html#getRecords()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List GetRecords()
        {
            return IExecuteWithSignature<Java.Util.List>("getRecords", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsResponse.html#getNextPageToken()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetNextPageToken()
        {
            return IExecuteWithSignature<long>("getNextPageToken", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ReadRecordsResponse<T>
    public partial class ReadRecordsResponse<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Health.Connect.ReadRecordsResponse{T}"/> to <see cref="Android.Health.Connect.ReadRecordsResponse"/>
        /// </summary>
        public static implicit operator Android.Health.Connect.ReadRecordsResponse(Android.Health.Connect.ReadRecordsResponse<T> t) => t.Cast<Android.Health.Connect.ReadRecordsResponse>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsResponse.html#getRecords()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetRecords()
        {
            return IExecuteWithSignature<Java.Util.List<T>>("getRecords", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsResponse.html#getNextPageToken()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetNextPageToken()
        {
            return IExecuteWithSignature<long>("getNextPageToken", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}