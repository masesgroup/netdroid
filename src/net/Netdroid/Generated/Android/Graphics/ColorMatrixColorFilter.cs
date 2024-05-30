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
    #region ColorMatrixColorFilter
    public partial class ColorMatrixColorFilter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrixColorFilter.html#%3Cinit%3E(android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        public ColorMatrixColorFilter(Android.Graphics.ColorMatrix arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrixColorFilter.html#%3Cinit%3E(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public ColorMatrixColorFilter(float[] arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/ColorMatrixColorFilter.html#getColorMatrix(android.graphics.ColorMatrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorMatrix"/></param>
        public void GetColorMatrix(Android.Graphics.ColorMatrix arg0)
        {
            IExecuteWithSignature("getColorMatrix", "(Landroid/graphics/ColorMatrix;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}