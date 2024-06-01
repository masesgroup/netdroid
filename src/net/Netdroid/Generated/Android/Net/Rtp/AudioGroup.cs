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

namespace Android.Net.Rtp
{
    #region AudioGroup
    public partial class AudioGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [System.Obsolete()]
        public AudioGroup(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#MODE_ECHO_SUPPRESSION"/>
        /// </summary>
        [System.Obsolete()]
        public static int MODE_ECHO_SUPPRESSION { get { if (!_MODE_ECHO_SUPPRESSIONReady) { _MODE_ECHO_SUPPRESSIONContent = SGetField<int>(LocalBridgeClazz, "MODE_ECHO_SUPPRESSION"); _MODE_ECHO_SUPPRESSIONReady = true; } return _MODE_ECHO_SUPPRESSIONContent; } }
        private static int _MODE_ECHO_SUPPRESSIONContent = default;
        private static bool _MODE_ECHO_SUPPRESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#MODE_MUTED"/>
        /// </summary>
        [System.Obsolete()]
        public static int MODE_MUTED { get { if (!_MODE_MUTEDReady) { _MODE_MUTEDContent = SGetField<int>(LocalBridgeClazz, "MODE_MUTED"); _MODE_MUTEDReady = true; } return _MODE_MUTEDContent; } }
        private static int _MODE_MUTEDContent = default;
        private static bool _MODE_MUTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#MODE_NORMAL"/>
        /// </summary>
        [System.Obsolete()]
        public static int MODE_NORMAL { get { if (!_MODE_NORMALReady) { _MODE_NORMALContent = SGetField<int>(LocalBridgeClazz, "MODE_NORMAL"); _MODE_NORMALReady = true; } return _MODE_NORMALContent; } }
        private static int _MODE_NORMALContent = default;
        private static bool _MODE_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#MODE_ON_HOLD"/>
        /// </summary>
        [System.Obsolete()]
        public static int MODE_ON_HOLD { get { if (!_MODE_ON_HOLDReady) { _MODE_ON_HOLDContent = SGetField<int>(LocalBridgeClazz, "MODE_ON_HOLD"); _MODE_ON_HOLDReady = true; } return _MODE_ON_HOLDContent; } }
        private static int _MODE_ON_HOLDContent = default;
        private static bool _MODE_ON_HOLDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#getMode()"/> <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#setMode(int)"/>
        /// </summary>
        [System.Obsolete()]
        public int Mode
        {
            get { return IExecuteWithSignature<int>("getMode", "()I"); } set { IExecuteWithSignature("setMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#getStreams()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Net.Rtp.AudioStream[] Streams
        {
            get { return IExecuteWithSignatureArray<Android.Net.Rtp.AudioStream>("getStreams", "()[Landroid/net/rtp/AudioStream;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#clear()"/>
        /// </summary>
        [System.Obsolete()]
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioGroup.html#sendDtmf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SendDtmf(int arg0)
        {
            IExecuteWithSignature("sendDtmf", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}