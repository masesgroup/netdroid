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

namespace Android.Telephony
{
    #region NetworkRegistrationInfo
    public partial class NetworkRegistrationInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#DOMAIN_CS"/>
        /// </summary>
        public static int DOMAIN_CS { get { if (!_DOMAIN_CSReady) { _DOMAIN_CSContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_CS"); _DOMAIN_CSReady = true; } return _DOMAIN_CSContent; } }
        private static int _DOMAIN_CSContent = default;
        private static bool _DOMAIN_CSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#DOMAIN_CS_PS"/>
        /// </summary>
        public static int DOMAIN_CS_PS { get { if (!_DOMAIN_CS_PSReady) { _DOMAIN_CS_PSContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_CS_PS"); _DOMAIN_CS_PSReady = true; } return _DOMAIN_CS_PSContent; } }
        private static int _DOMAIN_CS_PSContent = default;
        private static bool _DOMAIN_CS_PSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#DOMAIN_PS"/>
        /// </summary>
        public static int DOMAIN_PS { get { if (!_DOMAIN_PSReady) { _DOMAIN_PSContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_PS"); _DOMAIN_PSReady = true; } return _DOMAIN_PSContent; } }
        private static int _DOMAIN_PSContent = default;
        private static bool _DOMAIN_PSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#DOMAIN_UNKNOWN"/>
        /// </summary>
        public static int DOMAIN_UNKNOWN { get { if (!_DOMAIN_UNKNOWNReady) { _DOMAIN_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_UNKNOWN"); _DOMAIN_UNKNOWNReady = true; } return _DOMAIN_UNKNOWNContent; } }
        private static int _DOMAIN_UNKNOWNContent = default;
        private static bool _DOMAIN_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#NR_STATE_CONNECTED"/>
        /// </summary>
        public static int NR_STATE_CONNECTED { get { if (!_NR_STATE_CONNECTEDReady) { _NR_STATE_CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "NR_STATE_CONNECTED"); _NR_STATE_CONNECTEDReady = true; } return _NR_STATE_CONNECTEDContent; } }
        private static int _NR_STATE_CONNECTEDContent = default;
        private static bool _NR_STATE_CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#NR_STATE_NONE"/>
        /// </summary>
        public static int NR_STATE_NONE { get { if (!_NR_STATE_NONEReady) { _NR_STATE_NONEContent = SGetField<int>(LocalBridgeClazz, "NR_STATE_NONE"); _NR_STATE_NONEReady = true; } return _NR_STATE_NONEContent; } }
        private static int _NR_STATE_NONEContent = default;
        private static bool _NR_STATE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#NR_STATE_NOT_RESTRICTED"/>
        /// </summary>
        public static int NR_STATE_NOT_RESTRICTED { get { if (!_NR_STATE_NOT_RESTRICTEDReady) { _NR_STATE_NOT_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "NR_STATE_NOT_RESTRICTED"); _NR_STATE_NOT_RESTRICTEDReady = true; } return _NR_STATE_NOT_RESTRICTEDContent; } }
        private static int _NR_STATE_NOT_RESTRICTEDContent = default;
        private static bool _NR_STATE_NOT_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#NR_STATE_RESTRICTED"/>
        /// </summary>
        public static int NR_STATE_RESTRICTED { get { if (!_NR_STATE_RESTRICTEDReady) { _NR_STATE_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "NR_STATE_RESTRICTED"); _NR_STATE_RESTRICTEDReady = true; } return _NR_STATE_RESTRICTEDContent; } }
        private static int _NR_STATE_RESTRICTEDContent = default;
        private static bool _NR_STATE_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_DATA"/>
        /// </summary>
        public static int SERVICE_TYPE_DATA { get { if (!_SERVICE_TYPE_DATAReady) { _SERVICE_TYPE_DATAContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_DATA"); _SERVICE_TYPE_DATAReady = true; } return _SERVICE_TYPE_DATAContent; } }
        private static int _SERVICE_TYPE_DATAContent = default;
        private static bool _SERVICE_TYPE_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_EMERGENCY"/>
        /// </summary>
        public static int SERVICE_TYPE_EMERGENCY { get { if (!_SERVICE_TYPE_EMERGENCYReady) { _SERVICE_TYPE_EMERGENCYContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_EMERGENCY"); _SERVICE_TYPE_EMERGENCYReady = true; } return _SERVICE_TYPE_EMERGENCYContent; } }
        private static int _SERVICE_TYPE_EMERGENCYContent = default;
        private static bool _SERVICE_TYPE_EMERGENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_MMS"/>
        /// </summary>
        public static int SERVICE_TYPE_MMS { get { if (!_SERVICE_TYPE_MMSReady) { _SERVICE_TYPE_MMSContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_MMS"); _SERVICE_TYPE_MMSReady = true; } return _SERVICE_TYPE_MMSContent; } }
        private static int _SERVICE_TYPE_MMSContent = default;
        private static bool _SERVICE_TYPE_MMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_SMS"/>
        /// </summary>
        public static int SERVICE_TYPE_SMS { get { if (!_SERVICE_TYPE_SMSReady) { _SERVICE_TYPE_SMSContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_SMS"); _SERVICE_TYPE_SMSReady = true; } return _SERVICE_TYPE_SMSContent; } }
        private static int _SERVICE_TYPE_SMSContent = default;
        private static bool _SERVICE_TYPE_SMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_UNKNOWN"/>
        /// </summary>
        public static int SERVICE_TYPE_UNKNOWN { get { if (!_SERVICE_TYPE_UNKNOWNReady) { _SERVICE_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_UNKNOWN"); _SERVICE_TYPE_UNKNOWNReady = true; } return _SERVICE_TYPE_UNKNOWNContent; } }
        private static int _SERVICE_TYPE_UNKNOWNContent = default;
        private static bool _SERVICE_TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_VIDEO"/>
        /// </summary>
        public static int SERVICE_TYPE_VIDEO { get { if (!_SERVICE_TYPE_VIDEOReady) { _SERVICE_TYPE_VIDEOContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_VIDEO"); _SERVICE_TYPE_VIDEOReady = true; } return _SERVICE_TYPE_VIDEOContent; } }
        private static int _SERVICE_TYPE_VIDEOContent = default;
        private static bool _SERVICE_TYPE_VIDEOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#SERVICE_TYPE_VOICE"/>
        /// </summary>
        public static int SERVICE_TYPE_VOICE { get { if (!_SERVICE_TYPE_VOICEReady) { _SERVICE_TYPE_VOICEContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_VOICE"); _SERVICE_TYPE_VOICEReady = true; } return _SERVICE_TYPE_VOICEContent; } }
        private static int _SERVICE_TYPE_VOICEContent = default;
        private static bool _SERVICE_TYPE_VOICEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getCellIdentity()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.CellIdentity"/></returns>
        public Android.Telephony.CellIdentity GetCellIdentity()
        {
            return IExecuteWithSignature<Android.Telephony.CellIdentity>("getCellIdentity", "()Landroid/telephony/CellIdentity;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isNetworkRegistered()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNetworkRegistered()
        {
            return IExecuteWithSignature<bool>("isNetworkRegistered", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isNetworkRoaming()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNetworkRoaming()
        {
            return IExecuteWithSignature<bool>("isNetworkRoaming", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isNetworkSearching()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNetworkSearching()
        {
            return IExecuteWithSignature<bool>("isNetworkSearching", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isNonTerrestrialNetwork()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNonTerrestrialNetwork()
        {
            return IExecuteWithSignature<bool>("isNonTerrestrialNetwork", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isRegistered()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsRegistered()
        {
            return IExecuteWithSignature<bool>("isRegistered", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isRoaming()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsRoaming()
        {
            return IExecuteWithSignature<bool>("isRoaming", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#isSearching()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsSearching()
        {
            return IExecuteWithSignature<bool>("isSearching", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getAccessNetworkTechnology()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAccessNetworkTechnology()
        {
            return IExecuteWithSignature<int>("getAccessNetworkTechnology", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getDomain()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDomain()
        {
            return IExecuteWithSignature<int>("getDomain", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getRejectCause()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRejectCause()
        {
            return IExecuteWithSignature<int>("getRejectCause", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getTransportType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTransportType()
        {
            return IExecuteWithSignature<int>("getTransportType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getRegisteredPlmn()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRegisteredPlmn()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRegisteredPlmn", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#getAvailableServices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> GetAvailableServices()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getAvailableServices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkRegistrationInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}