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

namespace Android.Media
{
    #region IMicrophoneDirection
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMicrophoneDirection
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#setPreferredMicrophoneDirection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool SetPreferredMicrophoneDirection(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#setPreferredMicrophoneFieldDimension(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        bool SetPreferredMicrophoneFieldDimension(float arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MicrophoneDirection
    public partial class MicrophoneDirection : Android.Media.IMicrophoneDirection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#MIC_DIRECTION_AWAY_FROM_USER"/>
        /// </summary>
        public static int MIC_DIRECTION_AWAY_FROM_USER { get { if (!_MIC_DIRECTION_AWAY_FROM_USERReady) { _MIC_DIRECTION_AWAY_FROM_USERContent = SGetField<int>(LocalBridgeClazz, "MIC_DIRECTION_AWAY_FROM_USER"); _MIC_DIRECTION_AWAY_FROM_USERReady = true; } return _MIC_DIRECTION_AWAY_FROM_USERContent; } }
        private static int _MIC_DIRECTION_AWAY_FROM_USERContent = default;
        private static bool _MIC_DIRECTION_AWAY_FROM_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#MIC_DIRECTION_EXTERNAL"/>
        /// </summary>
        public static int MIC_DIRECTION_EXTERNAL { get { if (!_MIC_DIRECTION_EXTERNALReady) { _MIC_DIRECTION_EXTERNALContent = SGetField<int>(LocalBridgeClazz, "MIC_DIRECTION_EXTERNAL"); _MIC_DIRECTION_EXTERNALReady = true; } return _MIC_DIRECTION_EXTERNALContent; } }
        private static int _MIC_DIRECTION_EXTERNALContent = default;
        private static bool _MIC_DIRECTION_EXTERNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#MIC_DIRECTION_TOWARDS_USER"/>
        /// </summary>
        public static int MIC_DIRECTION_TOWARDS_USER { get { if (!_MIC_DIRECTION_TOWARDS_USERReady) { _MIC_DIRECTION_TOWARDS_USERContent = SGetField<int>(LocalBridgeClazz, "MIC_DIRECTION_TOWARDS_USER"); _MIC_DIRECTION_TOWARDS_USERReady = true; } return _MIC_DIRECTION_TOWARDS_USERContent; } }
        private static int _MIC_DIRECTION_TOWARDS_USERContent = default;
        private static bool _MIC_DIRECTION_TOWARDS_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#MIC_DIRECTION_UNSPECIFIED"/>
        /// </summary>
        public static int MIC_DIRECTION_UNSPECIFIED { get { if (!_MIC_DIRECTION_UNSPECIFIEDReady) { _MIC_DIRECTION_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "MIC_DIRECTION_UNSPECIFIED"); _MIC_DIRECTION_UNSPECIFIEDReady = true; } return _MIC_DIRECTION_UNSPECIFIEDContent; } }
        private static int _MIC_DIRECTION_UNSPECIFIEDContent = default;
        private static bool _MIC_DIRECTION_UNSPECIFIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#setPreferredMicrophoneDirection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPreferredMicrophoneDirection(int arg0)
        {
            return IExecuteWithSignature<bool>("setPreferredMicrophoneDirection", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneDirection.html#setPreferredMicrophoneFieldDimension(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPreferredMicrophoneFieldDimension(float arg0)
        {
            return IExecuteWithSignature<bool>("setPreferredMicrophoneFieldDimension", "(F)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}