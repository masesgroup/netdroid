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

namespace Android.View.Animation
{
    #region LayoutAnimationController
    public partial class LayoutAnimationController
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public LayoutAnimationController(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#%3Cinit%3E(android.view.animation.Animation,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public LayoutAnimationController(Android.View.Animation.Animation arg0, float arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#%3Cinit%3E(android.view.animation.Animation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        public LayoutAnimationController(Android.View.Animation.Animation arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#ORDER_NORMAL"/>
        /// </summary>
        public static int ORDER_NORMAL { get { if (!_ORDER_NORMALReady) { _ORDER_NORMALContent = SGetField<int>(LocalBridgeClazz, "ORDER_NORMAL"); _ORDER_NORMALReady = true; } return _ORDER_NORMALContent; } }
        private static int _ORDER_NORMALContent = default;
        private static bool _ORDER_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#ORDER_RANDOM"/>
        /// </summary>
        public static int ORDER_RANDOM { get { if (!_ORDER_RANDOMReady) { _ORDER_RANDOMContent = SGetField<int>(LocalBridgeClazz, "ORDER_RANDOM"); _ORDER_RANDOMReady = true; } return _ORDER_RANDOMContent; } }
        private static int _ORDER_RANDOMContent = default;
        private static bool _ORDER_RANDOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#ORDER_REVERSE"/>
        /// </summary>
        public static int ORDER_REVERSE { get { if (!_ORDER_REVERSEReady) { _ORDER_REVERSEContent = SGetField<int>(LocalBridgeClazz, "ORDER_REVERSE"); _ORDER_REVERSEReady = true; } return _ORDER_REVERSEContent; } }
        private static int _ORDER_REVERSEContent = default;
        private static bool _ORDER_REVERSEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#getAnimation()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Animation.Animation"/></returns>
        public Android.View.Animation.Animation GetAnimation()
        {
            return IExecuteWithSignature<Android.View.Animation.Animation>("getAnimation", "()Landroid/view/animation/Animation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#getInterpolator()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Animation.Interpolator"/></returns>
        public Android.View.Animation.Interpolator GetInterpolator()
        {
            return IExecuteWithSignature<Android.View.Animation.Interpolator>("getInterpolator", "()Landroid/view/animation/Interpolator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#isDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#willOverlap()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WillOverlap()
        {
            return IExecuteWithSignature<bool>("willOverlap", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#getAnimationForView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.Animation.Animation"/></returns>
        public Android.View.Animation.Animation GetAnimationForView(Android.View.View arg0)
        {
            return IExecuteWithSignature<Android.View.Animation.Animation>("getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#getDelay()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetDelay()
        {
            return IExecuteWithSignature<float>("getDelay", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#getOrder()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrder()
        {
            return IExecuteWithSignature<int>("getOrder", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#setAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecute("setAnimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#setAnimation(android.view.animation.Animation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        public void SetAnimation(Android.View.Animation.Animation arg0)
        {
            IExecuteWithSignature("setAnimation", "(Landroid/view/animation/Animation;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#setDelay(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetDelay(float arg0)
        {
            IExecuteWithSignature("setDelay", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#setInterpolator(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInterpolator(Android.Content.Context arg0, int arg1)
        {
            IExecute("setInterpolator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#setInterpolator(android.view.animation.Interpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Interpolator"/></param>
        public void SetInterpolator(Android.View.Animation.Interpolator arg0)
        {
            IExecuteWithSignature("setInterpolator", "(Landroid/view/animation/Interpolator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#setOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOrder(int arg0)
        {
            IExecuteWithSignature("setOrder", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }

        #endregion

        #region Nested classes
        #region AnimationParameters
        public partial class AnimationParameters
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.AnimationParameters.html#count"/>
            /// </summary>
            public int count { get { return IGetField<int>("count"); } set { ISetField("count", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/LayoutAnimationController.AnimationParameters.html#index"/>
            /// </summary>
            public int index { get { return IGetField<int>("index"); } set { ISetField("index", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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