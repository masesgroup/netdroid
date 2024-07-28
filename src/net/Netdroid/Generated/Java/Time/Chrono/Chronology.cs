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

namespace Java.Time.Chrono
{
    #region IChronology
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IChronology : Java.Lang.IComparable<Java.Time.Chrono.Chronology>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Chronology
    public partial class Chronology : Java.Time.Chrono.IChronology
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public static Java.Time.Chrono.Chronology From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.Chronology>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/Chronology;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#of(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public static Java.Time.Chrono.Chronology Of(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.Chronology>(LocalBridgeClazz, "of", "(Ljava/lang/String;)Ljava/time/chrono/Chronology;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#ofLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public static Java.Time.Chrono.Chronology OfLocale(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.Chronology>(LocalBridgeClazz, "ofLocale", "(Ljava/util/Locale;)Ljava/time/chrono/Chronology;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#getAvailableChronologies()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Time.Chrono.Chronology> GetAvailableChronologies()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Time.Chrono.Chronology>>(LocalBridgeClazz, "getAvailableChronologies", "()Ljava/util/Set;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#isLeapYear(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeapYear(long arg0)
        {
            return IExecuteWithSignature<bool>("isLeapYear", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#compareTo(java.time.chrono.Chronology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.Chronology arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/chrono/Chronology;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#prolepticYear(java.time.chrono.Era,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ProlepticYear(Java.Time.Chrono.Era arg0, int arg1)
        {
            return IExecute<int>("prolepticYear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#getCalendarType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCalendarType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCalendarType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#date(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate Date(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("date", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#date(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate Date(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("date", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#dateEpochDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateEpochDay(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateEpochDay", "(J)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#dateYearDay(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateYearDay(int arg0, int arg1)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("dateYearDay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#resolveDate(java.util.Map,java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate ResolveDate(Java.Util.Map<Java.Time.Temporal.TemporalField, Java.Lang.Long> arg0, Java.Time.Format.ResolverStyle arg1)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("resolveDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#eraOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.Era"/></returns>
        public Java.Time.Chrono.Era EraOf(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.Era>("eraOf", "(I)Ljava/time/chrono/Era;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#range(java.time.temporal.ChronoField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.ChronoField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.ChronoField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/ChronoField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#eras()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.Chrono.Era> Eras()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.Chrono.Era>>("eras", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#date(java.time.chrono.Era,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate Date(Java.Time.Chrono.Era arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("date", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#dateNow()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateNow()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateNow", "()Ljava/time/chrono/ChronoLocalDate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#dateNow(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateNow(Java.Time.Clock arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateNow", "(Ljava/time/Clock;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#dateNow(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateNow(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoLocalDate>("dateNow", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoLocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#dateYearDay(java.time.chrono.Era,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoLocalDate"/></returns>
        public Java.Time.Chrono.ChronoLocalDate DateYearDay(Java.Time.Chrono.Era arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.Chrono.ChronoLocalDate>("dateYearDay", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#period(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Period(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.Chrono.ChronoPeriod>("period", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#epochSecond(int,int,int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long EpochSecond(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Java.Time.ZoneOffset arg6)
        {
            return IExecute<long>("epochSecond", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/Chronology.html#epochSecond(java.time.chrono.Era,int,int,int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Era"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long EpochSecond(Java.Time.Chrono.Era arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Time.ZoneOffset arg7)
        {
            return IExecute<long>("epochSecond", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}