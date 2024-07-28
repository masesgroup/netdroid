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

namespace Android.Companion.Virtual
{
    #region VirtualDeviceManager
    public partial class VirtualDeviceManager
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
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.html#getVirtualDevice(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Companion.Virtual.VirtualDevice"/></returns>
        public Android.Companion.Virtual.VirtualDevice GetVirtualDevice(int arg0)
        {
            return IExecuteWithSignature<Android.Companion.Virtual.VirtualDevice>("getVirtualDevice", "(I)Landroid/companion/virtual/VirtualDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.html#getVirtualDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Companion.Virtual.VirtualDevice> GetVirtualDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Companion.Virtual.VirtualDevice>>("getVirtualDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.html#registerVirtualDeviceListener(java.util.concurrent.Executor,android.companion.virtual.VirtualDeviceManager.VirtualDeviceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Companion.Virtual.VirtualDeviceManager.VirtualDeviceListener"/></param>
        public void RegisterVirtualDeviceListener(Java.Util.Concurrent.Executor arg0, Android.Companion.Virtual.VirtualDeviceManager.VirtualDeviceListener arg1)
        {
            IExecute("registerVirtualDeviceListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.html#unregisterVirtualDeviceListener(android.companion.virtual.VirtualDeviceManager.VirtualDeviceListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.Virtual.VirtualDeviceManager.VirtualDeviceListener"/></param>
        public void UnregisterVirtualDeviceListener(Android.Companion.Virtual.VirtualDeviceManager.VirtualDeviceListener arg0)
        {
            IExecuteWithSignature("unregisterVirtualDeviceListener", "(Landroid/companion/virtual/VirtualDeviceManager$VirtualDeviceListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region VirtualDeviceListener
        public partial class VirtualDeviceListener
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
            /// Handlers initializer for <see cref="VirtualDeviceListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onVirtualDeviceClosed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnVirtualDeviceClosedEventHandler));
                AddEventHandler("onVirtualDeviceCreated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnVirtualDeviceCreatedEventHandler));

            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceClosed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
            public void OnVirtualDeviceClosedDefault(int arg0)
            {
                IExecuteWithSignature("onVirtualDeviceClosedDefault", "(I)V", arg0);
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceClosed(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnVirtualDeviceClosed"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnVirtualDeviceClosed { get; set; } = null;

            void OnVirtualDeviceClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnVirtualDeviceClosed != null) ? OnOnVirtualDeviceClosed : OnVirtualDeviceClosed;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceClosed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnVirtualDeviceClosedDefault"/>; override the method to implement a different behavior</remarks>
            public virtual void OnVirtualDeviceClosed(int arg0)
            {
                OnVirtualDeviceClosedDefault(arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceCreated(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
            public void OnVirtualDeviceCreatedDefault(int arg0)
            {
                IExecuteWithSignature("onVirtualDeviceCreatedDefault", "(I)V", arg0);
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceCreated(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnVirtualDeviceCreated"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnVirtualDeviceCreated { get; set; } = null;

            void OnVirtualDeviceCreatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnVirtualDeviceCreated != null) ? OnOnVirtualDeviceCreated : OnVirtualDeviceCreated;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceCreated(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnVirtualDeviceCreatedDefault"/>; override the method to implement a different behavior</remarks>
            public virtual void OnVirtualDeviceCreated(int arg0)
            {
                OnVirtualDeviceCreatedDefault(arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region VirtualDeviceListenerDirect
        public partial class VirtualDeviceListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceClosed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnVirtualDeviceClosed(int arg0)
            {
                IExecuteWithSignature("onVirtualDeviceClosed", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDeviceManager.VirtualDeviceListener.html#onVirtualDeviceCreated(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnVirtualDeviceCreated(int arg0)
            {
                IExecuteWithSignature("onVirtualDeviceCreated", "(I)V", arg0);
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