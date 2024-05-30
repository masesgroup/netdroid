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

namespace Java.Util.Concurrent
{
    #region ForkJoinTask
    public partial class ForkJoinTask
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Java.Util.Concurrent.ForkJoinTask t) => t.Cast<Java.Util.Concurrent.Future>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ForkJoinTask t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getPool()"/> 
        /// </summary>
        public static Java.Util.Concurrent.ForkJoinPool Pool
        {
            get { return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinPool>(LocalBridgeClazz, "getPool", "()Ljava/util/concurrent/ForkJoinPool;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getQueuedTaskCount()"/> 
        /// </summary>
        public static int QueuedTaskCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getQueuedTaskCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getSurplusQueuedTaskCount()"/> 
        /// </summary>
        public static int SurplusQueuedTaskCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getSurplusQueuedTaskCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public static Java.Util.Collection InvokeAll(Java.Util.Collection arg0)
        {
            return SExecuteWithSignature<Java.Util.Collection>(LocalBridgeClazz, "invokeAll", "(Ljava/util/Collection;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask Adapt(Java.Lang.Runnable arg0, object arg1)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask>(LocalBridgeClazz, "adapt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask Adapt(Java.Util.Concurrent.Callable arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask>(LocalBridgeClazz, "adapt", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#inForkJoinPool()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool InForkJoinPool()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "inForkJoinPool", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask Adapt(Java.Lang.Runnable arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask>(LocalBridgeClazz, "adapt", "(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#helpQuiesce()"/>
        /// </summary>
        public static void HelpQuiesce()
        {
            SExecuteWithSignature(LocalBridgeClazz, "helpQuiesce", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask,java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public static void InvokeAll(Java.Util.Concurrent.ForkJoinTask arg0, Java.Util.Concurrent.ForkJoinTask arg1)
        {
            SExecute(LocalBridgeClazz, "invokeAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public static void InvokeAll(params Java.Util.Concurrent.ForkJoinTask[] arg0)
        {
            if (arg0.Length == 0) SExecuteWithSignature(LocalBridgeClazz, "invokeAll", "([Ljava/util/concurrent/ForkJoinTask;)V"); else SExecuteWithSignature(LocalBridgeClazz, "invokeAll", "([Ljava/util/concurrent/ForkJoinTask;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getException()"/> 
        /// </summary>
        public Java.Lang.Throwable Exception
        {
            get { var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException", "()Ljava/lang/Throwable;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getForkJoinTaskTag()"/> 
        /// </summary>
        public short ForkJoinTaskTag
        {
            get { return IExecuteWithSignature<short>("getForkJoinTaskTag", "()S"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getRawResult()"/> 
        /// </summary>
        public object RawResult
        {
            get { return IExecuteWithSignature("getRawResult", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#cancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#tryUnfork()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TryUnfork()
        {
            return IExecuteWithSignature<bool>("tryUnfork", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#compareAndSetForkJoinTaskTag(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetForkJoinTaskTag(short arg0, short arg1)
        {
            return IExecute<bool>("compareAndSetForkJoinTaskTag", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedAbnormally()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletedAbnormally()
        {
            return IExecuteWithSignature<bool>("isCompletedAbnormally", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedNormally()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletedNormally()
        {
            return IExecuteWithSignature<bool>("isCompletedNormally", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#fork()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public Java.Util.Concurrent.ForkJoinTask Fork()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask>("fork", "()Ljava/util/concurrent/ForkJoinTask;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#setForkJoinTaskTag(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public short SetForkJoinTaskTag(short arg0)
        {
            return IExecuteWithSignature<short>("setForkJoinTaskTag", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public object Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invoke()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Invoke()
        {
            return IExecuteWithSignature("invoke", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#join()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Join()
        {
            return IExecuteWithSignature("join", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#quietlyComplete()"/>
        /// </summary>
        public void QuietlyComplete()
        {
            IExecuteWithSignature("quietlyComplete", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#quietlyInvoke()"/>
        /// </summary>
        public void QuietlyInvoke()
        {
            IExecuteWithSignature("quietlyInvoke", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#quietlyJoin()"/>
        /// </summary>
        public void QuietlyJoin()
        {
            IExecuteWithSignature("quietlyJoin", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#complete(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Complete(object arg0)
        {
            IExecuteWithSignature("complete", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#completeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CompleteExceptionally(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("completeExceptionally", "(Ljava/lang/Throwable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#reinitialize()"/>
        /// </summary>
        public void Reinitialize()
        {
            IExecuteWithSignature("reinitialize", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ForkJoinTask<V>
    public partial class ForkJoinTask<V> : Java.Util.Concurrent.IFuture<V>, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask{V}"/> to <see cref="Java.Util.Concurrent.Future{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future<V>(Java.Util.Concurrent.ForkJoinTask<V> t) => t.Cast<Java.Util.Concurrent.Future<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask{V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ForkJoinTask<V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ForkJoinTask{V}"/> to <see cref="Java.Util.Concurrent.ForkJoinTask"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ForkJoinTask(Java.Util.Concurrent.ForkJoinTask<V> t) => t.Cast<Java.Util.Concurrent.ForkJoinTask>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getPool()"/> 
        /// </summary>
        public static Java.Util.Concurrent.ForkJoinPool Pool
        {
            get { return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinPool>(LocalBridgeClazz, "getPool", "()Ljava/util/concurrent/ForkJoinPool;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getQueuedTaskCount()"/> 
        /// </summary>
        public static int QueuedTaskCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getQueuedTaskCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getSurplusQueuedTaskCount()"/> 
        /// </summary>
        public static int SurplusQueuedTaskCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getSurplusQueuedTaskCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public static Java.Util.Collection<T> InvokeAll<T>(Java.Util.Collection<T> arg0)
        {
            return SExecuteWithSignature<Java.Util.Collection<T>>(LocalBridgeClazz, "invokeAll", "(Ljava/util/Collection;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask<T> Adapt<T>(Java.Lang.Runnable arg0, T arg1)
        {
            return SExecute<Java.Util.Concurrent.ForkJoinTask<T>>(LocalBridgeClazz, "adapt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask<T> Adapt<T, Arg0ExtendsT>(Java.Util.Concurrent.Callable<Arg0ExtendsT> arg0) where Arg0ExtendsT: T
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask<T>>(LocalBridgeClazz, "adapt", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#inForkJoinPool()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool InForkJoinPool()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "inForkJoinPool", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#adapt(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public static Java.Util.Concurrent.ForkJoinTask<object> Adapt(Java.Lang.Runnable arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask<object>>(LocalBridgeClazz, "adapt", "(Ljava/lang/Runnable;)Ljava/util/concurrent/ForkJoinTask;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#helpQuiesce()"/>
        /// </summary>
        public static void HelpQuiesce()
        {
            SExecuteWithSignature(LocalBridgeClazz, "helpQuiesce", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask,java.util.concurrent.ForkJoinTask)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public static void InvokeAll(Java.Util.Concurrent.ForkJoinTask<object> arg0, Java.Util.Concurrent.ForkJoinTask<object> arg1)
        {
            SExecute(LocalBridgeClazz, "invokeAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invokeAll(java.util.concurrent.ForkJoinTask[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ForkJoinTask"/></param>
        public static void InvokeAll(params Java.Util.Concurrent.ForkJoinTask<object>[] arg0)
        {
            if (arg0.Length == 0) SExecuteWithSignature(LocalBridgeClazz, "invokeAll", "([Ljava/util/concurrent/ForkJoinTask;)V"); else SExecuteWithSignature(LocalBridgeClazz, "invokeAll", "([Ljava/util/concurrent/ForkJoinTask;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getException()"/> 
        /// </summary>
        public Java.Lang.Throwable Exception
        {
            get { var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getException", "()Ljava/lang/Throwable;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Lang.Throwable>(obj); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getForkJoinTaskTag()"/> 
        /// </summary>
        public short ForkJoinTaskTag
        {
            get { return IExecuteWithSignature<short>("getForkJoinTaskTag", "()S"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#getRawResult()"/> 
        /// </summary>
        public V RawResult
        {
            get { return IExecuteWithSignature<V>("getRawResult", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#cancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#tryUnfork()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TryUnfork()
        {
            return IExecuteWithSignature<bool>("tryUnfork", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#compareAndSetForkJoinTaskTag(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetForkJoinTaskTag(short arg0, short arg1)
        {
            return IExecute<bool>("compareAndSetForkJoinTaskTag", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedAbnormally()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletedAbnormally()
        {
            return IExecuteWithSignature<bool>("isCompletedAbnormally", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isCompletedNormally()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletedNormally()
        {
            return IExecuteWithSignature<bool>("isCompletedNormally", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#isDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#fork()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinTask"/></returns>
        public Java.Util.Concurrent.ForkJoinTask<V> Fork()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ForkJoinTask<V>>("fork", "()Ljava/util/concurrent/ForkJoinTask;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#setForkJoinTaskTag(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public short SetForkJoinTaskTag(short arg0)
        {
            return IExecuteWithSignature<short>("setForkJoinTaskTag", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="V"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public V Get()
        {
            return IExecuteWithSignature<V>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#get(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><typeparamref name="V"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public V Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<V>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#invoke()"/>
        /// </summary>
        /// <returns><typeparamref name="V"/></returns>
        public V Invoke()
        {
            return IExecuteWithSignature<V>("invoke", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#join()"/>
        /// </summary>
        /// <returns><typeparamref name="V"/></returns>
        public V Join()
        {
            return IExecuteWithSignature<V>("join", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#quietlyComplete()"/>
        /// </summary>
        public void QuietlyComplete()
        {
            IExecuteWithSignature("quietlyComplete", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#quietlyInvoke()"/>
        /// </summary>
        public void QuietlyInvoke()
        {
            IExecuteWithSignature("quietlyInvoke", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#quietlyJoin()"/>
        /// </summary>
        public void QuietlyJoin()
        {
            IExecuteWithSignature("quietlyJoin", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#complete(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public void Complete(V arg0)
        {
            IExecuteWithSignature("complete", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#completeExceptionally(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void CompleteExceptionally(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("completeExceptionally", "(Ljava/lang/Throwable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/ForkJoinTask.html#reinitialize()"/>
        /// </summary>
        public void Reinitialize()
        {
            IExecuteWithSignature("reinitialize", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}