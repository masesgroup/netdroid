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

namespace Java.Util.Function
{
    #region BiPredicate declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html"/>
    /// </summary>
    public partial class BiPredicate : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BiPredicate() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.BiPredicate";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region BiPredicateDirect declaration
    /// <summary>
    /// Direct override of <see cref="BiPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class BiPredicateDirect : BiPredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.BiPredicate";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region BiPredicate<T, U> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public partial class BiPredicate<T, U> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BiPredicate() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.BiPredicate";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region BiPredicateDirect<T, U> declaration
    /// <summary>
    /// Direct override of <see cref="BiPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class BiPredicateDirect<T, U> : BiPredicate<T, U>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.BiPredicate";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region BiPredicate implementation
    public partial class BiPredicate
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="BiPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndEventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OrEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object, object, bool> OnTest { get; set; } = null;
        
        bool hasOverrideTest = true;
        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideTest = true;
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<object>(0), data.EventData.GetAt<object>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideTest, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(object arg0, object arg1)
        {
            hasOverrideTest = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate AndDefault(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate>("andDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate, Java.Util.Function.BiPredicate> OnAnd { get; set; } = null;
        
        bool hasOverrideAnd = true;
        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAnd = true;
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.BiPredicate>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAnd, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate And(Java.Util.Function.BiPredicate arg0)
        {
            hasOverrideAnd = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate>("negateDefault", "()Ljava/util/function/BiPredicate;");
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate> OnNegate { get; set; } = null;
        
        bool hasOverrideNegate = true;
        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideNegate = true;
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideNegate, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate Negate()
        {
            hasOverrideNegate = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate OrDefault(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate>("orDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate, Java.Util.Function.BiPredicate> OnOr { get; set; } = null;
        
        bool hasOverrideOr = true;
        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOr = true;
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.BiPredicate>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOr, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate Or(Java.Util.Function.BiPredicate arg0)
        {
            hasOverrideOr = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region BiPredicateDirect implementation
    public partial class BiPredicateDirect
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(object arg0, object arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate And(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("and", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("negate", "()Ljava/util/function/BiPredicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate Or(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("or", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IBiPredicate<T, U>
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.BiPredicate implementing <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html"/>
    /// </summary>
    public partial interface IBiPredicate<T, U>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region BiPredicate<T, U> implementation
    public partial class BiPredicate<T, U> : Java.Util.Function.IBiPredicate<T, U>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="BiPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(And<Arg0objectSuperT, Arg0objectSuperU>EventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(Or<Arg0objectSuperT, Arg0objectSuperU>EventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<T, U, bool> OnTest { get; set; } = null;
        
        bool hasOverrideTest = true;
        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideTest = true;
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<T>(0), data.EventData.GetAt<U>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideTest, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(T arg0, U arg1)
        {
            hasOverrideTest = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>Default(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate<T, U>>("andDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd<Arg0objectSuperT, Arg0objectSuperU>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>, Java.Util.Function.BiPredicate<T, U>> OnAnd<Arg0objectSuperT, Arg0objectSuperU> { get; set; } = null;
        
        bool hasOverrideAnd<Arg0objectSuperT, Arg0objectSuperU> = true;
        void And<Arg0objectSuperT, Arg0objectSuperU>EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAnd<Arg0objectSuperT, Arg0objectSuperU> = true;
            var methodToExecute = (OnAnd<Arg0objectSuperT, Arg0objectSuperU> != null) ? OnAnd<Arg0objectSuperT, Arg0objectSuperU> : And<Arg0objectSuperT, Arg0objectSuperU>;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAnd<Arg0objectSuperT, Arg0objectSuperU>, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="And<Arg0objectSuperT, Arg0objectSuperU>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            hasOverrideAnd<Arg0objectSuperT, Arg0objectSuperU> = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate<T, U> NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate<T, U>>("negateDefault", "()Ljava/util/function/BiPredicate;");
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate<T, U>> OnNegate { get; set; } = null;
        
        bool hasOverrideNegate = true;
        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideNegate = true;
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideNegate, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate<T, U> Negate()
        {
            hasOverrideNegate = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>Default(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicate<T, U>>("orDefault", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr<Arg0objectSuperT, Arg0objectSuperU>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>, Java.Util.Function.BiPredicate<T, U>> OnOr<Arg0objectSuperT, Arg0objectSuperU> { get; set; } = null;
        
        bool hasOverrideOr<Arg0objectSuperT, Arg0objectSuperU> = true;
        void Or<Arg0objectSuperT, Arg0objectSuperU>EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOr<Arg0objectSuperT, Arg0objectSuperU> = true;
            var methodToExecute = (OnOr<Arg0objectSuperT, Arg0objectSuperU> != null) ? OnOr<Arg0objectSuperT, Arg0objectSuperU> : Or<Arg0objectSuperT, Arg0objectSuperU>;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOr<Arg0objectSuperT, Arg0objectSuperU>, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="Or<Arg0objectSuperT, Arg0objectSuperU>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            hasOverrideOr<Arg0objectSuperT, Arg0objectSuperU> = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region BiPredicateDirect<T, U> implementation
    public partial class BiPredicateDirect<T, U> : Java.Util.Function.IBiPredicate<T, U>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(T arg0, U arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("and", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate<T, U> Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("negate", "()Ljava/util/function/BiPredicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public override Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("or", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}