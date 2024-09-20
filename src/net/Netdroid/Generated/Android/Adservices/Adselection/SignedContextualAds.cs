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

namespace Android.Adservices.Adselection
{
    #region SignedContextualAds
    public partial class SignedContextualAds
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#getBuyer()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdTechIdentifier"/></returns>
        public Android.Adservices.Common.AdTechIdentifier GetBuyer()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdTechIdentifier>("getBuyer", "()Landroid/adservices/common/AdTechIdentifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#getDecisionLogicUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetDecisionLogicUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getDecisionLogicUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#getSignature()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSignature()
        {
            return IExecuteWithSignatureArray<byte>("getSignature", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#getAdsWithBid()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Adselection.AdWithBid> GetAdsWithBid()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Adselection.AdWithBid>>("getAdsWithBid", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.Builder.html#%3Cinit%3E(android.adservices.adselection.SignedContextualAds)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Adselection.SignedContextualAds"/></param>
            public Builder(Android.Adservices.Adselection.SignedContextualAds arg0)
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
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Adselection.SignedContextualAds"/></returns>
            public Android.Adservices.Adselection.SignedContextualAds Build()
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.SignedContextualAds>("build", "()Landroid/adservices/adselection/SignedContextualAds;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.Builder.html#setAdsWithBid(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.SignedContextualAds.Builder"/></returns>
            public Android.Adservices.Adselection.SignedContextualAds.Builder SetAdsWithBid(Java.Util.List<Android.Adservices.Adselection.AdWithBid> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.SignedContextualAds.Builder>("setAdsWithBid", "(Ljava/util/List;)Landroid/adservices/adselection/SignedContextualAds$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.Builder.html#setBuyer(android.adservices.common.AdTechIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.SignedContextualAds.Builder"/></returns>
            public Android.Adservices.Adselection.SignedContextualAds.Builder SetBuyer(Android.Adservices.Common.AdTechIdentifier arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.SignedContextualAds.Builder>("setBuyer", "(Landroid/adservices/common/AdTechIdentifier;)Landroid/adservices/adselection/SignedContextualAds$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.Builder.html#setDecisionLogicUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.SignedContextualAds.Builder"/></returns>
            public Android.Adservices.Adselection.SignedContextualAds.Builder SetDecisionLogicUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.SignedContextualAds.Builder>("setDecisionLogicUri", "(Landroid/net/Uri;)Landroid/adservices/adselection/SignedContextualAds$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/adselection/SignedContextualAds.Builder.html#setSignature(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Adservices.Adselection.SignedContextualAds.Builder"/></returns>
            public Android.Adservices.Adselection.SignedContextualAds.Builder SetSignature(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Adselection.SignedContextualAds.Builder>("setSignature", "([B)Landroid/adservices/adselection/SignedContextualAds$Builder;", new object[] { arg0 });
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