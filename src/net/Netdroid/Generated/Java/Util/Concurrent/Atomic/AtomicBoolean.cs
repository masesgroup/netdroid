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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicBoolean
    public partial class AtomicBoolean
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public AtomicBoolean(bool arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#weakCompareAndSet(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool WeakCompareAndSet(bool arg0, bool arg1)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#weakCompareAndSetPlain(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(bool arg0, bool arg1)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#compareAndExchange(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndExchange(bool arg0, bool arg1)
        {
            return IExecute<bool>("compareAndExchange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#compareAndExchangeAcquire(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndExchangeAcquire(bool arg0, bool arg1)
        {
            return IExecute<bool>("compareAndExchangeAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#compareAndExchangeRelease(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndExchangeRelease(bool arg0, bool arg1)
        {
            return IExecute<bool>("compareAndExchangeRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#compareAndSet(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(bool arg0, bool arg1)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#get()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Get()
        {
            return IExecuteWithSignature<bool>("get", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#getAcquire()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAcquire()
        {
            return IExecuteWithSignature<bool>("getAcquire", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#getAndSet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetAndSet(bool arg0)
        {
            return IExecuteWithSignature<bool>("getAndSet", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#getOpaque()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetOpaque()
        {
            return IExecuteWithSignature<bool>("getOpaque", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#getPlain()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetPlain()
        {
            return IExecuteWithSignature<bool>("getPlain", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#weakCompareAndSetAcquire(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(bool arg0, bool arg1)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#weakCompareAndSetRelease(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(bool arg0, bool arg1)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#weakCompareAndSetVolatile(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetVolatile(bool arg0, bool arg1)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#lazySet(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void LazySet(bool arg0)
        {
            IExecuteWithSignature("lazySet", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#set(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Set(bool arg0)
        {
            IExecuteWithSignature("set", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#setOpaque(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOpaque(bool arg0)
        {
            IExecuteWithSignature("setOpaque", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#setPlain(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPlain(bool arg0)
        {
            IExecuteWithSignature("setPlain", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/atomic/AtomicBoolean.html#setRelease(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRelease(bool arg0)
        {
            IExecuteWithSignature("setRelease", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}