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

namespace Android.Content.Pm
{
    #region ServiceInfo
    public partial class ServiceInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#%3Cinit%3E(android.content.pm.ServiceInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ServiceInfo"/></param>
        public ServiceInfo(Android.Content.Pm.ServiceInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Pm.ServiceInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.Pm.ServiceInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#permission"/>
        /// </summary>
        public Java.Lang.String permission { get { return IGetField<Java.Lang.String>("permission"); } set { ISetField("permission", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FLAG_ALLOW_SHARED_ISOLATED_PROCESS"/>
        /// </summary>
        public static int FLAG_ALLOW_SHARED_ISOLATED_PROCESS { get { if (!_FLAG_ALLOW_SHARED_ISOLATED_PROCESSReady) { _FLAG_ALLOW_SHARED_ISOLATED_PROCESSContent = SGetField<int>(LocalBridgeClazz, "FLAG_ALLOW_SHARED_ISOLATED_PROCESS"); _FLAG_ALLOW_SHARED_ISOLATED_PROCESSReady = true; } return _FLAG_ALLOW_SHARED_ISOLATED_PROCESSContent; } }
        private static int _FLAG_ALLOW_SHARED_ISOLATED_PROCESSContent = default;
        private static bool _FLAG_ALLOW_SHARED_ISOLATED_PROCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FLAG_EXTERNAL_SERVICE"/>
        /// </summary>
        public static int FLAG_EXTERNAL_SERVICE { get { if (!_FLAG_EXTERNAL_SERVICEReady) { _FLAG_EXTERNAL_SERVICEContent = SGetField<int>(LocalBridgeClazz, "FLAG_EXTERNAL_SERVICE"); _FLAG_EXTERNAL_SERVICEReady = true; } return _FLAG_EXTERNAL_SERVICEContent; } }
        private static int _FLAG_EXTERNAL_SERVICEContent = default;
        private static bool _FLAG_EXTERNAL_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FLAG_ISOLATED_PROCESS"/>
        /// </summary>
        public static int FLAG_ISOLATED_PROCESS { get { if (!_FLAG_ISOLATED_PROCESSReady) { _FLAG_ISOLATED_PROCESSContent = SGetField<int>(LocalBridgeClazz, "FLAG_ISOLATED_PROCESS"); _FLAG_ISOLATED_PROCESSReady = true; } return _FLAG_ISOLATED_PROCESSContent; } }
        private static int _FLAG_ISOLATED_PROCESSContent = default;
        private static bool _FLAG_ISOLATED_PROCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FLAG_SINGLE_USER"/>
        /// </summary>
        public static int FLAG_SINGLE_USER { get { if (!_FLAG_SINGLE_USERReady) { _FLAG_SINGLE_USERContent = SGetField<int>(LocalBridgeClazz, "FLAG_SINGLE_USER"); _FLAG_SINGLE_USERReady = true; } return _FLAG_SINGLE_USERContent; } }
        private static int _FLAG_SINGLE_USERContent = default;
        private static bool _FLAG_SINGLE_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FLAG_STOP_WITH_TASK"/>
        /// </summary>
        public static int FLAG_STOP_WITH_TASK { get { if (!_FLAG_STOP_WITH_TASKReady) { _FLAG_STOP_WITH_TASKContent = SGetField<int>(LocalBridgeClazz, "FLAG_STOP_WITH_TASK"); _FLAG_STOP_WITH_TASKReady = true; } return _FLAG_STOP_WITH_TASKContent; } }
        private static int _FLAG_STOP_WITH_TASKContent = default;
        private static bool _FLAG_STOP_WITH_TASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FLAG_USE_APP_ZYGOTE"/>
        /// </summary>
        public static int FLAG_USE_APP_ZYGOTE { get { if (!_FLAG_USE_APP_ZYGOTEReady) { _FLAG_USE_APP_ZYGOTEContent = SGetField<int>(LocalBridgeClazz, "FLAG_USE_APP_ZYGOTE"); _FLAG_USE_APP_ZYGOTEReady = true; } return _FLAG_USE_APP_ZYGOTEContent; } }
        private static int _FLAG_USE_APP_ZYGOTEContent = default;
        private static bool _FLAG_USE_APP_ZYGOTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_CAMERA"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_CAMERA { get { if (!_FOREGROUND_SERVICE_TYPE_CAMERAReady) { _FOREGROUND_SERVICE_TYPE_CAMERAContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_CAMERA"); _FOREGROUND_SERVICE_TYPE_CAMERAReady = true; } return _FOREGROUND_SERVICE_TYPE_CAMERAContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_CAMERAContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_CAMERAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICE"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICE { get { if (!_FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICEReady) { _FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICEContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICE"); _FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICEReady = true; } return _FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICEContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICEContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_CONNECTED_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_DATA_SYNC"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_DATA_SYNC { get { if (!_FOREGROUND_SERVICE_TYPE_DATA_SYNCReady) { _FOREGROUND_SERVICE_TYPE_DATA_SYNCContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_DATA_SYNC"); _FOREGROUND_SERVICE_TYPE_DATA_SYNCReady = true; } return _FOREGROUND_SERVICE_TYPE_DATA_SYNCContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_DATA_SYNCContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_DATA_SYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_HEALTH"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_HEALTH { get { if (!_FOREGROUND_SERVICE_TYPE_HEALTHReady) { _FOREGROUND_SERVICE_TYPE_HEALTHContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_HEALTH"); _FOREGROUND_SERVICE_TYPE_HEALTHReady = true; } return _FOREGROUND_SERVICE_TYPE_HEALTHContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_HEALTHContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_HEALTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_LOCATION"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_LOCATION { get { if (!_FOREGROUND_SERVICE_TYPE_LOCATIONReady) { _FOREGROUND_SERVICE_TYPE_LOCATIONContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_LOCATION"); _FOREGROUND_SERVICE_TYPE_LOCATIONReady = true; } return _FOREGROUND_SERVICE_TYPE_LOCATIONContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_LOCATIONContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_LOCATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_MANIFEST"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_MANIFEST { get { if (!_FOREGROUND_SERVICE_TYPE_MANIFESTReady) { _FOREGROUND_SERVICE_TYPE_MANIFESTContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_MANIFEST"); _FOREGROUND_SERVICE_TYPE_MANIFESTReady = true; } return _FOREGROUND_SERVICE_TYPE_MANIFESTContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_MANIFESTContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_MANIFESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACK"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACK { get { if (!_FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACKReady) { _FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACKContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACK"); _FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACKReady = true; } return _FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACKContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACKContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_MEDIA_PLAYBACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSING"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSING { get { if (!_FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSINGReady) { _FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSINGContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSING"); _FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSINGReady = true; } return _FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSINGContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSINGContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_MEDIA_PROCESSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTION"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTION { get { if (!_FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTIONReady) { _FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTIONContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTION"); _FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTIONReady = true; } return _FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTIONContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTIONContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_MEDIA_PROJECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_MICROPHONE"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_MICROPHONE { get { if (!_FOREGROUND_SERVICE_TYPE_MICROPHONEReady) { _FOREGROUND_SERVICE_TYPE_MICROPHONEContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_MICROPHONE"); _FOREGROUND_SERVICE_TYPE_MICROPHONEReady = true; } return _FOREGROUND_SERVICE_TYPE_MICROPHONEContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_MICROPHONEContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_MICROPHONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_NONE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int FOREGROUND_SERVICE_TYPE_NONE { get { if (!_FOREGROUND_SERVICE_TYPE_NONEReady) { _FOREGROUND_SERVICE_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_NONE"); _FOREGROUND_SERVICE_TYPE_NONEReady = true; } return _FOREGROUND_SERVICE_TYPE_NONEContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_NONEContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_PHONE_CALL"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_PHONE_CALL { get { if (!_FOREGROUND_SERVICE_TYPE_PHONE_CALLReady) { _FOREGROUND_SERVICE_TYPE_PHONE_CALLContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_PHONE_CALL"); _FOREGROUND_SERVICE_TYPE_PHONE_CALLReady = true; } return _FOREGROUND_SERVICE_TYPE_PHONE_CALLContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_PHONE_CALLContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_PHONE_CALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGING"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGING { get { if (!_FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGINGReady) { _FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGINGContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGING"); _FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGINGReady = true; } return _FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGINGContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGINGContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_REMOTE_MESSAGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_SHORT_SERVICE"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_SHORT_SERVICE { get { if (!_FOREGROUND_SERVICE_TYPE_SHORT_SERVICEReady) { _FOREGROUND_SERVICE_TYPE_SHORT_SERVICEContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_SHORT_SERVICE"); _FOREGROUND_SERVICE_TYPE_SHORT_SERVICEReady = true; } return _FOREGROUND_SERVICE_TYPE_SHORT_SERVICEContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_SHORT_SERVICEContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_SHORT_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_SPECIAL_USE"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_SPECIAL_USE { get { if (!_FOREGROUND_SERVICE_TYPE_SPECIAL_USEReady) { _FOREGROUND_SERVICE_TYPE_SPECIAL_USEContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_SPECIAL_USE"); _FOREGROUND_SERVICE_TYPE_SPECIAL_USEReady = true; } return _FOREGROUND_SERVICE_TYPE_SPECIAL_USEContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_SPECIAL_USEContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_SPECIAL_USEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTED"/>
        /// </summary>
        public static int FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTED { get { if (!_FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTEDReady) { _FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTEDContent = SGetField<int>(LocalBridgeClazz, "FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTED"); _FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTEDReady = true; } return _FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTEDContent; } }
        private static int _FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTEDContent = default;
        private static bool _FOREGROUND_SERVICE_TYPE_SYSTEM_EXEMPTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#getForegroundServiceType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetForegroundServiceType()
        {
            return IExecuteWithSignature<int>("getForegroundServiceType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ServiceInfo.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecute("dump", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}