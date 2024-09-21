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
    #region AudioPresentation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html"/>
    /// </summary>
    public partial class AudioPresentation : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.media.AudioPresentation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AudioPresentation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AudioPresentation(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.media.AudioPresentation$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region AudioPresentation implementation
    public partial class AudioPresentation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_COMMENTARY"/>
        /// </summary>
        public static int CONTENT_COMMENTARY { get { if (!_CONTENT_COMMENTARYReady) { _CONTENT_COMMENTARYContent = SGetField<int>(LocalBridgeClazz, "CONTENT_COMMENTARY"); _CONTENT_COMMENTARYReady = true; } return _CONTENT_COMMENTARYContent; } }
        private static int _CONTENT_COMMENTARYContent = default;
        private static bool _CONTENT_COMMENTARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_DIALOG"/>
        /// </summary>
        public static int CONTENT_DIALOG { get { if (!_CONTENT_DIALOGReady) { _CONTENT_DIALOGContent = SGetField<int>(LocalBridgeClazz, "CONTENT_DIALOG"); _CONTENT_DIALOGReady = true; } return _CONTENT_DIALOGContent; } }
        private static int _CONTENT_DIALOGContent = default;
        private static bool _CONTENT_DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_EMERGENCY"/>
        /// </summary>
        public static int CONTENT_EMERGENCY { get { if (!_CONTENT_EMERGENCYReady) { _CONTENT_EMERGENCYContent = SGetField<int>(LocalBridgeClazz, "CONTENT_EMERGENCY"); _CONTENT_EMERGENCYReady = true; } return _CONTENT_EMERGENCYContent; } }
        private static int _CONTENT_EMERGENCYContent = default;
        private static bool _CONTENT_EMERGENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_HEARING_IMPAIRED"/>
        /// </summary>
        public static int CONTENT_HEARING_IMPAIRED { get { if (!_CONTENT_HEARING_IMPAIREDReady) { _CONTENT_HEARING_IMPAIREDContent = SGetField<int>(LocalBridgeClazz, "CONTENT_HEARING_IMPAIRED"); _CONTENT_HEARING_IMPAIREDReady = true; } return _CONTENT_HEARING_IMPAIREDContent; } }
        private static int _CONTENT_HEARING_IMPAIREDContent = default;
        private static bool _CONTENT_HEARING_IMPAIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_MAIN"/>
        /// </summary>
        public static int CONTENT_MAIN { get { if (!_CONTENT_MAINReady) { _CONTENT_MAINContent = SGetField<int>(LocalBridgeClazz, "CONTENT_MAIN"); _CONTENT_MAINReady = true; } return _CONTENT_MAINContent; } }
        private static int _CONTENT_MAINContent = default;
        private static bool _CONTENT_MAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_MUSIC_AND_EFFECTS"/>
        /// </summary>
        public static int CONTENT_MUSIC_AND_EFFECTS { get { if (!_CONTENT_MUSIC_AND_EFFECTSReady) { _CONTENT_MUSIC_AND_EFFECTSContent = SGetField<int>(LocalBridgeClazz, "CONTENT_MUSIC_AND_EFFECTS"); _CONTENT_MUSIC_AND_EFFECTSReady = true; } return _CONTENT_MUSIC_AND_EFFECTSContent; } }
        private static int _CONTENT_MUSIC_AND_EFFECTSContent = default;
        private static bool _CONTENT_MUSIC_AND_EFFECTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_UNKNOWN"/>
        /// </summary>
        public static int CONTENT_UNKNOWN { get { if (!_CONTENT_UNKNOWNReady) { _CONTENT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CONTENT_UNKNOWN"); _CONTENT_UNKNOWNReady = true; } return _CONTENT_UNKNOWNContent; } }
        private static int _CONTENT_UNKNOWNContent = default;
        private static bool _CONTENT_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_VISUALLY_IMPAIRED"/>
        /// </summary>
        public static int CONTENT_VISUALLY_IMPAIRED { get { if (!_CONTENT_VISUALLY_IMPAIREDReady) { _CONTENT_VISUALLY_IMPAIREDContent = SGetField<int>(LocalBridgeClazz, "CONTENT_VISUALLY_IMPAIRED"); _CONTENT_VISUALLY_IMPAIREDReady = true; } return _CONTENT_VISUALLY_IMPAIREDContent; } }
        private static int _CONTENT_VISUALLY_IMPAIREDContent = default;
        private static bool _CONTENT_VISUALLY_IMPAIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#CONTENT_VOICEOVER"/>
        /// </summary>
        public static int CONTENT_VOICEOVER { get { if (!_CONTENT_VOICEOVERReady) { _CONTENT_VOICEOVERContent = SGetField<int>(LocalBridgeClazz, "CONTENT_VOICEOVER"); _CONTENT_VOICEOVERReady = true; } return _CONTENT_VOICEOVERContent; } }
        private static int _CONTENT_VOICEOVERContent = default;
        private static bool _CONTENT_VOICEOVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#MASTERED_FOR_3D"/>
        /// </summary>
        public static int MASTERED_FOR_3D { get { if (!_MASTERED_FOR_3DReady) { _MASTERED_FOR_3DContent = SGetField<int>(LocalBridgeClazz, "MASTERED_FOR_3D"); _MASTERED_FOR_3DReady = true; } return _MASTERED_FOR_3DContent; } }
        private static int _MASTERED_FOR_3DContent = default;
        private static bool _MASTERED_FOR_3DReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#MASTERED_FOR_HEADPHONE"/>
        /// </summary>
        public static int MASTERED_FOR_HEADPHONE { get { if (!_MASTERED_FOR_HEADPHONEReady) { _MASTERED_FOR_HEADPHONEContent = SGetField<int>(LocalBridgeClazz, "MASTERED_FOR_HEADPHONE"); _MASTERED_FOR_HEADPHONEReady = true; } return _MASTERED_FOR_HEADPHONEContent; } }
        private static int _MASTERED_FOR_HEADPHONEContent = default;
        private static bool _MASTERED_FOR_HEADPHONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#MASTERED_FOR_STEREO"/>
        /// </summary>
        public static int MASTERED_FOR_STEREO { get { if (!_MASTERED_FOR_STEREOReady) { _MASTERED_FOR_STEREOContent = SGetField<int>(LocalBridgeClazz, "MASTERED_FOR_STEREO"); _MASTERED_FOR_STEREOReady = true; } return _MASTERED_FOR_STEREOContent; } }
        private static int _MASTERED_FOR_STEREOContent = default;
        private static bool _MASTERED_FOR_STEREOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#MASTERED_FOR_SURROUND"/>
        /// </summary>
        public static int MASTERED_FOR_SURROUND { get { if (!_MASTERED_FOR_SURROUNDReady) { _MASTERED_FOR_SURROUNDContent = SGetField<int>(LocalBridgeClazz, "MASTERED_FOR_SURROUND"); _MASTERED_FOR_SURROUNDReady = true; } return _MASTERED_FOR_SURROUNDContent; } }
        private static int _MASTERED_FOR_SURROUNDContent = default;
        private static bool _MASTERED_FOR_SURROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#MASTERING_NOT_INDICATED"/>
        /// </summary>
        public static int MASTERING_NOT_INDICATED { get { if (!_MASTERING_NOT_INDICATEDReady) { _MASTERING_NOT_INDICATEDContent = SGetField<int>(LocalBridgeClazz, "MASTERING_NOT_INDICATED"); _MASTERING_NOT_INDICATEDReady = true; } return _MASTERING_NOT_INDICATEDContent; } }
        private static int _MASTERING_NOT_INDICATEDContent = default;
        private static bool _MASTERING_NOT_INDICATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#PRESENTATION_ID_UNKNOWN"/>
        /// </summary>
        public static int PRESENTATION_ID_UNKNOWN { get { if (!_PRESENTATION_ID_UNKNOWNReady) { _PRESENTATION_ID_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "PRESENTATION_ID_UNKNOWN"); _PRESENTATION_ID_UNKNOWNReady = true; } return _PRESENTATION_ID_UNKNOWNContent; } }
        private static int _PRESENTATION_ID_UNKNOWNContent = default;
        private static bool _PRESENTATION_ID_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#PROGRAM_ID_UNKNOWN"/>
        /// </summary>
        public static int PROGRAM_ID_UNKNOWN { get { if (!_PROGRAM_ID_UNKNOWNReady) { _PROGRAM_ID_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "PROGRAM_ID_UNKNOWN"); _PROGRAM_ID_UNKNOWNReady = true; } return _PROGRAM_ID_UNKNOWNContent; } }
        private static int _PROGRAM_ID_UNKNOWNContent = default;
        private static bool _PROGRAM_ID_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#hasAudioDescription()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAudioDescription()
        {
            return IExecuteWithSignature<bool>("hasAudioDescription", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#hasDialogueEnhancement()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDialogueEnhancement()
        {
            return IExecuteWithSignature<bool>("hasDialogueEnhancement", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#hasSpokenSubtitles()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSpokenSubtitles()
        {
            return IExecuteWithSignature<bool>("hasSpokenSubtitles", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#getMasteringIndication()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMasteringIndication()
        {
            return IExecuteWithSignature<int>("getMasteringIndication", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#getPresentationId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPresentationId()
        {
            return IExecuteWithSignature<int>("getPresentationId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#getProgramId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProgramId()
        {
            return IExecuteWithSignature<int>("getProgramId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#getLabels()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Util.Locale, Java.Lang.String> GetLabels()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Util.Locale, Java.Lang.String>>("getLabels", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
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
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.AudioPresentation"/></returns>
            public Android.Media.AudioPresentation Build()
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation>("build", "()Landroid/media/AudioPresentation;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setHasAudioDescription(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetHasAudioDescription(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setHasAudioDescription", "(Z)Landroid/media/AudioPresentation$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setHasDialogueEnhancement(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetHasDialogueEnhancement(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setHasDialogueEnhancement", "(Z)Landroid/media/AudioPresentation$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setHasSpokenSubtitles(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetHasSpokenSubtitles(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setHasSpokenSubtitles", "(Z)Landroid/media/AudioPresentation$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setLabels(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetLabels(Java.Util.Map<Android.Icu.Util.ULocale, Java.Lang.CharSequence> arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setLabels", "(Ljava/util/Map;)Landroid/media/AudioPresentation$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setLocale(android.icu.util.ULocale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetLocale(Android.Icu.Util.ULocale arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setLocale", "(Landroid/icu/util/ULocale;)Landroid/media/AudioPresentation$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setMasteringIndication(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetMasteringIndication(int arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setMasteringIndication", "(I)Landroid/media/AudioPresentation$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioPresentation.Builder.html#setProgramId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.AudioPresentation.Builder"/></returns>
            public Android.Media.AudioPresentation.Builder SetProgramId(int arg0)
            {
                return IExecuteWithSignature<Android.Media.AudioPresentation.Builder>("setProgramId", "(I)Landroid/media/AudioPresentation$Builder;", arg0);
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