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

namespace Java.Time.Format
{
    #region DateTimeFormatterBuilder
    public partial class DateTimeFormatterBuilder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#getLocalizedDateTimePattern(java.time.format.FormatStyle,java.time.format.FormatStyle,java.time.chrono.Chronology,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <param name="arg2"><see cref="Java.Time.Chrono.Chronology"/></param>
        /// <param name="arg3"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetLocalizedDateTimePattern(Java.Time.Format.FormatStyle arg0, Java.Time.Format.FormatStyle arg1, Java.Time.Chrono.Chronology arg2, Java.Util.Locale arg3)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getLocalizedDateTimePattern", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#toFormatter()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter ToFormatter()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("toFormatter", "()Ljava/time/format/DateTimeFormatter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#toFormatter(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatter"/></returns>
        public Java.Time.Format.DateTimeFormatter ToFormatter(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatter>("toFormatter", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#append(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder Append(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("append", "(Ljava/time/format/DateTimeFormatter;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendChronologyId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendChronologyId()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendChronologyId", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendChronologyText(java.time.format.TextStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendChronologyText(Java.Time.Format.TextStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendChronologyText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendDayPeriodText(java.time.format.TextStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendDayPeriodText(Java.Time.Format.TextStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendDayPeriodText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendFraction(java.time.temporal.TemporalField,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendFraction(Java.Time.Temporal.TemporalField arg0, int arg1, int arg2, bool arg3)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendFraction", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendGenericZoneText(java.time.format.TextStyle,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendGenericZoneText(Java.Time.Format.TextStyle arg0, Java.Util.Set<Java.Time.ZoneId> arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendGenericZoneText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendGenericZoneText(java.time.format.TextStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendGenericZoneText(Java.Time.Format.TextStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendGenericZoneText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendInstant()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendInstant()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendInstant", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendInstant(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendInstant(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendInstant", "(I)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendLiteral(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendLiteral(char arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendLiteral", "(C)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendLiteral(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendLiteral(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendLiteral", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendLocalized(java.time.format.FormatStyle,java.time.format.FormatStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.FormatStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendLocalized(Java.Time.Format.FormatStyle arg0, Java.Time.Format.FormatStyle arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendLocalized", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendLocalizedOffset(java.time.format.TextStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendLocalizedOffset(Java.Time.Format.TextStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendLocalizedOffset", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendOffset(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendOffset(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendOffsetId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendOffsetId()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendOffsetId", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendOptional(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendOptional(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendOptional", "(Ljava/time/format/DateTimeFormatter;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendPattern(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendPattern", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendText(java.time.temporal.TemporalField,java.time.format.TextStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendText(Java.Time.Temporal.TemporalField arg0, Java.Time.Format.TextStyle arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendText(java.time.temporal.TemporalField,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendText(Java.Time.Temporal.TemporalField arg0, Java.Util.Map<Java.Lang.Long, Java.Lang.String> arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendText(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendText(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendText", "(Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendValue(java.time.temporal.TemporalField,int,int,java.time.format.SignStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Time.Format.SignStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendValue(Java.Time.Temporal.TemporalField arg0, int arg1, int arg2, Java.Time.Format.SignStyle arg3)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendValue", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendValue(java.time.temporal.TemporalField,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendValue(Java.Time.Temporal.TemporalField arg0, int arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendValue(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendValue(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendValue", "(Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendValueReduced(java.time.temporal.TemporalField,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendValueReduced(Java.Time.Temporal.TemporalField arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendValueReduced", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendValueReduced(java.time.temporal.TemporalField,int,int,java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendValueReduced(Java.Time.Temporal.TemporalField arg0, int arg1, int arg2, Java.Time.Chrono.ChronoLocalDate arg3)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendValueReduced", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendZoneId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendZoneId()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendZoneId", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendZoneOrOffsetId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendZoneOrOffsetId()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendZoneOrOffsetId", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendZoneRegionId()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendZoneRegionId()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendZoneRegionId", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendZoneText(java.time.format.TextStyle,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendZoneText(Java.Time.Format.TextStyle arg0, Java.Util.Set<Java.Time.ZoneId> arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("appendZoneText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#appendZoneText(java.time.format.TextStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder AppendZoneText(Java.Time.Format.TextStyle arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("appendZoneText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#optionalEnd()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder OptionalEnd()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("optionalEnd", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#optionalStart()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder OptionalStart()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("optionalStart", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#padNext(int,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder PadNext(int arg0, char arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("padNext", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#padNext(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder PadNext(int arg0)
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("padNext", "(I)Ljava/time/format/DateTimeFormatterBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#parseCaseInsensitive()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder ParseCaseInsensitive()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("parseCaseInsensitive", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#parseCaseSensitive()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder ParseCaseSensitive()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("parseCaseSensitive", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#parseDefaulting(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder ParseDefaulting(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Format.DateTimeFormatterBuilder>("parseDefaulting", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#parseLenient()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder ParseLenient()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("parseLenient", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/format/DateTimeFormatterBuilder.html#parseStrict()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Format.DateTimeFormatterBuilder"/></returns>
        public Java.Time.Format.DateTimeFormatterBuilder ParseStrict()
        {
            return IExecuteWithSignature<Java.Time.Format.DateTimeFormatterBuilder>("parseStrict", "()Ljava/time/format/DateTimeFormatterBuilder;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}