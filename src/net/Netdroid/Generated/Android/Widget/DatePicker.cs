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

namespace Android.Widget
{
    #region DatePicker declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html"/>
    /// </summary>
    public partial class DatePicker : Android.Widget.FrameLayout
    {
        const string _bridgeClassName = "android.widget.DatePicker";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DatePicker() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DatePicker(params object[] args) : base(args) { }
    
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
        #region OnDateChangedListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.OnDateChangedListener.html"/>
        /// </summary>
        public partial class OnDateChangedListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnDateChangedListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.DatePicker_OnDateChangedListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnDateChangedListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnDateChangedListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnDateChangedListenerDirect : OnDateChangedListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.DatePicker$OnDateChangedListener";
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

    #region DatePicker implementation
    public partial class DatePicker
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public DatePicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public DatePicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public DatePicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public DatePicker(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getCalendarView()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.CalendarView"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.CalendarView GetCalendarView()
        {
            return IExecuteWithSignature<Android.Widget.CalendarView>("getCalendarView", "()Landroid/widget/CalendarView;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getCalendarViewShown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetCalendarViewShown()
        {
            return IExecuteWithSignature<bool>("getCalendarViewShown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getSpinnersShown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetSpinnersShown()
        {
            return IExecuteWithSignature<bool>("getSpinnersShown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfMonth()
        {
            return IExecuteWithSignature<int>("getDayOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getFirstDayOfWeek()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFirstDayOfWeek()
        {
            return IExecuteWithSignature<int>("getFirstDayOfWeek", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonth()
        {
            return IExecuteWithSignature<int>("getMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetYear()
        {
            return IExecuteWithSignature<int>("getYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getMaxDate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMaxDate()
        {
            return IExecuteWithSignature<long>("getMaxDate", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getMinDate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMinDate()
        {
            return IExecuteWithSignature<long>("getMinDate", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#init(int,int,int,android.widget.DatePicker.OnDateChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Widget.DatePicker.OnDateChangedListener"/></param>
        public void Init(int arg0, int arg1, int arg2, Android.Widget.DatePicker.OnDateChangedListener arg3)
        {
            IExecuteWithSignature("init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setCalendarViewShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetCalendarViewShown(bool arg0)
        {
            IExecuteWithSignature("setCalendarViewShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setFirstDayOfWeek(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFirstDayOfWeek(int arg0)
        {
            IExecuteWithSignature("setFirstDayOfWeek", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setMaxDate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMaxDate(long arg0)
        {
            IExecuteWithSignature("setMaxDate", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setMinDate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMinDate(long arg0)
        {
            IExecuteWithSignature("setMinDate", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setOnDateChangedListener(android.widget.DatePicker.OnDateChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.DatePicker.OnDateChangedListener"/></param>
        public void SetOnDateChangedListener(Android.Widget.DatePicker.OnDateChangedListener arg0)
        {
            IExecuteWithSignature("setOnDateChangedListener", "(Landroid/widget/DatePicker$OnDateChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setSpinnersShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetSpinnersShown(bool arg0)
        {
            IExecuteWithSignature("setSpinnersShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#updateDate(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void UpdateDate(int arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("updateDate", "(III)V", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
        #region OnDateChangedListener implementation
        public partial class OnDateChangedListener
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
            /// Handlers initializer for <see cref="OnDateChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDateChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnDateChangedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/DatePicker.OnDateChangedListener.html#onDateChanged(android.widget.DatePicker,int,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.DatePicker, int, int, int> OnOnDateChanged { get; set; } = null;
            
            bool hasOverrideOnDateChanged = true;
            void OnDateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnDateChanged = true;
                var methodToExecute = (OnOnDateChanged != null) ? OnOnDateChanged : OnDateChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.DatePicker>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnDateChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/DatePicker.OnDateChangedListener.html#onDateChanged(android.widget.DatePicker,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.DatePicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public virtual void OnDateChanged(Android.Widget.DatePicker arg0, int arg1, int arg2, int arg3)
            {
                hasOverrideOnDateChanged = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnDateChangedListenerDirect implementation
        public partial class OnDateChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/DatePicker.OnDateChangedListener.html#onDateChanged(android.widget.DatePicker,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.DatePicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public override void OnDateChanged(Android.Widget.DatePicker arg0, int arg1, int arg2, int arg3)
            {
                IExecuteWithSignature("onDateChanged", "(Landroid/widget/DatePicker;III)V", arg0, arg1, arg2, arg3);
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