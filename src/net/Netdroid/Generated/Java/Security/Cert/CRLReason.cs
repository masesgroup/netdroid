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

namespace Java.Security.Cert
{
    #region CRLReason
    public partial class CRLReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#AA_COMPROMISE"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason AA_COMPROMISE { get { if (!_AA_COMPROMISEReady) { _AA_COMPROMISEContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "AA_COMPROMISE"); _AA_COMPROMISEReady = true; } return _AA_COMPROMISEContent; } }
        private static Java.Security.Cert.CRLReason _AA_COMPROMISEContent = default;
        private static bool _AA_COMPROMISEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#AFFILIATION_CHANGED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason AFFILIATION_CHANGED { get { if (!_AFFILIATION_CHANGEDReady) { _AFFILIATION_CHANGEDContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "AFFILIATION_CHANGED"); _AFFILIATION_CHANGEDReady = true; } return _AFFILIATION_CHANGEDContent; } }
        private static Java.Security.Cert.CRLReason _AFFILIATION_CHANGEDContent = default;
        private static bool _AFFILIATION_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#CA_COMPROMISE"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason CA_COMPROMISE { get { if (!_CA_COMPROMISEReady) { _CA_COMPROMISEContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "CA_COMPROMISE"); _CA_COMPROMISEReady = true; } return _CA_COMPROMISEContent; } }
        private static Java.Security.Cert.CRLReason _CA_COMPROMISEContent = default;
        private static bool _CA_COMPROMISEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#CERTIFICATE_HOLD"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason CERTIFICATE_HOLD { get { if (!_CERTIFICATE_HOLDReady) { _CERTIFICATE_HOLDContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "CERTIFICATE_HOLD"); _CERTIFICATE_HOLDReady = true; } return _CERTIFICATE_HOLDContent; } }
        private static Java.Security.Cert.CRLReason _CERTIFICATE_HOLDContent = default;
        private static bool _CERTIFICATE_HOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#CESSATION_OF_OPERATION"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason CESSATION_OF_OPERATION { get { if (!_CESSATION_OF_OPERATIONReady) { _CESSATION_OF_OPERATIONContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "CESSATION_OF_OPERATION"); _CESSATION_OF_OPERATIONReady = true; } return _CESSATION_OF_OPERATIONContent; } }
        private static Java.Security.Cert.CRLReason _CESSATION_OF_OPERATIONContent = default;
        private static bool _CESSATION_OF_OPERATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#KEY_COMPROMISE"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason KEY_COMPROMISE { get { if (!_KEY_COMPROMISEReady) { _KEY_COMPROMISEContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "KEY_COMPROMISE"); _KEY_COMPROMISEReady = true; } return _KEY_COMPROMISEContent; } }
        private static Java.Security.Cert.CRLReason _KEY_COMPROMISEContent = default;
        private static bool _KEY_COMPROMISEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#PRIVILEGE_WITHDRAWN"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason PRIVILEGE_WITHDRAWN { get { if (!_PRIVILEGE_WITHDRAWNReady) { _PRIVILEGE_WITHDRAWNContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "PRIVILEGE_WITHDRAWN"); _PRIVILEGE_WITHDRAWNReady = true; } return _PRIVILEGE_WITHDRAWNContent; } }
        private static Java.Security.Cert.CRLReason _PRIVILEGE_WITHDRAWNContent = default;
        private static bool _PRIVILEGE_WITHDRAWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#REMOVE_FROM_CRL"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason REMOVE_FROM_CRL { get { if (!_REMOVE_FROM_CRLReady) { _REMOVE_FROM_CRLContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "REMOVE_FROM_CRL"); _REMOVE_FROM_CRLReady = true; } return _REMOVE_FROM_CRLContent; } }
        private static Java.Security.Cert.CRLReason _REMOVE_FROM_CRLContent = default;
        private static bool _REMOVE_FROM_CRLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#SUPERSEDED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason SUPERSEDED { get { if (!_SUPERSEDEDReady) { _SUPERSEDEDContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "SUPERSEDED"); _SUPERSEDEDReady = true; } return _SUPERSEDEDContent; } }
        private static Java.Security.Cert.CRLReason _SUPERSEDEDContent = default;
        private static bool _SUPERSEDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#UNSPECIFIED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason UNSPECIFIED { get { if (!_UNSPECIFIEDReady) { _UNSPECIFIEDContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "UNSPECIFIED"); _UNSPECIFIEDReady = true; } return _UNSPECIFIEDContent; } }
        private static Java.Security.Cert.CRLReason _UNSPECIFIEDContent = default;
        private static bool _UNSPECIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#UNUSED"/>
        /// </summary>
        public static Java.Security.Cert.CRLReason UNUSED { get { if (!_UNUSEDReady) { _UNUSEDContent = SGetField<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "UNUSED"); _UNUSEDReady = true; } return _UNUSEDContent; } }
        private static Java.Security.Cert.CRLReason _UNUSEDContent = default;
        private static bool _UNUSEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.CRLReason"/></returns>
        public static Java.Security.Cert.CRLReason ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/security/cert/CRLReason;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/CRLReason.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.CRLReason"/></returns>
        public static Java.Security.Cert.CRLReason[] Values()
        {
            return SExecuteWithSignatureArray<Java.Security.Cert.CRLReason>(LocalBridgeClazz, "values", "()[Ljava/security/cert/CRLReason;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}