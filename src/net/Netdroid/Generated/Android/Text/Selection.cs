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

namespace Android.Text
{
    #region Selection
    public partial class Selection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#SELECTION_END"/>
        /// </summary>
        public static object SELECTION_END { get { if (!_SELECTION_ENDReady) { _SELECTION_ENDContent = SGetField(LocalBridgeClazz, "SELECTION_END"); _SELECTION_ENDReady = true; } return _SELECTION_ENDContent; } }
        private static object _SELECTION_ENDContent = default;
        private static bool _SELECTION_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#SELECTION_START"/>
        /// </summary>
        public static object SELECTION_START { get { if (!_SELECTION_STARTReady) { _SELECTION_STARTContent = SGetField(LocalBridgeClazz, "SELECTION_START"); _SELECTION_STARTReady = true; } return _SELECTION_STARTContent; } }
        private static object _SELECTION_STARTContent = default;
        private static bool _SELECTION_STARTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendDown(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendDown(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "extendDown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendLeft(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendLeft(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "extendLeft", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendRight(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendRight(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "extendRight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendToLeftEdge(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendToLeftEdge(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "extendToLeftEdge", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendToParagraphEnd(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendToParagraphEnd(Android.Text.Spannable arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "extendToParagraphEnd", "(Landroid/text/Spannable;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendToParagraphStart(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendToParagraphStart(Android.Text.Spannable arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "extendToParagraphStart", "(Landroid/text/Spannable;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendToRightEdge(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendToRightEdge(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "extendToRightEdge", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendUp(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ExtendUp(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "extendUp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveDown(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveDown(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveDown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveLeft(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveLeft(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveLeft", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveRight(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveRight(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveRight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveToLeftEdge(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveToLeftEdge(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveToLeftEdge", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveToParagraphEnd(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveToParagraphEnd(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveToParagraphEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveToParagraphStart(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveToParagraphStart(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveToParagraphStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveToRightEdge(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveToRightEdge(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveToRightEdge", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#moveUp(android.text.Spannable,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MoveUp(Android.Text.Spannable arg0, Android.Text.Layout arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "moveUp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#getSelectionEnd(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSelectionEnd(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSelectionEnd", "(Ljava/lang/CharSequence;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#getSelectionStart(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSelectionStart(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSelectionStart", "(Ljava/lang/CharSequence;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#extendSelection(android.text.Spannable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void ExtendSelection(Android.Text.Spannable arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "extendSelection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#removeSelection(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        public static void RemoveSelection(Android.Text.Spannable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "removeSelection", "(Landroid/text/Spannable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#selectAll(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        public static void SelectAll(Android.Text.Spannable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "selectAll", "(Landroid/text/Spannable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#setSelection(android.text.Spannable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void SetSelection(Android.Text.Spannable arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "setSelection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Selection.html#setSelection(android.text.Spannable,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public static void SetSelection(Android.Text.Spannable arg0, int arg1, int arg2)
        {
            SExecute(LocalBridgeClazz, "setSelection", arg0, arg1, arg2);
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