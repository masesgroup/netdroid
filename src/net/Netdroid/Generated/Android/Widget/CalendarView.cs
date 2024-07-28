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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region CalendarView
    public partial class CalendarView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public CalendarView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public CalendarView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public CalendarView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public CalendarView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getSelectedDateVerticalBar()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        [global::System.Obsolete()]
        public Android.Graphics.Drawable.Drawable GetSelectedDateVerticalBar()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getSelectedDateVerticalBar", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getShowWeekNumber()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetShowWeekNumber()
        {
            return IExecuteWithSignature<bool>("getShowWeekNumber", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getDateTextAppearance()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDateTextAppearance()
        {
            return IExecuteWithSignature<int>("getDateTextAppearance", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getFirstDayOfWeek()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFirstDayOfWeek()
        {
            return IExecuteWithSignature<int>("getFirstDayOfWeek", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getFocusedMonthDateColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetFocusedMonthDateColor()
        {
            return IExecuteWithSignature<int>("getFocusedMonthDateColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getSelectedWeekBackgroundColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetSelectedWeekBackgroundColor()
        {
            return IExecuteWithSignature<int>("getSelectedWeekBackgroundColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getShownWeekCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetShownWeekCount()
        {
            return IExecuteWithSignature<int>("getShownWeekCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getUnfocusedMonthDateColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetUnfocusedMonthDateColor()
        {
            return IExecuteWithSignature<int>("getUnfocusedMonthDateColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getWeekDayTextAppearance()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWeekDayTextAppearance()
        {
            return IExecuteWithSignature<int>("getWeekDayTextAppearance", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getWeekNumberColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetWeekNumberColor()
        {
            return IExecuteWithSignature<int>("getWeekNumberColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getWeekSeparatorLineColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetWeekSeparatorLineColor()
        {
            return IExecuteWithSignature<int>("getWeekSeparatorLineColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getDate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDate()
        {
            return IExecuteWithSignature<long>("getDate", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getMaxDate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMaxDate()
        {
            return IExecuteWithSignature<long>("getMaxDate", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#getMinDate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMinDate()
        {
            return IExecuteWithSignature<long>("getMinDate", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setDate(long,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void SetDate(long arg0, bool arg1, bool arg2)
        {
            IExecute("setDate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setDate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetDate(long arg0)
        {
            IExecuteWithSignature("setDate", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setDateTextAppearance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDateTextAppearance(int arg0)
        {
            IExecuteWithSignature("setDateTextAppearance", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setFirstDayOfWeek(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFirstDayOfWeek(int arg0)
        {
            IExecuteWithSignature("setFirstDayOfWeek", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setFocusedMonthDateColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetFocusedMonthDateColor(int arg0)
        {
            IExecuteWithSignature("setFocusedMonthDateColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setMaxDate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMaxDate(long arg0)
        {
            IExecuteWithSignature("setMaxDate", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setMinDate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMinDate(long arg0)
        {
            IExecuteWithSignature("setMinDate", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setOnDateChangeListener(android.widget.CalendarView.OnDateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.CalendarView.OnDateChangeListener"/></param>
        public void SetOnDateChangeListener(Android.Widget.CalendarView.OnDateChangeListener arg0)
        {
            IExecuteWithSignature("setOnDateChangeListener", "(Landroid/widget/CalendarView$OnDateChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setSelectedDateVerticalBar(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        [global::System.Obsolete()]
        public void SetSelectedDateVerticalBar(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setSelectedDateVerticalBar", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setSelectedDateVerticalBar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSelectedDateVerticalBar(int arg0)
        {
            IExecuteWithSignature("setSelectedDateVerticalBar", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setSelectedWeekBackgroundColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetSelectedWeekBackgroundColor(int arg0)
        {
            IExecuteWithSignature("setSelectedWeekBackgroundColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setShownWeekCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetShownWeekCount(int arg0)
        {
            IExecuteWithSignature("setShownWeekCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setShowWeekNumber(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetShowWeekNumber(bool arg0)
        {
            IExecuteWithSignature("setShowWeekNumber", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setUnfocusedMonthDateColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetUnfocusedMonthDateColor(int arg0)
        {
            IExecuteWithSignature("setUnfocusedMonthDateColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setWeekDayTextAppearance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetWeekDayTextAppearance(int arg0)
        {
            IExecuteWithSignature("setWeekDayTextAppearance", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setWeekNumberColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetWeekNumberColor(int arg0)
        {
            IExecuteWithSignature("setWeekNumberColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CalendarView.html#setWeekSeparatorLineColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetWeekSeparatorLineColor(int arg0)
        {
            IExecuteWithSignature("setWeekSeparatorLineColor", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnDateChangeListener
        public partial class OnDateChangeListener
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
            /// Handlers initializer for <see cref="OnDateChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSelectedDayChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.CalendarView>>>(OnSelectedDayChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/CalendarView.OnDateChangeListener.html#onSelectedDayChange(android.widget.CalendarView,int,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSelectedDayChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.CalendarView, int, int, int> OnOnSelectedDayChange { get; set; } = null;

            void OnSelectedDayChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.CalendarView>> data)
            {
                var methodToExecute = (OnOnSelectedDayChange != null) ? OnOnSelectedDayChange : OnSelectedDayChange;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/CalendarView.OnDateChangeListener.html#onSelectedDayChange(android.widget.CalendarView,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.CalendarView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public virtual void OnSelectedDayChange(Android.Widget.CalendarView arg0, int arg1, int arg2, int arg3)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDateChangeListenerDirect
        public partial class OnDateChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/CalendarView.OnDateChangeListener.html#onSelectedDayChange(android.widget.CalendarView,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.CalendarView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public override void OnSelectedDayChange(Android.Widget.CalendarView arg0, int arg1, int arg2, int arg3)
            {
                IExecute("onSelectedDayChange", arg0, arg1, arg2, arg3);
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