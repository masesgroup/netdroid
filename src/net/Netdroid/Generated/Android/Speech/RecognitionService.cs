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
    #region RecognitionService
    public partial class RecognitionService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#getMaxConcurrentSessionsCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxConcurrentSessionsCount()
        {
            return IExecuteWithSignature<int>("getMaxConcurrentSessionsCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onCheckRecognitionSupport(android.content.Intent,android.content.AttributionSource,android.speech.RecognitionService.SupportCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.AttributionSource"/></param>
        /// <param name="arg2"><see cref="Android.Speech.RecognitionService.SupportCallback"/></param>
        public void OnCheckRecognitionSupport(Android.Content.Intent arg0, Android.Content.AttributionSource arg1, Android.Speech.RecognitionService.SupportCallback arg2)
        {
            IExecute("onCheckRecognitionSupport", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onCheckRecognitionSupport(android.content.Intent,android.speech.RecognitionService.SupportCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Speech.RecognitionService.SupportCallback"/></param>
        public void OnCheckRecognitionSupport(Android.Content.Intent arg0, Android.Speech.RecognitionService.SupportCallback arg1)
        {
            IExecute("onCheckRecognitionSupport", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onTriggerModelDownload(android.content.Intent,android.content.AttributionSource,android.speech.ModelDownloadListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.AttributionSource"/></param>
        /// <param name="arg2"><see cref="Android.Speech.ModelDownloadListener"/></param>
        public void OnTriggerModelDownload(Android.Content.Intent arg0, Android.Content.AttributionSource arg1, Android.Speech.ModelDownloadListener arg2)
        {
            IExecute("onTriggerModelDownload", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onTriggerModelDownload(android.content.Intent,android.content.AttributionSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.AttributionSource"/></param>
        public void OnTriggerModelDownload(Android.Content.Intent arg0, Android.Content.AttributionSource arg1)
        {
            IExecute("onTriggerModelDownload", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onTriggerModelDownload(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void OnTriggerModelDownload(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("onTriggerModelDownload", "(Landroid/content/Intent;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#getCallingAttributionSource()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.AttributionSource"/></returns>
            public Android.Content.AttributionSource GetCallingAttributionSource()
            {
                return IExecuteWithSignature<Android.Content.AttributionSource>("getCallingAttributionSource", "()Landroid/content/AttributionSource;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#getCallingUid()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCallingUid()
            {
                return IExecuteWithSignature<int>("getCallingUid", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#beginningOfSpeech()"/>
            /// </summary>
            /// <exception cref="Android.Os.RemoteException"/>
            public void BeginningOfSpeech()
            {
                IExecuteWithSignature("beginningOfSpeech", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#bufferReceived(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void BufferReceived(byte[] arg0)
            {
                IExecuteWithSignature("bufferReceived", "([B)V", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#endOfSegmentedSession()"/>
            /// </summary>
            /// <exception cref="Android.Os.RemoteException"/>
            public void EndOfSegmentedSession()
            {
                IExecuteWithSignature("endOfSegmentedSession", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#endOfSpeech()"/>
            /// </summary>
            /// <exception cref="Android.Os.RemoteException"/>
            public void EndOfSpeech()
            {
                IExecuteWithSignature("endOfSpeech", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#error(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void Error(int arg0)
            {
                IExecuteWithSignature("error", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#languageDetection(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void LanguageDetection(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("languageDetection", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#partialResults(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void PartialResults(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("partialResults", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#readyForSpeech(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void ReadyForSpeech(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("readyForSpeech", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#results(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void Results(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("results", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#rmsChanged(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void RmsChanged(float arg0)
            {
                IExecuteWithSignature("rmsChanged", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#segmentResults(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void SegmentResults(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("segmentResults", "(Landroid/os/Bundle;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SupportCallback
        public partial class SupportCallback
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
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.SupportCallback.html#onError(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnError(int arg0)
            {
                IExecuteWithSignature("onError", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.SupportCallback.html#onSupportResult(android.speech.RecognitionSupport)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Speech.RecognitionSupport"/></param>
            public void OnSupportResult(Android.Speech.RecognitionSupport arg0)
            {
                IExecuteWithSignature("onSupportResult", "(Landroid/speech/RecognitionSupport;)V", arg0);
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