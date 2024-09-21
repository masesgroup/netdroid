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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics.Drawable
{
    #region ShapeDrawable declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.html"/>
    /// </summary>
    public partial class ShapeDrawable : Android.Graphics.Drawable.Drawable
    {
        const string _bridgeClassName = "android.graphics.drawable.ShapeDrawable";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ShapeDrawable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ShapeDrawable(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region ShaderFactory declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ShapeDrawable.ShaderFactory.html"/>
        /// </summary>
        public partial class ShaderFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ShaderFactory>
        {
            const string _bridgeClassName = "android.graphics.drawable.ShapeDrawable$ShaderFactory";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("ShaderFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ShaderFactory() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("ShaderFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ShaderFactory(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region ShapeDrawable implementation
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
        #region ShaderFactory implementation
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