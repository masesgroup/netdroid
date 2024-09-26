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

namespace Java.Time.Zone
{
    #region ZoneRules declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html"/>
    /// </summary>
    public partial class ZoneRules : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.time.zone.ZoneRules";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ZoneRules() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ZoneRules(params object[] args) : base(args) { }

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

    #region ZoneRules implementation
    public partial class ZoneRules
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#of(java.time.ZoneOffset,java.time.ZoneOffset,java.util.List,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules Of(Java.Time.ZoneOffset arg0, Java.Time.ZoneOffset arg1, Java.Util.List<Java.Time.Zone.ZoneOffsetTransition> arg2, Java.Util.List<Java.Time.Zone.ZoneOffsetTransition> arg3, Java.Util.List<Java.Time.Zone.ZoneOffsetTransitionRule> arg4)
        {
            return SExecuteWithSignature<Java.Time.Zone.ZoneRules>(LocalBridgeClazz, "of", "(Ljava/time/ZoneOffset;Ljava/time/ZoneOffset;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljava/time/zone/ZoneRules;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#of(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules Of(Java.Time.ZoneOffset arg0)
        {
            return SExecuteWithSignature<Java.Time.Zone.ZoneRules>(LocalBridgeClazz, "of", "(Ljava/time/ZoneOffset;)Ljava/time/zone/ZoneRules;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#isDaylightSavings(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDaylightSavings(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<bool>("isDaylightSavings", "(Ljava/time/Instant;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#isFixedOffset()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFixedOffset()
        {
            return IExecuteWithSignature<bool>("isFixedOffset", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#isValidOffset(java.time.LocalDateTime,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidOffset(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1)
        {
            return IExecuteWithSignature<bool>("isValidOffset", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getDaylightSavings(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GetDaylightSavings(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Java.Time.Duration>("getDaylightSavings", "(Ljava/time/Instant;)Ljava/time/Duration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getTransition(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition GetTransition(Java.Time.LocalDateTime arg0)
        {
            return IExecuteWithSignature<Java.Time.Zone.ZoneOffsetTransition>("getTransition", "(Ljava/time/LocalDateTime;)Ljava/time/zone/ZoneOffsetTransition;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#nextTransition(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition NextTransition(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Java.Time.Zone.ZoneOffsetTransition>("nextTransition", "(Ljava/time/Instant;)Ljava/time/zone/ZoneOffsetTransition;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#previousTransition(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public Java.Time.Zone.ZoneOffsetTransition PreviousTransition(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Java.Time.Zone.ZoneOffsetTransition>("previousTransition", "(Ljava/time/Instant;)Ljava/time/zone/ZoneOffsetTransition;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getOffset(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetOffset(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffset", "(Ljava/time/Instant;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getOffset(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetOffset(Java.Time.LocalDateTime arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffset", "(Ljava/time/LocalDateTime;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getStandardOffset(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.ZoneOffset"/></returns>
        public Java.Time.ZoneOffset GetStandardOffset(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Java.Time.ZoneOffset>("getStandardOffset", "(Ljava/time/Instant;)Ljava/time/ZoneOffset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getTransitions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.Zone.ZoneOffsetTransition> GetTransitions()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.Zone.ZoneOffsetTransition>>("getTransitions", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getTransitionRules()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.Zone.ZoneOffsetTransitionRule> GetTransitionRules()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.Zone.ZoneOffsetTransitionRule>>("getTransitionRules", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/zone/ZoneRules.html#getValidOffsets(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Time.ZoneOffset> GetValidOffsets(Java.Time.LocalDateTime arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Time.ZoneOffset>>("getValidOffsets", "(Ljava/time/LocalDateTime;)Ljava/util/List;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}