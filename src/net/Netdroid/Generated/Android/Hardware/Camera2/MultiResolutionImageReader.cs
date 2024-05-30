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

namespace Android.Hardware.Camera2
{
    #region MultiResolutionImageReader
    public partial class MultiResolutionImageReader
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/MultiResolutionImageReader.html#%3Cinit%3E(java.util.Collection,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public MultiResolutionImageReader(Java.Util.Collection<Android.Hardware.Camera2.Params.MultiResolutionStreamInfo> arg0, int arg1, int arg2)
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/MultiResolutionImageReader.html#getSurface()"/> 
        /// </summary>
        public Android.View.Surface Surface
        {
            get { return IExecuteWithSignature<Android.View.Surface>("getSurface", "()Landroid/view/Surface;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/MultiResolutionImageReader.html#getStreamInfoForImageReader(android.media.ImageReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.ImageReader"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.Params.MultiResolutionStreamInfo"/></returns>
        public Android.Hardware.Camera2.Params.MultiResolutionStreamInfo GetStreamInfoForImageReader(Android.Media.ImageReader arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.Params.MultiResolutionStreamInfo>("getStreamInfoForImageReader", "(Landroid/media/ImageReader;)Landroid/hardware/camera2/params/MultiResolutionStreamInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/MultiResolutionImageReader.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/MultiResolutionImageReader.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/MultiResolutionImageReader.html#setOnImageAvailableListener(android.media.ImageReader.OnImageAvailableListener,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.ImageReader.OnImageAvailableListener"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        public void SetOnImageAvailableListener(Android.Media.ImageReader.OnImageAvailableListener arg0, Java.Util.Concurrent.Executor arg1)
        {
            IExecute("setOnImageAvailableListener", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}