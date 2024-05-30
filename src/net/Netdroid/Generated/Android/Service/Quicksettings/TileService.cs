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

namespace Android.Service.Quicksettings
{
    #region TileService
    public partial class TileService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#ACTION_QS_TILE"/>
        /// </summary>
        public static Java.Lang.String ACTION_QS_TILE { get { if (!_ACTION_QS_TILEReady) { _ACTION_QS_TILEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_QS_TILE"); _ACTION_QS_TILEReady = true; } return _ACTION_QS_TILEContent; } }
        private static Java.Lang.String _ACTION_QS_TILEContent = default;
        private static bool _ACTION_QS_TILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#ACTION_QS_TILE_PREFERENCES"/>
        /// </summary>
        public static Java.Lang.String ACTION_QS_TILE_PREFERENCES { get { if (!_ACTION_QS_TILE_PREFERENCESReady) { _ACTION_QS_TILE_PREFERENCESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_QS_TILE_PREFERENCES"); _ACTION_QS_TILE_PREFERENCESReady = true; } return _ACTION_QS_TILE_PREFERENCESContent; } }
        private static Java.Lang.String _ACTION_QS_TILE_PREFERENCESContent = default;
        private static bool _ACTION_QS_TILE_PREFERENCESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#META_DATA_ACTIVE_TILE"/>
        /// </summary>
        public static Java.Lang.String META_DATA_ACTIVE_TILE { get { if (!_META_DATA_ACTIVE_TILEReady) { _META_DATA_ACTIVE_TILEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_ACTIVE_TILE"); _META_DATA_ACTIVE_TILEReady = true; } return _META_DATA_ACTIVE_TILEContent; } }
        private static Java.Lang.String _META_DATA_ACTIVE_TILEContent = default;
        private static bool _META_DATA_ACTIVE_TILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#META_DATA_TOGGLEABLE_TILE"/>
        /// </summary>
        public static Java.Lang.String META_DATA_TOGGLEABLE_TILE { get { if (!_META_DATA_TOGGLEABLE_TILEReady) { _META_DATA_TOGGLEABLE_TILEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_TOGGLEABLE_TILE"); _META_DATA_TOGGLEABLE_TILEReady = true; } return _META_DATA_TOGGLEABLE_TILEContent; } }
        private static Java.Lang.String _META_DATA_TOGGLEABLE_TILEContent = default;
        private static bool _META_DATA_TOGGLEABLE_TILEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#requestListeningState(android.content.Context,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        public static void RequestListeningState(Android.Content.Context arg0, Android.Content.ComponentName arg1)
        {
            SExecute(LocalBridgeClazz, "requestListeningState", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#getQsTile()"/> 
        /// </summary>
        public Android.Service.Quicksettings.Tile QsTile
        {
            get { return IExecuteWithSignature<Android.Service.Quicksettings.Tile>("getQsTile", "()Landroid/service/quicksettings/Tile;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#isLocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLocked()
        {
            return IExecuteWithSignature<bool>("isLocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#isSecure()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSecure()
        {
            return IExecuteWithSignature<bool>("isSecure", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#showDialog(android.app.Dialog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Dialog"/></param>
        public void ShowDialog(Android.App.Dialog arg0)
        {
            IExecuteWithSignature("showDialog", "(Landroid/app/Dialog;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#startActivityAndCollapse(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        public void StartActivityAndCollapse(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("startActivityAndCollapse", "(Landroid/app/PendingIntent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#unlockAndRun(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void UnlockAndRun(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("unlockAndRun", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#onClick()"/>
        /// </summary>
        public void OnClick()
        {
            IExecuteWithSignature("onClick", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#onStartListening()"/>
        /// </summary>
        public void OnStartListening()
        {
            IExecuteWithSignature("onStartListening", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#onStopListening()"/>
        /// </summary>
        public void OnStopListening()
        {
            IExecuteWithSignature("onStopListening", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#onTileAdded()"/>
        /// </summary>
        public void OnTileAdded()
        {
            IExecuteWithSignature("onTileAdded", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/TileService.html#onTileRemoved()"/>
        /// </summary>
        public void OnTileRemoved()
        {
            IExecuteWithSignature("onTileRemoved", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}