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

namespace Android.Media.Session
{
    #region MediaController
    public partial class MediaController
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#%3Cinit%3E(android.content.Context,android.media.session.MediaSession.Token)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Media.Session.MediaSession.Token"/></param>
        public MediaController(Android.Content.Context arg0, Android.Media.Session.MediaSession.Token arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getSessionActivity()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        public Android.App.PendingIntent GetSessionActivity()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getSessionActivity", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getMetadata()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.MediaMetadata"/></returns>
        public Android.Media.MediaMetadata GetMetadata()
        {
            return IExecuteWithSignature<Android.Media.MediaMetadata>("getMetadata", "()Landroid/media/MediaMetadata;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getPlaybackInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaController.PlaybackInfo"/></returns>
        public Android.Media.Session.MediaController.PlaybackInfo GetPlaybackInfo()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaController.PlaybackInfo>("getPlaybackInfo", "()Landroid/media/session/MediaController$PlaybackInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getTransportControls()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaController.TransportControls"/></returns>
        public Android.Media.Session.MediaController.TransportControls GetTransportControls()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaController.TransportControls>("getTransportControls", "()Landroid/media/session/MediaController$TransportControls;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getSessionToken()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSession.Token"/></returns>
        public Android.Media.Session.MediaSession.Token GetSessionToken()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSession.Token>("getSessionToken", "()Landroid/media/session/MediaSession$Token;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getPlaybackState()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.PlaybackState"/></returns>
        public Android.Media.Session.PlaybackState GetPlaybackState()
        {
            return IExecuteWithSignature<Android.Media.Session.PlaybackState>("getPlaybackState", "()Landroid/media/session/PlaybackState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getSessionInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetSessionInfo()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getSessionInfo", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#dispatchMediaButtonEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchMediaButtonEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchMediaButtonEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getRatingType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRatingType()
        {
            return IExecuteWithSignature<int>("getRatingType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getQueueTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetQueueTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getQueueTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getTag()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTag()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTag", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getQueue()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.Session.MediaSession.QueueItem> GetQueue()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.Session.MediaSession.QueueItem>>("getQueue", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#getFlags()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetFlags()
        {
            return IExecuteWithSignature<long>("getFlags", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#adjustVolume(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void AdjustVolume(int arg0, int arg1)
        {
            IExecute("adjustVolume", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#registerCallback(android.media.session.MediaController.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaController.Callback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterCallback(Android.Media.Session.MediaController.Callback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#registerCallback(android.media.session.MediaController.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaController.Callback"/></param>
        public void RegisterCallback(Android.Media.Session.MediaController.Callback arg0)
        {
            IExecuteWithSignature("registerCallback", "(Landroid/media/session/MediaController$Callback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#sendCommand(java.lang.String,android.os.Bundle,android.os.ResultReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.Os.ResultReceiver"/></param>
        public void SendCommand(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.Os.ResultReceiver arg2)
        {
            IExecute("sendCommand", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#setVolumeTo(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetVolumeTo(int arg0, int arg1)
        {
            IExecute("setVolumeTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/session/MediaController.html#unregisterCallback(android.media.session.MediaController.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaController.Callback"/></param>
        public void UnregisterCallback(Android.Media.Session.MediaController.Callback arg0)
        {
            IExecuteWithSignature("unregisterCallback", "(Landroid/media/session/MediaController$Callback;)V", arg0);
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onAudioInfoChanged(android.media.session.MediaController.PlaybackInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Session.MediaController.PlaybackInfo"/></param>
            public void OnAudioInfoChanged(Android.Media.Session.MediaController.PlaybackInfo arg0)
            {
                IExecuteWithSignature("onAudioInfoChanged", "(Landroid/media/session/MediaController$PlaybackInfo;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onExtrasChanged(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void OnExtrasChanged(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("onExtrasChanged", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onMetadataChanged(android.media.MediaMetadata)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaMetadata"/></param>
            public void OnMetadataChanged(Android.Media.MediaMetadata arg0)
            {
                IExecuteWithSignature("onMetadataChanged", "(Landroid/media/MediaMetadata;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onPlaybackStateChanged(android.media.session.PlaybackState)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Session.PlaybackState"/></param>
            public void OnPlaybackStateChanged(Android.Media.Session.PlaybackState arg0)
            {
                IExecuteWithSignature("onPlaybackStateChanged", "(Landroid/media/session/PlaybackState;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onQueueChanged(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public void OnQueueChanged(Java.Util.List<Android.Media.Session.MediaSession.QueueItem> arg0)
            {
                IExecuteWithSignature("onQueueChanged", "(Ljava/util/List;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onQueueTitleChanged(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            public void OnQueueTitleChanged(Java.Lang.CharSequence arg0)
            {
                IExecuteWithSignature("onQueueTitleChanged", "(Ljava/lang/CharSequence;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onSessionDestroyed()"/>
            /// </summary>
            public void OnSessionDestroyed()
            {
                IExecuteWithSignature("onSessionDestroyed", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.Callback.html#onSessionEvent(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnSessionEvent(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("onSessionEvent", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PlaybackInfo
        public partial class PlaybackInfo
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#PLAYBACK_TYPE_LOCAL"/>
            /// </summary>
            public static int PLAYBACK_TYPE_LOCAL { get { if (!_PLAYBACK_TYPE_LOCALReady) { _PLAYBACK_TYPE_LOCALContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_TYPE_LOCAL"); _PLAYBACK_TYPE_LOCALReady = true; } return _PLAYBACK_TYPE_LOCALContent; } }
            private static int _PLAYBACK_TYPE_LOCALContent = default;
            private static bool _PLAYBACK_TYPE_LOCALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#PLAYBACK_TYPE_REMOTE"/>
            /// </summary>
            public static int PLAYBACK_TYPE_REMOTE { get { if (!_PLAYBACK_TYPE_REMOTEReady) { _PLAYBACK_TYPE_REMOTEContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_TYPE_REMOTE"); _PLAYBACK_TYPE_REMOTEReady = true; } return _PLAYBACK_TYPE_REMOTEContent; } }
            private static int _PLAYBACK_TYPE_REMOTEContent = default;
            private static bool _PLAYBACK_TYPE_REMOTEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#getAudioAttributes()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.AudioAttributes"/></returns>
            public Android.Media.AudioAttributes GetAudioAttributes()
            {
                return IExecuteWithSignature<Android.Media.AudioAttributes>("getAudioAttributes", "()Landroid/media/AudioAttributes;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#getCurrentVolume()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCurrentVolume()
            {
                return IExecuteWithSignature<int>("getCurrentVolume", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#getMaxVolume()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMaxVolume()
            {
                return IExecuteWithSignature<int>("getMaxVolume", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#getPlaybackType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetPlaybackType()
            {
                return IExecuteWithSignature<int>("getPlaybackType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#getVolumeControl()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetVolumeControl()
            {
                return IExecuteWithSignature<int>("getVolumeControl", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#getVolumeControlId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetVolumeControlId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getVolumeControlId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.PlaybackInfo.html#writeToParcel(android.os.Parcel,int)"/>
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

        #region TransportControls
        public partial class TransportControls
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
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#fastForward()"/>
            /// </summary>
            public void FastForward()
            {
                IExecuteWithSignature("fastForward", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#pause()"/>
            /// </summary>
            public void Pause()
            {
                IExecuteWithSignature("pause", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#play()"/>
            /// </summary>
            public void Play()
            {
                IExecuteWithSignature("play", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#playFromMediaId(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void PlayFromMediaId(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("playFromMediaId", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#playFromSearch(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void PlayFromSearch(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("playFromSearch", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#playFromUri(android.net.Uri,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void PlayFromUri(Android.Net.Uri arg0, Android.Os.Bundle arg1)
            {
                IExecute("playFromUri", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#prepare()"/>
            /// </summary>
            public void Prepare()
            {
                IExecuteWithSignature("prepare", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#prepareFromMediaId(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void PrepareFromMediaId(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("prepareFromMediaId", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#prepareFromSearch(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void PrepareFromSearch(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("prepareFromSearch", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#prepareFromUri(android.net.Uri,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void PrepareFromUri(Android.Net.Uri arg0, Android.Os.Bundle arg1)
            {
                IExecute("prepareFromUri", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#rewind()"/>
            /// </summary>
            public void Rewind()
            {
                IExecuteWithSignature("rewind", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#seekTo(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void SeekTo(long arg0)
            {
                IExecuteWithSignature("seekTo", "(J)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#sendCustomAction(android.media.session.PlaybackState.CustomAction,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Session.PlaybackState.CustomAction"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void SendCustomAction(Android.Media.Session.PlaybackState.CustomAction arg0, Android.Os.Bundle arg1)
            {
                IExecute("sendCustomAction", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#sendCustomAction(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void SendCustomAction(Java.Lang.String arg0, Android.Os.Bundle arg1)
            {
                IExecute("sendCustomAction", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#setPlaybackSpeed(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void SetPlaybackSpeed(float arg0)
            {
                IExecuteWithSignature("setPlaybackSpeed", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#setRating(android.media.Rating)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Rating"/></param>
            public void SetRating(Android.Media.Rating arg0)
            {
                IExecuteWithSignature("setRating", "(Landroid/media/Rating;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#skipToNext()"/>
            /// </summary>
            public void SkipToNext()
            {
                IExecuteWithSignature("skipToNext", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#skipToPrevious()"/>
            /// </summary>
            public void SkipToPrevious()
            {
                IExecuteWithSignature("skipToPrevious", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#skipToQueueItem(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void SkipToQueueItem(long arg0)
            {
                IExecuteWithSignature("skipToQueueItem", "(J)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/session/MediaController.TransportControls.html#stop()"/>
            /// </summary>
            public void Stop()
            {
                IExecuteWithSignature("stop", "()V");
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