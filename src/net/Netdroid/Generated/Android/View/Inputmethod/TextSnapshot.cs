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

namespace Android.View.Inputmethod
{
    #region TextSnapshot
    public partial class TextSnapshot
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#%3Cinit%3E(android.view.inputmethod.SurroundingText,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.SurroundingText"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TextSnapshot(Android.View.Inputmethod.SurroundingText arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getCompositionEnd()"/> 
        /// </summary>
        public int CompositionEnd
        {
            get { return IExecuteWithSignature<int>("getCompositionEnd", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getCompositionStart()"/> 
        /// </summary>
        public int CompositionStart
        {
            get { return IExecuteWithSignature<int>("getCompositionStart", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getCursorCapsMode()"/> 
        /// </summary>
        public int CursorCapsMode
        {
            get { return IExecuteWithSignature<int>("getCursorCapsMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getSelectionEnd()"/> 
        /// </summary>
        public int SelectionEnd
        {
            get { return IExecuteWithSignature<int>("getSelectionEnd", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getSelectionStart()"/> 
        /// </summary>
        public int SelectionStart
        {
            get { return IExecuteWithSignature<int>("getSelectionStart", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getSurroundingText()"/> 
        /// </summary>
        public Android.View.Inputmethod.SurroundingText SurroundingText
        {
            get { return IExecuteWithSignature<Android.View.Inputmethod.SurroundingText>("getSurroundingText", "()Landroid/view/inputmethod/SurroundingText;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}