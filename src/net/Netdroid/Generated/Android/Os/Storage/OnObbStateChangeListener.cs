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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os.Storage
{
    #region OnObbStateChangeListener
    public partial class OnObbStateChangeListener
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#ERROR_ALREADY_MOUNTED"/>
        /// </summary>
        public static int ERROR_ALREADY_MOUNTED { get { if (!_ERROR_ALREADY_MOUNTEDReady) { _ERROR_ALREADY_MOUNTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_ALREADY_MOUNTED"); _ERROR_ALREADY_MOUNTEDReady = true; } return _ERROR_ALREADY_MOUNTEDContent; } }
        private static int _ERROR_ALREADY_MOUNTEDContent = default;
        private static bool _ERROR_ALREADY_MOUNTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#ERROR_COULD_NOT_MOUNT"/>
        /// </summary>
        public static int ERROR_COULD_NOT_MOUNT { get { if (!_ERROR_COULD_NOT_MOUNTReady) { _ERROR_COULD_NOT_MOUNTContent = SGetField<int>(LocalBridgeClazz, "ERROR_COULD_NOT_MOUNT"); _ERROR_COULD_NOT_MOUNTReady = true; } return _ERROR_COULD_NOT_MOUNTContent; } }
        private static int _ERROR_COULD_NOT_MOUNTContent = default;
        private static bool _ERROR_COULD_NOT_MOUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#ERROR_COULD_NOT_UNMOUNT"/>
        /// </summary>
        public static int ERROR_COULD_NOT_UNMOUNT { get { if (!_ERROR_COULD_NOT_UNMOUNTReady) { _ERROR_COULD_NOT_UNMOUNTContent = SGetField<int>(LocalBridgeClazz, "ERROR_COULD_NOT_UNMOUNT"); _ERROR_COULD_NOT_UNMOUNTReady = true; } return _ERROR_COULD_NOT_UNMOUNTContent; } }
        private static int _ERROR_COULD_NOT_UNMOUNTContent = default;
        private static bool _ERROR_COULD_NOT_UNMOUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#ERROR_INTERNAL"/>
        /// </summary>
        public static int ERROR_INTERNAL { get { if (!_ERROR_INTERNALReady) { _ERROR_INTERNALContent = SGetField<int>(LocalBridgeClazz, "ERROR_INTERNAL"); _ERROR_INTERNALReady = true; } return _ERROR_INTERNALContent; } }
        private static int _ERROR_INTERNALContent = default;
        private static bool _ERROR_INTERNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#ERROR_NOT_MOUNTED"/>
        /// </summary>
        public static int ERROR_NOT_MOUNTED { get { if (!_ERROR_NOT_MOUNTEDReady) { _ERROR_NOT_MOUNTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_NOT_MOUNTED"); _ERROR_NOT_MOUNTEDReady = true; } return _ERROR_NOT_MOUNTEDContent; } }
        private static int _ERROR_NOT_MOUNTEDContent = default;
        private static bool _ERROR_NOT_MOUNTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#ERROR_PERMISSION_DENIED"/>
        /// </summary>
        public static int ERROR_PERMISSION_DENIED { get { if (!_ERROR_PERMISSION_DENIEDReady) { _ERROR_PERMISSION_DENIEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_PERMISSION_DENIED"); _ERROR_PERMISSION_DENIEDReady = true; } return _ERROR_PERMISSION_DENIEDContent; } }
        private static int _ERROR_PERMISSION_DENIEDContent = default;
        private static bool _ERROR_PERMISSION_DENIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#MOUNTED"/>
        /// </summary>
        public static int MOUNTED { get { if (!_MOUNTEDReady) { _MOUNTEDContent = SGetField<int>(LocalBridgeClazz, "MOUNTED"); _MOUNTEDReady = true; } return _MOUNTEDContent; } }
        private static int _MOUNTEDContent = default;
        private static bool _MOUNTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#UNMOUNTED"/>
        /// </summary>
        public static int UNMOUNTED { get { if (!_UNMOUNTEDReady) { _UNMOUNTEDContent = SGetField<int>(LocalBridgeClazz, "UNMOUNTED"); _UNMOUNTEDReady = true; } return _UNMOUNTEDContent; } }
        private static int _UNMOUNTEDContent = default;
        private static bool _UNMOUNTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/storage/OnObbStateChangeListener.html#onObbStateChange(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnObbStateChange(Java.Lang.String arg0, int arg1)
        {
            IExecute("onObbStateChange", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}