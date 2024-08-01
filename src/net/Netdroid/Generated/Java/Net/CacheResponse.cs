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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region CacheResponse
    public partial class CacheResponse
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
        /// <see href="https://developer.android.com/reference/java/net/CacheResponse.html#getBody()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetBody()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getBody", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/CacheResponse.html#getHeaders()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> GetHeaders()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("getHeaders", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}