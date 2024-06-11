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

namespace Android.Speech.Tts
{
    #region SynthesisRequest
    public partial class SynthesisRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#%3Cinit%3E(java.lang.CharSequence,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public SynthesisRequest(Java.Lang.CharSequence arg0, Android.Os.Bundle arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#%3Cinit%3E(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public SynthesisRequest(Java.Lang.String arg0, Android.Os.Bundle arg1)
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
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetParams()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getParams", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getCallerUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCallerUid()
        {
            return IExecuteWithSignature<int>("getCallerUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getPitch()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPitch()
        {
            return IExecuteWithSignature<int>("getPitch", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getSpeechRate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpeechRate()
        {
            return IExecuteWithSignature<int>("getSpeechRate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getCharSequenceText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCharSequenceText()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCharSequenceText", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getCountry()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCountry()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCountry", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getLanguage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLanguage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLanguage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getVariant()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetVariant()
        {
            return IExecuteWithSignature<Java.Lang.String>("getVariant", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisRequest.html#getVoiceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetVoiceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getVoiceName", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}