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

namespace Android.Widget
{
    #region DialerFilter
    public partial class DialerFilter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public DialerFilter(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public DialerFilter(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#DIGITS_AND_LETTERS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int DIGITS_AND_LETTERS { get { if (!_DIGITS_AND_LETTERSReady) { _DIGITS_AND_LETTERSContent = SGetField<int>(LocalBridgeClazz, "DIGITS_AND_LETTERS"); _DIGITS_AND_LETTERSReady = true; } return _DIGITS_AND_LETTERSContent; } }
        private static int _DIGITS_AND_LETTERSContent = default;
        private static bool _DIGITS_AND_LETTERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#DIGITS_AND_LETTERS_NO_DIGITS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int DIGITS_AND_LETTERS_NO_DIGITS { get { if (!_DIGITS_AND_LETTERS_NO_DIGITSReady) { _DIGITS_AND_LETTERS_NO_DIGITSContent = SGetField<int>(LocalBridgeClazz, "DIGITS_AND_LETTERS_NO_DIGITS"); _DIGITS_AND_LETTERS_NO_DIGITSReady = true; } return _DIGITS_AND_LETTERS_NO_DIGITSContent; } }
        private static int _DIGITS_AND_LETTERS_NO_DIGITSContent = default;
        private static bool _DIGITS_AND_LETTERS_NO_DIGITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#DIGITS_AND_LETTERS_NO_LETTERS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int DIGITS_AND_LETTERS_NO_LETTERS { get { if (!_DIGITS_AND_LETTERS_NO_LETTERSReady) { _DIGITS_AND_LETTERS_NO_LETTERSContent = SGetField<int>(LocalBridgeClazz, "DIGITS_AND_LETTERS_NO_LETTERS"); _DIGITS_AND_LETTERS_NO_LETTERSReady = true; } return _DIGITS_AND_LETTERS_NO_LETTERSContent; } }
        private static int _DIGITS_AND_LETTERS_NO_LETTERSContent = default;
        private static bool _DIGITS_AND_LETTERS_NO_LETTERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#DIGITS_ONLY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int DIGITS_ONLY { get { if (!_DIGITS_ONLYReady) { _DIGITS_ONLYContent = SGetField<int>(LocalBridgeClazz, "DIGITS_ONLY"); _DIGITS_ONLYReady = true; } return _DIGITS_ONLYContent; } }
        private static int _DIGITS_ONLYContent = default;
        private static bool _DIGITS_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#LETTERS_ONLY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int LETTERS_ONLY { get { if (!_LETTERS_ONLYReady) { _LETTERS_ONLYContent = SGetField<int>(LocalBridgeClazz, "LETTERS_ONLY"); _LETTERS_ONLYReady = true; } return _LETTERS_ONLYContent; } }
        private static int _LETTERS_ONLYContent = default;
        private static bool _LETTERS_ONLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#isQwertyKeyboard()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsQwertyKeyboard()
        {
            return IExecuteWithSignature<bool>("isQwertyKeyboard", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#getMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetMode()
        {
            return IExecuteWithSignature<int>("getMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#getDigits()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetDigits()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDigits", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#getFilterText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetFilterText()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getFilterText", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#getLetters()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetLetters()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLetters", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#append(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Append(Java.Lang.String arg0)
        {
            IExecuteWithSignature("append", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#clearText()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void ClearText()
        {
            IExecuteWithSignature("clearText", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#removeFilterWatcher(android.text.TextWatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextWatcher"/></param>
        [global::System.Obsolete()]
        public void RemoveFilterWatcher(Android.Text.TextWatcher arg0)
        {
            IExecuteWithSignature("removeFilterWatcher", "(Landroid/text/TextWatcher;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#setDigitsWatcher(android.text.TextWatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextWatcher"/></param>
        [global::System.Obsolete()]
        public void SetDigitsWatcher(Android.Text.TextWatcher arg0)
        {
            IExecuteWithSignature("setDigitsWatcher", "(Landroid/text/TextWatcher;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#setFilterWatcher(android.text.TextWatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextWatcher"/></param>
        [global::System.Obsolete()]
        public void SetFilterWatcher(Android.Text.TextWatcher arg0)
        {
            IExecuteWithSignature("setFilterWatcher", "(Landroid/text/TextWatcher;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#setLettersWatcher(android.text.TextWatcher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextWatcher"/></param>
        [global::System.Obsolete()]
        public void SetLettersWatcher(Android.Text.TextWatcher arg0)
        {
            IExecuteWithSignature("setLettersWatcher", "(Landroid/text/TextWatcher;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DialerFilter.html#setMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetMode(int arg0)
        {
            IExecuteWithSignature("setMode", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}