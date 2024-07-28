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
    #region ForkJoinWorkerThread
    public partial class ForkJoinWorkerThread
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
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ForkJoinWorkerThread.html#getPoolIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPoolIndex()
        {
            return IExecuteWithSignature<int>("getPoolIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ForkJoinWorkerThread.html#getPool()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ForkJoinPool"/></returns>
        public Java.Util.Concurrent.ForkJoinPool GetPool()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ForkJoinPool>("getPool", "()Ljava/util/concurrent/ForkJoinPool;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}