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

namespace Android.Net.Wifi.Rtt
{
    #region CivicLocationKeys declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html"/>
    /// </summary>
    public partial class CivicLocationKeys : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CivicLocationKeys>
    {
        const string _bridgeClassName = "android.net.wifi.rtt.CivicLocationKeys";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CivicLocationKeys() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CivicLocationKeys(params object[] args) : base(args) { }
    
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

    #region CivicLocationKeys implementation
    public partial class CivicLocationKeys
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#ADDITIONAL_CODE"/>
        /// </summary>
        public static int ADDITIONAL_CODE { get { if (!_ADDITIONAL_CODEReady) { _ADDITIONAL_CODEContent = SGetField<int>(LocalBridgeClazz, "ADDITIONAL_CODE"); _ADDITIONAL_CODEReady = true; } return _ADDITIONAL_CODEContent; } }
        private static int _ADDITIONAL_CODEContent = default;
        private static bool _ADDITIONAL_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#APT"/>
        /// </summary>
        public static int APT { get { if (!_APTReady) { _APTContent = SGetField<int>(LocalBridgeClazz, "APT"); _APTReady = true; } return _APTContent; } }
        private static int _APTContent = default;
        private static bool _APTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#BOROUGH"/>
        /// </summary>
        public static int BOROUGH { get { if (!_BOROUGHReady) { _BOROUGHContent = SGetField<int>(LocalBridgeClazz, "BOROUGH"); _BOROUGHReady = true; } return _BOROUGHContent; } }
        private static int _BOROUGHContent = default;
        private static bool _BOROUGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#BRANCH_ROAD_NAME"/>
        /// </summary>
        public static int BRANCH_ROAD_NAME { get { if (!_BRANCH_ROAD_NAMEReady) { _BRANCH_ROAD_NAMEContent = SGetField<int>(LocalBridgeClazz, "BRANCH_ROAD_NAME"); _BRANCH_ROAD_NAMEReady = true; } return _BRANCH_ROAD_NAMEContent; } }
        private static int _BRANCH_ROAD_NAMEContent = default;
        private static bool _BRANCH_ROAD_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#BUILDING"/>
        /// </summary>
        public static int BUILDING { get { if (!_BUILDINGReady) { _BUILDINGContent = SGetField<int>(LocalBridgeClazz, "BUILDING"); _BUILDINGReady = true; } return _BUILDINGContent; } }
        private static int _BUILDINGContent = default;
        private static bool _BUILDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#CITY"/>
        /// </summary>
        public static int CITY { get { if (!_CITYReady) { _CITYContent = SGetField<int>(LocalBridgeClazz, "CITY"); _CITYReady = true; } return _CITYContent; } }
        private static int _CITYContent = default;
        private static bool _CITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#COUNTY"/>
        /// </summary>
        public static int COUNTY { get { if (!_COUNTYReady) { _COUNTYContent = SGetField<int>(LocalBridgeClazz, "COUNTY"); _COUNTYReady = true; } return _COUNTYContent; } }
        private static int _COUNTYContent = default;
        private static bool _COUNTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#DESK"/>
        /// </summary>
        public static int DESK { get { if (!_DESKReady) { _DESKContent = SGetField<int>(LocalBridgeClazz, "DESK"); _DESKReady = true; } return _DESKContent; } }
        private static int _DESKContent = default;
        private static bool _DESKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#FLOOR"/>
        /// </summary>
        public static int FLOOR { get { if (!_FLOORReady) { _FLOORContent = SGetField<int>(LocalBridgeClazz, "FLOOR"); _FLOORReady = true; } return _FLOORContent; } }
        private static int _FLOORContent = default;
        private static bool _FLOORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#GROUP_OF_STREETS"/>
        /// </summary>
        public static int GROUP_OF_STREETS { get { if (!_GROUP_OF_STREETSReady) { _GROUP_OF_STREETSContent = SGetField<int>(LocalBridgeClazz, "GROUP_OF_STREETS"); _GROUP_OF_STREETSReady = true; } return _GROUP_OF_STREETSContent; } }
        private static int _GROUP_OF_STREETSContent = default;
        private static bool _GROUP_OF_STREETSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#HNO"/>
        /// </summary>
        public static int HNO { get { if (!_HNOReady) { _HNOContent = SGetField<int>(LocalBridgeClazz, "HNO"); _HNOReady = true; } return _HNOContent; } }
        private static int _HNOContent = default;
        private static bool _HNOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#HNS"/>
        /// </summary>
        public static int HNS { get { if (!_HNSReady) { _HNSContent = SGetField<int>(LocalBridgeClazz, "HNS"); _HNSReady = true; } return _HNSContent; } }
        private static int _HNSContent = default;
        private static bool _HNSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#LANGUAGE"/>
        /// </summary>
        public static int LANGUAGE { get { if (!_LANGUAGEReady) { _LANGUAGEContent = SGetField<int>(LocalBridgeClazz, "LANGUAGE"); _LANGUAGEReady = true; } return _LANGUAGEContent; } }
        private static int _LANGUAGEContent = default;
        private static bool _LANGUAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#LMK"/>
        /// </summary>
        public static int LMK { get { if (!_LMKReady) { _LMKContent = SGetField<int>(LocalBridgeClazz, "LMK"); _LMKReady = true; } return _LMKContent; } }
        private static int _LMKContent = default;
        private static bool _LMKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#LOC"/>
        /// </summary>
        public static int LOC { get { if (!_LOCReady) { _LOCContent = SGetField<int>(LocalBridgeClazz, "LOC"); _LOCReady = true; } return _LOCContent; } }
        private static int _LOCContent = default;
        private static bool _LOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#NAM"/>
        /// </summary>
        public static int NAM { get { if (!_NAMReady) { _NAMContent = SGetField<int>(LocalBridgeClazz, "NAM"); _NAMReady = true; } return _NAMContent; } }
        private static int _NAMContent = default;
        private static bool _NAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#NEIGHBORHOOD"/>
        /// </summary>
        public static int NEIGHBORHOOD { get { if (!_NEIGHBORHOODReady) { _NEIGHBORHOODContent = SGetField<int>(LocalBridgeClazz, "NEIGHBORHOOD"); _NEIGHBORHOODReady = true; } return _NEIGHBORHOODContent; } }
        private static int _NEIGHBORHOODContent = default;
        private static bool _NEIGHBORHOODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#PCN"/>
        /// </summary>
        public static int PCN { get { if (!_PCNReady) { _PCNContent = SGetField<int>(LocalBridgeClazz, "PCN"); _PCNReady = true; } return _PCNContent; } }
        private static int _PCNContent = default;
        private static bool _PCNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#PO_BOX"/>
        /// </summary>
        public static int PO_BOX { get { if (!_PO_BOXReady) { _PO_BOXContent = SGetField<int>(LocalBridgeClazz, "PO_BOX"); _PO_BOXReady = true; } return _PO_BOXContent; } }
        private static int _PO_BOXContent = default;
        private static bool _PO_BOXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#POD"/>
        /// </summary>
        public static int POD { get { if (!_PODReady) { _PODContent = SGetField<int>(LocalBridgeClazz, "POD"); _PODReady = true; } return _PODContent; } }
        private static int _PODContent = default;
        private static bool _PODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#POSTAL_CODE"/>
        /// </summary>
        public static int POSTAL_CODE { get { if (!_POSTAL_CODEReady) { _POSTAL_CODEContent = SGetField<int>(LocalBridgeClazz, "POSTAL_CODE"); _POSTAL_CODEReady = true; } return _POSTAL_CODEContent; } }
        private static int _POSTAL_CODEContent = default;
        private static bool _POSTAL_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#PRD"/>
        /// </summary>
        public static int PRD { get { if (!_PRDReady) { _PRDContent = SGetField<int>(LocalBridgeClazz, "PRD"); _PRDReady = true; } return _PRDContent; } }
        private static int _PRDContent = default;
        private static bool _PRDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#PRIMARY_ROAD_NAME"/>
        /// </summary>
        public static int PRIMARY_ROAD_NAME { get { if (!_PRIMARY_ROAD_NAMEReady) { _PRIMARY_ROAD_NAMEContent = SGetField<int>(LocalBridgeClazz, "PRIMARY_ROAD_NAME"); _PRIMARY_ROAD_NAMEReady = true; } return _PRIMARY_ROAD_NAMEContent; } }
        private static int _PRIMARY_ROAD_NAMEContent = default;
        private static bool _PRIMARY_ROAD_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#ROAD_SECTION"/>
        /// </summary>
        public static int ROAD_SECTION { get { if (!_ROAD_SECTIONReady) { _ROAD_SECTIONContent = SGetField<int>(LocalBridgeClazz, "ROAD_SECTION"); _ROAD_SECTIONReady = true; } return _ROAD_SECTIONContent; } }
        private static int _ROAD_SECTIONContent = default;
        private static bool _ROAD_SECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#ROOM"/>
        /// </summary>
        public static int ROOM { get { if (!_ROOMReady) { _ROOMContent = SGetField<int>(LocalBridgeClazz, "ROOM"); _ROOMReady = true; } return _ROOMContent; } }
        private static int _ROOMContent = default;
        private static bool _ROOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#SCRIPT"/>
        /// </summary>
        public static int SCRIPT { get { if (!_SCRIPTReady) { _SCRIPTContent = SGetField<int>(LocalBridgeClazz, "SCRIPT"); _SCRIPTReady = true; } return _SCRIPTContent; } }
        private static int _SCRIPTContent = default;
        private static bool _SCRIPTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#STATE"/>
        /// </summary>
        public static int STATE { get { if (!_STATEReady) { _STATEContent = SGetField<int>(LocalBridgeClazz, "STATE"); _STATEReady = true; } return _STATEContent; } }
        private static int _STATEContent = default;
        private static bool _STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#STREET_NAME_POST_MODIFIER"/>
        /// </summary>
        public static int STREET_NAME_POST_MODIFIER { get { if (!_STREET_NAME_POST_MODIFIERReady) { _STREET_NAME_POST_MODIFIERContent = SGetField<int>(LocalBridgeClazz, "STREET_NAME_POST_MODIFIER"); _STREET_NAME_POST_MODIFIERReady = true; } return _STREET_NAME_POST_MODIFIERContent; } }
        private static int _STREET_NAME_POST_MODIFIERContent = default;
        private static bool _STREET_NAME_POST_MODIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#STREET_NAME_PRE_MODIFIER"/>
        /// </summary>
        public static int STREET_NAME_PRE_MODIFIER { get { if (!_STREET_NAME_PRE_MODIFIERReady) { _STREET_NAME_PRE_MODIFIERContent = SGetField<int>(LocalBridgeClazz, "STREET_NAME_PRE_MODIFIER"); _STREET_NAME_PRE_MODIFIERReady = true; } return _STREET_NAME_PRE_MODIFIERContent; } }
        private static int _STREET_NAME_PRE_MODIFIERContent = default;
        private static bool _STREET_NAME_PRE_MODIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#STS"/>
        /// </summary>
        public static int STS { get { if (!_STSReady) { _STSContent = SGetField<int>(LocalBridgeClazz, "STS"); _STSReady = true; } return _STSContent; } }
        private static int _STSContent = default;
        private static bool _STSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#SUBBRANCH_ROAD_NAME"/>
        /// </summary>
        public static int SUBBRANCH_ROAD_NAME { get { if (!_SUBBRANCH_ROAD_NAMEReady) { _SUBBRANCH_ROAD_NAMEContent = SGetField<int>(LocalBridgeClazz, "SUBBRANCH_ROAD_NAME"); _SUBBRANCH_ROAD_NAMEReady = true; } return _SUBBRANCH_ROAD_NAMEContent; } }
        private static int _SUBBRANCH_ROAD_NAMEContent = default;
        private static bool _SUBBRANCH_ROAD_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/rtt/CivicLocationKeys.html#TYPE_OF_PLACE"/>
        /// </summary>
        public static int TYPE_OF_PLACE { get { if (!_TYPE_OF_PLACEReady) { _TYPE_OF_PLACEContent = SGetField<int>(LocalBridgeClazz, "TYPE_OF_PLACE"); _TYPE_OF_PLACEReady = true; } return _TYPE_OF_PLACEContent; } }
        private static int _TYPE_OF_PLACEContent = default;
        private static bool _TYPE_OF_PLACEReady = false; // this is used because in case of generics 
    
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
}