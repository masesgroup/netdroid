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

namespace Android.Service.Wallpaper
{
    #region WallpaperService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.html"/>
    /// </summary>
    public partial class WallpaperService : Android.App.Service
    {
        const string _bridgeClassName = "android.service.wallpaper.WallpaperService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("WallpaperService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WallpaperService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("WallpaperService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WallpaperService(params object[] args) : base(args) { }
    
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
        #region Engine declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html"/>
        /// </summary>
        public partial class Engine : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Engine>
        {
            const string _bridgeClassName = "android.service.wallpaper.WallpaperService$Engine";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Engine() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Engine(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region WallpaperService implementation
    public partial class WallpaperService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.html#onCreateEngine()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Wallpaper.WallpaperService.Engine"/></returns>
        public Android.Service.Wallpaper.WallpaperService.Engine OnCreateEngine()
        {
            return IExecuteWithSignature<Android.Service.Wallpaper.WallpaperService.Engine>("onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;");
        }
    
        #endregion
    
        #region Nested classes
        #region Engine implementation
        public partial class Engine
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#%3Cinit%3E(android.service.wallpaper.WallpaperService)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Wallpaper.WallpaperService"/></param>
            public Engine(Android.Service.Wallpaper.WallpaperService arg0)
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
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onComputeColors()"/>
            /// </summary>
            /// <returns><see cref="Android.App.WallpaperColors"/></returns>
            public Android.App.WallpaperColors OnComputeColors()
            {
                return IExecuteWithSignature<Android.App.WallpaperColors>("onComputeColors", "()Landroid/app/WallpaperColors;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#getDisplayContext()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.Context"/></returns>
            public Android.Content.Context GetDisplayContext()
            {
                return IExecuteWithSignature<Android.Content.Context>("getDisplayContext", "()Landroid/content/Context;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onCommand(java.lang.String,int,int,int,android.os.Bundle,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Android.Os.Bundle"/></param>
            /// <param name="arg5"><see cref="bool"/></param>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle OnCommand(Java.Lang.String arg0, int arg1, int arg2, int arg3, Android.Os.Bundle arg4, bool arg5)
            {
                return IExecuteWithSignature<Android.Os.Bundle>("onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#getSurfaceHolder()"/>
            /// </summary>
            /// <returns><see cref="Android.View.SurfaceHolder"/></returns>
            public Android.View.SurfaceHolder GetSurfaceHolder()
            {
                return IExecuteWithSignature<Android.View.SurfaceHolder>("getSurfaceHolder", "()Landroid/view/SurfaceHolder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#isPreview()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsPreview()
            {
                return IExecuteWithSignature<bool>("isPreview", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#isVisible()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsVisible()
            {
                return IExecuteWithSignature<bool>("isVisible", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#getDesiredMinimumHeight()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetDesiredMinimumHeight()
            {
                return IExecuteWithSignature<int>("getDesiredMinimumHeight", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#getDesiredMinimumWidth()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetDesiredMinimumWidth()
            {
                return IExecuteWithSignature<int>("getDesiredMinimumWidth", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#getWallpaperFlags()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetWallpaperFlags()
            {
                return IExecuteWithSignature<int>("getWallpaperFlags", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#notifyColorsChanged()"/>
            /// </summary>
            public void NotifyColorsChanged()
            {
                IExecuteWithSignature("notifyColorsChanged", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onApplyWindowInsets(android.view.WindowInsets)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.WindowInsets"/></param>
            public void OnApplyWindowInsets(Android.View.WindowInsets arg0)
            {
                IExecuteWithSignature("onApplyWindowInsets", "(Landroid/view/WindowInsets;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onCreate(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void OnCreate(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("onCreate", "(Landroid/view/SurfaceHolder;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onDesiredSizeChanged(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnDesiredSizeChanged(int arg0, int arg1)
            {
                IExecuteWithSignature("onDesiredSizeChanged", "(II)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onDestroy()"/>
            /// </summary>
            public void OnDestroy()
            {
                IExecuteWithSignature("onDestroy", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onOffsetsChanged(float,float,float,float,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="int"/></param>
            public void OnOffsetsChanged(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5)
            {
                IExecuteWithSignature("onOffsetsChanged", "(FFFFII)V", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onSurfaceChanged(android.view.SurfaceHolder,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public void OnSurfaceChanged(Android.View.SurfaceHolder arg0, int arg1, int arg2, int arg3)
            {
                IExecuteWithSignature("onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onSurfaceCreated(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void OnSurfaceCreated(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onSurfaceDestroyed(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void OnSurfaceDestroyed(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onSurfaceRedrawNeeded(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void OnSurfaceRedrawNeeded(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("onSurfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onTouchEvent(android.view.MotionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
            public void OnTouchEvent(Android.View.MotionEvent arg0)
            {
                IExecuteWithSignature("onTouchEvent", "(Landroid/view/MotionEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void OnVisibilityChanged(bool arg0)
            {
                IExecuteWithSignature("onVisibilityChanged", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onWallpaperFlagsChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnWallpaperFlagsChanged(int arg0)
            {
                IExecuteWithSignature("onWallpaperFlagsChanged", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#onZoomChanged(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void OnZoomChanged(float arg0)
            {
                IExecuteWithSignature("onZoomChanged", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#setOffsetNotificationsEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetOffsetNotificationsEnabled(bool arg0)
            {
                IExecuteWithSignature("setOffsetNotificationsEnabled", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/wallpaper/WallpaperService.Engine.html#setTouchEventsEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetTouchEventsEnabled(bool arg0)
            {
                IExecuteWithSignature("setTouchEventsEnabled", "(Z)V", arg0);
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