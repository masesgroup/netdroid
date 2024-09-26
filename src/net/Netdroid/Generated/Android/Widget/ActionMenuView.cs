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
    #region ActionMenuView declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html"/>
    /// </summary>
    public partial class ActionMenuView : Android.Widget.LinearLayout
    {
        const string _bridgeClassName = "android.widget.ActionMenuView";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ActionMenuView() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ActionMenuView(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.LayoutParams.html"/>
        /// </summary>
        public partial class LayoutParams : Android.Widget.LinearLayout.LayoutParams
        {
            const string _bridgeClassName = "android.widget.ActionMenuView$LayoutParams";
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

        #region OnMenuItemClickListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.OnMenuItemClickListener.html"/>
        /// </summary>
        public partial class OnMenuItemClickListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnMenuItemClickListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.ActionMenuView_OnMenuItemClickListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnMenuItemClickListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnMenuItemClickListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnMenuItemClickListenerDirect : OnMenuItemClickListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.widget.ActionMenuView$OnMenuItemClickListener";
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

    #region ActionMenuView implementation
    public partial class ActionMenuView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ActionMenuView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ActionMenuView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#getOverflowIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetOverflowIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getOverflowIcon", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#getMenu()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Menu"/></returns>
        public Android.View.Menu GetMenu()
        {
            return IExecuteWithSignature<Android.View.Menu>("getMenu", "()Landroid/view/Menu;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#hideOverflowMenu()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HideOverflowMenu()
        {
            return IExecuteWithSignature<bool>("hideOverflowMenu", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#isOverflowMenuShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOverflowMenuShowing()
        {
            return IExecuteWithSignature<bool>("isOverflowMenuShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#showOverflowMenu()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShowOverflowMenu()
        {
            return IExecuteWithSignature<bool>("showOverflowMenu", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#getPopupTheme()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPopupTheme()
        {
            return IExecuteWithSignature<int>("getPopupTheme", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#dismissPopupMenus()"/>
        /// </summary>
        public void DismissPopupMenus()
        {
            IExecuteWithSignature("dismissPopupMenus", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#onConfigurationChanged(android.content.res.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Configuration"/></param>
        public void OnConfigurationChanged(Android.Content.Res.Configuration arg0)
        {
            IExecuteWithSignature("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#onDetachedFromWindow()"/>
        /// </summary>
        public void OnDetachedFromWindow()
        {
            IExecuteWithSignature("onDetachedFromWindow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#setOnMenuItemClickListener(android.widget.ActionMenuView.OnMenuItemClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ActionMenuView.OnMenuItemClickListener"/></param>
        public void SetOnMenuItemClickListener(Android.Widget.ActionMenuView.OnMenuItemClickListener arg0)
        {
            IExecuteWithSignature("setOnMenuItemClickListener", "(Landroid/widget/ActionMenuView$OnMenuItemClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#setOverflowIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetOverflowIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setOverflowIcon", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.html#setPopupTheme(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPopupTheme(int arg0)
        {
            IExecuteWithSignature("setPopupTheme", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region LayoutParams implementation
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.LayoutParams.html#%3Cinit%3E(android.widget.ActionMenuView.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.ActionMenuView.LayoutParams"/></param>
            public LayoutParams(Android.Widget.ActionMenuView.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.LayoutParams.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
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

        #region OnMenuItemClickListener implementation
        public partial class OnMenuItemClickListener
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
            /// Handlers initializer for <see cref="OnMenuItemClickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onMenuItemClick", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnMenuItemClickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/ActionMenuView.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMenuItemClick"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.View.MenuItem, bool> OnOnMenuItemClick { get; set; } = null;

            bool hasOverrideOnMenuItemClick = true;
            void OnMenuItemClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnMenuItemClick = true;
                var methodToExecute = (OnOnMenuItemClick != null) ? OnOnMenuItemClick : OnMenuItemClick;
                var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.View.MenuItem>(0));
                data.EventData.TypedEventData.SetReturnData(hasOverrideOnMenuItemClick, executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnMenuItemClick(Android.View.MenuItem arg0)
            {
                hasOverrideOnMenuItemClick = false; return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuItemClickListenerDirect implementation
        public partial class OnMenuItemClickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/ActionMenuView.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnMenuItemClick(Android.View.MenuItem arg0)
            {
                return IExecuteWithSignature<bool>("onMenuItemClick", "(Landroid/view/MenuItem;)Z", arg0);
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