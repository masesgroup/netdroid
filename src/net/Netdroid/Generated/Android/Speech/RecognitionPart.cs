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

namespace Android.Speech
{
    #region RecognitionPart
    public partial class RecognitionPart
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CONFIDENCE_LEVEL_HIGH"/>
        /// </summary>
        public static int CONFIDENCE_LEVEL_HIGH { get { if (!_CONFIDENCE_LEVEL_HIGHReady) { _CONFIDENCE_LEVEL_HIGHContent = SGetField<int>(LocalBridgeClazz, "CONFIDENCE_LEVEL_HIGH"); _CONFIDENCE_LEVEL_HIGHReady = true; } return _CONFIDENCE_LEVEL_HIGHContent; } }
        private static int _CONFIDENCE_LEVEL_HIGHContent = default;
        private static bool _CONFIDENCE_LEVEL_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CONFIDENCE_LEVEL_LOW"/>
        /// </summary>
        public static int CONFIDENCE_LEVEL_LOW { get { if (!_CONFIDENCE_LEVEL_LOWReady) { _CONFIDENCE_LEVEL_LOWContent = SGetField<int>(LocalBridgeClazz, "CONFIDENCE_LEVEL_LOW"); _CONFIDENCE_LEVEL_LOWReady = true; } return _CONFIDENCE_LEVEL_LOWContent; } }
        private static int _CONFIDENCE_LEVEL_LOWContent = default;
        private static bool _CONFIDENCE_LEVEL_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CONFIDENCE_LEVEL_MEDIUM"/>
        /// </summary>
        public static int CONFIDENCE_LEVEL_MEDIUM { get { if (!_CONFIDENCE_LEVEL_MEDIUMReady) { _CONFIDENCE_LEVEL_MEDIUMContent = SGetField<int>(LocalBridgeClazz, "CONFIDENCE_LEVEL_MEDIUM"); _CONFIDENCE_LEVEL_MEDIUMReady = true; } return _CONFIDENCE_LEVEL_MEDIUMContent; } }
        private static int _CONFIDENCE_LEVEL_MEDIUMContent = default;
        private static bool _CONFIDENCE_LEVEL_MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CONFIDENCE_LEVEL_MEDIUM_HIGH"/>
        /// </summary>
        public static int CONFIDENCE_LEVEL_MEDIUM_HIGH { get { if (!_CONFIDENCE_LEVEL_MEDIUM_HIGHReady) { _CONFIDENCE_LEVEL_MEDIUM_HIGHContent = SGetField<int>(LocalBridgeClazz, "CONFIDENCE_LEVEL_MEDIUM_HIGH"); _CONFIDENCE_LEVEL_MEDIUM_HIGHReady = true; } return _CONFIDENCE_LEVEL_MEDIUM_HIGHContent; } }
        private static int _CONFIDENCE_LEVEL_MEDIUM_HIGHContent = default;
        private static bool _CONFIDENCE_LEVEL_MEDIUM_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CONFIDENCE_LEVEL_MEDIUM_LOW"/>
        /// </summary>
        public static int CONFIDENCE_LEVEL_MEDIUM_LOW { get { if (!_CONFIDENCE_LEVEL_MEDIUM_LOWReady) { _CONFIDENCE_LEVEL_MEDIUM_LOWContent = SGetField<int>(LocalBridgeClazz, "CONFIDENCE_LEVEL_MEDIUM_LOW"); _CONFIDENCE_LEVEL_MEDIUM_LOWReady = true; } return _CONFIDENCE_LEVEL_MEDIUM_LOWContent; } }
        private static int _CONFIDENCE_LEVEL_MEDIUM_LOWContent = default;
        private static bool _CONFIDENCE_LEVEL_MEDIUM_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#CONFIDENCE_LEVEL_UNKNOWN"/>
        /// </summary>
        public static int CONFIDENCE_LEVEL_UNKNOWN { get { if (!_CONFIDENCE_LEVEL_UNKNOWNReady) { _CONFIDENCE_LEVEL_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CONFIDENCE_LEVEL_UNKNOWN"); _CONFIDENCE_LEVEL_UNKNOWNReady = true; } return _CONFIDENCE_LEVEL_UNKNOWNContent; } }
        private static int _CONFIDENCE_LEVEL_UNKNOWNContent = default;
        private static bool _CONFIDENCE_LEVEL_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#getConfidenceLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConfidenceLevel()
        {
            return IExecuteWithSignature<int>("getConfidenceLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#getFormattedText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFormattedText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFormattedText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#getRawText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRawText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRawText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#getTimestampMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestampMillis()
        {
            return IExecuteWithSignature<long>("getTimestampMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
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
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Speech.RecognitionPart"/></returns>
            public Android.Speech.RecognitionPart Build()
            {
                return IExecuteWithSignature<Android.Speech.RecognitionPart>("build", "()Landroid/speech/RecognitionPart;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.Builder.html#setConfidenceLevel(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Speech.RecognitionPart.Builder"/></returns>
            public Android.Speech.RecognitionPart.Builder SetConfidenceLevel(int arg0)
            {
                return IExecuteWithSignature<Android.Speech.RecognitionPart.Builder>("setConfidenceLevel", "(I)Landroid/speech/RecognitionPart$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.Builder.html#setFormattedText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Speech.RecognitionPart.Builder"/></returns>
            public Android.Speech.RecognitionPart.Builder SetFormattedText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Speech.RecognitionPart.Builder>("setFormattedText", "(Ljava/lang/String;)Landroid/speech/RecognitionPart$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.Builder.html#setRawText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Speech.RecognitionPart.Builder"/></returns>
            public Android.Speech.RecognitionPart.Builder SetRawText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Speech.RecognitionPart.Builder>("setRawText", "(Ljava/lang/String;)Landroid/speech/RecognitionPart$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionPart.Builder.html#setTimestampMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Speech.RecognitionPart.Builder"/></returns>
            public Android.Speech.RecognitionPart.Builder SetTimestampMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Speech.RecognitionPart.Builder>("setTimestampMillis", "(J)Landroid/speech/RecognitionPart$Builder;", arg0);
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