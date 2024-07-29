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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony.Euicc
{
    #region DownloadableSubscription
    public partial class DownloadableSubscription
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.html#forActivationCode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Telephony.Euicc.DownloadableSubscription"/></returns>
        public static Android.Telephony.Euicc.DownloadableSubscription ForActivationCode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Telephony.Euicc.DownloadableSubscription>(LocalBridgeClazz, "forActivationCode", "(Ljava/lang/String;)Landroid/telephony/euicc/DownloadableSubscription;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.html#getConfirmationCode()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetConfirmationCode()
        {
            return IExecuteWithSignature<Java.Lang.String>("getConfirmationCode", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.html#getEncodedActivationCode()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncodedActivationCode()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncodedActivationCode", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.Builder.html#%3Cinit%3E(android.telephony.euicc.DownloadableSubscription)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telephony.Euicc.DownloadableSubscription"/></param>
            public Builder(Android.Telephony.Euicc.DownloadableSubscription arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.Builder.html#%3Cinit%3E(java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.Euicc.DownloadableSubscription"/></returns>
            public Android.Telephony.Euicc.DownloadableSubscription Build()
            {
                return IExecuteWithSignature<Android.Telephony.Euicc.DownloadableSubscription>("build", "()Landroid/telephony/euicc/DownloadableSubscription;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.Builder.html#setConfirmationCode(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Telephony.Euicc.DownloadableSubscription.Builder"/></returns>
            public Android.Telephony.Euicc.DownloadableSubscription.Builder SetConfirmationCode(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Euicc.DownloadableSubscription.Builder>("setConfirmationCode", "(Ljava/lang/String;)Landroid/telephony/euicc/DownloadableSubscription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/euicc/DownloadableSubscription.Builder.html#setEncodedActivationCode(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Telephony.Euicc.DownloadableSubscription.Builder"/></returns>
            public Android.Telephony.Euicc.DownloadableSubscription.Builder SetEncodedActivationCode(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Euicc.DownloadableSubscription.Builder>("setEncodedActivationCode", "(Ljava/lang/String;)Landroid/telephony/euicc/DownloadableSubscription$Builder;", arg0);
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