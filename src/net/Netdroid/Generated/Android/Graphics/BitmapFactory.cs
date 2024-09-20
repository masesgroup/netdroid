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

namespace Android.Graphics
{
    #region BitmapFactory
    public partial class BitmapFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeByteArray(byte[],int,int,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeByteArray(byte[] arg0, int arg1, int arg2, Android.Graphics.BitmapFactory.Options arg3)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeByteArray", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeByteArray(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeByteArray(byte[] arg0, int arg1, int arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeByteArray", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeFile(java.lang.String,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeFile(Java.Lang.String arg0, Android.Graphics.BitmapFactory.Options arg1)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeFile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeFile(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeFileDescriptor(java.io.FileDescriptor,android.graphics.Rect,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeFileDescriptor(Java.Io.FileDescriptor arg0, Android.Graphics.Rect arg1, Android.Graphics.BitmapFactory.Options arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeFileDescriptor", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeFileDescriptor(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeFileDescriptor(Java.Io.FileDescriptor arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeResource(android.content.res.Resources,int,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeResource(Android.Content.Res.Resources arg0, int arg1, Android.Graphics.BitmapFactory.Options arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeResource", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeResource(android.content.res.Resources,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeResource(Android.Content.Res.Resources arg0, int arg1)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeResourceStream(android.content.res.Resources,android.util.TypedValue,java.io.InputStream,android.graphics.Rect,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources"/></param>
        /// <param name="arg1"><see cref="Android.Util.TypedValue"/></param>
        /// <param name="arg2"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeResourceStream(Android.Content.Res.Resources arg0, Android.Util.TypedValue arg1, Java.Io.InputStream arg2, Android.Graphics.Rect arg3, Android.Graphics.BitmapFactory.Options arg4)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeResourceStream", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeStream(java.io.InputStream,android.graphics.Rect,android.graphics.BitmapFactory.Options)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.BitmapFactory.Options"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeStream(Java.Io.InputStream arg0, Android.Graphics.Rect arg1, Android.Graphics.BitmapFactory.Options arg2)
        {
            return SExecute<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.html#decodeStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public static Android.Graphics.Bitmap DecodeStream(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Bitmap>(LocalBridgeClazz, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Options
        public partial class Options
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inBitmap"/>
            /// </summary>
            public Android.Graphics.Bitmap inBitmap { get { return IGetField<Android.Graphics.Bitmap>("inBitmap"); } set { ISetField("inBitmap", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inPreferredConfig"/>
            /// </summary>
            public Android.Graphics.Bitmap.Config inPreferredConfig { get { return IGetField<Android.Graphics.Bitmap.Config>("inPreferredConfig"); } set { ISetField("inPreferredConfig", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#outConfig"/>
            /// </summary>
            public Android.Graphics.Bitmap.Config outConfig { get { return IGetField<Android.Graphics.Bitmap.Config>("outConfig"); } set { ISetField("outConfig", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inPreferredColorSpace"/>
            /// </summary>
            public Android.Graphics.ColorSpace inPreferredColorSpace { get { return IGetField<Android.Graphics.ColorSpace>("inPreferredColorSpace"); } set { ISetField("inPreferredColorSpace", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#outColorSpace"/>
            /// </summary>
            public Android.Graphics.ColorSpace outColorSpace { get { return IGetField<Android.Graphics.ColorSpace>("outColorSpace"); } set { ISetField("outColorSpace", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inDither"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool inDither { get { return IGetField<bool>("inDither"); } set { ISetField("inDither", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inInputShareable"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool inInputShareable { get { return IGetField<bool>("inInputShareable"); } set { ISetField("inInputShareable", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inJustDecodeBounds"/>
            /// </summary>
            public bool inJustDecodeBounds { get { return IGetField<bool>("inJustDecodeBounds"); } set { ISetField("inJustDecodeBounds", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inMutable"/>
            /// </summary>
            public bool inMutable { get { return IGetField<bool>("inMutable"); } set { ISetField("inMutable", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inPreferQualityOverSpeed"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool inPreferQualityOverSpeed { get { return IGetField<bool>("inPreferQualityOverSpeed"); } set { ISetField("inPreferQualityOverSpeed", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inPremultiplied"/>
            /// </summary>
            public bool inPremultiplied { get { return IGetField<bool>("inPremultiplied"); } set { ISetField("inPremultiplied", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inPurgeable"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool inPurgeable { get { return IGetField<bool>("inPurgeable"); } set { ISetField("inPurgeable", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inScaled"/>
            /// </summary>
            public bool inScaled { get { return IGetField<bool>("inScaled"); } set { ISetField("inScaled", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#mCancel"/>
            /// </summary>
            [global::System.Obsolete()]
            public bool mCancel { get { return IGetField<bool>("mCancel"); } set { ISetField("mCancel", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inTempStorage"/>
            /// </summary>
            public byte[] inTempStorage { get { return IGetFieldArray<byte>("inTempStorage"); } set { ISetField("inTempStorage", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inDensity"/>
            /// </summary>
            public int inDensity { get { return IGetField<int>("inDensity"); } set { ISetField("inDensity", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inSampleSize"/>
            /// </summary>
            public int inSampleSize { get { return IGetField<int>("inSampleSize"); } set { ISetField("inSampleSize", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inScreenDensity"/>
            /// </summary>
            public int inScreenDensity { get { return IGetField<int>("inScreenDensity"); } set { ISetField("inScreenDensity", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#inTargetDensity"/>
            /// </summary>
            public int inTargetDensity { get { return IGetField<int>("inTargetDensity"); } set { ISetField("inTargetDensity", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#outHeight"/>
            /// </summary>
            public int outHeight { get { return IGetField<int>("outHeight"); } set { ISetField("outHeight", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#outWidth"/>
            /// </summary>
            public int outWidth { get { return IGetField<int>("outWidth"); } set { ISetField("outWidth", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#outMimeType"/>
            /// </summary>
            public Java.Lang.String outMimeType { get { return IGetField<Java.Lang.String>("outMimeType"); } set { ISetField("outMimeType", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/BitmapFactory.Options.html#requestCancelDecode()"/>
            /// </summary>
            [global::System.Obsolete()]
            public void RequestCancelDecode()
            {
                IExecuteWithSignature("requestCancelDecode", "()V");
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