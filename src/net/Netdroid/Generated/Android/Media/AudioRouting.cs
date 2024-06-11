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

namespace Android.Media
{
    #region IAudioRouting
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAudioRouting
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AudioRouting
    public partial class AudioRouting : Android.Media.IAudioRouting
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
        /// <see href="https://developer.android.com/reference/android/media/AudioRouting.html#getPreferredDevice()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.AudioDeviceInfo"/></returns>
        public Android.Media.AudioDeviceInfo GetPreferredDevice()
        {
            return IExecuteWithSignature<Android.Media.AudioDeviceInfo>("getPreferredDevice", "()Landroid/media/AudioDeviceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioRouting.html#getRoutedDevice()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.AudioDeviceInfo"/></returns>
        public Android.Media.AudioDeviceInfo GetRoutedDevice()
        {
            return IExecuteWithSignature<Android.Media.AudioDeviceInfo>("getRoutedDevice", "()Landroid/media/AudioDeviceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioRouting.html#setPreferredDevice(android.media.AudioDeviceInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioDeviceInfo"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetPreferredDevice(Android.Media.AudioDeviceInfo arg0)
        {
            return IExecuteWithSignature<bool>("setPreferredDevice", "(Landroid/media/AudioDeviceInfo;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioRouting.html#addOnRoutingChangedListener(android.media.AudioRouting.OnRoutingChangedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioRouting.OnRoutingChangedListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void AddOnRoutingChangedListener(Android.Media.AudioRouting.OnRoutingChangedListener arg0, Android.Os.Handler arg1)
        {
            IExecute("addOnRoutingChangedListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioRouting.html#removeOnRoutingChangedListener(android.media.AudioRouting.OnRoutingChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioRouting.OnRoutingChangedListener"/></param>
        public void RemoveOnRoutingChangedListener(Android.Media.AudioRouting.OnRoutingChangedListener arg0)
        {
            IExecuteWithSignature("removeOnRoutingChangedListener", "(Landroid/media/AudioRouting$OnRoutingChangedListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnRoutingChangedListener
        public partial class OnRoutingChangedListener
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
            /// Handlers initializer for <see cref="OnRoutingChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onRoutingChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.AudioRouting>>>(OnRoutingChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/AudioRouting.OnRoutingChangedListener.html#onRoutingChanged(android.media.AudioRouting)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnRoutingChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.AudioRouting> OnOnRoutingChanged { get; set; } = null;

            void OnRoutingChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.AudioRouting>> data)
            {
                var methodToExecute = (OnOnRoutingChanged != null) ? OnOnRoutingChanged : OnRoutingChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/AudioRouting.OnRoutingChangedListener.html#onRoutingChanged(android.media.AudioRouting)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.AudioRouting"/></param>
            public virtual void OnRoutingChanged(Android.Media.AudioRouting arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnRoutingChangedListenerDirect
        public partial class OnRoutingChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/AudioRouting.OnRoutingChangedListener.html#onRoutingChanged(android.media.AudioRouting)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.AudioRouting"/></param>
            public override void OnRoutingChanged(Android.Media.AudioRouting arg0)
            {
                IExecuteWithSignature("onRoutingChanged", "(Landroid/media/AudioRouting;)V", arg0);
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