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

namespace Java.Net
{
    #region ResponseCache
    public partial class ResponseCache
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ResponseCache.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.ResponseCache"/></returns>
        public static Java.Net.ResponseCache GetDefault()
        {
            return SExecuteWithSignature<Java.Net.ResponseCache>(LocalBridgeClazz, "getDefault", "()Ljava/net/ResponseCache;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ResponseCache.html#setDefault(java.net.ResponseCache)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ResponseCache"/></param>
        public static void SetDefault(Java.Net.ResponseCache arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefault", "(Ljava/net/ResponseCache;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ResponseCache.html#put(java.net.URI,java.net.URLConnection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.URLConnection"/></param>
        /// <returns><see cref="Java.Net.CacheRequest"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.CacheRequest Put(Java.Net.URI arg0, Java.Net.URLConnection arg1)
        {
            return IExecute<Java.Net.CacheRequest>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ResponseCache.html#get(java.net.URI,java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Net.CacheResponse"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.CacheResponse Get(Java.Net.URI arg0, Java.Lang.String arg1, Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> arg2)
        {
            return IExecute<Java.Net.CacheResponse>("get", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}