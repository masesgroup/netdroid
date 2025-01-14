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
    #region LayerDrawable declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html"/>
    /// </summary>
    public partial class LayerDrawable : Android.Graphics.Drawable.Drawable
    {
        const string _bridgeClassName = "android.graphics.drawable.LayerDrawable";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LayerDrawable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LayerDrawable(params object[] args) : base(args) { }
    
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

    #region LayerDrawable implementation
    public partial class LayerDrawable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#%3Cinit%3E(android.graphics.drawable.Drawable[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public LayerDrawable(Android.Graphics.Drawable.Drawable[] arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#INSET_UNDEFINED"/>
        /// </summary>
        public static int INSET_UNDEFINED { get { if (!_INSET_UNDEFINEDReady) { _INSET_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "INSET_UNDEFINED"); _INSET_UNDEFINEDReady = true; } return _INSET_UNDEFINEDContent; } }
        private static int _INSET_UNDEFINEDContent = default;
        private static bool _INSET_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#PADDING_MODE_NEST"/>
        /// </summary>
        public static int PADDING_MODE_NEST { get { if (!_PADDING_MODE_NESTReady) { _PADDING_MODE_NESTContent = SGetField<int>(LocalBridgeClazz, "PADDING_MODE_NEST"); _PADDING_MODE_NESTReady = true; } return _PADDING_MODE_NESTContent; } }
        private static int _PADDING_MODE_NESTContent = default;
        private static bool _PADDING_MODE_NESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#PADDING_MODE_STACK"/>
        /// </summary>
        public static int PADDING_MODE_STACK { get { if (!_PADDING_MODE_STACKReady) { _PADDING_MODE_STACKContent = SGetField<int>(LocalBridgeClazz, "PADDING_MODE_STACK"); _PADDING_MODE_STACKReady = true; } return _PADDING_MODE_STACKContent; } }
        private static int _PADDING_MODE_STACKContent = default;
        private static bool _PADDING_MODE_STACKReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#findDrawableByLayerId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable FindDrawableByLayerId(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawable(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setDrawableByLayerId(int,android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetDrawableByLayerId(int arg0, Android.Graphics.Drawable.Drawable arg1)
        {
            return IExecuteWithSignature<bool>("setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#addLayer(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="int"/></returns>
        public int AddLayer(Android.Graphics.Drawable.Drawable arg0)
        {
            return IExecuteWithSignature<int>("addLayer", "(Landroid/graphics/drawable/Drawable;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#findIndexByLayerId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindIndexByLayerId(int arg0)
        {
            return IExecuteWithSignature<int>("findIndexByLayerId", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getBottomPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBottomPadding()
        {
            return IExecuteWithSignature<int>("getBottomPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getEndPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEndPadding()
        {
            return IExecuteWithSignature<int>("getEndPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetId(int arg0)
        {
            return IExecuteWithSignature<int>("getId", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerGravity(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerGravity", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerHeight(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerHeight", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerInsetBottom(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerInsetBottom(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerInsetBottom", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerInsetEnd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerInsetEnd(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerInsetEnd", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerInsetLeft(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerInsetLeft(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerInsetLeft", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerInsetRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerInsetRight(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerInsetRight", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerInsetStart(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerInsetStart(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerInsetStart", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerInsetTop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerInsetTop(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerInsetTop", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLayerWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayerWidth(int arg0)
        {
            return IExecuteWithSignature<int>("getLayerWidth", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getLeftPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLeftPadding()
        {
            return IExecuteWithSignature<int>("getLeftPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getNumberOfLayers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNumberOfLayers()
        {
            return IExecuteWithSignature<int>("getNumberOfLayers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getPaddingMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPaddingMode()
        {
            return IExecuteWithSignature<int>("getPaddingMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getRightPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRightPadding()
        {
            return IExecuteWithSignature<int>("getRightPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getStartPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStartPadding()
        {
            return IExecuteWithSignature<int>("getStartPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#getTopPadding()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTopPadding()
        {
            return IExecuteWithSignature<int>("getTopPadding", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#invalidateDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void InvalidateDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#scheduleDrawable(android.graphics.drawable.Drawable,java.lang.Runnable,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ScheduleDrawable(Android.Graphics.Drawable.Drawable arg0, Java.Lang.Runnable arg1, long arg2)
        {
            IExecuteWithSignature("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setDrawable(int,android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetDrawable(int arg0, Android.Graphics.Drawable.Drawable arg1)
        {
            IExecuteWithSignature("setDrawable", "(ILandroid/graphics/drawable/Drawable;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setId(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetId(int arg0, int arg1)
        {
            IExecuteWithSignature("setId", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerGravity(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerGravity(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerGravity", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerHeight(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerHeight(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerHeight", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInset(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetLayerInset(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("setLayerInset", "(IIIII)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetBottom(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerInsetBottom(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerInsetBottom", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetEnd(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerInsetEnd(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerInsetEnd", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetLeft(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerInsetLeft(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerInsetLeft", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetRelative(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetLayerInsetRelative(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("setLayerInsetRelative", "(IIIII)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetRight(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerInsetRight(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerInsetRight", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetStart(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerInsetStart(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerInsetStart", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerInsetTop(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerInsetTop(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerInsetTop", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerSize(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetLayerSize(int arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setLayerSize", "(III)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setLayerWidth(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayerWidth(int arg0, int arg1)
        {
            IExecuteWithSignature("setLayerWidth", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setOpacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOpacity(int arg0)
        {
            IExecuteWithSignature("setOpacity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setPadding(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetPadding(int arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setPadding", "(IIII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setPaddingMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPaddingMode(int arg0)
        {
            IExecuteWithSignature("setPaddingMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#setPaddingRelative(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetPaddingRelative(int arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setPaddingRelative", "(IIII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/LayerDrawable.html#unscheduleDrawable(android.graphics.drawable.Drawable,java.lang.Runnable)"/>
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