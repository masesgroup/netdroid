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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicIntegerFieldUpdater
    public partial class AtomicIntegerFieldUpdater
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#newUpdater(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater NewUpdater(Java.Lang.Class arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater>(LocalBridgeClazz, "newUpdater", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#compareAndSet(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(object arg0, int arg1, int arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#weakCompareAndSet(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(object arg0, int arg1, int arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(object arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#lazySet(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void LazySet(object arg0, int arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#set(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Set(object arg0, int arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#accumulateAndGet(java.lang.Object,int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int AccumulateAndGet(object arg0, int arg1, Java.Util.Function.IntBinaryOperator arg2)
        {
            return IExecute<int>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndAccumulate(java.lang.Object,int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndAccumulate(object arg0, int arg1, Java.Util.Function.IntBinaryOperator arg2)
        {
            return IExecute<int>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndUpdate(java.lang.Object,java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndUpdate(object arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return IExecute<int>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#updateAndGet(java.lang.Object,java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int UpdateAndGet(object arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return IExecute<int>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#addAndGet(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AddAndGet(object arg0, int arg1)
        {
            return IExecute<int>("addAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#decrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int DecrementAndGet(object arg0)
        {
            return IExecuteWithSignature<int>("decrementAndGet", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndAdd(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndAdd(object arg0, int arg1)
        {
            return IExecute<int>("getAndAdd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndDecrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndDecrement(object arg0)
        {
            return IExecuteWithSignature<int>("getAndDecrement", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndIncrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndIncrement(object arg0)
        {
            return IExecuteWithSignature<int>("getAndIncrement", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndSet(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndSet(object arg0, int arg1)
        {
            return IExecute<int>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#incrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IncrementAndGet(object arg0)
        {
            return IExecuteWithSignature<int>("incrementAndGet", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AtomicIntegerFieldUpdater<T>
    public partial class AtomicIntegerFieldUpdater<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater{T}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater(Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<T> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#newUpdater(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="U"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<U> NewUpdater<U>(Java.Lang.Class arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicIntegerFieldUpdater<U>>(LocalBridgeClazz, "newUpdater", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#compareAndSet(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(T arg0, int arg1, int arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#weakCompareAndSet(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(T arg0, int arg1, int arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(T arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#lazySet(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void LazySet(T arg0, int arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#set(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Set(T arg0, int arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#accumulateAndGet(java.lang.Object,int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int AccumulateAndGet(T arg0, int arg1, Java.Util.Function.IntBinaryOperator arg2)
        {
            return IExecute<int>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndAccumulate(java.lang.Object,int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndAccumulate(T arg0, int arg1, Java.Util.Function.IntBinaryOperator arg2)
        {
            return IExecute<int>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndUpdate(java.lang.Object,java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndUpdate(T arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return IExecute<int>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#updateAndGet(java.lang.Object,java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int UpdateAndGet(T arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return IExecute<int>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#addAndGet(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AddAndGet(T arg0, int arg1)
        {
            return IExecute<int>("addAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#decrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int DecrementAndGet(T arg0)
        {
            return IExecuteWithSignature<int>("decrementAndGet", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndAdd(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndAdd(T arg0, int arg1)
        {
            return IExecute<int>("getAndAdd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndDecrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndDecrement(T arg0)
        {
            return IExecuteWithSignature<int>("getAndDecrement", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndIncrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndIncrement(T arg0)
        {
            return IExecuteWithSignature<int>("getAndIncrement", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndSet(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndSet(T arg0, int arg1)
        {
            return IExecute<int>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#incrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int IncrementAndGet(T arg0)
        {
            return IExecuteWithSignature<int>("incrementAndGet", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}