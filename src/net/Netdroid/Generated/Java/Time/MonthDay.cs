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
    #region MonthDay declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/MonthDay.html"/>
    /// </summary>
    public partial class MonthDay : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MonthDay>
    {
        const string _bridgeClassName = "java.time.MonthDay";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MonthDay() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MonthDay(params object[] args) : base(args) { }
    
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

    #region MonthDay implementation
    public partial class MonthDay : Java.Time.Temporal.ITemporalAccessor, Java.Time.Temporal.ITemporalAdjuster, Java.Lang.IComparable<Java.Time.MonthDay>, Java.Io.ISerializable
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Time.Temporal.TemporalAccessor"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.MonthDay t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.MonthDay t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.MonthDay t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.MonthDay"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.MonthDay t) => t.Cast<Java.Io.Serializable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.MonthDay>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/MonthDay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Now()
        {
            return SExecuteWithSignature<Java.Time.MonthDay>(LocalBridgeClazz, "now", "()Ljava/time/MonthDay;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.MonthDay>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/MonthDay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.MonthDay>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/MonthDay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#of(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Of(int arg0, int arg1)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#of(java.time.Month,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Month"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Of(Java.Time.Month arg0, int arg1)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.MonthDay>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public static Java.Time.MonthDay Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.MonthDay>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/MonthDay;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#isAfter(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.MonthDay arg0)
        {
            return IExecuteWithSignature<bool>("isAfter", "(Ljava/time/MonthDay;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#isBefore(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.MonthDay arg0)
        {
            return IExecuteWithSignature<bool>("isBefore", "(Ljava/time/MonthDay;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#isValidYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidYear(int arg0)
        {
            return IExecuteWithSignature<bool>("isValidYear", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#compareTo(java.time.MonthDay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.MonthDay"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.MonthDay arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/MonthDay;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#getDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfMonth()
        {
            return IExecuteWithSignature<int>("getDayOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#getMonthValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonthValue()
        {
            return IExecuteWithSignature<int>("getMonthValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#atYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate AtYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("atYear", "(I)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month GetMonth()
        {
            return IExecuteWithSignature<Java.Time.Month>("getMonth", "()Ljava/time/Month;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#with(java.time.Month)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Month"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public Java.Time.MonthDay With(Java.Time.Month arg0)
        {
            return IExecuteWithSignature<Java.Time.MonthDay>("with", "(Ljava/time/Month;)Ljava/time/MonthDay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public Java.Time.MonthDay WithDayOfMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.MonthDay>("withDayOfMonth", "(I)Ljava/time/MonthDay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.MonthDay"/></returns>
        public Java.Time.MonthDay WithMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.MonthDay>("withMonth", "(I)Ljava/time/MonthDay;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/MonthDay.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}