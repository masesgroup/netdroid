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

namespace Android.Provider
{
    #region SettingsSlicesContract declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html"/>
    /// </summary>
    public partial class SettingsSlicesContract : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SettingsSlicesContract>
    {
        const string _bridgeClassName = "android.provider.SettingsSlicesContract";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SettingsSlicesContract() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SettingsSlicesContract(params object[] args) : base(args) { }
    
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

    #region SettingsSlicesContract implementation
    public partial class SettingsSlicesContract
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#BASE_URI"/>
        /// </summary>
        public static Android.Net.Uri BASE_URI { get { if (!_BASE_URIReady) { _BASE_URIContent = SGetField<Android.Net.Uri>(LocalBridgeClazz, "BASE_URI"); _BASE_URIReady = true; } return _BASE_URIContent; } }
        private static Android.Net.Uri _BASE_URIContent = default;
        private static bool _BASE_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#AUTHORITY"/>
        /// </summary>
        public static Java.Lang.String AUTHORITY { get { if (!_AUTHORITYReady) { _AUTHORITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTHORITY"); _AUTHORITYReady = true; } return _AUTHORITYContent; } }
        private static Java.Lang.String _AUTHORITYContent = default;
        private static bool _AUTHORITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#KEY_AIRPLANE_MODE"/>
        /// </summary>
        public static Java.Lang.String KEY_AIRPLANE_MODE { get { if (!_KEY_AIRPLANE_MODEReady) { _KEY_AIRPLANE_MODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_AIRPLANE_MODE"); _KEY_AIRPLANE_MODEReady = true; } return _KEY_AIRPLANE_MODEContent; } }
        private static Java.Lang.String _KEY_AIRPLANE_MODEContent = default;
        private static bool _KEY_AIRPLANE_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#KEY_BATTERY_SAVER"/>
        /// </summary>
        public static Java.Lang.String KEY_BATTERY_SAVER { get { if (!_KEY_BATTERY_SAVERReady) { _KEY_BATTERY_SAVERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_BATTERY_SAVER"); _KEY_BATTERY_SAVERReady = true; } return _KEY_BATTERY_SAVERContent; } }
        private static Java.Lang.String _KEY_BATTERY_SAVERContent = default;
        private static bool _KEY_BATTERY_SAVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#KEY_BLUETOOTH"/>
        /// </summary>
        public static Java.Lang.String KEY_BLUETOOTH { get { if (!_KEY_BLUETOOTHReady) { _KEY_BLUETOOTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_BLUETOOTH"); _KEY_BLUETOOTHReady = true; } return _KEY_BLUETOOTHContent; } }
        private static Java.Lang.String _KEY_BLUETOOTHContent = default;
        private static bool _KEY_BLUETOOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#KEY_LOCATION"/>
        /// </summary>
        public static Java.Lang.String KEY_LOCATION { get { if (!_KEY_LOCATIONReady) { _KEY_LOCATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_LOCATION"); _KEY_LOCATIONReady = true; } return _KEY_LOCATIONContent; } }
        private static Java.Lang.String _KEY_LOCATIONContent = default;
        private static bool _KEY_LOCATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#KEY_WIFI"/>
        /// </summary>
        public static Java.Lang.String KEY_WIFI { get { if (!_KEY_WIFIReady) { _KEY_WIFIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_WIFI"); _KEY_WIFIReady = true; } return _KEY_WIFIContent; } }
        private static Java.Lang.String _KEY_WIFIContent = default;
        private static bool _KEY_WIFIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#PATH_SETTING_ACTION"/>
        /// </summary>
        public static Java.Lang.String PATH_SETTING_ACTION { get { if (!_PATH_SETTING_ACTIONReady) { _PATH_SETTING_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PATH_SETTING_ACTION"); _PATH_SETTING_ACTIONReady = true; } return _PATH_SETTING_ACTIONContent; } }
        private static Java.Lang.String _PATH_SETTING_ACTIONContent = default;
        private static bool _PATH_SETTING_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SettingsSlicesContract.html#PATH_SETTING_INTENT"/>
        /// </summary>
        public static Java.Lang.String PATH_SETTING_INTENT { get { if (!_PATH_SETTING_INTENTReady) { _PATH_SETTING_INTENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PATH_SETTING_INTENT"); _PATH_SETTING_INTENTReady = true; } return _PATH_SETTING_INTENTContent; } }
        private static Java.Lang.String _PATH_SETTING_INTENTContent = default;
        private static bool _PATH_SETTING_INTENTReady = false; // this is used because in case of generics 
    
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