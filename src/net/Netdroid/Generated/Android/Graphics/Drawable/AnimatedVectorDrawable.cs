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
    #region AnimatedVectorDrawable
    public partial class AnimatedVectorDrawable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Graphics.Drawable.AnimatedVectorDrawable"/> to <see cref="Android.Graphics.Drawable.Animatable2"/>
        /// </summary>
        public static implicit operator Android.Graphics.Drawable.Animatable2(Android.Graphics.Drawable.AnimatedVectorDrawable t) => t.Cast<Android.Graphics.Drawable.Animatable2>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#unregisterAnimationCallback(android.graphics.drawable.Animatable2.AnimationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Animatable2.AnimationCallback"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnregisterAnimationCallback(Android.Graphics.Drawable.Animatable2.AnimationCallback arg0)
        {
            return IExecuteWithSignature<bool>("unregisterAnimationCallback", "(Landroid/graphics/drawable/Animatable2$AnimationCallback;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#clearAnimationCallbacks()"/>
        /// </summary>
        public void ClearAnimationCallbacks()
        {
            IExecuteWithSignature("clearAnimationCallbacks", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#registerAnimationCallback(android.graphics.drawable.Animatable2.AnimationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Animatable2.AnimationCallback"/></param>
        public void RegisterAnimationCallback(Android.Graphics.Drawable.Animatable2.AnimationCallback arg0)
        {
            IExecuteWithSignature("registerAnimationCallback", "(Landroid/graphics/drawable/Animatable2$AnimationCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedVectorDrawable.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}