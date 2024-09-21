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

namespace Android.App
{
    #region UiAutomation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html"/>
    /// </summary>
    public partial class UiAutomation : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UiAutomation>
    {
        const string _bridgeClassName = "android.app.UiAutomation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UiAutomation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UiAutomation(params object[] args) : base(args) { }

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
        #region AccessibilityEventFilter declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.AccessibilityEventFilter.html"/>
        /// </summary>
        public partial class AccessibilityEventFilter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AccessibilityEventFilter>
        {
            const string _bridgeClassName = "android.app.UiAutomation$AccessibilityEventFilter";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("AccessibilityEventFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public AccessibilityEventFilter() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("AccessibilityEventFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public AccessibilityEventFilter(params object[] args) : base(args) { }

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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region OnAccessibilityEventListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.OnAccessibilityEventListener.html"/>
        /// </summary>
        public partial class OnAccessibilityEventListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnAccessibilityEventListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.app.UiAutomation_OnAccessibilityEventListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnAccessibilityEventListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnAccessibilityEventListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnAccessibilityEventListenerDirect : OnAccessibilityEventListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.app.UiAutomation$OnAccessibilityEventListener";
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

    #region UiAutomation implementation
    public partial class UiAutomation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICES"/>
        /// </summary>
        public static int FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICES { get { if (!_FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICESReady) { _FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICESContent = SGetField<int>(LocalBridgeClazz, "FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICES"); _FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICESReady = true; } return _FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICESContent; } }
        private static int _FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICESContent = default;
        private static bool _FLAG_DONT_SUPPRESS_ACCESSIBILITY_SERVICESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#FLAG_DONT_USE_ACCESSIBILITY"/>
        /// </summary>
        public static int FLAG_DONT_USE_ACCESSIBILITY { get { if (!_FLAG_DONT_USE_ACCESSIBILITYReady) { _FLAG_DONT_USE_ACCESSIBILITYContent = SGetField<int>(LocalBridgeClazz, "FLAG_DONT_USE_ACCESSIBILITY"); _FLAG_DONT_USE_ACCESSIBILITYReady = true; } return _FLAG_DONT_USE_ACCESSIBILITYContent; } }
        private static int _FLAG_DONT_USE_ACCESSIBILITYContent = default;
        private static bool _FLAG_DONT_USE_ACCESSIBILITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#ROTATION_FREEZE_0"/>
        /// </summary>
        public static int ROTATION_FREEZE_0 { get { if (!_ROTATION_FREEZE_0Ready) { _ROTATION_FREEZE_0Content = SGetField<int>(LocalBridgeClazz, "ROTATION_FREEZE_0"); _ROTATION_FREEZE_0Ready = true; } return _ROTATION_FREEZE_0Content; } }
        private static int _ROTATION_FREEZE_0Content = default;
        private static bool _ROTATION_FREEZE_0Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#ROTATION_FREEZE_180"/>
        /// </summary>
        public static int ROTATION_FREEZE_180 { get { if (!_ROTATION_FREEZE_180Ready) { _ROTATION_FREEZE_180Content = SGetField<int>(LocalBridgeClazz, "ROTATION_FREEZE_180"); _ROTATION_FREEZE_180Ready = true; } return _ROTATION_FREEZE_180Content; } }
        private static int _ROTATION_FREEZE_180Content = default;
        private static bool _ROTATION_FREEZE_180Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#ROTATION_FREEZE_270"/>
        /// </summary>
        public static int ROTATION_FREEZE_270 { get { if (!_ROTATION_FREEZE_270Ready) { _ROTATION_FREEZE_270Content = SGetField<int>(LocalBridgeClazz, "ROTATION_FREEZE_270"); _ROTATION_FREEZE_270Ready = true; } return _ROTATION_FREEZE_270Content; } }
        private static int _ROTATION_FREEZE_270Content = default;
        private static bool _ROTATION_FREEZE_270Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#ROTATION_FREEZE_90"/>
        /// </summary>
        public static int ROTATION_FREEZE_90 { get { if (!_ROTATION_FREEZE_90Ready) { _ROTATION_FREEZE_90Content = SGetField<int>(LocalBridgeClazz, "ROTATION_FREEZE_90"); _ROTATION_FREEZE_90Ready = true; } return _ROTATION_FREEZE_90Content; } }
        private static int _ROTATION_FREEZE_90Content = default;
        private static bool _ROTATION_FREEZE_90Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#ROTATION_FREEZE_CURRENT"/>
        /// </summary>
        public static int ROTATION_FREEZE_CURRENT { get { if (!_ROTATION_FREEZE_CURRENTReady) { _ROTATION_FREEZE_CURRENTContent = SGetField<int>(LocalBridgeClazz, "ROTATION_FREEZE_CURRENT"); _ROTATION_FREEZE_CURRENTReady = true; } return _ROTATION_FREEZE_CURRENTContent; } }
        private static int _ROTATION_FREEZE_CURRENTContent = default;
        private static bool _ROTATION_FREEZE_CURRENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#ROTATION_UNFREEZE"/>
        /// </summary>
        public static int ROTATION_UNFREEZE { get { if (!_ROTATION_UNFREEZEReady) { _ROTATION_UNFREEZEContent = SGetField<int>(LocalBridgeClazz, "ROTATION_UNFREEZE"); _ROTATION_UNFREEZEReady = true; } return _ROTATION_UNFREEZEContent; } }
        private static int _ROTATION_UNFREEZEContent = default;
        private static bool _ROTATION_UNFREEZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#getServiceInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Accessibilityservice.AccessibilityServiceInfo"/></returns>
        public Android.Accessibilityservice.AccessibilityServiceInfo GetServiceInfo()
        {
            return IExecuteWithSignature<Android.Accessibilityservice.AccessibilityServiceInfo>("getServiceInfo", "()Landroid/accessibilityservice/AccessibilityServiceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#takeScreenshot()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap TakeScreenshot()
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("takeScreenshot", "()Landroid/graphics/Bitmap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#takeScreenshot(android.view.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Window"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap TakeScreenshot(Android.View.Window arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("takeScreenshot", "(Landroid/view/Window;)Landroid/graphics/Bitmap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#executeShellCommand(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor ExecuteShellCommand(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("executeShellCommand", "(Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#executeShellCommandRw(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor[] ExecuteShellCommandRw(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Android.Os.ParcelFileDescriptor>("executeShellCommandRw", "(Ljava/lang/String;)[Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#executeShellCommandRwe(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor[] ExecuteShellCommandRwe(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Android.Os.ParcelFileDescriptor>("executeShellCommandRwe", "(Ljava/lang/String;)[Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#getWindowsOnAllDisplays()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<Java.Util.List<Android.View.Accessibility.AccessibilityWindowInfo>> GetWindowsOnAllDisplays()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<Java.Util.List<Android.View.Accessibility.AccessibilityWindowInfo>>>("getWindowsOnAllDisplays", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#executeAndWaitForEvent(java.lang.Runnable,android.app.UiAutomation.AccessibilityEventFilter,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="Android.App.UiAutomation.AccessibilityEventFilter"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityEvent"/></returns>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public Android.View.Accessibility.AccessibilityEvent ExecuteAndWaitForEvent(Java.Lang.Runnable arg0, Android.App.UiAutomation.AccessibilityEventFilter arg1, long arg2)
        {
            return IExecute<Android.View.Accessibility.AccessibilityEvent>("executeAndWaitForEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#findFocus(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo FindFocus(int arg0)
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("findFocus", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#getRootInActiveWindow()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo GetRootInActiveWindow()
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo>("getRootInActiveWindow", "()Landroid/view/accessibility/AccessibilityNodeInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#getWindowAnimationFrameStats()"/>
        /// </summary>
        /// <returns><see cref="Android.View.WindowAnimationFrameStats"/></returns>
        [global::System.Obsolete()]
        public Android.View.WindowAnimationFrameStats GetWindowAnimationFrameStats()
        {
            return IExecuteWithSignature<Android.View.WindowAnimationFrameStats>("getWindowAnimationFrameStats", "()Landroid/view/WindowAnimationFrameStats;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#getWindowContentFrameStats(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.WindowContentFrameStats"/></returns>
        public Android.View.WindowContentFrameStats GetWindowContentFrameStats(int arg0)
        {
            return IExecuteWithSignature<Android.View.WindowContentFrameStats>("getWindowContentFrameStats", "(I)Landroid/view/WindowContentFrameStats;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#clearCache()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ClearCache()
        {
            return IExecuteWithSignature<bool>("clearCache", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#clearWindowContentFrameStats(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ClearWindowContentFrameStats(int arg0)
        {
            return IExecuteWithSignature<bool>("clearWindowContentFrameStats", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#injectInputEvent(android.view.InputEvent,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.InputEvent"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool InjectInputEvent(Android.View.InputEvent arg0, bool arg1)
        {
            return IExecute<bool>("injectInputEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#performGlobalAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PerformGlobalAction(int arg0)
        {
            return IExecuteWithSignature<bool>("performGlobalAction", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#setRotation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRotation(int arg0)
        {
            return IExecuteWithSignature<bool>("setRotation", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#getWindows()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.Accessibility.AccessibilityWindowInfo> GetWindows()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.Accessibility.AccessibilityWindowInfo>>("getWindows", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#adoptShellPermissionIdentity()"/>
        /// </summary>
        public void AdoptShellPermissionIdentity()
        {
            IExecuteWithSignature("adoptShellPermissionIdentity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#adoptShellPermissionIdentity(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AdoptShellPermissionIdentity(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("adoptShellPermissionIdentity", "([Ljava/lang/String;)V"); else IExecuteWithSignature("adoptShellPermissionIdentity", "([Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#clearWindowAnimationFrameStats()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void ClearWindowAnimationFrameStats()
        {
            IExecuteWithSignature("clearWindowAnimationFrameStats", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#dropShellPermissionIdentity()"/>
        /// </summary>
        public void DropShellPermissionIdentity()
        {
            IExecuteWithSignature("dropShellPermissionIdentity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#grantRuntimePermission(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void GrantRuntimePermission(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("grantRuntimePermission", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#grantRuntimePermissionAsUser(java.lang.String,java.lang.String,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.UserHandle"/></param>
        public void GrantRuntimePermissionAsUser(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.UserHandle arg2)
        {
            IExecute("grantRuntimePermissionAsUser", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#revokeRuntimePermission(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void RevokeRuntimePermission(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("revokeRuntimePermission", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#revokeRuntimePermissionAsUser(java.lang.String,java.lang.String,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.UserHandle"/></param>
        public void RevokeRuntimePermissionAsUser(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.UserHandle arg2)
        {
            IExecute("revokeRuntimePermissionAsUser", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#setAnimationScale(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAnimationScale(float arg0)
        {
            IExecuteWithSignature("setAnimationScale", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#setOnAccessibilityEventListener(android.app.UiAutomation.OnAccessibilityEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.UiAutomation.OnAccessibilityEventListener"/></param>
        public void SetOnAccessibilityEventListener(Android.App.UiAutomation.OnAccessibilityEventListener arg0)
        {
            IExecuteWithSignature("setOnAccessibilityEventListener", "(Landroid/app/UiAutomation$OnAccessibilityEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#setRunAsMonkey(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRunAsMonkey(bool arg0)
        {
            IExecuteWithSignature("setRunAsMonkey", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#setServiceInfo(android.accessibilityservice.AccessibilityServiceInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.AccessibilityServiceInfo"/></param>
        public void SetServiceInfo(Android.Accessibilityservice.AccessibilityServiceInfo arg0)
        {
            IExecuteWithSignature("setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/UiAutomation.html#waitForIdle(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public void WaitForIdle(long arg0, long arg1)
        {
            IExecute("waitForIdle", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region AccessibilityEventFilter implementation
        public partial class AccessibilityEventFilter
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
            /// <see href="https://developer.android.com/reference/android/app/UiAutomation.AccessibilityEventFilter.html#accept(android.view.accessibility.AccessibilityEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Accept(Android.View.Accessibility.AccessibilityEvent arg0)
            {
                return IExecuteWithSignature<bool>("accept", "(Landroid/view/accessibility/AccessibilityEvent;)Z", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnAccessibilityEventListener implementation
        public partial class OnAccessibilityEventListener
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
            /// Handlers initializer for <see cref="OnAccessibilityEventListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAccessibilityEvent", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAccessibilityEventEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/UiAutomation.OnAccessibilityEventListener.html#onAccessibilityEvent(android.view.accessibility.AccessibilityEvent)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAccessibilityEvent"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Accessibility.AccessibilityEvent> OnOnAccessibilityEvent { get; set; } = null;

            bool hasOverrideOnAccessibilityEvent = true;
            void OnAccessibilityEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnAccessibilityEvent = true;
                var methodToExecute = (OnOnAccessibilityEvent != null) ? OnOnAccessibilityEvent : OnAccessibilityEvent;
                methodToExecute.Invoke(data.EventData.GetAt<Android.View.Accessibility.AccessibilityEvent>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnAccessibilityEvent;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/UiAutomation.OnAccessibilityEventListener.html#onAccessibilityEvent(android.view.accessibility.AccessibilityEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
            public virtual void OnAccessibilityEvent(Android.View.Accessibility.AccessibilityEvent arg0)
            {
                hasOverrideOnAccessibilityEvent = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnAccessibilityEventListenerDirect implementation
        public partial class OnAccessibilityEventListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/UiAutomation.OnAccessibilityEventListener.html#onAccessibilityEvent(android.view.accessibility.AccessibilityEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
            public override void OnAccessibilityEvent(Android.View.Accessibility.AccessibilityEvent arg0)
            {
                IExecuteWithSignature("onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", arg0);
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