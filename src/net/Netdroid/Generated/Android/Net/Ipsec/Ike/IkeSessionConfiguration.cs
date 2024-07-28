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

namespace Android.Net.Ipsec.Ike
{
    #region IkeSessionConfiguration
    public partial class IkeSessionConfiguration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#EXTENSION_TYPE_FRAGMENTATION"/>
        /// </summary>
        public static int EXTENSION_TYPE_FRAGMENTATION { get { if (!_EXTENSION_TYPE_FRAGMENTATIONReady) { _EXTENSION_TYPE_FRAGMENTATIONContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_TYPE_FRAGMENTATION"); _EXTENSION_TYPE_FRAGMENTATIONReady = true; } return _EXTENSION_TYPE_FRAGMENTATIONContent; } }
        private static int _EXTENSION_TYPE_FRAGMENTATIONContent = default;
        private static bool _EXTENSION_TYPE_FRAGMENTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#EXTENSION_TYPE_MOBIKE"/>
        /// </summary>
        public static int EXTENSION_TYPE_MOBIKE { get { if (!_EXTENSION_TYPE_MOBIKEReady) { _EXTENSION_TYPE_MOBIKEContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_TYPE_MOBIKE"); _EXTENSION_TYPE_MOBIKEReady = true; } return _EXTENSION_TYPE_MOBIKEContent; } }
        private static int _EXTENSION_TYPE_MOBIKEContent = default;
        private static bool _EXTENSION_TYPE_MOBIKEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#getEapInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Eap.EapInfo"/></returns>
        public Android.Net.Eap.EapInfo GetEapInfo()
        {
            return IExecuteWithSignature<Android.Net.Eap.EapInfo>("getEapInfo", "()Landroid/net/eap/EapInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#getIkeSessionConnectionInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConnectionInfo"/></returns>
        public Android.Net.Ipsec.Ike.IkeSessionConnectionInfo GetIkeSessionConnectionInfo()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConnectionInfo>("getIkeSessionConnectionInfo", "()Landroid/net/ipsec/ike/IkeSessionConnectionInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#isIkeExtensionEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsIkeExtensionEnabled(int arg0)
        {
            return IExecuteWithSignature<bool>("isIkeExtensionEnabled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#getRemoteApplicationVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRemoteApplicationVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRemoteApplicationVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.html#getRemoteVendorIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<byte[]> GetRemoteVendorIds()
        {
            return IExecuteWithSignature<Java.Util.List<byte[]>>("getRemoteVendorIds", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#%3Cinit%3E(android.net.ipsec.ike.IkeSessionConnectionInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeSessionConnectionInfo"/></param>
            public Builder(Android.Net.Ipsec.Ike.IkeSessionConnectionInfo arg0)
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration Build()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration>("build", "()Landroid/net/ipsec/ike/IkeSessionConfiguration;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#addIkeExtension(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder AddIkeExtension(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("addIkeExtension", "(I)Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#addRemoteVendorId(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder AddRemoteVendorId(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("addRemoteVendorId", "([B)Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#clearIkeExtensions()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder ClearIkeExtensions()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("clearIkeExtensions", "()Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#clearRemoteApplicationVersion()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder ClearRemoteApplicationVersion()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("clearRemoteApplicationVersion", "()Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#clearRemoteVendorIds()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder ClearRemoteVendorIds()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("clearRemoteVendorIds", "()Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#setEapInfo(android.net.eap.EapInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Eap.EapInfo"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder SetEapInfo(Android.Net.Eap.EapInfo arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("setEapInfo", "(Landroid/net/eap/EapInfo;)Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionConfiguration.Builder.html#setRemoteApplicationVersion(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder SetRemoteApplicationVersion(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionConfiguration.Builder>("setRemoteApplicationVersion", "(Ljava/lang/String;)Landroid/net/ipsec/ike/IkeSessionConfiguration$Builder;", arg0);
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