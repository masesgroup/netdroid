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

namespace Android.Telecom
{
    #region VideoProfile
    public partial class VideoProfile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public VideoProfile(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public VideoProfile(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#QUALITY_DEFAULT"/>
        /// </summary>
        public static int QUALITY_DEFAULT { get { if (!_QUALITY_DEFAULTReady) { _QUALITY_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "QUALITY_DEFAULT"); _QUALITY_DEFAULTReady = true; } return _QUALITY_DEFAULTContent; } }
        private static int _QUALITY_DEFAULTContent = default;
        private static bool _QUALITY_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#QUALITY_HIGH"/>
        /// </summary>
        public static int QUALITY_HIGH { get { if (!_QUALITY_HIGHReady) { _QUALITY_HIGHContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH"); _QUALITY_HIGHReady = true; } return _QUALITY_HIGHContent; } }
        private static int _QUALITY_HIGHContent = default;
        private static bool _QUALITY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#QUALITY_LOW"/>
        /// </summary>
        public static int QUALITY_LOW { get { if (!_QUALITY_LOWReady) { _QUALITY_LOWContent = SGetField<int>(LocalBridgeClazz, "QUALITY_LOW"); _QUALITY_LOWReady = true; } return _QUALITY_LOWContent; } }
        private static int _QUALITY_LOWContent = default;
        private static bool _QUALITY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#QUALITY_MEDIUM"/>
        /// </summary>
        public static int QUALITY_MEDIUM { get { if (!_QUALITY_MEDIUMReady) { _QUALITY_MEDIUMContent = SGetField<int>(LocalBridgeClazz, "QUALITY_MEDIUM"); _QUALITY_MEDIUMReady = true; } return _QUALITY_MEDIUMContent; } }
        private static int _QUALITY_MEDIUMContent = default;
        private static bool _QUALITY_MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#STATE_AUDIO_ONLY"/>
        /// </summary>
        public static int STATE_AUDIO_ONLY { get { if (!_STATE_AUDIO_ONLYReady) { _STATE_AUDIO_ONLYContent = SGetField<int>(LocalBridgeClazz, "STATE_AUDIO_ONLY"); _STATE_AUDIO_ONLYReady = true; } return _STATE_AUDIO_ONLYContent; } }
        private static int _STATE_AUDIO_ONLYContent = default;
        private static bool _STATE_AUDIO_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#STATE_BIDIRECTIONAL"/>
        /// </summary>
        public static int STATE_BIDIRECTIONAL { get { if (!_STATE_BIDIRECTIONALReady) { _STATE_BIDIRECTIONALContent = SGetField<int>(LocalBridgeClazz, "STATE_BIDIRECTIONAL"); _STATE_BIDIRECTIONALReady = true; } return _STATE_BIDIRECTIONALContent; } }
        private static int _STATE_BIDIRECTIONALContent = default;
        private static bool _STATE_BIDIRECTIONALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#STATE_PAUSED"/>
        /// </summary>
        public static int STATE_PAUSED { get { if (!_STATE_PAUSEDReady) { _STATE_PAUSEDContent = SGetField<int>(LocalBridgeClazz, "STATE_PAUSED"); _STATE_PAUSEDReady = true; } return _STATE_PAUSEDContent; } }
        private static int _STATE_PAUSEDContent = default;
        private static bool _STATE_PAUSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#STATE_RX_ENABLED"/>
        /// </summary>
        public static int STATE_RX_ENABLED { get { if (!_STATE_RX_ENABLEDReady) { _STATE_RX_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "STATE_RX_ENABLED"); _STATE_RX_ENABLEDReady = true; } return _STATE_RX_ENABLEDContent; } }
        private static int _STATE_RX_ENABLEDContent = default;
        private static bool _STATE_RX_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#STATE_TX_ENABLED"/>
        /// </summary>
        public static int STATE_TX_ENABLED { get { if (!_STATE_TX_ENABLEDReady) { _STATE_TX_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "STATE_TX_ENABLED"); _STATE_TX_ENABLEDReady = true; } return _STATE_TX_ENABLEDContent; } }
        private static int _STATE_TX_ENABLEDContent = default;
        private static bool _STATE_TX_ENABLEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#isAudioOnly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAudioOnly(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isAudioOnly", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#isBidirectional(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsBidirectional(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isBidirectional", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#isPaused(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPaused(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isPaused", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#isReceptionEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsReceptionEnabled(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isReceptionEnabled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#isTransmissionEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTransmissionEnabled(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isTransmissionEnabled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#isVideo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsVideo(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isVideo", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#videoStateToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String VideoStateToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "videoStateToString", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#getQuality()"/> 
        /// </summary>
        public int Quality
        {
            get { return IExecuteWithSignature<int>("getQuality", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#getVideoState()"/> 
        /// </summary>
        public int VideoState
        {
            get { return IExecuteWithSignature<int>("getVideoState", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region CameraCapabilities
        public partial class CameraCapabilities
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#%3Cinit%3E(int,int,boolean,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            public CameraCapabilities(int arg0, int arg1, bool arg2, float arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public CameraCapabilities(int arg0, int arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#getHeight()"/> 
            /// </summary>
            public int Height
            {
                get { return IExecuteWithSignature<int>("getHeight", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#getMaxZoom()"/> 
            /// </summary>
            public float MaxZoom
            {
                get { return IExecuteWithSignature<float>("getMaxZoom", "()F"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#getWidth()"/> 
            /// </summary>
            public int Width
            {
                get { return IExecuteWithSignature<int>("getWidth", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#isZoomSupported()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsZoomSupported()
            {
                return IExecuteWithSignature<bool>("isZoomSupported", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/VideoProfile.CameraCapabilities.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
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