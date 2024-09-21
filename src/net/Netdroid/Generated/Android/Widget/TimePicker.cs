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

namespace Android.Widget
{
    #region TimePicker declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html"/>
    /// </summary>
    public partial class TimePicker : Android.Widget.FrameLayout
    {
        const string _bridgeClassName = "android.widget.TimePicker";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimePicker() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimePicker(params object[] args) : base(args) { }

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
        #region OnTimeChangedListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.OnTimeChangedListener.html"/>
        /// </summary>
        public partial class OnTimeChangedListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnTimeChangedListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.TimePicker_OnTimeChangedListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnTimeChangedListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnTimeChangedListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnTimeChangedListenerDirect : OnTimeChangedListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.widget.TimePicker$OnTimeChangedListener";
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

    #region TimePicker implementation
    public partial class TimePicker
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TimePicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TimePicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public TimePicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public TimePicker(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#is24HourView()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is24HourView()
        {
            return IExecuteWithSignature<bool>("is24HourView", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#validateInput()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ValidateInput()
        {
            return IExecuteWithSignature<bool>("validateInput", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#getHour()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHour()
        {
            return IExecuteWithSignature<int>("getHour", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#getMinute()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinute()
        {
            return IExecuteWithSignature<int>("getMinute", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#getCurrentHour()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.Integer GetCurrentHour()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getCurrentHour", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#getCurrentMinute()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.Integer GetCurrentMinute()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getCurrentMinute", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#setCurrentHour(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        [global::System.Obsolete()]
        public void SetCurrentHour(Java.Lang.Integer arg0)
        {
            IExecuteWithSignature("setCurrentHour", "(Ljava/lang/Integer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#setCurrentMinute(java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        [global::System.Obsolete()]
        public void SetCurrentMinute(Java.Lang.Integer arg0)
        {
            IExecuteWithSignature("setCurrentMinute", "(Ljava/lang/Integer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#setHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHour(int arg0)
        {
            IExecuteWithSignature("setHour", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#setIs24HourView(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void SetIs24HourView(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("setIs24HourView", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#setMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMinute(int arg0)
        {
            IExecuteWithSignature("setMinute", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TimePicker.html#setOnTimeChangedListener(android.widget.TimePicker.OnTimeChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TimePicker.OnTimeChangedListener"/></param>
        public void SetOnTimeChangedListener(Android.Widget.TimePicker.OnTimeChangedListener arg0)
        {
            IExecuteWithSignature("setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnTimeChangedListener implementation
        public partial class OnTimeChangedListener
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
            /// Handlers initializer for <see cref="OnTimeChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onTimeChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTimeChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/TimePicker.OnTimeChangedListener.html#onTimeChanged(android.widget.TimePicker,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnTimeChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.TimePicker, int, int> OnOnTimeChanged { get; set; } = null;

            bool hasOverrideOnTimeChanged = true;
            void OnTimeChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnTimeChanged = true;
                var methodToExecute = (OnOnTimeChanged != null) ? OnOnTimeChanged : OnTimeChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.TimePicker>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnTimeChanged;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TimePicker.OnTimeChangedListener.html#onTimeChanged(android.widget.TimePicker,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.TimePicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnTimeChanged(Android.Widget.TimePicker arg0, int arg1, int arg2)
            {
                hasOverrideOnTimeChanged = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnTimeChangedListenerDirect implementation
        public partial class OnTimeChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/TimePicker.OnTimeChangedListener.html#onTimeChanged(android.widget.TimePicker,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.TimePicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnTimeChanged(Android.Widget.TimePicker arg0, int arg1, int arg2)
            {
                IExecute("onTimeChanged", arg0, arg1, arg2);
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