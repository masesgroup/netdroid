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

namespace Android.Speech
{
    #region IModelDownloadListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.speech.ModelDownloadListener implementing <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html"/>
    /// </summary>
    public partial interface IModelDownloadListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ModelDownloadListener
    public partial class ModelDownloadListener : Android.Speech.IModelDownloadListener
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
        /// Handlers initializer for <see cref="ModelDownloadListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnErrorEventHandler));
            AddEventHandler("onProgress", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnProgressEventHandler));
            AddEventHandler("onScheduled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnScheduledEventHandler));
            AddEventHandler("onSuccess", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnSuccessEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onError(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnOnError { get; set; } = null;

        void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnError(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onProgress(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnProgress"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnOnProgress { get; set; } = null;

        void OnProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnProgress != null) ? OnOnProgress : OnProgress;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onProgress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnProgress(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onScheduled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnScheduled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnScheduled { get; set; } = null;

        void OnScheduledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnScheduled != null) ? OnOnScheduled : OnScheduled;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onScheduled()"/>
        /// </summary>
        public virtual void OnScheduled()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onSuccess()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSuccess"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnSuccess { get; set; } = null;

        void OnSuccessEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnSuccess != null) ? OnOnSuccess : OnSuccess;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onSuccess()"/>
        /// </summary>
        public virtual void OnSuccess()
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ModelDownloadListenerDirect
    public partial class ModelDownloadListenerDirect : Android.Speech.IModelDownloadListener
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
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnError(int arg0)
        {
            IExecuteWithSignature("onError", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onProgress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnProgress(int arg0)
        {
            IExecuteWithSignature("onProgress", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onScheduled()"/>
        /// </summary>
        public override void OnScheduled()
        {
            IExecuteWithSignature("onScheduled", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/ModelDownloadListener.html#onSuccess()"/>
        /// </summary>
        public override void OnSuccess()
        {
            IExecuteWithSignature("onSuccess", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}