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

namespace Android.Telephony
{
    #region ServiceState declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html"/>
    /// </summary>
    public partial class ServiceState : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.telephony.ServiceState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ServiceState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ServiceState(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region ServiceState implementation
    public partial class ServiceState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        [global::System.Obsolete()]
        public ServiceState(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#%3Cinit%3E(android.telephony.ServiceState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.ServiceState"/></param>
        public ServiceState(Android.Telephony.ServiceState arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#DUPLEX_MODE_FDD"/>
        /// </summary>
        public static int DUPLEX_MODE_FDD { get { if (!_DUPLEX_MODE_FDDReady) { _DUPLEX_MODE_FDDContent = SGetField<int>(LocalBridgeClazz, "DUPLEX_MODE_FDD"); _DUPLEX_MODE_FDDReady = true; } return _DUPLEX_MODE_FDDContent; } }
        private static int _DUPLEX_MODE_FDDContent = default;
        private static bool _DUPLEX_MODE_FDDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#DUPLEX_MODE_TDD"/>
        /// </summary>
        public static int DUPLEX_MODE_TDD { get { if (!_DUPLEX_MODE_TDDReady) { _DUPLEX_MODE_TDDContent = SGetField<int>(LocalBridgeClazz, "DUPLEX_MODE_TDD"); _DUPLEX_MODE_TDDReady = true; } return _DUPLEX_MODE_TDDContent; } }
        private static int _DUPLEX_MODE_TDDContent = default;
        private static bool _DUPLEX_MODE_TDDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#DUPLEX_MODE_UNKNOWN"/>
        /// </summary>
        public static int DUPLEX_MODE_UNKNOWN { get { if (!_DUPLEX_MODE_UNKNOWNReady) { _DUPLEX_MODE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "DUPLEX_MODE_UNKNOWN"); _DUPLEX_MODE_UNKNOWNReady = true; } return _DUPLEX_MODE_UNKNOWNContent; } }
        private static int _DUPLEX_MODE_UNKNOWNContent = default;
        private static bool _DUPLEX_MODE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#STATE_EMERGENCY_ONLY"/>
        /// </summary>
        public static int STATE_EMERGENCY_ONLY { get { if (!_STATE_EMERGENCY_ONLYReady) { _STATE_EMERGENCY_ONLYContent = SGetField<int>(LocalBridgeClazz, "STATE_EMERGENCY_ONLY"); _STATE_EMERGENCY_ONLYReady = true; } return _STATE_EMERGENCY_ONLYContent; } }
        private static int _STATE_EMERGENCY_ONLYContent = default;
        private static bool _STATE_EMERGENCY_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#STATE_IN_SERVICE"/>
        /// </summary>
        public static int STATE_IN_SERVICE { get { if (!_STATE_IN_SERVICEReady) { _STATE_IN_SERVICEContent = SGetField<int>(LocalBridgeClazz, "STATE_IN_SERVICE"); _STATE_IN_SERVICEReady = true; } return _STATE_IN_SERVICEContent; } }
        private static int _STATE_IN_SERVICEContent = default;
        private static bool _STATE_IN_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#STATE_OUT_OF_SERVICE"/>
        /// </summary>
        public static int STATE_OUT_OF_SERVICE { get { if (!_STATE_OUT_OF_SERVICEReady) { _STATE_OUT_OF_SERVICEContent = SGetField<int>(LocalBridgeClazz, "STATE_OUT_OF_SERVICE"); _STATE_OUT_OF_SERVICEReady = true; } return _STATE_OUT_OF_SERVICEContent; } }
        private static int _STATE_OUT_OF_SERVICEContent = default;
        private static bool _STATE_OUT_OF_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#STATE_POWER_OFF"/>
        /// </summary>
        public static int STATE_POWER_OFF { get { if (!_STATE_POWER_OFFReady) { _STATE_POWER_OFFContent = SGetField<int>(LocalBridgeClazz, "STATE_POWER_OFF"); _STATE_POWER_OFFReady = true; } return _STATE_POWER_OFFContent; } }
        private static int _STATE_POWER_OFFContent = default;
        private static bool _STATE_POWER_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#UNKNOWN_ID"/>
        /// </summary>
        public static int UNKNOWN_ID { get { if (!_UNKNOWN_IDReady) { _UNKNOWN_IDContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN_ID"); _UNKNOWN_IDReady = true; } return _UNKNOWN_IDContent; } }
        private static int _UNKNOWN_IDContent = default;
        private static bool _UNKNOWN_IDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getIsManualSelection()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetIsManualSelection()
        {
            return IExecuteWithSignature<bool>("getIsManualSelection", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getRoaming()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetRoaming()
        {
            return IExecuteWithSignature<bool>("getRoaming", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#isSearching()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSearching()
        {
            return IExecuteWithSignature<bool>("isSearching", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#isUsingNonTerrestrialNetwork()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUsingNonTerrestrialNetwork()
        {
            return IExecuteWithSignature<bool>("isUsingNonTerrestrialNetwork", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getCdmaNetworkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCdmaNetworkId()
        {
            return IExecuteWithSignature<int>("getCdmaNetworkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getCdmaSystemId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCdmaSystemId()
        {
            return IExecuteWithSignature<int>("getCdmaSystemId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getChannelNumber()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChannelNumber()
        {
            return IExecuteWithSignature<int>("getChannelNumber", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getDuplexMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDuplexMode()
        {
            return IExecuteWithSignature<int>("getDuplexMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getCellBandwidths()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetCellBandwidths()
        {
            return IExecuteWithSignatureArray<int>("getCellBandwidths", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getOperatorAlphaLong()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOperatorAlphaLong()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOperatorAlphaLong", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getOperatorAlphaShort()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOperatorAlphaShort()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOperatorAlphaShort", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getOperatorNumeric()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetOperatorNumeric()
        {
            return IExecuteWithSignature<Java.Lang.String>("getOperatorNumeric", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#getNetworkRegistrationInfoList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telephony.NetworkRegistrationInfo> GetNetworkRegistrationInfoList()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telephony.NetworkRegistrationInfo>>("getNetworkRegistrationInfoList", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#setIsManualSelection(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIsManualSelection(bool arg0)
        {
            IExecuteWithSignature("setIsManualSelection", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#setOperatorName(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void SetOperatorName(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("setOperatorName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#setRoaming(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRoaming(bool arg0)
        {
            IExecuteWithSignature("setRoaming", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#setState(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetState(int arg0)
        {
            IExecuteWithSignature("setState", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#setStateOff()"/>
        /// </summary>
        public void SetStateOff()
        {
            IExecuteWithSignature("setStateOff", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#setStateOutOfService()"/>
        /// </summary>
        public void SetStateOutOfService()
        {
            IExecuteWithSignature("setStateOutOfService", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ServiceState.html#writeToParcel(android.os.Parcel,int)"/>
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