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
    #region AccessControlContext
    public partial class AccessControlContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AccessControlContext.html#%3Cinit%3E(java.security.AccessControlContext,java.security.DomainCombiner)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.AccessControlContext"/></param>
        /// <param name="arg1"><see cref="Java.Security.DomainCombiner"/></param>
        public AccessControlContext(Java.Security.AccessControlContext arg0, Java.Security.DomainCombiner arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AccessControlContext.html#%3Cinit%3E(java.security.ProtectionDomain[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.ProtectionDomain"/></param>
        public AccessControlContext(Java.Security.ProtectionDomain[] arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/java/security/AccessControlContext.html#getDomainCombiner()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.DomainCombiner"/></returns>
        public Java.Security.DomainCombiner GetDomainCombiner()
        {
            return IExecuteWithSignature<Java.Security.DomainCombiner>("getDomainCombiner", "()Ljava/security/DomainCombiner;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AccessControlContext.html#checkPermission(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        /// <exception cref="Java.Security.AccessControlException"/>
        public void CheckPermission(Java.Security.Permission arg0)
        {
            IExecuteWithSignature("checkPermission", "(Ljava/security/Permission;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}