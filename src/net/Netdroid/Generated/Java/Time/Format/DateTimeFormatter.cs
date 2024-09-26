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

namespace Java.Time.Format
{
    #region DateTimeFormatter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html"/>
    /// </summary>
    public partial class DateTimeFormatter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DateTimeFormatter>
    {
        const string _bridgeClassName = "java.time.format.DateTimeFormatter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DateTimeFormatter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DateTimeFormatter(params object[] args) : base(args) { }

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

    #region DateTimeFormatter implementation
    public partial class DateTimeFormatter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#BASIC_ISO_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter BASIC_ISO_DATE { get { if (!_BASIC_ISO_DATEReady) { _BASIC_ISO_DATEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "BASIC_ISO_DATE"); _BASIC_ISO_DATEReady = true; } return _BASIC_ISO_DATEContent; } }
        private static Java.Time.Format.DateTimeFormatter _BASIC_ISO_DATEContent = default;
        private static bool _BASIC_ISO_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_DATE { get { if (!_ISO_DATEReady) { _ISO_DATEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_DATE"); _ISO_DATEReady = true; } return _ISO_DATEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_DATEContent = default;
        private static bool _ISO_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_DATE_TIME { get { if (!_ISO_DATE_TIMEReady) { _ISO_DATE_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_DATE_TIME"); _ISO_DATE_TIMEReady = true; } return _ISO_DATE_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_DATE_TIMEContent = default;
        private static bool _ISO_DATE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_INSTANT"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_INSTANT { get { if (!_ISO_INSTANTReady) { _ISO_INSTANTContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_INSTANT"); _ISO_INSTANTReady = true; } return _ISO_INSTANTContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_INSTANTContent = default;
        private static bool _ISO_INSTANTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_LOCAL_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_LOCAL_DATE { get { if (!_ISO_LOCAL_DATEReady) { _ISO_LOCAL_DATEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_LOCAL_DATE"); _ISO_LOCAL_DATEReady = true; } return _ISO_LOCAL_DATEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_LOCAL_DATEContent = default;
        private static bool _ISO_LOCAL_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_LOCAL_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_LOCAL_DATE_TIME { get { if (!_ISO_LOCAL_DATE_TIMEReady) { _ISO_LOCAL_DATE_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_LOCAL_DATE_TIME"); _ISO_LOCAL_DATE_TIMEReady = true; } return _ISO_LOCAL_DATE_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_LOCAL_DATE_TIMEContent = default;
        private static bool _ISO_LOCAL_DATE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_LOCAL_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_LOCAL_TIME { get { if (!_ISO_LOCAL_TIMEReady) { _ISO_LOCAL_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_LOCAL_TIME"); _ISO_LOCAL_TIMEReady = true; } return _ISO_LOCAL_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_LOCAL_TIMEContent = default;
        private static bool _ISO_LOCAL_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_OFFSET_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_OFFSET_DATE { get { if (!_ISO_OFFSET_DATEReady) { _ISO_OFFSET_DATEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_OFFSET_DATE"); _ISO_OFFSET_DATEReady = true; } return _ISO_OFFSET_DATEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_OFFSET_DATEContent = default;
        private static bool _ISO_OFFSET_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_OFFSET_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_OFFSET_DATE_TIME { get { if (!_ISO_OFFSET_DATE_TIMEReady) { _ISO_OFFSET_DATE_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_OFFSET_DATE_TIME"); _ISO_OFFSET_DATE_TIMEReady = true; } return _ISO_OFFSET_DATE_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_OFFSET_DATE_TIMEContent = default;
        private static bool _ISO_OFFSET_DATE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_OFFSET_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_OFFSET_TIME { get { if (!_ISO_OFFSET_TIMEReady) { _ISO_OFFSET_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_OFFSET_TIME"); _ISO_OFFSET_TIMEReady = true; } return _ISO_OFFSET_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_OFFSET_TIMEContent = default;
        private static bool _ISO_OFFSET_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_ORDINAL_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_ORDINAL_DATE { get { if (!_ISO_ORDINAL_DATEReady) { _ISO_ORDINAL_DATEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_ORDINAL_DATE"); _ISO_ORDINAL_DATEReady = true; } return _ISO_ORDINAL_DATEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_ORDINAL_DATEContent = default;
        private static bool _ISO_ORDINAL_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_TIME { get { if (!_ISO_TIMEReady) { _ISO_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_TIME"); _ISO_TIMEReady = true; } return _ISO_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_TIMEContent = default;
        private static bool _ISO_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_WEEK_DATE"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_WEEK_DATE { get { if (!_ISO_WEEK_DATEReady) { _ISO_WEEK_DATEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_WEEK_DATE"); _ISO_WEEK_DATEReady = true; } return _ISO_WEEK_DATEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_WEEK_DATEContent = default;
        private static bool _ISO_WEEK_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ISO_ZONED_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter ISO_ZONED_DATE_TIME { get { if (!_ISO_ZONED_DATE_TIMEReady) { _ISO_ZONED_DATE_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ISO_ZONED_DATE_TIME"); _ISO_ZONED_DATE_TIMEReady = true; } return _ISO_ZONED_DATE_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _ISO_ZONED_DATE_TIMEContent = default;
        private static bool _ISO_ZONED_DATE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#RFC_1123_DATE_TIME"/>
        /// </summary>
        public static Java.Time.Format.DateTimeFormatter RFC_1123_DATE_TIME { get { if (!_RFC_1123_DATE_TIMEReady) { _RFC_1123_DATE_TIMEContent = SGetField<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "RFC_1123_DATE_TIME"); _RFC_1123_DATE_TIMEReady = true; } return _RFC_1123_DATE_TIMEContent; } }
        private static Java.Time.Format.DateTimeFormatter _RFC_1123_DATE_TIMEContent = default;
        private static bool _RFC_1123_DATE_TIMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parsedLeapSecond()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Lang.Boolean> ParsedLeapSecond()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Lang.Boolean>>(LocalBridgeClazz, "parsedLeapSecond", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parsedExcessDays()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.TemporalQuery"/></returns>
        public static Java.Time.Temporal.TemporalQuery<Java.Time.Period> ParsedExcessDays()
        {
            return SExecuteWithSignature<Java.Time.Temporal.TemporalQuery<Java.Time.Period>>(LocalBridgeClazz, "parsedExcessDays", "()Ljava/time/temporal/TemporalQuery;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ofLocalizedDate(java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedDate(Java.Time.Format.FormatStyle arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ofLocalizedDate", "(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ofLocalizedDateTime(java.time.format.FormatStyle,java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedDateTime(Java.Time.Format.FormatStyle arg0, Java.Time.Format.FormatStyle arg1)
        {
            return SExecuteWithSignature<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ofLocalizedDateTime", "(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ofLocalizedDateTime(java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedDateTime(Java.Time.Format.FormatStyle arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ofLocalizedDateTime", "(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ofLocalizedTime(java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfLocalizedTime(Java.Time.Format.FormatStyle arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ofLocalizedTime", "(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ofPattern(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfPattern(Java.Lang.String arg0, Java.Util.Locale arg1)
        {
            return SExecuteWithSignature<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ofPattern", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#ofPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public static Java.Time.Format.DateTimeFormatter OfPattern(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Format.DateTimeFormatter>(LocalBridgeClazz, "ofPattern", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatter;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parse(java.lang.CharSequence,java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Parse<T>(Java.Lang.CharSequence arg0, Java.Time.Temporal.TemporalQuery<T> arg1)
        {
            return IExecuteWithSignature<T>("parse", "(Ljava/lang/CharSequence;Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#format(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/temporal/TemporalAccessor;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#toFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format ToFormat()
        {
            return IExecuteWithSignature<Java.Text.Format>("toFormat", "()Ljava/text/Format;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#toFormat(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format ToFormat(Java.Time.Temporal.TemporalQuery<object> arg0)
        {
            return IExecuteWithSignature<Java.Text.Format>("toFormat", "(Ljava/time/temporal/TemporalQuery;)Ljava/text/Format;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#getChronology()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public Java.Time.Chrono.Chronology GetChronology()
        {
            return IExecuteWithSignature<Java.Time.Chrono.Chronology>("getChronology", "()Ljava/time/chrono/Chronology;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#localizedBy(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter LocalizedBy(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("localizedBy", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withChronology(java.time.chrono.Chronology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithChronology(Java.Time.Chrono.Chronology arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withChronology", "(Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withDecimalStyle(java.time.format.DecimalStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DecimalStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithDecimalStyle(Java.Time.Format.DecimalStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withDecimalStyle", "(Ljava/time/format/DecimalStyle;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithLocale(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withLocale", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withResolverFields(java.time.temporal.TemporalField[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithResolverFields(params Java.Time.Temporal.TemporalField[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withResolverFields", "([Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatter;"); else return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withResolverFields", "([Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withResolverFields(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithResolverFields(Java.Util.Set<Java.Time.Temporal.TemporalField> arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withResolverFields", "(Ljava/util/Set;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withResolverStyle(java.time.format.ResolverStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.ResolverStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithResolverStyle(Java.Time.Format.ResolverStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withResolverStyle", "(Ljava/time/format/ResolverStyle;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#withZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter WithZone(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("withZone", "(Ljava/time/ZoneId;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#getDecimalStyle()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DecimalStyle"/></returns>
        public Java.Time.Format.DecimalStyle GetDecimalStyle()
        {
            return IExecuteWithSignature<Java.Time.Format.DecimalStyle>("getDecimalStyle", "()Ljava/time/format/DecimalStyle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#getResolverStyle()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.ResolverStyle"/></returns>
        public Java.Time.Format.ResolverStyle GetResolverStyle()
        {
            return IExecuteWithSignature<Java.Time.Format.ResolverStyle>("getResolverStyle", "()Ljava/time/format/ResolverStyle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parse(java.lang.CharSequence,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor Parse(Java.Lang.CharSequence arg0, Java.Text.ParsePosition arg1)
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalAccessor>("parse", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor Parse(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalAccessor>("parse", "(Ljava/lang/CharSequence;)Ljava/time/temporal/TemporalAccessor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parseBest(java.lang.CharSequence,java.time.temporal.TemporalQuery[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor ParseBest(Java.Lang.CharSequence arg0, params Java.Time.Temporal.TemporalQuery<object>[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Time.Temporal.TemporalAccessor>("parseBest", "(Ljava/lang/CharSequence;[Ljava/time/temporal/TemporalQuery;)Ljava/time/temporal/TemporalAccessor;", arg0); else return IExecuteWithSignature<Java.Time.Temporal.TemporalAccessor>("parseBest", "(Ljava/lang/CharSequence;[Ljava/time/temporal/TemporalQuery;)Ljava/time/temporal/TemporalAccessor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#parseUnresolved(java.lang.CharSequence,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Time.Temporal.TemporalAccessor"/></returns>
        public Java.Time.Temporal.TemporalAccessor ParseUnresolved(Java.Lang.CharSequence arg0, Java.Text.ParsePosition arg1)
        {
            return IExecuteWithSignature<Java.Time.Temporal.TemporalAccessor>("parseUnresolved", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#getZone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public Java.Time.ZoneId GetZone()
        {
            return IExecuteWithSignature<Java.Time.ZoneId>("getZone", "()Ljava/time/ZoneId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#getResolverFields()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Time.Temporal.TemporalField> GetResolverFields()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Time.Temporal.TemporalField>>("getResolverFields", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatter.html#formatTo(java.time.temporal.TemporalAccessor,java.lang.Appendable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Appendable"/></param>
        public void FormatTo(Java.Time.Temporal.TemporalAccessor arg0, Java.Lang.Appendable arg1)
        {
            IExecuteWithSignature("formatTo", "(Ljava/time/temporal/TemporalAccessor;Ljava/lang/Appendable;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}