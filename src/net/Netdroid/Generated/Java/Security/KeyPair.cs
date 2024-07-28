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

namespace Java.Security
{
    #region KeyPair
    public partial class KeyPair
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/KeyPair.html#%3Cinit%3E(java.security.PublicKey,java.security.PrivateKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.PrivateKey"/></param>
        public KeyPair(Java.Security.PublicKey arg0, Java.Security.PrivateKey arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/KeyPair.html#getPrivate()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.PrivateKey"/></returns>
        public Java.Security.PrivateKey GetPrivate()
        {
            return IExecuteWithSignature<Java.Security.PrivateKey>("getPrivate", "()Ljava/security/PrivateKey;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/KeyPair.html#getPublic()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.PublicKey"/></returns>
        public Java.Security.PublicKey GetPublic()
        {
            return IExecuteWithSignature<Java.Security.PublicKey>("getPublic", "()Ljava/security/PublicKey;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}