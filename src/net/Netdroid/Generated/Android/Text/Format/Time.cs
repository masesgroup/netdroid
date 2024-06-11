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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Format
{
    #region Time
    public partial class Time
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#%3Cinit%3E(android.text.format.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Format.Time"/></param>
        [global::System.Obsolete()]
        public Time(Android.Text.Format.Time arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public Time(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#allDay"/>
        /// </summary>
        [global::System.Obsolete()]
        public bool allDay { get { return IGetField<bool>("allDay"); } set { ISetField("allDay", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#hour"/>
        /// </summary>
        [global::System.Obsolete()]
        public int hour { get { return IGetField<int>("hour"); } set { ISetField("hour", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#isDst"/>
        /// </summary>
        [global::System.Obsolete()]
        public int isDst { get { return IGetField<int>("isDst"); } set { ISetField("isDst", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#minute"/>
        /// </summary>
        [global::System.Obsolete()]
        public int minute { get { return IGetField<int>("minute"); } set { ISetField("minute", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#month"/>
        /// </summary>
        [global::System.Obsolete()]
        public int month { get { return IGetField<int>("month"); } set { ISetField("month", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#monthDay"/>
        /// </summary>
        [global::System.Obsolete()]
        public int monthDay { get { return IGetField<int>("monthDay"); } set { ISetField("monthDay", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#second"/>
        /// </summary>
        [global::System.Obsolete()]
        public int second { get { return IGetField<int>("second"); } set { ISetField("second", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#weekDay"/>
        /// </summary>
        [global::System.Obsolete()]
        public int weekDay { get { return IGetField<int>("weekDay"); } set { ISetField("weekDay", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#year"/>
        /// </summary>
        [global::System.Obsolete()]
        public int year { get { return IGetField<int>("year"); } set { ISetField("year", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#yearDay"/>
        /// </summary>
        [global::System.Obsolete()]
        public int yearDay { get { return IGetField<int>("yearDay"); } set { ISetField("yearDay", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#timezone"/>
        /// </summary>
        [global::System.Obsolete()]
        public Java.Lang.String timezone { get { return IGetField<Java.Lang.String>("timezone"); } set { ISetField("timezone", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#gmtoff"/>
        /// </summary>
        [global::System.Obsolete()]
        public long gmtoff { get { return IGetField<long>("gmtoff"); } set { ISetField("gmtoff", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#EPOCH_JULIAN_DAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EPOCH_JULIAN_DAY { get { if (!_EPOCH_JULIAN_DAYReady) { _EPOCH_JULIAN_DAYContent = SGetField<int>(LocalBridgeClazz, "EPOCH_JULIAN_DAY"); _EPOCH_JULIAN_DAYReady = true; } return _EPOCH_JULIAN_DAYContent; } }
        private static int _EPOCH_JULIAN_DAYContent = default;
        private static bool _EPOCH_JULIAN_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#FRIDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int FRIDAY { get { if (!_FRIDAYReady) { _FRIDAYContent = SGetField<int>(LocalBridgeClazz, "FRIDAY"); _FRIDAYReady = true; } return _FRIDAYContent; } }
        private static int _FRIDAYContent = default;
        private static bool _FRIDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#HOUR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int HOUR { get { if (!_HOURReady) { _HOURContent = SGetField<int>(LocalBridgeClazz, "HOUR"); _HOURReady = true; } return _HOURContent; } }
        private static int _HOURContent = default;
        private static bool _HOURReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#MINUTE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MINUTE { get { if (!_MINUTEReady) { _MINUTEContent = SGetField<int>(LocalBridgeClazz, "MINUTE"); _MINUTEReady = true; } return _MINUTEContent; } }
        private static int _MINUTEContent = default;
        private static bool _MINUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#MONDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MONDAY { get { if (!_MONDAYReady) { _MONDAYContent = SGetField<int>(LocalBridgeClazz, "MONDAY"); _MONDAYReady = true; } return _MONDAYContent; } }
        private static int _MONDAYContent = default;
        private static bool _MONDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#MONDAY_BEFORE_JULIAN_EPOCH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MONDAY_BEFORE_JULIAN_EPOCH { get { if (!_MONDAY_BEFORE_JULIAN_EPOCHReady) { _MONDAY_BEFORE_JULIAN_EPOCHContent = SGetField<int>(LocalBridgeClazz, "MONDAY_BEFORE_JULIAN_EPOCH"); _MONDAY_BEFORE_JULIAN_EPOCHReady = true; } return _MONDAY_BEFORE_JULIAN_EPOCHContent; } }
        private static int _MONDAY_BEFORE_JULIAN_EPOCHContent = default;
        private static bool _MONDAY_BEFORE_JULIAN_EPOCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#MONTH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MONTH { get { if (!_MONTHReady) { _MONTHContent = SGetField<int>(LocalBridgeClazz, "MONTH"); _MONTHReady = true; } return _MONTHContent; } }
        private static int _MONTHContent = default;
        private static bool _MONTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#MONTH_DAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MONTH_DAY { get { if (!_MONTH_DAYReady) { _MONTH_DAYContent = SGetField<int>(LocalBridgeClazz, "MONTH_DAY"); _MONTH_DAYReady = true; } return _MONTH_DAYContent; } }
        private static int _MONTH_DAYContent = default;
        private static bool _MONTH_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#SATURDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SATURDAY { get { if (!_SATURDAYReady) { _SATURDAYContent = SGetField<int>(LocalBridgeClazz, "SATURDAY"); _SATURDAYReady = true; } return _SATURDAYContent; } }
        private static int _SATURDAYContent = default;
        private static bool _SATURDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#SECOND"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SECOND { get { if (!_SECONDReady) { _SECONDContent = SGetField<int>(LocalBridgeClazz, "SECOND"); _SECONDReady = true; } return _SECONDContent; } }
        private static int _SECONDContent = default;
        private static bool _SECONDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#SUNDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SUNDAY { get { if (!_SUNDAYReady) { _SUNDAYContent = SGetField<int>(LocalBridgeClazz, "SUNDAY"); _SUNDAYReady = true; } return _SUNDAYContent; } }
        private static int _SUNDAYContent = default;
        private static bool _SUNDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#THURSDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int THURSDAY { get { if (!_THURSDAYReady) { _THURSDAYContent = SGetField<int>(LocalBridgeClazz, "THURSDAY"); _THURSDAYReady = true; } return _THURSDAYContent; } }
        private static int _THURSDAYContent = default;
        private static bool _THURSDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#TUESDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TUESDAY { get { if (!_TUESDAYReady) { _TUESDAYContent = SGetField<int>(LocalBridgeClazz, "TUESDAY"); _TUESDAYReady = true; } return _TUESDAYContent; } }
        private static int _TUESDAYContent = default;
        private static bool _TUESDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#WEDNESDAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int WEDNESDAY { get { if (!_WEDNESDAYReady) { _WEDNESDAYContent = SGetField<int>(LocalBridgeClazz, "WEDNESDAY"); _WEDNESDAYReady = true; } return _WEDNESDAYContent; } }
        private static int _WEDNESDAYContent = default;
        private static bool _WEDNESDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#WEEK_DAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int WEEK_DAY { get { if (!_WEEK_DAYReady) { _WEEK_DAYContent = SGetField<int>(LocalBridgeClazz, "WEEK_DAY"); _WEEK_DAYReady = true; } return _WEEK_DAYContent; } }
        private static int _WEEK_DAYContent = default;
        private static bool _WEEK_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#WEEK_NUM"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int WEEK_NUM { get { if (!_WEEK_NUMReady) { _WEEK_NUMContent = SGetField<int>(LocalBridgeClazz, "WEEK_NUM"); _WEEK_NUMReady = true; } return _WEEK_NUMContent; } }
        private static int _WEEK_NUMContent = default;
        private static bool _WEEK_NUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#YEAR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int YEAR { get { if (!_YEARReady) { _YEARContent = SGetField<int>(LocalBridgeClazz, "YEAR"); _YEARReady = true; } return _YEARContent; } }
        private static int _YEARContent = default;
        private static bool _YEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#YEAR_DAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int YEAR_DAY { get { if (!_YEAR_DAYReady) { _YEAR_DAYContent = SGetField<int>(LocalBridgeClazz, "YEAR_DAY"); _YEAR_DAYReady = true; } return _YEAR_DAYContent; } }
        private static int _YEAR_DAYContent = default;
        private static bool _YEAR_DAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#TIMEZONE_UTC"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String TIMEZONE_UTC { get { if (!_TIMEZONE_UTCReady) { _TIMEZONE_UTCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TIMEZONE_UTC"); _TIMEZONE_UTCReady = true; } return _TIMEZONE_UTCContent; } }
        private static Java.Lang.String _TIMEZONE_UTCContent = default;
        private static bool _TIMEZONE_UTCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#isEpoch(android.text.format.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Format.Time"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsEpoch(Android.Text.Format.Time arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isEpoch", "(Landroid/text/format/Time;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#compare(android.text.format.Time,android.text.format.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Format.Time"/></param>
        /// <param name="arg1"><see cref="Android.Text.Format.Time"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int Compare(Android.Text.Format.Time arg0, Android.Text.Format.Time arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#getJulianDay(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetJulianDay(long arg0, long arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getJulianDay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#getJulianMondayFromWeeksSinceEpoch(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetJulianMondayFromWeeksSinceEpoch(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getJulianMondayFromWeeksSinceEpoch", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#getWeeksSinceEpochFromJulianDay(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetWeeksSinceEpochFromJulianDay(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getWeeksSinceEpochFromJulianDay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#getCurrentTimezone()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String GetCurrentTimezone()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getCurrentTimezone", "()Ljava/lang/String;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#after(android.text.format.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Format.Time"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool After(Android.Text.Format.Time arg0)
        {
            return IExecuteWithSignature<bool>("after", "(Landroid/text/format/Time;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#before(android.text.format.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Format.Time"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Before(Android.Text.Format.Time arg0)
        {
            return IExecuteWithSignature<bool>("before", "(Landroid/text/format/Time;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("parse", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#parse3339(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Parse3339(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("parse3339", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#getActualMaximum(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetActualMaximum(int arg0)
        {
            return IExecuteWithSignature<int>("getActualMaximum", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#getWeekNumber()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetWeekNumber()
        {
            return IExecuteWithSignature<int>("getWeekNumber", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#format(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String Format(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#format2445()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String Format2445()
        {
            return IExecuteWithSignature<Java.Lang.String>("format2445", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#format3339(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String Format3339(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format3339", "(Z)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#normalize(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long Normalize(bool arg0)
        {
            return IExecuteWithSignature<long>("normalize", "(Z)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#setJulianDay(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long SetJulianDay(int arg0)
        {
            return IExecuteWithSignature<long>("setJulianDay", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#toMillis(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long ToMillis(bool arg0)
        {
            return IExecuteWithSignature<long>("toMillis", "(Z)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#clear(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Clear(Java.Lang.String arg0)
        {
            IExecuteWithSignature("clear", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#set(android.text.format.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Format.Time"/></param>
        [global::System.Obsolete()]
        public void Set(Android.Text.Format.Time arg0)
        {
            IExecuteWithSignature("set", "(Landroid/text/format/Time;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#set(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void Set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("set", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#set(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void Set(int arg0, int arg1, int arg2)
        {
            IExecute("set", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#set(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void Set(long arg0)
        {
            IExecuteWithSignature("set", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#setToNow()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void SetToNow()
        {
            IExecuteWithSignature("setToNow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/format/Time.html#switchTimezone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void SwitchTimezone(Java.Lang.String arg0)
        {
            IExecuteWithSignature("switchTimezone", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}