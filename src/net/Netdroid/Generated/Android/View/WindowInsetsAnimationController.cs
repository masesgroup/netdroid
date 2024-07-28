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

namespace Android.View
{
    #region IWindowInsetsAnimationController
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWindowInsetsAnimationController
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowInsetsAnimationController
    public partial class WindowInsetsAnimationController : Android.View.IWindowInsetsAnimationController
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
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#getCurrentInsets()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public Android.Graphics.Insets GetCurrentInsets()
        {
            return IExecuteWithSignature<Android.Graphics.Insets>("getCurrentInsets", "()Landroid/graphics/Insets;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#getHiddenStateInsets()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public Android.Graphics.Insets GetHiddenStateInsets()
        {
            return IExecuteWithSignature<Android.Graphics.Insets>("getHiddenStateInsets", "()Landroid/graphics/Insets;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#getShownStateInsets()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Insets"/></returns>
        public Android.Graphics.Insets GetShownStateInsets()
        {
            return IExecuteWithSignature<Android.Graphics.Insets>("getShownStateInsets", "()Landroid/graphics/Insets;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#isFinished()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFinished()
        {
            return IExecuteWithSignature<bool>("isFinished", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#getCurrentAlpha()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCurrentAlpha()
        {
            return IExecuteWithSignature<float>("getCurrentAlpha", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#getCurrentFraction()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCurrentFraction()
        {
            return IExecuteWithSignature<float>("getCurrentFraction", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#getTypes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTypes()
        {
            return IExecuteWithSignature<int>("getTypes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#finish(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Finish(bool arg0)
        {
            IExecuteWithSignature("finish", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#setInsetsAndAlpha(android.graphics.Insets,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetInsetsAndAlpha(Android.Graphics.Insets arg0, float arg1, float arg2)
        {
            IExecute("setInsetsAndAlpha", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/WindowInsetsAnimationController.html#isReady()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReady()
        {
            return IExecuteWithSignature<bool>("isReady", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}