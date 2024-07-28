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
    #region DrbgParameters
    public partial class DrbgParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.html#instantiation(int,java.security.DrbgParameters.Capability,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.DrbgParameters.Capability"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Java.Security.DrbgParameters.Instantiation"/></returns>
        public static Java.Security.DrbgParameters.Instantiation InstantiationMethod(int arg0, Java.Security.DrbgParameters.Capability arg1, byte[] arg2)
        {
            return SExecute<Java.Security.DrbgParameters.Instantiation>(LocalBridgeClazz, "instantiation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.html#nextBytes(int,boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Java.Security.DrbgParameters.NextBytes"/></returns>
        public static Java.Security.DrbgParameters.NextBytes NextBytesMethod(int arg0, bool arg1, byte[] arg2)
        {
            return SExecute<Java.Security.DrbgParameters.NextBytes>(LocalBridgeClazz, "nextBytes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.html#reseed(boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Security.DrbgParameters.Reseed"/></returns>
        public static Java.Security.DrbgParameters.Reseed ReseedMethod(bool arg0, byte[] arg1)
        {
            return SExecute<Java.Security.DrbgParameters.Reseed>(LocalBridgeClazz, "reseed", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Capability
        public partial class Capability
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#NONE"/>
            /// </summary>
            public static Java.Security.DrbgParameters.Capability NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static Java.Security.DrbgParameters.Capability _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#PR_AND_RESEED"/>
            /// </summary>
            public static Java.Security.DrbgParameters.Capability PR_AND_RESEED { get { if (!_PR_AND_RESEEDReady) { _PR_AND_RESEEDContent = SGetField<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "PR_AND_RESEED"); _PR_AND_RESEEDReady = true; } return _PR_AND_RESEEDContent; } }
            private static Java.Security.DrbgParameters.Capability _PR_AND_RESEEDContent = default;
            private static bool _PR_AND_RESEEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#RESEED_ONLY"/>
            /// </summary>
            public static Java.Security.DrbgParameters.Capability RESEED_ONLY { get { if (!_RESEED_ONLYReady) { _RESEED_ONLYContent = SGetField<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "RESEED_ONLY"); _RESEED_ONLYReady = true; } return _RESEED_ONLYContent; } }
            private static Java.Security.DrbgParameters.Capability _RESEED_ONLYContent = default;
            private static bool _RESEED_ONLYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Security.DrbgParameters.Capability"/></returns>
            public static Java.Security.DrbgParameters.Capability ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/security/DrbgParameters$Capability;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.DrbgParameters.Capability"/></returns>
            public static Java.Security.DrbgParameters.Capability[] Values()
            {
                return SExecuteWithSignatureArray<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "values", "()[Ljava/security/DrbgParameters$Capability;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#supportsPredictionResistance()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool SupportsPredictionResistance()
            {
                return IExecuteWithSignature<bool>("supportsPredictionResistance", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Capability.html#supportsReseeding()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool SupportsReseeding()
            {
                return IExecuteWithSignature<bool>("supportsReseeding", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Instantiation
        public partial class Instantiation
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
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Instantiation.html#getPersonalizationString()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetPersonalizationString()
            {
                return IExecuteWithSignatureArray<byte>("getPersonalizationString", "()[B");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Instantiation.html#getStrength()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetStrength()
            {
                return IExecuteWithSignature<int>("getStrength", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Instantiation.html#getCapability()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.DrbgParameters.Capability"/></returns>
            public Java.Security.DrbgParameters.Capability GetCapability()
            {
                return IExecuteWithSignature<Java.Security.DrbgParameters.Capability>("getCapability", "()Ljava/security/DrbgParameters$Capability;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region NextBytes
        public partial class NextBytes
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
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.NextBytes.html#getPredictionResistance()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetPredictionResistance()
            {
                return IExecuteWithSignature<bool>("getPredictionResistance", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.NextBytes.html#getAdditionalInput()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetAdditionalInput()
            {
                return IExecuteWithSignatureArray<byte>("getAdditionalInput", "()[B");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.NextBytes.html#getStrength()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetStrength()
            {
                return IExecuteWithSignature<int>("getStrength", "()I");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Reseed
        public partial class Reseed
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
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Reseed.html#getPredictionResistance()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetPredictionResistance()
            {
                return IExecuteWithSignature<bool>("getPredictionResistance", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/security/DrbgParameters.Reseed.html#getAdditionalInput()"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte[] GetAdditionalInput()
            {
                return IExecuteWithSignatureArray<byte>("getAdditionalInput", "()[B");
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