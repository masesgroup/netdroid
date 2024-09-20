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

namespace Java.Time.Chrono
{
    #region IChronoLocalDate
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IChronoLocalDate
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ChronoLocalDate
    public partial class ChronoLocalDate : Java.Time.Chrono.IChronoLocalDate, Java.Time.Temporal.ITemporal, Java.Time.Temporal.ITemporalAdjuster, Java.Lang.IComparable<Java.Time.Chrono.ChronoLocalDate>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ChronoLocalDate"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.Chrono.ChronoLocalDate t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ChronoLocalDate"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.Chrono.ChronoLocalDate t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.ChronoLocalDate"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.Chrono.ChronoLocalDate t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public static Java.Time.Chrono.ChronoLocalDate From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#timeLineOrder()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public static Java.Util.Comparator<Java.Time.Chrono.ChronoLocalDate> TimeLineOrder()
        {
            return SExecuteWithSignature<Java.Util.Comparator<Java.Time.Chrono.ChronoLocalDate>>(LocalBridgeClazz, "timeLineOrder", "()Ljava/util/Comparator;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#lengthOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LengthOfMonth()
        {
            return IExecuteWithSignature<int>("lengthOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#getChronology()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public Java.Time.Chrono.Chronology GetChronology()
        {
            return IExecuteWithSignature<Java.Time.Chrono.Chronology>("getChronology", "()Ljava/time/chrono/Chronology;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#until(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Until(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("until", "(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Until(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<long>("until", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#isAfter(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<bool>("isAfter", "(Ljava/time/chrono/ChronoLocalDate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#isBefore(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<bool>("isBefore", "(Ljava/time/chrono/ChronoLocalDate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#isEqual(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<bool>("isEqual", "(Ljava/time/chrono/ChronoLocalDate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#isLeapYear()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeapYear()
        {
            return IExecuteWithSignature<bool>("isLeapYear", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#compareTo(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/chrono/ChronoLocalDate;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#lengthOfYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LengthOfYear()
        {
            return IExecuteWithSignature<int>("lengthOfYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#getEra()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.Era"/></returns>
        public Java.Time.Chrono.Era GetEra()
        {
            return IExecuteWithSignature<Java.Time.Chrono.Era>("getEra", "()Ljava/time/chrono/Era;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#with(java.time.temporal.TemporalAdjuster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAdjuster"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("with", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#with(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/ChronoLocalDate.html#toEpochDay()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToEpochDay()
        {
            return IExecuteWithSignature<long>("toEpochDay", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}