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

namespace Java.Util.Function
{
    #region IIntUnaryOperator
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.IntUnaryOperator implementing <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html"/>
    /// </summary>
    public partial interface IIntUnaryOperator
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntUnaryOperator
    public partial class IntUnaryOperator : Java.Util.Function.IIntUnaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#identity()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.IntUnaryOperator Identity()
        {
            return SExecuteWithSignature<Java.Util.Function.IntUnaryOperator>(LocalBridgeClazz, "identity", "()Ljava/util/function/IntUnaryOperator;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="IntUnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsInt", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsIntEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntUnaryOperator>>>(AndThenEventHandler));
            AddEventHandler("compose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntUnaryOperator>>>(ComposeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsInt"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, int> OnApplyAsInt { get; set; } = null;

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnApplyAsInt != null) ? OnApplyAsInt : ApplyAsInt;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int ApplyAsInt(int arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntUnaryOperator AndThenDefault(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperator>("andThenDefault", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntUnaryOperator, Java.Util.Function.IntUnaryOperator> OnAndThen { get; set; } = null;

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntUnaryOperator>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntUnaryOperator AndThen(Java.Util.Function.IntUnaryOperator arg0)
        {
            return AndThenDefault(arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntUnaryOperator ComposeDefault(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperator>("composeDefault", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntUnaryOperator, Java.Util.Function.IntUnaryOperator> OnCompose { get; set; } = null;

        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntUnaryOperator>> data)
        {
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ComposeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntUnaryOperator Compose(Java.Util.Function.IntUnaryOperator arg0)
        {
            return ComposeDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntUnaryOperatorDirect
    public partial class IntUnaryOperatorDirect : Java.Util.Function.IIntUnaryOperator
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
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(int arg0)
        {
            return IExecuteWithSignature<int>("applyAsInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        public override Java.Util.Function.IntUnaryOperator AndThen(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperatorDirect, Java.Util.Function.IntUnaryOperator>("andThen", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        public override Java.Util.Function.IntUnaryOperator Compose(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperatorDirect, Java.Util.Function.IntUnaryOperator>("compose", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}