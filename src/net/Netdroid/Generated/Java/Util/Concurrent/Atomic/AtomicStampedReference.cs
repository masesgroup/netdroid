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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicStampedReference
    public partial class AtomicStampedReference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#%3Cinit%3E(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AtomicStampedReference(object arg0, int arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#getReference()"/> 
        /// </summary>
        public object Reference
        {
            get { return IExecuteWithSignature("getReference", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#getStamp()"/> 
        /// </summary>
        public int Stamp
        {
            get { return IExecuteWithSignature<int>("getStamp", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#attemptStamp(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AttemptStamp(object arg0, int arg1)
        {
            return IExecute<bool>("attemptStamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#compareAndSet(java.lang.Object,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(object arg0, object arg1, int arg2, int arg3)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#weakCompareAndSet(java.lang.Object,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(object arg0, object arg1, int arg2, int arg3)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#get(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(int[] arg0)
        {
            return IExecuteWithSignature("get", "([I)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#set(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Set(object arg0, int arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AtomicStampedReference<V>
    public partial class AtomicStampedReference<V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#%3Cinit%3E(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AtomicStampedReference(V arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicStampedReference{V}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicStampedReference"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicStampedReference(Java.Util.Concurrent.Atomic.AtomicStampedReference<V> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicStampedReference>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#getReference()"/> 
        /// </summary>
        public V Reference
        {
            get { return IExecuteWithSignature<V>("getReference", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#getStamp()"/> 
        /// </summary>
        public int Stamp
        {
            get { return IExecuteWithSignature<int>("getStamp", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#attemptStamp(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AttemptStamp(V arg0, int arg1)
        {
            return IExecute<bool>("attemptStamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#compareAndSet(java.lang.Object,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(V arg0, V arg1, int arg2, int arg3)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#weakCompareAndSet(java.lang.Object,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(V arg0, V arg1, int arg2, int arg3)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#get(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Get(int[] arg0)
        {
            return IExecuteWithSignature<V>("get", "([I)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/atomic/AtomicStampedReference.html#set(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Set(V arg0, int arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}