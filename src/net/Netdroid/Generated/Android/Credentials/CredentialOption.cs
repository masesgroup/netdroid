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

namespace Android.Credentials
{
    #region CredentialOption
    public partial class CredentialOption
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#SUPPORTED_ELEMENT_KEYS"/>
        /// </summary>
        public static Java.Lang.String SUPPORTED_ELEMENT_KEYS { get { if (!_SUPPORTED_ELEMENT_KEYSReady) { _SUPPORTED_ELEMENT_KEYSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUPPORTED_ELEMENT_KEYS"); _SUPPORTED_ELEMENT_KEYSReady = true; } return _SUPPORTED_ELEMENT_KEYSContent; } }
        private static Java.Lang.String _SUPPORTED_ELEMENT_KEYSContent = default;
        private static bool _SUPPORTED_ELEMENT_KEYSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#getCandidateQueryData()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetCandidateQueryData()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getCandidateQueryData", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#getCredentialRetrievalData()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetCredentialRetrievalData()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getCredentialRetrievalData", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#isSystemProviderRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSystemProviderRequired()
        {
            return IExecuteWithSignature<bool>("isSystemProviderRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#getAllowedProviders()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Content.ComponentName> GetAllowedProviders()
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Content.ComponentName>>("getAllowedProviders", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.Builder.html#%3Cinit%3E(java.lang.String,android.os.Bundle,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public Builder(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.Os.Bundle arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Credentials.CredentialOption"/></returns>
            public Android.Credentials.CredentialOption Build()
            {
                return IExecuteWithSignature<Android.Credentials.CredentialOption>("build", "()Landroid/credentials/CredentialOption;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.Builder.html#addAllowedProvider(android.content.ComponentName)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
            /// <returns><see cref="Android.Credentials.CredentialOption.Builder"/></returns>
            public Android.Credentials.CredentialOption.Builder AddAllowedProvider(Android.Content.ComponentName arg0)
            {
                return IExecuteWithSignature<Android.Credentials.CredentialOption.Builder>("addAllowedProvider", "(Landroid/content/ComponentName;)Landroid/credentials/CredentialOption$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.Builder.html#setAllowedProviders(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Credentials.CredentialOption.Builder"/></returns>
            public Android.Credentials.CredentialOption.Builder SetAllowedProviders(Java.Util.Set<Android.Content.ComponentName> arg0)
            {
                return IExecuteWithSignature<Android.Credentials.CredentialOption.Builder>("setAllowedProviders", "(Ljava/util/Set;)Landroid/credentials/CredentialOption$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/credentials/CredentialOption.Builder.html#setIsSystemProviderRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Credentials.CredentialOption.Builder"/></returns>
            public Android.Credentials.CredentialOption.Builder SetIsSystemProviderRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Credentials.CredentialOption.Builder>("setIsSystemProviderRequired", "(Z)Landroid/credentials/CredentialOption$Builder;", arg0);
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