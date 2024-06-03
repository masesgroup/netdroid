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

namespace Java.Time
{
    #region LocalDateTime
    public partial class LocalDateTime : Java.Time.Temporal.ITemporal, Java.Time.Temporal.ITemporalAdjuster, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDateTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.LocalDateTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDateTime"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.LocalDateTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDateTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.LocalDateTime t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#MAX"/>
        /// </summary>
        public static Java.Time.LocalDateTime MAX { get { if (!_MAXReady) { _MAXContent = SGetField<Java.Time.LocalDateTime>(LocalBridgeClazz, "MAX"); _MAXReady = true; } return _MAXContent; } }
        private static Java.Time.LocalDateTime _MAXContent = default;
        private static bool _MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#MIN"/>
        /// </summary>
        public static Java.Time.LocalDateTime MIN { get { if (!_MINReady) { _MINContent = SGetField<Java.Time.LocalDateTime>(LocalBridgeClazz, "MIN"); _MINReady = true; } return _MINContent; } }
        private static Java.Time.LocalDateTime _MINContent = default;
        private static bool _MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Now()
        {
            return SExecuteWithSignature<Java.Time.LocalDateTime>(LocalBridgeClazz, "now", "()Ljava/time/LocalDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDateTime>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDateTime>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(int,java.time.Month,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Time.Month"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, Java.Time.Month arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(int,java.time.Month,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Time.Month"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, Java.Time.Month arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(int,java.time.Month,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Time.Month"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(int arg0, Java.Time.Month arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#of(java.time.LocalDate,java.time.LocalTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.LocalTime"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Of(Java.Time.LocalDate arg0, Java.Time.LocalTime arg1)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#ofEpochSecond(long,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime OfEpochSecond(long arg0, int arg1, Java.Time.ZoneOffset arg2)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "ofEpochSecond", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.LocalDateTime>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public static Java.Time.LocalDateTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDateTime>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/LocalDateTime;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfMonth()
        {
            return IExecuteWithSignature<int>("getDayOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getDayOfYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfYear()
        {
            return IExecuteWithSignature<int>("getDayOfYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getHour()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHour()
        {
            return IExecuteWithSignature<int>("getHour", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getMinute()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinute()
        {
            return IExecuteWithSignature<int>("getMinute", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getMonthValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonthValue()
        {
            return IExecuteWithSignature<int>("getMonthValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getNano()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNano()
        {
            return IExecuteWithSignature<int>("getNano", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getSecond()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSecond()
        {
            return IExecuteWithSignature<int>("getSecond", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetYear()
        {
            return IExecuteWithSignature<int>("getYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#toLocalDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ToLocalDate()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("toLocalDate", "()Ljava/time/chrono/ChronoLocalDate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getDayOfWeek()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek GetDayOfWeek()
        {
            return IExecuteWithSignature<Java.Time.DayOfWeek>("getDayOfWeek", "()Ljava/time/DayOfWeek;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusDays", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusHours", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusMinutes", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusMonths", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusNanos", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusSeconds", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusWeeks(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusWeeks", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime MinusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("minusYears", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusDays", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusHours", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusMinutes", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusMonths", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusNanos", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusSeconds", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusWeeks(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusWeeks", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime PlusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("plusYears", "(J)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithDayOfMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withDayOfMonth", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withDayOfYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithDayOfYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withDayOfYear", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithHour(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withHour", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithMinute(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withMinute", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withMonth", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithNano(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withNano", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithSecond(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withSecond", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#withYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime WithYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("withYear", "(I)Ljava/time/LocalDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#toLocalTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("toLocalTime", "()Ljava/time/LocalTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month GetMonth()
        {
            return IExecuteWithSignature<Java.Time.Month>("getMonth", "()Ljava/time/Month;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#atOffset(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime AtOffset(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetDateTime>("atOffset", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDateTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Until(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<long>("until", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}