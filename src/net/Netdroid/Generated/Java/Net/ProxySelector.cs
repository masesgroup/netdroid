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
    #region ProxySelector
    public partial class ProxySelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ProxySelector.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.ProxySelector"/></returns>
        public static Java.Net.ProxySelector GetDefault()
        {
            return SExecuteWithSignature<Java.Net.ProxySelector>(LocalBridgeClazz, "getDefault", "()Ljava/net/ProxySelector;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ProxySelector.html#of(java.net.InetSocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetSocketAddress"/></param>
        /// <returns><see cref="Java.Net.ProxySelector"/></returns>
        public static Java.Net.ProxySelector Of(Java.Net.InetSocketAddress arg0)
        {
            return SExecuteWithSignature<Java.Net.ProxySelector>(LocalBridgeClazz, "of", "(Ljava/net/InetSocketAddress;)Ljava/net/ProxySelector;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ProxySelector.html#setDefault(java.net.ProxySelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ProxySelector"/></param>
        public static void SetDefault(Java.Net.ProxySelector arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefault", "(Ljava/net/ProxySelector;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ProxySelector.html#select(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Net.Proxy> Select(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Net.Proxy>>("select", "(Ljava/net/URI;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/ProxySelector.html#connectFailed(java.net.URI,java.net.SocketAddress,java.io.IOException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg2"><see cref="Java.Io.IOException"/></param>
        public void ConnectFailed(Java.Net.URI arg0, Java.Net.SocketAddress arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            IExecute("connectFailed", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}