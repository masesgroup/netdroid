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

namespace Android.Net.Ipsec.Ike
{
    #region IkeSessionParams
    public partial class IkeSessionParams
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#IKE_DPD_DELAY_SEC_DISABLED"/>
        /// </summary>
        public static int IKE_DPD_DELAY_SEC_DISABLED { get { if (!_IKE_DPD_DELAY_SEC_DISABLEDReady) { _IKE_DPD_DELAY_SEC_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "IKE_DPD_DELAY_SEC_DISABLED"); _IKE_DPD_DELAY_SEC_DISABLEDReady = true; } return _IKE_DPD_DELAY_SEC_DISABLEDContent; } }
        private static int _IKE_DPD_DELAY_SEC_DISABLEDContent = default;
        private static bool _IKE_DPD_DELAY_SEC_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#IKE_OPTION_ACCEPT_ANY_REMOTE_ID"/>
        /// </summary>
        public static int IKE_OPTION_ACCEPT_ANY_REMOTE_ID { get { if (!_IKE_OPTION_ACCEPT_ANY_REMOTE_IDReady) { _IKE_OPTION_ACCEPT_ANY_REMOTE_IDContent = SGetField<int>(LocalBridgeClazz, "IKE_OPTION_ACCEPT_ANY_REMOTE_ID"); _IKE_OPTION_ACCEPT_ANY_REMOTE_IDReady = true; } return _IKE_OPTION_ACCEPT_ANY_REMOTE_IDContent; } }
        private static int _IKE_OPTION_ACCEPT_ANY_REMOTE_IDContent = default;
        private static bool _IKE_OPTION_ACCEPT_ANY_REMOTE_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#IKE_OPTION_EAP_ONLY_AUTH"/>
        /// </summary>
        public static int IKE_OPTION_EAP_ONLY_AUTH { get { if (!_IKE_OPTION_EAP_ONLY_AUTHReady) { _IKE_OPTION_EAP_ONLY_AUTHContent = SGetField<int>(LocalBridgeClazz, "IKE_OPTION_EAP_ONLY_AUTH"); _IKE_OPTION_EAP_ONLY_AUTHReady = true; } return _IKE_OPTION_EAP_ONLY_AUTHContent; } }
        private static int _IKE_OPTION_EAP_ONLY_AUTHContent = default;
        private static bool _IKE_OPTION_EAP_ONLY_AUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#IKE_OPTION_FORCE_PORT_4500"/>
        /// </summary>
        public static int IKE_OPTION_FORCE_PORT_4500 { get { if (!_IKE_OPTION_FORCE_PORT_4500Ready) { _IKE_OPTION_FORCE_PORT_4500Content = SGetField<int>(LocalBridgeClazz, "IKE_OPTION_FORCE_PORT_4500"); _IKE_OPTION_FORCE_PORT_4500Ready = true; } return _IKE_OPTION_FORCE_PORT_4500Content; } }
        private static int _IKE_OPTION_FORCE_PORT_4500Content = default;
        private static bool _IKE_OPTION_FORCE_PORT_4500Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#IKE_OPTION_INITIAL_CONTACT"/>
        /// </summary>
        public static int IKE_OPTION_INITIAL_CONTACT { get { if (!_IKE_OPTION_INITIAL_CONTACTReady) { _IKE_OPTION_INITIAL_CONTACTContent = SGetField<int>(LocalBridgeClazz, "IKE_OPTION_INITIAL_CONTACT"); _IKE_OPTION_INITIAL_CONTACTReady = true; } return _IKE_OPTION_INITIAL_CONTACTContent; } }
        private static int _IKE_OPTION_INITIAL_CONTACTContent = default;
        private static bool _IKE_OPTION_INITIAL_CONTACTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#IKE_OPTION_MOBIKE"/>
        /// </summary>
        public static int IKE_OPTION_MOBIKE { get { if (!_IKE_OPTION_MOBIKEReady) { _IKE_OPTION_MOBIKEContent = SGetField<int>(LocalBridgeClazz, "IKE_OPTION_MOBIKE"); _IKE_OPTION_MOBIKEReady = true; } return _IKE_OPTION_MOBIKEContent; } }
        private static int _IKE_OPTION_MOBIKEContent = default;
        private static bool _IKE_OPTION_MOBIKEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getLocalIdentification()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.IkeIdentification"/></returns>
        public Android.Net.Ipsec.Ike.IkeIdentification GetLocalIdentification()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeIdentification>("getLocalIdentification", "()Landroid/net/ipsec/ike/IkeIdentification;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getRemoteIdentification()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.IkeIdentification"/></returns>
        public Android.Net.Ipsec.Ike.IkeIdentification GetRemoteIdentification()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeIdentification>("getRemoteIdentification", "()Landroid/net/ipsec/ike/IkeIdentification;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getLocalAuthConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.IkeAuthConfig"/></returns>
        public Android.Net.Ipsec.Ike.IkeSessionParams.IkeAuthConfig GetLocalAuthConfig()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.IkeAuthConfig>("getLocalAuthConfig", "()Landroid/net/ipsec/ike/IkeSessionParams$IkeAuthConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getRemoteAuthConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.IkeAuthConfig"/></returns>
        public Android.Net.Ipsec.Ike.IkeSessionParams.IkeAuthConfig GetRemoteAuthConfig()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.IkeAuthConfig>("getRemoteAuthConfig", "()Landroid/net/ipsec/ike/IkeSessionParams$IkeAuthConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getNetwork()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Network"/></returns>
        public Android.Net.Network GetNetwork()
        {
            return IExecuteWithSignature<Android.Net.Network>("getNetwork", "()Landroid/net/Network;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#hasIkeOption(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasIkeOption(int arg0)
        {
            return IExecuteWithSignature<bool>("hasIkeOption", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getDpdDelaySeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDpdDelaySeconds()
        {
            return IExecuteWithSignature<int>("getDpdDelaySeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getHardLifetimeSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHardLifetimeSeconds()
        {
            return IExecuteWithSignature<int>("getHardLifetimeSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getNattKeepAliveDelaySeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNattKeepAliveDelaySeconds()
        {
            return IExecuteWithSignature<int>("getNattKeepAliveDelaySeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getSoftLifetimeSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSoftLifetimeSeconds()
        {
            return IExecuteWithSignature<int>("getSoftLifetimeSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getRetransmissionTimeoutsMillis()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetRetransmissionTimeoutsMillis()
        {
            return IExecuteWithSignatureArray<int>("getRetransmissionTimeoutsMillis", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getServerHostname()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetServerHostname()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServerHostname", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getIkeSaProposals()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Ipsec.Ike.IkeSaProposal> GetIkeSaProposals()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Ipsec.Ike.IkeSaProposal>>("getIkeSaProposals", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.html#getIkeOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetIkeOptions()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getIkeOptions", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#%3Cinit%3E(android.net.ipsec.ike.IkeSessionParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeSessionParams"/></param>
            public Builder(Android.Net.Ipsec.Ike.IkeSessionParams arg0)
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams Build()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams>("build", "()Landroid/net/ipsec/ike/IkeSessionParams;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#addIkeOption(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder AddIkeOption(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("addIkeOption", "(I)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#addIkeSaProposal(android.net.ipsec.ike.IkeSaProposal)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeSaProposal"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder AddIkeSaProposal(Android.Net.Ipsec.Ike.IkeSaProposal arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("addIkeSaProposal", "(Landroid/net/ipsec/ike/IkeSaProposal;)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#removeIkeOption(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder RemoveIkeOption(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("removeIkeOption", "(I)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setAuthDigitalSignature(java.security.cert.X509Certificate,java.security.cert.X509Certificate,java.security.PrivateKey)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
            /// <param name="arg1"><see cref="Java.Security.Cert.X509Certificate"/></param>
            /// <param name="arg2"><see cref="Java.Security.PrivateKey"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetAuthDigitalSignature(Java.Security.Cert.X509Certificate arg0, Java.Security.Cert.X509Certificate arg1, Java.Security.PrivateKey arg2)
            {
                return IExecute<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setAuthDigitalSignature", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setAuthDigitalSignature(java.security.cert.X509Certificate,java.security.cert.X509Certificate,java.util.List,java.security.PrivateKey)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
            /// <param name="arg1"><see cref="Java.Security.Cert.X509Certificate"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <param name="arg3"><see cref="Java.Security.PrivateKey"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetAuthDigitalSignature(Java.Security.Cert.X509Certificate arg0, Java.Security.Cert.X509Certificate arg1, Java.Util.List<Java.Security.Cert.X509Certificate> arg2, Java.Security.PrivateKey arg3)
            {
                return IExecute<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setAuthDigitalSignature", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setAuthEap(java.security.cert.X509Certificate,android.net.eap.EapSessionConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
            /// <param name="arg1"><see cref="Android.Net.Eap.EapSessionConfig"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetAuthEap(Java.Security.Cert.X509Certificate arg0, Android.Net.Eap.EapSessionConfig arg1)
            {
                return IExecute<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setAuthEap", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setAuthPsk(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetAuthPsk(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setAuthPsk", "([B)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setDpdDelaySeconds(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetDpdDelaySeconds(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setDpdDelaySeconds", "(I)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setLifetimeSeconds(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetLifetimeSeconds(int arg0, int arg1)
            {
                return IExecute<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setLifetimeSeconds", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setLocalIdentification(android.net.ipsec.ike.IkeIdentification)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeIdentification"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetLocalIdentification(Android.Net.Ipsec.Ike.IkeIdentification arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setLocalIdentification", "(Landroid/net/ipsec/ike/IkeIdentification;)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setNattKeepAliveDelaySeconds(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetNattKeepAliveDelaySeconds(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setNattKeepAliveDelaySeconds", "(I)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setNetwork(android.net.Network)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Network"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetNetwork(Android.Net.Network arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setNetwork", "(Landroid/net/Network;)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setRemoteIdentification(android.net.ipsec.ike.IkeIdentification)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeIdentification"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetRemoteIdentification(Android.Net.Ipsec.Ike.IkeIdentification arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setRemoteIdentification", "(Landroid/net/ipsec/ike/IkeIdentification;)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setRetransmissionTimeoutsMillis(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetRetransmissionTimeoutsMillis(int[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setRetransmissionTimeoutsMillis", "([I)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.Builder.html#setServerHostname(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSessionParams.Builder SetServerHostname(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams.Builder>("setServerHostname", "(Ljava/lang/String;)Landroid/net/ipsec/ike/IkeSessionParams$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region IkeAuthConfig
        public partial class IkeAuthConfig
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region IkeAuthDigitalSignLocalConfig
        public partial class IkeAuthDigitalSignLocalConfig
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.IkeAuthDigitalSignLocalConfig.html#getClientEndCertificate()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
            public Java.Security.Cert.X509Certificate GetClientEndCertificate()
            {
                return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getClientEndCertificate", "()Ljava/security/cert/X509Certificate;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.IkeAuthDigitalSignLocalConfig.html#getPrivateKey()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.PrivateKey"/></returns>
            public Java.Security.PrivateKey GetPrivateKey()
            {
                return IExecuteWithSignature<Java.Security.PrivateKey>("getPrivateKey", "()Ljava/security/PrivateKey;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.IkeAuthDigitalSignLocalConfig.html#getIntermediateCertificates()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Java.Security.Cert.X509Certificate> GetIntermediateCertificates()
            {
                return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.X509Certificate>>("getIntermediateCertificates", "()Ljava/util/List;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region IkeAuthDigitalSignRemoteConfig
        public partial class IkeAuthDigitalSignRemoteConfig
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.IkeAuthDigitalSignRemoteConfig.html#getRemoteCaCert()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
            public Java.Security.Cert.X509Certificate GetRemoteCaCert()
            {
                return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getRemoteCaCert", "()Ljava/security/cert/X509Certificate;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region IkeAuthEapConfig
        public partial class IkeAuthEapConfig
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.IkeAuthEapConfig.html#getEapConfig()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Eap.EapSessionConfig"/></returns>
            public Android.Net.Eap.EapSessionConfig GetEapConfig()
            {
                return IExecuteWithSignature<Android.Net.Eap.EapSessionConfig>("getEapConfig", "()Landroid/net/eap/EapSessionConfig;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region IkeAuthPskConfig
        public partial class IkeAuthPskConfig
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionParams.IkeAuthPskConfig.html#getPsk()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetPsk()
            {
                return IExecuteWithSignatureArray<byte>("getPsk", "()[B");
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