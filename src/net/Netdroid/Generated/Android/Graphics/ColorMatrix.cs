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
    #region ColorMatrix
    public partial class ColorMatrix
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#%3Cinit%3E(android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        public ColorMatrix(Android.Graphics.ColorMatrix arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#%3Cinit%3E(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public ColorMatrix(float[] arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#getArray()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetArray()
        {
            return IExecuteWithSignatureArray<float>("getArray", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#postConcat(android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        public void PostConcat(Android.Graphics.ColorMatrix arg0)
        {
            IExecuteWithSignature("postConcat", "(Landroid/graphics/ColorMatrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#preConcat(android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        public void PreConcat(Android.Graphics.ColorMatrix arg0)
        {
            IExecuteWithSignature("preConcat", "(Landroid/graphics/ColorMatrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#set(android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        public void Set(Android.Graphics.ColorMatrix arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/ColorMatrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#set(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void Set(float[] arg0)
        {
            IExecuteWithSignature("set", "([F)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#setConcat(android.graphics.ColorMatrix,android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.ColorMatrix"/></param>
        public void SetConcat(Android.Graphics.ColorMatrix arg0, Android.Graphics.ColorMatrix arg1)
        {
            IExecute("setConcat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#setRGB2YUV()"/>
        /// </summary>
        public void SetRGB2YUV()
        {
            IExecuteWithSignature("setRGB2YUV", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#setRotate(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetRotate(int arg0, float arg1)
        {
            IExecute("setRotate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#setSaturation(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetSaturation(float arg0)
        {
            IExecuteWithSignature("setSaturation", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#setScale(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetScale(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("setScale", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrix.html#setYUV2RGB()"/>
        /// </summary>
        public void SetYUV2RGB()
        {
            IExecuteWithSignature("setYUV2RGB", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}