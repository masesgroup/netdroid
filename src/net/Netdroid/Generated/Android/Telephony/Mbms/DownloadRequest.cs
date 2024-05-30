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

namespace Android.Telephony.Mbms
{
    #region DownloadRequest
    public partial class DownloadRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#getMaxAppIntentSize()"/> 
        /// </summary>
        public static int MaxAppIntentSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxAppIntentSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#getMaxDestinationUriSize()"/> 
        /// </summary>
        public static int MaxDestinationUriSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxDestinationUriSize", "()I"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#getDestinationUri()"/> 
        /// </summary>
        public Android.Net.Uri DestinationUri
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getDestinationUri", "()Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#getFileServiceId()"/> 
        /// </summary>
        public Java.Lang.String FileServiceId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFileServiceId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#getSourceUri()"/> 
        /// </summary>
        public Android.Net.Uri SourceUri
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getSourceUri", "()Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#getSubscriptionId()"/> 
        /// </summary>
        public int SubscriptionId
        {
            get { return IExecuteWithSignature<int>("getSubscriptionId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#toByteArray()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] ToByteArray()
        {
            return IExecuteWithSignatureArray<byte>("toByteArray", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#%3Cinit%3E(android.net.Uri,android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            public Builder(Android.Net.Uri arg0, Android.Net.Uri arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#fromDownloadRequest(android.telephony.mbms.DownloadRequest)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telephony.Mbms.DownloadRequest"/></param>
            /// <returns><see cref="Android.Telephony.Mbms.DownloadRequest.Builder"/></returns>
            public static Android.Telephony.Mbms.DownloadRequest.Builder FromDownloadRequest(Android.Telephony.Mbms.DownloadRequest arg0)
            {
                return SExecuteWithSignature<Android.Telephony.Mbms.DownloadRequest.Builder>(LocalBridgeClazz, "fromDownloadRequest", "(Landroid/telephony/mbms/DownloadRequest;)Landroid/telephony/mbms/DownloadRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#fromSerializedRequest(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Telephony.Mbms.DownloadRequest.Builder"/></returns>
            public static Android.Telephony.Mbms.DownloadRequest.Builder FromSerializedRequest(byte[] arg0)
            {
                return SExecuteWithSignature<Android.Telephony.Mbms.DownloadRequest.Builder>(LocalBridgeClazz, "fromSerializedRequest", "([B)Landroid/telephony/mbms/DownloadRequest$Builder;", new object[] { arg0 });
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.Mbms.DownloadRequest"/></returns>
            public Android.Telephony.Mbms.DownloadRequest Build()
            {
                return IExecuteWithSignature<Android.Telephony.Mbms.DownloadRequest>("build", "()Landroid/telephony/mbms/DownloadRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#setAppIntent(android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="Android.Telephony.Mbms.DownloadRequest.Builder"/></returns>
            public Android.Telephony.Mbms.DownloadRequest.Builder SetAppIntent(Android.Content.Intent arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Mbms.DownloadRequest.Builder>("setAppIntent", "(Landroid/content/Intent;)Landroid/telephony/mbms/DownloadRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#setServiceInfo(android.telephony.mbms.FileServiceInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telephony.Mbms.FileServiceInfo"/></param>
            /// <returns><see cref="Android.Telephony.Mbms.DownloadRequest.Builder"/></returns>
            public Android.Telephony.Mbms.DownloadRequest.Builder SetServiceInfo(Android.Telephony.Mbms.FileServiceInfo arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Mbms.DownloadRequest.Builder>("setServiceInfo", "(Landroid/telephony/mbms/FileServiceInfo;)Landroid/telephony/mbms/DownloadRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/mbms/DownloadRequest.Builder.html#setSubscriptionId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.Mbms.DownloadRequest.Builder"/></returns>
            public Android.Telephony.Mbms.DownloadRequest.Builder SetSubscriptionId(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Mbms.DownloadRequest.Builder>("setSubscriptionId", "(I)Landroid/telephony/mbms/DownloadRequest$Builder;", arg0);
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