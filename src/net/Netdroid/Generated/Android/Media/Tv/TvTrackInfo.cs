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

namespace Android.Media.Tv
{
    #region TvTrackInfo
    public partial class TvTrackInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#TYPE_AUDIO"/>
        /// </summary>
        public static int TYPE_AUDIO { get { if (!_TYPE_AUDIOReady) { _TYPE_AUDIOContent = SGetField<int>(LocalBridgeClazz, "TYPE_AUDIO"); _TYPE_AUDIOReady = true; } return _TYPE_AUDIOContent; } }
        private static int _TYPE_AUDIOContent = default;
        private static bool _TYPE_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#TYPE_SUBTITLE"/>
        /// </summary>
        public static int TYPE_SUBTITLE { get { if (!_TYPE_SUBTITLEReady) { _TYPE_SUBTITLEContent = SGetField<int>(LocalBridgeClazz, "TYPE_SUBTITLE"); _TYPE_SUBTITLEReady = true; } return _TYPE_SUBTITLEContent; } }
        private static int _TYPE_SUBTITLEContent = default;
        private static bool _TYPE_SUBTITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#TYPE_VIDEO"/>
        /// </summary>
        public static int TYPE_VIDEO { get { if (!_TYPE_VIDEOReady) { _TYPE_VIDEOContent = SGetField<int>(LocalBridgeClazz, "TYPE_VIDEO"); _TYPE_VIDEOReady = true; } return _TYPE_VIDEOContent; } }
        private static int _TYPE_VIDEOContent = default;
        private static bool _TYPE_VIDEOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getAudioChannelCount()"/> 
        /// </summary>
        public int AudioChannelCount
        {
            get { return IExecuteWithSignature<int>("getAudioChannelCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getAudioSampleRate()"/> 
        /// </summary>
        public int AudioSampleRate
        {
            get { return IExecuteWithSignature<int>("getAudioSampleRate", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.CharSequence Description
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getDescription", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getEncoding()"/> 
        /// </summary>
        public Java.Lang.String Encoding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getEncoding", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getExtra()"/> 
        /// </summary>
        public Android.Os.Bundle Extra
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtra", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getLanguage()"/> 
        /// </summary>
        public Java.Lang.String Language
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLanguage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getVideoActiveFormatDescription()"/> 
        /// </summary>
        public byte VideoActiveFormatDescription
        {
            get { return IExecuteWithSignature<byte>("getVideoActiveFormatDescription", "()B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getVideoFrameRate()"/> 
        /// </summary>
        public float VideoFrameRate
        {
            get { return IExecuteWithSignature<float>("getVideoFrameRate", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getVideoHeight()"/> 
        /// </summary>
        public int VideoHeight
        {
            get { return IExecuteWithSignature<int>("getVideoHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getVideoPixelAspectRatio()"/> 
        /// </summary>
        public float VideoPixelAspectRatio
        {
            get { return IExecuteWithSignature<float>("getVideoPixelAspectRatio", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#getVideoWidth()"/> 
        /// </summary>
        public int VideoWidth
        {
            get { return IExecuteWithSignature<int>("getVideoWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#isAudioDescription()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAudioDescription()
        {
            return IExecuteWithSignature<bool>("isAudioDescription", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#isEncrypted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEncrypted()
        {
            return IExecuteWithSignature<bool>("isEncrypted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#isHardOfHearing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHardOfHearing()
        {
            return IExecuteWithSignature<bool>("isHardOfHearing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#isSpokenSubtitle()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSpokenSubtitle()
        {
            return IExecuteWithSignature<bool>("isSpokenSubtitle", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#%3Cinit%3E(int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public Builder(int arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo"/></returns>
            public Android.Media.Tv.TvTrackInfo Build()
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo>("build", "()Landroid/media/tv/TvTrackInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setAudioChannelCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetAudioChannelCount(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setAudioChannelCount", "(I)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setAudioDescription(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetAudioDescription(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setAudioDescription", "(Z)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setAudioSampleRate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetAudioSampleRate(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setAudioSampleRate", "(I)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setDescription(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetDescription(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setDescription", "(Ljava/lang/CharSequence;)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setEncoding(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetEncoding(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setEncoding", "(Ljava/lang/String;)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setEncrypted(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetEncrypted(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setEncrypted", "(Z)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setExtra(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetExtra(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setExtra", "(Landroid/os/Bundle;)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setHardOfHearing(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetHardOfHearing(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setHardOfHearing", "(Z)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setLanguage(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetLanguage(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setLanguage", "(Ljava/lang/String;)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setSpokenSubtitle(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetSpokenSubtitle(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setSpokenSubtitle", "(Z)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setVideoActiveFormatDescription(byte)"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetVideoActiveFormatDescription(byte arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setVideoActiveFormatDescription", "(B)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setVideoFrameRate(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetVideoFrameRate(float arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setVideoFrameRate", "(F)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setVideoHeight(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetVideoHeight(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setVideoHeight", "(I)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setVideoPixelAspectRatio(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetVideoPixelAspectRatio(float arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setVideoPixelAspectRatio", "(F)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/tv/TvTrackInfo.Builder.html#setVideoWidth(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Tv.TvTrackInfo.Builder"/></returns>
            public Android.Media.Tv.TvTrackInfo.Builder SetVideoWidth(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Tv.TvTrackInfo.Builder>("setVideoWidth", "(I)Landroid/media/tv/TvTrackInfo$Builder;", arg0);
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