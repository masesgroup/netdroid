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
    #region DayOfWeek declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html"/>
    /// </summary>
    public partial class DayOfWeek : Java.Lang.Enum<Java.Time.DayOfWeek>
    {
        const string _bridgeClassName = "java.time.DayOfWeek";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DayOfWeek() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DayOfWeek(params object[] args) : base(args) { }
    
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

    #region DayOfWeek implementation
    public partial class DayOfWeek : Java.Time.Temporal.ITemporalAccessor, Java.Time.Temporal.ITemporalAdjuster
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.DayOfWeek"/> to <see cref="Java.Time.Temporal.TemporalAccessor"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.DayOfWeek t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        /// <summary>
        /// Converter from <see cref="Java.Time.DayOfWeek"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.DayOfWeek t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#FRIDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek FRIDAY { get { if (!_FRIDAYReady) { _FRIDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "FRIDAY"); _FRIDAYReady = true; } return _FRIDAYContent; } }
        private static Java.Time.DayOfWeek _FRIDAYContent = default;
        private static bool _FRIDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#MONDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek MONDAY { get { if (!_MONDAYReady) { _MONDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "MONDAY"); _MONDAYReady = true; } return _MONDAYContent; } }
        private static Java.Time.DayOfWeek _MONDAYContent = default;
        private static bool _MONDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#SATURDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek SATURDAY { get { if (!_SATURDAYReady) { _SATURDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "SATURDAY"); _SATURDAYReady = true; } return _SATURDAYContent; } }
        private static Java.Time.DayOfWeek _SATURDAYContent = default;
        private static bool _SATURDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#SUNDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek SUNDAY { get { if (!_SUNDAYReady) { _SUNDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "SUNDAY"); _SUNDAYReady = true; } return _SUNDAYContent; } }
        private static Java.Time.DayOfWeek _SUNDAYContent = default;
        private static bool _SUNDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#THURSDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek THURSDAY { get { if (!_THURSDAYReady) { _THURSDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "THURSDAY"); _THURSDAYReady = true; } return _THURSDAYContent; } }
        private static Java.Time.DayOfWeek _THURSDAYContent = default;
        private static bool _THURSDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#TUESDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek TUESDAY { get { if (!_TUESDAYReady) { _TUESDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "TUESDAY"); _TUESDAYReady = true; } return _TUESDAYContent; } }
        private static Java.Time.DayOfWeek _TUESDAYContent = default;
        private static bool _TUESDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#WEDNESDAY"/>
        /// </summary>
        public static Java.Time.DayOfWeek WEDNESDAY { get { if (!_WEDNESDAYReady) { _WEDNESDAYContent = SGetField<Java.Time.DayOfWeek>(LocalBridgeClazz, "WEDNESDAY"); _WEDNESDAYReady = true; } return _WEDNESDAYContent; } }
        private static Java.Time.DayOfWeek _WEDNESDAYContent = default;
        private static bool _WEDNESDAYReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.DayOfWeek>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/DayOfWeek;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek Of(int arg0)
        {
            return SExecuteWithSignature<Java.Time.DayOfWeek>(LocalBridgeClazz, "of", "(I)Ljava/time/DayOfWeek;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.DayOfWeek>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/DayOfWeek;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public static Java.Time.DayOfWeek[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.DayOfWeek>(LocalBridgeClazz, "values", "()[Ljava/time/DayOfWeek;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetValue()
        {
            return IExecuteWithSignature<int>("getValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#minus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek Minus(long arg0)
        {
            return IExecuteWithSignature<Java.Time.DayOfWeek>("minus", "(J)Ljava/time/DayOfWeek;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#plus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek Plus(long arg0)
        {
            return IExecuteWithSignature<Java.Time.DayOfWeek>("plus", "(J)Ljava/time/DayOfWeek;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/DayOfWeek.html#getLong(java.time.temporal.TemporalField)"/>
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