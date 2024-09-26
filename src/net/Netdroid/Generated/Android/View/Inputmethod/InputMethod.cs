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

namespace Android.View.Inputmethod
{
    #region InputMethod declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html"/>
    /// </summary>
    public partial class InputMethod : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InputMethod>
    {
        const string _bridgeClassName = "android.view.inputmethod.InputMethod";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InputMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethod() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InputMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethod(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region SessionCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.SessionCallback.html"/>
        /// </summary>
        public partial class SessionCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SessionCallback>
        {
            const string _bridgeClassName = "android.view.inputmethod.InputMethod$SessionCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("SessionCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public SessionCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("SessionCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public SessionCallback(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region IInputMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethod
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethod implementation
    public partial class InputMethod : Android.View.Inputmethod.IInputMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#SHOW_EXPLICIT"/>
        /// </summary>
        public static int SHOW_EXPLICIT { get { if (!_SHOW_EXPLICITReady) { _SHOW_EXPLICITContent = SGetField<int>(LocalBridgeClazz, "SHOW_EXPLICIT"); _SHOW_EXPLICITReady = true; } return _SHOW_EXPLICITContent; } }
        private static int _SHOW_EXPLICITContent = default;
        private static bool _SHOW_EXPLICITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#SHOW_FORCED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SHOW_FORCED { get { if (!_SHOW_FORCEDReady) { _SHOW_FORCEDContent = SGetField<int>(LocalBridgeClazz, "SHOW_FORCED"); _SHOW_FORCEDReady = true; } return _SHOW_FORCEDContent; } }
        private static int _SHOW_FORCEDContent = default;
        private static bool _SHOW_FORCEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#attachToken(android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
        public void AttachToken(Android.Os.IBinder arg0)
        {
            IExecuteWithSignature("attachToken", "(Landroid/os/IBinder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#bindInput(android.view.inputmethod.InputBinding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputBinding"/></param>
        public void BindInput(Android.View.Inputmethod.InputBinding arg0)
        {
            IExecuteWithSignature("bindInput", "(Landroid/view/inputmethod/InputBinding;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#changeInputMethodSubtype(android.view.inputmethod.InputMethodSubtype)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethodSubtype"/></param>
        public void ChangeInputMethodSubtype(Android.View.Inputmethod.InputMethodSubtype arg0)
        {
            IExecuteWithSignature("changeInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#createSession(android.view.inputmethod.InputMethod.SessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethod.SessionCallback"/></param>
        public void CreateSession(Android.View.Inputmethod.InputMethod.SessionCallback arg0)
        {
            IExecuteWithSignature("createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#hideSoftInput(int,android.os.ResultReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.ResultReceiver"/></param>
        public void HideSoftInput(int arg0, Android.Os.ResultReceiver arg1)
        {
            IExecuteWithSignature("hideSoftInput", "(ILandroid/os/ResultReceiver;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#restartInput(android.view.inputmethod.InputConnection,android.view.inputmethod.EditorInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputConnection"/></param>
        /// <param name="arg1"><see cref="Android.View.Inputmethod.EditorInfo"/></param>
        public void RestartInput(Android.View.Inputmethod.InputConnection arg0, Android.View.Inputmethod.EditorInfo arg1)
        {
            IExecuteWithSignature("restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#revokeSession(android.view.inputmethod.InputMethodSession)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethodSession"/></param>
        public void RevokeSession(Android.View.Inputmethod.InputMethodSession arg0)
        {
            IExecuteWithSignature("revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#setSessionEnabled(android.view.inputmethod.InputMethodSession,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethodSession"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetSessionEnabled(Android.View.Inputmethod.InputMethodSession arg0, bool arg1)
        {
            IExecuteWithSignature("setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#showSoftInput(int,android.os.ResultReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.ResultReceiver"/></param>
        public void ShowSoftInput(int arg0, Android.Os.ResultReceiver arg1)
        {
            IExecuteWithSignature("showSoftInput", "(ILandroid/os/ResultReceiver;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#startInput(android.view.inputmethod.InputConnection,android.view.inputmethod.EditorInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.InputConnection"/></param>
        /// <param name="arg1"><see cref="Android.View.Inputmethod.EditorInfo"/></param>
        public void StartInput(Android.View.Inputmethod.InputConnection arg0, Android.View.Inputmethod.EditorInfo arg1)
        {
            IExecuteWithSignature("startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.html#unbindInput()"/>
        /// </summary>
        public void UnbindInput()
        {
            IExecuteWithSignature("unbindInput", "()V");
        }

        #endregion

        #region Nested classes
        #region SessionCallback implementation
        public partial class SessionCallback
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethod.SessionCallback.html#sessionCreated(android.view.inputmethod.InputMethodSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Inputmethod.InputMethodSession"/></param>
            public void SessionCreated(Android.View.Inputmethod.InputMethodSession arg0)
            {
                IExecuteWithSignature("sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V", arg0);
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