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

namespace Java.Util.Jar
{
    #region JarFile
    public partial class JarFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0, bool arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public JarFile(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#MANIFEST_NAME"/>
        /// </summary>
        public static Java.Lang.String MANIFEST_NAME { get { if (!_MANIFEST_NAMEReady) { _MANIFEST_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MANIFEST_NAME"); _MANIFEST_NAMEReady = true; } return _MANIFEST_NAMEContent; } }
        private static Java.Lang.String _MANIFEST_NAMEContent = default;
        private static bool _MANIFEST_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#isMultiRelease()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMultiRelease()
        {
            return IExecuteWithSignature<bool>("isMultiRelease", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#getJarEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Jar.JarEntry"/></returns>
        public Java.Util.Jar.JarEntry GetJarEntry(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Jar.JarEntry>("getJarEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#getManifest()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Manifest"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Manifest GetManifest()
        {
            return IExecuteWithSignature<Java.Util.Jar.Manifest>("getManifest", "()Ljava/util/jar/Manifest;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/JarFile.html#versionedStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Jar.JarEntry> VersionedStream()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.Jar.JarEntry>>("versionedStream", "()Ljava/util/stream/Stream;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}