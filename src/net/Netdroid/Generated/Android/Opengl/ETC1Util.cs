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

namespace Android.Opengl
{
    #region ETC1Util
    public partial class ETC1Util
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.html#compressTexture(java.nio.Buffer,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Buffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.Opengl.ETC1Util.ETC1Texture"/></returns>
        public static Android.Opengl.ETC1Util.ETC1Texture CompressTexture(Java.Nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Android.Opengl.ETC1Util.ETC1Texture>(LocalBridgeClazz, "compressTexture", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.html#createTexture(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Android.Opengl.ETC1Util.ETC1Texture"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Opengl.ETC1Util.ETC1Texture CreateTexture(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Android.Opengl.ETC1Util.ETC1Texture>(LocalBridgeClazz, "createTexture", "(Ljava/io/InputStream;)Landroid/opengl/ETC1Util$ETC1Texture;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.html#isETC1Supported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsETC1Supported()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isETC1Supported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.html#loadTexture(int,int,int,int,int,android.opengl.ETC1Util.ETC1Texture)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Opengl.ETC1Util.ETC1Texture"/></param>
        public static void LoadTexture(int arg0, int arg1, int arg2, int arg3, int arg4, Android.Opengl.ETC1Util.ETC1Texture arg5)
        {
            SExecute(LocalBridgeClazz, "loadTexture", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.html#loadTexture(int,int,int,int,int,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void LoadTexture(int arg0, int arg1, int arg2, int arg3, int arg4, Java.Io.InputStream arg5)
        {
            SExecute(LocalBridgeClazz, "loadTexture", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.html#writeTexture(android.opengl.ETC1Util.ETC1Texture,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Opengl.ETC1Util.ETC1Texture"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void WriteTexture(Android.Opengl.ETC1Util.ETC1Texture arg0, Java.Io.OutputStream arg1)
        {
            SExecute(LocalBridgeClazz, "writeTexture", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region ETC1Texture
        public partial class ETC1Texture
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.ETC1Texture.html#%3Cinit%3E(int,int,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
            public ETC1Texture(int arg0, int arg1, Java.Nio.ByteBuffer arg2)
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
            /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.ETC1Texture.html#getData()"/> 
            /// </summary>
            public Java.Nio.ByteBuffer Data
            {
                get { return IExecuteWithSignature<Java.Nio.ByteBuffer>("getData", "()Ljava/nio/ByteBuffer;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.ETC1Texture.html#getHeight()"/> 
            /// </summary>
            public int Height
            {
                get { return IExecuteWithSignature<int>("getHeight", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/opengl/ETC1Util.ETC1Texture.html#getWidth()"/> 
            /// </summary>
            public int Width
            {
                get { return IExecuteWithSignature<int>("getWidth", "()I"); }
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