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

namespace Android.Os
{
    #region StatFs
    public partial class StatFs
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public StatFs(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getAvailableBlocks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetAvailableBlocks()
        {
            return IExecuteWithSignature<int>("getAvailableBlocks", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getBlockCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetBlockCount()
        {
            return IExecuteWithSignature<int>("getBlockCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getBlockSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetBlockSize()
        {
            return IExecuteWithSignature<int>("getBlockSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getFreeBlocks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetFreeBlocks()
        {
            return IExecuteWithSignature<int>("getFreeBlocks", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getAvailableBlocksLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAvailableBlocksLong()
        {
            return IExecuteWithSignature<long>("getAvailableBlocksLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getAvailableBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAvailableBytes()
        {
            return IExecuteWithSignature<long>("getAvailableBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getBlockCountLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetBlockCountLong()
        {
            return IExecuteWithSignature<long>("getBlockCountLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getBlockSizeLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetBlockSizeLong()
        {
            return IExecuteWithSignature<long>("getBlockSizeLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getFreeBlocksLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetFreeBlocksLong()
        {
            return IExecuteWithSignature<long>("getFreeBlocksLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getFreeBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetFreeBytes()
        {
            return IExecuteWithSignature<long>("getFreeBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#getTotalBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTotalBytes()
        {
            return IExecuteWithSignature<long>("getTotalBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/StatFs.html#restat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Restat(Java.Lang.String arg0)
        {
            IExecuteWithSignature("restat", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}