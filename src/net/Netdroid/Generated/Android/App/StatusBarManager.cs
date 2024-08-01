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

namespace Android.App
{
    #region StatusBarManager
    public partial class StatusBarManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUND"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUND { get { if (!_TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUNDReady) { _TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUNDContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUND"); _TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUNDReady = true; } return _TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUNDContent; } }
        private static int _TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUNDContent = default;
        private static bool _TILE_ADD_REQUEST_ERROR_APP_NOT_IN_FOREGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_ERROR_BAD_COMPONENT"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_ERROR_BAD_COMPONENT { get { if (!_TILE_ADD_REQUEST_ERROR_BAD_COMPONENTReady) { _TILE_ADD_REQUEST_ERROR_BAD_COMPONENTContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_ERROR_BAD_COMPONENT"); _TILE_ADD_REQUEST_ERROR_BAD_COMPONENTReady = true; } return _TILE_ADD_REQUEST_ERROR_BAD_COMPONENTContent; } }
        private static int _TILE_ADD_REQUEST_ERROR_BAD_COMPONENTContent = default;
        private static bool _TILE_ADD_REQUEST_ERROR_BAD_COMPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGE"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGE { get { if (!_TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGEReady) { _TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGEContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGE"); _TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGEReady = true; } return _TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGEContent; } }
        private static int _TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGEContent = default;
        private static bool _TILE_ADD_REQUEST_ERROR_MISMATCHED_PACKAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICE"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICE { get { if (!_TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICEReady) { _TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICEContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICE"); _TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICEReady = true; } return _TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICEContent; } }
        private static int _TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICEContent = default;
        private static bool _TILE_ADD_REQUEST_ERROR_NO_STATUS_BAR_SERVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USER"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USER { get { if (!_TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USERReady) { _TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USERContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USER"); _TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USERReady = true; } return _TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USERContent; } }
        private static int _TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USERContent = default;
        private static bool _TILE_ADD_REQUEST_ERROR_NOT_CURRENT_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESS"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESS { get { if (!_TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESSReady) { _TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESSContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESS"); _TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESSReady = true; } return _TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESSContent; } }
        private static int _TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESSContent = default;
        private static bool _TILE_ADD_REQUEST_ERROR_REQUEST_IN_PROGRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_RESULT_TILE_ADDED"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_RESULT_TILE_ADDED { get { if (!_TILE_ADD_REQUEST_RESULT_TILE_ADDEDReady) { _TILE_ADD_REQUEST_RESULT_TILE_ADDEDContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_RESULT_TILE_ADDED"); _TILE_ADD_REQUEST_RESULT_TILE_ADDEDReady = true; } return _TILE_ADD_REQUEST_RESULT_TILE_ADDEDContent; } }
        private static int _TILE_ADD_REQUEST_RESULT_TILE_ADDEDContent = default;
        private static bool _TILE_ADD_REQUEST_RESULT_TILE_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDED"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDED { get { if (!_TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDEDReady) { _TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDEDContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDED"); _TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDEDReady = true; } return _TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDEDContent; } }
        private static int _TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDEDContent = default;
        private static bool _TILE_ADD_REQUEST_RESULT_TILE_ALREADY_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDED"/>
        /// </summary>
        public static int TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDED { get { if (!_TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDEDReady) { _TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDEDContent = SGetField<int>(LocalBridgeClazz, "TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDED"); _TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDEDReady = true; } return _TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDEDContent; } }
        private static int _TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDEDContent = default;
        private static bool _TILE_ADD_REQUEST_RESULT_TILE_NOT_ADDEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#canLaunchCaptureContentActivityForNote(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanLaunchCaptureContentActivityForNote(Android.App.Activity arg0)
        {
            return IExecuteWithSignature<bool>("canLaunchCaptureContentActivityForNote", "(Landroid/app/Activity;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/StatusBarManager.html#requestAddTileService(android.content.ComponentName,java.lang.CharSequence,android.graphics.drawable.Icon,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Drawable.Icon"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Java.Util.Function.Consumer"/></param>
        public void RequestAddTileService(Android.Content.ComponentName arg0, Java.Lang.CharSequence arg1, Android.Graphics.Drawable.Icon arg2, Java.Util.Concurrent.Executor arg3, Java.Util.Function.Consumer<Java.Lang.Integer> arg4)
        {
            IExecute("requestAddTileService", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}