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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region FileObserver
    public partial class FileObserver
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#%3Cinit%3E(java.io.File,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FileObserver(Java.Io.File arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public FileObserver(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public FileObserver(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public FileObserver(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#%3Cinit%3E(java.util.List,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FileObserver(Java.Util.List<Java.Io.File> arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public FileObserver(Java.Util.List<Java.Io.File> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#ACCESS"/>
        /// </summary>
        public static int ACCESS { get { if (!_ACCESSReady) { _ACCESSContent = SGetField<int>(LocalBridgeClazz, "ACCESS"); _ACCESSReady = true; } return _ACCESSContent; } }
        private static int _ACCESSContent = default;
        private static bool _ACCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#ALL_EVENTS"/>
        /// </summary>
        public static int ALL_EVENTS { get { if (!_ALL_EVENTSReady) { _ALL_EVENTSContent = SGetField<int>(LocalBridgeClazz, "ALL_EVENTS"); _ALL_EVENTSReady = true; } return _ALL_EVENTSContent; } }
        private static int _ALL_EVENTSContent = default;
        private static bool _ALL_EVENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#ATTRIB"/>
        /// </summary>
        public static int ATTRIB { get { if (!_ATTRIBReady) { _ATTRIBContent = SGetField<int>(LocalBridgeClazz, "ATTRIB"); _ATTRIBReady = true; } return _ATTRIBContent; } }
        private static int _ATTRIBContent = default;
        private static bool _ATTRIBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#CLOSE_NOWRITE"/>
        /// </summary>
        public static int CLOSE_NOWRITE { get { if (!_CLOSE_NOWRITEReady) { _CLOSE_NOWRITEContent = SGetField<int>(LocalBridgeClazz, "CLOSE_NOWRITE"); _CLOSE_NOWRITEReady = true; } return _CLOSE_NOWRITEContent; } }
        private static int _CLOSE_NOWRITEContent = default;
        private static bool _CLOSE_NOWRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#CLOSE_WRITE"/>
        /// </summary>
        public static int CLOSE_WRITE { get { if (!_CLOSE_WRITEReady) { _CLOSE_WRITEContent = SGetField<int>(LocalBridgeClazz, "CLOSE_WRITE"); _CLOSE_WRITEReady = true; } return _CLOSE_WRITEContent; } }
        private static int _CLOSE_WRITEContent = default;
        private static bool _CLOSE_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#CREATE"/>
        /// </summary>
        public static int CREATE { get { if (!_CREATEReady) { _CREATEContent = SGetField<int>(LocalBridgeClazz, "CREATE"); _CREATEReady = true; } return _CREATEContent; } }
        private static int _CREATEContent = default;
        private static bool _CREATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#DELETE"/>
        /// </summary>
        public static int DELETE { get { if (!_DELETEReady) { _DELETEContent = SGetField<int>(LocalBridgeClazz, "DELETE"); _DELETEReady = true; } return _DELETEContent; } }
        private static int _DELETEContent = default;
        private static bool _DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#DELETE_SELF"/>
        /// </summary>
        public static int DELETE_SELF { get { if (!_DELETE_SELFReady) { _DELETE_SELFContent = SGetField<int>(LocalBridgeClazz, "DELETE_SELF"); _DELETE_SELFReady = true; } return _DELETE_SELFContent; } }
        private static int _DELETE_SELFContent = default;
        private static bool _DELETE_SELFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#MODIFY"/>
        /// </summary>
        public static int MODIFY { get { if (!_MODIFYReady) { _MODIFYContent = SGetField<int>(LocalBridgeClazz, "MODIFY"); _MODIFYReady = true; } return _MODIFYContent; } }
        private static int _MODIFYContent = default;
        private static bool _MODIFYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#MOVE_SELF"/>
        /// </summary>
        public static int MOVE_SELF { get { if (!_MOVE_SELFReady) { _MOVE_SELFContent = SGetField<int>(LocalBridgeClazz, "MOVE_SELF"); _MOVE_SELFReady = true; } return _MOVE_SELFContent; } }
        private static int _MOVE_SELFContent = default;
        private static bool _MOVE_SELFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#MOVED_FROM"/>
        /// </summary>
        public static int MOVED_FROM { get { if (!_MOVED_FROMReady) { _MOVED_FROMContent = SGetField<int>(LocalBridgeClazz, "MOVED_FROM"); _MOVED_FROMReady = true; } return _MOVED_FROMContent; } }
        private static int _MOVED_FROMContent = default;
        private static bool _MOVED_FROMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#MOVED_TO"/>
        /// </summary>
        public static int MOVED_TO { get { if (!_MOVED_TOReady) { _MOVED_TOContent = SGetField<int>(LocalBridgeClazz, "MOVED_TO"); _MOVED_TOReady = true; } return _MOVED_TOContent; } }
        private static int _MOVED_TOContent = default;
        private static bool _MOVED_TOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#OPEN"/>
        /// </summary>
        public static int OPEN { get { if (!_OPENReady) { _OPENContent = SGetField<int>(LocalBridgeClazz, "OPEN"); _OPENReady = true; } return _OPENContent; } }
        private static int _OPENContent = default;
        private static bool _OPENReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#onEvent(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnEvent(int arg0, Java.Lang.String arg1)
        {
            IExecute("onEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#startWatching()"/>
        /// </summary>
        public void StartWatching()
        {
            IExecuteWithSignature("startWatching", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/FileObserver.html#stopWatching()"/>
        /// </summary>
        public void StopWatching()
        {
            IExecuteWithSignature("stopWatching", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}