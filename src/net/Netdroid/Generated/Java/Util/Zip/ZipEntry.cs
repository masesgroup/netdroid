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

namespace Java.Util.Zip
{
    #region ZipEntry
    public partial class ZipEntry : Java.Lang.ICloneable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public ZipEntry(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#%3Cinit%3E(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        public ZipEntry(Java.Util.Zip.ZipEntry arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Zip.ZipEntry"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Zip.ZipEntry t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#DEFLATED"/>
        /// </summary>
        public static int DEFLATED { get { if (!_DEFLATEDReady) { _DEFLATEDContent = SGetField<int>(LocalBridgeClazz, "DEFLATED"); _DEFLATEDReady = true; } return _DEFLATEDContent; } }
        private static int _DEFLATEDContent = default;
        private static bool _DEFLATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#STORED"/>
        /// </summary>
        public static int STORED { get { if (!_STOREDReady) { _STOREDContent = SGetField<int>(LocalBridgeClazz, "STORED"); _STOREDReady = true; } return _STOREDContent; } }
        private static int _STOREDContent = default;
        private static bool _STOREDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#isDirectory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDirectory()
        {
            return IExecuteWithSignature<bool>("isDirectory", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getExtra()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetExtra()
        {
            return IExecuteWithSignatureArray<byte>("getExtra", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getMethod()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMethod()
        {
            return IExecuteWithSignature<int>("getMethod", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getComment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetComment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getComment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getCreationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime GetCreationTime()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("getCreationTime", "()Ljava/nio/file/attribute/FileTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getLastAccessTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime GetLastAccessTime()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("getLastAccessTime", "()Ljava/nio/file/attribute/FileTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getLastModifiedTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime GetLastModifiedTime()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("getLastModifiedTime", "()Ljava/nio/file/attribute/FileTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getTimeLocal()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime GetTimeLocal()
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("getTimeLocal", "()Ljava/time/LocalDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setCreationTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetCreationTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("setCreationTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setLastAccessTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetLastAccessTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("setLastAccessTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setLastModifiedTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetLastModifiedTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("setLastModifiedTime", "(Ljava/nio/file/attribute/FileTime;)Ljava/util/zip/ZipEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getCompressedSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCompressedSize()
        {
            return IExecuteWithSignature<long>("getCompressedSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getCrc()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCrc()
        {
            return IExecuteWithSignature<long>("getCrc", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSize()
        {
            return IExecuteWithSignature<long>("getSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#getTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTime()
        {
            return IExecuteWithSignature<long>("getTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetComment(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setComment", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setCompressedSize(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetCompressedSize(long arg0)
        {
            IExecuteWithSignature("setCompressedSize", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setCrc(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetCrc(long arg0)
        {
            IExecuteWithSignature("setCrc", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setExtra(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetExtra(byte[] arg0)
        {
            IExecuteWithSignature("setExtra", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setMethod(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMethod(int arg0)
        {
            IExecuteWithSignature("setMethod", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setSize(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetSize(long arg0)
        {
            IExecuteWithSignature("setSize", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetTime(long arg0)
        {
            IExecuteWithSignature("setTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipEntry.html#setTimeLocal(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        public void SetTimeLocal(Java.Time.LocalDateTime arg0)
        {
            IExecuteWithSignature("setTimeLocal", "(Ljava/time/LocalDateTime;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}