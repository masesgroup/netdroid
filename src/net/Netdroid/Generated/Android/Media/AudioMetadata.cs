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
    #region AudioMetadata
    public partial class AudioMetadata
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.html#createMap()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.AudioMetadataMap"/></returns>
        public static Android.Media.AudioMetadataMap CreateMap()
        {
            return SExecuteWithSignature<Android.Media.AudioMetadataMap>(LocalBridgeClazz, "createMap", "()Landroid/media/AudioMetadataMap;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Format
        public partial class Format
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_ATMOS_PRESENT"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_ATMOS_PRESENT { get { if (!_KEY_ATMOS_PRESENTReady) { _KEY_ATMOS_PRESENTContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_ATMOS_PRESENT"); _KEY_ATMOS_PRESENTReady = true; } return _KEY_ATMOS_PRESENTContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_ATMOS_PRESENTContent = default;
            private static bool _KEY_ATMOS_PRESENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_AUDIO_ENCODING"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_AUDIO_ENCODING { get { if (!_KEY_AUDIO_ENCODINGReady) { _KEY_AUDIO_ENCODINGContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_AUDIO_ENCODING"); _KEY_AUDIO_ENCODINGReady = true; } return _KEY_AUDIO_ENCODINGContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_AUDIO_ENCODINGContent = default;
            private static bool _KEY_AUDIO_ENCODINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_BIT_RATE"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_BIT_RATE { get { if (!_KEY_BIT_RATEReady) { _KEY_BIT_RATEContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_BIT_RATE"); _KEY_BIT_RATEReady = true; } return _KEY_BIT_RATEContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_BIT_RATEContent = default;
            private static bool _KEY_BIT_RATEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_BIT_WIDTH"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_BIT_WIDTH { get { if (!_KEY_BIT_WIDTHReady) { _KEY_BIT_WIDTHContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_BIT_WIDTH"); _KEY_BIT_WIDTHReady = true; } return _KEY_BIT_WIDTHContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_BIT_WIDTHContent = default;
            private static bool _KEY_BIT_WIDTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_CHANNEL_MASK"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_CHANNEL_MASK { get { if (!_KEY_CHANNEL_MASKReady) { _KEY_CHANNEL_MASKContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_CHANNEL_MASK"); _KEY_CHANNEL_MASKReady = true; } return _KEY_CHANNEL_MASKContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_CHANNEL_MASKContent = default;
            private static bool _KEY_CHANNEL_MASKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_PRESENTATION_CONTENT_CLASSIFIER"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_PRESENTATION_CONTENT_CLASSIFIER { get { if (!_KEY_PRESENTATION_CONTENT_CLASSIFIERReady) { _KEY_PRESENTATION_CONTENT_CLASSIFIERContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_PRESENTATION_CONTENT_CLASSIFIER"); _KEY_PRESENTATION_CONTENT_CLASSIFIERReady = true; } return _KEY_PRESENTATION_CONTENT_CLASSIFIERContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_PRESENTATION_CONTENT_CLASSIFIERContent = default;
            private static bool _KEY_PRESENTATION_CONTENT_CLASSIFIERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_PRESENTATION_ID"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_PRESENTATION_ID { get { if (!_KEY_PRESENTATION_IDReady) { _KEY_PRESENTATION_IDContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_PRESENTATION_ID"); _KEY_PRESENTATION_IDReady = true; } return _KEY_PRESENTATION_IDContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_PRESENTATION_IDContent = default;
            private static bool _KEY_PRESENTATION_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_PROGRAM_ID"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_PROGRAM_ID { get { if (!_KEY_PROGRAM_IDReady) { _KEY_PROGRAM_IDContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_PROGRAM_ID"); _KEY_PROGRAM_IDReady = true; } return _KEY_PROGRAM_IDContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_PROGRAM_IDContent = default;
            private static bool _KEY_PROGRAM_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_SAMPLE_RATE"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_SAMPLE_RATE { get { if (!_KEY_SAMPLE_RATEReady) { _KEY_SAMPLE_RATEContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_SAMPLE_RATE"); _KEY_SAMPLE_RATEReady = true; } return _KEY_SAMPLE_RATEContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_SAMPLE_RATEContent = default;
            private static bool _KEY_SAMPLE_RATEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_MIME"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_MIME { get { if (!_KEY_MIMEReady) { _KEY_MIMEContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_MIME"); _KEY_MIMEReady = true; } return _KEY_MIMEContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_MIMEContent = default;
            private static bool _KEY_MIMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Format.html#KEY_PRESENTATION_LANGUAGE"/>
            /// </summary>
            public static Android.Media.AudioMetadata.Key KEY_PRESENTATION_LANGUAGE { get { if (!_KEY_PRESENTATION_LANGUAGEReady) { _KEY_PRESENTATION_LANGUAGEContent = SGetField<Android.Media.AudioMetadata.Key>(LocalBridgeClazz, "KEY_PRESENTATION_LANGUAGE"); _KEY_PRESENTATION_LANGUAGEReady = true; } return _KEY_PRESENTATION_LANGUAGEContent; } }
            private static Android.Media.AudioMetadata.Key _KEY_PRESENTATION_LANGUAGEContent = default;
            private static bool _KEY_PRESENTATION_LANGUAGEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Key
        public partial class Key
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
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Key.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Key.html#getValueClass()"/> 
            /// </summary>
            public Java.Lang.Class ValueClass
            {
                get { return IExecuteWithSignature<Java.Lang.Class>("getValueClass", "()Ljava/lang/Class;"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Key<T>
        public partial class Key<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Media.AudioMetadata.Key{T}"/> to <see cref="Android.Media.AudioMetadata.Key"/>
            /// </summary>
            public static implicit operator Android.Media.AudioMetadata.Key(Android.Media.AudioMetadata.Key<T> t) => t.Cast<Android.Media.AudioMetadata.Key>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Key.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioMetadata.Key.html#getValueClass()"/> 
            /// </summary>
            public Java.Lang.Class ValueClass
            {
                get { return IExecuteWithSignature<Java.Lang.Class>("getValueClass", "()Ljava/lang/Class;"); }
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