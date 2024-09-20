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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region Executors
    public partial class Executors
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#callable(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<T> Callable<T>(Java.Lang.Runnable arg0, T arg1)
        {
            return SExecute<Java.Util.Concurrent.Callable<T>>(LocalBridgeClazz, "callable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#privilegedCallable(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.Callable<T> PrivilegedCallable<T>(Java.Util.Concurrent.Callable<T> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<T>>(LocalBridgeClazz, "privilegedCallable", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.Callable<T> PrivilegedCallableUsingCurrentClassLoader<T>(Java.Util.Concurrent.Callable<T> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<T>>(LocalBridgeClazz, "privilegedCallableUsingCurrentClassLoader", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#callable(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<object> Callable(Java.Lang.Runnable arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<object>>(LocalBridgeClazz, "callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#callable(java.security.PrivilegedAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<object> Callable(Java.Security.PrivilegedAction<object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<object>>(LocalBridgeClazz, "callable", "(Ljava/security/PrivilegedAction;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#callable(java.security.PrivilegedExceptionAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable<object> Callable(Java.Security.PrivilegedExceptionAction<object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.Callable<object>>(LocalBridgeClazz, "callable", "(Ljava/security/PrivilegedExceptionAction;)Ljava/util/concurrent/Callable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newCachedThreadPool()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewCachedThreadPool()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newCachedThreadPool(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewCachedThreadPool(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newFixedThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewFixedThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newFixedThreadPool", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newFixedThreadPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewFixedThreadPool(int arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newFixedThreadPool", "(I)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newSingleThreadExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewSingleThreadExecutor()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newSingleThreadExecutor", "()Ljava/util/concurrent/ExecutorService;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newSingleThreadExecutor(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewSingleThreadExecutor(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newWorkStealingPool()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewWorkStealingPool()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newWorkStealingPool", "()Ljava/util/concurrent/ExecutorService;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newWorkStealingPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewWorkStealingPool(int arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "newWorkStealingPool", "(I)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#unconfigurableExecutorService(java.util.concurrent.ExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService UnconfigurableExecutorService(Java.Util.Concurrent.ExecutorService arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ExecutorService>(LocalBridgeClazz, "unconfigurableExecutorService", "(Ljava/util/concurrent/ExecutorService;)Ljava/util/concurrent/ExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newScheduledThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewScheduledThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newScheduledThreadPool", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newScheduledThreadPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewScheduledThreadPool(int arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newScheduledThreadPool", "(I)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newSingleThreadScheduledExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewSingleThreadScheduledExecutor()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newSingleThreadScheduledExecutor", "()Ljava/util/concurrent/ScheduledExecutorService;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewSingleThreadScheduledExecutor(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "newSingleThreadScheduledExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService UnconfigurableScheduledExecutorService(Java.Util.Concurrent.ScheduledExecutorService arg0)
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ScheduledExecutorService>(LocalBridgeClazz, "unconfigurableScheduledExecutorService", "(Ljava/util/concurrent/ScheduledExecutorService;)Ljava/util/concurrent/ScheduledExecutorService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#defaultThreadFactory()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ThreadFactory"/></returns>
        public static Java.Util.Concurrent.ThreadFactory DefaultThreadFactory()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ThreadFactory>(LocalBridgeClazz, "defaultThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Executors.html#privilegedThreadFactory()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ThreadFactory"/></returns>
        [global::System.Obsolete()]
        public static Java.Util.Concurrent.ThreadFactory PrivilegedThreadFactory()
        {
            return SExecuteWithSignature<Java.Util.Concurrent.ThreadFactory>(LocalBridgeClazz, "privilegedThreadFactory", "()Ljava/util/concurrent/ThreadFactory;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}