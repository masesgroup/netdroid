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

namespace Android.Widget
{
    #region Gallery declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/Gallery.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class Gallery : Android.Widget.AbsSpinner
    {
        const string _bridgeClassName = "android.widget.Gallery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Gallery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Gallery(params object[] args) : base(args) { }

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
        #region LayoutParams declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.LayoutParams.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class LayoutParams : Android.View.ViewGroup.LayoutParams
        {
            const string _bridgeClassName = "android.widget.Gallery$LayoutParams";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LayoutParams() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LayoutParams(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Gallery implementation
    public partial class Gallery
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Gallery(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public Gallery(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public Gallery(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public Gallery(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#onDown(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnDown(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onDown", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#onFling(android.view.MotionEvent,android.view.MotionEvent,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnFling(Android.View.MotionEvent arg0, Android.View.MotionEvent arg1, float arg2, float arg3)
        {
            return IExecuteWithSignature<bool>("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#onScroll(android.view.MotionEvent,android.view.MotionEvent,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnScroll(Android.View.MotionEvent arg0, Android.View.MotionEvent arg1, float arg2, float arg3)
        {
            return IExecuteWithSignature<bool>("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#onSingleTapUp(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnSingleTapUp(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#onLongPress(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        [global::System.Obsolete()]
        public void OnLongPress(Android.View.MotionEvent arg0)
        {
            IExecuteWithSignature("onLongPress", "(Landroid/view/MotionEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#onShowPress(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        [global::System.Obsolete()]
        public void OnShowPress(Android.View.MotionEvent arg0)
        {
            IExecuteWithSignature("onShowPress", "(Landroid/view/MotionEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#setAnimationDuration(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetAnimationDuration(int arg0)
        {
            IExecuteWithSignature("setAnimationDuration", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#setCallbackDuringFling(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetCallbackDuringFling(bool arg0)
        {
            IExecuteWithSignature("setCallbackDuringFling", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#setGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetGravity(int arg0)
        {
            IExecuteWithSignature("setGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#setSpacing(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSpacing(int arg0)
        {
            IExecuteWithSignature("setSpacing", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Gallery.html#setUnselectedAlpha(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void SetUnselectedAlpha(float arg0)
        {
            IExecuteWithSignature("setUnselectedAlpha", "(F)V", arg0);
        }

        #endregion

        #region Nested classes
        #region LayoutParams implementation
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Gallery.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            [global::System.Obsolete()]
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Gallery.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            [global::System.Obsolete()]
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Gallery.LayoutParams.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            [global::System.Obsolete()]
            public LayoutParams(int arg0, int arg1)
                : base(arg0, arg1)
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