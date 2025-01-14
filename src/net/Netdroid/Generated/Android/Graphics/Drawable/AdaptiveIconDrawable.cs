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

namespace Android.Graphics.Drawable
{
    #region AdaptiveIconDrawable declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html"/>
    /// </summary>
    public partial class AdaptiveIconDrawable : Android.Graphics.Drawable.Drawable
    {
        const string _bridgeClassName = "android.graphics.drawable.AdaptiveIconDrawable";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdaptiveIconDrawable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdaptiveIconDrawable(params object[] args) : base(args) { }
    
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

    #region AdaptiveIconDrawable implementation
    public partial class AdaptiveIconDrawable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#%3Cinit%3E(android.graphics.drawable.Drawable,android.graphics.drawable.Drawable,android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public AdaptiveIconDrawable(Android.Graphics.Drawable.Drawable arg0, Android.Graphics.Drawable.Drawable arg1, Android.Graphics.Drawable.Drawable arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#%3Cinit%3E(android.graphics.drawable.Drawable,android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public AdaptiveIconDrawable(Android.Graphics.Drawable.Drawable arg0, Android.Graphics.Drawable.Drawable arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#getExtraInsetFraction()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public static float GetExtraInsetFraction()
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "getExtraInsetFraction", "()F");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#getBackground()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetBackground()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getBackground", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#getForeground()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetForeground()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getForeground", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#getMonochrome()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetMonochrome()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getMonochrome", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#getIconMask()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path GetIconMask()
        {
            return IExecuteWithSignature<Android.Graphics.Path>("getIconMask", "()Landroid/graphics/Path;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#invalidateDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void InvalidateDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#scheduleDrawable(android.graphics.drawable.Drawable,java.lang.Runnable,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ScheduleDrawable(Android.Graphics.Drawable.Drawable arg0, Java.Lang.Runnable arg1, long arg2)
        {
            IExecuteWithSignature("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#setOpacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOpacity(int arg0)
        {
            IExecuteWithSignature("setOpacity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AdaptiveIconDrawable.html#unscheduleDrawable(android.graphics.drawable.Drawable,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void UnscheduleDrawable(Android.Graphics.Drawable.Drawable arg0, Java.Lang.Runnable arg1)
        {
            IExecuteWithSignature("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}