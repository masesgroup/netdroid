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

namespace Android.Widget
{
    #region VideoView
    public partial class VideoView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public VideoView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public VideoView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public VideoView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public VideoView(Android.Content.Context arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#canPause()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanPause()
        {
            return IExecuteWithSignature<bool>("canPause", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#canSeekBackward()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanSeekBackward()
        {
            return IExecuteWithSignature<bool>("canSeekBackward", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#canSeekForward()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanSeekForward()
        {
            return IExecuteWithSignature<bool>("canSeekForward", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#isPlaying()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPlaying()
        {
            return IExecuteWithSignature<bool>("isPlaying", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#getAudioSessionId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAudioSessionId()
        {
            return IExecuteWithSignature<int>("getAudioSessionId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#getBufferPercentage()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBufferPercentage()
        {
            return IExecuteWithSignature<int>("getBufferPercentage", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#getCurrentPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCurrentPosition()
        {
            return IExecuteWithSignature<int>("getCurrentPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#getDuration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDuration()
        {
            return IExecuteWithSignature<int>("getDuration", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#resolveAdjustedSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ResolveAdjustedSize(int arg0, int arg1)
        {
            return IExecute<int>("resolveAdjustedSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#addSubtitleSource(java.io.InputStream,android.media.MediaFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Android.Media.MediaFormat"/></param>
        public void AddSubtitleSource(Java.Io.InputStream arg0, Android.Media.MediaFormat arg1)
        {
            IExecute("addSubtitleSource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#pause()"/>
        /// </summary>
        public void Pause()
        {
            IExecuteWithSignature("pause", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#resume()"/>
        /// </summary>
        public void Resume()
        {
            IExecuteWithSignature("resume", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#seekTo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SeekTo(int arg0)
        {
            IExecuteWithSignature("seekTo", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setAudioAttributes(android.media.AudioAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioAttributes"/></param>
        public void SetAudioAttributes(Android.Media.AudioAttributes arg0)
        {
            IExecuteWithSignature("setAudioAttributes", "(Landroid/media/AudioAttributes;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setAudioFocusRequest(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetAudioFocusRequest(int arg0)
        {
            IExecuteWithSignature("setAudioFocusRequest", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setMediaController(android.widget.MediaController)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.MediaController"/></param>
        public void SetMediaController(Android.Widget.MediaController arg0)
        {
            IExecuteWithSignature("setMediaController", "(Landroid/widget/MediaController;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaPlayer.OnCompletionListener"/></param>
        public void SetOnCompletionListener(Android.Media.MediaPlayer.OnCompletionListener arg0)
        {
            IExecuteWithSignature("setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setOnErrorListener(android.media.MediaPlayer.OnErrorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaPlayer.OnErrorListener"/></param>
        public void SetOnErrorListener(Android.Media.MediaPlayer.OnErrorListener arg0)
        {
            IExecuteWithSignature("setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setOnInfoListener(android.media.MediaPlayer.OnInfoListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaPlayer.OnInfoListener"/></param>
        public void SetOnInfoListener(Android.Media.MediaPlayer.OnInfoListener arg0)
        {
            IExecuteWithSignature("setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaPlayer.OnPreparedListener"/></param>
        public void SetOnPreparedListener(Android.Media.MediaPlayer.OnPreparedListener arg0)
        {
            IExecuteWithSignature("setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setVideoPath(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetVideoPath(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setVideoPath", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setVideoURI(android.net.Uri,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public void SetVideoURI(Android.Net.Uri arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
        {
            IExecute("setVideoURI", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#setVideoURI(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        public void SetVideoURI(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("setVideoURI", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#stopPlayback()"/>
        /// </summary>
        public void StopPlayback()
        {
            IExecuteWithSignature("stopPlayback", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/VideoView.html#suspend()"/>
        /// </summary>
        public void Suspend()
        {
            IExecuteWithSignature("suspend", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}