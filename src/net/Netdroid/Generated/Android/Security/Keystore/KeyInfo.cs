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

namespace Android.Security.Keystore
{
    #region KeyInfo
    public partial class KeyInfo
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
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getBlockModes()"/> 
        /// </summary>
        public Java.Lang.String[] BlockModes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getBlockModes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getDigests()"/> 
        /// </summary>
        public Java.Lang.String[] Digests
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getDigests", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getEncryptionPaddings()"/> 
        /// </summary>
        public Java.Lang.String[] EncryptionPaddings
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEncryptionPaddings", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getKeySize()"/> 
        /// </summary>
        public int KeySize
        {
            get { return IExecuteWithSignature<int>("getKeySize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getKeystoreAlias()"/> 
        /// </summary>
        public Java.Lang.String KeystoreAlias
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getKeystoreAlias", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getKeyValidityForConsumptionEnd()"/> 
        /// </summary>
        public Java.Util.Date KeyValidityForConsumptionEnd
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getKeyValidityForConsumptionEnd", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getKeyValidityForOriginationEnd()"/> 
        /// </summary>
        public Java.Util.Date KeyValidityForOriginationEnd
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getKeyValidityForOriginationEnd", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getKeyValidityStart()"/> 
        /// </summary>
        public Java.Util.Date KeyValidityStart
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getKeyValidityStart", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getOrigin()"/> 
        /// </summary>
        public int Origin
        {
            get { return IExecuteWithSignature<int>("getOrigin", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getPurposes()"/> 
        /// </summary>
        public int Purposes
        {
            get { return IExecuteWithSignature<int>("getPurposes", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getRemainingUsageCount()"/> 
        /// </summary>
        public int RemainingUsageCount
        {
            get { return IExecuteWithSignature<int>("getRemainingUsageCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getSecurityLevel()"/> 
        /// </summary>
        public int SecurityLevel
        {
            get { return IExecuteWithSignature<int>("getSecurityLevel", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getSignaturePaddings()"/> 
        /// </summary>
        public Java.Lang.String[] SignaturePaddings
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSignaturePaddings", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getUserAuthenticationType()"/> 
        /// </summary>
        public int UserAuthenticationType
        {
            get { return IExecuteWithSignature<int>("getUserAuthenticationType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#getUserAuthenticationValidityDurationSeconds()"/> 
        /// </summary>
        public int UserAuthenticationValidityDurationSeconds
        {
            get { return IExecuteWithSignature<int>("getUserAuthenticationValidityDurationSeconds", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#isInvalidatedByBiometricEnrollment()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInvalidatedByBiometricEnrollment()
        {
            return IExecuteWithSignature<bool>("isInvalidatedByBiometricEnrollment", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#isTrustedUserPresenceRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTrustedUserPresenceRequired()
        {
            return IExecuteWithSignature<bool>("isTrustedUserPresenceRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#isUserAuthenticationRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationRequired()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#isUserAuthenticationRequirementEnforcedBySecureHardware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationRequirementEnforcedBySecureHardware()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationRequirementEnforcedBySecureHardware", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#isUserAuthenticationValidWhileOnBody()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserAuthenticationValidWhileOnBody()
        {
            return IExecuteWithSignature<bool>("isUserAuthenticationValidWhileOnBody", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/keystore/KeyInfo.html#isUserConfirmationRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserConfirmationRequired()
        {
            return IExecuteWithSignature<bool>("isUserConfirmationRequired", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}