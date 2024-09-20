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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Appsearch
{
    #region StorageInfo
    public partial class StorageInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.html#getAliveDocumentsCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAliveDocumentsCount()
        {
            return IExecuteWithSignature<int>("getAliveDocumentsCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.html#getAliveNamespacesCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAliveNamespacesCount()
        {
            return IExecuteWithSignature<int>("getAliveNamespacesCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.html#getSizeBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSizeBytes()
        {
            return IExecuteWithSignature<long>("getSizeBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.StorageInfo"/></returns>
            public Android.App.Appsearch.StorageInfo Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.StorageInfo>("build", "()Landroid/app/appsearch/StorageInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.Builder.html#setAliveDocumentsCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Appsearch.StorageInfo.Builder"/></returns>
            public Android.App.Appsearch.StorageInfo.Builder SetAliveDocumentsCount(int arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.StorageInfo.Builder>("setAliveDocumentsCount", "(I)Landroid/app/appsearch/StorageInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.Builder.html#setAliveNamespacesCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Appsearch.StorageInfo.Builder"/></returns>
            public Android.App.Appsearch.StorageInfo.Builder SetAliveNamespacesCount(int arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.StorageInfo.Builder>("setAliveNamespacesCount", "(I)Landroid/app/appsearch/StorageInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/StorageInfo.Builder.html#setSizeBytes(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.App.Appsearch.StorageInfo.Builder"/></returns>
            public Android.App.Appsearch.StorageInfo.Builder SetSizeBytes(long arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.StorageInfo.Builder>("setSizeBytes", "(J)Landroid/app/appsearch/StorageInfo$Builder;", arg0);
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