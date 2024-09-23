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
    #region Clock declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/Clock.html"/>
    /// </summary>
    public partial class Clock : Java.Time.InstantSource
    {
        const string _bridgeClassName = "java.time.Clock";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Clock class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Clock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Clock class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Clock(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region Clock implementation
    public partial class Clock
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#fixed(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock Fixed(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.Clock>(LocalBridgeClazz, "fixed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#offset(java.time.Clock,java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock Offset(Java.Time.Clock arg0, Java.Time.Duration arg1)
        {
            return SExecute<Java.Time.Clock>(LocalBridgeClazz, "offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#system(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock System(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "system", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#systemDefaultZone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock SystemDefaultZone()
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "systemDefaultZone", "()Ljava/time/Clock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#systemUTC()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock SystemUTC()
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "systemUTC", "()Ljava/time/Clock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#tick(java.time.Clock,java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock Tick(Java.Time.Clock arg0, Java.Time.Duration arg1)
        {
            return SExecute<Java.Time.Clock>(LocalBridgeClazz, "tick", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#tickMillis(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock TickMillis(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "tickMillis", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#tickMinutes(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock TickMinutes(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "tickMinutes", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#tickSeconds(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock TickSeconds(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "tickSeconds", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#withZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public Java.Time.Clock WithZone(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Clock>("withZone", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#instant()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant Instant()
        {
            return IExecuteWithSignature<Java.Time.Instant>("instant", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#getZone()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public Java.Time.ZoneId GetZone()
        {
            return IExecuteWithSignature<Java.Time.ZoneId>("getZone", "()Ljava/time/ZoneId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Clock.html#millis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Millis()
        {
            return IExecuteWithSignature<long>("millis", "()J");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}