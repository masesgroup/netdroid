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

namespace Android.Security
{
    #region KeyStoreParameter
    public partial class KeyStoreParameter
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
        /// <see href="https://developer.android.com/reference/android/security/KeyStoreParameter.html#isEncryptionRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsEncryptionRequired()
        {
            return IExecuteWithSignature<bool>("isEncryptionRequired", "()Z");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyStoreParameter.Builder.html#%3Cinit%3E(android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            [global::System.Obsolete()]
            public Builder(Android.Content.Context arg0)
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
            /// <see href="https://developer.android.com/reference/android/security/KeyStoreParameter.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.KeyStoreParameter"/></returns>
            [global::System.Obsolete()]
            public Android.Security.KeyStoreParameter Build()
            {
                return IExecuteWithSignature<Android.Security.KeyStoreParameter>("build", "()Landroid/security/KeyStoreParameter;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/KeyStoreParameter.Builder.html#setEncryptionRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Security.KeyStoreParameter.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Security.KeyStoreParameter.Builder SetEncryptionRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Security.KeyStoreParameter.Builder>("setEncryptionRequired", "(Z)Landroid/security/KeyStoreParameter$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}