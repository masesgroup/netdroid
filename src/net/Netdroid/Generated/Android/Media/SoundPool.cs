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

namespace Android.Media
{
    #region SoundPool
    public partial class SoundPool
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public SoundPool(int arg0, int arg1, int arg2)
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
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#play(int,float,float,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int Play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5)
        {
            return IExecute<int>("play", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#unload(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Unload(int arg0)
        {
            return IExecuteWithSignature<bool>("unload", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#autoPause()"/>
        /// </summary>
        public void AutoPause()
        {
            IExecuteWithSignature("autoPause", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#autoResume()"/>
        /// </summary>
        public void AutoResume()
        {
            IExecuteWithSignature("autoResume", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#pause(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Pause(int arg0)
        {
            IExecuteWithSignature("pause", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#resume(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Resume(int arg0)
        {
            IExecuteWithSignature("resume", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#setLoop(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLoop(int arg0, int arg1)
        {
            IExecute("setLoop", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#setPriority(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetPriority(int arg0, int arg1)
        {
            IExecute("setPriority", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#setRate(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetRate(int arg0, float arg1)
        {
            IExecute("setRate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#stop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Stop(int arg0)
        {
            IExecuteWithSignature("stop", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#setVolume(int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetVolume(int arg0, float arg1, float arg2)
        {
            IExecute("setVolume", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#load(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Load(Android.Content.Context arg0, int arg1, int arg2)
        {
            return IExecute<int>("load", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#load(android.content.res.AssetFileDescriptor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.AssetFileDescriptor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Load(Android.Content.Res.AssetFileDescriptor arg0, int arg1)
        {
            return IExecute<int>("load", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#load(java.io.FileDescriptor,long,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Load(Java.Io.FileDescriptor arg0, long arg1, long arg2, int arg3)
        {
            return IExecute<int>("load", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#load(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Load(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("load", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SoundPool.html#setOnLoadCompleteListener(android.media.SoundPool.OnLoadCompleteListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.SoundPool.OnLoadCompleteListener"/></param>
        public void SetOnLoadCompleteListener(Android.Media.SoundPool.OnLoadCompleteListener arg0)
        {
            IExecuteWithSignature("setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.SoundPool"/></returns>
            public Android.Media.SoundPool Build()
            {
                return IExecuteWithSignature<Android.Media.SoundPool>("build", "()Landroid/media/SoundPool;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.Builder.html#setAudioAttributes(android.media.AudioAttributes)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.AudioAttributes"/></param>
            /// <returns><see cref="Android.Media.SoundPool.Builder"/></returns>
            /// <exception cref="Java.Lang.IllegalArgumentException"/>
            public Android.Media.SoundPool.Builder SetAudioAttributes(Android.Media.AudioAttributes arg0)
            {
                return IExecuteWithSignature<Android.Media.SoundPool.Builder>("setAudioAttributes", "(Landroid/media/AudioAttributes;)Landroid/media/SoundPool$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.Builder.html#setAudioSessionId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.SoundPool.Builder"/></returns>
            public Android.Media.SoundPool.Builder SetAudioSessionId(int arg0)
            {
                return IExecuteWithSignature<Android.Media.SoundPool.Builder>("setAudioSessionId", "(I)Landroid/media/SoundPool$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.Builder.html#setContext(android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <returns><see cref="Android.Media.SoundPool.Builder"/></returns>
            public Android.Media.SoundPool.Builder SetContext(Android.Content.Context arg0)
            {
                return IExecuteWithSignature<Android.Media.SoundPool.Builder>("setContext", "(Landroid/content/Context;)Landroid/media/SoundPool$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.Builder.html#setMaxStreams(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.SoundPool.Builder"/></returns>
            /// <exception cref="Java.Lang.IllegalArgumentException"/>
            public Android.Media.SoundPool.Builder SetMaxStreams(int arg0)
            {
                return IExecuteWithSignature<Android.Media.SoundPool.Builder>("setMaxStreams", "(I)Landroid/media/SoundPool$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnLoadCompleteListener
        public partial class OnLoadCompleteListener
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
            /// Handlers initializer for <see cref="OnLoadCompleteListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onLoadComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.SoundPool>>>(OnLoadCompleteEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/SoundPool.OnLoadCompleteListener.html#onLoadComplete(android.media.SoundPool,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnLoadComplete"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.SoundPool, int, int> OnOnLoadComplete { get; set; } = null;

            void OnLoadCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.SoundPool>> data)
            {
                var methodToExecute = (OnOnLoadComplete != null) ? OnOnLoadComplete : OnLoadComplete;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.OnLoadCompleteListener.html#onLoadComplete(android.media.SoundPool,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.SoundPool"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnLoadComplete(Android.Media.SoundPool arg0, int arg1, int arg2)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnLoadCompleteListenerDirect
        public partial class OnLoadCompleteListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/SoundPool.OnLoadCompleteListener.html#onLoadComplete(android.media.SoundPool,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.SoundPool"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnLoadComplete(Android.Media.SoundPool arg0, int arg1, int arg2)
            {
                IExecute("onLoadComplete", arg0, arg1, arg2);
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