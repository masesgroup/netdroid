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

namespace Android.App
{
    #region WallpaperManager
    public partial class WallpaperManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#FLAG_LOCK"/>
        /// </summary>
        public static int FLAG_LOCK { get { if (!_FLAG_LOCKReady) { _FLAG_LOCKContent = SGetField<int>(LocalBridgeClazz, "FLAG_LOCK"); _FLAG_LOCKReady = true; } return _FLAG_LOCKContent; } }
        private static int _FLAG_LOCKContent = default;
        private static bool _FLAG_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#FLAG_SYSTEM"/>
        /// </summary>
        public static int FLAG_SYSTEM { get { if (!_FLAG_SYSTEMReady) { _FLAG_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "FLAG_SYSTEM"); _FLAG_SYSTEMReady = true; } return _FLAG_SYSTEMContent; } }
        private static int _FLAG_SYSTEMContent = default;
        private static bool _FLAG_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#ACTION_CHANGE_LIVE_WALLPAPER"/>
        /// </summary>
        public static Java.Lang.String ACTION_CHANGE_LIVE_WALLPAPER { get { if (!_ACTION_CHANGE_LIVE_WALLPAPERReady) { _ACTION_CHANGE_LIVE_WALLPAPERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CHANGE_LIVE_WALLPAPER"); _ACTION_CHANGE_LIVE_WALLPAPERReady = true; } return _ACTION_CHANGE_LIVE_WALLPAPERContent; } }
        private static Java.Lang.String _ACTION_CHANGE_LIVE_WALLPAPERContent = default;
        private static bool _ACTION_CHANGE_LIVE_WALLPAPERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#ACTION_CROP_AND_SET_WALLPAPER"/>
        /// </summary>
        public static Java.Lang.String ACTION_CROP_AND_SET_WALLPAPER { get { if (!_ACTION_CROP_AND_SET_WALLPAPERReady) { _ACTION_CROP_AND_SET_WALLPAPERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CROP_AND_SET_WALLPAPER"); _ACTION_CROP_AND_SET_WALLPAPERReady = true; } return _ACTION_CROP_AND_SET_WALLPAPERContent; } }
        private static Java.Lang.String _ACTION_CROP_AND_SET_WALLPAPERContent = default;
        private static bool _ACTION_CROP_AND_SET_WALLPAPERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#ACTION_LIVE_WALLPAPER_CHOOSER"/>
        /// </summary>
        public static Java.Lang.String ACTION_LIVE_WALLPAPER_CHOOSER { get { if (!_ACTION_LIVE_WALLPAPER_CHOOSERReady) { _ACTION_LIVE_WALLPAPER_CHOOSERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_LIVE_WALLPAPER_CHOOSER"); _ACTION_LIVE_WALLPAPER_CHOOSERReady = true; } return _ACTION_LIVE_WALLPAPER_CHOOSERContent; } }
        private static Java.Lang.String _ACTION_LIVE_WALLPAPER_CHOOSERContent = default;
        private static bool _ACTION_LIVE_WALLPAPER_CHOOSERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#COMMAND_DROP"/>
        /// </summary>
        public static Java.Lang.String COMMAND_DROP { get { if (!_COMMAND_DROPReady) { _COMMAND_DROPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COMMAND_DROP"); _COMMAND_DROPReady = true; } return _COMMAND_DROPContent; } }
        private static Java.Lang.String _COMMAND_DROPContent = default;
        private static bool _COMMAND_DROPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#COMMAND_SECONDARY_TAP"/>
        /// </summary>
        public static Java.Lang.String COMMAND_SECONDARY_TAP { get { if (!_COMMAND_SECONDARY_TAPReady) { _COMMAND_SECONDARY_TAPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COMMAND_SECONDARY_TAP"); _COMMAND_SECONDARY_TAPReady = true; } return _COMMAND_SECONDARY_TAPContent; } }
        private static Java.Lang.String _COMMAND_SECONDARY_TAPContent = default;
        private static bool _COMMAND_SECONDARY_TAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#COMMAND_TAP"/>
        /// </summary>
        public static Java.Lang.String COMMAND_TAP { get { if (!_COMMAND_TAPReady) { _COMMAND_TAPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COMMAND_TAP"); _COMMAND_TAPReady = true; } return _COMMAND_TAPContent; } }
        private static Java.Lang.String _COMMAND_TAPContent = default;
        private static bool _COMMAND_TAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#EXTRA_LIVE_WALLPAPER_COMPONENT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LIVE_WALLPAPER_COMPONENT { get { if (!_EXTRA_LIVE_WALLPAPER_COMPONENTReady) { _EXTRA_LIVE_WALLPAPER_COMPONENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LIVE_WALLPAPER_COMPONENT"); _EXTRA_LIVE_WALLPAPER_COMPONENTReady = true; } return _EXTRA_LIVE_WALLPAPER_COMPONENTContent; } }
        private static Java.Lang.String _EXTRA_LIVE_WALLPAPER_COMPONENTContent = default;
        private static bool _EXTRA_LIVE_WALLPAPER_COMPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#WALLPAPER_PREVIEW_META_DATA"/>
        /// </summary>
        public static Java.Lang.String WALLPAPER_PREVIEW_META_DATA { get { if (!_WALLPAPER_PREVIEW_META_DATAReady) { _WALLPAPER_PREVIEW_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WALLPAPER_PREVIEW_META_DATA"); _WALLPAPER_PREVIEW_META_DATAReady = true; } return _WALLPAPER_PREVIEW_META_DATAContent; } }
        private static Java.Lang.String _WALLPAPER_PREVIEW_META_DATAContent = default;
        private static bool _WALLPAPER_PREVIEW_META_DATAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getInstance(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.App.WallpaperManager"/></returns>
        public static Android.App.WallpaperManager GetInstance(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.App.WallpaperManager>(LocalBridgeClazz, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getBuiltInDrawable()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Drawable BuiltInDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getBuiltInDrawable", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getDesiredMinimumHeight()"/> 
        /// </summary>
        public int DesiredMinimumHeight
        {
            get { return IExecuteWithSignature<int>("getDesiredMinimumHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getDesiredMinimumWidth()"/> 
        /// </summary>
        public int DesiredMinimumWidth
        {
            get { return IExecuteWithSignature<int>("getDesiredMinimumWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getDrawable()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Drawable Drawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDrawable", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getFastDrawable()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Drawable FastDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getFastDrawable", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getWallpaperInfo()"/> 
        /// </summary>
        public Android.App.WallpaperInfo WallpaperInfo
        {
            get { return IExecuteWithSignature<Android.App.WallpaperInfo>("getWallpaperInfo", "()Landroid/app/WallpaperInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getWallpaperColors(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.WallpaperColors"/></returns>
        public Android.App.WallpaperColors GetWallpaperColors(int arg0)
        {
            return IExecuteWithSignature<Android.App.WallpaperColors>("getWallpaperColors", "(I)Landroid/app/WallpaperColors;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getWallpaperInfo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.WallpaperInfo"/></returns>
        public Android.App.WallpaperInfo GetWallpaperInfo(int arg0)
        {
            return IExecuteWithSignature<Android.App.WallpaperInfo>("getWallpaperInfo", "(I)Landroid/app/WallpaperInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getCropAndSetWallpaperIntent(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent GetCropAndSetWallpaperIntent(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Android.Content.Intent>("getCropAndSetWallpaperIntent", "(Landroid/net/Uri;)Landroid/content/Intent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getBuiltInDrawable(int,int,boolean,float,float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetBuiltInDrawable(int arg0, int arg1, bool arg2, float arg3, float arg4, int arg5)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getBuiltInDrawable", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getBuiltInDrawable(int,int,boolean,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetBuiltInDrawable(int arg0, int arg1, bool arg2, float arg3, float arg4)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getBuiltInDrawable", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getBuiltInDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetBuiltInDrawable(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getBuiltInDrawable", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawable(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getFastDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetFastDrawable(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getFastDrawable", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#peekDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable PeekDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("peekDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#peekDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable PeekDrawable(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("peekDrawable", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#peekFastDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable PeekFastDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("peekFastDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#peekFastDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable PeekFastDrawable(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("peekFastDrawable", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getWallpaperFile(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor GetWallpaperFile(int arg0)
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("getWallpaperFile", "(I)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#hasResourceWallpaper(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasResourceWallpaper(int arg0)
        {
            return IExecuteWithSignature<bool>("hasResourceWallpaper", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#isSetWallpaperAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSetWallpaperAllowed()
        {
            return IExecuteWithSignature<bool>("isSetWallpaperAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#isWallpaperSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWallpaperSupported()
        {
            return IExecuteWithSignature<bool>("isWallpaperSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#getWallpaperId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetWallpaperId(int arg0)
        {
            return IExecuteWithSignature<int>("getWallpaperId", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setBitmap(android.graphics.Bitmap,android.graphics.Rect,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SetBitmap(Android.Graphics.Bitmap arg0, Android.Graphics.Rect arg1, bool arg2, int arg3)
        {
            return IExecute<int>("setBitmap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setBitmap(android.graphics.Bitmap,android.graphics.Rect,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SetBitmap(Android.Graphics.Bitmap arg0, Android.Graphics.Rect arg1, bool arg2)
        {
            return IExecute<int>("setBitmap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setResource(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SetResource(int arg0, int arg1)
        {
            return IExecute<int>("setResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setStream(java.io.InputStream,android.graphics.Rect,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SetStream(Java.Io.InputStream arg0, Android.Graphics.Rect arg1, bool arg2, int arg3)
        {
            return IExecute<int>("setStream", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setStream(java.io.InputStream,android.graphics.Rect,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SetStream(Java.Io.InputStream arg0, Android.Graphics.Rect arg1, bool arg2)
        {
            return IExecute<int>("setStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#addOnColorsChangedListener(android.app.WallpaperManager.OnColorsChangedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.WallpaperManager.OnColorsChangedListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void AddOnColorsChangedListener(Android.App.WallpaperManager.OnColorsChangedListener arg0, Android.Os.Handler arg1)
        {
            IExecute("addOnColorsChangedListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#clear()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#clear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Clear(int arg0)
        {
            IExecuteWithSignature("clear", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#clearWallpaper()"/>
        /// </summary>
        public void ClearWallpaper()
        {
            IExecuteWithSignature("clearWallpaper", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#clearWallpaperOffsets(android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        public void ClearWallpaperOffsets(Android.Os.IBinder arg0)
        {
            IExecuteWithSignature("clearWallpaperOffsets", "(Landroid/os/IBinder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#forgetLoadedWallpaper()"/>
        /// </summary>
        public void ForgetLoadedWallpaper()
        {
            IExecuteWithSignature("forgetLoadedWallpaper", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#removeOnColorsChangedListener(android.app.WallpaperManager.OnColorsChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.WallpaperManager.OnColorsChangedListener"/></param>
        public void RemoveOnColorsChangedListener(Android.App.WallpaperManager.OnColorsChangedListener arg0)
        {
            IExecuteWithSignature("removeOnColorsChangedListener", "(Landroid/app/WallpaperManager$OnColorsChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#sendWallpaperCommand(android.os.IBinder,java.lang.String,int,int,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Os.Bundle"/></param>
        public void SendWallpaperCommand(Android.Os.IBinder arg0, Java.Lang.String arg1, int arg2, int arg3, int arg4, Android.Os.Bundle arg5)
        {
            IExecute("sendWallpaperCommand", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setBitmap(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetBitmap(Android.Graphics.Bitmap arg0)
        {
            IExecuteWithSignature("setBitmap", "(Landroid/graphics/Bitmap;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setDisplayPadding(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetDisplayPadding(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setDisplayPadding", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetResource(int arg0)
        {
            IExecuteWithSignature("setResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetStream(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("setStream", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setWallpaperOffsets(android.os.IBinder,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetWallpaperOffsets(Android.Os.IBinder arg0, float arg1, float arg2)
        {
            IExecute("setWallpaperOffsets", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#setWallpaperOffsetSteps(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetWallpaperOffsetSteps(float arg0, float arg1)
        {
            IExecute("setWallpaperOffsetSteps", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.html#suggestDesiredDimensions(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SuggestDesiredDimensions(int arg0, int arg1)
        {
            IExecute("suggestDesiredDimensions", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region OnColorsChangedListener
        public partial class OnColorsChangedListener
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// Handlers initializer for <see cref="OnColorsChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onColorsChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.App.WallpaperColors>>>(OnColorsChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/WallpaperManager.OnColorsChangedListener.html#onColorsChanged(android.app.WallpaperColors,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnColorsChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.App.WallpaperColors, int> OnOnColorsChanged { get; set; } = null;

            void OnColorsChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.App.WallpaperColors>> data)
            {
                var methodToExecute = (OnOnColorsChanged != null) ? OnOnColorsChanged : OnColorsChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.OnColorsChangedListener.html#onColorsChanged(android.app.WallpaperColors,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.WallpaperColors"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public virtual void OnColorsChanged(Android.App.WallpaperColors arg0, int arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnColorsChangedListenerDirect
        public partial class OnColorsChangedListenerDirect
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/WallpaperManager.OnColorsChangedListener.html#onColorsChanged(android.app.WallpaperColors,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.WallpaperColors"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public override void OnColorsChanged(Android.App.WallpaperColors arg0, int arg1)
            {
                IExecute("onColorsChanged", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}