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

namespace Android.Opengl
{
    #region GLUtils
    public partial class GLUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#getInternalFormat(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetInternalFormat(Android.Graphics.Bitmap arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getInternalFormat", "(Landroid/graphics/Bitmap;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#getType(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetType(Android.Graphics.Bitmap arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getType", "(Landroid/graphics/Bitmap;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#getEGLErrorString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetEGLErrorString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getEGLErrorString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#texImage2D(int,int,android.graphics.Bitmap,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public static void TexImage2D(int arg0, int arg1, Android.Graphics.Bitmap arg2, int arg3)
        {
            SExecute(LocalBridgeClazz, "texImage2D", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#texImage2D(int,int,int,android.graphics.Bitmap,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public static void TexImage2D(int arg0, int arg1, int arg2, Android.Graphics.Bitmap arg3, int arg4, int arg5)
        {
            SExecute(LocalBridgeClazz, "texImage2D", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#texImage2D(int,int,int,android.graphics.Bitmap,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void TexImage2D(int arg0, int arg1, int arg2, Android.Graphics.Bitmap arg3, int arg4)
        {
            SExecute(LocalBridgeClazz, "texImage2D", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#texSubImage2D(int,int,int,int,android.graphics.Bitmap,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public static void TexSubImage2D(int arg0, int arg1, int arg2, int arg3, Android.Graphics.Bitmap arg4, int arg5, int arg6)
        {
            SExecute(LocalBridgeClazz, "texSubImage2D", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLUtils.html#texSubImage2D(int,int,int,int,android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Bitmap"/></param>
        public static void TexSubImage2D(int arg0, int arg1, int arg2, int arg3, Android.Graphics.Bitmap arg4)
        {
            SExecute(LocalBridgeClazz, "texSubImage2D", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}