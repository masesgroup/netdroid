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

namespace Android.Media.Tv
{
    #region BroadcastInfoResponse
    public partial class BroadcastInfoResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#RESPONSE_RESULT_CANCEL"/>
        /// </summary>
        public static int RESPONSE_RESULT_CANCEL { get { if (!_RESPONSE_RESULT_CANCELReady) { _RESPONSE_RESULT_CANCELContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_RESULT_CANCEL"); _RESPONSE_RESULT_CANCELReady = true; } return _RESPONSE_RESULT_CANCELContent; } }
        private static int _RESPONSE_RESULT_CANCELContent = default;
        private static bool _RESPONSE_RESULT_CANCELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#RESPONSE_RESULT_ERROR"/>
        /// </summary>
        public static int RESPONSE_RESULT_ERROR { get { if (!_RESPONSE_RESULT_ERRORReady) { _RESPONSE_RESULT_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_RESULT_ERROR"); _RESPONSE_RESULT_ERRORReady = true; } return _RESPONSE_RESULT_ERRORContent; } }
        private static int _RESPONSE_RESULT_ERRORContent = default;
        private static bool _RESPONSE_RESULT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#RESPONSE_RESULT_OK"/>
        /// </summary>
        public static int RESPONSE_RESULT_OK { get { if (!_RESPONSE_RESULT_OKReady) { _RESPONSE_RESULT_OKContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_RESULT_OK"); _RESPONSE_RESULT_OKReady = true; } return _RESPONSE_RESULT_OKContent; } }
        private static int _RESPONSE_RESULT_OKContent = default;
        private static bool _RESPONSE_RESULT_OKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#getRequestId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRequestId()
        {
            return IExecuteWithSignature<int>("getRequestId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#getResponseResult()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResponseResult()
        {
            return IExecuteWithSignature<int>("getResponseResult", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#getSequence()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSequence()
        {
            return IExecuteWithSignature<int>("getSequence", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/BroadcastInfoResponse.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}