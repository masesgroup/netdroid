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

namespace Android.App.Appsearch
{
    #region RemoveByDocumentIdRequest
    public partial class RemoveByDocumentIdRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.html#getNamespace()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespace()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespace", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.html#getIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getIds", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.Builder.html#%3Cinit%3E(java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.RemoveByDocumentIdRequest"/></returns>
            public Android.App.Appsearch.RemoveByDocumentIdRequest Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.RemoveByDocumentIdRequest>("build", "()Landroid/app/appsearch/RemoveByDocumentIdRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.Builder.html#addIds(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.RemoveByDocumentIdRequest.Builder"/></returns>
            public Android.App.Appsearch.RemoveByDocumentIdRequest.Builder AddIds(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.RemoveByDocumentIdRequest.Builder>("addIds", "([Ljava/lang/String;)Landroid/app/appsearch/RemoveByDocumentIdRequest$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.RemoveByDocumentIdRequest.Builder>("addIds", "([Ljava/lang/String;)Landroid/app/appsearch/RemoveByDocumentIdRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/RemoveByDocumentIdRequest.Builder.html#addIds(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.RemoveByDocumentIdRequest.Builder"/></returns>
            public Android.App.Appsearch.RemoveByDocumentIdRequest.Builder AddIds(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.RemoveByDocumentIdRequest.Builder>("addIds", "(Ljava/util/Collection;)Landroid/app/appsearch/RemoveByDocumentIdRequest$Builder;", arg0);
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