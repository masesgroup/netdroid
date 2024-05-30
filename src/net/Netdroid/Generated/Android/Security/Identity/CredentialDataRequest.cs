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

namespace Android.Security.Identity
{
    #region CredentialDataRequest
    public partial class CredentialDataRequest
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
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#getDeviceSignedEntriesToRequest()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>> DeviceSignedEntriesToRequest
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>>>("getDeviceSignedEntriesToRequest", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#getIssuerSignedEntriesToRequest()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>> IssuerSignedEntriesToRequest
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>>>("getIssuerSignedEntriesToRequest", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#getReaderSignature()"/> 
        /// </summary>
        public byte[] ReaderSignature
        {
            get { return IExecuteWithSignatureArray<byte>("getReaderSignature", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#getRequestMessage()"/> 
        /// </summary>
        public byte[] RequestMessage
        {
            get { return IExecuteWithSignatureArray<byte>("getRequestMessage", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#isAllowUsingExhaustedKeys()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllowUsingExhaustedKeys()
        {
            return IExecuteWithSignature<bool>("isAllowUsingExhaustedKeys", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#isAllowUsingExpiredKeys()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllowUsingExpiredKeys()
        {
            return IExecuteWithSignature<bool>("isAllowUsingExpiredKeys", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.html#isIncrementUseCount()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIncrementUseCount()
        {
            return IExecuteWithSignature<bool>("isIncrementUseCount", "()Z");
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
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest"/></returns>
            public Android.Security.Identity.CredentialDataRequest Build()
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest>("build", "()Landroid/security/identity/CredentialDataRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setAllowUsingExhaustedKeys(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetAllowUsingExhaustedKeys(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setAllowUsingExhaustedKeys", "(Z)Landroid/security/identity/CredentialDataRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setAllowUsingExpiredKeys(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetAllowUsingExpiredKeys(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setAllowUsingExpiredKeys", "(Z)Landroid/security/identity/CredentialDataRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setDeviceSignedEntriesToRequest(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetDeviceSignedEntriesToRequest(Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>> arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setDeviceSignedEntriesToRequest", "(Ljava/util/Map;)Landroid/security/identity/CredentialDataRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setIncrementUseCount(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetIncrementUseCount(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setIncrementUseCount", "(Z)Landroid/security/identity/CredentialDataRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setIssuerSignedEntriesToRequest(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetIssuerSignedEntriesToRequest(Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>> arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setIssuerSignedEntriesToRequest", "(Ljava/util/Map;)Landroid/security/identity/CredentialDataRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setReaderSignature(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetReaderSignature(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setReaderSignature", "([B)Landroid/security/identity/CredentialDataRequest$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/identity/CredentialDataRequest.Builder.html#setRequestMessage(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Security.Identity.CredentialDataRequest.Builder"/></returns>
            public Android.Security.Identity.CredentialDataRequest.Builder SetRequestMessage(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Security.Identity.CredentialDataRequest.Builder>("setRequestMessage", "([B)Landroid/security/identity/CredentialDataRequest$Builder;", new object[] { arg0 });
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