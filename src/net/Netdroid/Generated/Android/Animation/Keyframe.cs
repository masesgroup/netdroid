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

namespace Android.Animation
{
    #region Keyframe declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html"/>
    /// </summary>
    public partial class Keyframe : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "android.animation.Keyframe";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Keyframe class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Keyframe() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Keyframe class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Keyframe(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Keyframe implementation
    public partial class Keyframe
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#ofFloat(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public static Android.Animation.Keyframe OfFloat(float arg0, float arg1)
        {
            return SExecuteWithSignature<Android.Animation.Keyframe>(LocalBridgeClazz, "ofFloat", "(FF)Landroid/animation/Keyframe;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#ofFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public static Android.Animation.Keyframe OfFloat(float arg0)
        {
            return SExecuteWithSignature<Android.Animation.Keyframe>(LocalBridgeClazz, "ofFloat", "(F)Landroid/animation/Keyframe;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#ofInt(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public static Android.Animation.Keyframe OfInt(float arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Animation.Keyframe>(LocalBridgeClazz, "ofInt", "(FI)Landroid/animation/Keyframe;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#ofInt(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public static Android.Animation.Keyframe OfInt(float arg0)
        {
            return SExecuteWithSignature<Android.Animation.Keyframe>(LocalBridgeClazz, "ofInt", "(F)Landroid/animation/Keyframe;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#ofObject(float,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public static Android.Animation.Keyframe OfObject(float arg0, object arg1)
        {
            return SExecuteWithSignature<Android.Animation.Keyframe>(LocalBridgeClazz, "ofObject", "(FLjava/lang/Object;)Landroid/animation/Keyframe;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#ofObject(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public static Android.Animation.Keyframe OfObject(float arg0)
        {
            return SExecuteWithSignature<Android.Animation.Keyframe>(LocalBridgeClazz, "ofObject", "(F)Landroid/animation/Keyframe;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Animation.Keyframe"/></returns>
        public Android.Animation.Keyframe Clone()
        {
            return IExecuteWithSignature<Android.Animation.Keyframe>("clone", "()Landroid/animation/Keyframe;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetValue()
        {
            return IExecuteWithSignature("getValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#setValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetValue(object arg0)
        {
            IExecuteWithSignature("setValue", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#getInterpolator()"/>
        /// </summary>
        /// <returns><see cref="Android.Animation.TimeInterpolator"/></returns>
        public Android.Animation.TimeInterpolator GetInterpolator()
        {
            return IExecuteWithSignature<Android.Animation.TimeInterpolator>("getInterpolator", "()Landroid/animation/TimeInterpolator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#hasValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasValue()
        {
            return IExecuteWithSignature<bool>("hasValue", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#getFraction()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFraction()
        {
            return IExecuteWithSignature<float>("getFraction", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#setFraction(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetFraction(float arg0)
        {
            IExecuteWithSignature("setFraction", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/Keyframe.html#setInterpolator(android.animation.TimeInterpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.TimeInterpolator"/></param>
        public void SetInterpolator(Android.Animation.TimeInterpolator arg0)
        {
            IExecuteWithSignature("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}