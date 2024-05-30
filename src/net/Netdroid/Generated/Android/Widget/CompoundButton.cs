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

namespace Android.Widget
{
    #region CompoundButton
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
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonDrawable()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Drawable ButtonDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getButtonDrawable", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonTintBlendMode()"/> <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        public Android.Graphics.BlendMode ButtonTintBlendMode
        {
            get { return IExecuteWithSignature<Android.Graphics.BlendMode>("getButtonTintBlendMode", "()Landroid/graphics/BlendMode;"); } set { IExecuteWithSignature("setButtonTintBlendMode", "(Landroid/graphics/BlendMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonTintList()"/> <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        public Android.Content.Res.ColorStateList ButtonTintList
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getButtonTintList", "()Landroid/content/res/ColorStateList;"); } set { IExecuteWithSignature("setButtonTintList", "(Landroid/content/res/ColorStateList;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#getButtonTintMode()"/> <see href="https://developer.android.com/reference/android/widget/CompoundButton.html#setButtonTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        public Android.Graphics.PorterDuff.Mode ButtonTintMode
        {
            get { return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getButtonTintMode", "()Landroid/graphics/PorterDuff$Mode;"); } set { IExecuteWithSignature("setButtonTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", value); }
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
        #region OnCheckedChangeListener
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
                AddEventHandler("onCheckedChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.CompoundButton>>>(OnCheckedChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/CompoundButton.OnCheckedChangeListener.html#onCheckedChanged(android.widget.CompoundButton,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnCheckedChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Widget.CompoundButton, bool> OnOnCheckedChanged { get; set; } = null;

            void OnCheckedChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.CompoundButton>> data)
            {
                var methodToExecute = (OnOnCheckedChanged != null) ? OnOnCheckedChanged : OnCheckedChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/CompoundButton.OnCheckedChangeListener.html#onCheckedChanged(android.widget.CompoundButton,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.CompoundButton"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public virtual void OnCheckedChanged(Android.Widget.CompoundButton arg0, bool arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnCheckedChangeListenerDirect
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
                IExecute("onCheckedChanged", arg0, arg1);
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