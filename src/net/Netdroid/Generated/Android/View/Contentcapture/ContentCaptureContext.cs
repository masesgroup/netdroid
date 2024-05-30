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

namespace Android.View.Contentcapture
{
    #region ContentCaptureContext
    public partial class ContentCaptureContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.html#forLocusId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.View.Contentcapture.ContentCaptureContext"/></returns>
        public static Android.View.Contentcapture.ContentCaptureContext ForLocusId(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.View.Contentcapture.ContentCaptureContext>(LocalBridgeClazz, "forLocusId", "(Ljava/lang/String;)Landroid/view/contentcapture/ContentCaptureContext;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.html#getExtras()"/> 
        /// </summary>
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.html#getLocusId()"/> 
        /// </summary>
        public Android.Content.LocusId LocusId
        {
            get { return IExecuteWithSignature<Android.Content.LocusId>("getLocusId", "()Landroid/content/LocusId;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.Builder.html#%3Cinit%3E(android.content.LocusId)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.LocusId"/></param>
            public Builder(Android.Content.LocusId arg0)
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
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Contentcapture.ContentCaptureContext"/></returns>
            public Android.View.Contentcapture.ContentCaptureContext Build()
            {
                return IExecuteWithSignature<Android.View.Contentcapture.ContentCaptureContext>("build", "()Landroid/view/contentcapture/ContentCaptureContext;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/ContentCaptureContext.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.View.Contentcapture.ContentCaptureContext.Builder"/></returns>
            public Android.View.Contentcapture.ContentCaptureContext.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.View.Contentcapture.ContentCaptureContext.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/view/contentcapture/ContentCaptureContext$Builder;", arg0);
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