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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region RingtoneManager
    public partial class RingtoneManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#%3Cinit%3E(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        public RingtoneManager(Android.App.Activity arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public RingtoneManager(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#ID_COLUMN_INDEX"/>
        /// </summary>
        public static int ID_COLUMN_INDEX { get { if (!_ID_COLUMN_INDEXReady) { _ID_COLUMN_INDEXContent = SGetField<int>(LocalBridgeClazz, "ID_COLUMN_INDEX"); _ID_COLUMN_INDEXReady = true; } return _ID_COLUMN_INDEXContent; } }
        private static int _ID_COLUMN_INDEXContent = default;
        private static bool _ID_COLUMN_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#TITLE_COLUMN_INDEX"/>
        /// </summary>
        public static int TITLE_COLUMN_INDEX { get { if (!_TITLE_COLUMN_INDEXReady) { _TITLE_COLUMN_INDEXContent = SGetField<int>(LocalBridgeClazz, "TITLE_COLUMN_INDEX"); _TITLE_COLUMN_INDEXReady = true; } return _TITLE_COLUMN_INDEXContent; } }
        private static int _TITLE_COLUMN_INDEXContent = default;
        private static bool _TITLE_COLUMN_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#TYPE_ALARM"/>
        /// </summary>
        public static int TYPE_ALARM { get { if (!_TYPE_ALARMReady) { _TYPE_ALARMContent = SGetField<int>(LocalBridgeClazz, "TYPE_ALARM"); _TYPE_ALARMReady = true; } return _TYPE_ALARMContent; } }
        private static int _TYPE_ALARMContent = default;
        private static bool _TYPE_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#TYPE_ALL"/>
        /// </summary>
        public static int TYPE_ALL { get { if (!_TYPE_ALLReady) { _TYPE_ALLContent = SGetField<int>(LocalBridgeClazz, "TYPE_ALL"); _TYPE_ALLReady = true; } return _TYPE_ALLContent; } }
        private static int _TYPE_ALLContent = default;
        private static bool _TYPE_ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#TYPE_NOTIFICATION"/>
        /// </summary>
        public static int TYPE_NOTIFICATION { get { if (!_TYPE_NOTIFICATIONReady) { _TYPE_NOTIFICATIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_NOTIFICATION"); _TYPE_NOTIFICATIONReady = true; } return _TYPE_NOTIFICATIONContent; } }
        private static int _TYPE_NOTIFICATIONContent = default;
        private static bool _TYPE_NOTIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#TYPE_RINGTONE"/>
        /// </summary>
        public static int TYPE_RINGTONE { get { if (!_TYPE_RINGTONEReady) { _TYPE_RINGTONEContent = SGetField<int>(LocalBridgeClazz, "TYPE_RINGTONE"); _TYPE_RINGTONEReady = true; } return _TYPE_RINGTONEContent; } }
        private static int _TYPE_RINGTONEContent = default;
        private static bool _TYPE_RINGTONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#URI_COLUMN_INDEX"/>
        /// </summary>
        public static int URI_COLUMN_INDEX { get { if (!_URI_COLUMN_INDEXReady) { _URI_COLUMN_INDEXContent = SGetField<int>(LocalBridgeClazz, "URI_COLUMN_INDEX"); _URI_COLUMN_INDEXReady = true; } return _URI_COLUMN_INDEXContent; } }
        private static int _URI_COLUMN_INDEXContent = default;
        private static bool _URI_COLUMN_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#ACTION_RINGTONE_PICKER"/>
        /// </summary>
        public static Java.Lang.String ACTION_RINGTONE_PICKER { get { if (!_ACTION_RINGTONE_PICKERReady) { _ACTION_RINGTONE_PICKERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_RINGTONE_PICKER"); _ACTION_RINGTONE_PICKERReady = true; } return _ACTION_RINGTONE_PICKERContent; } }
        private static Java.Lang.String _ACTION_RINGTONE_PICKERContent = default;
        private static bool _ACTION_RINGTONE_PICKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_DEFAULT_URI"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_DEFAULT_URI { get { if (!_EXTRA_RINGTONE_DEFAULT_URIReady) { _EXTRA_RINGTONE_DEFAULT_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_DEFAULT_URI"); _EXTRA_RINGTONE_DEFAULT_URIReady = true; } return _EXTRA_RINGTONE_DEFAULT_URIContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_DEFAULT_URIContent = default;
        private static bool _EXTRA_RINGTONE_DEFAULT_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_EXISTING_URI"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_EXISTING_URI { get { if (!_EXTRA_RINGTONE_EXISTING_URIReady) { _EXTRA_RINGTONE_EXISTING_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_EXISTING_URI"); _EXTRA_RINGTONE_EXISTING_URIReady = true; } return _EXTRA_RINGTONE_EXISTING_URIContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_EXISTING_URIContent = default;
        private static bool _EXTRA_RINGTONE_EXISTING_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_INCLUDE_DRM"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_RINGTONE_INCLUDE_DRM { get { if (!_EXTRA_RINGTONE_INCLUDE_DRMReady) { _EXTRA_RINGTONE_INCLUDE_DRMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_INCLUDE_DRM"); _EXTRA_RINGTONE_INCLUDE_DRMReady = true; } return _EXTRA_RINGTONE_INCLUDE_DRMContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_INCLUDE_DRMContent = default;
        private static bool _EXTRA_RINGTONE_INCLUDE_DRMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_PICKED_URI"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_PICKED_URI { get { if (!_EXTRA_RINGTONE_PICKED_URIReady) { _EXTRA_RINGTONE_PICKED_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_PICKED_URI"); _EXTRA_RINGTONE_PICKED_URIReady = true; } return _EXTRA_RINGTONE_PICKED_URIContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_PICKED_URIContent = default;
        private static bool _EXTRA_RINGTONE_PICKED_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_SHOW_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_SHOW_DEFAULT { get { if (!_EXTRA_RINGTONE_SHOW_DEFAULTReady) { _EXTRA_RINGTONE_SHOW_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_SHOW_DEFAULT"); _EXTRA_RINGTONE_SHOW_DEFAULTReady = true; } return _EXTRA_RINGTONE_SHOW_DEFAULTContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_SHOW_DEFAULTContent = default;
        private static bool _EXTRA_RINGTONE_SHOW_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_SHOW_SILENT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_SHOW_SILENT { get { if (!_EXTRA_RINGTONE_SHOW_SILENTReady) { _EXTRA_RINGTONE_SHOW_SILENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_SHOW_SILENT"); _EXTRA_RINGTONE_SHOW_SILENTReady = true; } return _EXTRA_RINGTONE_SHOW_SILENTContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_SHOW_SILENTContent = default;
        private static bool _EXTRA_RINGTONE_SHOW_SILENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_TITLE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_TITLE { get { if (!_EXTRA_RINGTONE_TITLEReady) { _EXTRA_RINGTONE_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_TITLE"); _EXTRA_RINGTONE_TITLEReady = true; } return _EXTRA_RINGTONE_TITLEContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_TITLEContent = default;
        private static bool _EXTRA_RINGTONE_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#EXTRA_RINGTONE_TYPE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE_TYPE { get { if (!_EXTRA_RINGTONE_TYPEReady) { _EXTRA_RINGTONE_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE_TYPE"); _EXTRA_RINGTONE_TYPEReady = true; } return _EXTRA_RINGTONE_TYPEContent; } }
        private static Java.Lang.String _EXTRA_RINGTONE_TYPEContent = default;
        private static bool _EXTRA_RINGTONE_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#openDefaultRingtoneUri(android.content.Context,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public static Android.Content.Res.AssetFileDescriptor OpenDefaultRingtoneUri(Android.Content.Context arg0, Android.Net.Uri arg1)
        {
            return SExecute<Android.Content.Res.AssetFileDescriptor>(LocalBridgeClazz, "openDefaultRingtoneUri", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getRingtone(android.content.Context,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Media.Ringtone"/></returns>
        public static Android.Media.Ringtone GetRingtone(Android.Content.Context arg0, Android.Net.Uri arg1)
        {
            return SExecute<Android.Media.Ringtone>(LocalBridgeClazz, "getRingtone", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getActualDefaultRingtoneUri(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri GetActualDefaultRingtoneUri(Android.Content.Context arg0, int arg1)
        {
            return SExecute<Android.Net.Uri>(LocalBridgeClazz, "getActualDefaultRingtoneUri", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getDefaultUri(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri GetDefaultUri(int arg0)
        {
            return SExecuteWithSignature<Android.Net.Uri>(LocalBridgeClazz, "getDefaultUri", "(I)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getValidRingtoneUri(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public static Android.Net.Uri GetValidRingtoneUri(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Net.Uri>(LocalBridgeClazz, "getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#hasHapticChannels(android.content.Context,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool HasHapticChannels(Android.Content.Context arg0, Android.Net.Uri arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "hasHapticChannels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#hasHapticChannels(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool HasHapticChannels(Android.Net.Uri arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "hasHapticChannels", "(Landroid/net/Uri;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#isDefault(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDefault(Android.Net.Uri arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDefault", "(Landroid/net/Uri;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getDefaultType(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetDefaultType(Android.Net.Uri arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getDefaultType", "(Landroid/net/Uri;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#setActualDefaultRingtoneUri(android.content.Context,int,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Net.Uri"/></param>
        public static void SetActualDefaultRingtoneUri(Android.Content.Context arg0, int arg1, Android.Net.Uri arg2)
        {
            SExecute(LocalBridgeClazz, "setActualDefaultRingtoneUri", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getCursor()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor GetCursor()
        {
            return IExecuteWithSignature<Android.Database.Cursor>("getCursor", "()Landroid/database/Cursor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getRingtone(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.Ringtone"/></returns>
        public Android.Media.Ringtone GetRingtone(int arg0)
        {
            return IExecuteWithSignature<Android.Media.Ringtone>("getRingtone", "(I)Landroid/media/Ringtone;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getRingtoneUri(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetRingtoneUri(int arg0)
        {
            return IExecuteWithSignature<Android.Net.Uri>("getRingtoneUri", "(I)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getIncludeDrm()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetIncludeDrm()
        {
            return IExecuteWithSignature<bool>("getIncludeDrm", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getStopPreviousRingtone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetStopPreviousRingtone()
        {
            return IExecuteWithSignature<bool>("getStopPreviousRingtone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#hasHapticChannels(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasHapticChannels(int arg0)
        {
            return IExecuteWithSignature<bool>("hasHapticChannels", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#getRingtonePosition(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRingtonePosition(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<int>("getRingtonePosition", "(Landroid/net/Uri;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#inferStreamType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int InferStreamType()
        {
            return IExecuteWithSignature<int>("inferStreamType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#setIncludeDrm(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetIncludeDrm(bool arg0)
        {
            IExecuteWithSignature("setIncludeDrm", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#setStopPreviousRingtone(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetStopPreviousRingtone(bool arg0)
        {
            IExecuteWithSignature("setStopPreviousRingtone", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#setType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetType(int arg0)
        {
            IExecuteWithSignature("setType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RingtoneManager.html#stopPreviousRingtone()"/>
        /// </summary>
        public void StopPreviousRingtone()
        {
            IExecuteWithSignature("stopPreviousRingtone", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}