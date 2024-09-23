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

namespace Android.Os
{
    #region Environment declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/Environment.html"/>
    /// </summary>
    public partial class Environment : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Environment>
    {
        const string _bridgeClassName = "android.os.Environment";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Environment() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Environment(params object[] args) : base(args) { }
    
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

    #region Environment implementation
    public partial class Environment
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_BAD_REMOVAL"/>
        /// </summary>
        public static Java.Lang.String MEDIA_BAD_REMOVAL { get { if (!_MEDIA_BAD_REMOVALReady) { _MEDIA_BAD_REMOVALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_BAD_REMOVAL"); _MEDIA_BAD_REMOVALReady = true; } return _MEDIA_BAD_REMOVALContent; } }
        private static Java.Lang.String _MEDIA_BAD_REMOVALContent = default;
        private static bool _MEDIA_BAD_REMOVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_CHECKING"/>
        /// </summary>
        public static Java.Lang.String MEDIA_CHECKING { get { if (!_MEDIA_CHECKINGReady) { _MEDIA_CHECKINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_CHECKING"); _MEDIA_CHECKINGReady = true; } return _MEDIA_CHECKINGContent; } }
        private static Java.Lang.String _MEDIA_CHECKINGContent = default;
        private static bool _MEDIA_CHECKINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_EJECTING"/>
        /// </summary>
        public static Java.Lang.String MEDIA_EJECTING { get { if (!_MEDIA_EJECTINGReady) { _MEDIA_EJECTINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_EJECTING"); _MEDIA_EJECTINGReady = true; } return _MEDIA_EJECTINGContent; } }
        private static Java.Lang.String _MEDIA_EJECTINGContent = default;
        private static bool _MEDIA_EJECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_MOUNTED"/>
        /// </summary>
        public static Java.Lang.String MEDIA_MOUNTED { get { if (!_MEDIA_MOUNTEDReady) { _MEDIA_MOUNTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_MOUNTED"); _MEDIA_MOUNTEDReady = true; } return _MEDIA_MOUNTEDContent; } }
        private static Java.Lang.String _MEDIA_MOUNTEDContent = default;
        private static bool _MEDIA_MOUNTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_MOUNTED_READ_ONLY"/>
        /// </summary>
        public static Java.Lang.String MEDIA_MOUNTED_READ_ONLY { get { if (!_MEDIA_MOUNTED_READ_ONLYReady) { _MEDIA_MOUNTED_READ_ONLYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_MOUNTED_READ_ONLY"); _MEDIA_MOUNTED_READ_ONLYReady = true; } return _MEDIA_MOUNTED_READ_ONLYContent; } }
        private static Java.Lang.String _MEDIA_MOUNTED_READ_ONLYContent = default;
        private static bool _MEDIA_MOUNTED_READ_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_NOFS"/>
        /// </summary>
        public static Java.Lang.String MEDIA_NOFS { get { if (!_MEDIA_NOFSReady) { _MEDIA_NOFSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_NOFS"); _MEDIA_NOFSReady = true; } return _MEDIA_NOFSContent; } }
        private static Java.Lang.String _MEDIA_NOFSContent = default;
        private static bool _MEDIA_NOFSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_REMOVED"/>
        /// </summary>
        public static Java.Lang.String MEDIA_REMOVED { get { if (!_MEDIA_REMOVEDReady) { _MEDIA_REMOVEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_REMOVED"); _MEDIA_REMOVEDReady = true; } return _MEDIA_REMOVEDContent; } }
        private static Java.Lang.String _MEDIA_REMOVEDContent = default;
        private static bool _MEDIA_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_SHARED"/>
        /// </summary>
        public static Java.Lang.String MEDIA_SHARED { get { if (!_MEDIA_SHAREDReady) { _MEDIA_SHAREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_SHARED"); _MEDIA_SHAREDReady = true; } return _MEDIA_SHAREDContent; } }
        private static Java.Lang.String _MEDIA_SHAREDContent = default;
        private static bool _MEDIA_SHAREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_UNKNOWN"/>
        /// </summary>
        public static Java.Lang.String MEDIA_UNKNOWN { get { if (!_MEDIA_UNKNOWNReady) { _MEDIA_UNKNOWNContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_UNKNOWN"); _MEDIA_UNKNOWNReady = true; } return _MEDIA_UNKNOWNContent; } }
        private static Java.Lang.String _MEDIA_UNKNOWNContent = default;
        private static bool _MEDIA_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_UNMOUNTABLE"/>
        /// </summary>
        public static Java.Lang.String MEDIA_UNMOUNTABLE { get { if (!_MEDIA_UNMOUNTABLEReady) { _MEDIA_UNMOUNTABLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_UNMOUNTABLE"); _MEDIA_UNMOUNTABLEReady = true; } return _MEDIA_UNMOUNTABLEContent; } }
        private static Java.Lang.String _MEDIA_UNMOUNTABLEContent = default;
        private static bool _MEDIA_UNMOUNTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#MEDIA_UNMOUNTED"/>
        /// </summary>
        public static Java.Lang.String MEDIA_UNMOUNTED { get { if (!_MEDIA_UNMOUNTEDReady) { _MEDIA_UNMOUNTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_UNMOUNTED"); _MEDIA_UNMOUNTEDReady = true; } return _MEDIA_UNMOUNTEDContent; } }
        private static Java.Lang.String _MEDIA_UNMOUNTEDContent = default;
        private static bool _MEDIA_UNMOUNTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_ALARMS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_ALARMS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_ALARMS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_ALARMS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_AUDIOBOOKS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_AUDIOBOOKS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_AUDIOBOOKS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_AUDIOBOOKS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_DCIM"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_DCIM { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_DCIM"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_DCIM", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_DOCUMENTS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_DOCUMENTS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_DOCUMENTS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_DOCUMENTS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_DOWNLOADS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_DOWNLOADS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_DOWNLOADS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_DOWNLOADS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_MOVIES"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_MOVIES { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_MOVIES"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_MOVIES", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_MUSIC"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_MUSIC { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_MUSIC"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_MUSIC", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_NOTIFICATIONS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_NOTIFICATIONS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_NOTIFICATIONS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_NOTIFICATIONS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_PICTURES"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_PICTURES { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_PICTURES"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_PICTURES", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_PODCASTS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_PODCASTS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_PODCASTS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_PODCASTS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_RECORDINGS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_RECORDINGS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_RECORDINGS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_RECORDINGS", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_RINGTONES"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_RINGTONES { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_RINGTONES"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_RINGTONES", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#DIRECTORY_SCREENSHOTS"/>
        /// </summary>
        public static Java.Lang.String DIRECTORY_SCREENSHOTS { get { return SGetField<Java.Lang.String>(LocalBridgeClazz, "DIRECTORY_SCREENSHOTS"); } set { SSetField(LocalBridgeClazz, "DIRECTORY_SCREENSHOTS", value); } }
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageEmulated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageEmulated()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageEmulated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageEmulated(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageEmulated(Java.Io.File arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageEmulated", "(Ljava/io/File;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageLegacy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageLegacy()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageLegacy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageLegacy(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageLegacy(Java.Io.File arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageLegacy", "(Ljava/io/File;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageManager()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageManager()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageManager", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageManager(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageManager(Java.Io.File arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageManager", "(Ljava/io/File;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageRemovable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageRemovable()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageRemovable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#isExternalStorageRemovable(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsExternalStorageRemovable(Java.Io.File arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isExternalStorageRemovable", "(Ljava/io/File;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getDataDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File GetDataDirectory()
        {
            return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getDataDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getDownloadCacheDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File GetDownloadCacheDirectory()
        {
            return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getDownloadCacheDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getExternalStorageDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File GetExternalStorageDirectory()
        {
            return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getExternalStorageDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getExternalStoragePublicDirectory(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File GetExternalStoragePublicDirectory(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getRootDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File GetRootDirectory()
        {
            return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getRootDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getStorageDirectory()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File GetStorageDirectory()
        {
            return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getStorageDirectory", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getExternalStorageState()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetExternalStorageState()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getExternalStorageState", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getExternalStorageState(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetExternalStorageState(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getExternalStorageState", "(Ljava/io/File;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Environment.html#getStorageState(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String GetStorageState(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getStorageState", "(Ljava/io/File;)Ljava/lang/String;", arg0);
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