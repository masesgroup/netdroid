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

namespace Java.Util.Concurrent
{
    #region TimeUnit declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html"/>
    /// </summary>
    public partial class TimeUnit : Java.Lang.Enum<Java.Util.Concurrent.TimeUnit>
    {
        const string _bridgeClassName = "java.util.concurrent.TimeUnit";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimeUnit() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimeUnit(params object[] args) : base(args) { }

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

    #region TimeUnit implementation
    public partial class TimeUnit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#DAYS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit DAYS { get { if (!_DAYSReady) { _DAYSContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "DAYS"); _DAYSReady = true; } return _DAYSContent; } }
        private static Java.Util.Concurrent.TimeUnit _DAYSContent = default;
        private static bool _DAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#HOURS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit HOURS { get { if (!_HOURSReady) { _HOURSContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "HOURS"); _HOURSReady = true; } return _HOURSContent; } }
        private static Java.Util.Concurrent.TimeUnit _HOURSContent = default;
        private static bool _HOURSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#MICROSECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit MICROSECONDS { get { if (!_MICROSECONDSReady) { _MICROSECONDSContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "MICROSECONDS"); _MICROSECONDSReady = true; } return _MICROSECONDSContent; } }
        private static Java.Util.Concurrent.TimeUnit _MICROSECONDSContent = default;
        private static bool _MICROSECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#MILLISECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit MILLISECONDS { get { if (!_MILLISECONDSReady) { _MILLISECONDSContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "MILLISECONDS"); _MILLISECONDSReady = true; } return _MILLISECONDSContent; } }
        private static Java.Util.Concurrent.TimeUnit _MILLISECONDSContent = default;
        private static bool _MILLISECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#MINUTES"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit MINUTES { get { if (!_MINUTESReady) { _MINUTESContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "MINUTES"); _MINUTESReady = true; } return _MINUTESContent; } }
        private static Java.Util.Concurrent.TimeUnit _MINUTESContent = default;
        private static bool _MINUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#NANOSECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit NANOSECONDS { get { if (!_NANOSECONDSReady) { _NANOSECONDSContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "NANOSECONDS"); _NANOSECONDSReady = true; } return _NANOSECONDSContent; } }
        private static Java.Util.Concurrent.TimeUnit _NANOSECONDSContent = default;
        private static bool _NANOSECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#SECONDS"/>
        /// </summary>
        public static Java.Util.Concurrent.TimeUnit SECONDS { get { if (!_SECONDSReady) { _SECONDSContent = SGetField<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "SECONDS"); _SECONDSReady = true; } return _SECONDSContent; } }
        private static Java.Util.Concurrent.TimeUnit _SECONDSContent = default;
        private static bool _SECONDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#of(java.time.temporal.ChronoUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.ChronoUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.TimeUnit"/></returns>
        public static Java.Util.Concurrent.TimeUnit Of(Java.Time.Temporal.ChronoUnit arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "of", "(Ljava/time/temporal/ChronoUnit;)Ljava/util/concurrent/TimeUnit;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Concurrent.TimeUnit"/></returns>
        public static Java.Util.Concurrent.TimeUnit ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.TimeUnit"/></returns>
        public static Java.Util.Concurrent.TimeUnit[] Values()
        {
            return SExecuteWithSignatureArray<Java.Util.Concurrent.TimeUnit>(LocalBridgeClazz, "values", "()[Ljava/util/concurrent/TimeUnit;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toChronoUnit()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Temporal.ChronoUnit"/></returns>
        public Java.Time.Temporal.ChronoUnit ToChronoUnit()
        {
            return IExecuteWithSignature<Java.Time.Temporal.ChronoUnit>("toChronoUnit", "()Ljava/time/temporal/ChronoUnit;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#convert(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="long"/></returns>
        public long Convert(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<long>("convert", "(Ljava/time/Duration;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#convert(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Convert(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<long>("convert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToDays(long arg0)
        {
            return IExecuteWithSignature<long>("toDays", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToHours(long arg0)
        {
            return IExecuteWithSignature<long>("toHours", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toMicros(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToMicros(long arg0)
        {
            return IExecuteWithSignature<long>("toMicros", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToMillis(long arg0)
        {
            return IExecuteWithSignature<long>("toMillis", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToMinutes(long arg0)
        {
            return IExecuteWithSignature<long>("toMinutes", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToNanos(long arg0)
        {
            return IExecuteWithSignature<long>("toNanos", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#toSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToSeconds(long arg0)
        {
            return IExecuteWithSignature<long>("toSeconds", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#sleep(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Sleep(long arg0)
        {
            IExecuteWithSignature("sleep", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#timedJoin(java.lang.Thread,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void TimedJoin(Java.Lang.Thread arg0, long arg1)
        {
            IExecute("timedJoin", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/TimeUnit.html#timedWait(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void TimedWait(object arg0, long arg1)
        {
            IExecute("timedWait", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}