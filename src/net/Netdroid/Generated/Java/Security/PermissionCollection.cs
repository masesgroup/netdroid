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

namespace Java.Security
{
    #region PermissionCollection
    public partial class PermissionCollection
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
        /// <see href="https://developer.android.com/reference/java/security/PermissionCollection.html#implies(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.Permission arg0)
        {
            return IExecuteWithSignature<bool>("implies", "(Ljava/security/Permission;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/PermissionCollection.html#elements()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Security.Permission> Elements()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Security.Permission>>("elements", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/PermissionCollection.html#add(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        public void Add(Java.Security.Permission arg0)
        {
            IExecuteWithSignature("add", "(Ljava/security/Permission;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/PermissionCollection.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/PermissionCollection.html#elementsAsStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Security.Permission> ElementsAsStream()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Security.Permission>>("elementsAsStream", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/PermissionCollection.html#setReadOnly()"/>
        /// </summary>
        public void SetReadOnly()
        {
            IExecuteWithSignature("setReadOnly", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}