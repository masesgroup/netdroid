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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region RemoteController
    public partial class RemoteController
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#%3Cinit%3E(android.content.Context,android.media.RemoteController.OnClientUpdateListener,android.os.Looper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Media.RemoteController.OnClientUpdateListener"/></param>
        /// <param name="arg2"><see cref="Android.Os.Looper"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [global::System.Obsolete()]
        public RemoteController(Android.Content.Context arg0, Android.Media.RemoteController.OnClientUpdateListener arg1, Android.Os.Looper arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#%3Cinit%3E(android.content.Context,android.media.RemoteController.OnClientUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Media.RemoteController.OnClientUpdateListener"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [global::System.Obsolete()]
        public RemoteController(Android.Content.Context arg0, Android.Media.RemoteController.OnClientUpdateListener arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#POSITION_SYNCHRONIZATION_CHECK"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int POSITION_SYNCHRONIZATION_CHECK { get { if (!_POSITION_SYNCHRONIZATION_CHECKReady) { _POSITION_SYNCHRONIZATION_CHECKContent = SGetField<int>(LocalBridgeClazz, "POSITION_SYNCHRONIZATION_CHECK"); _POSITION_SYNCHRONIZATION_CHECKReady = true; } return _POSITION_SYNCHRONIZATION_CHECKContent; } }
        private static int _POSITION_SYNCHRONIZATION_CHECKContent = default;
        private static bool _POSITION_SYNCHRONIZATION_CHECKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#POSITION_SYNCHRONIZATION_NONE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int POSITION_SYNCHRONIZATION_NONE { get { if (!_POSITION_SYNCHRONIZATION_NONEReady) { _POSITION_SYNCHRONIZATION_NONEContent = SGetField<int>(LocalBridgeClazz, "POSITION_SYNCHRONIZATION_NONE"); _POSITION_SYNCHRONIZATION_NONEReady = true; } return _POSITION_SYNCHRONIZATION_NONEContent; } }
        private static int _POSITION_SYNCHRONIZATION_NONEContent = default;
        private static bool _POSITION_SYNCHRONIZATION_NONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#editMetadata()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.RemoteController.MetadataEditor"/></returns>
        [global::System.Obsolete()]
        public Android.Media.RemoteController.MetadataEditor EditMetadata()
        {
            return IExecuteWithSignature<Android.Media.RemoteController.MetadataEditor>("editMetadata", "()Landroid/media/RemoteController$MetadataEditor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#clearArtworkConfiguration()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool ClearArtworkConfiguration()
        {
            return IExecuteWithSignature<bool>("clearArtworkConfiguration", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#seekTo(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [global::System.Obsolete()]
        public bool SeekTo(long arg0)
        {
            return IExecuteWithSignature<bool>("seekTo", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#sendMediaKeyEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [global::System.Obsolete()]
        public bool SendMediaKeyEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("sendMediaKeyEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#setArtworkConfiguration(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [global::System.Obsolete()]
        public bool SetArtworkConfiguration(int arg0, int arg1)
        {
            return IExecute<bool>("setArtworkConfiguration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#setSynchronizationMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [global::System.Obsolete()]
        public bool SetSynchronizationMode(int arg0)
        {
            return IExecuteWithSignature<bool>("setSynchronizationMode", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RemoteController.html#getEstimatedMediaPosition()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetEstimatedMediaPosition()
        {
            return IExecuteWithSignature<long>("getEstimatedMediaPosition", "()J");
        }

        #endregion

        #region Nested classes
        #region MetadataEditor
        public partial class MetadataEditor
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnClientUpdateListener
        public partial class OnClientUpdateListener
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
            /// Handlers initializer for <see cref="OnClientUpdateListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onClientChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnClientChangeEventHandler));
                AddEventHandler("onClientMetadataUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.RemoteController.MetadataEditor>>>(OnClientMetadataUpdateEventHandler));
                AddEventHandler("onClientPlaybackStateUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnClientPlaybackStateUpdateEventHandler));
                AddEventHandler("onClientPlaybackStateUpdate1", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnClientPlaybackStateUpdate1EventHandler));
                AddEventHandler("onClientTransportControlUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnClientTransportControlUpdateEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientChange(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClientChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnClientChange { get; set; } = null;

            void OnClientChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnClientChange != null) ? OnOnClientChange : OnClientChange;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientChange(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public virtual void OnClientChange(bool arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientMetadataUpdate(android.media.RemoteController.MetadataEditor)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClientMetadataUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.RemoteController.MetadataEditor> OnOnClientMetadataUpdate { get; set; } = null;

            void OnClientMetadataUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.RemoteController.MetadataEditor>> data)
            {
                var methodToExecute = (OnOnClientMetadataUpdate != null) ? OnOnClientMetadataUpdate : OnClientMetadataUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientMetadataUpdate(android.media.RemoteController.MetadataEditor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.RemoteController.MetadataEditor"/></param>
            [global::System.Obsolete()]
            public virtual void OnClientMetadataUpdate(Android.Media.RemoteController.MetadataEditor arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientPlaybackStateUpdate(int,long,long,float)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClientPlaybackStateUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int, long, long, float> OnOnClientPlaybackStateUpdate { get; set; } = null;

            void OnClientPlaybackStateUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnClientPlaybackStateUpdate != null) ? OnOnClientPlaybackStateUpdate : OnClientPlaybackStateUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0), data.EventData.GetAt<long>(1), data.EventData.GetAt<float>(2));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientPlaybackStateUpdate(int,long,long,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            [global::System.Obsolete()]
            public virtual void OnClientPlaybackStateUpdate(int arg0, long arg1, long arg2, float arg3)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientPlaybackStateUpdate(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClientPlaybackStateUpdate1"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnClientPlaybackStateUpdate1 { get; set; } = null;

            void OnClientPlaybackStateUpdate1EventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnClientPlaybackStateUpdate1 != null) ? OnOnClientPlaybackStateUpdate1 : OnClientPlaybackStateUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientPlaybackStateUpdate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [global::System.Obsolete()]
            public virtual void OnClientPlaybackStateUpdate(int arg0)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientTransportControlUpdate(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClientTransportControlUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnClientTransportControlUpdate { get; set; } = null;

            void OnClientTransportControlUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnClientTransportControlUpdate != null) ? OnOnClientTransportControlUpdate : OnClientTransportControlUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientTransportControlUpdate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [global::System.Obsolete()]
            public virtual void OnClientTransportControlUpdate(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnClientUpdateListenerDirect
        public partial class OnClientUpdateListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientChange(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public override void OnClientChange(bool arg0)
            {
                IExecuteWithSignature("onClientChange", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientMetadataUpdate(android.media.RemoteController.MetadataEditor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.RemoteController.MetadataEditor"/></param>
            [global::System.Obsolete()]
            public override void OnClientMetadataUpdate(Android.Media.RemoteController.MetadataEditor arg0)
            {
                IExecuteWithSignature("onClientMetadataUpdate", "(Landroid/media/RemoteController$MetadataEditor;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientPlaybackStateUpdate(int,long,long,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            [global::System.Obsolete()]
            public override void OnClientPlaybackStateUpdate(int arg0, long arg1, long arg2, float arg3)
            {
                IExecute("onClientPlaybackStateUpdate", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientPlaybackStateUpdate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [global::System.Obsolete()]
            public override void OnClientPlaybackStateUpdate(int arg0)
            {
                IExecuteWithSignature("onClientPlaybackStateUpdate", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RemoteController.OnClientUpdateListener.html#onClientTransportControlUpdate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [global::System.Obsolete()]
            public override void OnClientTransportControlUpdate(int arg0)
            {
                IExecuteWithSignature("onClientTransportControlUpdate", "(I)V", arg0);
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