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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Print
{
    #region PrintDocumentInfo
    public partial class PrintDocumentInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#CONTENT_TYPE_DOCUMENT"/>
        /// </summary>
        public static int CONTENT_TYPE_DOCUMENT { get { if (!_CONTENT_TYPE_DOCUMENTReady) { _CONTENT_TYPE_DOCUMENTContent = SGetField<int>(LocalBridgeClazz, "CONTENT_TYPE_DOCUMENT"); _CONTENT_TYPE_DOCUMENTReady = true; } return _CONTENT_TYPE_DOCUMENTContent; } }
        private static int _CONTENT_TYPE_DOCUMENTContent = default;
        private static bool _CONTENT_TYPE_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#CONTENT_TYPE_PHOTO"/>
        /// </summary>
        public static int CONTENT_TYPE_PHOTO { get { if (!_CONTENT_TYPE_PHOTOReady) { _CONTENT_TYPE_PHOTOContent = SGetField<int>(LocalBridgeClazz, "CONTENT_TYPE_PHOTO"); _CONTENT_TYPE_PHOTOReady = true; } return _CONTENT_TYPE_PHOTOContent; } }
        private static int _CONTENT_TYPE_PHOTOContent = default;
        private static bool _CONTENT_TYPE_PHOTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#CONTENT_TYPE_UNKNOWN"/>
        /// </summary>
        public static int CONTENT_TYPE_UNKNOWN { get { if (!_CONTENT_TYPE_UNKNOWNReady) { _CONTENT_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CONTENT_TYPE_UNKNOWN"); _CONTENT_TYPE_UNKNOWNReady = true; } return _CONTENT_TYPE_UNKNOWNContent; } }
        private static int _CONTENT_TYPE_UNKNOWNContent = default;
        private static bool _CONTENT_TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#PAGE_COUNT_UNKNOWN"/>
        /// </summary>
        public static int PAGE_COUNT_UNKNOWN { get { if (!_PAGE_COUNT_UNKNOWNReady) { _PAGE_COUNT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "PAGE_COUNT_UNKNOWN"); _PAGE_COUNT_UNKNOWNReady = true; } return _PAGE_COUNT_UNKNOWNContent; } }
        private static int _PAGE_COUNT_UNKNOWNContent = default;
        private static bool _PAGE_COUNT_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#getContentType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetContentType()
        {
            return IExecuteWithSignature<int>("getContentType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#getPageCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPageCount()
        {
            return IExecuteWithSignature<int>("getPageCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#getDataSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDataSize()
        {
            return IExecuteWithSignature<long>("getDataSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.Builder.html#%3Cinit%3E(java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Print.PrintDocumentInfo"/></returns>
            public Android.Print.PrintDocumentInfo Build()
            {
                return IExecuteWithSignature<Android.Print.PrintDocumentInfo>("build", "()Landroid/print/PrintDocumentInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.Builder.html#setContentType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Print.PrintDocumentInfo.Builder"/></returns>
            public Android.Print.PrintDocumentInfo.Builder SetContentType(int arg0)
            {
                return IExecuteWithSignature<Android.Print.PrintDocumentInfo.Builder>("setContentType", "(I)Landroid/print/PrintDocumentInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/print/PrintDocumentInfo.Builder.html#setPageCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Print.PrintDocumentInfo.Builder"/></returns>
            public Android.Print.PrintDocumentInfo.Builder SetPageCount(int arg0)
            {
                return IExecuteWithSignature<Android.Print.PrintDocumentInfo.Builder>("setPageCount", "(I)Landroid/print/PrintDocumentInfo$Builder;", arg0);
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