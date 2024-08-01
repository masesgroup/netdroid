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

namespace Java.Security.Interfaces
{
    #region IDSAParams
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDSAParams
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DSAParams
    public partial class DSAParams : Java.Security.Interfaces.IDSAParams
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
        /// <see href="https://developer.android.com/reference/java/security/interfaces/DSAParams.html#getG()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetG()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getG", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/DSAParams.html#getP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/interfaces/DSAParams.html#getQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getQ", "()Ljava/math/BigInteger;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}