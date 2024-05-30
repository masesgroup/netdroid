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

namespace Android.Security
{
    #region AttestedKeyPair
    public partial class AttestedKeyPair
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/AttestedKeyPair.html#%3Cinit%3E(java.security.KeyPair,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyPair"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public AttestedKeyPair(Java.Security.KeyPair arg0, Java.Util.List<Java.Security.Cert.Certificate> arg1)
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
        /// <see href="https://developer.android.com/reference/android/security/AttestedKeyPair.html#getAttestationRecord()"/> 
        /// </summary>
        public Java.Util.List<Java.Security.Cert.Certificate> AttestationRecord
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.Certificate>>("getAttestationRecord", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/AttestedKeyPair.html#getKeyPair()"/> 
        /// </summary>
        public Java.Security.KeyPair KeyPair
        {
            get { return IExecuteWithSignature<Java.Security.KeyPair>("getKeyPair", "()Ljava/security/KeyPair;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}