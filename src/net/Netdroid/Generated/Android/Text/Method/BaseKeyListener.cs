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

namespace Android.Text.Method
{
    #region BaseKeyListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html"/>
    /// </summary>
    public partial class BaseKeyListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BaseKeyListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.android.text.method.BaseKeyListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region BaseKeyListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="BaseKeyListener"/> or its generic type if there is one
    /// </summary>
    public partial class BaseKeyListenerDirect : BaseKeyListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "android.text.method.BaseKeyListener";
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region BaseKeyListener implementation
    public partial class BaseKeyListener
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#isMetaTracker(java.lang.CharSequence,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static bool IsMetaTracker(Java.Lang.CharSequence arg0, object arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isMetaTracker", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#isSelectingMetaTracker(java.lang.CharSequence,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static bool IsSelectingMetaTracker(Java.Lang.CharSequence arg0, object arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isSelectingMetaTracker", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0, Android.View.KeyEvent arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(long arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(long arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#adjustMetaAfterKeypress(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long AdjustMetaAfterKeypress(long arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "adjustMetaAfterKeypress", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#handleKeyDown(long,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long HandleKeyDown(long arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "handleKeyDown", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#handleKeyUp(long,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long HandleKeyUp(long arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "handleKeyUp", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#resetLockedMeta(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long ResetLockedMeta(long arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "resetLockedMeta", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#adjustMetaAfterKeypress(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void AdjustMetaAfterKeypress(Android.Text.Spannable arg0)
        {
            SExecute(LocalBridgeClazz, "adjustMetaAfterKeypress", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void ClearMetaKeyState(Android.Text.Editable arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "clearMetaKeyState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#resetMetaState(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void ResetMetaState(Android.Text.Spannable arg0)
        {
            SExecute(LocalBridgeClazz, "resetMetaState", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="BaseKeyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getInputType", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetInputTypeEventHandler));
            AddEventHandler("backspace", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(BackspaceEventHandler));
            AddEventHandler("forwardDelete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ForwardDeleteEventHandler));
            AddEventHandler("onKeyOther", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnKeyOtherEventHandler));
            AddEventHandler("onKeyUp", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnKeyUpEventHandler));
            AddEventHandler("clearMetaKeyState", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ClearMetaKeyStateEventHandler));
            AddEventHandler("clearMetaKeyState3", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ClearMetaKeyState3EventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#getInputType()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetInputType"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int> OnGetInputType { get; set; } = null;

        bool hasOverrideGetInputType = true;
        void GetInputTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetInputType = true;
            var methodToExecute = (OnGetInputType != null) ? OnGetInputType : GetInputType;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetInputType, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#getInputType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetInputType()
        {
            hasOverrideGetInputType = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#backspace(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnBackspace"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnBackspace { get; set; } = null;

        bool hasOverrideBackspace = true;
        void BackspaceEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideBackspace = true;
            var methodToExecute = (OnBackspace != null) ? OnBackspace : Backspace;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.View.View>(0), data.EventData.GetAt<Android.Text.Editable>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<Android.View.KeyEvent>(3));
            data.EventData.TypedEventData.SetReturnData(hasOverrideBackspace, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#backspace(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Backspace(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            hasOverrideBackspace = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#forwardDelete(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnForwardDelete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnForwardDelete { get; set; } = null;

        bool hasOverrideForwardDelete = true;
        void ForwardDeleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideForwardDelete = true;
            var methodToExecute = (OnForwardDelete != null) ? OnForwardDelete : ForwardDelete;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.View.View>(0), data.EventData.GetAt<Android.Text.Editable>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<Android.View.KeyEvent>(3));
            data.EventData.TypedEventData.SetReturnData(hasOverrideForwardDelete, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#forwardDelete(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool ForwardDelete(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            hasOverrideForwardDelete = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#onKeyOther(android.view.View,android.text.Editable,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnKeyOther"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, Android.View.KeyEvent, bool> OnOnKeyOther { get; set; } = null;

        bool hasOverrideOnKeyOther = true;
        void OnKeyOtherEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnKeyOther = true;
            var methodToExecute = (OnOnKeyOther != null) ? OnOnKeyOther : OnKeyOther;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.View.View>(0), data.EventData.GetAt<Android.Text.Editable>(1), data.EventData.GetAt<Android.View.KeyEvent>(2));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOnKeyOther, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#onKeyOther(android.view.View,android.text.Editable,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool OnKeyOther(Android.View.View arg0, Android.Text.Editable arg1, Android.View.KeyEvent arg2)
        {
            hasOverrideOnKeyOther = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnKeyUp"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnOnKeyUp { get; set; } = null;

        bool hasOverrideOnKeyUp = true;
        void OnKeyUpEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnKeyUp = true;
            var methodToExecute = (OnOnKeyUp != null) ? OnOnKeyUp : OnKeyUp;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.View.View>(0), data.EventData.GetAt<Android.Text.Editable>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<Android.View.KeyEvent>(3));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOnKeyUp, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool OnKeyUp(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            hasOverrideOnKeyUp = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnClearMetaKeyState"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<long, int, long> OnClearMetaKeyState { get; set; } = null;

        bool hasOverrideClearMetaKeyState = true;
        void ClearMetaKeyStateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClearMetaKeyState = true;
            var methodToExecute = (OnClearMetaKeyState != null) ? OnClearMetaKeyState : ClearMetaKeyState;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<long>(0), data.EventData.GetAt<int>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideClearMetaKeyState, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ClearMetaKeyState(long arg0, int arg1)
        {
            hasOverrideClearMetaKeyState = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnClearMetaKeyState3"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.View.View, Android.Text.Editable, int> OnClearMetaKeyState3 { get; set; } = null;

        bool hasOverrideClearMetaKeyState3 = true;
        void ClearMetaKeyState3EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClearMetaKeyState3 = true;
            var methodToExecute = (OnClearMetaKeyState3 != null) ? OnClearMetaKeyState3 : ClearMetaKeyState;
            methodToExecute.Invoke(data.EventData.GetAt<Android.View.View>(0), data.EventData.GetAt<Android.Text.Editable>(1), data.EventData.GetAt<int>(2));
            data.EventData.TypedEventData.HasOverride = hasOverrideClearMetaKeyState3;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public virtual void ClearMetaKeyState(Android.View.View arg0, Android.Text.Editable arg1, int arg2)
        {
            hasOverrideClearMetaKeyState3 = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BaseKeyListenerDirect implementation
    public partial class BaseKeyListenerDirect
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
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#getInputType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public override int GetInputType()
        {
            return IExecute<int>("getInputType");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#backspace(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Backspace(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("backspace", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#forwardDelete(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool ForwardDelete(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("forwardDelete", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#onKeyOther(android.view.View,android.text.Editable,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool OnKeyOther(Android.View.View arg0, Android.Text.Editable arg1, Android.View.KeyEvent arg2)
        {
            return IExecute<bool>("onKeyOther", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool OnKeyUp(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("onKeyUp", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ClearMetaKeyState(long arg0, int arg1)
        {
            return IExecute<long>("clearMetaKeyState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public override void ClearMetaKeyState(Android.View.View arg0, Android.Text.Editable arg1, int arg2)
        {
            IExecute("clearMetaKeyState", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}