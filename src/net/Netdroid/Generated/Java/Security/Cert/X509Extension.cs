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

namespace Java.Security.Cert
{
    #region IX509Extension
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IX509Extension
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region X509Extension
    public partial class X509Extension : Java.Security.Cert.IX509Extension
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
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Extension.html#hasUnsupportedCriticalExtension()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasUnsupportedCriticalExtension()
        {
            return IExecuteWithSignature<bool>("hasUnsupportedCriticalExtension", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Extension.html#getExtensionValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetExtensionValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getExtensionValue", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Extension.html#getCriticalExtensionOIDs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetCriticalExtensionOIDs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getCriticalExtensionOIDs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/X509Extension.html#getNonCriticalExtensionOIDs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetNonCriticalExtensionOIDs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}