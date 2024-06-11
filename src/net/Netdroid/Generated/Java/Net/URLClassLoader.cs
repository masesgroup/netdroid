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
    #region URLClassLoader
    public partial class URLClassLoader
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#%3Cinit%3E(java.lang.String,java.net.URL[],java.lang.ClassLoader,java.net.URLStreamHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Net.URL"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg3"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        public URLClassLoader(Java.Lang.String arg0, Java.Net.URL[] arg1, Java.Lang.ClassLoader arg2, Java.Net.URLStreamHandlerFactory arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#%3Cinit%3E(java.lang.String,java.net.URL[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Net.URL"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        public URLClassLoader(Java.Lang.String arg0, Java.Net.URL[] arg1, Java.Lang.ClassLoader arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader,java.net.URLStreamHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        public URLClassLoader(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1, Java.Net.URLStreamHandlerFactory arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#%3Cinit%3E(java.net.URL[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        public URLClassLoader(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#%3Cinit%3E(java.net.URL[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public URLClassLoader(Java.Net.URL[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Net.URLClassLoader"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Net.URLClassLoader t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#newInstance(java.net.URL[],java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Net.URLClassLoader"/></returns>
        public static Java.Net.URLClassLoader NewInstance(Java.Net.URL[] arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Java.Net.URLClassLoader>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#newInstance(java.net.URL[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Net.URLClassLoader"/></returns>
        public static Java.Net.URLClassLoader NewInstance(Java.Net.URL[] arg0)
        {
            return SExecuteWithSignature<Java.Net.URLClassLoader>(LocalBridgeClazz, "newInstance", "([Ljava/net/URL;)Ljava/net/URLClassLoader;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#findResource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL FindResource(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Net.URL>("findResource", "(Ljava/lang/String;)Ljava/net/URL;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#getURLs()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL[] GetURLs()
        {
            return IExecuteWithSignatureArray<Java.Net.URL>("getURLs", "()[Ljava/net/URL;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#findResources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Enumeration<Java.Net.URL> FindResources(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Net.URL>>("findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLClassLoader.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}