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
    #region ScheduledFuture declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/ScheduledFuture.html"/>
    /// </summary>
    public partial class ScheduledFuture : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScheduledFuture>
    {
        const string _bridgeClassName = "java.util.concurrent.ScheduledFuture";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ScheduledFuture class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ScheduledFuture() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ScheduledFuture class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ScheduledFuture(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region ScheduledFuture<V> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/ScheduledFuture.html"/>
    /// </summary>
    /// <typeparam name="V"></typeparam>
    public partial class ScheduledFuture<V> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScheduledFuture<V>>
    {
        const string _bridgeClassName = "java.util.concurrent.ScheduledFuture";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ScheduledFuture class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ScheduledFuture() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ScheduledFuture class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ScheduledFuture(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region ScheduledFuture implementation
    public partial class ScheduledFuture
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture"/> to <see cref="Java.Util.Concurrent.Delayed"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Delayed(Java.Util.Concurrent.ScheduledFuture t) => t.Cast<Java.Util.Concurrent.Delayed>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Java.Util.Concurrent.ScheduledFuture t) => t.Cast<Java.Util.Concurrent.Future>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IScheduledFuture<V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScheduledFuture<V>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ScheduledFuture<V> implementation
    public partial class ScheduledFuture<V> : Java.Util.Concurrent.IScheduledFuture<V>, Java.Util.Concurrent.IDelayed, Java.Util.Concurrent.IFuture<V>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.Delayed"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Delayed(Java.Util.Concurrent.ScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.Delayed>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.Future{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future<V>(Java.Util.Concurrent.ScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.Future<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.ScheduledFuture"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ScheduledFuture(Java.Util.Concurrent.ScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.ScheduledFuture>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}