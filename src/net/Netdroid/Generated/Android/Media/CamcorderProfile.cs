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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region CamcorderProfile
    public partial class CamcorderProfile
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#audioBitRate"/>
        /// </summary>
        public int audioBitRate { get { return IGetField<int>("audioBitRate"); } set { ISetField("audioBitRate", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#audioChannels"/>
        /// </summary>
        public int audioChannels { get { return IGetField<int>("audioChannels"); } set { ISetField("audioChannels", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#audioCodec"/>
        /// </summary>
        public int audioCodec { get { return IGetField<int>("audioCodec"); } set { ISetField("audioCodec", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#audioSampleRate"/>
        /// </summary>
        public int audioSampleRate { get { return IGetField<int>("audioSampleRate"); } set { ISetField("audioSampleRate", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#duration"/>
        /// </summary>
        public int duration { get { return IGetField<int>("duration"); } set { ISetField("duration", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#fileFormat"/>
        /// </summary>
        public int fileFormat { get { return IGetField<int>("fileFormat"); } set { ISetField("fileFormat", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#quality"/>
        /// </summary>
        public int quality { get { return IGetField<int>("quality"); } set { ISetField("quality", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#videoBitRate"/>
        /// </summary>
        public int videoBitRate { get { return IGetField<int>("videoBitRate"); } set { ISetField("videoBitRate", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#videoCodec"/>
        /// </summary>
        public int videoCodec { get { return IGetField<int>("videoCodec"); } set { ISetField("videoCodec", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#videoFrameHeight"/>
        /// </summary>
        public int videoFrameHeight { get { return IGetField<int>("videoFrameHeight"); } set { ISetField("videoFrameHeight", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#videoFrameRate"/>
        /// </summary>
        public int videoFrameRate { get { return IGetField<int>("videoFrameRate"); } set { ISetField("videoFrameRate", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#videoFrameWidth"/>
        /// </summary>
        public int videoFrameWidth { get { return IGetField<int>("videoFrameWidth"); } set { ISetField("videoFrameWidth", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_1080P"/>
        /// </summary>
        public static int QUALITY_1080P { get { if (!_QUALITY_1080PReady) { _QUALITY_1080PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_1080P"); _QUALITY_1080PReady = true; } return _QUALITY_1080PContent; } }
        private static int _QUALITY_1080PContent = default;
        private static bool _QUALITY_1080PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_2160P"/>
        /// </summary>
        public static int QUALITY_2160P { get { if (!_QUALITY_2160PReady) { _QUALITY_2160PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_2160P"); _QUALITY_2160PReady = true; } return _QUALITY_2160PContent; } }
        private static int _QUALITY_2160PContent = default;
        private static bool _QUALITY_2160PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_2K"/>
        /// </summary>
        public static int QUALITY_2K { get { if (!_QUALITY_2KReady) { _QUALITY_2KContent = SGetField<int>(LocalBridgeClazz, "QUALITY_2K"); _QUALITY_2KReady = true; } return _QUALITY_2KContent; } }
        private static int _QUALITY_2KContent = default;
        private static bool _QUALITY_2KReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_480P"/>
        /// </summary>
        public static int QUALITY_480P { get { if (!_QUALITY_480PReady) { _QUALITY_480PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_480P"); _QUALITY_480PReady = true; } return _QUALITY_480PContent; } }
        private static int _QUALITY_480PContent = default;
        private static bool _QUALITY_480PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_4KDCI"/>
        /// </summary>
        public static int QUALITY_4KDCI { get { if (!_QUALITY_4KDCIReady) { _QUALITY_4KDCIContent = SGetField<int>(LocalBridgeClazz, "QUALITY_4KDCI"); _QUALITY_4KDCIReady = true; } return _QUALITY_4KDCIContent; } }
        private static int _QUALITY_4KDCIContent = default;
        private static bool _QUALITY_4KDCIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_720P"/>
        /// </summary>
        public static int QUALITY_720P { get { if (!_QUALITY_720PReady) { _QUALITY_720PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_720P"); _QUALITY_720PReady = true; } return _QUALITY_720PContent; } }
        private static int _QUALITY_720PContent = default;
        private static bool _QUALITY_720PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_8KUHD"/>
        /// </summary>
        public static int QUALITY_8KUHD { get { if (!_QUALITY_8KUHDReady) { _QUALITY_8KUHDContent = SGetField<int>(LocalBridgeClazz, "QUALITY_8KUHD"); _QUALITY_8KUHDReady = true; } return _QUALITY_8KUHDContent; } }
        private static int _QUALITY_8KUHDContent = default;
        private static bool _QUALITY_8KUHDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_CIF"/>
        /// </summary>
        public static int QUALITY_CIF { get { if (!_QUALITY_CIFReady) { _QUALITY_CIFContent = SGetField<int>(LocalBridgeClazz, "QUALITY_CIF"); _QUALITY_CIFReady = true; } return _QUALITY_CIFContent; } }
        private static int _QUALITY_CIFContent = default;
        private static bool _QUALITY_CIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH"/>
        /// </summary>
        public static int QUALITY_HIGH { get { if (!_QUALITY_HIGHReady) { _QUALITY_HIGHContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH"); _QUALITY_HIGHReady = true; } return _QUALITY_HIGHContent; } }
        private static int _QUALITY_HIGHContent = default;
        private static bool _QUALITY_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_1080P"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_1080P { get { if (!_QUALITY_HIGH_SPEED_1080PReady) { _QUALITY_HIGH_SPEED_1080PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_1080P"); _QUALITY_HIGH_SPEED_1080PReady = true; } return _QUALITY_HIGH_SPEED_1080PContent; } }
        private static int _QUALITY_HIGH_SPEED_1080PContent = default;
        private static bool _QUALITY_HIGH_SPEED_1080PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_2160P"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_2160P { get { if (!_QUALITY_HIGH_SPEED_2160PReady) { _QUALITY_HIGH_SPEED_2160PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_2160P"); _QUALITY_HIGH_SPEED_2160PReady = true; } return _QUALITY_HIGH_SPEED_2160PContent; } }
        private static int _QUALITY_HIGH_SPEED_2160PContent = default;
        private static bool _QUALITY_HIGH_SPEED_2160PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_480P"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_480P { get { if (!_QUALITY_HIGH_SPEED_480PReady) { _QUALITY_HIGH_SPEED_480PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_480P"); _QUALITY_HIGH_SPEED_480PReady = true; } return _QUALITY_HIGH_SPEED_480PContent; } }
        private static int _QUALITY_HIGH_SPEED_480PContent = default;
        private static bool _QUALITY_HIGH_SPEED_480PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_4KDCI"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_4KDCI { get { if (!_QUALITY_HIGH_SPEED_4KDCIReady) { _QUALITY_HIGH_SPEED_4KDCIContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_4KDCI"); _QUALITY_HIGH_SPEED_4KDCIReady = true; } return _QUALITY_HIGH_SPEED_4KDCIContent; } }
        private static int _QUALITY_HIGH_SPEED_4KDCIContent = default;
        private static bool _QUALITY_HIGH_SPEED_4KDCIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_720P"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_720P { get { if (!_QUALITY_HIGH_SPEED_720PReady) { _QUALITY_HIGH_SPEED_720PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_720P"); _QUALITY_HIGH_SPEED_720PReady = true; } return _QUALITY_HIGH_SPEED_720PContent; } }
        private static int _QUALITY_HIGH_SPEED_720PContent = default;
        private static bool _QUALITY_HIGH_SPEED_720PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_CIF"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_CIF { get { if (!_QUALITY_HIGH_SPEED_CIFReady) { _QUALITY_HIGH_SPEED_CIFContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_CIF"); _QUALITY_HIGH_SPEED_CIFReady = true; } return _QUALITY_HIGH_SPEED_CIFContent; } }
        private static int _QUALITY_HIGH_SPEED_CIFContent = default;
        private static bool _QUALITY_HIGH_SPEED_CIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_HIGH"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_HIGH { get { if (!_QUALITY_HIGH_SPEED_HIGHReady) { _QUALITY_HIGH_SPEED_HIGHContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_HIGH"); _QUALITY_HIGH_SPEED_HIGHReady = true; } return _QUALITY_HIGH_SPEED_HIGHContent; } }
        private static int _QUALITY_HIGH_SPEED_HIGHContent = default;
        private static bool _QUALITY_HIGH_SPEED_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_LOW"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_LOW { get { if (!_QUALITY_HIGH_SPEED_LOWReady) { _QUALITY_HIGH_SPEED_LOWContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_LOW"); _QUALITY_HIGH_SPEED_LOWReady = true; } return _QUALITY_HIGH_SPEED_LOWContent; } }
        private static int _QUALITY_HIGH_SPEED_LOWContent = default;
        private static bool _QUALITY_HIGH_SPEED_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_HIGH_SPEED_VGA"/>
        /// </summary>
        public static int QUALITY_HIGH_SPEED_VGA { get { if (!_QUALITY_HIGH_SPEED_VGAReady) { _QUALITY_HIGH_SPEED_VGAContent = SGetField<int>(LocalBridgeClazz, "QUALITY_HIGH_SPEED_VGA"); _QUALITY_HIGH_SPEED_VGAReady = true; } return _QUALITY_HIGH_SPEED_VGAContent; } }
        private static int _QUALITY_HIGH_SPEED_VGAContent = default;
        private static bool _QUALITY_HIGH_SPEED_VGAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_LOW"/>
        /// </summary>
        public static int QUALITY_LOW { get { if (!_QUALITY_LOWReady) { _QUALITY_LOWContent = SGetField<int>(LocalBridgeClazz, "QUALITY_LOW"); _QUALITY_LOWReady = true; } return _QUALITY_LOWContent; } }
        private static int _QUALITY_LOWContent = default;
        private static bool _QUALITY_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_QCIF"/>
        /// </summary>
        public static int QUALITY_QCIF { get { if (!_QUALITY_QCIFReady) { _QUALITY_QCIFContent = SGetField<int>(LocalBridgeClazz, "QUALITY_QCIF"); _QUALITY_QCIFReady = true; } return _QUALITY_QCIFContent; } }
        private static int _QUALITY_QCIFContent = default;
        private static bool _QUALITY_QCIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_QHD"/>
        /// </summary>
        public static int QUALITY_QHD { get { if (!_QUALITY_QHDReady) { _QUALITY_QHDContent = SGetField<int>(LocalBridgeClazz, "QUALITY_QHD"); _QUALITY_QHDReady = true; } return _QUALITY_QHDContent; } }
        private static int _QUALITY_QHDContent = default;
        private static bool _QUALITY_QHDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_QVGA"/>
        /// </summary>
        public static int QUALITY_QVGA { get { if (!_QUALITY_QVGAReady) { _QUALITY_QVGAContent = SGetField<int>(LocalBridgeClazz, "QUALITY_QVGA"); _QUALITY_QVGAReady = true; } return _QUALITY_QVGAContent; } }
        private static int _QUALITY_QVGAContent = default;
        private static bool _QUALITY_QVGAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_1080P"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_1080P { get { if (!_QUALITY_TIME_LAPSE_1080PReady) { _QUALITY_TIME_LAPSE_1080PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_1080P"); _QUALITY_TIME_LAPSE_1080PReady = true; } return _QUALITY_TIME_LAPSE_1080PContent; } }
        private static int _QUALITY_TIME_LAPSE_1080PContent = default;
        private static bool _QUALITY_TIME_LAPSE_1080PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_2160P"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_2160P { get { if (!_QUALITY_TIME_LAPSE_2160PReady) { _QUALITY_TIME_LAPSE_2160PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_2160P"); _QUALITY_TIME_LAPSE_2160PReady = true; } return _QUALITY_TIME_LAPSE_2160PContent; } }
        private static int _QUALITY_TIME_LAPSE_2160PContent = default;
        private static bool _QUALITY_TIME_LAPSE_2160PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_2K"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_2K { get { if (!_QUALITY_TIME_LAPSE_2KReady) { _QUALITY_TIME_LAPSE_2KContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_2K"); _QUALITY_TIME_LAPSE_2KReady = true; } return _QUALITY_TIME_LAPSE_2KContent; } }
        private static int _QUALITY_TIME_LAPSE_2KContent = default;
        private static bool _QUALITY_TIME_LAPSE_2KReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_480P"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_480P { get { if (!_QUALITY_TIME_LAPSE_480PReady) { _QUALITY_TIME_LAPSE_480PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_480P"); _QUALITY_TIME_LAPSE_480PReady = true; } return _QUALITY_TIME_LAPSE_480PContent; } }
        private static int _QUALITY_TIME_LAPSE_480PContent = default;
        private static bool _QUALITY_TIME_LAPSE_480PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_4KDCI"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_4KDCI { get { if (!_QUALITY_TIME_LAPSE_4KDCIReady) { _QUALITY_TIME_LAPSE_4KDCIContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_4KDCI"); _QUALITY_TIME_LAPSE_4KDCIReady = true; } return _QUALITY_TIME_LAPSE_4KDCIContent; } }
        private static int _QUALITY_TIME_LAPSE_4KDCIContent = default;
        private static bool _QUALITY_TIME_LAPSE_4KDCIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_720P"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_720P { get { if (!_QUALITY_TIME_LAPSE_720PReady) { _QUALITY_TIME_LAPSE_720PContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_720P"); _QUALITY_TIME_LAPSE_720PReady = true; } return _QUALITY_TIME_LAPSE_720PContent; } }
        private static int _QUALITY_TIME_LAPSE_720PContent = default;
        private static bool _QUALITY_TIME_LAPSE_720PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_8KUHD"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_8KUHD { get { if (!_QUALITY_TIME_LAPSE_8KUHDReady) { _QUALITY_TIME_LAPSE_8KUHDContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_8KUHD"); _QUALITY_TIME_LAPSE_8KUHDReady = true; } return _QUALITY_TIME_LAPSE_8KUHDContent; } }
        private static int _QUALITY_TIME_LAPSE_8KUHDContent = default;
        private static bool _QUALITY_TIME_LAPSE_8KUHDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_CIF"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_CIF { get { if (!_QUALITY_TIME_LAPSE_CIFReady) { _QUALITY_TIME_LAPSE_CIFContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_CIF"); _QUALITY_TIME_LAPSE_CIFReady = true; } return _QUALITY_TIME_LAPSE_CIFContent; } }
        private static int _QUALITY_TIME_LAPSE_CIFContent = default;
        private static bool _QUALITY_TIME_LAPSE_CIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_HIGH"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_HIGH { get { if (!_QUALITY_TIME_LAPSE_HIGHReady) { _QUALITY_TIME_LAPSE_HIGHContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_HIGH"); _QUALITY_TIME_LAPSE_HIGHReady = true; } return _QUALITY_TIME_LAPSE_HIGHContent; } }
        private static int _QUALITY_TIME_LAPSE_HIGHContent = default;
        private static bool _QUALITY_TIME_LAPSE_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_LOW"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_LOW { get { if (!_QUALITY_TIME_LAPSE_LOWReady) { _QUALITY_TIME_LAPSE_LOWContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_LOW"); _QUALITY_TIME_LAPSE_LOWReady = true; } return _QUALITY_TIME_LAPSE_LOWContent; } }
        private static int _QUALITY_TIME_LAPSE_LOWContent = default;
        private static bool _QUALITY_TIME_LAPSE_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_QCIF"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_QCIF { get { if (!_QUALITY_TIME_LAPSE_QCIFReady) { _QUALITY_TIME_LAPSE_QCIFContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_QCIF"); _QUALITY_TIME_LAPSE_QCIFReady = true; } return _QUALITY_TIME_LAPSE_QCIFContent; } }
        private static int _QUALITY_TIME_LAPSE_QCIFContent = default;
        private static bool _QUALITY_TIME_LAPSE_QCIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_QHD"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_QHD { get { if (!_QUALITY_TIME_LAPSE_QHDReady) { _QUALITY_TIME_LAPSE_QHDContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_QHD"); _QUALITY_TIME_LAPSE_QHDReady = true; } return _QUALITY_TIME_LAPSE_QHDContent; } }
        private static int _QUALITY_TIME_LAPSE_QHDContent = default;
        private static bool _QUALITY_TIME_LAPSE_QHDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_QVGA"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_QVGA { get { if (!_QUALITY_TIME_LAPSE_QVGAReady) { _QUALITY_TIME_LAPSE_QVGAContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_QVGA"); _QUALITY_TIME_LAPSE_QVGAReady = true; } return _QUALITY_TIME_LAPSE_QVGAContent; } }
        private static int _QUALITY_TIME_LAPSE_QVGAContent = default;
        private static bool _QUALITY_TIME_LAPSE_QVGAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_TIME_LAPSE_VGA"/>
        /// </summary>
        public static int QUALITY_TIME_LAPSE_VGA { get { if (!_QUALITY_TIME_LAPSE_VGAReady) { _QUALITY_TIME_LAPSE_VGAContent = SGetField<int>(LocalBridgeClazz, "QUALITY_TIME_LAPSE_VGA"); _QUALITY_TIME_LAPSE_VGAReady = true; } return _QUALITY_TIME_LAPSE_VGAContent; } }
        private static int _QUALITY_TIME_LAPSE_VGAContent = default;
        private static bool _QUALITY_TIME_LAPSE_VGAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#QUALITY_VGA"/>
        /// </summary>
        public static int QUALITY_VGA { get { if (!_QUALITY_VGAReady) { _QUALITY_VGAContent = SGetField<int>(LocalBridgeClazz, "QUALITY_VGA"); _QUALITY_VGAReady = true; } return _QUALITY_VGAContent; } }
        private static int _QUALITY_VGAContent = default;
        private static bool _QUALITY_VGAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#get(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.CamcorderProfile"/></returns>
        [global::System.Obsolete()]
        public static Android.Media.CamcorderProfile Get(int arg0, int arg1)
        {
            return SExecute<Android.Media.CamcorderProfile>(LocalBridgeClazz, "get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.CamcorderProfile"/></returns>
        [global::System.Obsolete()]
        public static Android.Media.CamcorderProfile Get(int arg0)
        {
            return SExecuteWithSignature<Android.Media.CamcorderProfile>(LocalBridgeClazz, "get", "(I)Landroid/media/CamcorderProfile;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#getAll(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.EncoderProfiles"/></returns>
        public static Android.Media.EncoderProfiles GetAll(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Android.Media.EncoderProfiles>(LocalBridgeClazz, "getAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#hasProfile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool HasProfile(int arg0, int arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "hasProfile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/CamcorderProfile.html#hasProfile(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool HasProfile(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "hasProfile", "(I)Z", arg0);
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