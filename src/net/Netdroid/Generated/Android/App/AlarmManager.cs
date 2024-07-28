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

namespace Android.App
{
    #region AlarmManager
    public partial class AlarmManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#ELAPSED_REALTIME"/>
        /// </summary>
        public static int ELAPSED_REALTIME { get { if (!_ELAPSED_REALTIMEReady) { _ELAPSED_REALTIMEContent = SGetField<int>(LocalBridgeClazz, "ELAPSED_REALTIME"); _ELAPSED_REALTIMEReady = true; } return _ELAPSED_REALTIMEContent; } }
        private static int _ELAPSED_REALTIMEContent = default;
        private static bool _ELAPSED_REALTIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#ELAPSED_REALTIME_WAKEUP"/>
        /// </summary>
        public static int ELAPSED_REALTIME_WAKEUP { get { if (!_ELAPSED_REALTIME_WAKEUPReady) { _ELAPSED_REALTIME_WAKEUPContent = SGetField<int>(LocalBridgeClazz, "ELAPSED_REALTIME_WAKEUP"); _ELAPSED_REALTIME_WAKEUPReady = true; } return _ELAPSED_REALTIME_WAKEUPContent; } }
        private static int _ELAPSED_REALTIME_WAKEUPContent = default;
        private static bool _ELAPSED_REALTIME_WAKEUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#RTC"/>
        /// </summary>
        public static int RTC { get { if (!_RTCReady) { _RTCContent = SGetField<int>(LocalBridgeClazz, "RTC"); _RTCReady = true; } return _RTCContent; } }
        private static int _RTCContent = default;
        private static bool _RTCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#RTC_WAKEUP"/>
        /// </summary>
        public static int RTC_WAKEUP { get { if (!_RTC_WAKEUPReady) { _RTC_WAKEUPContent = SGetField<int>(LocalBridgeClazz, "RTC_WAKEUP"); _RTC_WAKEUPReady = true; } return _RTC_WAKEUPContent; } }
        private static int _RTC_WAKEUPContent = default;
        private static bool _RTC_WAKEUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#ACTION_NEXT_ALARM_CLOCK_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_NEXT_ALARM_CLOCK_CHANGED { get { if (!_ACTION_NEXT_ALARM_CLOCK_CHANGEDReady) { _ACTION_NEXT_ALARM_CLOCK_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_NEXT_ALARM_CLOCK_CHANGED"); _ACTION_NEXT_ALARM_CLOCK_CHANGEDReady = true; } return _ACTION_NEXT_ALARM_CLOCK_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_NEXT_ALARM_CLOCK_CHANGEDContent = default;
        private static bool _ACTION_NEXT_ALARM_CLOCK_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGED { get { if (!_ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGEDReady) { _ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGED"); _ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGEDReady = true; } return _ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGEDContent = default;
        private static bool _ACTION_SCHEDULE_EXACT_ALARM_PERMISSION_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#INTERVAL_DAY"/>
        /// </summary>
        public static long INTERVAL_DAY { get { if (!_INTERVAL_DAYReady) { _INTERVAL_DAYContent = SGetField<long>(LocalBridgeClazz, "INTERVAL_DAY"); _INTERVAL_DAYReady = true; } return _INTERVAL_DAYContent; } }
        private static long _INTERVAL_DAYContent = default;
        private static bool _INTERVAL_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#INTERVAL_FIFTEEN_MINUTES"/>
        /// </summary>
        public static long INTERVAL_FIFTEEN_MINUTES { get { if (!_INTERVAL_FIFTEEN_MINUTESReady) { _INTERVAL_FIFTEEN_MINUTESContent = SGetField<long>(LocalBridgeClazz, "INTERVAL_FIFTEEN_MINUTES"); _INTERVAL_FIFTEEN_MINUTESReady = true; } return _INTERVAL_FIFTEEN_MINUTESContent; } }
        private static long _INTERVAL_FIFTEEN_MINUTESContent = default;
        private static bool _INTERVAL_FIFTEEN_MINUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#INTERVAL_HALF_DAY"/>
        /// </summary>
        public static long INTERVAL_HALF_DAY { get { if (!_INTERVAL_HALF_DAYReady) { _INTERVAL_HALF_DAYContent = SGetField<long>(LocalBridgeClazz, "INTERVAL_HALF_DAY"); _INTERVAL_HALF_DAYReady = true; } return _INTERVAL_HALF_DAYContent; } }
        private static long _INTERVAL_HALF_DAYContent = default;
        private static bool _INTERVAL_HALF_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#INTERVAL_HALF_HOUR"/>
        /// </summary>
        public static long INTERVAL_HALF_HOUR { get { if (!_INTERVAL_HALF_HOURReady) { _INTERVAL_HALF_HOURContent = SGetField<long>(LocalBridgeClazz, "INTERVAL_HALF_HOUR"); _INTERVAL_HALF_HOURReady = true; } return _INTERVAL_HALF_HOURContent; } }
        private static long _INTERVAL_HALF_HOURContent = default;
        private static bool _INTERVAL_HALF_HOURReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#INTERVAL_HOUR"/>
        /// </summary>
        public static long INTERVAL_HOUR { get { if (!_INTERVAL_HOURReady) { _INTERVAL_HOURContent = SGetField<long>(LocalBridgeClazz, "INTERVAL_HOUR"); _INTERVAL_HOURReady = true; } return _INTERVAL_HOURContent; } }
        private static long _INTERVAL_HOURContent = default;
        private static bool _INTERVAL_HOURReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#getNextAlarmClock()"/>
        /// </summary>
        /// <returns><see cref="Android.App.AlarmManager.AlarmClockInfo"/></returns>
        public Android.App.AlarmManager.AlarmClockInfo GetNextAlarmClock()
        {
            return IExecuteWithSignature<Android.App.AlarmManager.AlarmClockInfo>("getNextAlarmClock", "()Landroid/app/AlarmManager$AlarmClockInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#canScheduleExactAlarms()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanScheduleExactAlarms()
        {
            return IExecuteWithSignature<bool>("canScheduleExactAlarms", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#cancel(android.app.AlarmManager.OnAlarmListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.AlarmManager.OnAlarmListener"/></param>
        public void Cancel(Android.App.AlarmManager.OnAlarmListener arg0)
        {
            IExecuteWithSignature("cancel", "(Landroid/app/AlarmManager$OnAlarmListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#cancel(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        public void Cancel(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("cancel", "(Landroid/app/PendingIntent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#cancelAll()"/>
        /// </summary>
        public void CancelAll()
        {
            IExecuteWithSignature("cancelAll", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#set(int,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void Set(int arg0, long arg1, Android.App.PendingIntent arg2)
        {
            IExecute("set", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#set(int,long,java.lang.String,android.app.AlarmManager.OnAlarmListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.App.AlarmManager.OnAlarmListener"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public void Set(int arg0, long arg1, Java.Lang.String arg2, Android.App.AlarmManager.OnAlarmListener arg3, Android.Os.Handler arg4)
        {
            IExecute("set", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setAlarmClock(android.app.AlarmManager.AlarmClockInfo,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.AlarmManager.AlarmClockInfo"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        public void SetAlarmClock(Android.App.AlarmManager.AlarmClockInfo arg0, Android.App.PendingIntent arg1)
        {
            IExecute("setAlarmClock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setAndAllowWhileIdle(int,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void SetAndAllowWhileIdle(int arg0, long arg1, Android.App.PendingIntent arg2)
        {
            IExecute("setAndAllowWhileIdle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setExact(int,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void SetExact(int arg0, long arg1, Android.App.PendingIntent arg2)
        {
            IExecute("setExact", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setExact(int,long,java.lang.String,android.app.AlarmManager.OnAlarmListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.App.AlarmManager.OnAlarmListener"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public void SetExact(int arg0, long arg1, Java.Lang.String arg2, Android.App.AlarmManager.OnAlarmListener arg3, Android.Os.Handler arg4)
        {
            IExecute("setExact", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setExactAndAllowWhileIdle(int,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        public void SetExactAndAllowWhileIdle(int arg0, long arg1, Android.App.PendingIntent arg2)
        {
            IExecute("setExactAndAllowWhileIdle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setInexactRepeating(int,long,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.PendingIntent"/></param>
        public void SetInexactRepeating(int arg0, long arg1, long arg2, Android.App.PendingIntent arg3)
        {
            IExecute("setInexactRepeating", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setRepeating(int,long,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.PendingIntent"/></param>
        public void SetRepeating(int arg0, long arg1, long arg2, Android.App.PendingIntent arg3)
        {
            IExecute("setRepeating", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetTime(long arg0)
        {
            IExecuteWithSignature("setTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setTimeZone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetTimeZone(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setTimeZone", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setWindow(int,long,long,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.PendingIntent"/></param>
        public void SetWindow(int arg0, long arg1, long arg2, Android.App.PendingIntent arg3)
        {
            IExecute("setWindow", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setWindow(int,long,long,java.lang.String,android.app.AlarmManager.OnAlarmListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Android.App.AlarmManager.OnAlarmListener"/></param>
        /// <param name="arg5"><see cref="Android.Os.Handler"/></param>
        public void SetWindow(int arg0, long arg1, long arg2, Java.Lang.String arg3, Android.App.AlarmManager.OnAlarmListener arg4, Android.Os.Handler arg5)
        {
            IExecute("setWindow", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/AlarmManager.html#setWindow(int,long,long,java.lang.String,java.util.concurrent.Executor,android.app.AlarmManager.OnAlarmListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg5"><see cref="Android.App.AlarmManager.OnAlarmListener"/></param>
        public void SetWindow(int arg0, long arg1, long arg2, Java.Lang.String arg3, Java.Util.Concurrent.Executor arg4, Android.App.AlarmManager.OnAlarmListener arg5)
        {
            IExecute("setWindow", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes
        #region AlarmClockInfo
        public partial class AlarmClockInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.AlarmClockInfo.html#%3Cinit%3E(long,android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
            public AlarmClockInfo(long arg0, Android.App.PendingIntent arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.AlarmClockInfo.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.AlarmClockInfo.html#getShowIntent()"/>
            /// </summary>
            /// <returns><see cref="Android.App.PendingIntent"/></returns>
            public Android.App.PendingIntent GetShowIntent()
            {
                return IExecuteWithSignature<Android.App.PendingIntent>("getShowIntent", "()Landroid/app/PendingIntent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.AlarmClockInfo.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.AlarmClockInfo.html#getTriggerTime()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetTriggerTime()
            {
                return IExecuteWithSignature<long>("getTriggerTime", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.AlarmClockInfo.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnAlarmListener
        public partial class OnAlarmListener
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
            /// Handlers initializer for <see cref="OnAlarmListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAlarm", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnAlarmEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/AlarmManager.OnAlarmListener.html#onAlarm()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAlarm"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnAlarm { get; set; } = null;

            void OnAlarmEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnAlarm != null) ? OnOnAlarm : OnAlarm;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.OnAlarmListener.html#onAlarm()"/>
            /// </summary>
            public virtual void OnAlarm()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnAlarmListenerDirect
        public partial class OnAlarmListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/AlarmManager.OnAlarmListener.html#onAlarm()"/>
            /// </summary>
            public override void OnAlarm()
            {
                IExecuteWithSignature("onAlarm", "()V");
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