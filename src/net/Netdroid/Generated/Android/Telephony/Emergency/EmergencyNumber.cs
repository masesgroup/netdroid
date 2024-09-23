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

namespace Android.Telephony.Emergency
{
    #region EmergencyNumber declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html"/>
    /// </summary>
    public partial class EmergencyNumber : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EmergencyNumber>
    {
        const string _bridgeClassName = "android.telephony.emergency.EmergencyNumber";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EmergencyNumber() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EmergencyNumber(params object[] args) : base(args) { }
    
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

    #region EmergencyNumber implementation
    public partial class EmergencyNumber : Android.Os.IParcelable, Java.Lang.IComparable<Android.Telephony.Emergency.EmergencyNumber>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Telephony.Emergency.EmergencyNumber"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Telephony.Emergency.EmergencyNumber t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Telephony.Emergency.EmergencyNumber"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Android.Telephony.Emergency.EmergencyNumber t) => t.Cast<Java.Lang.Comparable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_CALL_ROUTING_EMERGENCY"/>
        /// </summary>
        public static int EMERGENCY_CALL_ROUTING_EMERGENCY { get { if (!_EMERGENCY_CALL_ROUTING_EMERGENCYReady) { _EMERGENCY_CALL_ROUTING_EMERGENCYContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_CALL_ROUTING_EMERGENCY"); _EMERGENCY_CALL_ROUTING_EMERGENCYReady = true; } return _EMERGENCY_CALL_ROUTING_EMERGENCYContent; } }
        private static int _EMERGENCY_CALL_ROUTING_EMERGENCYContent = default;
        private static bool _EMERGENCY_CALL_ROUTING_EMERGENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_CALL_ROUTING_NORMAL"/>
        /// </summary>
        public static int EMERGENCY_CALL_ROUTING_NORMAL { get { if (!_EMERGENCY_CALL_ROUTING_NORMALReady) { _EMERGENCY_CALL_ROUTING_NORMALContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_CALL_ROUTING_NORMAL"); _EMERGENCY_CALL_ROUTING_NORMALReady = true; } return _EMERGENCY_CALL_ROUTING_NORMALContent; } }
        private static int _EMERGENCY_CALL_ROUTING_NORMALContent = default;
        private static bool _EMERGENCY_CALL_ROUTING_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_CALL_ROUTING_UNKNOWN"/>
        /// </summary>
        public static int EMERGENCY_CALL_ROUTING_UNKNOWN { get { if (!_EMERGENCY_CALL_ROUTING_UNKNOWNReady) { _EMERGENCY_CALL_ROUTING_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_CALL_ROUTING_UNKNOWN"); _EMERGENCY_CALL_ROUTING_UNKNOWNReady = true; } return _EMERGENCY_CALL_ROUTING_UNKNOWNContent; } }
        private static int _EMERGENCY_CALL_ROUTING_UNKNOWNContent = default;
        private static bool _EMERGENCY_CALL_ROUTING_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_NUMBER_SOURCE_DATABASE"/>
        /// </summary>
        public static int EMERGENCY_NUMBER_SOURCE_DATABASE { get { if (!_EMERGENCY_NUMBER_SOURCE_DATABASEReady) { _EMERGENCY_NUMBER_SOURCE_DATABASEContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_NUMBER_SOURCE_DATABASE"); _EMERGENCY_NUMBER_SOURCE_DATABASEReady = true; } return _EMERGENCY_NUMBER_SOURCE_DATABASEContent; } }
        private static int _EMERGENCY_NUMBER_SOURCE_DATABASEContent = default;
        private static bool _EMERGENCY_NUMBER_SOURCE_DATABASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_NUMBER_SOURCE_DEFAULT"/>
        /// </summary>
        public static int EMERGENCY_NUMBER_SOURCE_DEFAULT { get { if (!_EMERGENCY_NUMBER_SOURCE_DEFAULTReady) { _EMERGENCY_NUMBER_SOURCE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_NUMBER_SOURCE_DEFAULT"); _EMERGENCY_NUMBER_SOURCE_DEFAULTReady = true; } return _EMERGENCY_NUMBER_SOURCE_DEFAULTContent; } }
        private static int _EMERGENCY_NUMBER_SOURCE_DEFAULTContent = default;
        private static bool _EMERGENCY_NUMBER_SOURCE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_NUMBER_SOURCE_MODEM_CONFIG"/>
        /// </summary>
        public static int EMERGENCY_NUMBER_SOURCE_MODEM_CONFIG { get { if (!_EMERGENCY_NUMBER_SOURCE_MODEM_CONFIGReady) { _EMERGENCY_NUMBER_SOURCE_MODEM_CONFIGContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_NUMBER_SOURCE_MODEM_CONFIG"); _EMERGENCY_NUMBER_SOURCE_MODEM_CONFIGReady = true; } return _EMERGENCY_NUMBER_SOURCE_MODEM_CONFIGContent; } }
        private static int _EMERGENCY_NUMBER_SOURCE_MODEM_CONFIGContent = default;
        private static bool _EMERGENCY_NUMBER_SOURCE_MODEM_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALING"/>
        /// </summary>
        public static int EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALING { get { if (!_EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALINGReady) { _EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALINGContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALING"); _EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALINGReady = true; } return _EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALINGContent; } }
        private static int _EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALINGContent = default;
        private static bool _EMERGENCY_NUMBER_SOURCE_NETWORK_SIGNALINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_NUMBER_SOURCE_SIM"/>
        /// </summary>
        public static int EMERGENCY_NUMBER_SOURCE_SIM { get { if (!_EMERGENCY_NUMBER_SOURCE_SIMReady) { _EMERGENCY_NUMBER_SOURCE_SIMContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_NUMBER_SOURCE_SIM"); _EMERGENCY_NUMBER_SOURCE_SIMReady = true; } return _EMERGENCY_NUMBER_SOURCE_SIMContent; } }
        private static int _EMERGENCY_NUMBER_SOURCE_SIMContent = default;
        private static bool _EMERGENCY_NUMBER_SOURCE_SIMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_AIEC"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_AIEC { get { if (!_EMERGENCY_SERVICE_CATEGORY_AIECReady) { _EMERGENCY_SERVICE_CATEGORY_AIECContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_AIEC"); _EMERGENCY_SERVICE_CATEGORY_AIECReady = true; } return _EMERGENCY_SERVICE_CATEGORY_AIECContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_AIECContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_AIECReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_AMBULANCE"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_AMBULANCE { get { if (!_EMERGENCY_SERVICE_CATEGORY_AMBULANCEReady) { _EMERGENCY_SERVICE_CATEGORY_AMBULANCEContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_AMBULANCE"); _EMERGENCY_SERVICE_CATEGORY_AMBULANCEReady = true; } return _EMERGENCY_SERVICE_CATEGORY_AMBULANCEContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_AMBULANCEContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_AMBULANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADE"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADE { get { if (!_EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADEReady) { _EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADEContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADE"); _EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADEReady = true; } return _EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADEContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADEContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_FIRE_BRIGADEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_MARINE_GUARD"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_MARINE_GUARD { get { if (!_EMERGENCY_SERVICE_CATEGORY_MARINE_GUARDReady) { _EMERGENCY_SERVICE_CATEGORY_MARINE_GUARDContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_MARINE_GUARD"); _EMERGENCY_SERVICE_CATEGORY_MARINE_GUARDReady = true; } return _EMERGENCY_SERVICE_CATEGORY_MARINE_GUARDContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_MARINE_GUARDContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_MARINE_GUARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_MIEC"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_MIEC { get { if (!_EMERGENCY_SERVICE_CATEGORY_MIECReady) { _EMERGENCY_SERVICE_CATEGORY_MIECContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_MIEC"); _EMERGENCY_SERVICE_CATEGORY_MIECReady = true; } return _EMERGENCY_SERVICE_CATEGORY_MIECContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_MIECContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_MIECReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUE"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUE { get { if (!_EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUEReady) { _EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUEContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUE"); _EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUEReady = true; } return _EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUEContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUEContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_MOUNTAIN_RESCUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_POLICE"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_POLICE { get { if (!_EMERGENCY_SERVICE_CATEGORY_POLICEReady) { _EMERGENCY_SERVICE_CATEGORY_POLICEContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_POLICE"); _EMERGENCY_SERVICE_CATEGORY_POLICEReady = true; } return _EMERGENCY_SERVICE_CATEGORY_POLICEContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_POLICEContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_POLICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#EMERGENCY_SERVICE_CATEGORY_UNSPECIFIED"/>
        /// </summary>
        public static int EMERGENCY_SERVICE_CATEGORY_UNSPECIFIED { get { if (!_EMERGENCY_SERVICE_CATEGORY_UNSPECIFIEDReady) { _EMERGENCY_SERVICE_CATEGORY_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "EMERGENCY_SERVICE_CATEGORY_UNSPECIFIED"); _EMERGENCY_SERVICE_CATEGORY_UNSPECIFIEDReady = true; } return _EMERGENCY_SERVICE_CATEGORY_UNSPECIFIEDContent; } }
        private static int _EMERGENCY_SERVICE_CATEGORY_UNSPECIFIEDContent = default;
        private static bool _EMERGENCY_SERVICE_CATEGORY_UNSPECIFIEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#isFromSources(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFromSources(int arg0)
        {
            return IExecuteWithSignature<bool>("isFromSources", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#isInEmergencyServiceCategories(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsInEmergencyServiceCategories(int arg0)
        {
            return IExecuteWithSignature<bool>("isInEmergencyServiceCategories", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#compareTo(android.telephony.emergency.EmergencyNumber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Emergency.EmergencyNumber"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Telephony.Emergency.EmergencyNumber arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/telephony/emergency/EmergencyNumber;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getEmergencyCallRouting()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEmergencyCallRouting()
        {
            return IExecuteWithSignature<int>("getEmergencyCallRouting", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getCountryIso()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCountryIso()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCountryIso", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getMnc()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMnc()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMnc", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNumber()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNumber", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getEmergencyNumberSources()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> GetEmergencyNumberSources()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getEmergencyNumberSources", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getEmergencyServiceCategories()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> GetEmergencyServiceCategories()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getEmergencyServiceCategories", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#getEmergencyUrns()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetEmergencyUrns()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getEmergencyUrns", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/emergency/EmergencyNumber.html#writeToParcel(android.os.Parcel,int)"/>
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