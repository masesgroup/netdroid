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

namespace Android.App.Admin
{
    #region DevicePolicyResourcesManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html"/>
    /// </summary>
    public partial class DevicePolicyResourcesManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DevicePolicyResourcesManager>
    {
        const string _bridgeClassName = "android.app.admin.DevicePolicyResourcesManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DevicePolicyResourcesManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DevicePolicyResourcesManager(params object[] args) : base(args) { }
    
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

    #region DevicePolicyResourcesManager implementation
    public partial class DevicePolicyResourcesManager
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
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getDrawable(java.lang.String,java.lang.String,java.lang.String,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawable(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Function.Supplier<Android.Graphics.Drawable.Drawable> arg3)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getDrawable", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getDrawable(java.lang.String,java.lang.String,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawable(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.Function.Supplier<Android.Graphics.Drawable.Drawable> arg2)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getDrawable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getDrawableForDensity(java.lang.String,java.lang.String,int,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawableForDensity(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, Java.Util.Function.Supplier<Android.Graphics.Drawable.Drawable> arg3)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getDrawableForDensity", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getDrawableForDensity(java.lang.String,java.lang.String,java.lang.String,int,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDrawableForDensity(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, int arg3, Java.Util.Function.Supplier<Android.Graphics.Drawable.Drawable> arg4)
        {
            return IExecute<Android.Graphics.Drawable.Drawable>("getDrawableForDensity", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getDrawableAsIcon(java.lang.String,java.lang.String,android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Drawable.Icon"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetDrawableAsIcon(Java.Lang.String arg0, Java.Lang.String arg1, Android.Graphics.Drawable.Icon arg2)
        {
            return IExecute<Android.Graphics.Drawable.Icon>("getDrawableAsIcon", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getDrawableAsIcon(java.lang.String,java.lang.String,java.lang.String,android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Drawable.Icon"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetDrawableAsIcon(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Graphics.Drawable.Icon arg3)
        {
            return IExecute<Android.Graphics.Drawable.Icon>("getDrawableAsIcon", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getString(java.lang.String,java.util.function.Supplier,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0, Java.Util.Function.Supplier<Java.Lang.String> arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Lang.String>("getString", arg0, arg1); else return IExecute<Java.Lang.String>("getString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DevicePolicyResourcesManager.html#getString(java.lang.String,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0, Java.Util.Function.Supplier<Java.Lang.String> arg1)
        {
            return IExecute<Java.Lang.String>("getString", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}