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
    #region AbsSeekBar declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html"/>
    /// </summary>
    public partial class AbsSeekBar : Android.Widget.ProgressBar
    {
        const string _bridgeClassName = "android.widget.AbsSeekBar";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbsSeekBar class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbsSeekBar() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbsSeekBar class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbsSeekBar(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region AbsSeekBar implementation
    public partial class AbsSeekBar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AbsSeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AbsSeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public AbsSeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AbsSeekBar(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetThumbTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getThumbTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMarkTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetTickMarkTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getTickMarkTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetThumbTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getThumbTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMarkTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetTickMarkTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getTickMarkTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumb()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetThumb()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getThumb", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMark()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetTickMark()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getTickMark", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetThumbTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getThumbTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMarkTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetTickMarkTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getTickMarkTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getSplitTrack()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetSplitTrack()
        {
            return IExecuteWithSignature<bool>("getSplitTrack", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getKeyProgressIncrement()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetKeyProgressIncrement()
        {
            return IExecuteWithSignature<int>("getKeyProgressIncrement", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThumbOffset()
        {
            return IExecuteWithSignature<int>("getThumbOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setKeyProgressIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetKeyProgressIncrement(int arg0)
        {
            IExecuteWithSignature("setKeyProgressIncrement", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setSplitTrack(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSplitTrack(bool arg0)
        {
            IExecuteWithSignature("setSplitTrack", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumb(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetThumb(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setThumb", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetThumbOffset(int arg0)
        {
            IExecuteWithSignature("setThumbOffset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetThumbTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setThumbTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetThumbTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setThumbTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetThumbTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setThumbTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMark(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetTickMark(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setTickMark", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMarkTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetTickMarkTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setTickMarkTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMarkTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetTickMarkTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setTickMarkTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMarkTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetTickMarkTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setTickMarkTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}