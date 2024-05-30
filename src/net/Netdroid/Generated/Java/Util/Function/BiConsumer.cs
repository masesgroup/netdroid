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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region BiConsumer
    public partial class BiConsumer
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
        /// Handlers initializer for <see cref="BiConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(AcceptEventHandler));
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer>>>(AndThenEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<object, object> OnAccept { get; set; } = null;

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public virtual void Accept(object arg0, object arg1)
        {
            
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiConsumer AndThenDefault(Java.Util.Function.BiConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumer>("andThenDefault", "(Ljava/util/function/BiConsumer;)Ljava/util/function/BiConsumer;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.BiConsumer, Java.Util.Function.BiConsumer> OnAndThen { get; set; } = null;

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer>> data)
        {
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiConsumer AndThen(Java.Util.Function.BiConsumer arg0)
        {
            return AndThenDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiConsumerDirect
    public partial class BiConsumerDirect
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public override void Accept(object arg0, object arg1)
        {
            IExecute("accept", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public override Java.Util.Function.BiConsumer AndThen(Java.Util.Function.BiConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumerDirect, Java.Util.Function.BiConsumer>("andThen", "(Ljava/util/function/BiConsumer;)Ljava/util/function/BiConsumer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBiConsumer<T, U>
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.BiConsumer implementing <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html"/>
    /// </summary>
    public partial interface IBiConsumer<T, U>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        void Accept(T arg0, U arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        Java.Util.Function.BiConsumer<T, U> AndThen<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT: T where Arg0objectSuperU: U;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiConsumer<T, U>
    public partial class BiConsumer<T, U> : Java.Util.Function.IBiConsumer<T, U>
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
        /// Handlers initializer for <see cref="BiConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(AcceptEventHandler));
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU>>>>(AndThen<Arg0objectSuperT, Arg0objectSuperU>EventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<T, U> OnAccept { get; set; } = null;

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<U>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        public virtual void Accept(T arg0, U arg1)
        {
            
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.BiConsumer<T, U> AndThen<Arg0objectSuperT, Arg0objectSuperU>Default(Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT: T where Arg0objectSuperU: U
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumer<T, U>>("andThenDefault", "(Ljava/util/function/BiConsumer;)Ljava/util/function/BiConsumer;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen<Arg0objectSuperT, Arg0objectSuperU>"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU>, Java.Util.Function.BiConsumer<T, U>> OnAndThen<Arg0objectSuperT, Arg0objectSuperU> { get; set; } = null;

        void AndThen<Arg0objectSuperT, Arg0objectSuperU>EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU>>> data)
        {
            var methodToExecute = (OnAndThen<Arg0objectSuperT, Arg0objectSuperU> != null) ? OnAndThen<Arg0objectSuperT, Arg0objectSuperU> : AndThen<Arg0objectSuperT, Arg0objectSuperU>;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThen<Arg0objectSuperT, Arg0objectSuperU>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.BiConsumer<T, U> AndThen<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT: T where Arg0objectSuperU: U
        {
            return AndThen<Arg0objectSuperT, Arg0objectSuperU>Default(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BiConsumerDirect<T, U>
    public partial class BiConsumerDirect<T, U> : Java.Util.Function.IBiConsumer<T, U>
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#accept(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        public override void Accept(T arg0, U arg1)
        {
            IExecute("accept", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/function/BiConsumer.html#andThen(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public override Java.Util.Function.BiConsumer<T, U> AndThen<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiConsumer<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT: T where Arg0objectSuperU: U
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumerDirect<T, U>, Java.Util.Function.BiConsumer<T, U>>("andThen", "(Ljava/util/function/BiConsumer;)Ljava/util/function/BiConsumer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}