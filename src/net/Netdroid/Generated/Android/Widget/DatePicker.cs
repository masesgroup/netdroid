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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region DatePicker
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
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getDayOfMonth()"/> 
        /// </summary>
        public int DayOfMonth
        {
            get { return IExecuteWithSignature<int>("getDayOfMonth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getFirstDayOfWeek()"/> <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setFirstDayOfWeek(int)"/>
        /// </summary>
        public int FirstDayOfWeek
        {
            get { return IExecuteWithSignature<int>("getFirstDayOfWeek", "()I"); } set { IExecuteWithSignature("setFirstDayOfWeek", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getMaxDate()"/> <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setMaxDate(long)"/>
        /// </summary>
        public long MaxDate
        {
            get { return IExecuteWithSignature<long>("getMaxDate", "()J"); } set { IExecuteWithSignature("setMaxDate", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getMinDate()"/> <see href="https://developer.android.com/reference/android/widget/DatePicker.html#setMinDate(long)"/>
        /// </summary>
        public long MinDate
        {
            get { return IExecuteWithSignature<long>("getMinDate", "()J"); } set { IExecuteWithSignature("setMinDate", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getMonth()"/> 
        /// </summary>
        public int Month
        {
            get { return IExecuteWithSignature<int>("getMonth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#getYear()"/> 
        /// </summary>
        public int Year
        {
            get { return IExecuteWithSignature<int>("getYear", "()I"); }
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
            IExecute("init", arg0, arg1, arg2, arg3);
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
        /// <see href="https://developer.android.com/reference/android/widget/DatePicker.html#updateDate(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void UpdateDate(int arg0, int arg1, int arg2)
        {
            IExecute("updateDate", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region OnDateChangedListener
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
                AddEventHandler("onDateChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.DatePicker>>>(OnDateChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/DatePicker.OnDateChangedListener.html#onDateChanged(android.widget.DatePicker,int,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Android.Widget.DatePicker, int, int, int> OnOnDateChanged { get; set; } = null;

            void OnDateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.DatePicker>> data)
            {
                var methodToExecute = (OnOnDateChanged != null) ? OnOnDateChanged : OnDateChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
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
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDateChangedListenerDirect
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
                IExecute("onDateChanged", arg0, arg1, arg2, arg3);
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