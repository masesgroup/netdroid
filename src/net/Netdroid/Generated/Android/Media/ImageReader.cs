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
    #region ImageReader
    public partial class ImageReader
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#newInstance(int,int,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="Android.Media.ImageReader"/></returns>
        public static Android.Media.ImageReader NewInstance(int arg0, int arg1, int arg2, int arg3, long arg4)
        {
            return SExecute<Android.Media.ImageReader>(LocalBridgeClazz, "newInstance", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#newInstance(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.ImageReader"/></returns>
        public static Android.Media.ImageReader NewInstance(int arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Android.Media.ImageReader>(LocalBridgeClazz, "newInstance", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#acquireLatestImage()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Image"/></returns>
        public Android.Media.Image AcquireLatestImage()
        {
            return IExecuteWithSignature<Android.Media.Image>("acquireLatestImage", "()Landroid/media/Image;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#acquireNextImage()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Image"/></returns>
        public Android.Media.Image AcquireNextImage()
        {
            return IExecuteWithSignature<Android.Media.Image>("acquireNextImage", "()Landroid/media/Image;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getSurface()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Surface"/></returns>
        public Android.View.Surface GetSurface()
        {
            return IExecuteWithSignature<Android.View.Surface>("getSurface", "()Landroid/view/Surface;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getDataSpace()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDataSpace()
        {
            return IExecuteWithSignature<int>("getDataSpace", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getHardwareBufferFormat()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHardwareBufferFormat()
        {
            return IExecuteWithSignature<int>("getHardwareBufferFormat", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getImageFormat()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImageFormat()
        {
            return IExecuteWithSignature<int>("getImageFormat", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getMaxImages()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxImages()
        {
            return IExecuteWithSignature<int>("getMaxImages", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#getUsage()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetUsage()
        {
            return IExecuteWithSignature<long>("getUsage", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#discardFreeBuffers()"/>
        /// </summary>
        public void DiscardFreeBuffers()
        {
            IExecuteWithSignature("discardFreeBuffers", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/ImageReader.html#setOnImageAvailableListener(android.media.ImageReader.OnImageAvailableListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.ImageReader.OnImageAvailableListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void SetOnImageAvailableListener(Android.Media.ImageReader.OnImageAvailableListener arg0, Android.Os.Handler arg1)
        {
            IExecute("setOnImageAvailableListener", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(int arg0, int arg1)
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
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.ImageReader"/></returns>
            public Android.Media.ImageReader Build()
            {
                return IExecuteWithSignature<Android.Media.ImageReader>("build", "()Landroid/media/ImageReader;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#setDefaultDataSpace(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.ImageReader.Builder"/></returns>
            public Android.Media.ImageReader.Builder SetDefaultDataSpace(int arg0)
            {
                return IExecuteWithSignature<Android.Media.ImageReader.Builder>("setDefaultDataSpace", "(I)Landroid/media/ImageReader$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#setDefaultHardwareBufferFormat(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.ImageReader.Builder"/></returns>
            public Android.Media.ImageReader.Builder SetDefaultHardwareBufferFormat(int arg0)
            {
                return IExecuteWithSignature<Android.Media.ImageReader.Builder>("setDefaultHardwareBufferFormat", "(I)Landroid/media/ImageReader$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#setImageFormat(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.ImageReader.Builder"/></returns>
            public Android.Media.ImageReader.Builder SetImageFormat(int arg0)
            {
                return IExecuteWithSignature<Android.Media.ImageReader.Builder>("setImageFormat", "(I)Landroid/media/ImageReader$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#setMaxImages(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.ImageReader.Builder"/></returns>
            public Android.Media.ImageReader.Builder SetMaxImages(int arg0)
            {
                return IExecuteWithSignature<Android.Media.ImageReader.Builder>("setMaxImages", "(I)Landroid/media/ImageReader$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.Builder.html#setUsage(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.ImageReader.Builder"/></returns>
            public Android.Media.ImageReader.Builder SetUsage(long arg0)
            {
                return IExecuteWithSignature<Android.Media.ImageReader.Builder>("setUsage", "(J)Landroid/media/ImageReader$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnImageAvailableListener
        public partial class OnImageAvailableListener
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
            /// Handlers initializer for <see cref="OnImageAvailableListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onImageAvailable", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.ImageReader>>>(OnImageAvailableEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/ImageReader.OnImageAvailableListener.html#onImageAvailable(android.media.ImageReader)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnImageAvailable"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.ImageReader> OnOnImageAvailable { get; set; } = null;

            void OnImageAvailableEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.ImageReader>> data)
            {
                var methodToExecute = (OnOnImageAvailable != null) ? OnOnImageAvailable : OnImageAvailable;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.OnImageAvailableListener.html#onImageAvailable(android.media.ImageReader)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.ImageReader"/></param>
            public virtual void OnImageAvailable(Android.Media.ImageReader arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnImageAvailableListenerDirect
        public partial class OnImageAvailableListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/ImageReader.OnImageAvailableListener.html#onImageAvailable(android.media.ImageReader)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.ImageReader"/></param>
            public override void OnImageAvailable(Android.Media.ImageReader arg0)
            {
                IExecuteWithSignature("onImageAvailable", "(Landroid/media/ImageReader;)V", arg0);
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