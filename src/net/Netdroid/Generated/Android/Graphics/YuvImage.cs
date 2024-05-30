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

namespace Android.Graphics
{
    #region YuvImage
    public partial class YuvImage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#%3Cinit%3E(byte[],int,int,int,int[],android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Graphics.ColorSpace"/></param>
        public YuvImage(byte[] arg0, int arg1, int arg2, int arg3, int[] arg4, Android.Graphics.ColorSpace arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#%3Cinit%3E(byte[],int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public YuvImage(byte[] arg0, int arg1, int arg2, int arg3, int[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#getColorSpace()"/> 
        /// </summary>
        public Android.Graphics.ColorSpace ColorSpace
        {
            get { return IExecuteWithSignature<Android.Graphics.ColorSpace>("getColorSpace", "()Landroid/graphics/ColorSpace;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#getStrides()"/> 
        /// </summary>
        public int[] Strides
        {
            get { return IExecuteWithSignatureArray<int>("getStrides", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#getYuvData()"/> 
        /// </summary>
        public byte[] YuvData
        {
            get { return IExecuteWithSignatureArray<byte>("getYuvData", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#getYuvFormat()"/> 
        /// </summary>
        public int YuvFormat
        {
            get { return IExecuteWithSignature<int>("getYuvFormat", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#compressToJpeg(android.graphics.Rect,int,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompressToJpeg(Android.Graphics.Rect arg0, int arg1, Java.Io.OutputStream arg2)
        {
            return IExecute<bool>("compressToJpeg", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/YuvImage.html#compressToJpegR(android.graphics.YuvImage,int,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.YuvImage"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompressToJpegR(Android.Graphics.YuvImage arg0, int arg1, Java.Io.OutputStream arg2)
        {
            return IExecute<bool>("compressToJpegR", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}