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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region AudioProfile declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html"/>
    /// </summary>
    public partial class AudioProfile : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.media.AudioProfile";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AudioProfile() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AudioProfile(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AudioProfile implementation
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
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getEncapsulationType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEncapsulationType()
        {
            return IExecuteWithSignature<int>("getEncapsulationType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getFormat()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFormat()
        {
            return IExecuteWithSignature<int>("getFormat", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getChannelIndexMasks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetChannelIndexMasks()
        {
            return IExecuteWithSignatureArray<int>("getChannelIndexMasks", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getChannelMasks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetChannelMasks()
        {
            return IExecuteWithSignatureArray<int>("getChannelMasks", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#getSampleRates()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetSampleRates()
        {
            return IExecuteWithSignatureArray<int>("getSampleRates", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioProfile.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}