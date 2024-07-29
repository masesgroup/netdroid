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

namespace Android.Renderscript
{
    #region Matrix4f
    public partial class Matrix4f
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#%3Cinit%3E(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        [global::System.Obsolete()]
        public Matrix4f(float[] arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#inverse()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Inverse()
        {
            return IExecuteWithSignature<bool>("inverse", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#inverseTranspose()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool InverseTranspose()
        {
            return IExecuteWithSignature<bool>("inverseTranspose", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#get(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        [global::System.Obsolete()]
        public float Get(int arg0, int arg1)
        {
            return IExecute<float>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#getArray()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        [global::System.Obsolete()]
        public float[] GetArray()
        {
            return IExecuteWithSignatureArray<float>("getArray", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#load(android.renderscript.Matrix4f)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Matrix4f"/></param>
        [global::System.Obsolete()]
        public void Load(Android.Renderscript.Matrix4f arg0)
        {
            IExecuteWithSignature("load", "(Landroid/renderscript/Matrix4f;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadFrustum(float,float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadFrustum(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            IExecute("loadFrustum", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadIdentity()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void LoadIdentity()
        {
            IExecuteWithSignature("loadIdentity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadMultiply(android.renderscript.Matrix4f,android.renderscript.Matrix4f)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Matrix4f"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Matrix4f"/></param>
        [global::System.Obsolete()]
        public void LoadMultiply(Android.Renderscript.Matrix4f arg0, Android.Renderscript.Matrix4f arg1)
        {
            IExecute("loadMultiply", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadOrtho(float,float,float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadOrtho(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
        {
            IExecute("loadOrtho", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadOrthoWindow(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void LoadOrthoWindow(int arg0, int arg1)
        {
            IExecute("loadOrthoWindow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadPerspective(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadPerspective(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("loadPerspective", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadProjectionNormalized(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void LoadProjectionNormalized(int arg0, int arg1)
        {
            IExecute("loadProjectionNormalized", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadRotate(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadRotate(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("loadRotate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadScale(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadScale(float arg0, float arg1, float arg2)
        {
            IExecute("loadScale", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#loadTranslate(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadTranslate(float arg0, float arg1, float arg2)
        {
            IExecute("loadTranslate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#multiply(android.renderscript.Matrix4f)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Matrix4f"/></param>
        [global::System.Obsolete()]
        public void Multiply(Android.Renderscript.Matrix4f arg0)
        {
            IExecuteWithSignature("multiply", "(Landroid/renderscript/Matrix4f;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#rotate(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Rotate(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("rotate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#scale(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Scale(float arg0, float arg1, float arg2)
        {
            IExecute("scale", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#set(int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Set(int arg0, int arg1, float arg2)
        {
            IExecute("set", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#translate(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Translate(float arg0, float arg1, float arg2)
        {
            IExecute("translate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix4f.html#transpose()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Transpose()
        {
            IExecuteWithSignature("transpose", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}