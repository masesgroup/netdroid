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

namespace Android.Bluetooth
{
    #region BluetoothCodecConfig
    public partial class BluetoothCodecConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#BITS_PER_SAMPLE_16"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_16 { get { if (!_BITS_PER_SAMPLE_16Ready) { _BITS_PER_SAMPLE_16Content = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_16"); _BITS_PER_SAMPLE_16Ready = true; } return _BITS_PER_SAMPLE_16Content; } }
        private static int _BITS_PER_SAMPLE_16Content = default;
        private static bool _BITS_PER_SAMPLE_16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#BITS_PER_SAMPLE_24"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_24 { get { if (!_BITS_PER_SAMPLE_24Ready) { _BITS_PER_SAMPLE_24Content = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_24"); _BITS_PER_SAMPLE_24Ready = true; } return _BITS_PER_SAMPLE_24Content; } }
        private static int _BITS_PER_SAMPLE_24Content = default;
        private static bool _BITS_PER_SAMPLE_24Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#BITS_PER_SAMPLE_32"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_32 { get { if (!_BITS_PER_SAMPLE_32Ready) { _BITS_PER_SAMPLE_32Content = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_32"); _BITS_PER_SAMPLE_32Ready = true; } return _BITS_PER_SAMPLE_32Content; } }
        private static int _BITS_PER_SAMPLE_32Content = default;
        private static bool _BITS_PER_SAMPLE_32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#BITS_PER_SAMPLE_NONE"/>
        /// </summary>
        public static int BITS_PER_SAMPLE_NONE { get { if (!_BITS_PER_SAMPLE_NONEReady) { _BITS_PER_SAMPLE_NONEContent = SGetField<int>(LocalBridgeClazz, "BITS_PER_SAMPLE_NONE"); _BITS_PER_SAMPLE_NONEReady = true; } return _BITS_PER_SAMPLE_NONEContent; } }
        private static int _BITS_PER_SAMPLE_NONEContent = default;
        private static bool _BITS_PER_SAMPLE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CHANNEL_MODE_MONO"/>
        /// </summary>
        public static int CHANNEL_MODE_MONO { get { if (!_CHANNEL_MODE_MONOReady) { _CHANNEL_MODE_MONOContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_MODE_MONO"); _CHANNEL_MODE_MONOReady = true; } return _CHANNEL_MODE_MONOContent; } }
        private static int _CHANNEL_MODE_MONOContent = default;
        private static bool _CHANNEL_MODE_MONOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CHANNEL_MODE_NONE"/>
        /// </summary>
        public static int CHANNEL_MODE_NONE { get { if (!_CHANNEL_MODE_NONEReady) { _CHANNEL_MODE_NONEContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_MODE_NONE"); _CHANNEL_MODE_NONEReady = true; } return _CHANNEL_MODE_NONEContent; } }
        private static int _CHANNEL_MODE_NONEContent = default;
        private static bool _CHANNEL_MODE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CHANNEL_MODE_STEREO"/>
        /// </summary>
        public static int CHANNEL_MODE_STEREO { get { if (!_CHANNEL_MODE_STEREOReady) { _CHANNEL_MODE_STEREOContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_MODE_STEREO"); _CHANNEL_MODE_STEREOReady = true; } return _CHANNEL_MODE_STEREOContent; } }
        private static int _CHANNEL_MODE_STEREOContent = default;
        private static bool _CHANNEL_MODE_STEREOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CODEC_PRIORITY_DEFAULT"/>
        /// </summary>
        public static int CODEC_PRIORITY_DEFAULT { get { if (!_CODEC_PRIORITY_DEFAULTReady) { _CODEC_PRIORITY_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "CODEC_PRIORITY_DEFAULT"); _CODEC_PRIORITY_DEFAULTReady = true; } return _CODEC_PRIORITY_DEFAULTContent; } }
        private static int _CODEC_PRIORITY_DEFAULTContent = default;
        private static bool _CODEC_PRIORITY_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CODEC_PRIORITY_DISABLED"/>
        /// </summary>
        public static int CODEC_PRIORITY_DISABLED { get { if (!_CODEC_PRIORITY_DISABLEDReady) { _CODEC_PRIORITY_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "CODEC_PRIORITY_DISABLED"); _CODEC_PRIORITY_DISABLEDReady = true; } return _CODEC_PRIORITY_DISABLEDContent; } }
        private static int _CODEC_PRIORITY_DISABLEDContent = default;
        private static bool _CODEC_PRIORITY_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#CODEC_PRIORITY_HIGHEST"/>
        /// </summary>
        public static int CODEC_PRIORITY_HIGHEST { get { if (!_CODEC_PRIORITY_HIGHESTReady) { _CODEC_PRIORITY_HIGHESTContent = SGetField<int>(LocalBridgeClazz, "CODEC_PRIORITY_HIGHEST"); _CODEC_PRIORITY_HIGHESTReady = true; } return _CODEC_PRIORITY_HIGHESTContent; } }
        private static int _CODEC_PRIORITY_HIGHESTContent = default;
        private static bool _CODEC_PRIORITY_HIGHESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_176400"/>
        /// </summary>
        public static int SAMPLE_RATE_176400 { get { if (!_SAMPLE_RATE_176400Ready) { _SAMPLE_RATE_176400Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_176400"); _SAMPLE_RATE_176400Ready = true; } return _SAMPLE_RATE_176400Content; } }
        private static int _SAMPLE_RATE_176400Content = default;
        private static bool _SAMPLE_RATE_176400Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_192000"/>
        /// </summary>
        public static int SAMPLE_RATE_192000 { get { if (!_SAMPLE_RATE_192000Ready) { _SAMPLE_RATE_192000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_192000"); _SAMPLE_RATE_192000Ready = true; } return _SAMPLE_RATE_192000Content; } }
        private static int _SAMPLE_RATE_192000Content = default;
        private static bool _SAMPLE_RATE_192000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_44100"/>
        /// </summary>
        public static int SAMPLE_RATE_44100 { get { if (!_SAMPLE_RATE_44100Ready) { _SAMPLE_RATE_44100Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_44100"); _SAMPLE_RATE_44100Ready = true; } return _SAMPLE_RATE_44100Content; } }
        private static int _SAMPLE_RATE_44100Content = default;
        private static bool _SAMPLE_RATE_44100Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_48000"/>
        /// </summary>
        public static int SAMPLE_RATE_48000 { get { if (!_SAMPLE_RATE_48000Ready) { _SAMPLE_RATE_48000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_48000"); _SAMPLE_RATE_48000Ready = true; } return _SAMPLE_RATE_48000Content; } }
        private static int _SAMPLE_RATE_48000Content = default;
        private static bool _SAMPLE_RATE_48000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_88200"/>
        /// </summary>
        public static int SAMPLE_RATE_88200 { get { if (!_SAMPLE_RATE_88200Ready) { _SAMPLE_RATE_88200Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_88200"); _SAMPLE_RATE_88200Ready = true; } return _SAMPLE_RATE_88200Content; } }
        private static int _SAMPLE_RATE_88200Content = default;
        private static bool _SAMPLE_RATE_88200Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_96000"/>
        /// </summary>
        public static int SAMPLE_RATE_96000 { get { if (!_SAMPLE_RATE_96000Ready) { _SAMPLE_RATE_96000Content = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_96000"); _SAMPLE_RATE_96000Ready = true; } return _SAMPLE_RATE_96000Content; } }
        private static int _SAMPLE_RATE_96000Content = default;
        private static bool _SAMPLE_RATE_96000Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SAMPLE_RATE_NONE"/>
        /// </summary>
        public static int SAMPLE_RATE_NONE { get { if (!_SAMPLE_RATE_NONEReady) { _SAMPLE_RATE_NONEContent = SGetField<int>(LocalBridgeClazz, "SAMPLE_RATE_NONE"); _SAMPLE_RATE_NONEReady = true; } return _SAMPLE_RATE_NONEContent; } }
        private static int _SAMPLE_RATE_NONEContent = default;
        private static bool _SAMPLE_RATE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_AAC"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_AAC { get { if (!_SOURCE_CODEC_TYPE_AACReady) { _SOURCE_CODEC_TYPE_AACContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_AAC"); _SOURCE_CODEC_TYPE_AACReady = true; } return _SOURCE_CODEC_TYPE_AACContent; } }
        private static int _SOURCE_CODEC_TYPE_AACContent = default;
        private static bool _SOURCE_CODEC_TYPE_AACReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_APTX"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_APTX { get { if (!_SOURCE_CODEC_TYPE_APTXReady) { _SOURCE_CODEC_TYPE_APTXContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_APTX"); _SOURCE_CODEC_TYPE_APTXReady = true; } return _SOURCE_CODEC_TYPE_APTXContent; } }
        private static int _SOURCE_CODEC_TYPE_APTXContent = default;
        private static bool _SOURCE_CODEC_TYPE_APTXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_APTX_HD"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_APTX_HD { get { if (!_SOURCE_CODEC_TYPE_APTX_HDReady) { _SOURCE_CODEC_TYPE_APTX_HDContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_APTX_HD"); _SOURCE_CODEC_TYPE_APTX_HDReady = true; } return _SOURCE_CODEC_TYPE_APTX_HDContent; } }
        private static int _SOURCE_CODEC_TYPE_APTX_HDContent = default;
        private static bool _SOURCE_CODEC_TYPE_APTX_HDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_INVALID"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_INVALID { get { if (!_SOURCE_CODEC_TYPE_INVALIDReady) { _SOURCE_CODEC_TYPE_INVALIDContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_INVALID"); _SOURCE_CODEC_TYPE_INVALIDReady = true; } return _SOURCE_CODEC_TYPE_INVALIDContent; } }
        private static int _SOURCE_CODEC_TYPE_INVALIDContent = default;
        private static bool _SOURCE_CODEC_TYPE_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_LC3"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_LC3 { get { if (!_SOURCE_CODEC_TYPE_LC3Ready) { _SOURCE_CODEC_TYPE_LC3Content = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_LC3"); _SOURCE_CODEC_TYPE_LC3Ready = true; } return _SOURCE_CODEC_TYPE_LC3Content; } }
        private static int _SOURCE_CODEC_TYPE_LC3Content = default;
        private static bool _SOURCE_CODEC_TYPE_LC3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_LDAC"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_LDAC { get { if (!_SOURCE_CODEC_TYPE_LDACReady) { _SOURCE_CODEC_TYPE_LDACContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_LDAC"); _SOURCE_CODEC_TYPE_LDACReady = true; } return _SOURCE_CODEC_TYPE_LDACContent; } }
        private static int _SOURCE_CODEC_TYPE_LDACContent = default;
        private static bool _SOURCE_CODEC_TYPE_LDACReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_OPUS"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_OPUS { get { if (!_SOURCE_CODEC_TYPE_OPUSReady) { _SOURCE_CODEC_TYPE_OPUSContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_OPUS"); _SOURCE_CODEC_TYPE_OPUSReady = true; } return _SOURCE_CODEC_TYPE_OPUSContent; } }
        private static int _SOURCE_CODEC_TYPE_OPUSContent = default;
        private static bool _SOURCE_CODEC_TYPE_OPUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#SOURCE_CODEC_TYPE_SBC"/>
        /// </summary>
        public static int SOURCE_CODEC_TYPE_SBC { get { if (!_SOURCE_CODEC_TYPE_SBCReady) { _SOURCE_CODEC_TYPE_SBCContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CODEC_TYPE_SBC"); _SOURCE_CODEC_TYPE_SBCReady = true; } return _SOURCE_CODEC_TYPE_SBCContent; } }
        private static int _SOURCE_CODEC_TYPE_SBCContent = default;
        private static bool _SOURCE_CODEC_TYPE_SBCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#isMandatoryCodec()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMandatoryCodec()
        {
            return IExecuteWithSignature<bool>("isMandatoryCodec", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getBitsPerSample()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBitsPerSample()
        {
            return IExecuteWithSignature<int>("getBitsPerSample", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getChannelMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChannelMode()
        {
            return IExecuteWithSignature<int>("getChannelMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getCodecPriority()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCodecPriority()
        {
            return IExecuteWithSignature<int>("getCodecPriority", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getCodecType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCodecType()
        {
            return IExecuteWithSignature<int>("getCodecType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getSampleRate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSampleRate()
        {
            return IExecuteWithSignature<int>("getSampleRate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getCodecSpecific1()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCodecSpecific1()
        {
            return IExecuteWithSignature<long>("getCodecSpecific1", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getCodecSpecific2()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCodecSpecific2()
        {
            return IExecuteWithSignature<long>("getCodecSpecific2", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getCodecSpecific3()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCodecSpecific3()
        {
            return IExecuteWithSignature<long>("getCodecSpecific3", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#getCodecSpecific4()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCodecSpecific4()
        {
            return IExecuteWithSignature<long>("getCodecSpecific4", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig>("build", "()Landroid/bluetooth/BluetoothCodecConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setBitsPerSample(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetBitsPerSample(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setBitsPerSample", "(I)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setChannelMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetChannelMode(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setChannelMode", "(I)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setCodecPriority(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetCodecPriority(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setCodecPriority", "(I)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setCodecSpecific1(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetCodecSpecific1(long arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setCodecSpecific1", "(J)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setCodecSpecific2(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetCodecSpecific2(long arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setCodecSpecific2", "(J)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setCodecSpecific3(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetCodecSpecific3(long arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setCodecSpecific3", "(J)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setCodecSpecific4(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetCodecSpecific4(long arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setCodecSpecific4", "(J)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setCodecType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetCodecType(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setCodecType", "(I)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecConfig.Builder.html#setSampleRate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecConfig.Builder SetSampleRate(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig.Builder>("setSampleRate", "(I)Landroid/bluetooth/BluetoothCodecConfig$Builder;", arg0);
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