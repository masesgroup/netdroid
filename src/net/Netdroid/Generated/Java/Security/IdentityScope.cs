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
    #region IdentityScope
    public partial class IdentityScope
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#%3Cinit%3E(java.lang.String,java.security.IdentityScope)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.IdentityScope"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public IdentityScope(Java.Lang.String arg0, Java.Security.IdentityScope arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public IdentityScope(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#getSystemScope()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.IdentityScope"/></returns>
        public static Java.Security.IdentityScope GetSystemScope()
        {
            return SExecuteWithSignature<Java.Security.IdentityScope>(LocalBridgeClazz, "getSystemScope", "()Ljava/security/IdentityScope;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#getIdentity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Identity"/></returns>
        public Java.Security.Identity GetIdentity(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Security.Identity>("getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#getIdentity(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <returns><see cref="Java.Security.Identity"/></returns>
        public Java.Security.Identity GetIdentity(Java.Security.PublicKey arg0)
        {
            return IExecuteWithSignature<Java.Security.Identity>("getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#identities()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Security.Identity> Identities()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Security.Identity>>("identities", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#addIdentity(java.security.Identity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Identity"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public void AddIdentity(Java.Security.Identity arg0)
        {
            IExecuteWithSignature("addIdentity", "(Ljava/security/Identity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#removeIdentity(java.security.Identity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Identity"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public void RemoveIdentity(Java.Security.Identity arg0)
        {
            IExecuteWithSignature("removeIdentity", "(Ljava/security/Identity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/IdentityScope.html#getIdentity(java.security.Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Principal"/></param>
        /// <returns><see cref="Java.Security.Identity"/></returns>
        public Java.Security.Identity GetIdentity(Java.Security.Principal arg0)
        {
            return IExecuteWithSignature<Java.Security.Identity>("getIdentity", "(Ljava/security/Principal;)Ljava/security/Identity;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}