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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region Period
    public partial class Period : Java.Time.Chrono.IChronoPeriod, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Period"/> to <see cref="Java.Time.Chrono.ChronoPeriod"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoPeriod(Java.Time.Period t) => t.Cast<Java.Time.Chrono.ChronoPeriod>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Period"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Period t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#ZERO"/>
        /// </summary>
        public static Java.Time.Period ZERO { get { if (!_ZEROReady) { _ZEROContent = SGetField<Java.Time.Period>(LocalBridgeClazz, "ZERO"); _ZEROReady = true; } return _ZEROContent; } }
        private static Java.Time.Period _ZEROContent = default;
        private static bool _ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#between(java.time.LocalDate,java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period Between(Java.Time.LocalDate arg0, Java.Time.LocalDate arg1)
        {
            return SExecute<Java.Time.Period>(LocalBridgeClazz, "between", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#from(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period From(Java.Time.Temporal.TemporalAmount arg0)
        {
            return SExecuteWithSignature<Java.Time.Period>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period Of(int arg0, int arg1, int arg2)
        {
            return SExecute<Java.Time.Period>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#ofDays(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfDays(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Period>(LocalBridgeClazz, "ofDays", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#ofMonths(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfMonths(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Period>(LocalBridgeClazz, "ofMonths", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#ofWeeks(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfWeeks(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Period>(LocalBridgeClazz, "ofWeeks", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#ofYears(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period OfYears(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Period>(LocalBridgeClazz, "ofYears", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public static Java.Time.Period Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.Period>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/Period;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#isNegative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNegative()
        {
            return IExecuteWithSignature<bool>("isNegative", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#isZero()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsZero()
        {
            return IExecuteWithSignature<bool>("isZero", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#getDays()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDays()
        {
            return IExecuteWithSignature<int>("getDays", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#getMonths()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonths()
        {
            return IExecuteWithSignature<int>("getMonths", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#getYears()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetYears()
        {
            return IExecuteWithSignature<int>("getYears", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#getChronology()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public Java.Time.Chrono.Chronology GetChronology()
        {
            return IExecuteWithSignature<Java.Time.Chrono.Chronology>("getChronology", "()Ljava/time/chrono/Chronology;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriod;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#multipliedBy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod MultipliedBy(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("multipliedBy", "(I)Ljava/time/chrono/ChronoPeriod;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#negated()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Negated()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("negated", "()Ljava/time/chrono/ChronoPeriod;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#normalized()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Normalized()
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("normalized", "()Ljava/time/chrono/ChronoPeriod;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoPeriod;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period MinusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("minusDays", "(J)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period MinusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("minusMonths", "(J)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period MinusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("minusYears", "(J)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period PlusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("plusDays", "(J)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period PlusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("plusMonths", "(J)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period PlusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("plusYears", "(J)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#withDays(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period WithDays(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("withDays", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#withMonths(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period WithMonths(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("withMonths", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#withYears(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Period"/></returns>
        public Java.Time.Period WithYears(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Period>("withYears", "(I)Ljava/time/Period;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#addTo(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AddTo(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("addTo", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#subtractFrom(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal SubtractFrom(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("subtractFrom", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#getUnits()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.Temporal.TemporalUnit> GetUnits()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.Temporal.TemporalUnit>>("getUnits", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#get(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<long>("get", "(Ljava/time/temporal/TemporalUnit;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Period.html#toTotalMonths()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToTotalMonths()
        {
            return IExecuteWithSignature<long>("toTotalMonths", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}