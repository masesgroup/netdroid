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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Method
{
    #region IKeyListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.text.method.KeyListener implementing <see href="https://developer.android.com/reference/android/text/method/KeyListener.html"/>
    /// </summary>
    public partial interface IKeyListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyListener
    public partial class KeyListener : Android.Text.Method.IKeyListener
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
        /// Handlers initializer for <see cref="KeyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onKeyDown", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(OnKeyDownEventHandler));
            AddEventHandler("onKeyOther", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(OnKeyOtherEventHandler));
            AddEventHandler("onKeyUp", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(OnKeyUpEventHandler));
            AddEventHandler("getInputType", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetInputTypeEventHandler));
            AddEventHandler("clearMetaKeyState", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(ClearMetaKeyStateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyDown(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnKeyDown"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnOnKeyDown { get; set; } = null;

        void OnKeyDownEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnOnKeyDown != null) ? OnOnKeyDown : OnKeyDown;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<Android.View.KeyEvent>(2));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyDown(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool OnKeyDown(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyOther(android.view.View,android.text.Editable,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnKeyOther"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, Android.View.KeyEvent, bool> OnOnKeyOther { get; set; } = null;

        void OnKeyOtherEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnOnKeyOther != null) ? OnOnKeyOther : OnKeyOther;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<Android.View.KeyEvent>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyOther(android.view.View,android.text.Editable,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool OnKeyOther(Android.View.View arg0, Android.Text.Editable arg1, Android.View.KeyEvent arg2)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnKeyUp"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnOnKeyUp { get; set; } = null;

        void OnKeyUpEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnOnKeyUp != null) ? OnOnKeyUp : OnKeyUp;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<Android.View.KeyEvent>(2));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool OnKeyUp(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#getInputType()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetInputType"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int> OnGetInputType { get; set; } = null;

        void GetInputTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetInputType != null) ? OnGetInputType : GetInputType;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#getInputType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetInputType()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnClearMetaKeyState"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.View.View, Android.Text.Editable, int> OnClearMetaKeyState { get; set; } = null;

        void ClearMetaKeyStateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnClearMetaKeyState != null) ? OnClearMetaKeyState : ClearMetaKeyState;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public virtual void ClearMetaKeyState(Android.View.View arg0, Android.Text.Editable arg1, int arg2)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyListenerDirect
    public partial class KeyListenerDirect : Android.Text.Method.IKeyListener
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
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyDown(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool OnKeyDown(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("onKeyDown", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyOther(android.view.View,android.text.Editable,android.view.KeyEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#onKeyUp(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#getInputType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public override int GetInputType()
        {
            return IExecuteWithSignature<int>("getInputType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/KeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
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