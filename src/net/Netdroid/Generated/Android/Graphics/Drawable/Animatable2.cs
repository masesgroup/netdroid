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

namespace Android.Graphics.Drawable
{
    #region IAnimatable2
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnimatable2 : Android.Graphics.Drawable.IAnimatable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.html#unregisterAnimationCallback(android.graphics.drawable.Animatable2.AnimationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Animatable2.AnimationCallback"/></param>
        /// <returns><see cref="bool"/></returns>
        bool UnregisterAnimationCallback(Android.Graphics.Drawable.Animatable2.AnimationCallback arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.html#clearAnimationCallbacks()"/>
        /// </summary>
        void ClearAnimationCallbacks();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.html#registerAnimationCallback(android.graphics.drawable.Animatable2.AnimationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Animatable2.AnimationCallback"/></param>
        void RegisterAnimationCallback(Android.Graphics.Drawable.Animatable2.AnimationCallback arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Animatable2
    public partial class Animatable2 : Android.Graphics.Drawable.IAnimatable2
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
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.html#unregisterAnimationCallback(android.graphics.drawable.Animatable2.AnimationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Animatable2.AnimationCallback"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnregisterAnimationCallback(Android.Graphics.Drawable.Animatable2.AnimationCallback arg0)
        {
            return IExecuteWithSignature<bool>("unregisterAnimationCallback", "(Landroid/graphics/drawable/Animatable2$AnimationCallback;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.html#clearAnimationCallbacks()"/>
        /// </summary>
        public void ClearAnimationCallbacks()
        {
            IExecuteWithSignature("clearAnimationCallbacks", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.html#registerAnimationCallback(android.graphics.drawable.Animatable2.AnimationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Animatable2.AnimationCallback"/></param>
        public void RegisterAnimationCallback(Android.Graphics.Drawable.Animatable2.AnimationCallback arg0)
        {
            IExecuteWithSignature("registerAnimationCallback", "(Landroid/graphics/drawable/Animatable2$AnimationCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region AnimationCallback
        public partial class AnimationCallback
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
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.AnimationCallback.html#onAnimationEnd(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            public void OnAnimationEnd(Android.Graphics.Drawable.Drawable arg0)
            {
                IExecuteWithSignature("onAnimationEnd", "(Landroid/graphics/drawable/Drawable;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/Animatable2.AnimationCallback.html#onAnimationStart(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            public void OnAnimationStart(Android.Graphics.Drawable.Drawable arg0)
            {
                IExecuteWithSignature("onAnimationStart", "(Landroid/graphics/drawable/Drawable;)V", arg0);
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