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

namespace Android.Transition
{
    #region TransitionInflater
    public partial class TransitionInflater
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionInflater.html#from(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Transition.TransitionInflater"/></returns>
        public static Android.Transition.TransitionInflater From(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Transition.TransitionInflater>(LocalBridgeClazz, "from", "(Landroid/content/Context;)Landroid/transition/TransitionInflater;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionInflater.html#inflateTransition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Transition.Transition"/></returns>
        public Android.Transition.Transition InflateTransition(int arg0)
        {
            return IExecuteWithSignature<Android.Transition.Transition>("inflateTransition", "(I)Landroid/transition/Transition;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionInflater.html#inflateTransitionManager(int,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.Transition.TransitionManager"/></returns>
        public Android.Transition.TransitionManager InflateTransitionManager(int arg0, Android.View.ViewGroup arg1)
        {
            return IExecute<Android.Transition.TransitionManager>("inflateTransitionManager", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}