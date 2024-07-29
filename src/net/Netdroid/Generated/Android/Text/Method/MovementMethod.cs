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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Method
{
    #region IMovementMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMovementMethod
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MovementMethod
    public partial class MovementMethod : Android.Text.Method.IMovementMethod
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
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#canSelectArbitrarily()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanSelectArbitrarily()
        {
            return IExecuteWithSignature<bool>("canSelectArbitrarily", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onGenericMotionEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnGenericMotionEvent(Android.Widget.TextView arg0, Android.Text.Spannable arg1, Android.View.MotionEvent arg2)
        {
            return IExecute<bool>("onGenericMotionEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onKeyDown(android.widget.TextView,android.text.Spannable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyDown(Android.Widget.TextView arg0, Android.Text.Spannable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("onKeyDown", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onKeyOther(android.widget.TextView,android.text.Spannable,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyOther(Android.Widget.TextView arg0, Android.Text.Spannable arg1, Android.View.KeyEvent arg2)
        {
            return IExecute<bool>("onKeyOther", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onKeyUp(android.widget.TextView,android.text.Spannable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyUp(Android.Widget.TextView arg0, Android.Text.Spannable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("onKeyUp", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onTouchEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTouchEvent(Android.Widget.TextView arg0, Android.Text.Spannable arg1, Android.View.MotionEvent arg2)
        {
            return IExecute<bool>("onTouchEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onTrackballEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTrackballEvent(Android.Widget.TextView arg0, Android.Text.Spannable arg1, Android.View.MotionEvent arg2)
        {
            return IExecute<bool>("onTrackballEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#initialize(android.widget.TextView,android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        public void Initialize(Android.Widget.TextView arg0, Android.Text.Spannable arg1)
        {
            IExecute("initialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MovementMethod.html#onTakeFocus(android.widget.TextView,android.text.Spannable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnTakeFocus(Android.Widget.TextView arg0, Android.Text.Spannable arg1, int arg2)
        {
            IExecute("onTakeFocus", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}