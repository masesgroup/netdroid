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
    #region ZoomButtonsController declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ZoomButtonsController : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ZoomButtonsController>
    {
        const string _bridgeClassName = "android.widget.ZoomButtonsController";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ZoomButtonsController() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ZoomButtonsController(params object[] args) : base(args) { }
    
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
        #region OnZoomListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class OnZoomListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnZoomListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.ZoomButtonsController_OnZoomListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnZoomListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnZoomListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnZoomListenerDirect : OnZoomListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.ZoomButtonsController$OnZoomListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        }
        #endregion

    
    }
    #endregion

    #region ZoomButtonsController implementation
    public partial class ZoomButtonsController
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#%3Cinit%3E(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        [global::System.Obsolete()]
        public ZoomButtonsController(Android.View.View arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#getZoomControls()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        [global::System.Obsolete()]
        public Android.View.View GetZoomControls()
        {
            return IExecuteWithSignature<Android.View.View>("getZoomControls", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#getContainer()"/>
        /// </summary>
        /// <returns><see cref="Android.View.ViewGroup"/></returns>
        [global::System.Obsolete()]
        public Android.View.ViewGroup GetContainer()
        {
            return IExecuteWithSignature<Android.View.ViewGroup>("getContainer", "()Landroid/view/ViewGroup;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#isAutoDismissed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsAutoDismissed()
        {
            return IExecuteWithSignature<bool>("isAutoDismissed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#onTouch(android.view.View,android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnTouch(Android.View.View arg0, Android.View.MotionEvent arg1)
        {
            return IExecute<bool>("onTouch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setAutoDismissed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetAutoDismissed(bool arg0)
        {
            IExecuteWithSignature("setAutoDismissed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setFocusable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetFocusable(bool arg0)
        {
            IExecuteWithSignature("setFocusable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ZoomButtonsController.OnZoomListener"/></param>
        [global::System.Obsolete()]
        public void SetOnZoomListener(Android.Widget.ZoomButtonsController.OnZoomListener arg0)
        {
            IExecuteWithSignature("setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetVisible(bool arg0)
        {
            IExecuteWithSignature("setVisible", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setZoomInEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetZoomInEnabled(bool arg0)
        {
            IExecuteWithSignature("setZoomInEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setZoomOutEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetZoomOutEnabled(bool arg0)
        {
            IExecuteWithSignature("setZoomOutEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.html#setZoomSpeed(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void SetZoomSpeed(long arg0)
        {
            IExecuteWithSignature("setZoomSpeed", "(J)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region OnZoomListener implementation
        public partial class OnZoomListener
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
            /// Handlers initializer for <see cref="OnZoomListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onVisibilityChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnVisibilityChangedEventHandler));
                AddEventHandler("onZoom", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnZoomEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html#onVisibilityChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnVisibilityChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnVisibilityChanged { get; set; } = null;
            
            bool hasOverrideOnVisibilityChanged = true;
            void OnVisibilityChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnVisibilityChanged = true;
                var methodToExecute = (OnOnVisibilityChanged != null) ? OnOnVisibilityChanged : OnVisibilityChanged;
                methodToExecute.Invoke(data.EventData.GetAt<bool>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnVisibilityChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html#onVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public virtual void OnVisibilityChanged(bool arg0)
            {
                hasOverrideOnVisibilityChanged = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html#onZoom(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnZoom"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnZoom { get; set; } = null;
            
            bool hasOverrideOnZoom = true;
            void OnZoomEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnZoom = true;
                var methodToExecute = (OnOnZoom != null) ? OnOnZoom : OnZoom;
                methodToExecute.Invoke(data.EventData.GetAt<bool>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnZoom;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html#onZoom(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public virtual void OnZoom(bool arg0)
            {
                hasOverrideOnZoom = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnZoomListenerDirect implementation
        public partial class OnZoomListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html#onVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public override void OnVisibilityChanged(bool arg0)
            {
                IExecuteWithSignature("onVisibilityChanged", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ZoomButtonsController.OnZoomListener.html#onZoom(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public override void OnZoom(bool arg0)
            {
                IExecuteWithSignature("onZoom", "(Z)V", arg0);
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