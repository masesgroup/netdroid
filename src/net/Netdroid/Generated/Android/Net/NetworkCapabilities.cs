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

namespace Android.Net
{
    #region NetworkCapabilities
    public partial class NetworkCapabilities
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#%3Cinit%3E(android.net.NetworkCapabilities)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.NetworkCapabilities"/></param>
        public NetworkCapabilities(Android.Net.NetworkCapabilities arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_CAPTIVE_PORTAL"/>
        /// </summary>
        public static int NET_CAPABILITY_CAPTIVE_PORTAL { get { if (!_NET_CAPABILITY_CAPTIVE_PORTALReady) { _NET_CAPABILITY_CAPTIVE_PORTALContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_CAPTIVE_PORTAL"); _NET_CAPABILITY_CAPTIVE_PORTALReady = true; } return _NET_CAPABILITY_CAPTIVE_PORTALContent; } }
        private static int _NET_CAPABILITY_CAPTIVE_PORTALContent = default;
        private static bool _NET_CAPABILITY_CAPTIVE_PORTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_CBS"/>
        /// </summary>
        public static int NET_CAPABILITY_CBS { get { if (!_NET_CAPABILITY_CBSReady) { _NET_CAPABILITY_CBSContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_CBS"); _NET_CAPABILITY_CBSReady = true; } return _NET_CAPABILITY_CBSContent; } }
        private static int _NET_CAPABILITY_CBSContent = default;
        private static bool _NET_CAPABILITY_CBSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_DUN"/>
        /// </summary>
        public static int NET_CAPABILITY_DUN { get { if (!_NET_CAPABILITY_DUNReady) { _NET_CAPABILITY_DUNContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_DUN"); _NET_CAPABILITY_DUNReady = true; } return _NET_CAPABILITY_DUNContent; } }
        private static int _NET_CAPABILITY_DUNContent = default;
        private static bool _NET_CAPABILITY_DUNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_EIMS"/>
        /// </summary>
        public static int NET_CAPABILITY_EIMS { get { if (!_NET_CAPABILITY_EIMSReady) { _NET_CAPABILITY_EIMSContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_EIMS"); _NET_CAPABILITY_EIMSReady = true; } return _NET_CAPABILITY_EIMSContent; } }
        private static int _NET_CAPABILITY_EIMSContent = default;
        private static bool _NET_CAPABILITY_EIMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_ENTERPRISE"/>
        /// </summary>
        public static int NET_CAPABILITY_ENTERPRISE { get { if (!_NET_CAPABILITY_ENTERPRISEReady) { _NET_CAPABILITY_ENTERPRISEContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_ENTERPRISE"); _NET_CAPABILITY_ENTERPRISEReady = true; } return _NET_CAPABILITY_ENTERPRISEContent; } }
        private static int _NET_CAPABILITY_ENTERPRISEContent = default;
        private static bool _NET_CAPABILITY_ENTERPRISEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_FOREGROUND"/>
        /// </summary>
        public static int NET_CAPABILITY_FOREGROUND { get { if (!_NET_CAPABILITY_FOREGROUNDReady) { _NET_CAPABILITY_FOREGROUNDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_FOREGROUND"); _NET_CAPABILITY_FOREGROUNDReady = true; } return _NET_CAPABILITY_FOREGROUNDContent; } }
        private static int _NET_CAPABILITY_FOREGROUNDContent = default;
        private static bool _NET_CAPABILITY_FOREGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_FOTA"/>
        /// </summary>
        public static int NET_CAPABILITY_FOTA { get { if (!_NET_CAPABILITY_FOTAReady) { _NET_CAPABILITY_FOTAContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_FOTA"); _NET_CAPABILITY_FOTAReady = true; } return _NET_CAPABILITY_FOTAContent; } }
        private static int _NET_CAPABILITY_FOTAContent = default;
        private static bool _NET_CAPABILITY_FOTAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_HEAD_UNIT"/>
        /// </summary>
        public static int NET_CAPABILITY_HEAD_UNIT { get { if (!_NET_CAPABILITY_HEAD_UNITReady) { _NET_CAPABILITY_HEAD_UNITContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_HEAD_UNIT"); _NET_CAPABILITY_HEAD_UNITReady = true; } return _NET_CAPABILITY_HEAD_UNITContent; } }
        private static int _NET_CAPABILITY_HEAD_UNITContent = default;
        private static bool _NET_CAPABILITY_HEAD_UNITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_IA"/>
        /// </summary>
        public static int NET_CAPABILITY_IA { get { if (!_NET_CAPABILITY_IAReady) { _NET_CAPABILITY_IAContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_IA"); _NET_CAPABILITY_IAReady = true; } return _NET_CAPABILITY_IAContent; } }
        private static int _NET_CAPABILITY_IAContent = default;
        private static bool _NET_CAPABILITY_IAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_IMS"/>
        /// </summary>
        public static int NET_CAPABILITY_IMS { get { if (!_NET_CAPABILITY_IMSReady) { _NET_CAPABILITY_IMSContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_IMS"); _NET_CAPABILITY_IMSReady = true; } return _NET_CAPABILITY_IMSContent; } }
        private static int _NET_CAPABILITY_IMSContent = default;
        private static bool _NET_CAPABILITY_IMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_INTERNET"/>
        /// </summary>
        public static int NET_CAPABILITY_INTERNET { get { if (!_NET_CAPABILITY_INTERNETReady) { _NET_CAPABILITY_INTERNETContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_INTERNET"); _NET_CAPABILITY_INTERNETReady = true; } return _NET_CAPABILITY_INTERNETContent; } }
        private static int _NET_CAPABILITY_INTERNETContent = default;
        private static bool _NET_CAPABILITY_INTERNETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_MCX"/>
        /// </summary>
        public static int NET_CAPABILITY_MCX { get { if (!_NET_CAPABILITY_MCXReady) { _NET_CAPABILITY_MCXContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_MCX"); _NET_CAPABILITY_MCXReady = true; } return _NET_CAPABILITY_MCXContent; } }
        private static int _NET_CAPABILITY_MCXContent = default;
        private static bool _NET_CAPABILITY_MCXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_MMS"/>
        /// </summary>
        public static int NET_CAPABILITY_MMS { get { if (!_NET_CAPABILITY_MMSReady) { _NET_CAPABILITY_MMSContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_MMS"); _NET_CAPABILITY_MMSReady = true; } return _NET_CAPABILITY_MMSContent; } }
        private static int _NET_CAPABILITY_MMSContent = default;
        private static bool _NET_CAPABILITY_MMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_MMTEL"/>
        /// </summary>
        public static int NET_CAPABILITY_MMTEL { get { if (!_NET_CAPABILITY_MMTELReady) { _NET_CAPABILITY_MMTELContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_MMTEL"); _NET_CAPABILITY_MMTELReady = true; } return _NET_CAPABILITY_MMTELContent; } }
        private static int _NET_CAPABILITY_MMTELContent = default;
        private static bool _NET_CAPABILITY_MMTELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_NOT_CONGESTED"/>
        /// </summary>
        public static int NET_CAPABILITY_NOT_CONGESTED { get { if (!_NET_CAPABILITY_NOT_CONGESTEDReady) { _NET_CAPABILITY_NOT_CONGESTEDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_NOT_CONGESTED"); _NET_CAPABILITY_NOT_CONGESTEDReady = true; } return _NET_CAPABILITY_NOT_CONGESTEDContent; } }
        private static int _NET_CAPABILITY_NOT_CONGESTEDContent = default;
        private static bool _NET_CAPABILITY_NOT_CONGESTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_NOT_METERED"/>
        /// </summary>
        public static int NET_CAPABILITY_NOT_METERED { get { if (!_NET_CAPABILITY_NOT_METEREDReady) { _NET_CAPABILITY_NOT_METEREDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_NOT_METERED"); _NET_CAPABILITY_NOT_METEREDReady = true; } return _NET_CAPABILITY_NOT_METEREDContent; } }
        private static int _NET_CAPABILITY_NOT_METEREDContent = default;
        private static bool _NET_CAPABILITY_NOT_METEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_NOT_RESTRICTED"/>
        /// </summary>
        public static int NET_CAPABILITY_NOT_RESTRICTED { get { if (!_NET_CAPABILITY_NOT_RESTRICTEDReady) { _NET_CAPABILITY_NOT_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_NOT_RESTRICTED"); _NET_CAPABILITY_NOT_RESTRICTEDReady = true; } return _NET_CAPABILITY_NOT_RESTRICTEDContent; } }
        private static int _NET_CAPABILITY_NOT_RESTRICTEDContent = default;
        private static bool _NET_CAPABILITY_NOT_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_NOT_ROAMING"/>
        /// </summary>
        public static int NET_CAPABILITY_NOT_ROAMING { get { if (!_NET_CAPABILITY_NOT_ROAMINGReady) { _NET_CAPABILITY_NOT_ROAMINGContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_NOT_ROAMING"); _NET_CAPABILITY_NOT_ROAMINGReady = true; } return _NET_CAPABILITY_NOT_ROAMINGContent; } }
        private static int _NET_CAPABILITY_NOT_ROAMINGContent = default;
        private static bool _NET_CAPABILITY_NOT_ROAMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_NOT_SUSPENDED"/>
        /// </summary>
        public static int NET_CAPABILITY_NOT_SUSPENDED { get { if (!_NET_CAPABILITY_NOT_SUSPENDEDReady) { _NET_CAPABILITY_NOT_SUSPENDEDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_NOT_SUSPENDED"); _NET_CAPABILITY_NOT_SUSPENDEDReady = true; } return _NET_CAPABILITY_NOT_SUSPENDEDContent; } }
        private static int _NET_CAPABILITY_NOT_SUSPENDEDContent = default;
        private static bool _NET_CAPABILITY_NOT_SUSPENDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_NOT_VPN"/>
        /// </summary>
        public static int NET_CAPABILITY_NOT_VPN { get { if (!_NET_CAPABILITY_NOT_VPNReady) { _NET_CAPABILITY_NOT_VPNContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_NOT_VPN"); _NET_CAPABILITY_NOT_VPNReady = true; } return _NET_CAPABILITY_NOT_VPNContent; } }
        private static int _NET_CAPABILITY_NOT_VPNContent = default;
        private static bool _NET_CAPABILITY_NOT_VPNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_PRIORITIZE_BANDWIDTH"/>
        /// </summary>
        public static int NET_CAPABILITY_PRIORITIZE_BANDWIDTH { get { if (!_NET_CAPABILITY_PRIORITIZE_BANDWIDTHReady) { _NET_CAPABILITY_PRIORITIZE_BANDWIDTHContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_PRIORITIZE_BANDWIDTH"); _NET_CAPABILITY_PRIORITIZE_BANDWIDTHReady = true; } return _NET_CAPABILITY_PRIORITIZE_BANDWIDTHContent; } }
        private static int _NET_CAPABILITY_PRIORITIZE_BANDWIDTHContent = default;
        private static bool _NET_CAPABILITY_PRIORITIZE_BANDWIDTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_PRIORITIZE_LATENCY"/>
        /// </summary>
        public static int NET_CAPABILITY_PRIORITIZE_LATENCY { get { if (!_NET_CAPABILITY_PRIORITIZE_LATENCYReady) { _NET_CAPABILITY_PRIORITIZE_LATENCYContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_PRIORITIZE_LATENCY"); _NET_CAPABILITY_PRIORITIZE_LATENCYReady = true; } return _NET_CAPABILITY_PRIORITIZE_LATENCYContent; } }
        private static int _NET_CAPABILITY_PRIORITIZE_LATENCYContent = default;
        private static bool _NET_CAPABILITY_PRIORITIZE_LATENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_RCS"/>
        /// </summary>
        public static int NET_CAPABILITY_RCS { get { if (!_NET_CAPABILITY_RCSReady) { _NET_CAPABILITY_RCSContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_RCS"); _NET_CAPABILITY_RCSReady = true; } return _NET_CAPABILITY_RCSContent; } }
        private static int _NET_CAPABILITY_RCSContent = default;
        private static bool _NET_CAPABILITY_RCSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_SUPL"/>
        /// </summary>
        public static int NET_CAPABILITY_SUPL { get { if (!_NET_CAPABILITY_SUPLReady) { _NET_CAPABILITY_SUPLContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_SUPL"); _NET_CAPABILITY_SUPLReady = true; } return _NET_CAPABILITY_SUPLContent; } }
        private static int _NET_CAPABILITY_SUPLContent = default;
        private static bool _NET_CAPABILITY_SUPLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_TEMPORARILY_NOT_METERED"/>
        /// </summary>
        public static int NET_CAPABILITY_TEMPORARILY_NOT_METERED { get { if (!_NET_CAPABILITY_TEMPORARILY_NOT_METEREDReady) { _NET_CAPABILITY_TEMPORARILY_NOT_METEREDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_TEMPORARILY_NOT_METERED"); _NET_CAPABILITY_TEMPORARILY_NOT_METEREDReady = true; } return _NET_CAPABILITY_TEMPORARILY_NOT_METEREDContent; } }
        private static int _NET_CAPABILITY_TEMPORARILY_NOT_METEREDContent = default;
        private static bool _NET_CAPABILITY_TEMPORARILY_NOT_METEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_TRUSTED"/>
        /// </summary>
        public static int NET_CAPABILITY_TRUSTED { get { if (!_NET_CAPABILITY_TRUSTEDReady) { _NET_CAPABILITY_TRUSTEDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_TRUSTED"); _NET_CAPABILITY_TRUSTEDReady = true; } return _NET_CAPABILITY_TRUSTEDContent; } }
        private static int _NET_CAPABILITY_TRUSTEDContent = default;
        private static bool _NET_CAPABILITY_TRUSTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_VALIDATED"/>
        /// </summary>
        public static int NET_CAPABILITY_VALIDATED { get { if (!_NET_CAPABILITY_VALIDATEDReady) { _NET_CAPABILITY_VALIDATEDContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_VALIDATED"); _NET_CAPABILITY_VALIDATEDReady = true; } return _NET_CAPABILITY_VALIDATEDContent; } }
        private static int _NET_CAPABILITY_VALIDATEDContent = default;
        private static bool _NET_CAPABILITY_VALIDATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_WIFI_P2P"/>
        /// </summary>
        public static int NET_CAPABILITY_WIFI_P2P { get { if (!_NET_CAPABILITY_WIFI_P2PReady) { _NET_CAPABILITY_WIFI_P2PContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_WIFI_P2P"); _NET_CAPABILITY_WIFI_P2PReady = true; } return _NET_CAPABILITY_WIFI_P2PContent; } }
        private static int _NET_CAPABILITY_WIFI_P2PContent = default;
        private static bool _NET_CAPABILITY_WIFI_P2PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_CAPABILITY_XCAP"/>
        /// </summary>
        public static int NET_CAPABILITY_XCAP { get { if (!_NET_CAPABILITY_XCAPReady) { _NET_CAPABILITY_XCAPContent = SGetField<int>(LocalBridgeClazz, "NET_CAPABILITY_XCAP"); _NET_CAPABILITY_XCAPReady = true; } return _NET_CAPABILITY_XCAPContent; } }
        private static int _NET_CAPABILITY_XCAPContent = default;
        private static bool _NET_CAPABILITY_XCAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_ENTERPRISE_ID_1"/>
        /// </summary>
        public static int NET_ENTERPRISE_ID_1 { get { if (!_NET_ENTERPRISE_ID_1Ready) { _NET_ENTERPRISE_ID_1Content = SGetField<int>(LocalBridgeClazz, "NET_ENTERPRISE_ID_1"); _NET_ENTERPRISE_ID_1Ready = true; } return _NET_ENTERPRISE_ID_1Content; } }
        private static int _NET_ENTERPRISE_ID_1Content = default;
        private static bool _NET_ENTERPRISE_ID_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_ENTERPRISE_ID_2"/>
        /// </summary>
        public static int NET_ENTERPRISE_ID_2 { get { if (!_NET_ENTERPRISE_ID_2Ready) { _NET_ENTERPRISE_ID_2Content = SGetField<int>(LocalBridgeClazz, "NET_ENTERPRISE_ID_2"); _NET_ENTERPRISE_ID_2Ready = true; } return _NET_ENTERPRISE_ID_2Content; } }
        private static int _NET_ENTERPRISE_ID_2Content = default;
        private static bool _NET_ENTERPRISE_ID_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_ENTERPRISE_ID_3"/>
        /// </summary>
        public static int NET_ENTERPRISE_ID_3 { get { if (!_NET_ENTERPRISE_ID_3Ready) { _NET_ENTERPRISE_ID_3Content = SGetField<int>(LocalBridgeClazz, "NET_ENTERPRISE_ID_3"); _NET_ENTERPRISE_ID_3Ready = true; } return _NET_ENTERPRISE_ID_3Content; } }
        private static int _NET_ENTERPRISE_ID_3Content = default;
        private static bool _NET_ENTERPRISE_ID_3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_ENTERPRISE_ID_4"/>
        /// </summary>
        public static int NET_ENTERPRISE_ID_4 { get { if (!_NET_ENTERPRISE_ID_4Ready) { _NET_ENTERPRISE_ID_4Content = SGetField<int>(LocalBridgeClazz, "NET_ENTERPRISE_ID_4"); _NET_ENTERPRISE_ID_4Ready = true; } return _NET_ENTERPRISE_ID_4Content; } }
        private static int _NET_ENTERPRISE_ID_4Content = default;
        private static bool _NET_ENTERPRISE_ID_4Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#NET_ENTERPRISE_ID_5"/>
        /// </summary>
        public static int NET_ENTERPRISE_ID_5 { get { if (!_NET_ENTERPRISE_ID_5Ready) { _NET_ENTERPRISE_ID_5Content = SGetField<int>(LocalBridgeClazz, "NET_ENTERPRISE_ID_5"); _NET_ENTERPRISE_ID_5Ready = true; } return _NET_ENTERPRISE_ID_5Content; } }
        private static int _NET_ENTERPRISE_ID_5Content = default;
        private static bool _NET_ENTERPRISE_ID_5Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#SIGNAL_STRENGTH_UNSPECIFIED"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_UNSPECIFIED { get { if (!_SIGNAL_STRENGTH_UNSPECIFIEDReady) { _SIGNAL_STRENGTH_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_UNSPECIFIED"); _SIGNAL_STRENGTH_UNSPECIFIEDReady = true; } return _SIGNAL_STRENGTH_UNSPECIFIEDContent; } }
        private static int _SIGNAL_STRENGTH_UNSPECIFIEDContent = default;
        private static bool _SIGNAL_STRENGTH_UNSPECIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_BLUETOOTH"/>
        /// </summary>
        public static int TRANSPORT_BLUETOOTH { get { if (!_TRANSPORT_BLUETOOTHReady) { _TRANSPORT_BLUETOOTHContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_BLUETOOTH"); _TRANSPORT_BLUETOOTHReady = true; } return _TRANSPORT_BLUETOOTHContent; } }
        private static int _TRANSPORT_BLUETOOTHContent = default;
        private static bool _TRANSPORT_BLUETOOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_CELLULAR"/>
        /// </summary>
        public static int TRANSPORT_CELLULAR { get { if (!_TRANSPORT_CELLULARReady) { _TRANSPORT_CELLULARContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_CELLULAR"); _TRANSPORT_CELLULARReady = true; } return _TRANSPORT_CELLULARContent; } }
        private static int _TRANSPORT_CELLULARContent = default;
        private static bool _TRANSPORT_CELLULARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_ETHERNET"/>
        /// </summary>
        public static int TRANSPORT_ETHERNET { get { if (!_TRANSPORT_ETHERNETReady) { _TRANSPORT_ETHERNETContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_ETHERNET"); _TRANSPORT_ETHERNETReady = true; } return _TRANSPORT_ETHERNETContent; } }
        private static int _TRANSPORT_ETHERNETContent = default;
        private static bool _TRANSPORT_ETHERNETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_LOWPAN"/>
        /// </summary>
        public static int TRANSPORT_LOWPAN { get { if (!_TRANSPORT_LOWPANReady) { _TRANSPORT_LOWPANContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_LOWPAN"); _TRANSPORT_LOWPANReady = true; } return _TRANSPORT_LOWPANContent; } }
        private static int _TRANSPORT_LOWPANContent = default;
        private static bool _TRANSPORT_LOWPANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_THREAD"/>
        /// </summary>
        public static int TRANSPORT_THREAD { get { if (!_TRANSPORT_THREADReady) { _TRANSPORT_THREADContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_THREAD"); _TRANSPORT_THREADReady = true; } return _TRANSPORT_THREADContent; } }
        private static int _TRANSPORT_THREADContent = default;
        private static bool _TRANSPORT_THREADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_USB"/>
        /// </summary>
        public static int TRANSPORT_USB { get { if (!_TRANSPORT_USBReady) { _TRANSPORT_USBContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_USB"); _TRANSPORT_USBReady = true; } return _TRANSPORT_USBContent; } }
        private static int _TRANSPORT_USBContent = default;
        private static bool _TRANSPORT_USBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_VPN"/>
        /// </summary>
        public static int TRANSPORT_VPN { get { if (!_TRANSPORT_VPNReady) { _TRANSPORT_VPNContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_VPN"); _TRANSPORT_VPNReady = true; } return _TRANSPORT_VPNContent; } }
        private static int _TRANSPORT_VPNContent = default;
        private static bool _TRANSPORT_VPNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_WIFI"/>
        /// </summary>
        public static int TRANSPORT_WIFI { get { if (!_TRANSPORT_WIFIReady) { _TRANSPORT_WIFIContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_WIFI"); _TRANSPORT_WIFIReady = true; } return _TRANSPORT_WIFIContent; } }
        private static int _TRANSPORT_WIFIContent = default;
        private static bool _TRANSPORT_WIFIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#TRANSPORT_WIFI_AWARE"/>
        /// </summary>
        public static int TRANSPORT_WIFI_AWARE { get { if (!_TRANSPORT_WIFI_AWAREReady) { _TRANSPORT_WIFI_AWAREContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_WIFI_AWARE"); _TRANSPORT_WIFI_AWAREReady = true; } return _TRANSPORT_WIFI_AWAREContent; } }
        private static int _TRANSPORT_WIFI_AWAREContent = default;
        private static bool _TRANSPORT_WIFI_AWAREReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getCapabilities()"/> 
        /// </summary>
        public int[] Capabilities
        {
            get { return IExecuteWithSignatureArray<int>("getCapabilities", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getEnterpriseIds()"/> 
        /// </summary>
        public int[] EnterpriseIds
        {
            get { return IExecuteWithSignatureArray<int>("getEnterpriseIds", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getLinkDownstreamBandwidthKbps()"/> 
        /// </summary>
        public int LinkDownstreamBandwidthKbps
        {
            get { return IExecuteWithSignature<int>("getLinkDownstreamBandwidthKbps", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getLinkUpstreamBandwidthKbps()"/> 
        /// </summary>
        public int LinkUpstreamBandwidthKbps
        {
            get { return IExecuteWithSignature<int>("getLinkUpstreamBandwidthKbps", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getNetworkSpecifier()"/> 
        /// </summary>
        public Android.Net.NetworkSpecifier NetworkSpecifier
        {
            get { return IExecuteWithSignature<Android.Net.NetworkSpecifier>("getNetworkSpecifier", "()Landroid/net/NetworkSpecifier;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getOwnerUid()"/> 
        /// </summary>
        public int OwnerUid
        {
            get { return IExecuteWithSignature<int>("getOwnerUid", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getSignalStrength()"/> 
        /// </summary>
        public int SignalStrength
        {
            get { return IExecuteWithSignature<int>("getSignalStrength", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#getTransportInfo()"/> 
        /// </summary>
        public Android.Net.TransportInfo TransportInfo
        {
            get { return IExecuteWithSignature<Android.Net.TransportInfo>("getTransportInfo", "()Landroid/net/TransportInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#hasCapability(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCapability(int arg0)
        {
            return IExecuteWithSignature<bool>("hasCapability", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#hasEnterpriseId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasEnterpriseId(int arg0)
        {
            return IExecuteWithSignature<bool>("hasEnterpriseId", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#hasTransport(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasTransport(int arg0)
        {
            return IExecuteWithSignature<bool>("hasTransport", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkCapabilities.html#writeToParcel(android.os.Parcel,int)"/>
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