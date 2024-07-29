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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
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

    #region IntPredicate
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
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>>>(AndEventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>>>(OrEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, bool> OnTest { get; set; } = null;

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(int arg0)
        {
            return default;
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

        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>> data)
        {
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntPredicate And(Java.Util.Function.IntPredicate arg0)
        {
            return AndDefault(arg0);
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

        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntPredicate Negate()
        {
            return NegateDefault();
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

        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntPredicate>> data)
        {
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntPredicate Or(Java.Util.Function.IntPredicate arg0)
        {
            return OrDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntPredicateDirect
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