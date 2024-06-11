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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region Phaser
    public partial class Phaser
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Phaser(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#%3Cinit%3E(java.util.concurrent.Phaser,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Phaser"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public Phaser(Java.Util.Concurrent.Phaser arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#%3Cinit%3E(java.util.concurrent.Phaser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Phaser"/></param>
        public Phaser(Java.Util.Concurrent.Phaser arg0)
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
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#isTerminated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTerminated()
        {
            return IExecuteWithSignature<bool>("isTerminated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#getPhase()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPhase()
        {
            return IExecuteWithSignature<int>("getPhase", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#arrive()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Arrive()
        {
            return IExecuteWithSignature<int>("arrive", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#arriveAndAwaitAdvance()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ArriveAndAwaitAdvance()
        {
            return IExecuteWithSignature<int>("arriveAndAwaitAdvance", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#arriveAndDeregister()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ArriveAndDeregister()
        {
            return IExecuteWithSignature<int>("arriveAndDeregister", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#awaitAdvance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AwaitAdvance(int arg0)
        {
            return IExecuteWithSignature<int>("awaitAdvance", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#awaitAdvanceInterruptibly(int,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public int AwaitAdvanceInterruptibly(int arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<int>("awaitAdvanceInterruptibly", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#awaitAdvanceInterruptibly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public int AwaitAdvanceInterruptibly(int arg0)
        {
            return IExecuteWithSignature<int>("awaitAdvanceInterruptibly", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#bulkRegister(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int BulkRegister(int arg0)
        {
            return IExecuteWithSignature<int>("bulkRegister", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#getArrivedParties()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetArrivedParties()
        {
            return IExecuteWithSignature<int>("getArrivedParties", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#getRegisteredParties()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRegisteredParties()
        {
            return IExecuteWithSignature<int>("getRegisteredParties", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#getUnarrivedParties()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUnarrivedParties()
        {
            return IExecuteWithSignature<int>("getUnarrivedParties", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#register()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Register()
        {
            return IExecuteWithSignature<int>("register", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#getParent()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Phaser"/></returns>
        public Java.Util.Concurrent.Phaser GetParent()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Phaser>("getParent", "()Ljava/util/concurrent/Phaser;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#getRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Phaser"/></returns>
        public Java.Util.Concurrent.Phaser GetRoot()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Phaser>("getRoot", "()Ljava/util/concurrent/Phaser;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/Phaser.html#forceTermination()"/>
        /// </summary>
        public void ForceTermination()
        {
            IExecuteWithSignature("forceTermination", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}