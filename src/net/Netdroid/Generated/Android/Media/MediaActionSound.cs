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
    #region MediaActionSound
    public partial class MediaActionSound
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#FOCUS_COMPLETE"/>
        /// </summary>
        public static int FOCUS_COMPLETE { get { if (!_FOCUS_COMPLETEReady) { _FOCUS_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "FOCUS_COMPLETE"); _FOCUS_COMPLETEReady = true; } return _FOCUS_COMPLETEContent; } }
        private static int _FOCUS_COMPLETEContent = default;
        private static bool _FOCUS_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#SHUTTER_CLICK"/>
        /// </summary>
        public static int SHUTTER_CLICK { get { if (!_SHUTTER_CLICKReady) { _SHUTTER_CLICKContent = SGetField<int>(LocalBridgeClazz, "SHUTTER_CLICK"); _SHUTTER_CLICKReady = true; } return _SHUTTER_CLICKContent; } }
        private static int _SHUTTER_CLICKContent = default;
        private static bool _SHUTTER_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#START_VIDEO_RECORDING"/>
        /// </summary>
        public static int START_VIDEO_RECORDING { get { if (!_START_VIDEO_RECORDINGReady) { _START_VIDEO_RECORDINGContent = SGetField<int>(LocalBridgeClazz, "START_VIDEO_RECORDING"); _START_VIDEO_RECORDINGReady = true; } return _START_VIDEO_RECORDINGContent; } }
        private static int _START_VIDEO_RECORDINGContent = default;
        private static bool _START_VIDEO_RECORDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#STOP_VIDEO_RECORDING"/>
        /// </summary>
        public static int STOP_VIDEO_RECORDING { get { if (!_STOP_VIDEO_RECORDINGReady) { _STOP_VIDEO_RECORDINGContent = SGetField<int>(LocalBridgeClazz, "STOP_VIDEO_RECORDING"); _STOP_VIDEO_RECORDINGReady = true; } return _STOP_VIDEO_RECORDINGContent; } }
        private static int _STOP_VIDEO_RECORDINGContent = default;
        private static bool _STOP_VIDEO_RECORDINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#mustPlayShutterSound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool MustPlayShutterSound()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "mustPlayShutterSound", "()Z");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#load(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Load(int arg0)
        {
            IExecuteWithSignature("load", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#play(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Play(int arg0)
        {
            IExecuteWithSignature("play", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaActionSound.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}