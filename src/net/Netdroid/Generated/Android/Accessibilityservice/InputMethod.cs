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

namespace Android.Accessibilityservice
{
    #region InputMethod
    public partial class InputMethod
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#%3Cinit%3E(android.accessibilityservice.AccessibilityService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityService"/></param>
        public InputMethod(Android.Accessibilityservice.AccessibilityService arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#getCurrentInputConnection()"/>
        /// </summary>
        /// <returns><see cref="Android.Accessibilityservice.InputMethod.AccessibilityInputConnection"/></returns>
        public Android.Accessibilityservice.InputMethod.AccessibilityInputConnection GetCurrentInputConnection()
        {
            return IExecuteWithSignature<Android.Accessibilityservice.InputMethod.AccessibilityInputConnection>("getCurrentInputConnection", "()Landroid/accessibilityservice/InputMethod$AccessibilityInputConnection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#getCurrentInputEditorInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Inputmethod.EditorInfo"/></returns>
        public Android.View.Inputmethod.EditorInfo GetCurrentInputEditorInfo()
        {
            return IExecuteWithSignature<Android.View.Inputmethod.EditorInfo>("getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#getCurrentInputStarted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetCurrentInputStarted()
        {
            return IExecuteWithSignature<bool>("getCurrentInputStarted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#onFinishInput()"/>
        /// </summary>
        public void OnFinishInput()
        {
            IExecuteWithSignature("onFinishInput", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#onStartInput(android.view.inputmethod.EditorInfo,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.EditorInfo"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void OnStartInput(Android.View.Inputmethod.EditorInfo arg0, bool arg1)
        {
            IExecute("onStartInput", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.html#onUpdateSelection(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void OnUpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("onUpdateSelection", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes
        #region AccessibilityInputConnection
        public partial class AccessibilityInputConnection
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#getSurroundingText(int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.SurroundingText"/></returns>
            public Android.View.Inputmethod.SurroundingText GetSurroundingText(int arg0, int arg1, int arg2)
            {
                return IExecute<Android.View.Inputmethod.SurroundingText>("getSurroundingText", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#getCursorCapsMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetCursorCapsMode(int arg0)
            {
                return IExecuteWithSignature<int>("getCursorCapsMode", "(I)I", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#clearMetaKeyStates(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void ClearMetaKeyStates(int arg0)
            {
                IExecuteWithSignature("clearMetaKeyStates", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#commitText(java.lang.CharSequence,int,android.view.inputmethod.TextAttribute)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Android.View.Inputmethod.TextAttribute"/></param>
            public void CommitText(Java.Lang.CharSequence arg0, int arg1, Android.View.Inputmethod.TextAttribute arg2)
            {
                IExecute("commitText", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#deleteSurroundingText(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void DeleteSurroundingText(int arg0, int arg1)
            {
                IExecute("deleteSurroundingText", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#performContextMenuAction(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void PerformContextMenuAction(int arg0)
            {
                IExecuteWithSignature("performContextMenuAction", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#performEditorAction(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void PerformEditorAction(int arg0)
            {
                IExecuteWithSignature("performEditorAction", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#sendKeyEvent(android.view.KeyEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
            public void SendKeyEvent(Android.View.KeyEvent arg0)
            {
                IExecuteWithSignature("sendKeyEvent", "(Landroid/view/KeyEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/InputMethod.AccessibilityInputConnection.html#setSelection(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void SetSelection(int arg0, int arg1)
            {
                IExecute("setSelection", arg0, arg1);
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