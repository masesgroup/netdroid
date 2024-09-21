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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Wifi
{
    #region WifiNetworkSuggestion declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html"/>
    /// </summary>
    public partial class WifiNetworkSuggestion : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.wifi.WifiNetworkSuggestion";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WifiNetworkSuggestion() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public WifiNetworkSuggestion(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.wifi.WifiNetworkSuggestion$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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

    #region WifiNetworkSuggestion implementation
    public partial class WifiNetworkSuggestion
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#RANDOMIZATION_NON_PERSISTENT"/>
        /// </summary>
        public static int RANDOMIZATION_NON_PERSISTENT { get { if (!_RANDOMIZATION_NON_PERSISTENTReady) { _RANDOMIZATION_NON_PERSISTENTContent = SGetField<int>(LocalBridgeClazz, "RANDOMIZATION_NON_PERSISTENT"); _RANDOMIZATION_NON_PERSISTENTReady = true; } return _RANDOMIZATION_NON_PERSISTENTContent; } }
        private static int _RANDOMIZATION_NON_PERSISTENTContent = default;
        private static bool _RANDOMIZATION_NON_PERSISTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#RANDOMIZATION_PERSISTENT"/>
        /// </summary>
        public static int RANDOMIZATION_PERSISTENT { get { if (!_RANDOMIZATION_PERSISTENTReady) { _RANDOMIZATION_PERSISTENTContent = SGetField<int>(LocalBridgeClazz, "RANDOMIZATION_PERSISTENT"); _RANDOMIZATION_PERSISTENTReady = true; } return _RANDOMIZATION_PERSISTENTContent; } }
        private static int _RANDOMIZATION_PERSISTENTContent = default;
        private static bool _RANDOMIZATION_PERSISTENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getBssid()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public Android.Net.MacAddress GetBssid()
        {
            return IExecuteWithSignature<Android.Net.MacAddress>("getBssid", "()Landroid/net/MacAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getPasspointConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.Hotspot2.PasspointConfiguration"/></returns>
        public Android.Net.Wifi.Hotspot2.PasspointConfiguration GetPasspointConfig()
        {
            return IExecuteWithSignature<Android.Net.Wifi.Hotspot2.PasspointConfiguration>("getPasspointConfig", "()Landroid/net/wifi/hotspot2/PasspointConfiguration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getEnterpriseConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></returns>
        public Android.Net.Wifi.WifiEnterpriseConfig GetEnterpriseConfig()
        {
            return IExecuteWithSignature<Android.Net.Wifi.WifiEnterpriseConfig>("getEnterpriseConfig", "()Landroid/net/wifi/WifiEnterpriseConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getWifiSsid()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.WifiSsid"/></returns>
        public Android.Net.Wifi.WifiSsid GetWifiSsid()
        {
            return IExecuteWithSignature<Android.Net.Wifi.WifiSsid>("getWifiSsid", "()Landroid/net/wifi/WifiSsid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getSubscriptionGroup()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetSubscriptionGroup()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getSubscriptionGroup", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isAppInteractionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAppInteractionRequired()
        {
            return IExecuteWithSignature<bool>("isAppInteractionRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isCarrierMerged()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCarrierMerged()
        {
            return IExecuteWithSignature<bool>("isCarrierMerged", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isCredentialSharedWithUser()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCredentialSharedWithUser()
        {
            return IExecuteWithSignature<bool>("isCredentialSharedWithUser", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isEnhancedOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnhancedOpen()
        {
            return IExecuteWithSignature<bool>("isEnhancedOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isHiddenSsid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHiddenSsid()
        {
            return IExecuteWithSignature<bool>("isHiddenSsid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isInitialAutojoinEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInitialAutojoinEnabled()
        {
            return IExecuteWithSignature<bool>("isInitialAutojoinEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isMetered()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMetered()
        {
            return IExecuteWithSignature<bool>("isMetered", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isRestricted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRestricted()
        {
            return IExecuteWithSignature<bool>("isRestricted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isUntrusted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUntrusted()
        {
            return IExecuteWithSignature<bool>("isUntrusted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isUserInteractionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserInteractionRequired()
        {
            return IExecuteWithSignature<bool>("isUserInteractionRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#isWifi7Enabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWifi7Enabled()
        {
            return IExecuteWithSignature<bool>("isWifi7Enabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getMacRandomizationSetting()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMacRandomizationSetting()
        {
            return IExecuteWithSignature<int>("getMacRandomizationSetting", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getPriority()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriority()
        {
            return IExecuteWithSignature<int>("getPriority", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getPriorityGroup()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPriorityGroup()
        {
            return IExecuteWithSignature<int>("getPriorityGroup", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getSubscriptionId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubscriptionId()
        {
            return IExecuteWithSignature<int>("getSubscriptionId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getPassphrase()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPassphrase()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPassphrase", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#getSsid()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSsid()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSsid", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
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
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion>("build", "()Landroid/net/wifi/WifiNetworkSuggestion;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setBssid(android.net.MacAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetBssid(Android.Net.MacAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setBssid", "(Landroid/net/MacAddress;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setCarrierMerged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetCarrierMerged(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setCarrierMerged", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setCredentialSharedWithUser(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetCredentialSharedWithUser(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setCredentialSharedWithUser", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsAppInteractionRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsAppInteractionRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsAppInteractionRequired", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsEnhancedOpen(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsEnhancedOpen(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsEnhancedOpen", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsHiddenSsid(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsHiddenSsid(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsHiddenSsid", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsInitialAutojoinEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsInitialAutojoinEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsInitialAutojoinEnabled", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsMetered(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsMetered(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsMetered", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsUserInteractionRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsUserInteractionRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsUserInteractionRequired", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setIsWpa3SaeH2eOnlyModeEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetIsWpa3SaeH2eOnlyModeEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setIsWpa3SaeH2eOnlyModeEnabled", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setMacRandomizationSetting(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetMacRandomizationSetting(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setMacRandomizationSetting", "(I)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setPasspointConfig(android.net.wifi.hotspot2.PasspointConfiguration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.Hotspot2.PasspointConfiguration"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetPasspointConfig(Android.Net.Wifi.Hotspot2.PasspointConfiguration arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setPasspointConfig", "(Landroid/net/wifi/hotspot2/PasspointConfiguration;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setPriority(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetPriority(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setPriority", "(I)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setPriorityGroup(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetPriorityGroup(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setPriorityGroup", "(I)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setRestricted(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetRestricted(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setRestricted", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setSsid(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetSsid(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setSsid", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setSubscriptionGroup(android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetSubscriptionGroup(Android.Os.ParcelUuid arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setSubscriptionGroup", "(Landroid/os/ParcelUuid;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setSubscriptionId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetSubscriptionId(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setSubscriptionId", "(I)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setUntrusted(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetUntrusted(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setUntrusted", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWapiEnterpriseConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWapiEnterpriseConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWapiEnterpriseConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWapiPassphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWapiPassphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWapiPassphrase", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWifi7Enabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWifi7Enabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWifi7Enabled", "(Z)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWifiSsid(android.net.wifi.WifiSsid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiSsid"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWifiSsid(Android.Net.Wifi.WifiSsid arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWifiSsid", "(Landroid/net/wifi/WifiSsid;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWpa2EnterpriseConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWpa2EnterpriseConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWpa2EnterpriseConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWpa2Passphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWpa2Passphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWpa2Passphrase", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWpa3Enterprise192BitModeConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWpa3Enterprise192BitModeConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWpa3Enterprise192BitModeConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWpa3EnterpriseConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWpa3EnterpriseConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWpa3EnterpriseConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWpa3EnterpriseStandardModeConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWpa3EnterpriseStandardModeConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWpa3EnterpriseStandardModeConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSuggestion.Builder.html#setWpa3Passphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSuggestion.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSuggestion.Builder SetWpa3Passphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSuggestion.Builder>("setWpa3Passphrase", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSuggestion$Builder;", arg0);
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