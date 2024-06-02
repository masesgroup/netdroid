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

namespace Java.Nio.File
{
    #region FileSystems
    public partial class FileSystems
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileSystems.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        public static Java.Nio.File.FileSystem GetDefault()
        {
            return SExecuteWithSignature<Java.Nio.File.FileSystem>(LocalBridgeClazz, "getDefault", "()Ljava/nio/file/FileSystem;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileSystems.html#getFileSystem(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        public static Java.Nio.File.FileSystem GetFileSystem(Java.Net.URI arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.FileSystem>(LocalBridgeClazz, "getFileSystem", "(Ljava/net/URI;)Ljava/nio/file/FileSystem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileSystems.html#newFileSystem(java.net.URI,java.util.Map,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.File.FileSystem NewFileSystem(Java.Net.URI arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Nio.File.FileSystem>(LocalBridgeClazz, "newFileSystem", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileSystems.html#newFileSystem(java.net.URI,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.File.FileSystem NewFileSystem(Java.Net.URI arg0, Java.Util.Map<Java.Lang.String, object> arg1)
        {
            return SExecute<Java.Nio.File.FileSystem>(LocalBridgeClazz, "newFileSystem", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileSystems.html#newFileSystem(java.nio.file.Path,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.File.FileSystem NewFileSystem(Java.Nio.File.Path arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Java.Nio.File.FileSystem>(LocalBridgeClazz, "newFileSystem", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}