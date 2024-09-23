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
    #region Touch declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/method/Touch.html"/>
    /// </summary>
    public partial class Touch : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Touch>
    {
        const string _bridgeClassName = "android.text.method.Touch";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Touch() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Touch(params object[] args) : base(args) { }
    
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

    #region Touch implementation
    public partial class Touch
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/Touch.html#onTouchEvent(android.widget.TextView,android.text.Spannable,android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg2"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool OnTouchEvent(Android.Widget.TextView arg0, Android.Text.Spannable arg1, Android.View.MotionEvent arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "onTouchEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/Touch.html#getInitialScrollX(android.widget.TextView,android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetInitialScrollX(Android.Widget.TextView arg0, Android.Text.Spannable arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getInitialScrollX", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/Touch.html#getInitialScrollY(android.widget.TextView,android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Spannable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetInitialScrollY(Android.Widget.TextView arg0, Android.Text.Spannable arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getInitialScrollY", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/Touch.html#scrollTo(android.widget.TextView,android.text.Layout,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Android.Text.Layout"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public static void ScrollTo(Android.Widget.TextView arg0, Android.Text.Layout arg1, int arg2, int arg3)
        {
            SExecute(LocalBridgeClazz, "scrollTo", arg0, arg1, arg2, arg3);
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