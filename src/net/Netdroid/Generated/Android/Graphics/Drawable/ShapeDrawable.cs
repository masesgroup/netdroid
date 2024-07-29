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

namespace Android.Graphics.Drawable
{
    #region ShapeDrawable
    public partial class ShapeDrawable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#%3Cinit%3E(android.graphics.drawable.shapes.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Shapes.Shape"/></param>
        public ShapeDrawable(Android.Graphics.Drawable.Shapes.Shape arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#getShaderFactory()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.ShapeDrawable.ShaderFactory"/></returns>
        public Android.Graphics.Drawable.ShapeDrawable.ShaderFactory GetShaderFactory()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.ShapeDrawable.ShaderFactory>("getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#getShape()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Shapes.Shape"/></returns>
        public Android.Graphics.Drawable.Shapes.Shape GetShape()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Shapes.Shape>("getShape", "()Landroid/graphics/drawable/shapes/Shape;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#getPaint()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Paint"/></returns>
        public Android.Graphics.Paint GetPaint()
        {
            return IExecuteWithSignature<Android.Graphics.Paint>("getPaint", "()Landroid/graphics/Paint;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#setIntrinsicHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIntrinsicHeight(int arg0)
        {
            IExecuteWithSignature("setIntrinsicHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#setIntrinsicWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIntrinsicWidth(int arg0)
        {
            IExecuteWithSignature("setIntrinsicWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#setPadding(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetPadding(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setPadding", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#setPadding(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetPadding(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setPadding", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#setShaderFactory(android.graphics.drawable.ShapeDrawable.ShaderFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.ShapeDrawable.ShaderFactory"/></param>
        public void SetShaderFactory(Android.Graphics.Drawable.ShapeDrawable.ShaderFactory arg0)
        {
            IExecuteWithSignature("setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html#setShape(android.graphics.drawable.shapes.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Shapes.Shape"/></param>
        public void SetShape(Android.Graphics.Drawable.Shapes.Shape arg0)
        {
            IExecuteWithSignature("setShape", "(Landroid/graphics/drawable/shapes/Shape;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ShaderFactory
        public partial class ShaderFactory
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.ShaderFactory.html#resize(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Shader"/></returns>
            public Android.Graphics.Shader Resize(int arg0, int arg1)
            {
                return IExecute<Android.Graphics.Shader>("resize", arg0, arg1);
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