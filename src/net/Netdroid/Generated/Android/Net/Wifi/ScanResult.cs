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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Wifi
{
    #region ScanResult declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html"/>
    /// </summary>
    public partial class ScanResult : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.wifi.ScanResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScanResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScanResult(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region InformationElement declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html"/>
        /// </summary>
        public partial class InformationElement : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.net.wifi.ScanResult$InformationElement";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public InformationElement() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public InformationElement(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region ScanResult implementation
    public partial class ScanResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#%3Cinit%3E(android.net.wifi.ScanResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.ScanResult"/></param>
        public ScanResult(Android.Net.Wifi.ScanResult arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#centerFreq0"/>
        /// </summary>
        public int centerFreq0 { get { return IGetField<int>("centerFreq0"); } set { ISetField("centerFreq0", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#centerFreq1"/>
        /// </summary>
        public int centerFreq1 { get { return IGetField<int>("centerFreq1"); } set { ISetField("centerFreq1", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#channelWidth"/>
        /// </summary>
        public int channelWidth { get { return IGetField<int>("channelWidth"); } set { ISetField("channelWidth", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#frequency"/>
        /// </summary>
        public int frequency { get { return IGetField<int>("frequency"); } set { ISetField("frequency", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#level"/>
        /// </summary>
        public int level { get { return IGetField<int>("level"); } set { ISetField("level", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#operatorFriendlyName"/>
        /// </summary>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence operatorFriendlyName { get { return IGetField<Java.Lang.CharSequence>("operatorFriendlyName"); } set { ISetField("operatorFriendlyName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#venueName"/>
        /// </summary>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence venueName { get { return IGetField<Java.Lang.CharSequence>("venueName"); } set { ISetField("venueName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#BSSID"/>
        /// </summary>
        public Java.Lang.String BSSID { get { return IGetField<Java.Lang.String>("BSSID"); } set { ISetField("BSSID", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#capabilities"/>
        /// </summary>
        public Java.Lang.String capabilities { get { return IGetField<Java.Lang.String>("capabilities"); } set { ISetField("capabilities", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#SSID"/>
        /// </summary>
        [global::System.Obsolete()]
        public Java.Lang.String SSID { get { return IGetField<Java.Lang.String>("SSID"); } set { ISetField("SSID", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#timestamp"/>
        /// </summary>
        public long timestamp { get { return IGetField<long>("timestamp"); } set { ISetField("timestamp", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CHANNEL_WIDTH_160MHZ"/>
        /// </summary>
        public static int CHANNEL_WIDTH_160MHZ { get { if (!_CHANNEL_WIDTH_160MHZReady) { _CHANNEL_WIDTH_160MHZContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_WIDTH_160MHZ"); _CHANNEL_WIDTH_160MHZReady = true; } return _CHANNEL_WIDTH_160MHZContent; } }
        private static int _CHANNEL_WIDTH_160MHZContent = default;
        private static bool _CHANNEL_WIDTH_160MHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CHANNEL_WIDTH_20MHZ"/>
        /// </summary>
        public static int CHANNEL_WIDTH_20MHZ { get { if (!_CHANNEL_WIDTH_20MHZReady) { _CHANNEL_WIDTH_20MHZContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_WIDTH_20MHZ"); _CHANNEL_WIDTH_20MHZReady = true; } return _CHANNEL_WIDTH_20MHZContent; } }
        private static int _CHANNEL_WIDTH_20MHZContent = default;
        private static bool _CHANNEL_WIDTH_20MHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CHANNEL_WIDTH_320MHZ"/>
        /// </summary>
        public static int CHANNEL_WIDTH_320MHZ { get { if (!_CHANNEL_WIDTH_320MHZReady) { _CHANNEL_WIDTH_320MHZContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_WIDTH_320MHZ"); _CHANNEL_WIDTH_320MHZReady = true; } return _CHANNEL_WIDTH_320MHZContent; } }
        private static int _CHANNEL_WIDTH_320MHZContent = default;
        private static bool _CHANNEL_WIDTH_320MHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CHANNEL_WIDTH_40MHZ"/>
        /// </summary>
        public static int CHANNEL_WIDTH_40MHZ { get { if (!_CHANNEL_WIDTH_40MHZReady) { _CHANNEL_WIDTH_40MHZContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_WIDTH_40MHZ"); _CHANNEL_WIDTH_40MHZReady = true; } return _CHANNEL_WIDTH_40MHZContent; } }
        private static int _CHANNEL_WIDTH_40MHZContent = default;
        private static bool _CHANNEL_WIDTH_40MHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CHANNEL_WIDTH_80MHZ"/>
        /// </summary>
        public static int CHANNEL_WIDTH_80MHZ { get { if (!_CHANNEL_WIDTH_80MHZReady) { _CHANNEL_WIDTH_80MHZContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_WIDTH_80MHZ"); _CHANNEL_WIDTH_80MHZReady = true; } return _CHANNEL_WIDTH_80MHZContent; } }
        private static int _CHANNEL_WIDTH_80MHZContent = default;
        private static bool _CHANNEL_WIDTH_80MHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#CHANNEL_WIDTH_80MHZ_PLUS_MHZ"/>
        /// </summary>
        public static int CHANNEL_WIDTH_80MHZ_PLUS_MHZ { get { if (!_CHANNEL_WIDTH_80MHZ_PLUS_MHZReady) { _CHANNEL_WIDTH_80MHZ_PLUS_MHZContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_WIDTH_80MHZ_PLUS_MHZ"); _CHANNEL_WIDTH_80MHZ_PLUS_MHZReady = true; } return _CHANNEL_WIDTH_80MHZ_PLUS_MHZContent; } }
        private static int _CHANNEL_WIDTH_80MHZ_PLUS_MHZContent = default;
        private static bool _CHANNEL_WIDTH_80MHZ_PLUS_MHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#PREAMBLE_EHT"/>
        /// </summary>
        public static int PREAMBLE_EHT { get { if (!_PREAMBLE_EHTReady) { _PREAMBLE_EHTContent = SGetField<int>(LocalBridgeClazz, "PREAMBLE_EHT"); _PREAMBLE_EHTReady = true; } return _PREAMBLE_EHTContent; } }
        private static int _PREAMBLE_EHTContent = default;
        private static bool _PREAMBLE_EHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#PREAMBLE_HE"/>
        /// </summary>
        public static int PREAMBLE_HE { get { if (!_PREAMBLE_HEReady) { _PREAMBLE_HEContent = SGetField<int>(LocalBridgeClazz, "PREAMBLE_HE"); _PREAMBLE_HEReady = true; } return _PREAMBLE_HEContent; } }
        private static int _PREAMBLE_HEContent = default;
        private static bool _PREAMBLE_HEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#PREAMBLE_HT"/>
        /// </summary>
        public static int PREAMBLE_HT { get { if (!_PREAMBLE_HTReady) { _PREAMBLE_HTContent = SGetField<int>(LocalBridgeClazz, "PREAMBLE_HT"); _PREAMBLE_HTReady = true; } return _PREAMBLE_HTContent; } }
        private static int _PREAMBLE_HTContent = default;
        private static bool _PREAMBLE_HTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#PREAMBLE_LEGACY"/>
        /// </summary>
        public static int PREAMBLE_LEGACY { get { if (!_PREAMBLE_LEGACYReady) { _PREAMBLE_LEGACYContent = SGetField<int>(LocalBridgeClazz, "PREAMBLE_LEGACY"); _PREAMBLE_LEGACYReady = true; } return _PREAMBLE_LEGACYContent; } }
        private static int _PREAMBLE_LEGACYContent = default;
        private static bool _PREAMBLE_LEGACYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#PREAMBLE_VHT"/>
        /// </summary>
        public static int PREAMBLE_VHT { get { if (!_PREAMBLE_VHTReady) { _PREAMBLE_VHTContent = SGetField<int>(LocalBridgeClazz, "PREAMBLE_VHT"); _PREAMBLE_VHTReady = true; } return _PREAMBLE_VHTContent; } }
        private static int _PREAMBLE_VHTContent = default;
        private static bool _PREAMBLE_VHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#UNSPECIFIED"/>
        /// </summary>
        public static int UNSPECIFIED { get { if (!_UNSPECIFIEDReady) { _UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "UNSPECIFIED"); _UNSPECIFIEDReady = true; } return _UNSPECIFIEDContent; } }
        private static int _UNSPECIFIEDContent = default;
        private static bool _UNSPECIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_BAND_24_GHZ"/>
        /// </summary>
        public static int WIFI_BAND_24_GHZ { get { if (!_WIFI_BAND_24_GHZReady) { _WIFI_BAND_24_GHZContent = SGetField<int>(LocalBridgeClazz, "WIFI_BAND_24_GHZ"); _WIFI_BAND_24_GHZReady = true; } return _WIFI_BAND_24_GHZContent; } }
        private static int _WIFI_BAND_24_GHZContent = default;
        private static bool _WIFI_BAND_24_GHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_BAND_5_GHZ"/>
        /// </summary>
        public static int WIFI_BAND_5_GHZ { get { if (!_WIFI_BAND_5_GHZReady) { _WIFI_BAND_5_GHZContent = SGetField<int>(LocalBridgeClazz, "WIFI_BAND_5_GHZ"); _WIFI_BAND_5_GHZReady = true; } return _WIFI_BAND_5_GHZContent; } }
        private static int _WIFI_BAND_5_GHZContent = default;
        private static bool _WIFI_BAND_5_GHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_BAND_6_GHZ"/>
        /// </summary>
        public static int WIFI_BAND_6_GHZ { get { if (!_WIFI_BAND_6_GHZReady) { _WIFI_BAND_6_GHZContent = SGetField<int>(LocalBridgeClazz, "WIFI_BAND_6_GHZ"); _WIFI_BAND_6_GHZReady = true; } return _WIFI_BAND_6_GHZContent; } }
        private static int _WIFI_BAND_6_GHZContent = default;
        private static bool _WIFI_BAND_6_GHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_BAND_60_GHZ"/>
        /// </summary>
        public static int WIFI_BAND_60_GHZ { get { if (!_WIFI_BAND_60_GHZReady) { _WIFI_BAND_60_GHZContent = SGetField<int>(LocalBridgeClazz, "WIFI_BAND_60_GHZ"); _WIFI_BAND_60_GHZReady = true; } return _WIFI_BAND_60_GHZContent; } }
        private static int _WIFI_BAND_60_GHZContent = default;
        private static bool _WIFI_BAND_60_GHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_11AC"/>
        /// </summary>
        public static int WIFI_STANDARD_11AC { get { if (!_WIFI_STANDARD_11ACReady) { _WIFI_STANDARD_11ACContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_11AC"); _WIFI_STANDARD_11ACReady = true; } return _WIFI_STANDARD_11ACContent; } }
        private static int _WIFI_STANDARD_11ACContent = default;
        private static bool _WIFI_STANDARD_11ACReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_11AD"/>
        /// </summary>
        public static int WIFI_STANDARD_11AD { get { if (!_WIFI_STANDARD_11ADReady) { _WIFI_STANDARD_11ADContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_11AD"); _WIFI_STANDARD_11ADReady = true; } return _WIFI_STANDARD_11ADContent; } }
        private static int _WIFI_STANDARD_11ADContent = default;
        private static bool _WIFI_STANDARD_11ADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_11AX"/>
        /// </summary>
        public static int WIFI_STANDARD_11AX { get { if (!_WIFI_STANDARD_11AXReady) { _WIFI_STANDARD_11AXContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_11AX"); _WIFI_STANDARD_11AXReady = true; } return _WIFI_STANDARD_11AXContent; } }
        private static int _WIFI_STANDARD_11AXContent = default;
        private static bool _WIFI_STANDARD_11AXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_11BE"/>
        /// </summary>
        public static int WIFI_STANDARD_11BE { get { if (!_WIFI_STANDARD_11BEReady) { _WIFI_STANDARD_11BEContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_11BE"); _WIFI_STANDARD_11BEReady = true; } return _WIFI_STANDARD_11BEContent; } }
        private static int _WIFI_STANDARD_11BEContent = default;
        private static bool _WIFI_STANDARD_11BEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_11N"/>
        /// </summary>
        public static int WIFI_STANDARD_11N { get { if (!_WIFI_STANDARD_11NReady) { _WIFI_STANDARD_11NContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_11N"); _WIFI_STANDARD_11NReady = true; } return _WIFI_STANDARD_11NContent; } }
        private static int _WIFI_STANDARD_11NContent = default;
        private static bool _WIFI_STANDARD_11NReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_LEGACY"/>
        /// </summary>
        public static int WIFI_STANDARD_LEGACY { get { if (!_WIFI_STANDARD_LEGACYReady) { _WIFI_STANDARD_LEGACYContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_LEGACY"); _WIFI_STANDARD_LEGACYReady = true; } return _WIFI_STANDARD_LEGACYContent; } }
        private static int _WIFI_STANDARD_LEGACYContent = default;
        private static bool _WIFI_STANDARD_LEGACYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#WIFI_STANDARD_UNKNOWN"/>
        /// </summary>
        public static int WIFI_STANDARD_UNKNOWN { get { if (!_WIFI_STANDARD_UNKNOWNReady) { _WIFI_STANDARD_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "WIFI_STANDARD_UNKNOWN"); _WIFI_STANDARD_UNKNOWNReady = true; } return _WIFI_STANDARD_UNKNOWNContent; } }
        private static int _WIFI_STANDARD_UNKNOWNContent = default;
        private static bool _WIFI_STANDARD_UNKNOWNReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#convertChannelToFrequencyMhzIfSupported(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ConvertChannelToFrequencyMhzIfSupported(int arg0, int arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "convertChannelToFrequencyMhzIfSupported", "(II)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#convertFrequencyMhzToChannelIfSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ConvertFrequencyMhzToChannelIfSupported(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "convertFrequencyMhzToChannelIfSupported", "(I)I", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getApMldMacAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public Android.Net.MacAddress GetApMldMacAddress()
        {
            return IExecuteWithSignature<Android.Net.MacAddress>("getApMldMacAddress", "()Landroid/net/MacAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getWifiSsid()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.WifiSsid"/></returns>
        public Android.Net.Wifi.WifiSsid GetWifiSsid()
        {
            return IExecuteWithSignature<Android.Net.Wifi.WifiSsid>("getWifiSsid", "()Landroid/net/wifi/WifiSsid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#is80211azNtbResponder()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is80211azNtbResponder()
        {
            return IExecuteWithSignature<bool>("is80211azNtbResponder", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#is80211mcResponder()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is80211mcResponder()
        {
            return IExecuteWithSignature<bool>("is80211mcResponder", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#isPasspointNetwork()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPasspointNetwork()
        {
            return IExecuteWithSignature<bool>("isPasspointNetwork", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#isTwtResponder()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTwtResponder()
        {
            return IExecuteWithSignature<bool>("isTwtResponder", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getApMloLinkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetApMloLinkId()
        {
            return IExecuteWithSignature<int>("getApMloLinkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getWifiStandard()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWifiStandard()
        {
            return IExecuteWithSignature<int>("getWifiStandard", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getSecurityTypes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetSecurityTypes()
        {
            return IExecuteWithSignatureArray<int>("getSecurityTypes", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getAffiliatedMloLinks()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Wifi.MloLink> GetAffiliatedMloLinks()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.MloLink>>("getAffiliatedMloLinks", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#getInformationElements()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Wifi.ScanResult.InformationElement> GetInformationElements()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.ScanResult.InformationElement>>("getInformationElements", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region InformationElement implementation
        public partial class InformationElement
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#%3Cinit%3E(android.net.wifi.ScanResult.InformationElement)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.ScanResult.InformationElement"/></param>
            public InformationElement(Android.Net.Wifi.ScanResult.InformationElement arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#%3Cinit%3E(int,int,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            public InformationElement(int arg0, int arg1, byte[] arg2)
                : base(arg0, arg1, arg2)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#getId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetId()
            {
                return IExecuteWithSignature<int>("getId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#getIdExt()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetIdExt()
            {
                return IExecuteWithSignature<int>("getIdExt", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#getBytes()"/>
            /// </summary>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer GetBytes()
            {
                return IExecuteWithSignature<Java.Nio.ByteBuffer>("getBytes", "()Ljava/nio/ByteBuffer;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/ScanResult.InformationElement.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
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