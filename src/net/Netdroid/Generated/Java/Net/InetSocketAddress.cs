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

namespace Java.Net
{
    #region InetSocketAddress
    public partial class InetSocketAddress
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public InetSocketAddress(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public InetSocketAddress(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#%3Cinit%3E(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public InetSocketAddress(Java.Net.InetAddress arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#createUnresolved(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.InetSocketAddress"/></returns>
        public static Java.Net.InetSocketAddress CreateUnresolved(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Net.InetSocketAddress>(LocalBridgeClazz, "createUnresolved", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#getAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress Address
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getAddress", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#getHostName()"/> 
        /// </summary>
        public Java.Lang.String HostName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHostName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#getHostString()"/> 
        /// </summary>
        public Java.Lang.String HostString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHostString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecuteWithSignature<int>("getPort", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/InetSocketAddress.html#isUnresolved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnresolved()
        {
            return IExecuteWithSignature<bool>("isUnresolved", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}