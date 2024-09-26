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
    #region IntPredicate declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html"/>
    /// </summary>
    public partial class IntPredicate : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IntPredicate() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.IntPredicate";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region IntPredicateDirect declaration
    /// <summary>
    /// Direct override of <see cref="IntPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class IntPredicateDirect : IntPredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.function.IntPredicate";
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

    #region IIntPredicate
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.IntPredicate implementing <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html"/>
    /// </summary>
    public partial interface IIntPredicate
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntPredicate implementation
    public partial class IntPredicate : Java.Util.Function.IIntPredicate
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
        /// Handlers initializer for <see cref="IntPredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndEventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OrEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, bool> OnTest { get; set; } = null;

        bool hasOverrideTest = true;
        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideTest = true;
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideTest, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(int arg0)
        {
            hasOverrideTest = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntPredicate AndDefault(Java.Util.Function.IntPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicate>("andDefault", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntPredicate, Java.Util.Function.IntPredicate> OnAnd { get; set; } = null;

        bool hasOverrideAnd = true;
        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAnd = true;
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.IntPredicate>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAnd, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntPredicate And(Java.Util.Function.IntPredicate arg0)
        {
            hasOverrideAnd = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntPredicate NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicate>("negateDefault", "()Ljava/util/function/IntPredicate;");
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntPredicate> OnNegate { get; set; } = null;

        bool hasOverrideNegate = true;
        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideNegate = true;
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideNegate, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntPredicate Negate()
        {
            hasOverrideNegate = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntPredicate OrDefault(Java.Util.Function.IntPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicate>("orDefault", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntPredicate, Java.Util.Function.IntPredicate> OnOr { get; set; } = null;

        bool hasOverrideOr = true;
        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOr = true;
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.IntPredicate>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOr, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntPredicate Or(Java.Util.Function.IntPredicate arg0)
        {
            hasOverrideOr = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntPredicateDirect implementation
    public partial class IntPredicateDirect : Java.Util.Function.IIntPredicate
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
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(int arg0)
        {
            return IExecuteWithSignature<bool>("test", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public override Java.Util.Function.IntPredicate And(Java.Util.Function.IntPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicateDirect, Java.Util.Function.IntPredicate>("and", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public override Java.Util.Function.IntPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicateDirect, Java.Util.Function.IntPredicate>("negate", "()Ljava/util/function/IntPredicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public override Java.Util.Function.IntPredicate Or(Java.Util.Function.IntPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicateDirect, Java.Util.Function.IntPredicate>("or", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}