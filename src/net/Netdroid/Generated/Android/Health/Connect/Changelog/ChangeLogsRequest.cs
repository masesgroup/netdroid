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

namespace Android.Health.Connect.Changelog
{
    #region ChangeLogsRequest
    public partial class ChangeLogsRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.html#getPageSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPageSize()
        {
            return IExecuteWithSignature<int>("getPageSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.html#getToken()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetToken()
        {
            return IExecuteWithSignature<Java.Lang.String>("getToken", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Changelog.ChangeLogsRequest"/></returns>
            public Android.Health.Connect.Changelog.ChangeLogsRequest Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Changelog.ChangeLogsRequest>("build", "()Landroid/health/connect/changelog/ChangeLogsRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsRequest.Builder.html#setPageSize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Health.Connect.Changelog.ChangeLogsRequest.Builder"/></returns>
            public Android.Health.Connect.Changelog.ChangeLogsRequest.Builder SetPageSize(int arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Changelog.ChangeLogsRequest.Builder>("setPageSize", "(I)Landroid/health/connect/changelog/ChangeLogsRequest$Builder;", arg0);
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