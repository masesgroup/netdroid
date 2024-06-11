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

namespace Android.View.Contentcapture
{
    #region IDataShareWriteAdapter
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.view.contentcapture.DataShareWriteAdapter implementing <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html"/>
    /// </summary>
    public partial interface IDataShareWriteAdapter
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DataShareWriteAdapter
    public partial class DataShareWriteAdapter : Android.View.Contentcapture.IDataShareWriteAdapter
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
        /// Handlers initializer for <see cref="DataShareWriteAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onRejected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnRejectedEventHandler));
            AddEventHandler("onWrite", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Os.ParcelFileDescriptor>>>(OnWriteEventHandler));
            AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnErrorEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onRejected()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRejected"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnRejected { get; set; } = null;

        void OnRejectedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnRejected != null) ? OnOnRejected : OnRejected;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onRejected()"/>
        /// </summary>
        public virtual void OnRejected()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onWrite(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnWrite"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.ParcelFileDescriptor> OnOnWrite { get; set; } = null;

        void OnWriteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Os.ParcelFileDescriptor>> data)
        {
            var methodToExecute = (OnOnWrite != null) ? OnOnWrite : OnWrite;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onWrite(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        public virtual void OnWrite(Android.Os.ParcelFileDescriptor arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnErrorDefault(int arg0)
        {
            IExecuteWithSignature("onErrorDefault", "(I)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onError(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnOnError { get; set; } = null;

        void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnErrorDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnError(int arg0)
        {
            OnErrorDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DataShareWriteAdapterDirect
    public partial class DataShareWriteAdapterDirect : Android.View.Contentcapture.IDataShareWriteAdapter
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
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onRejected()"/>
        /// </summary>
        public override void OnRejected()
        {
            IExecuteWithSignature("onRejected", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onWrite(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        public override void OnWrite(Android.Os.ParcelFileDescriptor arg0)
        {
            IExecuteWithSignature("onWrite", "(Landroid/os/ParcelFileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataShareWriteAdapter.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnError(int arg0)
        {
            IExecuteWithSignature("onError", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}