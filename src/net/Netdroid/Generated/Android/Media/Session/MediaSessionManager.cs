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

namespace Android.Media.Session
{
    #region MediaSessionManager
    public partial class MediaSessionManager
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
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#getMediaKeyEventSession()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSession.Token"/></returns>
        public Android.Media.Session.MediaSession.Token GetMediaKeyEventSession()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSession.Token>("getMediaKeyEventSession", "()Landroid/media/session/MediaSession$Token;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#isTrustedForMediaControl(android.media.session.MediaSessionManager.RemoteUserInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.RemoteUserInfo"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTrustedForMediaControl(Android.Media.Session.MediaSessionManager.RemoteUserInfo arg0)
        {
            return IExecuteWithSignature<bool>("isTrustedForMediaControl", "(Landroid/media/session/MediaSessionManager$RemoteUserInfo;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#getMediaKeyEventSessionPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMediaKeyEventSessionPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMediaKeyEventSessionPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#getActiveSessions(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.Session.MediaController> GetActiveSessions(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.Session.MediaController>>("getActiveSessions", "(Landroid/content/ComponentName;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#getSession2Tokens()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.Session2Token> GetSession2Tokens()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.Session2Token>>("getSession2Tokens", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#addOnActiveSessionsChangedListener(android.media.session.MediaSessionManager.OnActiveSessionsChangedListener,android.content.ComponentName,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnActiveSessionsChangedListener"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void AddOnActiveSessionsChangedListener(Android.Media.Session.MediaSessionManager.OnActiveSessionsChangedListener arg0, Android.Content.ComponentName arg1, Android.Os.Handler arg2)
        {
            IExecute("addOnActiveSessionsChangedListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#addOnActiveSessionsChangedListener(android.media.session.MediaSessionManager.OnActiveSessionsChangedListener,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnActiveSessionsChangedListener"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        public void AddOnActiveSessionsChangedListener(Android.Media.Session.MediaSessionManager.OnActiveSessionsChangedListener arg0, Android.Content.ComponentName arg1)
        {
            IExecute("addOnActiveSessionsChangedListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#addOnMediaKeyEventSessionChangedListener(java.util.concurrent.Executor,android.media.session.MediaSessionManager.OnMediaKeyEventSessionChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Media.Session.MediaSessionManager.OnMediaKeyEventSessionChangedListener"/></param>
        public void AddOnMediaKeyEventSessionChangedListener(Java.Util.Concurrent.Executor arg0, Android.Media.Session.MediaSessionManager.OnMediaKeyEventSessionChangedListener arg1)
        {
            IExecute("addOnMediaKeyEventSessionChangedListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#addOnSession2TokensChangedListener(android.media.session.MediaSessionManager.OnSession2TokensChangedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnSession2TokensChangedListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void AddOnSession2TokensChangedListener(Android.Media.Session.MediaSessionManager.OnSession2TokensChangedListener arg0, Android.Os.Handler arg1)
        {
            IExecute("addOnSession2TokensChangedListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#addOnSession2TokensChangedListener(android.media.session.MediaSessionManager.OnSession2TokensChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnSession2TokensChangedListener"/></param>
        public void AddOnSession2TokensChangedListener(Android.Media.Session.MediaSessionManager.OnSession2TokensChangedListener arg0)
        {
            IExecuteWithSignature("addOnSession2TokensChangedListener", "(Landroid/media/session/MediaSessionManager$OnSession2TokensChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#notifySession2Created(android.media.Session2Token)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session2Token"/></param>
        [global::System.Obsolete()]
        public void NotifySession2Created(Android.Media.Session2Token arg0)
        {
            IExecuteWithSignature("notifySession2Created", "(Landroid/media/Session2Token;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#removeOnActiveSessionsChangedListener(android.media.session.MediaSessionManager.OnActiveSessionsChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnActiveSessionsChangedListener"/></param>
        public void RemoveOnActiveSessionsChangedListener(Android.Media.Session.MediaSessionManager.OnActiveSessionsChangedListener arg0)
        {
            IExecuteWithSignature("removeOnActiveSessionsChangedListener", "(Landroid/media/session/MediaSessionManager$OnActiveSessionsChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#removeOnMediaKeyEventSessionChangedListener(android.media.session.MediaSessionManager.OnMediaKeyEventSessionChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnMediaKeyEventSessionChangedListener"/></param>
        public void RemoveOnMediaKeyEventSessionChangedListener(Android.Media.Session.MediaSessionManager.OnMediaKeyEventSessionChangedListener arg0)
        {
            IExecuteWithSignature("removeOnMediaKeyEventSessionChangedListener", "(Landroid/media/session/MediaSessionManager$OnMediaKeyEventSessionChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.html#removeOnSession2TokensChangedListener(android.media.session.MediaSessionManager.OnSession2TokensChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSessionManager.OnSession2TokensChangedListener"/></param>
        public void RemoveOnSession2TokensChangedListener(Android.Media.Session.MediaSessionManager.OnSession2TokensChangedListener arg0)
        {
            IExecuteWithSignature("removeOnSession2TokensChangedListener", "(Landroid/media/session/MediaSessionManager$OnSession2TokensChangedListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnActiveSessionsChangedListener
        public partial class OnActiveSessionsChangedListener
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
            /// Handlers initializer for <see cref="OnActiveSessionsChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onActiveSessionsChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.List<Android.Media.Session.MediaController>>>>(OnActiveSessionsChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnActiveSessionsChangedListener.html#onActiveSessionsChanged(java.util.List)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnActiveSessionsChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Util.List<Android.Media.Session.MediaController>> OnOnActiveSessionsChanged { get; set; } = null;

            void OnActiveSessionsChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.List<Android.Media.Session.MediaController>>> data)
            {
                var methodToExecute = (OnOnActiveSessionsChanged != null) ? OnOnActiveSessionsChanged : OnActiveSessionsChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnActiveSessionsChangedListener.html#onActiveSessionsChanged(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public virtual void OnActiveSessionsChanged(Java.Util.List<Android.Media.Session.MediaController> arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnActiveSessionsChangedListenerDirect
        public partial class OnActiveSessionsChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnActiveSessionsChangedListener.html#onActiveSessionsChanged(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public override void OnActiveSessionsChanged(Java.Util.List<Android.Media.Session.MediaController> arg0)
            {
                IExecuteWithSignature("onActiveSessionsChanged", "(Ljava/util/List;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMediaKeyEventSessionChangedListener
        public partial class OnMediaKeyEventSessionChangedListener
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
            /// Handlers initializer for <see cref="OnMediaKeyEventSessionChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onMediaKeyEventSessionChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnMediaKeyEventSessionChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnMediaKeyEventSessionChangedListener.html#onMediaKeyEventSessionChanged(java.lang.String,android.media.session.MediaSession.Token)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMediaKeyEventSessionChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Lang.String, Android.Media.Session.MediaSession.Token> OnOnMediaKeyEventSessionChanged { get; set; } = null;

            void OnMediaKeyEventSessionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
            {
                var methodToExecute = (OnOnMediaKeyEventSessionChanged != null) ? OnOnMediaKeyEventSessionChanged : OnMediaKeyEventSessionChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Media.Session.MediaSession.Token>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnMediaKeyEventSessionChangedListener.html#onMediaKeyEventSessionChanged(java.lang.String,android.media.session.MediaSession.Token)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Media.Session.MediaSession.Token"/></param>
            public virtual void OnMediaKeyEventSessionChanged(Java.Lang.String arg0, Android.Media.Session.MediaSession.Token arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMediaKeyEventSessionChangedListenerDirect
        public partial class OnMediaKeyEventSessionChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnMediaKeyEventSessionChangedListener.html#onMediaKeyEventSessionChanged(java.lang.String,android.media.session.MediaSession.Token)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Media.Session.MediaSession.Token"/></param>
            public override void OnMediaKeyEventSessionChanged(Java.Lang.String arg0, Android.Media.Session.MediaSession.Token arg1)
            {
                IExecute("onMediaKeyEventSessionChanged", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSession2TokensChangedListener
        public partial class OnSession2TokensChangedListener
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
            /// Handlers initializer for <see cref="OnSession2TokensChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSession2TokensChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.List<Android.Media.Session2Token>>>>(OnSession2TokensChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnSession2TokensChangedListener.html#onSession2TokensChanged(java.util.List)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSession2TokensChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Util.List<Android.Media.Session2Token>> OnOnSession2TokensChanged { get; set; } = null;

            void OnSession2TokensChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.List<Android.Media.Session2Token>>> data)
            {
                var methodToExecute = (OnOnSession2TokensChanged != null) ? OnOnSession2TokensChanged : OnSession2TokensChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnSession2TokensChangedListener.html#onSession2TokensChanged(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public virtual void OnSession2TokensChanged(Java.Util.List<Android.Media.Session2Token> arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnSession2TokensChangedListenerDirect
        public partial class OnSession2TokensChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.OnSession2TokensChangedListener.html#onSession2TokensChanged(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public override void OnSession2TokensChanged(Java.Util.List<Android.Media.Session2Token> arg0)
            {
                IExecuteWithSignature("onSession2TokensChanged", "(Ljava/util/List;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RemoteUserInfo
        public partial class RemoteUserInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.RemoteUserInfo.html#%3Cinit%3E(java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public RemoteUserInfo(Java.Lang.String arg0, int arg1, int arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.RemoteUserInfo.html#getPid()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetPid()
            {
                return IExecuteWithSignature<int>("getPid", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.RemoteUserInfo.html#getUid()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetUid()
            {
                return IExecuteWithSignature<int>("getUid", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSessionManager.RemoteUserInfo.html#getPackageName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetPackageName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
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