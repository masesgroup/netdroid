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

namespace Android.Hardware.Camera2
{
    #region DngCreator
    public partial class DngCreator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#%3Cinit%3E(android.hardware.camera2.CameraCharacteristics,android.hardware.camera2.CaptureResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCharacteristics"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureResult"/></param>
        public DngCreator(Android.Hardware.Camera2.CameraCharacteristics arg0, Android.Hardware.Camera2.CaptureResult arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#MAX_THUMBNAIL_DIMENSION"/>
        /// </summary>
        public static int MAX_THUMBNAIL_DIMENSION { get { if (!_MAX_THUMBNAIL_DIMENSIONReady) { _MAX_THUMBNAIL_DIMENSIONContent = SGetField<int>(LocalBridgeClazz, "MAX_THUMBNAIL_DIMENSION"); _MAX_THUMBNAIL_DIMENSIONReady = true; } return _MAX_THUMBNAIL_DIMENSIONContent; } }
        private static int _MAX_THUMBNAIL_DIMENSIONContent = default;
        private static bool _MAX_THUMBNAIL_DIMENSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#setDescription(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.DngCreator"/></returns>
        public Android.Hardware.Camera2.DngCreator SetDescription(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.DngCreator>("setDescription", "(Ljava/lang/String;)Landroid/hardware/camera2/DngCreator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#setLocation(android.location.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Location.Location"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.DngCreator"/></returns>
        public Android.Hardware.Camera2.DngCreator SetLocation(Android.Location.Location arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.DngCreator>("setLocation", "(Landroid/location/Location;)Landroid/hardware/camera2/DngCreator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#setOrientation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.DngCreator"/></returns>
        public Android.Hardware.Camera2.DngCreator SetOrientation(int arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.DngCreator>("setOrientation", "(I)Landroid/hardware/camera2/DngCreator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#setThumbnail(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.DngCreator"/></returns>
        public Android.Hardware.Camera2.DngCreator SetThumbnail(Android.Graphics.Bitmap arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.DngCreator>("setThumbnail", "(Landroid/graphics/Bitmap;)Landroid/hardware/camera2/DngCreator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#setThumbnail(android.media.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Image"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.DngCreator"/></returns>
        public Android.Hardware.Camera2.DngCreator SetThumbnail(Android.Media.Image arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.DngCreator>("setThumbnail", "(Landroid/media/Image;)Landroid/hardware/camera2/DngCreator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#writeByteBuffer(java.io.OutputStream,android.util.Size,java.nio.ByteBuffer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteByteBuffer(Java.Io.OutputStream arg0, Android.Util.Size arg1, Java.Nio.ByteBuffer arg2, long arg3)
        {
            IExecute("writeByteBuffer", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#writeImage(java.io.OutputStream,android.media.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Android.Media.Image"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteImage(Java.Io.OutputStream arg0, Android.Media.Image arg1)
        {
            IExecute("writeImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/DngCreator.html#writeInputStream(java.io.OutputStream,android.util.Size,java.io.InputStream,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInputStream(Java.Io.OutputStream arg0, Android.Util.Size arg1, Java.Io.InputStream arg2, long arg3)
        {
            IExecute("writeInputStream", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}