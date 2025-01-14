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

namespace Android.Service.Controls
{
    #region DeviceTypes declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html"/>
    /// </summary>
    public partial class DeviceTypes : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DeviceTypes>
    {
        const string _bridgeClassName = "android.service.controls.DeviceTypes";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DeviceTypes() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DeviceTypes(params object[] args) : base(args) { }
    
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

    #region DeviceTypes implementation
    public partial class DeviceTypes
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_AC_HEATER"/>
        /// </summary>
        public static int TYPE_AC_HEATER { get { if (!_TYPE_AC_HEATERReady) { _TYPE_AC_HEATERContent = SGetField<int>(LocalBridgeClazz, "TYPE_AC_HEATER"); _TYPE_AC_HEATERReady = true; } return _TYPE_AC_HEATERContent; } }
        private static int _TYPE_AC_HEATERContent = default;
        private static bool _TYPE_AC_HEATERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_AC_UNIT"/>
        /// </summary>
        public static int TYPE_AC_UNIT { get { if (!_TYPE_AC_UNITReady) { _TYPE_AC_UNITContent = SGetField<int>(LocalBridgeClazz, "TYPE_AC_UNIT"); _TYPE_AC_UNITReady = true; } return _TYPE_AC_UNITContent; } }
        private static int _TYPE_AC_UNITContent = default;
        private static bool _TYPE_AC_UNITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_AIR_FRESHENER"/>
        /// </summary>
        public static int TYPE_AIR_FRESHENER { get { if (!_TYPE_AIR_FRESHENERReady) { _TYPE_AIR_FRESHENERContent = SGetField<int>(LocalBridgeClazz, "TYPE_AIR_FRESHENER"); _TYPE_AIR_FRESHENERReady = true; } return _TYPE_AIR_FRESHENERContent; } }
        private static int _TYPE_AIR_FRESHENERContent = default;
        private static bool _TYPE_AIR_FRESHENERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_AIR_PURIFIER"/>
        /// </summary>
        public static int TYPE_AIR_PURIFIER { get { if (!_TYPE_AIR_PURIFIERReady) { _TYPE_AIR_PURIFIERContent = SGetField<int>(LocalBridgeClazz, "TYPE_AIR_PURIFIER"); _TYPE_AIR_PURIFIERReady = true; } return _TYPE_AIR_PURIFIERContent; } }
        private static int _TYPE_AIR_PURIFIERContent = default;
        private static bool _TYPE_AIR_PURIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_AWNING"/>
        /// </summary>
        public static int TYPE_AWNING { get { if (!_TYPE_AWNINGReady) { _TYPE_AWNINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_AWNING"); _TYPE_AWNINGReady = true; } return _TYPE_AWNINGContent; } }
        private static int _TYPE_AWNINGContent = default;
        private static bool _TYPE_AWNINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_BLINDS"/>
        /// </summary>
        public static int TYPE_BLINDS { get { if (!_TYPE_BLINDSReady) { _TYPE_BLINDSContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLINDS"); _TYPE_BLINDSReady = true; } return _TYPE_BLINDSContent; } }
        private static int _TYPE_BLINDSContent = default;
        private static bool _TYPE_BLINDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_CAMERA"/>
        /// </summary>
        public static int TYPE_CAMERA { get { if (!_TYPE_CAMERAReady) { _TYPE_CAMERAContent = SGetField<int>(LocalBridgeClazz, "TYPE_CAMERA"); _TYPE_CAMERAReady = true; } return _TYPE_CAMERAContent; } }
        private static int _TYPE_CAMERAContent = default;
        private static bool _TYPE_CAMERAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_CLOSET"/>
        /// </summary>
        public static int TYPE_CLOSET { get { if (!_TYPE_CLOSETReady) { _TYPE_CLOSETContent = SGetField<int>(LocalBridgeClazz, "TYPE_CLOSET"); _TYPE_CLOSETReady = true; } return _TYPE_CLOSETContent; } }
        private static int _TYPE_CLOSETContent = default;
        private static bool _TYPE_CLOSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_COFFEE_MAKER"/>
        /// </summary>
        public static int TYPE_COFFEE_MAKER { get { if (!_TYPE_COFFEE_MAKERReady) { _TYPE_COFFEE_MAKERContent = SGetField<int>(LocalBridgeClazz, "TYPE_COFFEE_MAKER"); _TYPE_COFFEE_MAKERReady = true; } return _TYPE_COFFEE_MAKERContent; } }
        private static int _TYPE_COFFEE_MAKERContent = default;
        private static bool _TYPE_COFFEE_MAKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_CURTAIN"/>
        /// </summary>
        public static int TYPE_CURTAIN { get { if (!_TYPE_CURTAINReady) { _TYPE_CURTAINContent = SGetField<int>(LocalBridgeClazz, "TYPE_CURTAIN"); _TYPE_CURTAINReady = true; } return _TYPE_CURTAINContent; } }
        private static int _TYPE_CURTAINContent = default;
        private static bool _TYPE_CURTAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DEHUMIDIFIER"/>
        /// </summary>
        public static int TYPE_DEHUMIDIFIER { get { if (!_TYPE_DEHUMIDIFIERReady) { _TYPE_DEHUMIDIFIERContent = SGetField<int>(LocalBridgeClazz, "TYPE_DEHUMIDIFIER"); _TYPE_DEHUMIDIFIERReady = true; } return _TYPE_DEHUMIDIFIERContent; } }
        private static int _TYPE_DEHUMIDIFIERContent = default;
        private static bool _TYPE_DEHUMIDIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DISHWASHER"/>
        /// </summary>
        public static int TYPE_DISHWASHER { get { if (!_TYPE_DISHWASHERReady) { _TYPE_DISHWASHERContent = SGetField<int>(LocalBridgeClazz, "TYPE_DISHWASHER"); _TYPE_DISHWASHERReady = true; } return _TYPE_DISHWASHERContent; } }
        private static int _TYPE_DISHWASHERContent = default;
        private static bool _TYPE_DISHWASHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DISPLAY"/>
        /// </summary>
        public static int TYPE_DISPLAY { get { if (!_TYPE_DISPLAYReady) { _TYPE_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_DISPLAY"); _TYPE_DISPLAYReady = true; } return _TYPE_DISPLAYContent; } }
        private static int _TYPE_DISPLAYContent = default;
        private static bool _TYPE_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DOOR"/>
        /// </summary>
        public static int TYPE_DOOR { get { if (!_TYPE_DOORReady) { _TYPE_DOORContent = SGetField<int>(LocalBridgeClazz, "TYPE_DOOR"); _TYPE_DOORReady = true; } return _TYPE_DOORContent; } }
        private static int _TYPE_DOORContent = default;
        private static bool _TYPE_DOORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DOORBELL"/>
        /// </summary>
        public static int TYPE_DOORBELL { get { if (!_TYPE_DOORBELLReady) { _TYPE_DOORBELLContent = SGetField<int>(LocalBridgeClazz, "TYPE_DOORBELL"); _TYPE_DOORBELLReady = true; } return _TYPE_DOORBELLContent; } }
        private static int _TYPE_DOORBELLContent = default;
        private static bool _TYPE_DOORBELLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DRAWER"/>
        /// </summary>
        public static int TYPE_DRAWER { get { if (!_TYPE_DRAWERReady) { _TYPE_DRAWERContent = SGetField<int>(LocalBridgeClazz, "TYPE_DRAWER"); _TYPE_DRAWERReady = true; } return _TYPE_DRAWERContent; } }
        private static int _TYPE_DRAWERContent = default;
        private static bool _TYPE_DRAWERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_DRYER"/>
        /// </summary>
        public static int TYPE_DRYER { get { if (!_TYPE_DRYERReady) { _TYPE_DRYERContent = SGetField<int>(LocalBridgeClazz, "TYPE_DRYER"); _TYPE_DRYERReady = true; } return _TYPE_DRYERContent; } }
        private static int _TYPE_DRYERContent = default;
        private static bool _TYPE_DRYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_FAN"/>
        /// </summary>
        public static int TYPE_FAN { get { if (!_TYPE_FANReady) { _TYPE_FANContent = SGetField<int>(LocalBridgeClazz, "TYPE_FAN"); _TYPE_FANReady = true; } return _TYPE_FANContent; } }
        private static int _TYPE_FANContent = default;
        private static bool _TYPE_FANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GARAGE"/>
        /// </summary>
        public static int TYPE_GARAGE { get { if (!_TYPE_GARAGEReady) { _TYPE_GARAGEContent = SGetField<int>(LocalBridgeClazz, "TYPE_GARAGE"); _TYPE_GARAGEReady = true; } return _TYPE_GARAGEContent; } }
        private static int _TYPE_GARAGEContent = default;
        private static bool _TYPE_GARAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GATE"/>
        /// </summary>
        public static int TYPE_GATE { get { if (!_TYPE_GATEReady) { _TYPE_GATEContent = SGetField<int>(LocalBridgeClazz, "TYPE_GATE"); _TYPE_GATEReady = true; } return _TYPE_GATEContent; } }
        private static int _TYPE_GATEContent = default;
        private static bool _TYPE_GATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_ARM_DISARM"/>
        /// </summary>
        public static int TYPE_GENERIC_ARM_DISARM { get { if (!_TYPE_GENERIC_ARM_DISARMReady) { _TYPE_GENERIC_ARM_DISARMContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_ARM_DISARM"); _TYPE_GENERIC_ARM_DISARMReady = true; } return _TYPE_GENERIC_ARM_DISARMContent; } }
        private static int _TYPE_GENERIC_ARM_DISARMContent = default;
        private static bool _TYPE_GENERIC_ARM_DISARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_LOCK_UNLOCK"/>
        /// </summary>
        public static int TYPE_GENERIC_LOCK_UNLOCK { get { if (!_TYPE_GENERIC_LOCK_UNLOCKReady) { _TYPE_GENERIC_LOCK_UNLOCKContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_LOCK_UNLOCK"); _TYPE_GENERIC_LOCK_UNLOCKReady = true; } return _TYPE_GENERIC_LOCK_UNLOCKContent; } }
        private static int _TYPE_GENERIC_LOCK_UNLOCKContent = default;
        private static bool _TYPE_GENERIC_LOCK_UNLOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_ON_OFF"/>
        /// </summary>
        public static int TYPE_GENERIC_ON_OFF { get { if (!_TYPE_GENERIC_ON_OFFReady) { _TYPE_GENERIC_ON_OFFContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_ON_OFF"); _TYPE_GENERIC_ON_OFFReady = true; } return _TYPE_GENERIC_ON_OFFContent; } }
        private static int _TYPE_GENERIC_ON_OFFContent = default;
        private static bool _TYPE_GENERIC_ON_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_OPEN_CLOSE"/>
        /// </summary>
        public static int TYPE_GENERIC_OPEN_CLOSE { get { if (!_TYPE_GENERIC_OPEN_CLOSEReady) { _TYPE_GENERIC_OPEN_CLOSEContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_OPEN_CLOSE"); _TYPE_GENERIC_OPEN_CLOSEReady = true; } return _TYPE_GENERIC_OPEN_CLOSEContent; } }
        private static int _TYPE_GENERIC_OPEN_CLOSEContent = default;
        private static bool _TYPE_GENERIC_OPEN_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_START_STOP"/>
        /// </summary>
        public static int TYPE_GENERIC_START_STOP { get { if (!_TYPE_GENERIC_START_STOPReady) { _TYPE_GENERIC_START_STOPContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_START_STOP"); _TYPE_GENERIC_START_STOPReady = true; } return _TYPE_GENERIC_START_STOPContent; } }
        private static int _TYPE_GENERIC_START_STOPContent = default;
        private static bool _TYPE_GENERIC_START_STOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_TEMP_SETTING"/>
        /// </summary>
        public static int TYPE_GENERIC_TEMP_SETTING { get { if (!_TYPE_GENERIC_TEMP_SETTINGReady) { _TYPE_GENERIC_TEMP_SETTINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_TEMP_SETTING"); _TYPE_GENERIC_TEMP_SETTINGReady = true; } return _TYPE_GENERIC_TEMP_SETTINGContent; } }
        private static int _TYPE_GENERIC_TEMP_SETTINGContent = default;
        private static bool _TYPE_GENERIC_TEMP_SETTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_GENERIC_VIEWSTREAM"/>
        /// </summary>
        public static int TYPE_GENERIC_VIEWSTREAM { get { if (!_TYPE_GENERIC_VIEWSTREAMReady) { _TYPE_GENERIC_VIEWSTREAMContent = SGetField<int>(LocalBridgeClazz, "TYPE_GENERIC_VIEWSTREAM"); _TYPE_GENERIC_VIEWSTREAMReady = true; } return _TYPE_GENERIC_VIEWSTREAMContent; } }
        private static int _TYPE_GENERIC_VIEWSTREAMContent = default;
        private static bool _TYPE_GENERIC_VIEWSTREAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_HEATER"/>
        /// </summary>
        public static int TYPE_HEATER { get { if (!_TYPE_HEATERReady) { _TYPE_HEATERContent = SGetField<int>(LocalBridgeClazz, "TYPE_HEATER"); _TYPE_HEATERReady = true; } return _TYPE_HEATERContent; } }
        private static int _TYPE_HEATERContent = default;
        private static bool _TYPE_HEATERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_HOOD"/>
        /// </summary>
        public static int TYPE_HOOD { get { if (!_TYPE_HOODReady) { _TYPE_HOODContent = SGetField<int>(LocalBridgeClazz, "TYPE_HOOD"); _TYPE_HOODReady = true; } return _TYPE_HOODContent; } }
        private static int _TYPE_HOODContent = default;
        private static bool _TYPE_HOODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_HUMIDIFIER"/>
        /// </summary>
        public static int TYPE_HUMIDIFIER { get { if (!_TYPE_HUMIDIFIERReady) { _TYPE_HUMIDIFIERContent = SGetField<int>(LocalBridgeClazz, "TYPE_HUMIDIFIER"); _TYPE_HUMIDIFIERReady = true; } return _TYPE_HUMIDIFIERContent; } }
        private static int _TYPE_HUMIDIFIERContent = default;
        private static bool _TYPE_HUMIDIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_KETTLE"/>
        /// </summary>
        public static int TYPE_KETTLE { get { if (!_TYPE_KETTLEReady) { _TYPE_KETTLEContent = SGetField<int>(LocalBridgeClazz, "TYPE_KETTLE"); _TYPE_KETTLEReady = true; } return _TYPE_KETTLEContent; } }
        private static int _TYPE_KETTLEContent = default;
        private static bool _TYPE_KETTLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_LIGHT"/>
        /// </summary>
        public static int TYPE_LIGHT { get { if (!_TYPE_LIGHTReady) { _TYPE_LIGHTContent = SGetField<int>(LocalBridgeClazz, "TYPE_LIGHT"); _TYPE_LIGHTReady = true; } return _TYPE_LIGHTContent; } }
        private static int _TYPE_LIGHTContent = default;
        private static bool _TYPE_LIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_LOCK"/>
        /// </summary>
        public static int TYPE_LOCK { get { if (!_TYPE_LOCKReady) { _TYPE_LOCKContent = SGetField<int>(LocalBridgeClazz, "TYPE_LOCK"); _TYPE_LOCKReady = true; } return _TYPE_LOCKContent; } }
        private static int _TYPE_LOCKContent = default;
        private static bool _TYPE_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_MICROWAVE"/>
        /// </summary>
        public static int TYPE_MICROWAVE { get { if (!_TYPE_MICROWAVEReady) { _TYPE_MICROWAVEContent = SGetField<int>(LocalBridgeClazz, "TYPE_MICROWAVE"); _TYPE_MICROWAVEReady = true; } return _TYPE_MICROWAVEContent; } }
        private static int _TYPE_MICROWAVEContent = default;
        private static bool _TYPE_MICROWAVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_MOP"/>
        /// </summary>
        public static int TYPE_MOP { get { if (!_TYPE_MOPReady) { _TYPE_MOPContent = SGetField<int>(LocalBridgeClazz, "TYPE_MOP"); _TYPE_MOPReady = true; } return _TYPE_MOPContent; } }
        private static int _TYPE_MOPContent = default;
        private static bool _TYPE_MOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_MOWER"/>
        /// </summary>
        public static int TYPE_MOWER { get { if (!_TYPE_MOWERReady) { _TYPE_MOWERContent = SGetField<int>(LocalBridgeClazz, "TYPE_MOWER"); _TYPE_MOWERReady = true; } return _TYPE_MOWERContent; } }
        private static int _TYPE_MOWERContent = default;
        private static bool _TYPE_MOWERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_MULTICOOKER"/>
        /// </summary>
        public static int TYPE_MULTICOOKER { get { if (!_TYPE_MULTICOOKERReady) { _TYPE_MULTICOOKERContent = SGetField<int>(LocalBridgeClazz, "TYPE_MULTICOOKER"); _TYPE_MULTICOOKERReady = true; } return _TYPE_MULTICOOKERContent; } }
        private static int _TYPE_MULTICOOKERContent = default;
        private static bool _TYPE_MULTICOOKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_OUTLET"/>
        /// </summary>
        public static int TYPE_OUTLET { get { if (!_TYPE_OUTLETReady) { _TYPE_OUTLETContent = SGetField<int>(LocalBridgeClazz, "TYPE_OUTLET"); _TYPE_OUTLETReady = true; } return _TYPE_OUTLETContent; } }
        private static int _TYPE_OUTLETContent = default;
        private static bool _TYPE_OUTLETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_PERGOLA"/>
        /// </summary>
        public static int TYPE_PERGOLA { get { if (!_TYPE_PERGOLAReady) { _TYPE_PERGOLAContent = SGetField<int>(LocalBridgeClazz, "TYPE_PERGOLA"); _TYPE_PERGOLAReady = true; } return _TYPE_PERGOLAContent; } }
        private static int _TYPE_PERGOLAContent = default;
        private static bool _TYPE_PERGOLAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_RADIATOR"/>
        /// </summary>
        public static int TYPE_RADIATOR { get { if (!_TYPE_RADIATORReady) { _TYPE_RADIATORContent = SGetField<int>(LocalBridgeClazz, "TYPE_RADIATOR"); _TYPE_RADIATORReady = true; } return _TYPE_RADIATORContent; } }
        private static int _TYPE_RADIATORContent = default;
        private static bool _TYPE_RADIATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_REFRIGERATOR"/>
        /// </summary>
        public static int TYPE_REFRIGERATOR { get { if (!_TYPE_REFRIGERATORReady) { _TYPE_REFRIGERATORContent = SGetField<int>(LocalBridgeClazz, "TYPE_REFRIGERATOR"); _TYPE_REFRIGERATORReady = true; } return _TYPE_REFRIGERATORContent; } }
        private static int _TYPE_REFRIGERATORContent = default;
        private static bool _TYPE_REFRIGERATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_REMOTE_CONTROL"/>
        /// </summary>
        public static int TYPE_REMOTE_CONTROL { get { if (!_TYPE_REMOTE_CONTROLReady) { _TYPE_REMOTE_CONTROLContent = SGetField<int>(LocalBridgeClazz, "TYPE_REMOTE_CONTROL"); _TYPE_REMOTE_CONTROLReady = true; } return _TYPE_REMOTE_CONTROLContent; } }
        private static int _TYPE_REMOTE_CONTROLContent = default;
        private static bool _TYPE_REMOTE_CONTROLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_ROUTINE"/>
        /// </summary>
        public static int TYPE_ROUTINE { get { if (!_TYPE_ROUTINEReady) { _TYPE_ROUTINEContent = SGetField<int>(LocalBridgeClazz, "TYPE_ROUTINE"); _TYPE_ROUTINEReady = true; } return _TYPE_ROUTINEContent; } }
        private static int _TYPE_ROUTINEContent = default;
        private static bool _TYPE_ROUTINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_SECURITY_SYSTEM"/>
        /// </summary>
        public static int TYPE_SECURITY_SYSTEM { get { if (!_TYPE_SECURITY_SYSTEMReady) { _TYPE_SECURITY_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "TYPE_SECURITY_SYSTEM"); _TYPE_SECURITY_SYSTEMReady = true; } return _TYPE_SECURITY_SYSTEMContent; } }
        private static int _TYPE_SECURITY_SYSTEMContent = default;
        private static bool _TYPE_SECURITY_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_SET_TOP"/>
        /// </summary>
        public static int TYPE_SET_TOP { get { if (!_TYPE_SET_TOPReady) { _TYPE_SET_TOPContent = SGetField<int>(LocalBridgeClazz, "TYPE_SET_TOP"); _TYPE_SET_TOPReady = true; } return _TYPE_SET_TOPContent; } }
        private static int _TYPE_SET_TOPContent = default;
        private static bool _TYPE_SET_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_SHOWER"/>
        /// </summary>
        public static int TYPE_SHOWER { get { if (!_TYPE_SHOWERReady) { _TYPE_SHOWERContent = SGetField<int>(LocalBridgeClazz, "TYPE_SHOWER"); _TYPE_SHOWERReady = true; } return _TYPE_SHOWERContent; } }
        private static int _TYPE_SHOWERContent = default;
        private static bool _TYPE_SHOWERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_SHUTTER"/>
        /// </summary>
        public static int TYPE_SHUTTER { get { if (!_TYPE_SHUTTERReady) { _TYPE_SHUTTERContent = SGetField<int>(LocalBridgeClazz, "TYPE_SHUTTER"); _TYPE_SHUTTERReady = true; } return _TYPE_SHUTTERContent; } }
        private static int _TYPE_SHUTTERContent = default;
        private static bool _TYPE_SHUTTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_SPRINKLER"/>
        /// </summary>
        public static int TYPE_SPRINKLER { get { if (!_TYPE_SPRINKLERReady) { _TYPE_SPRINKLERContent = SGetField<int>(LocalBridgeClazz, "TYPE_SPRINKLER"); _TYPE_SPRINKLERReady = true; } return _TYPE_SPRINKLERContent; } }
        private static int _TYPE_SPRINKLERContent = default;
        private static bool _TYPE_SPRINKLERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_STANDMIXER"/>
        /// </summary>
        public static int TYPE_STANDMIXER { get { if (!_TYPE_STANDMIXERReady) { _TYPE_STANDMIXERContent = SGetField<int>(LocalBridgeClazz, "TYPE_STANDMIXER"); _TYPE_STANDMIXERReady = true; } return _TYPE_STANDMIXERContent; } }
        private static int _TYPE_STANDMIXERContent = default;
        private static bool _TYPE_STANDMIXERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_STYLER"/>
        /// </summary>
        public static int TYPE_STYLER { get { if (!_TYPE_STYLERReady) { _TYPE_STYLERContent = SGetField<int>(LocalBridgeClazz, "TYPE_STYLER"); _TYPE_STYLERReady = true; } return _TYPE_STYLERContent; } }
        private static int _TYPE_STYLERContent = default;
        private static bool _TYPE_STYLERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_SWITCH"/>
        /// </summary>
        public static int TYPE_SWITCH { get { if (!_TYPE_SWITCHReady) { _TYPE_SWITCHContent = SGetField<int>(LocalBridgeClazz, "TYPE_SWITCH"); _TYPE_SWITCHReady = true; } return _TYPE_SWITCHContent; } }
        private static int _TYPE_SWITCHContent = default;
        private static bool _TYPE_SWITCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_THERMOSTAT"/>
        /// </summary>
        public static int TYPE_THERMOSTAT { get { if (!_TYPE_THERMOSTATReady) { _TYPE_THERMOSTATContent = SGetField<int>(LocalBridgeClazz, "TYPE_THERMOSTAT"); _TYPE_THERMOSTATReady = true; } return _TYPE_THERMOSTATContent; } }
        private static int _TYPE_THERMOSTATContent = default;
        private static bool _TYPE_THERMOSTATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_TV"/>
        /// </summary>
        public static int TYPE_TV { get { if (!_TYPE_TVReady) { _TYPE_TVContent = SGetField<int>(LocalBridgeClazz, "TYPE_TV"); _TYPE_TVReady = true; } return _TYPE_TVContent; } }
        private static int _TYPE_TVContent = default;
        private static bool _TYPE_TVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_VACUUM"/>
        /// </summary>
        public static int TYPE_VACUUM { get { if (!_TYPE_VACUUMReady) { _TYPE_VACUUMContent = SGetField<int>(LocalBridgeClazz, "TYPE_VACUUM"); _TYPE_VACUUMReady = true; } return _TYPE_VACUUMContent; } }
        private static int _TYPE_VACUUMContent = default;
        private static bool _TYPE_VACUUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_VALVE"/>
        /// </summary>
        public static int TYPE_VALVE { get { if (!_TYPE_VALVEReady) { _TYPE_VALVEContent = SGetField<int>(LocalBridgeClazz, "TYPE_VALVE"); _TYPE_VALVEReady = true; } return _TYPE_VALVEContent; } }
        private static int _TYPE_VALVEContent = default;
        private static bool _TYPE_VALVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_WASHER"/>
        /// </summary>
        public static int TYPE_WASHER { get { if (!_TYPE_WASHERReady) { _TYPE_WASHERContent = SGetField<int>(LocalBridgeClazz, "TYPE_WASHER"); _TYPE_WASHERReady = true; } return _TYPE_WASHERContent; } }
        private static int _TYPE_WASHERContent = default;
        private static bool _TYPE_WASHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_WATER_HEATER"/>
        /// </summary>
        public static int TYPE_WATER_HEATER { get { if (!_TYPE_WATER_HEATERReady) { _TYPE_WATER_HEATERContent = SGetField<int>(LocalBridgeClazz, "TYPE_WATER_HEATER"); _TYPE_WATER_HEATERReady = true; } return _TYPE_WATER_HEATERContent; } }
        private static int _TYPE_WATER_HEATERContent = default;
        private static bool _TYPE_WATER_HEATERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#TYPE_WINDOW"/>
        /// </summary>
        public static int TYPE_WINDOW { get { if (!_TYPE_WINDOWReady) { _TYPE_WINDOWContent = SGetField<int>(LocalBridgeClazz, "TYPE_WINDOW"); _TYPE_WINDOWReady = true; } return _TYPE_WINDOWContent; } }
        private static int _TYPE_WINDOWContent = default;
        private static bool _TYPE_WINDOWReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/DeviceTypes.html#validDeviceType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ValidDeviceType(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "validDeviceType", "(I)Z", arg0);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}