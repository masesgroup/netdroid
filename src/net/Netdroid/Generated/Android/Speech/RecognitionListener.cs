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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Speech
{
    #region IRecognitionListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.speech.RecognitionListener implementing <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html"/>
    /// </summary>
    public partial interface IRecognitionListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RecognitionListener
    public partial class RecognitionListener : Android.Speech.IRecognitionListener
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
        /// Handlers initializer for <see cref="RecognitionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onBeginningOfSpeech", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnBeginningOfSpeechEventHandler));
            AddEventHandler("onBufferReceived", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<byte[]>>>(OnBufferReceivedEventHandler));
            AddEventHandler("onEndOfSpeech", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnEndOfSpeechEventHandler));
            AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnErrorEventHandler));
            AddEventHandler("onEvent", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnEventEventHandler));
            AddEventHandler("onPartialResults", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Os.Bundle>>>(OnPartialResultsEventHandler));
            AddEventHandler("onReadyForSpeech", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Os.Bundle>>>(OnReadyForSpeechEventHandler));
            AddEventHandler("onResults", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Os.Bundle>>>(OnResultsEventHandler));
            AddEventHandler("onRmsChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<float>>>(OnRmsChangedEventHandler));
            AddEventHandler("onEndOfSegmentedSession", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnEndOfSegmentedSessionEventHandler));
            AddEventHandler("onLanguageDetection", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Os.Bundle>>>(OnLanguageDetectionEventHandler));
            AddEventHandler("onSegmentResults", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Os.Bundle>>>(OnSegmentResultsEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBeginningOfSpeech()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBeginningOfSpeech"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnBeginningOfSpeech { get; set; } = null;

        void OnBeginningOfSpeechEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnBeginningOfSpeech != null) ? OnOnBeginningOfSpeech : OnBeginningOfSpeech;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBeginningOfSpeech()"/>
        /// </summary>
        public virtual void OnBeginningOfSpeech()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBufferReceived(byte[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBufferReceived"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<byte[]> OnOnBufferReceived { get; set; } = null;

        void OnBufferReceivedEventHandler(object sender, CLRListenerEventArgs<CLREventData<byte[]>> data)
        {
            var methodToExecute = (OnOnBufferReceived != null) ? OnOnBufferReceived : OnBufferReceived;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBufferReceived(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public virtual void OnBufferReceived(byte[] arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSpeech()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEndOfSpeech"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnEndOfSpeech { get; set; } = null;

        void OnEndOfSpeechEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnEndOfSpeech != null) ? OnOnEndOfSpeech : OnEndOfSpeech;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSpeech()"/>
        /// </summary>
        public virtual void OnEndOfSpeech()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onError(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnOnError { get; set; } = null;

        void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnError(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEvent(int,android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEvent"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, Android.Os.Bundle> OnOnEvent { get; set; } = null;

        void OnEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnEvent != null) ? OnOnEvent : OnEvent;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Os.Bundle>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEvent(int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnEvent(int arg0, Android.Os.Bundle arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onPartialResults(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartialResults"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnPartialResults { get; set; } = null;

        void OnPartialResultsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Os.Bundle>> data)
        {
            var methodToExecute = (OnOnPartialResults != null) ? OnOnPartialResults : OnPartialResults;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onPartialResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnPartialResults(Android.Os.Bundle arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onReadyForSpeech(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnReadyForSpeech"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnReadyForSpeech { get; set; } = null;

        void OnReadyForSpeechEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Os.Bundle>> data)
        {
            var methodToExecute = (OnOnReadyForSpeech != null) ? OnOnReadyForSpeech : OnReadyForSpeech;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onReadyForSpeech(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnReadyForSpeech(Android.Os.Bundle arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onResults(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnResults"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnResults { get; set; } = null;

        void OnResultsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Os.Bundle>> data)
        {
            var methodToExecute = (OnOnResults != null) ? OnOnResults : OnResults;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnResults(Android.Os.Bundle arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onRmsChanged(float)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRmsChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<float> OnOnRmsChanged { get; set; } = null;

        void OnRmsChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<float>> data)
        {
            var methodToExecute = (OnOnRmsChanged != null) ? OnOnRmsChanged : OnRmsChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onRmsChanged(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public virtual void OnRmsChanged(float arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnEndOfSegmentedSessionDefault()
        {
            IExecuteWithSignature("onEndOfSegmentedSessionDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEndOfSegmentedSession"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnEndOfSegmentedSession { get; set; } = null;

        void OnEndOfSegmentedSessionEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnEndOfSegmentedSession != null) ? OnOnEndOfSegmentedSession : OnEndOfSegmentedSession;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnEndOfSegmentedSessionDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnEndOfSegmentedSession()
        {
            OnEndOfSegmentedSessionDefault();
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnLanguageDetectionDefault(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onLanguageDetectionDefault", "(Landroid/os/Bundle;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnLanguageDetection"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnLanguageDetection { get; set; } = null;

        void OnLanguageDetectionEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Os.Bundle>> data)
        {
            var methodToExecute = (OnOnLanguageDetection != null) ? OnOnLanguageDetection : OnLanguageDetection;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnLanguageDetectionDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnLanguageDetection(Android.Os.Bundle arg0)
        {
            OnLanguageDetectionDefault(arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnSegmentResultsDefault(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onSegmentResultsDefault", "(Landroid/os/Bundle;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSegmentResults"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnSegmentResults { get; set; } = null;

        void OnSegmentResultsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Os.Bundle>> data)
        {
            var methodToExecute = (OnOnSegmentResults != null) ? OnOnSegmentResults : OnSegmentResults;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnSegmentResultsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnSegmentResults(Android.Os.Bundle arg0)
        {
            OnSegmentResultsDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RecognitionListenerDirect
    public partial class RecognitionListenerDirect : Android.Speech.IRecognitionListener
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
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBeginningOfSpeech()"/>
        /// </summary>
        public override void OnBeginningOfSpeech()
        {
            IExecuteWithSignature("onBeginningOfSpeech", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBufferReceived(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public override void OnBufferReceived(byte[] arg0)
        {
            IExecuteWithSignature("onBufferReceived", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSpeech()"/>
        /// </summary>
        public override void OnEndOfSpeech()
        {
            IExecuteWithSignature("onEndOfSpeech", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnError(int arg0)
        {
            IExecuteWithSignature("onError", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEvent(int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public override void OnEvent(int arg0, Android.Os.Bundle arg1)
        {
            IExecute("onEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onPartialResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnPartialResults(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onPartialResults", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onReadyForSpeech(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnReadyForSpeech(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onReadyForSpeech", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnResults(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onResults", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onRmsChanged(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public override void OnRmsChanged(float arg0)
        {
            IExecuteWithSignature("onRmsChanged", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        public override void OnEndOfSegmentedSession()
        {
            IExecuteWithSignature("onEndOfSegmentedSession", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnLanguageDetection(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onLanguageDetection", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnSegmentResults(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onSegmentResults", "(Landroid/os/Bundle;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}