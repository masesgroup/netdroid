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

namespace Android.Net.Wifi
{
    #region WifiInfo
    public partial class WifiInfo : Android.Os.IParcelable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Wifi.WifiInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Net.Wifi.WifiInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#LINK_SPEED_UNKNOWN"/>
        /// </summary>
        public static int LINK_SPEED_UNKNOWN { get { if (!_LINK_SPEED_UNKNOWNReady) { _LINK_SPEED_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "LINK_SPEED_UNKNOWN"); _LINK_SPEED_UNKNOWNReady = true; } return _LINK_SPEED_UNKNOWNContent; } }
        private static int _LINK_SPEED_UNKNOWNContent = default;
        private static bool _LINK_SPEED_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_DPP"/>
        /// </summary>
        public static int SECURITY_TYPE_DPP { get { if (!_SECURITY_TYPE_DPPReady) { _SECURITY_TYPE_DPPContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_DPP"); _SECURITY_TYPE_DPPReady = true; } return _SECURITY_TYPE_DPPContent; } }
        private static int _SECURITY_TYPE_DPPContent = default;
        private static bool _SECURITY_TYPE_DPPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_EAP"/>
        /// </summary>
        public static int SECURITY_TYPE_EAP { get { if (!_SECURITY_TYPE_EAPReady) { _SECURITY_TYPE_EAPContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_EAP"); _SECURITY_TYPE_EAPReady = true; } return _SECURITY_TYPE_EAPContent; } }
        private static int _SECURITY_TYPE_EAPContent = default;
        private static bool _SECURITY_TYPE_EAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_EAP_WPA3_ENTERPRISE"/>
        /// </summary>
        public static int SECURITY_TYPE_EAP_WPA3_ENTERPRISE { get { if (!_SECURITY_TYPE_EAP_WPA3_ENTERPRISEReady) { _SECURITY_TYPE_EAP_WPA3_ENTERPRISEContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_EAP_WPA3_ENTERPRISE"); _SECURITY_TYPE_EAP_WPA3_ENTERPRISEReady = true; } return _SECURITY_TYPE_EAP_WPA3_ENTERPRISEContent; } }
        private static int _SECURITY_TYPE_EAP_WPA3_ENTERPRISEContent = default;
        private static bool _SECURITY_TYPE_EAP_WPA3_ENTERPRISEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BIT"/>
        /// </summary>
        public static int SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BIT { get { if (!_SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BITReady) { _SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BITContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BIT"); _SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BITReady = true; } return _SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BITContent; } }
        private static int _SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BITContent = default;
        private static bool _SECURITY_TYPE_EAP_WPA3_ENTERPRISE_192_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_OPEN"/>
        /// </summary>
        public static int SECURITY_TYPE_OPEN { get { if (!_SECURITY_TYPE_OPENReady) { _SECURITY_TYPE_OPENContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_OPEN"); _SECURITY_TYPE_OPENReady = true; } return _SECURITY_TYPE_OPENContent; } }
        private static int _SECURITY_TYPE_OPENContent = default;
        private static bool _SECURITY_TYPE_OPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_OSEN"/>
        /// </summary>
        public static int SECURITY_TYPE_OSEN { get { if (!_SECURITY_TYPE_OSENReady) { _SECURITY_TYPE_OSENContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_OSEN"); _SECURITY_TYPE_OSENReady = true; } return _SECURITY_TYPE_OSENContent; } }
        private static int _SECURITY_TYPE_OSENContent = default;
        private static bool _SECURITY_TYPE_OSENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_OWE"/>
        /// </summary>
        public static int SECURITY_TYPE_OWE { get { if (!_SECURITY_TYPE_OWEReady) { _SECURITY_TYPE_OWEContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_OWE"); _SECURITY_TYPE_OWEReady = true; } return _SECURITY_TYPE_OWEContent; } }
        private static int _SECURITY_TYPE_OWEContent = default;
        private static bool _SECURITY_TYPE_OWEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_PASSPOINT_R1_R2"/>
        /// </summary>
        public static int SECURITY_TYPE_PASSPOINT_R1_R2 { get { if (!_SECURITY_TYPE_PASSPOINT_R1_R2Ready) { _SECURITY_TYPE_PASSPOINT_R1_R2Content = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_PASSPOINT_R1_R2"); _SECURITY_TYPE_PASSPOINT_R1_R2Ready = true; } return _SECURITY_TYPE_PASSPOINT_R1_R2Content; } }
        private static int _SECURITY_TYPE_PASSPOINT_R1_R2Content = default;
        private static bool _SECURITY_TYPE_PASSPOINT_R1_R2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_PASSPOINT_R3"/>
        /// </summary>
        public static int SECURITY_TYPE_PASSPOINT_R3 { get { if (!_SECURITY_TYPE_PASSPOINT_R3Ready) { _SECURITY_TYPE_PASSPOINT_R3Content = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_PASSPOINT_R3"); _SECURITY_TYPE_PASSPOINT_R3Ready = true; } return _SECURITY_TYPE_PASSPOINT_R3Content; } }
        private static int _SECURITY_TYPE_PASSPOINT_R3Content = default;
        private static bool _SECURITY_TYPE_PASSPOINT_R3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_PSK"/>
        /// </summary>
        public static int SECURITY_TYPE_PSK { get { if (!_SECURITY_TYPE_PSKReady) { _SECURITY_TYPE_PSKContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_PSK"); _SECURITY_TYPE_PSKReady = true; } return _SECURITY_TYPE_PSKContent; } }
        private static int _SECURITY_TYPE_PSKContent = default;
        private static bool _SECURITY_TYPE_PSKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_SAE"/>
        /// </summary>
        public static int SECURITY_TYPE_SAE { get { if (!_SECURITY_TYPE_SAEReady) { _SECURITY_TYPE_SAEContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_SAE"); _SECURITY_TYPE_SAEReady = true; } return _SECURITY_TYPE_SAEContent; } }
        private static int _SECURITY_TYPE_SAEContent = default;
        private static bool _SECURITY_TYPE_SAEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_UNKNOWN"/>
        /// </summary>
        public static int SECURITY_TYPE_UNKNOWN { get { if (!_SECURITY_TYPE_UNKNOWNReady) { _SECURITY_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_UNKNOWN"); _SECURITY_TYPE_UNKNOWNReady = true; } return _SECURITY_TYPE_UNKNOWNContent; } }
        private static int _SECURITY_TYPE_UNKNOWNContent = default;
        private static bool _SECURITY_TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_WAPI_CERT"/>
        /// </summary>
        public static int SECURITY_TYPE_WAPI_CERT { get { if (!_SECURITY_TYPE_WAPI_CERTReady) { _SECURITY_TYPE_WAPI_CERTContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_WAPI_CERT"); _SECURITY_TYPE_WAPI_CERTReady = true; } return _SECURITY_TYPE_WAPI_CERTContent; } }
        private static int _SECURITY_TYPE_WAPI_CERTContent = default;
        private static bool _SECURITY_TYPE_WAPI_CERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_WAPI_PSK"/>
        /// </summary>
        public static int SECURITY_TYPE_WAPI_PSK { get { if (!_SECURITY_TYPE_WAPI_PSKReady) { _SECURITY_TYPE_WAPI_PSKContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_WAPI_PSK"); _SECURITY_TYPE_WAPI_PSKReady = true; } return _SECURITY_TYPE_WAPI_PSKContent; } }
        private static int _SECURITY_TYPE_WAPI_PSKContent = default;
        private static bool _SECURITY_TYPE_WAPI_PSKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#SECURITY_TYPE_WEP"/>
        /// </summary>
        public static int SECURITY_TYPE_WEP { get { if (!_SECURITY_TYPE_WEPReady) { _SECURITY_TYPE_WEPContent = SGetField<int>(LocalBridgeClazz, "SECURITY_TYPE_WEP"); _SECURITY_TYPE_WEPReady = true; } return _SECURITY_TYPE_WEPContent; } }
        private static int _SECURITY_TYPE_WEPContent = default;
        private static bool _SECURITY_TYPE_WEPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#FREQUENCY_UNITS"/>
        /// </summary>
        public static Java.Lang.String FREQUENCY_UNITS { get { if (!_FREQUENCY_UNITSReady) { _FREQUENCY_UNITSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FREQUENCY_UNITS"); _FREQUENCY_UNITSReady = true; } return _FREQUENCY_UNITSContent; } }
        private static Java.Lang.String _FREQUENCY_UNITSContent = default;
        private static bool _FREQUENCY_UNITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#LINK_SPEED_UNITS"/>
        /// </summary>
        public static Java.Lang.String LINK_SPEED_UNITS { get { if (!_LINK_SPEED_UNITSReady) { _LINK_SPEED_UNITSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LINK_SPEED_UNITS"); _LINK_SPEED_UNITSReady = true; } return _LINK_SPEED_UNITSContent; } }
        private static Java.Lang.String _LINK_SPEED_UNITSContent = default;
        private static bool _LINK_SPEED_UNITSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getDetailedStateOf(android.net.wifi.SupplicantState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.SupplicantState"/></param>
        /// <returns><see cref="Android.Net.NetworkInfo.DetailedState"/></returns>
        public static Android.Net.NetworkInfo.DetailedState GetDetailedStateOf(Android.Net.Wifi.SupplicantState arg0)
        {
            return SExecuteWithSignature<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getApMldMacAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public Android.Net.MacAddress GetApMldMacAddress()
        {
            return IExecuteWithSignature<Android.Net.MacAddress>("getApMldMacAddress", "()Landroid/net/MacAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getSupplicantState()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.SupplicantState"/></returns>
        public Android.Net.Wifi.SupplicantState GetSupplicantState()
        {
            return IExecuteWithSignature<Android.Net.Wifi.SupplicantState>("getSupplicantState", "()Landroid/net/wifi/SupplicantState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#makeCopy(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Net.Wifi.WifiInfo"/></returns>
        public Android.Net.Wifi.WifiInfo MakeCopy(long arg0)
        {
            return IExecuteWithSignature<Android.Net.Wifi.WifiInfo>("makeCopy", "(J)Landroid/net/wifi/WifiInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getHiddenSSID()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetHiddenSSID()
        {
            return IExecuteWithSignature<bool>("getHiddenSSID", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#isRestricted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRestricted()
        {
            return IExecuteWithSignature<bool>("isRestricted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getApMloLinkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetApMloLinkId()
        {
            return IExecuteWithSignature<int>("getApMloLinkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getCurrentSecurityType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCurrentSecurityType()
        {
            return IExecuteWithSignature<int>("getCurrentSecurityType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getFrequency()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFrequency()
        {
            return IExecuteWithSignature<int>("getFrequency", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getIpAddress()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetIpAddress()
        {
            return IExecuteWithSignature<int>("getIpAddress", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getLinkSpeed()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLinkSpeed()
        {
            return IExecuteWithSignature<int>("getLinkSpeed", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getMaxSupportedRxLinkSpeedMbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxSupportedRxLinkSpeedMbps()
        {
            return IExecuteWithSignature<int>("getMaxSupportedRxLinkSpeedMbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getMaxSupportedTxLinkSpeedMbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxSupportedTxLinkSpeedMbps()
        {
            return IExecuteWithSignature<int>("getMaxSupportedTxLinkSpeedMbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getNetworkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkId()
        {
            return IExecuteWithSignature<int>("getNetworkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getRssi()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRssi()
        {
            return IExecuteWithSignature<int>("getRssi", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getRxLinkSpeedMbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRxLinkSpeedMbps()
        {
            return IExecuteWithSignature<int>("getRxLinkSpeedMbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getSubscriptionId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubscriptionId()
        {
            return IExecuteWithSignature<int>("getSubscriptionId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getTxLinkSpeedMbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTxLinkSpeedMbps()
        {
            return IExecuteWithSignature<int>("getTxLinkSpeedMbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getWifiStandard()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWifiStandard()
        {
            return IExecuteWithSignature<int>("getWifiStandard", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getBSSID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetBSSID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getBSSID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getMacAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMacAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMacAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getPasspointFqdn()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPasspointFqdn()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPasspointFqdn", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getPasspointProviderFriendlyName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPasspointProviderFriendlyName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPasspointProviderFriendlyName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getSSID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSSID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSSID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getAffiliatedMloLinks()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Wifi.MloLink> GetAffiliatedMloLinks()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.MloLink>>("getAffiliatedMloLinks", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getAssociatedMloLinks()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Wifi.MloLink> GetAssociatedMloLinks()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.MloLink>>("getAssociatedMloLinks", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getInformationElements()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Wifi.ScanResult.InformationElement> GetInformationElements()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.ScanResult.InformationElement>>("getInformationElements", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#getApplicableRedactions()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetApplicableRedactions()
        {
            return IExecuteWithSignature<long>("getApplicableRedactions", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.WifiInfo"/></returns>
            public Android.Net.Wifi.WifiInfo Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiInfo>("build", "()Landroid/net/wifi/WifiInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.Builder.html#setBssid(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiInfo.Builder"/></returns>
            public Android.Net.Wifi.WifiInfo.Builder SetBssid(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiInfo.Builder>("setBssid", "(Ljava/lang/String;)Landroid/net/wifi/WifiInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.Builder.html#setCurrentSecurityType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiInfo.Builder"/></returns>
            public Android.Net.Wifi.WifiInfo.Builder SetCurrentSecurityType(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiInfo.Builder>("setCurrentSecurityType", "(I)Landroid/net/wifi/WifiInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.Builder.html#setNetworkId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiInfo.Builder"/></returns>
            public Android.Net.Wifi.WifiInfo.Builder SetNetworkId(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiInfo.Builder>("setNetworkId", "(I)Landroid/net/wifi/WifiInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.Builder.html#setRssi(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiInfo.Builder"/></returns>
            public Android.Net.Wifi.WifiInfo.Builder SetRssi(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiInfo.Builder>("setRssi", "(I)Landroid/net/wifi/WifiInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiInfo.Builder.html#setSsid(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiInfo.Builder"/></returns>
            public Android.Net.Wifi.WifiInfo.Builder SetSsid(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiInfo.Builder>("setSsid", "([B)Landroid/net/wifi/WifiInfo$Builder;", new object[] { arg0 });
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