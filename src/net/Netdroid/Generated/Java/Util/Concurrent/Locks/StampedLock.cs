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

namespace Java.Util.Concurrent.Locks
{
    #region StampedLock declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html"/>
    /// </summary>
    public partial class StampedLock : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.util.concurrent.locks.StampedLock";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StampedLock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StampedLock(params object[] args) : base(args) { }
    
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

    #region StampedLock implementation
    public partial class StampedLock
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#isLockStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLockStamp(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isLockStamp", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#isOptimisticReadStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsOptimisticReadStamp(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isOptimisticReadStamp", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#isReadLockStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsReadLockStamp(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isReadLockStamp", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#isWriteLockStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsWriteLockStamp(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isWriteLockStamp", "(J)Z", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#isReadLocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadLocked()
        {
            return IExecuteWithSignature<bool>("isReadLocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#isWriteLocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWriteLocked()
        {
            return IExecuteWithSignature<bool>("isWriteLocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryUnlockRead()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TryUnlockRead()
        {
            return IExecuteWithSignature<bool>("tryUnlockRead", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryUnlockWrite()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TryUnlockWrite()
        {
            return IExecuteWithSignature<bool>("tryUnlockWrite", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#validate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Validate(long arg0)
        {
            return IExecuteWithSignature<bool>("validate", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#getReadLockCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReadLockCount()
        {
            return IExecuteWithSignature<int>("getReadLockCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#asReadLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Locks.Lock"/></returns>
        public Java.Util.Concurrent.Locks.Lock AsReadLock()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Locks.Lock>("asReadLock", "()Ljava/util/concurrent/locks/Lock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#asWriteLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Locks.Lock"/></returns>
        public Java.Util.Concurrent.Locks.Lock AsWriteLock()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Locks.Lock>("asWriteLock", "()Ljava/util/concurrent/locks/Lock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#asReadWriteLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Locks.ReadWriteLock"/></returns>
        public Java.Util.Concurrent.Locks.ReadWriteLock AsReadWriteLock()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Locks.ReadWriteLock>("asReadWriteLock", "()Ljava/util/concurrent/locks/ReadWriteLock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#readLock()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ReadLock()
        {
            return IExecuteWithSignature<long>("readLock", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#readLockInterruptibly()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long ReadLockInterruptibly()
        {
            return IExecuteWithSignature<long>("readLockInterruptibly", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryConvertToOptimisticRead(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TryConvertToOptimisticRead(long arg0)
        {
            return IExecuteWithSignature<long>("tryConvertToOptimisticRead", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryConvertToReadLock(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TryConvertToReadLock(long arg0)
        {
            return IExecuteWithSignature<long>("tryConvertToReadLock", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryConvertToWriteLock(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TryConvertToWriteLock(long arg0)
        {
            return IExecuteWithSignature<long>("tryConvertToWriteLock", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryOptimisticRead()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TryOptimisticRead()
        {
            return IExecuteWithSignature<long>("tryOptimisticRead", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryReadLock()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TryReadLock()
        {
            return IExecuteWithSignature<long>("tryReadLock", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryReadLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long TryReadLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<long>("tryReadLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryWriteLock()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TryWriteLock()
        {
            return IExecuteWithSignature<long>("tryWriteLock", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#tryWriteLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long TryWriteLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<long>("tryWriteLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#writeLock()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long WriteLock()
        {
            return IExecuteWithSignature<long>("writeLock", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#writeLockInterruptibly()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long WriteLockInterruptibly()
        {
            return IExecuteWithSignature<long>("writeLockInterruptibly", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#unlock(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Unlock(long arg0)
        {
            IExecuteWithSignature("unlock", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#unlockRead(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void UnlockRead(long arg0)
        {
            IExecuteWithSignature("unlockRead", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/StampedLock.html#unlockWrite(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void UnlockWrite(long arg0)
        {
            IExecuteWithSignature("unlockWrite", "(J)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}