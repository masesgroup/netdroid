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

namespace Android.Bluetooth
{
    #region BluetoothLeAudioCodecConfig
    public partial class BluetoothLeAudioCodecConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#BITS_PER_SAMPLE_16"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_16 { get { if (!_BITS_PER_SAMPLE_16Ready) { _BITS_PER_SAMPLE_16Content = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_16"); _BITS_PER_SAMPLE_16Ready = true; } return _BITS_PER_SAMPLE_16Content; } }
        private static int _BITS_PER_SAMPLE_16Content = default;
        private static bool _BITS_PER_SAMPLE_16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#BITS_PER_SAMPLE_24"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_24 { get { if (!_BITS_PER_SAMPLE_24Ready) { _BITS_PER_SAMPLE_24Content = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_24"); _BITS_PER_SAMPLE_24Ready = true; } return _BITS_PER_SAMPLE_24Content; } }
        private static int _BITS_PER_SAMPLE_24Content = default;
        private static bool _BITS_PER_SAMPLE_24Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#BITS_PER_SAMPLE_32"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_32 { get { if (!_BITS_PER_SAMPLE_32Ready) { _BITS_PER_SAMPLE_32Content = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_32"); _BITS_PER_SAMPLE_32Ready = true; } return _BITS_PER_SAMPLE_32Content; } }
        private static int _BITS_PER_SAMPLE_32Content = default;
        private static bool _BITS_PER_SAMPLE_32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#BITS_PER_SAMPLE_NONE"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_NONE { get { if (!_BITS_PER_SAMPLE_NONEReady) { _BITS_PER_SAMPLE_NONEContent = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_NONE"); _BITS_PER_SAMPLE_NONEReady = true; } return _BITS_PER_SAMPLE_NONEContent; } }
        private static int _BITS_PER_SAMPLE_NONEContent = default;
        private static bool _BITS_PER_SAMPLE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CHANNEL_COUNT_1"/>
        /// </summary>
        public static int CHANNEL_COUNT_1 { get { if (!_CHANNEL_COUNT_1Ready) { _CHANNEL_COUNT_1Content = SGetField<int>(LocalBridgeClazz, "CHANNEL_COUNT_1"); _CHANNEL_COUNT_1Ready = true; } return _CHANNEL_COUNT_1Content; } }
        private static int _CHANNEL_COUNT_1Content = default;
        private static bool _CHANNEL_COUNT_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CHANNEL_COUNT_2"/>
        /// </summary>
        public static int CHANNEL_COUNT_2 { get { if (!_CHANNEL_COUNT_2Ready) { _CHANNEL_COUNT_2Content = SGetField<int>(LocalBridgeClazz, "CHANNEL_COUNT_2"); _CHANNEL_COUNT_2Ready = true; } return _CHANNEL_COUNT_2Content; } }
        private static int _CHANNEL_COUNT_2Content = default;
        private static bool _CHANNEL_COUNT_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CHANNEL_COUNT_NONE"/>
        /// </summary>
        public static int CHANNEL_COUNT_NONE { get { if (!_CHANNEL_COUNT_NONEReady) { _CHANNEL_COUNT_NONEContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_COUNT_NONE"); _CHANNEL_COUNT_NONEReady = true; } return _CHANNEL_COUNT_NONEContent; } }
        private static int _CHANNEL_COUNT_NONEContent = default;
        private static bool _CHANNEL_COUNT_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CODEC_PRIORITY_DEFAULT"/>
        /// </summary>
        public static int CODEC_PRIORITY_DEFAULT { get { if (!_CODEC_PRIORITY_DEFAULTReady) { _CODEC_PRIORITY_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "CODEC_PRIORITY_DEFAULT"); _CODEC_PRIORITY_DEFAULTReady = true; } return _CODEC_PRIORITY_DEFAULTContent; } }
        private static int _CODEC_PRIORITY_DEFAULTContent = default;
        private static bool _CODEC_PRIORITY_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CODEC_PRIORITY_DISABLED"/>
        /// </summary>
        public static int CODEC_PRIORITY_DISABLED { get { if (!_CODEC_PRIORITY_DISABLEDReady) { _CODEC_PRIORITY_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "CODEC_PRIORITY_DISABLED"); _CODEC_PRIORITY_DISABLEDReady = true; } return _CODEC_PRIORITY_DISABLEDContent; } }
        private static int _CODEC_PRIORITY_DISABLEDContent = default;
        private static bool _CODEC_PRIORITY_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#CODEC_PRIORITY_HIGHEST"/>
        /// </summary>
        public static int CODEC_PRIORITY_HIGHEST { get { if (!_CODEC_PRIORITY_HIGHESTReady) { _CODEC_PRIORITY_HIGHESTContent = SGetField<int>(LocalBridgeClazz, "CODEC_PRIORITY_HIGHEST"); _CODEC_PRIORITY_HIGHESTReady = true; } return _CODEC_PRIORITY_HIGHESTContent; } }
        private static int _CODEC_PRIORITY_HIGHESTContent = default;
        private static bool _CODEC_PRIORITY_HIGHESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#FRAME_DURATION_10000"/>
        /// </summary>
        public static int FRAME_DURATION_10000 { get { if (!_FRAME_DURATION_10000Ready) { _FRAME_DURATION_10000Content = SGetField<int>(LocalBridgeClazz, "FRAME_DURATION_10000"); _FRAME_DURATION_10000Ready = true; } return _FRAME_DURATION_10000Content; } }
        private static int _FRAME_DURATION_10000Content = default;
        private static bool _FRAME_DURATION_10000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#FRAME_DURATION_7500"/>
        /// </summary>
        public static int FRAME_DURATION_7500 { get { if (!_FRAME_DURATION_7500Ready) { _FRAME_DURATION_7500Content = SGetField<int>(LocalBridgeClazz, "FRAME_DURATION_7500"); _FRAME_DURATION_7500Ready = true; } return _FRAME_DURATION_7500Content; } }
        private static int _FRAME_DURATION_7500Content = default;
        private static bool _FRAME_DURATION_7500Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#FRAME_DURATION_NONE"/>
        /// </summary>
        public static int FRAME_DURATION_NONE { get { if (!_FRAME_DURATION_NONEReady) { _FRAME_DURATION_NONEContent = SGetField<int>(LocalBridgeClazz, "FRAME_DURATION_NONE"); _FRAME_DURATION_NONEReady = true; } return _FRAME_DURATION_NONEContent; } }
        private static int _FRAME_DURATION_NONEContent = default;
        private static bool _FRAME_DURATION_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_11025"/>
        /// </summary>
        public static int SAMPLE_RATE_11025 { get { if (!_SAMPLE_RATE_11025Ready) { _SAMPLE_RATE_11025Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_11025"); _SAMPLE_RATE_11025Ready = true; } return _SAMPLE_RATE_11025Content; } }
        private static int _SAMPLE_RATE_11025Content = default;
        private static bool _SAMPLE_RATE_11025Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_16000"/>
        /// </summary>
        public static int SAMPLE_RATE_16000 { get { if (!_SAMPLE_RATE_16000Ready) { _SAMPLE_RATE_16000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_16000"); _SAMPLE_RATE_16000Ready = true; } return _SAMPLE_RATE_16000Content; } }
        private static int _SAMPLE_RATE_16000Content = default;
        private static bool _SAMPLE_RATE_16000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_176400"/>
        /// </summary>
        public static int SAMPLE_RATE_176400 { get { if (!_SAMPLE_RATE_176400Ready) { _SAMPLE_RATE_176400Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_176400"); _SAMPLE_RATE_176400Ready = true; } return _SAMPLE_RATE_176400Content; } }
        private static int _SAMPLE_RATE_176400Content = default;
        private static bool _SAMPLE_RATE_176400Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_192000"/>
        /// </summary>
        public static int SAMPLE_RATE_192000 { get { if (!_SAMPLE_RATE_192000Ready) { _SAMPLE_RATE_192000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_192000"); _SAMPLE_RATE_192000Ready = true; } return _SAMPLE_RATE_192000Content; } }
        private static int _SAMPLE_RATE_192000Content = default;
        private static bool _SAMPLE_RATE_192000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_22050"/>
        /// </summary>
        public static int SAMPLE_RATE_22050 { get { if (!_SAMPLE_RATE_22050Ready) { _SAMPLE_RATE_22050Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_22050"); _SAMPLE_RATE_22050Ready = true; } return _SAMPLE_RATE_22050Content; } }
        private static int _SAMPLE_RATE_22050Content = default;
        private static bool _SAMPLE_RATE_22050Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_24000"/>
        /// </summary>
        public static int SAMPLE_RATE_24000 { get { if (!_SAMPLE_RATE_24000Ready) { _SAMPLE_RATE_24000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_24000"); _SAMPLE_RATE_24000Ready = true; } return _SAMPLE_RATE_24000Content; } }
        private static int _SAMPLE_RATE_24000Content = default;
        private static bool _SAMPLE_RATE_24000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_32000"/>
        /// </summary>
        public static int SAMPLE_RATE_32000 { get { if (!_SAMPLE_RATE_32000Ready) { _SAMPLE_RATE_32000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_32000"); _SAMPLE_RATE_32000Ready = true; } return _SAMPLE_RATE_32000Content; } }
        private static int _SAMPLE_RATE_32000Content = default;
        private static bool _SAMPLE_RATE_32000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_384000"/>
        /// </summary>
        public static int SAMPLE_RATE_384000 { get { if (!_SAMPLE_RATE_384000Ready) { _SAMPLE_RATE_384000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_384000"); _SAMPLE_RATE_384000Ready = true; } return _SAMPLE_RATE_384000Content; } }
        private static int _SAMPLE_RATE_384000Content = default;
        private static bool _SAMPLE_RATE_384000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_44100"/>
        /// </summary>
        public static int SAMPLE_RATE_44100 { get { if (!_SAMPLE_RATE_44100Ready) { _SAMPLE_RATE_44100Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_44100"); _SAMPLE_RATE_44100Ready = true; } return _SAMPLE_RATE_44100Content; } }
        private static int _SAMPLE_RATE_44100Content = default;
        private static bool _SAMPLE_RATE_44100Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_48000"/>
        /// </summary>
        public static int SAMPLE_RATE_48000 { get { if (!_SAMPLE_RATE_48000Ready) { _SAMPLE_RATE_48000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_48000"); _SAMPLE_RATE_48000Ready = true; } return _SAMPLE_RATE_48000Content; } }
        private static int _SAMPLE_RATE_48000Content = default;
        private static bool _SAMPLE_RATE_48000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_8000"/>
        /// </summary>
        public static int SAMPLE_RATE_8000 { get { if (!_SAMPLE_RATE_8000Ready) { _SAMPLE_RATE_8000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_8000"); _SAMPLE_RATE_8000Ready = true; } return _SAMPLE_RATE_8000Content; } }
        private static int _SAMPLE_RATE_8000Content = default;
        private static bool _SAMPLE_RATE_8000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_88200"/>
        /// </summary>
        public static int SAMPLE_RATE_88200 { get { if (!_SAMPLE_RATE_88200Ready) { _SAMPLE_RATE_88200Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_88200"); _SAMPLE_RATE_88200Ready = true; } return _SAMPLE_RATE_88200Content; } }
        private static int _SAMPLE_RATE_88200Content = default;
        private static bool _SAMPLE_RATE_88200Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_96000"/>
        /// </summary>
        public static int SAMPLE_RATE_96000 { get { if (!_SAMPLE_RATE_96000Ready) { _SAMPLE_RATE_96000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_96000"); _SAMPLE_RATE_96000Ready = true; } return _SAMPLE_RATE_96000Content; } }
        private static int _SAMPLE_RATE_96000Content = default;
        private static bool _SAMPLE_RATE_96000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SAMPLE_RATE_NONE"/>
        /// </summary>
        public static int SAMPLE_RATE_NONE { get { if (!_SAMPLE_RATE_NONEReady) { _SAMPLE_RATE_NONEContent = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_NONE"); _SAMPLE_RATE_NONEReady = true; } return _SAMPLE_RATE_NONEContent; } }
        private static int _SAMPLE_RATE_NONEContent = default;
        private static bool _SAMPLE_RATE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SOURCE_CODEC_TYPE_INVALID"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_INVALID { get { if (!_SOURCE_CODEC_TYPE_INVALIDReady) { _SOURCE_CODEC_TYPE_INVALIDContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_INVALID"); _SOURCE_CODEC_TYPE_INVALIDReady = true; } return _SOURCE_CODEC_TYPE_INVALIDContent; } }
        private static int _SOURCE_CODEC_TYPE_INVALIDContent = default;
        private static bool _SOURCE_CODEC_TYPE_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#SOURCE_CODEC_TYPE_LC3"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_LC3 { get { if (!_SOURCE_CODEC_TYPE_LC3Ready) { _SOURCE_CODEC_TYPE_LC3Content = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_LC3"); _SOURCE_CODEC_TYPE_LC3Ready = true; } return _SOURCE_CODEC_TYPE_LC3Content; } }
        private static int _SOURCE_CODEC_TYPE_LC3Content = default;
        private static bool _SOURCE_CODEC_TYPE_LC3Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getBitsPerSample()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBitsPerSample()
        {
            return IExecuteWithSignature<int>("getBitsPerSample", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getChannelCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChannelCount()
        {
            return IExecuteWithSignature<int>("getChannelCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getCodecPriority()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCodecPriority()
        {
            return IExecuteWithSignature<int>("getCodecPriority", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getCodecType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCodecType()
        {
            return IExecuteWithSignature<int>("getCodecType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getFrameDuration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFrameDuration()
        {
            return IExecuteWithSignature<int>("getFrameDuration", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getMaxOctetsPerFrame()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxOctetsPerFrame()
        {
            return IExecuteWithSignature<int>("getMaxOctetsPerFrame", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getMinOctetsPerFrame()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinOctetsPerFrame()
        {
            return IExecuteWithSignature<int>("getMinOctetsPerFrame", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getOctetsPerFrame()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOctetsPerFrame()
        {
            return IExecuteWithSignature<int>("getOctetsPerFrame", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getSampleRate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSampleRate()
        {
            return IExecuteWithSignature<int>("getSampleRate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#getCodecName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCodecName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCodecName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#%3Cinit%3E(android.bluetooth.BluetoothLeAudioCodecConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig"/></param>
            public Builder(Android.Bluetooth.BluetoothLeAudioCodecConfig arg0)
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig>("build", "()Landroid/bluetooth/BluetoothLeAudioCodecConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setBitsPerSample(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetBitsPerSample(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setBitsPerSample", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setChannelCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetChannelCount(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setChannelCount", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setCodecPriority(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetCodecPriority(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setCodecPriority", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setCodecType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetCodecType(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setCodecType", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setFrameDuration(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetFrameDuration(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setFrameDuration", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setMaxOctetsPerFrame(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetMaxOctetsPerFrame(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setMaxOctetsPerFrame", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setMinOctetsPerFrame(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetMinOctetsPerFrame(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setMinOctetsPerFrame", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setOctetsPerFrame(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetOctetsPerFrame(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setOctetsPerFrame", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudioCodecConfig.Builder.html#setSampleRate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder SetSampleRate(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothLeAudioCodecConfig.Builder>("setSampleRate", "(I)Landroid/bluetooth/BluetoothLeAudioCodecConfig$Builder;", arg0);
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