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

namespace Android.Text.Method
{
    #region MetaKeyKeyListener
    public partial class MetaKeyKeyListener
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#META_ALT_LOCKED"/>
        /// </summary>
        public static int META_ALT_LOCKED { get { if (!_META_ALT_LOCKEDReady) { _META_ALT_LOCKEDContent = SGetField<int>(LocalBridgeClazz, "META_ALT_LOCKED"); _META_ALT_LOCKEDReady = true; } return _META_ALT_LOCKEDContent; } }
        private static int _META_ALT_LOCKEDContent = default;
        private static bool _META_ALT_LOCKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#META_ALT_ON"/>
        /// </summary>
        public static int META_ALT_ON { get { if (!_META_ALT_ONReady) { _META_ALT_ONContent = SGetField<int>(LocalBridgeClazz, "META_ALT_ON"); _META_ALT_ONReady = true; } return _META_ALT_ONContent; } }
        private static int _META_ALT_ONContent = default;
        private static bool _META_ALT_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#META_CAP_LOCKED"/>
        /// </summary>
        public static int META_CAP_LOCKED { get { if (!_META_CAP_LOCKEDReady) { _META_CAP_LOCKEDContent = SGetField<int>(LocalBridgeClazz, "META_CAP_LOCKED"); _META_CAP_LOCKEDReady = true; } return _META_CAP_LOCKEDContent; } }
        private static int _META_CAP_LOCKEDContent = default;
        private static bool _META_CAP_LOCKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#META_SHIFT_ON"/>
        /// </summary>
        public static int META_SHIFT_ON { get { if (!_META_SHIFT_ONReady) { _META_SHIFT_ONContent = SGetField<int>(LocalBridgeClazz, "META_SHIFT_ON"); _META_SHIFT_ONReady = true; } return _META_SHIFT_ONContent; } }
        private static int _META_SHIFT_ONContent = default;
        private static bool _META_SHIFT_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#META_SYM_LOCKED"/>
        /// </summary>
        public static int META_SYM_LOCKED { get { if (!_META_SYM_LOCKEDReady) { _META_SYM_LOCKEDContent = SGetField<int>(LocalBridgeClazz, "META_SYM_LOCKED"); _META_SYM_LOCKEDReady = true; } return _META_SYM_LOCKEDContent; } }
        private static int _META_SYM_LOCKEDContent = default;
        private static bool _META_SYM_LOCKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#META_SYM_ON"/>
        /// </summary>
        public static int META_SYM_ON { get { if (!_META_SYM_ONReady) { _META_SYM_ONContent = SGetField<int>(LocalBridgeClazz, "META_SYM_ON"); _META_SYM_ONReady = true; } return _META_SYM_ONContent; } }
        private static int _META_SYM_ONContent = default;
        private static bool _META_SYM_ONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#isMetaTracker(java.lang.CharSequence,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsMetaTracker(Java.Lang.CharSequence arg0, object arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isMetaTracker", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#isSelectingMetaTracker(java.lang.CharSequence,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSelectingMetaTracker(Java.Lang.CharSequence arg0, object arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isSelectingMetaTracker", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMetaState(Java.Lang.CharSequence arg0, Android.View.KeyEvent arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMetaState(Java.Lang.CharSequence arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMetaState(Java.Lang.CharSequence arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMetaState(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMetaState", "(Ljava/lang/CharSequence;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMetaState(long arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMetaState(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMetaState", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#adjustMetaAfterKeypress(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long AdjustMetaAfterKeypress(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "adjustMetaAfterKeypress", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#handleKeyDown(long,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="long"/></returns>
        public static long HandleKeyDown(long arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "handleKeyDown", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#handleKeyUp(long,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="long"/></returns>
        public static long HandleKeyUp(long arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "handleKeyUp", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#resetLockedMeta(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ResetLockedMeta(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "resetLockedMeta", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#adjustMetaAfterKeypress(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        public static void AdjustMetaAfterKeypress(Android.Text.Spannable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void ClearMetaKeyState(Android.Text.Editable arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "clearMetaKeyState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#resetMetaState(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        public static void ResetMetaState(Android.Text.Spannable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "resetMetaState", "(Landroid/text/Spannable;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#onKeyDown(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyDown(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("onKeyDown", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyUp(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("onKeyUp", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long ClearMetaKeyState(long arg0, int arg1)
        {
            return IExecute<long>("clearMetaKeyState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void ClearMetaKeyState(Android.View.View arg0, Android.Text.Editable arg1, int arg2)
        {
            IExecute("clearMetaKeyState", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}