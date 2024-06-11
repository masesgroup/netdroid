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

namespace Android.Widget
{
    #region MediaController
    public partial class MediaController
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public MediaController(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#%3Cinit%3E(android.content.Context,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public MediaController(Android.Content.Context arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public MediaController(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#isShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShowing()
        {
            return IExecuteWithSignature<bool>("isShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#hide()"/>
        /// </summary>
        public void Hide()
        {
            IExecuteWithSignature("hide", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#onFinishInflate()"/>
        /// </summary>
        public void OnFinishInflate()
        {
            IExecuteWithSignature("onFinishInflate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#setAnchorView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetAnchorView(Android.View.View arg0)
        {
            IExecuteWithSignature("setAnchorView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#setMediaPlayer(android.widget.MediaController.MediaPlayerControl)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.MediaController.MediaPlayerControl"/></param>
        public void SetMediaPlayer(Android.Widget.MediaController.MediaPlayerControl arg0)
        {
            IExecuteWithSignature("setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#setPrevNextListeners(android.view.View.OnClickListener,android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View.OnClickListener"/></param>
        /// <param name="arg1"><see cref="Android.View.View.OnClickListener"/></param>
        public void SetPrevNextListeners(Android.View.View.OnClickListener arg0, Android.View.View.OnClickListener arg1)
        {
            IExecute("setPrevNextListeners", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/MediaController.html#show(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Show(int arg0)
        {
            IExecuteWithSignature("show", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region MediaPlayerControl
        public partial class MediaPlayerControl
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
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#canPause()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool CanPause()
            {
                return IExecuteWithSignature<bool>("canPause", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#canSeekBackward()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool CanSeekBackward()
            {
                return IExecuteWithSignature<bool>("canSeekBackward", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#canSeekForward()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool CanSeekForward()
            {
                return IExecuteWithSignature<bool>("canSeekForward", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#isPlaying()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsPlaying()
            {
                return IExecuteWithSignature<bool>("isPlaying", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#getAudioSessionId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetAudioSessionId()
            {
                return IExecuteWithSignature<int>("getAudioSessionId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#getBufferPercentage()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetBufferPercentage()
            {
                return IExecuteWithSignature<int>("getBufferPercentage", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#getCurrentPosition()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCurrentPosition()
            {
                return IExecuteWithSignature<int>("getCurrentPosition", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#getDuration()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetDuration()
            {
                return IExecuteWithSignature<int>("getDuration", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#pause()"/>
            /// </summary>
            public void Pause()
            {
                IExecuteWithSignature("pause", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#seekTo(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SeekTo(int arg0)
            {
                IExecuteWithSignature("seekTo", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/MediaController.MediaPlayerControl.html#start()"/>
            /// </summary>
            public void Start()
            {
                IExecuteWithSignature("start", "()V");
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