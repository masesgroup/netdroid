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

namespace Java.Security
{
    #region DomainLoadStoreParameter
    public partial class DomainLoadStoreParameter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DomainLoadStoreParameter.html#%3Cinit%3E(java.net.URI,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public DomainLoadStoreParameter(Java.Net.URI arg0, Java.Util.Map<Java.Lang.String, Java.Security.KeyStore.ProtectionParameter> arg1)
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
        /// <see href="https://developer.android.com/reference/java/security/DomainLoadStoreParameter.html#getConfiguration()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI GetConfiguration()
        {
            return IExecuteWithSignature<Java.Net.URI>("getConfiguration", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DomainLoadStoreParameter.html#getProtectionParameter()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.KeyStore.ProtectionParameter"/></returns>
        public Java.Security.KeyStore.ProtectionParameter GetProtectionParameter()
        {
            return IExecuteWithSignature<Java.Security.KeyStore.ProtectionParameter>("getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DomainLoadStoreParameter.html#getProtectionParams()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Security.KeyStore.ProtectionParameter> GetProtectionParams()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Security.KeyStore.ProtectionParameter>>("getProtectionParams", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}