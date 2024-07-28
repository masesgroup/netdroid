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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region Mesh
    public partial class Mesh
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#%3Cinit%3E(android.graphics.MeshSpecification,int,java.nio.Buffer,int,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.MeshSpecification"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Buffer"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.RectF"/></param>
        public Mesh(Android.Graphics.MeshSpecification arg0, int arg1, Java.Nio.Buffer arg2, int arg3, Android.Graphics.RectF arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#%3Cinit%3E(android.graphics.MeshSpecification,int,java.nio.Buffer,int,java.nio.ShortBuffer,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.MeshSpecification"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Buffer"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Nio.ShortBuffer"/></param>
        /// <param name="arg5"><see cref="Android.Graphics.RectF"/></param>
        public Mesh(Android.Graphics.MeshSpecification arg0, int arg1, Java.Nio.Buffer arg2, int arg3, Java.Nio.ShortBuffer arg4, Android.Graphics.RectF arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#TRIANGLE_STRIP"/>
        /// </summary>
        public static int TRIANGLE_STRIP { get { if (!_TRIANGLE_STRIPReady) { _TRIANGLE_STRIPContent = SGetField<int>(LocalBridgeClazz, "TRIANGLE_STRIP"); _TRIANGLE_STRIPReady = true; } return _TRIANGLE_STRIPContent; } }
        private static int _TRIANGLE_STRIPContent = default;
        private static bool _TRIANGLE_STRIPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#TRIANGLES"/>
        /// </summary>
        public static int TRIANGLES { get { if (!_TRIANGLESReady) { _TRIANGLESContent = SGetField<int>(LocalBridgeClazz, "TRIANGLES"); _TRIANGLESReady = true; } return _TRIANGLESContent; } }
        private static int _TRIANGLESContent = default;
        private static bool _TRIANGLESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setColorUniform(java.lang.String,android.graphics.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Color"/></param>
        public void SetColorUniform(Java.Lang.String arg0, Android.Graphics.Color arg1)
        {
            IExecute("setColorUniform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setColorUniform(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetColorUniform(Java.Lang.String arg0, int arg1)
        {
            IExecute("setColorUniform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setColorUniform(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void SetColorUniform(Java.Lang.String arg0, long arg1)
        {
            IExecute("setColorUniform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setFloatUniform(java.lang.String,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public void SetFloatUniform(Java.Lang.String arg0, float arg1, float arg2, float arg3, float arg4)
        {
            IExecute("setFloatUniform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setFloatUniform(java.lang.String,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetFloatUniform(Java.Lang.String arg0, float arg1, float arg2, float arg3)
        {
            IExecute("setFloatUniform", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setFloatUniform(java.lang.String,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetFloatUniform(Java.Lang.String arg0, float arg1, float arg2)
        {
            IExecute("setFloatUniform", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setFloatUniform(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetFloatUniform(Java.Lang.String arg0, float arg1)
        {
            IExecute("setFloatUniform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setFloatUniform(java.lang.String,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetFloatUniform(Java.Lang.String arg0, float[] arg1)
        {
            IExecute("setFloatUniform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setIntUniform(java.lang.String,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetIntUniform(Java.Lang.String arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecute("setIntUniform", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setIntUniform(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetIntUniform(Java.Lang.String arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setIntUniform", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setIntUniform(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetIntUniform(Java.Lang.String arg0, int arg1, int arg2)
        {
            IExecute("setIntUniform", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setIntUniform(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetIntUniform(Java.Lang.String arg0, int arg1)
        {
            IExecute("setIntUniform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Mesh.html#setIntUniform(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetIntUniform(Java.Lang.String arg0, int[] arg1)
        {
            IExecute("setIntUniform", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}