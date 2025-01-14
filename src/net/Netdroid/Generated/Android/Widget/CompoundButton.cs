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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region CompoundButton declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html"/>
    /// </summary>
    public partial class CompoundButton : Android.Widget.Button
    {
        const string _bridgeClassName = "android.widget.CompoundButton";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CompoundButton class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CompoundButton() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CompoundButton class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CompoundButton(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region OnCheckedChangeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.OnCheckedChangeListener.html"/>
        /// </summary>
        public partial class OnCheckedChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnCheckedChangeListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.CompoundButton_OnCheckedChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnCheckedChangeListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnCheckedChangeListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnCheckedChangeListenerDirect : OnCheckedChangeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.CompoundButton$OnCheckedChangeListener";
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

    #region CompoundButton implementation
    public partial class CompoundButton
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public CompoundButton(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public CompoundButton(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public CompoundButton(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public CompoundButton(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.CompoundButton"/> to <see cref="Android.Widget.Checkable"/>
        /// </summary>
        public static implicit operator Android.Widget.Checkable(Android.Widget.CompoundButton t) => t.Cast<Android.Widget.Checkable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetButtonTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getButtonTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetButtonTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getButtonTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetButtonDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getButtonDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetButtonTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getButtonTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#isChecked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsChecked()
        {
            return IExecuteWithSignature<bool>("isChecked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetButtonDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetButtonDrawable(int arg0)
        {
            IExecuteWithSignature("setButtonDrawable", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonIcon(android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
        public void SetButtonIcon(Android.Graphics.Drawable.Icon arg0)
        {
            IExecuteWithSignature("setButtonIcon", "(Landroid/graphics/drawable/Icon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetButtonTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setButtonTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetButtonTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setButtonTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetButtonTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setButtonTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setChecked(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetChecked(bool arg0)
        {
            IExecuteWithSignature("setChecked", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.CompoundButton.OnCheckedChangeListener"/></param>
        public void SetOnCheckedChangeListener(Android.Widget.CompoundButton.OnCheckedChangeListener arg0)
        {
            IExecuteWithSignature("setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#toggle()"/>
        /// </summary>
        public void Toggle()
        {
            IExecuteWithSignature("toggle", "()V");
        }
    
        #endregion
    
        #region Nested classes
        #region OnCheckedChangeListener implementation
        public partial class OnCheckedChangeListener
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
            /// Handlers initializer for <see cref="OnCheckedChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onCheckedChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnCheckedChangedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/CompoundButton.OnCheckedChangeListener.html#onCheckedChanged(android.widget.CompoundButton,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnCheckedChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.CompoundButton, bool> OnOnCheckedChanged { get; set; } = null;
            
            bool hasOverrideOnCheckedChanged = true;
            void OnCheckedChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnCheckedChanged = true;
                var methodToExecute = (OnOnCheckedChanged != null) ? OnOnCheckedChanged : OnCheckedChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.CompoundButton>(0), data.EventData.GetAt<bool>(1));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnCheckedChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.OnCheckedChangeListener.html#onCheckedChanged(android.widget.CompoundButton,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.CompoundButton"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public virtual void OnCheckedChanged(Android.Widget.CompoundButton arg0, bool arg1)
            {
                hasOverrideOnCheckedChanged = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnCheckedChangeListenerDirect implementation
        public partial class OnCheckedChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.OnCheckedChangeListener.html#onCheckedChanged(android.widget.CompoundButton,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.CompoundButton"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public override void OnCheckedChanged(Android.Widget.CompoundButton arg0, bool arg1)
            {
                IExecuteWithSignature("onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V", arg0, arg1);
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