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
    #region TransitionSet
    public partial class TransitionSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public TransitionSet(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#ORDERING_SEQUENTIAL"/>
        /// </summary>
        public static int ORDERING_SEQUENTIAL { get { if (!_ORDERING_SEQUENTIALReady) { _ORDERING_SEQUENTIALContent = SGetField<int>(LocalBridgeClazz, "ORDERING_SEQUENTIAL"); _ORDERING_SEQUENTIALReady = true; } return _ORDERING_SEQUENTIALContent; } }
        private static int _ORDERING_SEQUENTIALContent = default;
        private static bool _ORDERING_SEQUENTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#ORDERING_TOGETHER"/>
        /// </summary>
        public static int ORDERING_TOGETHER { get { if (!_ORDERING_TOGETHERReady) { _ORDERING_TOGETHERContent = SGetField<int>(LocalBridgeClazz, "ORDERING_TOGETHER"); _ORDERING_TOGETHERReady = true; } return _ORDERING_TOGETHERContent; } }
        private static int _ORDERING_TOGETHERContent = default;
        private static bool _ORDERING_TOGETHERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#getTransitionAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Transition.Transition"/></returns>
        public Android.Transition.Transition GetTransitionAt(int arg0)
        {
            return IExecuteWithSignature<Android.Transition.Transition>("getTransitionAt", "(I)Landroid/transition/Transition;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#addTransition(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        /// <returns><see cref="Android.Transition.TransitionSet"/></returns>
        public Android.Transition.TransitionSet AddTransition(Android.Transition.Transition arg0)
        {
            return IExecuteWithSignature<Android.Transition.TransitionSet>("addTransition", "(Landroid/transition/Transition;)Landroid/transition/TransitionSet;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#removeTransition(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        /// <returns><see cref="Android.Transition.TransitionSet"/></returns>
        public Android.Transition.TransitionSet RemoveTransition(Android.Transition.Transition arg0)
        {
            return IExecuteWithSignature<Android.Transition.TransitionSet>("removeTransition", "(Landroid/transition/Transition;)Landroid/transition/TransitionSet;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#setOrdering(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Transition.TransitionSet"/></returns>
        public Android.Transition.TransitionSet SetOrdering(int arg0)
        {
            return IExecuteWithSignature<Android.Transition.TransitionSet>("setOrdering", "(I)Landroid/transition/TransitionSet;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#getOrdering()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrdering()
        {
            return IExecuteWithSignature<int>("getOrdering", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionSet.html#getTransitionCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTransitionCount()
        {
            return IExecuteWithSignature<int>("getTransitionCount", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}