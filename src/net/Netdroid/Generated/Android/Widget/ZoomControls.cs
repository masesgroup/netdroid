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
    #region ZoomControls declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ZoomControls : Android.Widget.LinearLayout
    {
        const string _bridgeClassName = "android.widget.ZoomControls";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ZoomControls() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ZoomControls(params object[] args) : base(args) { }
    
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

    #region ZoomControls implementation
    public partial class ZoomControls
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public ZoomControls(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public ZoomControls(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#hide()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Hide()
        {
            IExecuteWithSignature("hide", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#setIsZoomInEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetIsZoomInEnabled(bool arg0)
        {
            IExecuteWithSignature("setIsZoomInEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#setIsZoomOutEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetIsZoomOutEnabled(bool arg0)
        {
            IExecuteWithSignature("setIsZoomOutEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#setOnZoomInClickListener(android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View.OnClickListener"/></param>
        [global::System.Obsolete()]
        public void SetOnZoomInClickListener(Android.View.View.OnClickListener arg0)
        {
            IExecuteWithSignature("setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#setOnZoomOutClickListener(android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View.OnClickListener"/></param>
        [global::System.Obsolete()]
        public void SetOnZoomOutClickListener(Android.View.View.OnClickListener arg0)
        {
            IExecuteWithSignature("setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#setZoomSpeed(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void SetZoomSpeed(long arg0)
        {
            IExecuteWithSignature("setZoomSpeed", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomControls.html#show()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}