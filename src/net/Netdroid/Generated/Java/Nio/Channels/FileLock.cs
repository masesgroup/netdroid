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

namespace Java.Nio.Channels
{
    #region FileLock
    public partial class FileLock
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
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#release()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#isShared()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShared()
        {
            return IExecuteWithSignature<bool>("isShared", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#overlaps(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Overlaps(long arg0, long arg1)
        {
            return IExecute<bool>("overlaps", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#channel()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.FileChannel"/></returns>
        public Java.Nio.Channels.FileChannel Channel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.FileChannel>("channel", "()Ljava/nio/channels/FileChannel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#position()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Position()
        {
            return IExecuteWithSignature<long>("position", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/FileLock.html#acquiredBy()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.Channel"/></returns>
        public Java.Nio.Channels.Channel AcquiredBy()
        {
            return IExecuteWithSignature<Java.Nio.Channels.Channel>("acquiredBy", "()Ljava/nio/channels/Channel;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}