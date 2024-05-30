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

namespace Android.View
{
    #region FocusFinder
    public partial class FocusFinder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/FocusFinder.html#getInstance()"/> 
        /// </summary>
        public static Android.View.FocusFinder Instance
        {
            get { return SExecuteWithSignature<Android.View.FocusFinder>(LocalBridgeClazz, "getInstance", "()Landroid/view/FocusFinder;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/FocusFinder.html#findNearestTouchable(android.view.ViewGroup,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View FindNearestTouchable(Android.View.ViewGroup arg0, int arg1, int arg2, int arg3, int[] arg4)
        {
            return IExecute<Android.View.View>("findNearestTouchable", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/FocusFinder.html#findNextFocusFromRect(android.view.ViewGroup,android.graphics.Rect,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View FindNextFocusFromRect(Android.View.ViewGroup arg0, Android.Graphics.Rect arg1, int arg2)
        {
            return IExecute<Android.View.View>("findNextFocusFromRect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/FocusFinder.html#findNextKeyboardNavigationCluster(android.view.View,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View FindNextKeyboardNavigationCluster(Android.View.View arg0, Android.View.View arg1, int arg2)
        {
            return IExecute<Android.View.View>("findNextKeyboardNavigationCluster", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/FocusFinder.html#findNextFocus(android.view.ViewGroup,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View FindNextFocus(Android.View.ViewGroup arg0, Android.View.View arg1, int arg2)
        {
            return IExecute<Android.View.View>("findNextFocus", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}