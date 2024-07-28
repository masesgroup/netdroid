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
    #region DigestOutputStream
    public partial class DigestOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DigestOutputStream.html#%3Cinit%3E(java.io.OutputStream,java.security.MessageDigest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Security.MessageDigest"/></param>
        public DigestOutputStream(Java.Io.OutputStream arg0, Java.Security.MessageDigest arg1)
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
        /// <see href="https://developer.android.com/reference/java/security/DigestOutputStream.html#getMessageDigest()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.MessageDigest"/></returns>
        public Java.Security.MessageDigest GetMessageDigest()
        {
            return IExecuteWithSignature<Java.Security.MessageDigest>("getMessageDigest", "()Ljava/security/MessageDigest;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DigestOutputStream.html#on(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void On(bool arg0)
        {
            IExecuteWithSignature("on", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DigestOutputStream.html#setMessageDigest(java.security.MessageDigest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.MessageDigest"/></param>
        public void SetMessageDigest(Java.Security.MessageDigest arg0)
        {
            IExecuteWithSignature("setMessageDigest", "(Ljava/security/MessageDigest;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}