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

namespace Android.Hardware.Display
{
    #region DisplayManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html"/>
    /// </summary>
    public partial class DisplayManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DisplayManager>
    {
        const string _bridgeClassName = "android.hardware.display.DisplayManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DisplayManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DisplayManager(params object[] args) : base(args) { }

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
        #region DisplayListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html"/>
        /// </summary>
        public partial class DisplayListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DisplayListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.hardware.display.DisplayManager_DisplayListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region DisplayListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="DisplayListener"/> or its generic type if there is one
        /// </summary>
        public partial class DisplayListenerDirect : DisplayListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.hardware.display.DisplayManager$DisplayListener";
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

    #region DisplayManager implementation
    public partial class DisplayManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#MATCH_CONTENT_FRAMERATE_ALWAYS"/>
        /// </summary>
        public static int MATCH_CONTENT_FRAMERATE_ALWAYS { get { if (!_MATCH_CONTENT_FRAMERATE_ALWAYSReady) { _MATCH_CONTENT_FRAMERATE_ALWAYSContent = SGetField<int>(LocalBridgeClazz, "MATCH_CONTENT_FRAMERATE_ALWAYS"); _MATCH_CONTENT_FRAMERATE_ALWAYSReady = true; } return _MATCH_CONTENT_FRAMERATE_ALWAYSContent; } }
        private static int _MATCH_CONTENT_FRAMERATE_ALWAYSContent = default;
        private static bool _MATCH_CONTENT_FRAMERATE_ALWAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#MATCH_CONTENT_FRAMERATE_NEVER"/>
        /// </summary>
        public static int MATCH_CONTENT_FRAMERATE_NEVER { get { if (!_MATCH_CONTENT_FRAMERATE_NEVERReady) { _MATCH_CONTENT_FRAMERATE_NEVERContent = SGetField<int>(LocalBridgeClazz, "MATCH_CONTENT_FRAMERATE_NEVER"); _MATCH_CONTENT_FRAMERATE_NEVERReady = true; } return _MATCH_CONTENT_FRAMERATE_NEVERContent; } }
        private static int _MATCH_CONTENT_FRAMERATE_NEVERContent = default;
        private static bool _MATCH_CONTENT_FRAMERATE_NEVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLY"/>
        /// </summary>
        public static int MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLY { get { if (!_MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLYReady) { _MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLYContent = SGetField<int>(LocalBridgeClazz, "MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLY"); _MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLYReady = true; } return _MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLYContent; } }
        private static int _MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLYContent = default;
        private static bool _MATCH_CONTENT_FRAMERATE_SEAMLESSS_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#MATCH_CONTENT_FRAMERATE_UNKNOWN"/>
        /// </summary>
        public static int MATCH_CONTENT_FRAMERATE_UNKNOWN { get { if (!_MATCH_CONTENT_FRAMERATE_UNKNOWNReady) { _MATCH_CONTENT_FRAMERATE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "MATCH_CONTENT_FRAMERATE_UNKNOWN"); _MATCH_CONTENT_FRAMERATE_UNKNOWNReady = true; } return _MATCH_CONTENT_FRAMERATE_UNKNOWNContent; } }
        private static int _MATCH_CONTENT_FRAMERATE_UNKNOWNContent = default;
        private static bool _MATCH_CONTENT_FRAMERATE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#VIRTUAL_DISPLAY_FLAG_AUTO_MIRROR"/>
        /// </summary>
        public static int VIRTUAL_DISPLAY_FLAG_AUTO_MIRROR { get { if (!_VIRTUAL_DISPLAY_FLAG_AUTO_MIRRORReady) { _VIRTUAL_DISPLAY_FLAG_AUTO_MIRRORContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_DISPLAY_FLAG_AUTO_MIRROR"); _VIRTUAL_DISPLAY_FLAG_AUTO_MIRRORReady = true; } return _VIRTUAL_DISPLAY_FLAG_AUTO_MIRRORContent; } }
        private static int _VIRTUAL_DISPLAY_FLAG_AUTO_MIRRORContent = default;
        private static bool _VIRTUAL_DISPLAY_FLAG_AUTO_MIRRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLY"/>
        /// </summary>
        public static int VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLY { get { if (!_VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLYReady) { _VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLYContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLY"); _VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLYReady = true; } return _VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLYContent; } }
        private static int _VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLYContent = default;
        private static bool _VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#VIRTUAL_DISPLAY_FLAG_PRESENTATION"/>
        /// </summary>
        public static int VIRTUAL_DISPLAY_FLAG_PRESENTATION { get { if (!_VIRTUAL_DISPLAY_FLAG_PRESENTATIONReady) { _VIRTUAL_DISPLAY_FLAG_PRESENTATIONContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_DISPLAY_FLAG_PRESENTATION"); _VIRTUAL_DISPLAY_FLAG_PRESENTATIONReady = true; } return _VIRTUAL_DISPLAY_FLAG_PRESENTATIONContent; } }
        private static int _VIRTUAL_DISPLAY_FLAG_PRESENTATIONContent = default;
        private static bool _VIRTUAL_DISPLAY_FLAG_PRESENTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#VIRTUAL_DISPLAY_FLAG_PUBLIC"/>
        /// </summary>
        public static int VIRTUAL_DISPLAY_FLAG_PUBLIC { get { if (!_VIRTUAL_DISPLAY_FLAG_PUBLICReady) { _VIRTUAL_DISPLAY_FLAG_PUBLICContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_DISPLAY_FLAG_PUBLIC"); _VIRTUAL_DISPLAY_FLAG_PUBLICReady = true; } return _VIRTUAL_DISPLAY_FLAG_PUBLICContent; } }
        private static int _VIRTUAL_DISPLAY_FLAG_PUBLICContent = default;
        private static bool _VIRTUAL_DISPLAY_FLAG_PUBLICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#VIRTUAL_DISPLAY_FLAG_SECURE"/>
        /// </summary>
        public static int VIRTUAL_DISPLAY_FLAG_SECURE { get { if (!_VIRTUAL_DISPLAY_FLAG_SECUREReady) { _VIRTUAL_DISPLAY_FLAG_SECUREContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_DISPLAY_FLAG_SECURE"); _VIRTUAL_DISPLAY_FLAG_SECUREReady = true; } return _VIRTUAL_DISPLAY_FLAG_SECUREContent; } }
        private static int _VIRTUAL_DISPLAY_FLAG_SECUREContent = default;
        private static bool _VIRTUAL_DISPLAY_FLAG_SECUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#DISPLAY_CATEGORY_PRESENTATION"/>
        /// </summary>
        public static Java.Lang.String DISPLAY_CATEGORY_PRESENTATION { get { if (!_DISPLAY_CATEGORY_PRESENTATIONReady) { _DISPLAY_CATEGORY_PRESENTATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISPLAY_CATEGORY_PRESENTATION"); _DISPLAY_CATEGORY_PRESENTATIONReady = true; } return _DISPLAY_CATEGORY_PRESENTATIONContent; } }
        private static Java.Lang.String _DISPLAY_CATEGORY_PRESENTATIONContent = default;
        private static bool _DISPLAY_CATEGORY_PRESENTATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#getHdrConversionMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Display.HdrConversionMode"/></returns>
        public Android.Hardware.Display.HdrConversionMode GetHdrConversionMode()
        {
            return IExecuteWithSignature<Android.Hardware.Display.HdrConversionMode>("getHdrConversionMode", "()Landroid/hardware/display/HdrConversionMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#createVirtualDisplay(android.hardware.display.VirtualDisplayConfig,android.os.Handler,android.hardware.display.VirtualDisplay.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Display.VirtualDisplayConfig"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Display.VirtualDisplay.Callback"/></param>
        /// <returns><see cref="Android.Hardware.Display.VirtualDisplay"/></returns>
        public Android.Hardware.Display.VirtualDisplay CreateVirtualDisplay(Android.Hardware.Display.VirtualDisplayConfig arg0, Android.Os.Handler arg1, Android.Hardware.Display.VirtualDisplay.Callback arg2)
        {
            return IExecuteWithSignature<Android.Hardware.Display.VirtualDisplay>("createVirtualDisplay", "(Landroid/hardware/display/VirtualDisplayConfig;Landroid/os/Handler;Landroid/hardware/display/VirtualDisplay$Callback;)Landroid/hardware/display/VirtualDisplay;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#createVirtualDisplay(android.hardware.display.VirtualDisplayConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Display.VirtualDisplayConfig"/></param>
        /// <returns><see cref="Android.Hardware.Display.VirtualDisplay"/></returns>
        public Android.Hardware.Display.VirtualDisplay CreateVirtualDisplay(Android.Hardware.Display.VirtualDisplayConfig arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Display.VirtualDisplay>("createVirtualDisplay", "(Landroid/hardware/display/VirtualDisplayConfig;)Landroid/hardware/display/VirtualDisplay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#createVirtualDisplay(java.lang.String,int,int,int,android.view.Surface,int,android.hardware.display.VirtualDisplay.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.View.Surface"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Android.Hardware.Display.VirtualDisplay.Callback"/></param>
        /// <param name="arg7"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="Android.Hardware.Display.VirtualDisplay"/></returns>
        public Android.Hardware.Display.VirtualDisplay CreateVirtualDisplay(Java.Lang.String arg0, int arg1, int arg2, int arg3, Android.View.Surface arg4, int arg5, Android.Hardware.Display.VirtualDisplay.Callback arg6, Android.Os.Handler arg7)
        {
            return IExecuteWithSignature<Android.Hardware.Display.VirtualDisplay>("createVirtualDisplay", "(Ljava/lang/String;IIILandroid/view/Surface;ILandroid/hardware/display/VirtualDisplay$Callback;Landroid/os/Handler;)Landroid/hardware/display/VirtualDisplay;", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#createVirtualDisplay(java.lang.String,int,int,int,android.view.Surface,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.View.Surface"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Display.VirtualDisplay"/></returns>
        public Android.Hardware.Display.VirtualDisplay CreateVirtualDisplay(Java.Lang.String arg0, int arg1, int arg2, int arg3, Android.View.Surface arg4, int arg5)
        {
            return IExecuteWithSignature<Android.Hardware.Display.VirtualDisplay>("createVirtualDisplay", "(Ljava/lang/String;IIILandroid/view/Surface;I)Landroid/hardware/display/VirtualDisplay;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#getDisplay(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Display"/></returns>
        public Android.View.Display GetDisplay(int arg0)
        {
            return IExecuteWithSignature<Android.View.Display>("getDisplay", "(I)Landroid/view/Display;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#getDisplays()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Display"/></returns>
        public Android.View.Display[] GetDisplays()
        {
            return IExecuteWithSignatureArray<Android.View.Display>("getDisplays", "()[Landroid/view/Display;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#getDisplays(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.View.Display"/></returns>
        public Android.View.Display[] GetDisplays(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Android.View.Display>("getDisplays", "(Ljava/lang/String;)[Landroid/view/Display;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#getMatchContentFrameRateUserPreference()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMatchContentFrameRateUserPreference()
        {
            return IExecuteWithSignature<int>("getMatchContentFrameRateUserPreference", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#registerDisplayListener(android.hardware.display.DisplayManager.DisplayListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Display.DisplayManager.DisplayListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterDisplayListener(Android.Hardware.Display.DisplayManager.DisplayListener arg0, Android.Os.Handler arg1)
        {
            IExecuteWithSignature("registerDisplayListener", "(Landroid/hardware/display/DisplayManager$DisplayListener;Landroid/os/Handler;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.html#unregisterDisplayListener(android.hardware.display.DisplayManager.DisplayListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Display.DisplayManager.DisplayListener"/></param>
        public void UnregisterDisplayListener(Android.Hardware.Display.DisplayManager.DisplayListener arg0)
        {
            IExecuteWithSignature("unregisterDisplayListener", "(Landroid/hardware/display/DisplayManager$DisplayListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region DisplayListener implementation
        public partial class DisplayListener
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
            /// Handlers initializer for <see cref="DisplayListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDisplayAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnDisplayAddedEventHandler));
                AddEventHandler("onDisplayChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnDisplayChangedEventHandler));
                AddEventHandler("onDisplayRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnDisplayRemovedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayAdded(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDisplayAdded"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnDisplayAdded { get; set; } = null;

            bool hasOverrideOnDisplayAdded = true;
            void OnDisplayAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnDisplayAdded = true;
                var methodToExecute = (OnOnDisplayAdded != null) ? OnOnDisplayAdded : OnDisplayAdded;
                methodToExecute.Invoke(data.EventData.GetAt<int>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnDisplayAdded;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayAdded(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnDisplayAdded(int arg0)
            {
                hasOverrideOnDisplayAdded = false;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayChanged(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDisplayChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnDisplayChanged { get; set; } = null;

            bool hasOverrideOnDisplayChanged = true;
            void OnDisplayChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnDisplayChanged = true;
                var methodToExecute = (OnOnDisplayChanged != null) ? OnOnDisplayChanged : OnDisplayChanged;
                methodToExecute.Invoke(data.EventData.GetAt<int>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnDisplayChanged;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnDisplayChanged(int arg0)
            {
                hasOverrideOnDisplayChanged = false;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayRemoved(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDisplayRemoved"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnDisplayRemoved { get; set; } = null;

            bool hasOverrideOnDisplayRemoved = true;
            void OnDisplayRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnDisplayRemoved = true;
                var methodToExecute = (OnOnDisplayRemoved != null) ? OnOnDisplayRemoved : OnDisplayRemoved;
                methodToExecute.Invoke(data.EventData.GetAt<int>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnDisplayRemoved;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayRemoved(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnDisplayRemoved(int arg0)
            {
                hasOverrideOnDisplayRemoved = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DisplayListenerDirect implementation
        public partial class DisplayListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayAdded(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnDisplayAdded(int arg0)
            {
                IExecuteWithSignature("onDisplayAdded", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnDisplayChanged(int arg0)
            {
                IExecuteWithSignature("onDisplayChanged", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/DisplayManager.DisplayListener.html#onDisplayRemoved(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnDisplayRemoved(int arg0)
            {
                IExecuteWithSignature("onDisplayRemoved", "(I)V", arg0);
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