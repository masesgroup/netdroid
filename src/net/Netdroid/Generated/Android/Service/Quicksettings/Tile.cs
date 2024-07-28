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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Quicksettings
{
    #region Tile
    public partial class Tile
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#STATE_ACTIVE"/>
        /// </summary>
        public static int STATE_ACTIVE { get { if (!_STATE_ACTIVEReady) { _STATE_ACTIVEContent = SGetField<int>(LocalBridgeClazz, "STATE_ACTIVE"); _STATE_ACTIVEReady = true; } return _STATE_ACTIVEContent; } }
        private static int _STATE_ACTIVEContent = default;
        private static bool _STATE_ACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#STATE_INACTIVE"/>
        /// </summary>
        public static int STATE_INACTIVE { get { if (!_STATE_INACTIVEReady) { _STATE_INACTIVEContent = SGetField<int>(LocalBridgeClazz, "STATE_INACTIVE"); _STATE_INACTIVEReady = true; } return _STATE_INACTIVEContent; } }
        private static int _STATE_INACTIVEContent = default;
        private static bool _STATE_INACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#STATE_UNAVAILABLE"/>
        /// </summary>
        public static int STATE_UNAVAILABLE { get { if (!_STATE_UNAVAILABLEReady) { _STATE_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "STATE_UNAVAILABLE"); _STATE_UNAVAILABLEReady = true; } return _STATE_UNAVAILABLEContent; } }
        private static int _STATE_UNAVAILABLEContent = default;
        private static bool _STATE_UNAVAILABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getActivityLaunchForClick()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        public Android.App.PendingIntent GetActivityLaunchForClick()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getActivityLaunchForClick", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getContentDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetContentDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getStateDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetStateDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getStateDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#getSubtitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSubtitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSubtitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setActivityLaunchForClick(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        public void SetActivityLaunchForClick(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("setActivityLaunchForClick", "(Landroid/app/PendingIntent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setContentDescription(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetContentDescription(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setContentDescription", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setIcon(android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
        public void SetIcon(Android.Graphics.Drawable.Icon arg0)
        {
            IExecuteWithSignature("setIcon", "(Landroid/graphics/drawable/Icon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setLabel(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetLabel(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setLabel", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setState(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetState(int arg0)
        {
            IExecuteWithSignature("setState", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setStateDescription(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetStateDescription(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setStateDescription", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#setSubtitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetSubtitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setSubtitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#updateTile()"/>
        /// </summary>
        public void UpdateTile()
        {
            IExecuteWithSignature("updateTile", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quicksettings/Tile.html#writeToParcel(android.os.Parcel,int)"/>
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