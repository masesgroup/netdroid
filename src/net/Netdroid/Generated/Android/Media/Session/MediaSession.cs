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

namespace Android.Media.Session
{
    #region MediaSession
    public partial class MediaSession
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#%3Cinit%3E(android.content.Context,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        public MediaSession(Android.Content.Context arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#%3Cinit%3E(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public MediaSession(Android.Content.Context arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#FLAG_HANDLES_MEDIA_BUTTONS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int FLAG_HANDLES_MEDIA_BUTTONS { get { if (!_FLAG_HANDLES_MEDIA_BUTTONSReady) { _FLAG_HANDLES_MEDIA_BUTTONSContent = SGetField<int>(LocalBridgeClazz, "FLAG_HANDLES_MEDIA_BUTTONS"); _FLAG_HANDLES_MEDIA_BUTTONSReady = true; } return _FLAG_HANDLES_MEDIA_BUTTONSContent; } }
        private static int _FLAG_HANDLES_MEDIA_BUTTONSContent = default;
        private static bool _FLAG_HANDLES_MEDIA_BUTTONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#FLAG_HANDLES_TRANSPORT_CONTROLS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int FLAG_HANDLES_TRANSPORT_CONTROLS { get { if (!_FLAG_HANDLES_TRANSPORT_CONTROLSReady) { _FLAG_HANDLES_TRANSPORT_CONTROLSContent = SGetField<int>(LocalBridgeClazz, "FLAG_HANDLES_TRANSPORT_CONTROLS"); _FLAG_HANDLES_TRANSPORT_CONTROLSReady = true; } return _FLAG_HANDLES_TRANSPORT_CONTROLSContent; } }
        private static int _FLAG_HANDLES_TRANSPORT_CONTROLSContent = default;
        private static bool _FLAG_HANDLES_TRANSPORT_CONTROLSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#getController()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaController"/></returns>
        public Android.Media.Session.MediaController GetController()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaController>("getController", "()Landroid/media/session/MediaController;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#getSessionToken()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSession.Token"/></returns>
        public Android.Media.Session.MediaSession.Token GetSessionToken()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSession.Token>("getSessionToken", "()Landroid/media/session/MediaSession$Token;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#getCurrentControllerInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSessionManager.RemoteUserInfo"/></returns>
        public Android.Media.Session.MediaSessionManager.RemoteUserInfo GetCurrentControllerInfo()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSessionManager.RemoteUserInfo>("getCurrentControllerInfo", "()Landroid/media/session/MediaSessionManager$RemoteUserInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#sendSessionEvent(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void SendSessionEvent(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecute("sendSessionEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setActive(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetActive(bool arg0)
        {
            IExecuteWithSignature("setActive", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setCallback(android.media.session.MediaSession.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSession.Callback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void SetCallback(Android.Media.Session.MediaSession.Callback arg0, Android.Os.Handler arg1)
        {
            IExecute("setCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setCallback(android.media.session.MediaSession.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSession.Callback"/></param>
        public void SetCallback(Android.Media.Session.MediaSession.Callback arg0)
        {
            IExecuteWithSignature("setCallback", "(Landroid/media/session/MediaSession$Callback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setFlags(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFlags(int arg0)
        {
            IExecuteWithSignature("setFlags", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setMediaButtonBroadcastReceiver(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        public void SetMediaButtonBroadcastReceiver(Android.Content.ComponentName arg0)
        {
            IExecuteWithSignature("setMediaButtonBroadcastReceiver", "(Landroid/content/ComponentName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setMediaButtonReceiver(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        [global::System.Obsolete()]
        public void SetMediaButtonReceiver(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("setMediaButtonReceiver", "(Landroid/app/PendingIntent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setMetadata(android.media.MediaMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaMetadata"/></param>
        public void SetMetadata(Android.Media.MediaMetadata arg0)
        {
            IExecuteWithSignature("setMetadata", "(Landroid/media/MediaMetadata;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setPlaybackState(android.media.session.PlaybackState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.PlaybackState"/></param>
        public void SetPlaybackState(Android.Media.Session.PlaybackState arg0)
        {
            IExecuteWithSignature("setPlaybackState", "(Landroid/media/session/PlaybackState;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setPlaybackToLocal(android.media.AudioAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioAttributes"/></param>
        public void SetPlaybackToLocal(Android.Media.AudioAttributes arg0)
        {
            IExecuteWithSignature("setPlaybackToLocal", "(Landroid/media/AudioAttributes;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setPlaybackToRemote(android.media.VolumeProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.VolumeProvider"/></param>
        public void SetPlaybackToRemote(Android.Media.VolumeProvider arg0)
        {
            IExecuteWithSignature("setPlaybackToRemote", "(Landroid/media/VolumeProvider;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setQueue(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void SetQueue(Java.Util.List<Android.Media.Session.MediaSession.QueueItem> arg0)
        {
            IExecuteWithSignature("setQueue", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setQueueTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetQueueTitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setQueueTitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setRatingType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRatingType(int arg0)
        {
            IExecuteWithSignature("setRatingType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.html#setSessionActivity(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        public void SetSessionActivity(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("setSessionActivity", "(Landroid/app/PendingIntent;)V", arg0);
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onMediaButtonEvent(android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool OnMediaButtonEvent(Android.Content.Intent arg0)
            {
                return IExecuteWithSignature<bool>("onMediaButtonEvent", "(Landroid/content/Intent;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onCommand(java.lang.String,android.os.Bundle,android.os.ResultReceiver)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <param name="arg2"><see cref="Android.Os.ResultReceiver"/></param>
            public void OnCommand(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.Os.ResultReceiver arg2)
            {
                IExecute("onCommand", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onCustomAction(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnCustomAction(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onCustomAction", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onFastForward()"/>
            /// </summary>
            public void OnFastForward()
            {
                IExecuteWithSignature("onFastForward", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPause()"/>
            /// </summary>
            public void OnPause()
            {
                IExecuteWithSignature("onPause", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPlay()"/>
            /// </summary>
            public void OnPlay()
            {
                IExecuteWithSignature("onPlay", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPlayFromMediaId(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnPlayFromMediaId(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onPlayFromMediaId", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPlayFromSearch(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnPlayFromSearch(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onPlayFromSearch", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPlayFromUri(android.net.Uri,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnPlayFromUri(Android.Net.Uri arg0, Android.Os.Bundle arg1)
            {
                IExecute("onPlayFromUri", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPrepare()"/>
            /// </summary>
            public void OnPrepare()
            {
                IExecuteWithSignature("onPrepare", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPrepareFromMediaId(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnPrepareFromMediaId(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onPrepareFromMediaId", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPrepareFromSearch(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnPrepareFromSearch(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onPrepareFromSearch", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onPrepareFromUri(android.net.Uri,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnPrepareFromUri(Android.Net.Uri arg0, Android.Os.Bundle arg1)
            {
                IExecute("onPrepareFromUri", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onRewind()"/>
            /// </summary>
            public void OnRewind()
            {
                IExecuteWithSignature("onRewind", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onSeekTo(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void OnSeekTo(long arg0)
            {
                IExecuteWithSignature("onSeekTo", "(J)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onSetPlaybackSpeed(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void OnSetPlaybackSpeed(float arg0)
            {
                IExecuteWithSignature("onSetPlaybackSpeed", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onSetRating(android.media.Rating)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Rating"/></param>
            public void OnSetRating(Android.Media.Rating arg0)
            {
                IExecuteWithSignature("onSetRating", "(Landroid/media/Rating;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onSkipToNext()"/>
            /// </summary>
            public void OnSkipToNext()
            {
                IExecuteWithSignature("onSkipToNext", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onSkipToPrevious()"/>
            /// </summary>
            public void OnSkipToPrevious()
            {
                IExecuteWithSignature("onSkipToPrevious", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onSkipToQueueItem(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void OnSkipToQueueItem(long arg0)
            {
                IExecuteWithSignature("onSkipToQueueItem", "(J)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Callback.html#onStop()"/>
            /// </summary>
            public void OnStop()
            {
                IExecuteWithSignature("onStop", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region QueueItem
        public partial class QueueItem
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#%3Cinit%3E(android.media.MediaDescription,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaDescription"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public QueueItem(Android.Media.MediaDescription arg0, long arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#UNKNOWN_ID"/>
            /// </summary>
            public static int UNKNOWN_ID { get { if (!_UNKNOWN_IDReady) { _UNKNOWN_IDContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN_ID"); _UNKNOWN_IDReady = true; } return _UNKNOWN_IDContent; } }
            private static int _UNKNOWN_IDContent = default;
            private static bool _UNKNOWN_IDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#getDescription()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.MediaDescription"/></returns>
            public Android.Media.MediaDescription GetDescription()
            {
                return IExecuteWithSignature<Android.Media.MediaDescription>("getDescription", "()Landroid/media/MediaDescription;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#getQueueId()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetQueueId()
            {
                return IExecuteWithSignature<long>("getQueueId", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.QueueItem.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Token
        public partial class Token
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Token.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Token.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaSession.Token.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
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