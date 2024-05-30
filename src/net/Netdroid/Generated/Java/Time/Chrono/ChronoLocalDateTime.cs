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

namespace Java.Time.Chrono
{
    #region ChronoLocalDateTime
    public partial class ChronoLocalDateTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ChronoLocalDateTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.Chrono.ChronoLocalDateTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ChronoLocalDateTime"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.Chrono.ChronoLocalDateTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ChronoLocalDateTime"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.Chrono.ChronoLocalDateTime t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></returns>
        public static Java.Time.Chrono.ChronoLocalDateTime From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.ChronoLocalDateTime>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDateTime;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#getChronology()"/> 
        /// </summary>
        public Java.Time.Chrono.Chronology Chronology
        {
            get { return IExecuteWithSignature<Java.Time.Chrono.Chronology>("getChronology", "()Ljava/time/chrono/Chronology;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#toLocalDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ToLocalDate()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("toLocalDate", "()Ljava/time/chrono/ChronoLocalDate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#atZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoZonedDateTime"/></returns>
        public Java.Time.Chrono.ChronoZonedDateTime AtZone(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoZonedDateTime>("atZone", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#toLocalTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("toLocalTime", "()Ljava/time/LocalTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="object"/></returns>
        public object Query(Java.Time.Temporal.TemporalQuery arg0)
        {
            return IExecuteWithSignature("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#isAfter(java.time.chrono.ChronoLocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.Chrono.ChronoLocalDateTime arg0)
        {
            return IExecuteWithSignature<bool>("isAfter", "(Ljava/time/chrono/ChronoLocalDateTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#isBefore(java.time.chrono.ChronoLocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.Chrono.ChronoLocalDateTime arg0)
        {
            return IExecuteWithSignature<bool>("isBefore", "(Ljava/time/chrono/ChronoLocalDateTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#isEqual(java.time.chrono.ChronoLocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Java.Time.Chrono.ChronoLocalDateTime arg0)
        {
            return IExecuteWithSignature<bool>("isEqual", "(Ljava/time/chrono/ChronoLocalDateTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#compareTo(java.time.chrono.ChronoLocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDateTime"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.ChronoLocalDateTime arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/chrono/ChronoLocalDateTime;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#toInstant(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant ToInstant(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<Java.Time.Instant>("toInstant", "(Ljava/time/ZoneOffset;)Ljava/time/Instant;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#with(java.time.temporal.TemporalAdjuster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAdjuster"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("with", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#with(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/chrono/ChronoLocalDateTime.html#toEpochSecond(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToEpochSecond(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<long>("toEpochSecond", "(Ljava/time/ZoneOffset;)J", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}