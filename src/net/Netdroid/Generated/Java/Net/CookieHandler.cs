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
    #region CookieHandler
    public partial class CookieHandler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/CookieHandler.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.CookieHandler"/></returns>
        public static Java.Net.CookieHandler GetDefault()
        {
            return SExecuteWithSignature<Java.Net.CookieHandler>(LocalBridgeClazz, "getDefault", "()Ljava/net/CookieHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/CookieHandler.html#setDefault(java.net.CookieHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.CookieHandler"/></param>
        public static void SetDefault(Java.Net.CookieHandler arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefault", "(Ljava/net/CookieHandler;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/CookieHandler.html#get(java.net.URI,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> Get(Java.Net.URI arg0, Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> arg1)
        {
            return IExecute<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/CookieHandler.html#put(java.net.URI,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Put(Java.Net.URI arg0, Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> arg1)
        {
            IExecute("put", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}