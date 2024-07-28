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

namespace Android.Net.Rtp
{
    #region AudioStream
    public partial class AudioStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#%3Cinit%3E(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        [global::System.Obsolete()]
        public AudioStream(Java.Net.InetAddress arg0)
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
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#getCodec()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Rtp.AudioCodec"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Rtp.AudioCodec GetCodec()
        {
            return IExecuteWithSignature<Android.Net.Rtp.AudioCodec>("getCodec", "()Landroid/net/rtp/AudioCodec;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#getGroup()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Rtp.AudioGroup"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Rtp.AudioGroup GetGroup()
        {
            return IExecuteWithSignature<Android.Net.Rtp.AudioGroup>("getGroup", "()Landroid/net/rtp/AudioGroup;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#getDtmfType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetDtmfType()
        {
            return IExecuteWithSignature<int>("getDtmfType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#join(android.net.rtp.AudioGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Rtp.AudioGroup"/></param>
        [global::System.Obsolete()]
        public void Join(Android.Net.Rtp.AudioGroup arg0)
        {
            IExecuteWithSignature("join", "(Landroid/net/rtp/AudioGroup;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#setCodec(android.net.rtp.AudioCodec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Rtp.AudioCodec"/></param>
        [global::System.Obsolete()]
        public void SetCodec(Android.Net.Rtp.AudioCodec arg0)
        {
            IExecuteWithSignature("setCodec", "(Landroid/net/rtp/AudioCodec;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/rtp/AudioStream.html#setDtmfType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetDtmfType(int arg0)
        {
            IExecuteWithSignature("setDtmfType", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}