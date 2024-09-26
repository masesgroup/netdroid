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
    #region SubmissionPublisher declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html"/>
    /// </summary>
    public partial class SubmissionPublisher : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SubmissionPublisher>
    {
        const string _bridgeClassName = "java.util.concurrent.SubmissionPublisher";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SubmissionPublisher() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SubmissionPublisher(params object[] args) : base(args) { }

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

    #region SubmissionPublisher<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class SubmissionPublisher<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SubmissionPublisher<T>>
    {
        const string _bridgeClassName = "java.util.concurrent.SubmissionPublisher";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SubmissionPublisher() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SubmissionPublisher(params object[] args) : base(args) { }

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

    #region SubmissionPublisher implementation
    public partial class SubmissionPublisher
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1, Java.Util.Function.BiConsumer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.SubmissionPublisher"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Util.Concurrent.SubmissionPublisher t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#hasSubscribers()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSubscribers()
        {
            return IExecuteWithSignature<bool>("hasSubscribers", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#isSubscribed(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubscribed(Java.Util.Concurrent.Flow.Subscriber arg0)
        {
            return IExecuteWithSignature<bool>("isSubscribed", "(Ljava/util/concurrent/Flow$Subscriber;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#estimateMaximumLag()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int EstimateMaximumLag()
        {
            return IExecuteWithSignature<int>("estimateMaximumLag", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getMaxBufferCapacity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxBufferCapacity()
        {
            return IExecuteWithSignature<int>("getMaxBufferCapacity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getNumberOfSubscribers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNumberOfSubscribers()
        {
            return IExecuteWithSignature<int>("getNumberOfSubscribers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="int"/></returns>
        public int Offer(object arg0, Java.Util.Function.BiPredicate arg1)
        {
            return IExecuteWithSignature<int>("offer", "(Ljava/lang/Object;Ljava/util/function/BiPredicate;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,long,java.util.concurrent.TimeUnit,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="int"/></returns>
        public int Offer(object arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, Java.Util.Function.BiPredicate arg3)
        {
            return IExecuteWithSignature<int>("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;Ljava/util/function/BiPredicate;)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#submit(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Submit(object arg0)
        {
            return IExecuteWithSignature<int>("submit", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getClosedException()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Throwable"/></returns>
        public Java.Lang.Throwable GetClosedException()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getClosedException", "()Ljava/lang/Throwable;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#consume(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture Consume(Java.Util.Function.Consumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletableFuture>("consume", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Executor"/></returns>
        public Java.Util.Concurrent.Executor GetExecutor()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Executor>("getExecutor", "()Ljava/util/concurrent/Executor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getSubscribers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List GetSubscribers()
        {
            return IExecuteWithSignature<Java.Util.List>("getSubscribers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#estimateMinimumDemand()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long EstimateMinimumDemand()
        {
            return IExecuteWithSignature<long>("estimateMinimumDemand", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#closeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CloseExceptionally(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("closeExceptionally", "(Ljava/lang/Throwable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#subscribe(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        public void Subscribe(Java.Util.Concurrent.Flow.Subscriber arg0)
        {
            IExecuteWithSignature("subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SubmissionPublisher<T> implementation
    public partial class SubmissionPublisher<T> : Java.Lang.IAutoCloseable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1, Java.Util.Function.BiConsumer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#%3Cinit%3E(java.util.concurrent.Executor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public SubmissionPublisher(Java.Util.Concurrent.Executor arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.SubmissionPublisher{T}"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Util.Concurrent.SubmissionPublisher<T> t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.SubmissionPublisher{T}"/> to <see cref="Java.Util.Concurrent.SubmissionPublisher"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.SubmissionPublisher(Java.Util.Concurrent.SubmissionPublisher<T> t) => t.Cast<Java.Util.Concurrent.SubmissionPublisher>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#hasSubscribers()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSubscribers()
        {
            return IExecuteWithSignature<bool>("hasSubscribers", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#isSubscribed(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool IsSubscribed<Arg0objectSuperT>(Java.Util.Concurrent.Flow.Subscriber<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<bool>("isSubscribed", "(Ljava/util/concurrent/Flow$Subscriber;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#estimateMaximumLag()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int EstimateMaximumLag()
        {
            return IExecuteWithSignature<int>("estimateMaximumLag", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getMaxBufferCapacity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxBufferCapacity()
        {
            return IExecuteWithSignature<int>("getMaxBufferCapacity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getNumberOfSubscribers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNumberOfSubscribers()
        {
            return IExecuteWithSignature<int>("getNumberOfSubscribers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg1objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int Offer<Arg1objectSuperT>(T arg0, Java.Util.Function.BiPredicate<Java.Util.Concurrent.Flow.Subscriber<Arg1objectSuperT>, Arg1objectSuperT> arg1) where Arg1objectSuperT : T
        {
            return IExecuteWithSignature<int>("offer", "(Ljava/lang/Object;Ljava/util/function/BiPredicate;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#offer(java.lang.Object,long,java.util.concurrent.TimeUnit,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg3objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int Offer<Arg3objectSuperT>(T arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2, Java.Util.Function.BiPredicate<Java.Util.Concurrent.Flow.Subscriber<Arg3objectSuperT>, Arg3objectSuperT> arg3) where Arg3objectSuperT : T
        {
            return IExecuteWithSignature<int>("offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;Ljava/util/function/BiPredicate;)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#submit(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int Submit(T arg0)
        {
            return IExecuteWithSignature<int>("submit", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getClosedException()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Throwable"/></returns>
        public Java.Lang.Throwable GetClosedException()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getClosedException", "()Ljava/lang/Throwable;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#consume(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.Void> Consume<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletableFuture<Java.Lang.Void>>("consume", "(Ljava/util/function/Consumer;)Ljava/util/concurrent/CompletableFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Executor"/></returns>
        public Java.Util.Concurrent.Executor GetExecutor()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Executor>("getExecutor", "()Ljava/util/concurrent/Executor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#getSubscribers()"/>
        /// </summary>
        /// <typeparam name="ReturnobjectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Util.Concurrent.Flow.Subscriber<ReturnobjectSuperT>> GetSubscribers<ReturnobjectSuperT>() where ReturnobjectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.List<Java.Util.Concurrent.Flow.Subscriber<ReturnobjectSuperT>>>("getSubscribers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#estimateMinimumDemand()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long EstimateMinimumDemand()
        {
            return IExecuteWithSignature<long>("estimateMinimumDemand", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#closeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CloseExceptionally(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("closeExceptionally", "(Ljava/lang/Throwable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/SubmissionPublisher.html#subscribe(java.util.concurrent.Flow.Subscriber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void Subscribe<Arg0objectSuperT>(Java.Util.Concurrent.Flow.Subscriber<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            IExecuteWithSignature("subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}