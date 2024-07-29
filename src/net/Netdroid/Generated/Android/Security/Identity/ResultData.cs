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

namespace Android.Security.Identity
{
    #region ResultData
    public partial class ResultData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_NO_ACCESS_CONTROL_PROFILES"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_NO_ACCESS_CONTROL_PROFILES { get { if (!_STATUS_NO_ACCESS_CONTROL_PROFILESReady) { _STATUS_NO_ACCESS_CONTROL_PROFILESContent = SGetField<int>(LocalBridgeClazz, "STATUS_NO_ACCESS_CONTROL_PROFILES"); _STATUS_NO_ACCESS_CONTROL_PROFILESReady = true; } return _STATUS_NO_ACCESS_CONTROL_PROFILESContent; } }
        private static int _STATUS_NO_ACCESS_CONTROL_PROFILESContent = default;
        private static bool _STATUS_NO_ACCESS_CONTROL_PROFILESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_NO_SUCH_ENTRY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_NO_SUCH_ENTRY { get { if (!_STATUS_NO_SUCH_ENTRYReady) { _STATUS_NO_SUCH_ENTRYContent = SGetField<int>(LocalBridgeClazz, "STATUS_NO_SUCH_ENTRY"); _STATUS_NO_SUCH_ENTRYReady = true; } return _STATUS_NO_SUCH_ENTRYContent; } }
        private static int _STATUS_NO_SUCH_ENTRYContent = default;
        private static bool _STATUS_NO_SUCH_ENTRYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_NOT_IN_REQUEST_MESSAGE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_NOT_IN_REQUEST_MESSAGE { get { if (!_STATUS_NOT_IN_REQUEST_MESSAGEReady) { _STATUS_NOT_IN_REQUEST_MESSAGEContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_IN_REQUEST_MESSAGE"); _STATUS_NOT_IN_REQUEST_MESSAGEReady = true; } return _STATUS_NOT_IN_REQUEST_MESSAGEContent; } }
        private static int _STATUS_NOT_IN_REQUEST_MESSAGEContent = default;
        private static bool _STATUS_NOT_IN_REQUEST_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_NOT_REQUESTED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_NOT_REQUESTED { get { if (!_STATUS_NOT_REQUESTEDReady) { _STATUS_NOT_REQUESTEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_REQUESTED"); _STATUS_NOT_REQUESTEDReady = true; } return _STATUS_NOT_REQUESTEDContent; } }
        private static int _STATUS_NOT_REQUESTEDContent = default;
        private static bool _STATUS_NOT_REQUESTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_OK"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_OK { get { if (!_STATUS_OKReady) { _STATUS_OKContent = SGetField<int>(LocalBridgeClazz, "STATUS_OK"); _STATUS_OKReady = true; } return _STATUS_OKContent; } }
        private static int _STATUS_OKContent = default;
        private static bool _STATUS_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_READER_AUTHENTICATION_FAILED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_READER_AUTHENTICATION_FAILED { get { if (!_STATUS_READER_AUTHENTICATION_FAILEDReady) { _STATUS_READER_AUTHENTICATION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_READER_AUTHENTICATION_FAILED"); _STATUS_READER_AUTHENTICATION_FAILEDReady = true; } return _STATUS_READER_AUTHENTICATION_FAILEDContent; } }
        private static int _STATUS_READER_AUTHENTICATION_FAILEDContent = default;
        private static bool _STATUS_READER_AUTHENTICATION_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#STATUS_USER_AUTHENTICATION_FAILED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_USER_AUTHENTICATION_FAILED { get { if (!_STATUS_USER_AUTHENTICATION_FAILEDReady) { _STATUS_USER_AUTHENTICATION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_USER_AUTHENTICATION_FAILED"); _STATUS_USER_AUTHENTICATION_FAILEDReady = true; } return _STATUS_USER_AUTHENTICATION_FAILEDContent; } }
        private static int _STATUS_USER_AUTHENTICATION_FAILEDContent = default;
        private static bool _STATUS_USER_AUTHENTICATION_FAILEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getAuthenticatedData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetAuthenticatedData()
        {
            return IExecuteWithSignatureArray<byte>("getAuthenticatedData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getEntry(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetEntry(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteArray<byte>("getEntry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getMessageAuthenticationCode()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetMessageAuthenticationCode()
        {
            return IExecuteWithSignatureArray<byte>("getMessageAuthenticationCode", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getStaticAuthenticationData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] GetStaticAuthenticationData()
        {
            return IExecuteWithSignatureArray<byte>("getStaticAuthenticationData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getStatus(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetStatus(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getStatus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getEntryNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Collection<Java.Lang.String> GetEntryNames(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("getEntryNames", "(Ljava/lang/String;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getNamespaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Collection<Java.Lang.String> GetNamespaces()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("getNamespaces", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/ResultData.html#getRetrievedEntryNames(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Collection<Java.Lang.String> GetRetrievedEntryNames(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("getRetrievedEntryNames", "(Ljava/lang/String;)Ljava/util/Collection;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}