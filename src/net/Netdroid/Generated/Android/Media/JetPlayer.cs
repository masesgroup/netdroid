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
    #region JetPlayer
    public partial class JetPlayer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#getJetPlayer()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.JetPlayer"/></returns>
        public static Android.Media.JetPlayer GetJetPlayer()
        {
            return SExecuteWithSignature<Android.Media.JetPlayer>(LocalBridgeClazz, "getJetPlayer", "()Landroid/media/JetPlayer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#getMaxTracks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxTracks()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxTracks", "()I");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#clearQueue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ClearQueue()
        {
            return IExecuteWithSignature<bool>("clearQueue", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#closeJetFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CloseJetFile()
        {
            return IExecuteWithSignature<bool>("closeJetFile", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#loadJetFile(android.content.res.AssetFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.AssetFileDescriptor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool LoadJetFile(Android.Content.Res.AssetFileDescriptor arg0)
        {
            return IExecuteWithSignature<bool>("loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#loadJetFile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool LoadJetFile(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("loadJetFile", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#pause()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Pause()
        {
            return IExecuteWithSignature<bool>("pause", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#play()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Play()
        {
            return IExecuteWithSignature<bool>("play", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#queueJetSegment(int,int,int,int,int,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool QueueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5)
        {
            return IExecute<bool>("queueJetSegment", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#queueJetSegmentMuteArray(int,int,int,int,boolean[],byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool QueueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5)
        {
            return IExecute<bool>("queueJetSegmentMuteArray", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#setMuteArray(boolean[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetMuteArray(bool[] arg0, bool arg1)
        {
            return IExecute<bool>("setMuteArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#setMuteFlag(int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetMuteFlag(int arg0, bool arg1, bool arg2)
        {
            return IExecute<bool>("setMuteFlag", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#setMuteFlags(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetMuteFlags(int arg0, bool arg1)
        {
            return IExecute<bool>("setMuteFlags", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#triggerClip(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TriggerClip(int arg0)
        {
            return IExecuteWithSignature<bool>("triggerClip", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#setEventListener(android.media.JetPlayer.OnJetEventListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.JetPlayer.OnJetEventListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void SetEventListener(Android.Media.JetPlayer.OnJetEventListener arg0, Android.Os.Handler arg1)
        {
            IExecute("setEventListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/JetPlayer.html#setEventListener(android.media.JetPlayer.OnJetEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.JetPlayer.OnJetEventListener"/></param>
        public void SetEventListener(Android.Media.JetPlayer.OnJetEventListener arg0)
        {
            IExecuteWithSignature("setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnJetEventListener
        public partial class OnJetEventListener
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
            /// Handlers initializer for <see cref="OnJetEventListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onJetEvent", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>>>(OnJetEventEventHandler));
                AddEventHandler("onJetNumQueuedSegmentUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>>>(OnJetNumQueuedSegmentUpdateEventHandler));
                AddEventHandler("onJetPauseUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>>>(OnJetPauseUpdateEventHandler));
                AddEventHandler("onJetUserIdUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>>>(OnJetUserIdUpdateEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetEvent(android.media.JetPlayer,short,byte,byte,byte,byte)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnJetEvent"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.JetPlayer, short, byte, byte, byte, byte> OnOnJetEvent { get; set; } = null;

            void OnJetEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>> data)
            {
                var methodToExecute = (OnOnJetEvent != null) ? OnOnJetEvent : OnJetEvent;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<short>(0), data.EventData.GetAt<byte>(1), data.EventData.GetAt<byte>(2), data.EventData.GetAt<byte>(3), data.EventData.GetAt<byte>(4));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetEvent(android.media.JetPlayer,short,byte,byte,byte,byte)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <param name="arg3"><see cref="byte"/></param>
            /// <param name="arg4"><see cref="byte"/></param>
            /// <param name="arg5"><see cref="byte"/></param>
            public virtual void OnJetEvent(Android.Media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetNumQueuedSegmentUpdate(android.media.JetPlayer,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnJetNumQueuedSegmentUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.JetPlayer, int> OnOnJetNumQueuedSegmentUpdate { get; set; } = null;

            void OnJetNumQueuedSegmentUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>> data)
            {
                var methodToExecute = (OnOnJetNumQueuedSegmentUpdate != null) ? OnOnJetNumQueuedSegmentUpdate : OnJetNumQueuedSegmentUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetNumQueuedSegmentUpdate(android.media.JetPlayer,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public virtual void OnJetNumQueuedSegmentUpdate(Android.Media.JetPlayer arg0, int arg1)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetPauseUpdate(android.media.JetPlayer,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnJetPauseUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.JetPlayer, int> OnOnJetPauseUpdate { get; set; } = null;

            void OnJetPauseUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>> data)
            {
                var methodToExecute = (OnOnJetPauseUpdate != null) ? OnOnJetPauseUpdate : OnJetPauseUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetPauseUpdate(android.media.JetPlayer,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public virtual void OnJetPauseUpdate(Android.Media.JetPlayer arg0, int arg1)
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetUserIdUpdate(android.media.JetPlayer,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnJetUserIdUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.JetPlayer, int, int> OnOnJetUserIdUpdate { get; set; } = null;

            void OnJetUserIdUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.JetPlayer>> data)
            {
                var methodToExecute = (OnOnJetUserIdUpdate != null) ? OnOnJetUserIdUpdate : OnJetUserIdUpdate;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetUserIdUpdate(android.media.JetPlayer,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnJetUserIdUpdate(Android.Media.JetPlayer arg0, int arg1, int arg2)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnJetEventListenerDirect
        public partial class OnJetEventListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetEvent(android.media.JetPlayer,short,byte,byte,byte,byte)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <param name="arg3"><see cref="byte"/></param>
            /// <param name="arg4"><see cref="byte"/></param>
            /// <param name="arg5"><see cref="byte"/></param>
            public override void OnJetEvent(Android.Media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5)
            {
                IExecute("onJetEvent", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetNumQueuedSegmentUpdate(android.media.JetPlayer,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public override void OnJetNumQueuedSegmentUpdate(Android.Media.JetPlayer arg0, int arg1)
            {
                IExecute("onJetNumQueuedSegmentUpdate", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetPauseUpdate(android.media.JetPlayer,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public override void OnJetPauseUpdate(Android.Media.JetPlayer arg0, int arg1)
            {
                IExecute("onJetPauseUpdate", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/JetPlayer.OnJetEventListener.html#onJetUserIdUpdate(android.media.JetPlayer,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.JetPlayer"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnJetUserIdUpdate(Android.Media.JetPlayer arg0, int arg1, int arg2)
            {
                IExecute("onJetUserIdUpdate", arg0, arg1, arg2);
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