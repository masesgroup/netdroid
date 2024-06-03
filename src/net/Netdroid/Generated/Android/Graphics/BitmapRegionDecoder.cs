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
    #region BitmapRegionDecoder
    public partial class BitmapRegionDecoder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.BitmapRegionDecoder NewInstance(Android.Os.ParcelFileDescriptor arg0)
        {
            return SExecuteWithSignature<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", "(Landroid/os/ParcelFileDescriptor;)Landroid/graphics/BitmapRegionDecoder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(byte[],int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static Android.Graphics.BitmapRegionDecoder NewInstance(byte[] arg0, int arg1, int arg2, bool arg3)
        {
            return SExecute<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.BitmapRegionDecoder NewInstance(byte[] arg0, int arg1, int arg2)
        {
            return SExecute<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(java.io.FileDescriptor,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static Android.Graphics.BitmapRegionDecoder NewInstance(Java.Io.FileDescriptor arg0, bool arg1)
        {
            return SExecute<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(java.io.InputStream,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static Android.Graphics.BitmapRegionDecoder NewInstance(Java.Io.InputStream arg0, bool arg1)
        {
            return SExecute<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.BitmapRegionDecoder NewInstance(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", "(Ljava/io/InputStream;)Landroid/graphics/BitmapRegionDecoder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static Android.Graphics.BitmapRegionDecoder NewInstance(Java.Lang.String arg0, bool arg1)
        {
            return SExecute<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#newInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.BitmapRegionDecoder"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Graphics.BitmapRegionDecoder NewInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.BitmapRegionDecoder>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;)Landroid/graphics/BitmapRegionDecoder;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#decodeRegion(android.graphics.Rect,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap DecodeRegion(Android.Graphics.Rect arg0, Android.Graphics.BitmapFactory.Options arg1)
        {
            return IExecute<Android.Graphics.Bitmap>("decodeRegion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#isRecycled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRecycled()
        {
            return IExecuteWithSignature<bool>("isRecycled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapRegionDecoder.html#recycle()"/>
        /// </summary>
        public void Recycle()
        {
            IExecuteWithSignature("recycle", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}