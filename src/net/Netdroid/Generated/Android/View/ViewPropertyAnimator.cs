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

namespace Android.View
{
    #region ViewPropertyAnimator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html"/>
    /// </summary>
    public partial class ViewPropertyAnimator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ViewPropertyAnimator>
    {
        const string _bridgeClassName = "android.view.ViewPropertyAnimator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ViewPropertyAnimator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ViewPropertyAnimator(params object[] args) : base(args) { }

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

    #region ViewPropertyAnimator implementation
    public partial class ViewPropertyAnimator
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
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#getInterpolator()"/>
        /// </summary>
        /// <returns><see cref="Android.Animation.TimeInterpolator"/></returns>
        public Android.Animation.TimeInterpolator GetInterpolator()
        {
            return IExecuteWithSignature<Android.Animation.TimeInterpolator>("getInterpolator", "()Landroid/animation/TimeInterpolator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#alpha(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator Alpha(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("alpha", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#alphaBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator AlphaBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("alphaBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#rotation(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator Rotation(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("rotation", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#rotationBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator RotationBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("rotationBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#rotationX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator RotationX(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("rotationX", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#rotationXBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator RotationXBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("rotationXBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#rotationY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator RotationY(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("rotationY", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#rotationYBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator RotationYBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("rotationYBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#scaleX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator ScaleX(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("scaleX", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#scaleXBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator ScaleXBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("scaleXBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#scaleY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator ScaleY(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("scaleY", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#scaleYBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator ScaleYBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("scaleYBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#setDuration(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator SetDuration(long arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("setDuration", "(J)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#setInterpolator(android.animation.TimeInterpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.TimeInterpolator"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator SetInterpolator(Android.Animation.TimeInterpolator arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("setInterpolator", "(Landroid/animation/TimeInterpolator;)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#setListener(android.animation.Animator.AnimatorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator.AnimatorListener"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator SetListener(Android.Animation.Animator.AnimatorListener arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("setListener", "(Landroid/animation/Animator$AnimatorListener;)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#setStartDelay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator SetStartDelay(long arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("setStartDelay", "(J)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#setUpdateListener(android.animation.ValueAnimator.AnimatorUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.ValueAnimator.AnimatorUpdateListener"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator SetUpdateListener(Android.Animation.ValueAnimator.AnimatorUpdateListener arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("setUpdateListener", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#translationX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator TranslationX(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("translationX", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#translationXBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator TranslationXBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("translationXBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#translationY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator TranslationY(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("translationY", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#translationYBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator TranslationYBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("translationYBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#translationZ(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator TranslationZ(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("translationZ", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#translationZBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator TranslationZBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("translationZBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#withEndAction(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator WithEndAction(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("withEndAction", "(Ljava/lang/Runnable;)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#withLayer()"/>
        /// </summary>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator WithLayer()
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("withLayer", "()Landroid/view/ViewPropertyAnimator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#withStartAction(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator WithStartAction(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("withStartAction", "(Ljava/lang/Runnable;)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#x(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator x(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("x", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#xBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator XBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("xBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#y(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator y(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("y", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#yBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator YBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("yBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#z(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator z(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("z", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#zBy(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.View.ViewPropertyAnimator"/></returns>
        public Android.View.ViewPropertyAnimator ZBy(float arg0)
        {
            return IExecuteWithSignature<Android.View.ViewPropertyAnimator>("zBy", "(F)Landroid/view/ViewPropertyAnimator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#getDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDuration()
        {
            return IExecuteWithSignature<long>("getDuration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#getStartDelay()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartDelay()
        {
            return IExecuteWithSignature<long>("getStartDelay", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewPropertyAnimator.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}