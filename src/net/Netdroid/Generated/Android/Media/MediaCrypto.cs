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

namespace Android.Media
{
    #region MediaCrypto
    public partial class MediaCrypto
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCrypto.html#%3Cinit%3E(java.util.UUID,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Android.Media.MediaCryptoException"/>
        public MediaCrypto(Java.Util.UUID arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCrypto.html#isCryptoSchemeSupported(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsCryptoSchemeSupported(Java.Util.UUID arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isCryptoSchemeSupported", "(Ljava/util/UUID;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCrypto.html#requiresSecureDecoderComponent(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequiresSecureDecoderComponent(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("requiresSecureDecoderComponent", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCrypto.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCrypto.html#setMediaDrmSession(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Android.Media.MediaCryptoException"/>
        public void SetMediaDrmSession(byte[] arg0)
        {
            IExecuteWithSignature("setMediaDrmSession", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}