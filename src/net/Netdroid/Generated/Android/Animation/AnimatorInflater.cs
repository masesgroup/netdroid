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

namespace Android.Animation
{
    #region AnimatorInflater
    public partial class AnimatorInflater
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorInflater.html#loadAnimator(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.Animator"/></returns>
        /// <exception cref="Android.Content.Res.Resources.NotFoundException"/>
        public static Android.Animation.Animator LoadAnimator(Android.Content.Context arg0, int arg1)
        {
            return SExecute<Android.Animation.Animator>(LocalBridgeClazz, "loadAnimator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorInflater.html#loadStateListAnimator(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.StateListAnimator"/></returns>
        /// <exception cref="Android.Content.Res.Resources.NotFoundException"/>
        public static Android.Animation.StateListAnimator LoadStateListAnimator(Android.Content.Context arg0, int arg1)
        {
            return SExecute<Android.Animation.StateListAnimator>(LocalBridgeClazz, "loadStateListAnimator", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}