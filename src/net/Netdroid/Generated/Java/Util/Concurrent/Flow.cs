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
    #region Flow
    public partial class Flow
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.html#defaultBufferSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int DefaultBufferSize()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "defaultBufferSize", "()I");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Processor
        public partial class Processor
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Processor<T, R>
        public partial class Processor<T, R>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Flow.Processor{T, R}"/> to <see cref="Java.Util.Concurrent.Flow.Processor"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Flow.Processor(Java.Util.Concurrent.Flow.Processor<T, R> t) => t.Cast<Java.Util.Concurrent.Flow.Processor>();

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

        #region Publisher
        public partial class Publisher
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
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Publisher.html#subscribe(java.util.concurrent.Flow.Subscriber)"/>
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

        #region Publisher<T>
        public partial class Publisher<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Flow.Publisher{T}"/> to <see cref="Java.Util.Concurrent.Flow.Publisher"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Flow.Publisher(Java.Util.Concurrent.Flow.Publisher<T> t) => t.Cast<Java.Util.Concurrent.Flow.Publisher>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Publisher.html#subscribe(java.util.concurrent.Flow.Subscriber)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscriber"/></param>
            /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
            public void Subscribe<Arg0objectSuperT>(Java.Util.Concurrent.Flow.Subscriber<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
            {
                IExecuteWithSignature("subscribe", "(Ljava/util/concurrent/Flow$Subscriber;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Subscriber
        public partial class Subscriber
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
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onComplete()"/>
            /// </summary>
            public void OnComplete()
            {
                IExecuteWithSignature("onComplete", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onError(java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
            public void OnError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                IExecuteWithSignature("onError", "(Ljava/lang/Throwable;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onNext(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void OnNext(object arg0)
            {
                IExecuteWithSignature("onNext", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onSubscribe(java.util.concurrent.Flow.Subscription)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscription"/></param>
            public void OnSubscribe(Java.Util.Concurrent.Flow.Subscription arg0)
            {
                IExecuteWithSignature("onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Subscriber<T>
        public partial class Subscriber<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Flow.Subscriber{T}"/> to <see cref="Java.Util.Concurrent.Flow.Subscriber"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Flow.Subscriber(Java.Util.Concurrent.Flow.Subscriber<T> t) => t.Cast<Java.Util.Concurrent.Flow.Subscriber>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onComplete()"/>
            /// </summary>
            public void OnComplete()
            {
                IExecuteWithSignature("onComplete", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onError(java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
            public void OnError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                IExecuteWithSignature("onError", "(Ljava/lang/Throwable;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onNext(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="T"/></param>
            public void OnNext(T arg0)
            {
                IExecuteWithSignature("onNext", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscriber.html#onSubscribe(java.util.concurrent.Flow.Subscription)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Flow.Subscription"/></param>
            public void OnSubscribe(Java.Util.Concurrent.Flow.Subscription arg0)
            {
                IExecuteWithSignature("onSubscribe", "(Ljava/util/concurrent/Flow$Subscription;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Subscription
        public partial class Subscription
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
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscription.html#cancel()"/>
            /// </summary>
            public void Cancel()
            {
                IExecuteWithSignature("cancel", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/Flow.Subscription.html#request(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void Request(long arg0)
            {
                IExecuteWithSignature("request", "(J)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}