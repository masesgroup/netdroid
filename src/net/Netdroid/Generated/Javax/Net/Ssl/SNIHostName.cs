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

namespace Javax.Net.Ssl
{
    #region SNIHostName
    public partial class SNIHostName
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SNIHostName.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public SNIHostName(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SNIHostName.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public SNIHostName(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SNIHostName.html#createSNIMatcher(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SNIMatcher"/></returns>
        public static Javax.Net.Ssl.SNIMatcher CreateSNIMatcher(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Net.Ssl.SNIMatcher>(LocalBridgeClazz, "createSNIMatcher", "(Ljava/lang/String;)Ljavax/net/ssl/SNIMatcher;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SNIHostName.html#getAsciiName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAsciiName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAsciiName", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}