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
    #region ThumbnailUtils
    public partial class ThumbnailUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ThumbnailUtils.html#OPTIONS_RECYCLE_INPUT"/>
        /// </summary>
        public static int OPTIONS_RECYCLE_INPUT { get { if (!_OPTIONS_RECYCLE_INPUTReady) { _OPTIONS_RECYCLE_INPUTContent = SGetField<int>(LocalBridgeClazz, "OPTIONS_RECYCLE_INPUT"); _OPTIONS_RECYCLE_INPUTReady = true; } return _OPTIONS_RECYCLE_INPUTContent; } }
        private static int _OPTIONS_RECYCLE_INPUTContent = default;
        private static bool _OPTIONS_RECYCLE_INPUTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ThumbnailUtils.html#createAudioThumbnail(java.io.File,android.util.Size,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.Bitmap CreateAudioThumbnail(Java.Io.File arg0, Android.Util.Size arg1, Android.Os.CancellationSignal arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "createAudioThumbnail", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ThumbnailUtils.html#createImageThumbnail(java.io.File,android.util.Size,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.Bitmap CreateImageThumbnail(Java.Io.File arg0, Android.Util.Size arg1, Android.Os.CancellationSignal arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "createImageThumbnail", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ThumbnailUtils.html#createVideoThumbnail(java.io.File,android.util.Size,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.Bitmap CreateVideoThumbnail(Java.Io.File arg0, Android.Util.Size arg1, Android.Os.CancellationSignal arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "createVideoThumbnail", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ThumbnailUtils.html#extractThumbnail(android.graphics.Bitmap,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap ExtractThumbnail(Android.Graphics.Bitmap arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "extractThumbnail", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ThumbnailUtils.html#extractThumbnail(android.graphics.Bitmap,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap ExtractThumbnail(Android.Graphics.Bitmap arg0, int arg1, int arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "extractThumbnail", arg0, arg1, arg2);
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