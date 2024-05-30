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
    #region AudioProfile
    public partial class AudioProfile
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#AUDIO_ENCAPSULATION_TYPE_IEC61937"/>
        /// </summary>
        public static int AUDIO_ENCAPSULATION_TYPE_IEC61937 { get { if (!_AUDIO_ENCAPSULATION_TYPE_IEC61937Ready) { _AUDIO_ENCAPSULATION_TYPE_IEC61937Content = SGetField<int>(LocalBridgeClazz, "AUDIO_ENCAPSULATION_TYPE_IEC61937"); _AUDIO_ENCAPSULATION_TYPE_IEC61937Ready = true; } return _AUDIO_ENCAPSULATION_TYPE_IEC61937Content; } }
        private static int _AUDIO_ENCAPSULATION_TYPE_IEC61937Content = default;
        private static bool _AUDIO_ENCAPSULATION_TYPE_IEC61937Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#AUDIO_ENCAPSULATION_TYPE_NONE"/>
        /// </summary>
        public static int AUDIO_ENCAPSULATION_TYPE_NONE { get { if (!_AUDIO_ENCAPSULATION_TYPE_NONEReady) { _AUDIO_ENCAPSULATION_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "AUDIO_ENCAPSULATION_TYPE_NONE"); _AUDIO_ENCAPSULATION_TYPE_NONEReady = true; } return _AUDIO_ENCAPSULATION_TYPE_NONEContent; } }
        private static int _AUDIO_ENCAPSULATION_TYPE_NONEContent = default;
        private static bool _AUDIO_ENCAPSULATION_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#AUDIO_ENCAPSULATION_TYPE_PCM"/>
        /// </summary>
        public static int AUDIO_ENCAPSULATION_TYPE_PCM { get { if (!_AUDIO_ENCAPSULATION_TYPE_PCMReady) { _AUDIO_ENCAPSULATION_TYPE_PCMContent = SGetField<int>(LocalBridgeClazz, "AUDIO_ENCAPSULATION_TYPE_PCM"); _AUDIO_ENCAPSULATION_TYPE_PCMReady = true; } return _AUDIO_ENCAPSULATION_TYPE_PCMContent; } }
        private static int _AUDIO_ENCAPSULATION_TYPE_PCMContent = default;
        private static bool _AUDIO_ENCAPSULATION_TYPE_PCMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getChannelIndexMasks()"/> 
        /// </summary>
        public int[] ChannelIndexMasks
        {
            get { return IExecuteWithSignatureArray<int>("getChannelIndexMasks", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getChannelMasks()"/> 
        /// </summary>
        public int[] ChannelMasks
        {
            get { return IExecuteWithSignatureArray<int>("getChannelMasks", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getEncapsulationType()"/> 
        /// </summary>
        public int EncapsulationType
        {
            get { return IExecuteWithSignature<int>("getEncapsulationType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getFormat()"/> 
        /// </summary>
        public int Format
        {
            get { return IExecuteWithSignature<int>("getFormat", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getSampleRates()"/> 
        /// </summary>
        public int[] SampleRates
        {
            get { return IExecuteWithSignatureArray<int>("getSampleRates", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#writeToParcel(android.os.Parcel,int)"/>
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
}