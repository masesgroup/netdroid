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
    #region RotateDrawable declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html"/>
    /// </summary>
    public partial class RotateDrawable : Android.Graphics.Drawable.DrawableWrapper
    {
        const string _bridgeClassName = "android.graphics.drawable.RotateDrawable";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RotateDrawable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RotateDrawable(params object[] args) : base(args) { }

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

    }
    #endregion

    #region RotateDrawable implementation
    public partial class RotateDrawable
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
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#isPivotXRelative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPivotXRelative()
        {
            return IExecuteWithSignature<bool>("isPivotXRelative", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#isPivotYRelative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPivotYRelative()
        {
            return IExecuteWithSignature<bool>("isPivotYRelative", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#getFromDegrees()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFromDegrees()
        {
            return IExecuteWithSignature<float>("getFromDegrees", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#getPivotX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPivotX()
        {
            return IExecuteWithSignature<float>("getPivotX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#getPivotY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetPivotY()
        {
            return IExecuteWithSignature<float>("getPivotY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#getToDegrees()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetToDegrees()
        {
            return IExecuteWithSignature<float>("getToDegrees", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#setFromDegrees(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetFromDegrees(float arg0)
        {
            IExecuteWithSignature("setFromDegrees", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#setPivotX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetPivotX(float arg0)
        {
            IExecuteWithSignature("setPivotX", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#setPivotXRelative(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPivotXRelative(bool arg0)
        {
            IExecuteWithSignature("setPivotXRelative", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#setPivotY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetPivotY(float arg0)
        {
            IExecuteWithSignature("setPivotY", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#setPivotYRelative(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPivotYRelative(bool arg0)
        {
            IExecuteWithSignature("setPivotYRelative", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RotateDrawable.html#setToDegrees(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetToDegrees(float arg0)
        {
            IExecuteWithSignature("setToDegrees", "(F)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}