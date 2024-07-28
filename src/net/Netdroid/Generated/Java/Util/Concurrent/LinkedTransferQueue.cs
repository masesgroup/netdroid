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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region LinkedTransferQueue
    public partial class LinkedTransferQueue
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public LinkedTransferQueue(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.LinkedTransferQueue"/> to <see cref="Java.Util.Concurrent.TransferQueue"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.TransferQueue(Java.Util.Concurrent.LinkedTransferQueue t) => t.Cast<Java.Util.Concurrent.TransferQueue>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.LinkedTransferQueue"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.LinkedTransferQueue t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#hasWaitingConsumer()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasWaitingConsumer()
        {
            return IExecuteWithSignature<bool>("hasWaitingConsumer", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#offer(java.lang.Object,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<bool>("offer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#tryTransfer(java.lang.Object,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryTransfer(object arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<bool>("tryTransfer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#tryTransfer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TryTransfer(object arg0)
        {
            return IExecuteWithSignature<bool>("tryTransfer", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public object Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute("poll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#take()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public object Take()
        {
            return IExecuteWithSignature("take", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#drainTo(java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int DrainTo(Java.Util.Collection arg0, int arg1)
        {
            return IExecute<int>("drainTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#drainTo(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="int"/></returns>
        public int DrainTo(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<int>("drainTo", "(Ljava/util/Collection;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#getWaitingConsumerCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWaitingConsumerCount()
        {
            return IExecuteWithSignature<int>("getWaitingConsumerCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#remainingCapacity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RemainingCapacity()
        {
            return IExecuteWithSignature<int>("remainingCapacity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#put(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Put(object arg0)
        {
            IExecuteWithSignature("put", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#transfer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Transfer(object arg0)
        {
            IExecuteWithSignature("transfer", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LinkedTransferQueue<E>
    public partial class LinkedTransferQueue<E> : Java.Util.Concurrent.ITransferQueue<E>, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public LinkedTransferQueue(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.LinkedTransferQueue{E}"/> to <see cref="Java.Util.Concurrent.TransferQueue{E}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.TransferQueue<E>(Java.Util.Concurrent.LinkedTransferQueue<E> t) => t.Cast<Java.Util.Concurrent.TransferQueue<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.LinkedTransferQueue{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.LinkedTransferQueue<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.LinkedTransferQueue{E}"/> to <see cref="Java.Util.Concurrent.LinkedTransferQueue"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.LinkedTransferQueue(Java.Util.Concurrent.LinkedTransferQueue<E> t) => t.Cast<Java.Util.Concurrent.LinkedTransferQueue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#hasWaitingConsumer()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasWaitingConsumer()
        {
            return IExecuteWithSignature<bool>("hasWaitingConsumer", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#offer(java.lang.Object,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(E arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<bool>("offer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#tryTransfer(java.lang.Object,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryTransfer(E arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<bool>("tryTransfer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#tryTransfer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TryTransfer(E arg0)
        {
            return IExecuteWithSignature<bool>("tryTransfer", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><typeparamref name="E"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public E Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<E>("poll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#take()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public E Take()
        {
            return IExecuteWithSignature<E>("take", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#drainTo(java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int DrainTo<Arg0objectSuperE>(Java.Util.Collection<Arg0objectSuperE> arg0, int arg1) where Arg0objectSuperE : E
        {
            return IExecute<int>("drainTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#drainTo(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int DrainTo<Arg0objectSuperE>(Java.Util.Collection<Arg0objectSuperE> arg0) where Arg0objectSuperE : E
        {
            return IExecuteWithSignature<int>("drainTo", "(Ljava/util/Collection;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#getWaitingConsumerCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWaitingConsumerCount()
        {
            return IExecuteWithSignature<int>("getWaitingConsumerCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#remainingCapacity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RemainingCapacity()
        {
            return IExecuteWithSignature<int>("remainingCapacity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#put(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void Put(E arg0)
        {
            IExecuteWithSignature("put", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/LinkedTransferQueue.html#transfer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Transfer(E arg0)
        {
            IExecuteWithSignature("transfer", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}