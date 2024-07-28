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

namespace Android.Util
{
    #region AtomicFile
    public partial class AtomicFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public AtomicFile(Java.Io.File arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#readFully()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] ReadFully()
        {
            return IExecuteWithSignatureArray<byte>("readFully", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#getBaseFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File GetBaseFile()
        {
            return IExecuteWithSignature<Java.Io.File>("getBaseFile", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#openRead()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileInputStream"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Io.FileInputStream OpenRead()
        {
            return IExecuteWithSignature<Java.Io.FileInputStream>("openRead", "()Ljava/io/FileInputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#startWrite()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileOutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.FileOutputStream StartWrite()
        {
            return IExecuteWithSignature<Java.Io.FileOutputStream>("startWrite", "()Ljava/io/FileOutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#getLastModifiedTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLastModifiedTime()
        {
            return IExecuteWithSignature<long>("getLastModifiedTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#delete()"/>
        /// </summary>
        public void Delete()
        {
            IExecuteWithSignature("delete", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#failWrite(java.io.FileOutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileOutputStream"/></param>
        public void FailWrite(Java.Io.FileOutputStream arg0)
        {
            IExecuteWithSignature("failWrite", "(Ljava/io/FileOutputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/AtomicFile.html#finishWrite(java.io.FileOutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileOutputStream"/></param>
        public void FinishWrite(Java.Io.FileOutputStream arg0)
        {
            IExecuteWithSignature("finishWrite", "(Ljava/io/FileOutputStream;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}