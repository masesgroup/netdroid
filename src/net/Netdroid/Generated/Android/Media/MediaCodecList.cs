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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region MediaCodecList
    public partial class MediaCodecList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public MediaCodecList(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#ALL_CODECS"/>
        /// </summary>
        public static int ALL_CODECS { get { if (!_ALL_CODECSReady) { _ALL_CODECSContent = SGetField<int>(LocalBridgeClazz, "ALL_CODECS"); _ALL_CODECSReady = true; } return _ALL_CODECSContent; } }
        private static int _ALL_CODECSContent = default;
        private static bool _ALL_CODECSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#REGULAR_CODECS"/>
        /// </summary>
        public static int REGULAR_CODECS { get { if (!_REGULAR_CODECSReady) { _REGULAR_CODECSContent = SGetField<int>(LocalBridgeClazz, "REGULAR_CODECS"); _REGULAR_CODECSReady = true; } return _REGULAR_CODECSContent; } }
        private static int _REGULAR_CODECSContent = default;
        private static bool _REGULAR_CODECSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#getCodecInfoAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.MediaCodecInfo"/></returns>
        [global::System.Obsolete()]
        public static Android.Media.MediaCodecInfo GetCodecInfoAt(int arg0)
        {
            return SExecuteWithSignature<Android.Media.MediaCodecInfo>(LocalBridgeClazz, "getCodecInfoAt", "(I)Landroid/media/MediaCodecInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#getCodecCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetCodecCount()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getCodecCount", "()I");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#getCodecInfos()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.MediaCodecInfo"/></returns>
        public Android.Media.MediaCodecInfo[] GetCodecInfos()
        {
            return IExecuteWithSignatureArray<Android.Media.MediaCodecInfo>("getCodecInfos", "()[Landroid/media/MediaCodecInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#findDecoderForFormat(android.media.MediaFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaFormat"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindDecoderForFormat(Android.Media.MediaFormat arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("findDecoderForFormat", "(Landroid/media/MediaFormat;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCodecList.html#findEncoderForFormat(android.media.MediaFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaFormat"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindEncoderForFormat(Android.Media.MediaFormat arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("findEncoderForFormat", "(Landroid/media/MediaFormat;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}