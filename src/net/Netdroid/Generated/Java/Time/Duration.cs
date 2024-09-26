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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region Duration declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/Duration.html"/>
    /// </summary>
    public partial class Duration : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Duration>
    {
        const string _bridgeClassName = "java.time.Duration";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Duration() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Duration(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Duration implementation
    public partial class Duration : Java.Time.Temporal.ITemporalAmount, Java.Lang.IComparable<Java.Time.Duration>, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Duration"/> to <see cref="Java.Time.Temporal.TemporalAmount"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAmount(Java.Time.Duration t) => t.Cast<Java.Time.Temporal.TemporalAmount>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Duration"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.Duration t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Duration"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Duration t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ZERO"/>
        /// </summary>
        public static Java.Time.Duration ZERO { get { if (!_ZEROReady) { _ZEROContent = SGetField<Java.Time.Duration>(LocalBridgeClazz, "ZERO"); _ZEROReady = true; } return _ZEROContent; } }
        private static Java.Time.Duration _ZEROContent = default;
        private static bool _ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#between(java.time.temporal.Temporal,java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration Between(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.Temporal arg1)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "between", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/Temporal;)Ljava/time/Duration;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#from(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration From(Java.Time.Temporal.TemporalAmount arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#of(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration Of(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "of", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfDays(long arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofDays", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfHours(long arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofHours", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfMillis(long arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofMillis", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfMinutes(long arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofMinutes", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfNanos(long arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofNanos", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofSeconds(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfSeconds(long arg0, long arg1)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofSeconds", "(JJ)Ljava/time/Duration;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#ofSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration OfSeconds(long arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "ofSeconds", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public static Java.Time.Duration Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.Duration>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/Duration;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#isNegative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNegative()
        {
            return IExecuteWithSignature<bool>("isNegative", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#isZero()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsZero()
        {
            return IExecuteWithSignature<bool>("isZero", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#compareTo(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/Duration;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#getNano()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNano()
        {
            return IExecuteWithSignature<int>("getNano", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toHoursPart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToHoursPart()
        {
            return IExecuteWithSignature<int>("toHoursPart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toMillisPart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToMillisPart()
        {
            return IExecuteWithSignature<int>("toMillisPart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toMinutesPart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToMinutesPart()
        {
            return IExecuteWithSignature<int>("toMinutesPart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toNanosPart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToNanosPart()
        {
            return IExecuteWithSignature<int>("toNanosPart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toSecondsPart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToSecondsPart()
        {
            return IExecuteWithSignature<int>("toSecondsPart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#abs()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration Abs()
        {
            return IExecuteWithSignature<Java.Time.Duration>("abs", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#dividedBy(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration DividedBy(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("dividedBy", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minus(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration Minus(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minus", "(Ljava/time/Duration;)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MinusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minusDays", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MinusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minusHours", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minusMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MinusMillis(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minusMillis", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MinusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minusMinutes", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MinusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minusNanos", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MinusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("minusSeconds", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#multipliedBy(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration MultipliedBy(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("multipliedBy", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#negated()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration Negated()
        {
            return IExecuteWithSignature<Java.Time.Duration>("negated", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plus(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration Plus(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plus", "(Ljava/time/Duration;)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration PlusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plusDays", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration PlusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plusHours", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plusMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration PlusMillis(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plusMillis", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration PlusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plusMinutes", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration PlusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plusNanos", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration PlusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("plusSeconds", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#withNanos(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration WithNanos(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("withNanos", "(I)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#withSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration WithSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("withSeconds", "(J)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#addTo(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AddTo(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("addTo", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#subtractFrom(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal SubtractFrom(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("subtractFrom", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#getUnits()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.Temporal.TemporalUnit> GetUnits()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.Temporal.TemporalUnit>>("getUnits", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#dividedBy(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="long"/></returns>
        public long DividedBy(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<long>("dividedBy", "(Ljava/time/Duration;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#get(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<long>("get", "(Ljava/time/temporal/TemporalUnit;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#getSeconds()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSeconds()
        {
            return IExecuteWithSignature<long>("getSeconds", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toDays()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToDays()
        {
            return IExecuteWithSignature<long>("toDays", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toDaysPart()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToDaysPart()
        {
            return IExecuteWithSignature<long>("toDaysPart", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toHours()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToHours()
        {
            return IExecuteWithSignature<long>("toHours", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToMillis()
        {
            return IExecuteWithSignature<long>("toMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toMinutes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToMinutes()
        {
            return IExecuteWithSignature<long>("toMinutes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToNanos()
        {
            return IExecuteWithSignature<long>("toNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Duration.html#toSeconds()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToSeconds()
        {
            return IExecuteWithSignature<long>("toSeconds", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}