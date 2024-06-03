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
    #region ZonedDateTime
    public partial class ZonedDateTime : Java.Time.Temporal.ITemporal, Java.Time.Chrono.IChronoZonedDateTime<Java.Time.LocalDate>, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.ZonedDateTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.ZonedDateTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.ZonedDateTime"/> to <see cref="Java.Time.Chrono.ChronoZonedDateTime"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoZonedDateTime(Java.Time.ZonedDateTime t) => t.Cast<Java.Time.Chrono.ChronoZonedDateTime>();
        /// <summary>
        /// Converter from <see cref="Java.Time.ZonedDateTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.ZonedDateTime t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Now()
        {
            return SExecuteWithSignature<Java.Time.ZonedDateTime>(LocalBridgeClazz, "now", "()Ljava/time/ZonedDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.ZonedDateTime>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.ZonedDateTime>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#of(int,int,int,int,int,int,int,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Time.ZoneId arg7)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#of(java.time.LocalDate,java.time.LocalTime,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.LocalTime"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Of(Java.Time.LocalDate arg0, Java.Time.LocalTime arg1, Java.Time.ZoneId arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#of(java.time.LocalDateTime,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Of(Java.Time.LocalDateTime arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#ofInstant(java.time.LocalDateTime,java.time.ZoneOffset,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfInstant(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1, Java.Time.ZoneId arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofInstant", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#ofLocal(java.time.LocalDateTime,java.time.ZoneId,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfLocal(Java.Time.LocalDateTime arg0, Java.Time.ZoneId arg1, Java.Time.ZoneOffset arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofLocal", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#ofStrict(java.time.LocalDateTime,java.time.ZoneOffset,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime OfStrict(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1, Java.Time.ZoneId arg2)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "ofStrict", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.ZonedDateTime>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public static Java.Time.ZonedDateTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.ZonedDateTime>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/ZonedDateTime;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfMonth()
        {
            return IExecuteWithSignature<int>("getDayOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getDayOfYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfYear()
        {
            return IExecuteWithSignature<int>("getDayOfYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getHour()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHour()
        {
            return IExecuteWithSignature<int>("getHour", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getMinute()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinute()
        {
            return IExecuteWithSignature<int>("getMinute", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getMonthValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonthValue()
        {
            return IExecuteWithSignature<int>("getMonthValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getNano()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNano()
        {
            return IExecuteWithSignature<int>("getNano", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getSecond()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSecond()
        {
            return IExecuteWithSignature<int>("getSecond", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetYear()
        {
            return IExecuteWithSignature<int>("getYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#toLocalDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ToLocalDate()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("toLocalDate", "()Ljava/time/chrono/ChronoLocalDate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#toLocalDateTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></returns>
        public Java.Time.Chrono.ChronoLocalDateTime ToLocalDateTime()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDateTime>("toLocalDateTime", "()Ljava/time/chrono/ChronoLocalDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withEarlierOffsetAtOverlap()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithEarlierOffsetAtOverlap()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoZonedDateTime>("withEarlierOffsetAtOverlap", "()Ljava/time/chrono/ChronoZonedDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withLaterOffsetAtOverlap()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithLaterOffsetAtOverlap()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoZonedDateTime>("withLaterOffsetAtOverlap", "()Ljava/time/chrono/ChronoZonedDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withZoneSameInstant(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithZoneSameInstant(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoZonedDateTime>("withZoneSameInstant", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withZoneSameLocal(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime WithZoneSameLocal(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoZonedDateTime>("withZoneSameLocal", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getDayOfWeek()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek GetDayOfWeek()
        {
            return IExecuteWithSignature<Java.Time.DayOfWeek>("getDayOfWeek", "()Ljava/time/DayOfWeek;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#toLocalTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("toLocalTime", "()Ljava/time/LocalTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month GetMonth()
        {
            return IExecuteWithSignature<Java.Time.Month>("getMonth", "()Ljava/time/Month;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#toOffsetDateTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime ToOffsetDateTime()
        {
            return IExecuteWithSignature<Java.Time.OffsetDateTime>("toOffsetDateTime", "()Ljava/time/OffsetDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusDays", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusHours", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusMinutes", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusMonths", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusNanos", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusSeconds", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusWeeks(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusWeeks", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime MinusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("minusYears", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusDays", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusHours", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusMinutes", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusMonths", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusNanos", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusSeconds", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusWeeks(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusWeeks", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime PlusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("plusYears", "(J)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithDayOfMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withDayOfMonth", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withDayOfYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithDayOfYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withDayOfYear", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withFixedOffsetZone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithFixedOffsetZone()
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withFixedOffsetZone", "()Ljava/time/ZonedDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithHour(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withHour", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithMinute(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withMinute", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withMonth", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithNano(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withNano", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithSecond(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withSecond", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#withYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime WithYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("withYear", "(I)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getZone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public Java.Time.ZoneId GetZone()
        {
            return IExecuteWithSignature<Java.Time.ZoneId>("getZone", "()Ljava/time/ZoneId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getOffset()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetOffset()
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffset", "()Ljava/time/ZoneOffset;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZonedDateTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
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