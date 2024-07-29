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

namespace Java.Util.Concurrent.Locks
{
    #region ILock
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILock
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Lock
    public partial class Lock : Java.Util.Concurrent.Locks.ILock
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
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/Lock.html#tryLock()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TryLock()
        {
            return IExecuteWithSignature<bool>("tryLock", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/Lock.html#tryLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("tryLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/Lock.html#newCondition()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Locks.Condition"/></returns>
        public Java.Util.Concurrent.Locks.Condition NewCondition()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Locks.Condition>("newCondition", "()Ljava/util/concurrent/locks/Condition;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/Lock.html#lock()"/>
        /// </summary>
        public void LockMethod()
        {
            IExecuteWithSignature("lock", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/Lock.html#lockInterruptibly()"/>
        /// </summary>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void LockInterruptibly()
        {
            IExecuteWithSignature("lockInterruptibly", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/Lock.html#unlock()"/>
        /// </summary>
        public void Unlock()
        {
            IExecuteWithSignature("unlock", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}