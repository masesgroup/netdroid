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

namespace Java.Net
{
    #region JarURLConnection
    public partial class JarURLConnection
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
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getJarFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.JarFile"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.JarFile GetJarFile()
        {
            return IExecuteWithSignature<Java.Util.Jar.JarFile>("getJarFile", "()Ljava/util/jar/JarFile;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getEntryName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEntryName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEntryName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getJarFileURL()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetJarFileURL()
        {
            return IExecuteWithSignature<Java.Net.URL>("getJarFileURL", "()Ljava/net/URL;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getCertificates()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Security.Cert.Certificate[] GetCertificates()
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getCertificates", "()[Ljava/security/cert/Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Attributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Attributes GetAttributes()
        {
            return IExecuteWithSignature<Java.Util.Jar.Attributes>("getAttributes", "()Ljava/util/jar/Attributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getMainAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Attributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Attributes GetMainAttributes()
        {
            return IExecuteWithSignature<Java.Util.Jar.Attributes>("getMainAttributes", "()Ljava/util/jar/Attributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getJarEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.JarEntry"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.JarEntry GetJarEntry()
        {
            return IExecuteWithSignature<Java.Util.Jar.JarEntry>("getJarEntry", "()Ljava/util/jar/JarEntry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getManifest()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Manifest"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Manifest GetManifest()
        {
            return IExecuteWithSignature<Java.Util.Jar.Manifest>("getManifest", "()Ljava/util/jar/Manifest;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}