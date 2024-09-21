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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Method
{
    #region BaseMovementMethod declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html"/>
    /// </summary>
    public partial class BaseMovementMethod : Android.Text.Method.MovementMethod
    {
        const string _bridgeClassName = "android.text.method.BaseMovementMethod";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BaseMovementMethod() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BaseMovementMethod(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region BaseMovementMethod implementation
    public partial class BaseMovementMethod
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#canSelectArbitrarily()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanSelectArbitrarily()
        {
            return IExecuteWithSignature<bool>("canSelectArbitrarily", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#nextParagraph(android.widget.TextView,android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NextParagraph(Android.Widget.TextView arg0, Android.Text.Spannable arg1)
        {
            return IExecute<bool>("nextParagraph", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onGenericMotionEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onKeyDown(android.widget.TextView,android.text.Spannable,int,android.view.KeyEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onKeyOther(android.widget.TextView,android.text.Spannable,android.view.KeyEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onKeyUp(android.widget.TextView,android.text.Spannable,int,android.view.KeyEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onTouchEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onTrackballEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#previousParagraph(android.widget.TextView,android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PreviousParagraph(Android.Widget.TextView arg0, Android.Text.Spannable arg1)
        {
            return IExecute<bool>("previousParagraph", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#initialize(android.widget.TextView,android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        public void Initialize(Android.Widget.TextView arg0, Android.Text.Spannable arg1)
        {
            IExecute("initialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseMovementMethod.html#onTakeFocus(android.widget.TextView,android.text.Spannable,int)"/>
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