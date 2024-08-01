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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Transition
{
    #region VisibilityPropagation
    public partial class VisibilityPropagation
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
        /// <see href="https://developer.android.com/reference/android/transition/VisibilityPropagation.html#getViewVisibility(android.transition.TransitionValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.TransitionValues"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetViewVisibility(Android.Transition.TransitionValues arg0)
        {
            return IExecuteWithSignature<int>("getViewVisibility", "(Landroid/transition/TransitionValues;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/VisibilityPropagation.html#getViewX(android.transition.TransitionValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.TransitionValues"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetViewX(Android.Transition.TransitionValues arg0)
        {
            return IExecuteWithSignature<int>("getViewX", "(Landroid/transition/TransitionValues;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/VisibilityPropagation.html#getViewY(android.transition.TransitionValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.TransitionValues"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetViewY(Android.Transition.TransitionValues arg0)
        {
            return IExecuteWithSignature<int>("getViewY", "(Landroid/transition/TransitionValues;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}