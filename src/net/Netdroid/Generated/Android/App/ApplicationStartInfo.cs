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

namespace Android.App
{
    #region ApplicationStartInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html"/>
    /// </summary>
    public partial class ApplicationStartInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.ApplicationStartInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ApplicationStartInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ApplicationStartInfo(params object[] args) : base(args) { }

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

    #region ApplicationStartInfo implementation
    public partial class ApplicationStartInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#LAUNCH_MODE_SINGLE_INSTANCE"/>
        /// </summary>
        public static int LAUNCH_MODE_SINGLE_INSTANCE { get { if (!_LAUNCH_MODE_SINGLE_INSTANCEReady) { _LAUNCH_MODE_SINGLE_INSTANCEContent = SGetField<int>(LocalBridgeClazz, "LAUNCH_MODE_SINGLE_INSTANCE"); _LAUNCH_MODE_SINGLE_INSTANCEReady = true; } return _LAUNCH_MODE_SINGLE_INSTANCEContent; } }
        private static int _LAUNCH_MODE_SINGLE_INSTANCEContent = default;
        private static bool _LAUNCH_MODE_SINGLE_INSTANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#LAUNCH_MODE_SINGLE_INSTANCE_PER_TASK"/>
        /// </summary>
        public static int LAUNCH_MODE_SINGLE_INSTANCE_PER_TASK { get { if (!_LAUNCH_MODE_SINGLE_INSTANCE_PER_TASKReady) { _LAUNCH_MODE_SINGLE_INSTANCE_PER_TASKContent = SGetField<int>(LocalBridgeClazz, "LAUNCH_MODE_SINGLE_INSTANCE_PER_TASK"); _LAUNCH_MODE_SINGLE_INSTANCE_PER_TASKReady = true; } return _LAUNCH_MODE_SINGLE_INSTANCE_PER_TASKContent; } }
        private static int _LAUNCH_MODE_SINGLE_INSTANCE_PER_TASKContent = default;
        private static bool _LAUNCH_MODE_SINGLE_INSTANCE_PER_TASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#LAUNCH_MODE_SINGLE_TASK"/>
        /// </summary>
        public static int LAUNCH_MODE_SINGLE_TASK { get { if (!_LAUNCH_MODE_SINGLE_TASKReady) { _LAUNCH_MODE_SINGLE_TASKContent = SGetField<int>(LocalBridgeClazz, "LAUNCH_MODE_SINGLE_TASK"); _LAUNCH_MODE_SINGLE_TASKReady = true; } return _LAUNCH_MODE_SINGLE_TASKContent; } }
        private static int _LAUNCH_MODE_SINGLE_TASKContent = default;
        private static bool _LAUNCH_MODE_SINGLE_TASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#LAUNCH_MODE_SINGLE_TOP"/>
        /// </summary>
        public static int LAUNCH_MODE_SINGLE_TOP { get { if (!_LAUNCH_MODE_SINGLE_TOPReady) { _LAUNCH_MODE_SINGLE_TOPContent = SGetField<int>(LocalBridgeClazz, "LAUNCH_MODE_SINGLE_TOP"); _LAUNCH_MODE_SINGLE_TOPReady = true; } return _LAUNCH_MODE_SINGLE_TOPContent; } }
        private static int _LAUNCH_MODE_SINGLE_TOPContent = default;
        private static bool _LAUNCH_MODE_SINGLE_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#LAUNCH_MODE_STANDARD"/>
        /// </summary>
        public static int LAUNCH_MODE_STANDARD { get { if (!_LAUNCH_MODE_STANDARDReady) { _LAUNCH_MODE_STANDARDContent = SGetField<int>(LocalBridgeClazz, "LAUNCH_MODE_STANDARD"); _LAUNCH_MODE_STANDARDReady = true; } return _LAUNCH_MODE_STANDARDContent; } }
        private static int _LAUNCH_MODE_STANDARDContent = default;
        private static bool _LAUNCH_MODE_STANDARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_ALARM"/>
        /// </summary>
        public static int START_REASON_ALARM { get { if (!_START_REASON_ALARMReady) { _START_REASON_ALARMContent = SGetField<int>(LocalBridgeClazz, "START_REASON_ALARM"); _START_REASON_ALARMReady = true; } return _START_REASON_ALARMContent; } }
        private static int _START_REASON_ALARMContent = default;
        private static bool _START_REASON_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_BACKUP"/>
        /// </summary>
        public static int START_REASON_BACKUP { get { if (!_START_REASON_BACKUPReady) { _START_REASON_BACKUPContent = SGetField<int>(LocalBridgeClazz, "START_REASON_BACKUP"); _START_REASON_BACKUPReady = true; } return _START_REASON_BACKUPContent; } }
        private static int _START_REASON_BACKUPContent = default;
        private static bool _START_REASON_BACKUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_BOOT_COMPLETE"/>
        /// </summary>
        public static int START_REASON_BOOT_COMPLETE { get { if (!_START_REASON_BOOT_COMPLETEReady) { _START_REASON_BOOT_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "START_REASON_BOOT_COMPLETE"); _START_REASON_BOOT_COMPLETEReady = true; } return _START_REASON_BOOT_COMPLETEContent; } }
        private static int _START_REASON_BOOT_COMPLETEContent = default;
        private static bool _START_REASON_BOOT_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_BROADCAST"/>
        /// </summary>
        public static int START_REASON_BROADCAST { get { if (!_START_REASON_BROADCASTReady) { _START_REASON_BROADCASTContent = SGetField<int>(LocalBridgeClazz, "START_REASON_BROADCAST"); _START_REASON_BROADCASTReady = true; } return _START_REASON_BROADCASTContent; } }
        private static int _START_REASON_BROADCASTContent = default;
        private static bool _START_REASON_BROADCASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_CONTENT_PROVIDER"/>
        /// </summary>
        public static int START_REASON_CONTENT_PROVIDER { get { if (!_START_REASON_CONTENT_PROVIDERReady) { _START_REASON_CONTENT_PROVIDERContent = SGetField<int>(LocalBridgeClazz, "START_REASON_CONTENT_PROVIDER"); _START_REASON_CONTENT_PROVIDERReady = true; } return _START_REASON_CONTENT_PROVIDERContent; } }
        private static int _START_REASON_CONTENT_PROVIDERContent = default;
        private static bool _START_REASON_CONTENT_PROVIDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_JOB"/>
        /// </summary>
        public static int START_REASON_JOB { get { if (!_START_REASON_JOBReady) { _START_REASON_JOBContent = SGetField<int>(LocalBridgeClazz, "START_REASON_JOB"); _START_REASON_JOBReady = true; } return _START_REASON_JOBContent; } }
        private static int _START_REASON_JOBContent = default;
        private static bool _START_REASON_JOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_LAUNCHER"/>
        /// </summary>
        public static int START_REASON_LAUNCHER { get { if (!_START_REASON_LAUNCHERReady) { _START_REASON_LAUNCHERContent = SGetField<int>(LocalBridgeClazz, "START_REASON_LAUNCHER"); _START_REASON_LAUNCHERReady = true; } return _START_REASON_LAUNCHERContent; } }
        private static int _START_REASON_LAUNCHERContent = default;
        private static bool _START_REASON_LAUNCHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_LAUNCHER_RECENTS"/>
        /// </summary>
        public static int START_REASON_LAUNCHER_RECENTS { get { if (!_START_REASON_LAUNCHER_RECENTSReady) { _START_REASON_LAUNCHER_RECENTSContent = SGetField<int>(LocalBridgeClazz, "START_REASON_LAUNCHER_RECENTS"); _START_REASON_LAUNCHER_RECENTSReady = true; } return _START_REASON_LAUNCHER_RECENTSContent; } }
        private static int _START_REASON_LAUNCHER_RECENTSContent = default;
        private static bool _START_REASON_LAUNCHER_RECENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_OTHER"/>
        /// </summary>
        public static int START_REASON_OTHER { get { if (!_START_REASON_OTHERReady) { _START_REASON_OTHERContent = SGetField<int>(LocalBridgeClazz, "START_REASON_OTHER"); _START_REASON_OTHERReady = true; } return _START_REASON_OTHERContent; } }
        private static int _START_REASON_OTHERContent = default;
        private static bool _START_REASON_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_PUSH"/>
        /// </summary>
        public static int START_REASON_PUSH { get { if (!_START_REASON_PUSHReady) { _START_REASON_PUSHContent = SGetField<int>(LocalBridgeClazz, "START_REASON_PUSH"); _START_REASON_PUSHReady = true; } return _START_REASON_PUSHContent; } }
        private static int _START_REASON_PUSHContent = default;
        private static bool _START_REASON_PUSHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_SERVICE"/>
        /// </summary>
        public static int START_REASON_SERVICE { get { if (!_START_REASON_SERVICEReady) { _START_REASON_SERVICEContent = SGetField<int>(LocalBridgeClazz, "START_REASON_SERVICE"); _START_REASON_SERVICEReady = true; } return _START_REASON_SERVICEContent; } }
        private static int _START_REASON_SERVICEContent = default;
        private static bool _START_REASON_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_REASON_START_ACTIVITY"/>
        /// </summary>
        public static int START_REASON_START_ACTIVITY { get { if (!_START_REASON_START_ACTIVITYReady) { _START_REASON_START_ACTIVITYContent = SGetField<int>(LocalBridgeClazz, "START_REASON_START_ACTIVITY"); _START_REASON_START_ACTIVITYReady = true; } return _START_REASON_START_ACTIVITYContent; } }
        private static int _START_REASON_START_ACTIVITYContent = default;
        private static bool _START_REASON_START_ACTIVITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_APPLICATION_ONCREATE"/>
        /// </summary>
        public static int START_TIMESTAMP_APPLICATION_ONCREATE { get { if (!_START_TIMESTAMP_APPLICATION_ONCREATEReady) { _START_TIMESTAMP_APPLICATION_ONCREATEContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_APPLICATION_ONCREATE"); _START_TIMESTAMP_APPLICATION_ONCREATEReady = true; } return _START_TIMESTAMP_APPLICATION_ONCREATEContent; } }
        private static int _START_TIMESTAMP_APPLICATION_ONCREATEContent = default;
        private static bool _START_TIMESTAMP_APPLICATION_ONCREATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_BIND_APPLICATION"/>
        /// </summary>
        public static int START_TIMESTAMP_BIND_APPLICATION { get { if (!_START_TIMESTAMP_BIND_APPLICATIONReady) { _START_TIMESTAMP_BIND_APPLICATIONContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_BIND_APPLICATION"); _START_TIMESTAMP_BIND_APPLICATIONReady = true; } return _START_TIMESTAMP_BIND_APPLICATIONContent; } }
        private static int _START_TIMESTAMP_BIND_APPLICATIONContent = default;
        private static bool _START_TIMESTAMP_BIND_APPLICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_FIRST_FRAME"/>
        /// </summary>
        public static int START_TIMESTAMP_FIRST_FRAME { get { if (!_START_TIMESTAMP_FIRST_FRAMEReady) { _START_TIMESTAMP_FIRST_FRAMEContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_FIRST_FRAME"); _START_TIMESTAMP_FIRST_FRAMEReady = true; } return _START_TIMESTAMP_FIRST_FRAMEContent; } }
        private static int _START_TIMESTAMP_FIRST_FRAMEContent = default;
        private static bool _START_TIMESTAMP_FIRST_FRAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_FORK"/>
        /// </summary>
        public static int START_TIMESTAMP_FORK { get { if (!_START_TIMESTAMP_FORKReady) { _START_TIMESTAMP_FORKContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_FORK"); _START_TIMESTAMP_FORKReady = true; } return _START_TIMESTAMP_FORKContent; } }
        private static int _START_TIMESTAMP_FORKContent = default;
        private static bool _START_TIMESTAMP_FORKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_FULLY_DRAWN"/>
        /// </summary>
        public static int START_TIMESTAMP_FULLY_DRAWN { get { if (!_START_TIMESTAMP_FULLY_DRAWNReady) { _START_TIMESTAMP_FULLY_DRAWNContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_FULLY_DRAWN"); _START_TIMESTAMP_FULLY_DRAWNReady = true; } return _START_TIMESTAMP_FULLY_DRAWNContent; } }
        private static int _START_TIMESTAMP_FULLY_DRAWNContent = default;
        private static bool _START_TIMESTAMP_FULLY_DRAWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAME"/>
        /// </summary>
        public static int START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAME { get { if (!_START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAMEReady) { _START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAMEContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAME"); _START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAMEReady = true; } return _START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAMEContent; } }
        private static int _START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAMEContent = default;
        private static bool _START_TIMESTAMP_INITIAL_RENDERTHREAD_FRAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_LAUNCH"/>
        /// </summary>
        public static int START_TIMESTAMP_LAUNCH { get { if (!_START_TIMESTAMP_LAUNCHReady) { _START_TIMESTAMP_LAUNCHContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_LAUNCH"); _START_TIMESTAMP_LAUNCHReady = true; } return _START_TIMESTAMP_LAUNCHContent; } }
        private static int _START_TIMESTAMP_LAUNCHContent = default;
        private static bool _START_TIMESTAMP_LAUNCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_RESERVED_RANGE_DEVELOPER"/>
        /// </summary>
        public static int START_TIMESTAMP_RESERVED_RANGE_DEVELOPER { get { if (!_START_TIMESTAMP_RESERVED_RANGE_DEVELOPERReady) { _START_TIMESTAMP_RESERVED_RANGE_DEVELOPERContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_RESERVED_RANGE_DEVELOPER"); _START_TIMESTAMP_RESERVED_RANGE_DEVELOPERReady = true; } return _START_TIMESTAMP_RESERVED_RANGE_DEVELOPERContent; } }
        private static int _START_TIMESTAMP_RESERVED_RANGE_DEVELOPERContent = default;
        private static bool _START_TIMESTAMP_RESERVED_RANGE_DEVELOPERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_START"/>
        /// </summary>
        public static int START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_START { get { if (!_START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_STARTReady) { _START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_STARTContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_START"); _START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_STARTReady = true; } return _START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_STARTContent; } }
        private static int _START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_STARTContent = default;
        private static bool _START_TIMESTAMP_RESERVED_RANGE_DEVELOPER_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_RESERVED_RANGE_SYSTEM"/>
        /// </summary>
        public static int START_TIMESTAMP_RESERVED_RANGE_SYSTEM { get { if (!_START_TIMESTAMP_RESERVED_RANGE_SYSTEMReady) { _START_TIMESTAMP_RESERVED_RANGE_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_RESERVED_RANGE_SYSTEM"); _START_TIMESTAMP_RESERVED_RANGE_SYSTEMReady = true; } return _START_TIMESTAMP_RESERVED_RANGE_SYSTEMContent; } }
        private static int _START_TIMESTAMP_RESERVED_RANGE_SYSTEMContent = default;
        private static bool _START_TIMESTAMP_RESERVED_RANGE_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETE"/>
        /// </summary>
        public static int START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETE { get { if (!_START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETEReady) { _START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETE"); _START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETEReady = true; } return _START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETEContent; } }
        private static int _START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETEContent = default;
        private static bool _START_TIMESTAMP_SURFACEFLINGER_COMPOSITION_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TYPE_COLD"/>
        /// </summary>
        public static int START_TYPE_COLD { get { if (!_START_TYPE_COLDReady) { _START_TYPE_COLDContent = SGetField<int>(LocalBridgeClazz, "START_TYPE_COLD"); _START_TYPE_COLDReady = true; } return _START_TYPE_COLDContent; } }
        private static int _START_TYPE_COLDContent = default;
        private static bool _START_TYPE_COLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TYPE_HOT"/>
        /// </summary>
        public static int START_TYPE_HOT { get { if (!_START_TYPE_HOTReady) { _START_TYPE_HOTContent = SGetField<int>(LocalBridgeClazz, "START_TYPE_HOT"); _START_TYPE_HOTReady = true; } return _START_TYPE_HOTContent; } }
        private static int _START_TYPE_HOTContent = default;
        private static bool _START_TYPE_HOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TYPE_UNSET"/>
        /// </summary>
        public static int START_TYPE_UNSET { get { if (!_START_TYPE_UNSETReady) { _START_TYPE_UNSETContent = SGetField<int>(LocalBridgeClazz, "START_TYPE_UNSET"); _START_TYPE_UNSETReady = true; } return _START_TYPE_UNSETContent; } }
        private static int _START_TYPE_UNSETContent = default;
        private static bool _START_TYPE_UNSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#START_TYPE_WARM"/>
        /// </summary>
        public static int START_TYPE_WARM { get { if (!_START_TYPE_WARMReady) { _START_TYPE_WARMContent = SGetField<int>(LocalBridgeClazz, "START_TYPE_WARM"); _START_TYPE_WARMReady = true; } return _START_TYPE_WARMContent; } }
        private static int _START_TYPE_WARMContent = default;
        private static bool _START_TYPE_WARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#STARTUP_STATE_ERROR"/>
        /// </summary>
        public static int STARTUP_STATE_ERROR { get { if (!_STARTUP_STATE_ERRORReady) { _STARTUP_STATE_ERRORContent = SGetField<int>(LocalBridgeClazz, "STARTUP_STATE_ERROR"); _STARTUP_STATE_ERRORReady = true; } return _STARTUP_STATE_ERRORContent; } }
        private static int _STARTUP_STATE_ERRORContent = default;
        private static bool _STARTUP_STATE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#STARTUP_STATE_FIRST_FRAME_DRAWN"/>
        /// </summary>
        public static int STARTUP_STATE_FIRST_FRAME_DRAWN { get { if (!_STARTUP_STATE_FIRST_FRAME_DRAWNReady) { _STARTUP_STATE_FIRST_FRAME_DRAWNContent = SGetField<int>(LocalBridgeClazz, "STARTUP_STATE_FIRST_FRAME_DRAWN"); _STARTUP_STATE_FIRST_FRAME_DRAWNReady = true; } return _STARTUP_STATE_FIRST_FRAME_DRAWNContent; } }
        private static int _STARTUP_STATE_FIRST_FRAME_DRAWNContent = default;
        private static bool _STARTUP_STATE_FIRST_FRAME_DRAWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#STARTUP_STATE_STARTED"/>
        /// </summary>
        public static int STARTUP_STATE_STARTED { get { if (!_STARTUP_STATE_STARTEDReady) { _STARTUP_STATE_STARTEDContent = SGetField<int>(LocalBridgeClazz, "STARTUP_STATE_STARTED"); _STARTUP_STATE_STARTEDReady = true; } return _STARTUP_STATE_STARTEDContent; } }
        private static int _STARTUP_STATE_STARTEDContent = default;
        private static bool _STARTUP_STATE_STARTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent GetIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("getIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#wasForceStopped()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WasForceStopped()
        {
            return IExecuteWithSignature<bool>("wasForceStopped", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getDefiningUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefiningUid()
        {
            return IExecuteWithSignature<int>("getDefiningUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getLaunchMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLaunchMode()
        {
            return IExecuteWithSignature<int>("getLaunchMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getPackageUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPackageUid()
        {
            return IExecuteWithSignature<int>("getPackageUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getPid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPid()
        {
            return IExecuteWithSignature<int>("getPid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getRealUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRealUid()
        {
            return IExecuteWithSignature<int>("getRealUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getReason()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReason()
        {
            return IExecuteWithSignature<int>("getReason", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getStartType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStartType()
        {
            return IExecuteWithSignature<int>("getStartType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getStartupState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStartupState()
        {
            return IExecuteWithSignature<int>("getStartupState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getProcessName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProcessName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProcessName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#getStartupTimestamps()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, Java.Lang.Long> GetStartupTimestamps()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Java.Lang.Long>>("getStartupTimestamps", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationStartInfo.html#writeToParcel(android.os.Parcel,int)"/>
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