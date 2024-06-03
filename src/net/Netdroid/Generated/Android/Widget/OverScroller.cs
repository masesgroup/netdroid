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

namespace Android.Widget
{
    #region OverScroller
    public partial class OverScroller
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#%3Cinit%3E(android.content.Context,android.view.animation.Interpolator,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.Animation.Interpolator"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public OverScroller(Android.Content.Context arg0, Android.View.Animation.Interpolator arg1, float arg2, float arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#%3Cinit%3E(android.content.Context,android.view.animation.Interpolator,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.Animation.Interpolator"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        [global::System.Obsolete()]
        public OverScroller(Android.Content.Context arg0, Android.View.Animation.Interpolator arg1, float arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#%3Cinit%3E(android.content.Context,android.view.animation.Interpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.Animation.Interpolator"/></param>
        public OverScroller(Android.Content.Context arg0, Android.View.Animation.Interpolator arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public OverScroller(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#computeScrollOffset()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ComputeScrollOffset()
        {
            return IExecuteWithSignature<bool>("computeScrollOffset", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#isOverScrolled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOverScrolled()
        {
            return IExecuteWithSignature<bool>("isOverScrolled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#springBack(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SpringBack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return IExecute<bool>("springBack", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#isFinished()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFinished()
        {
            return IExecuteWithSignature<bool>("isFinished", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getCurrX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCurrX()
        {
            return IExecuteWithSignature<int>("getCurrX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getCurrY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCurrY()
        {
            return IExecuteWithSignature<int>("getCurrY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getFinalX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFinalX()
        {
            return IExecuteWithSignature<int>("getFinalX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getFinalY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFinalY()
        {
            return IExecuteWithSignature<int>("getFinalY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getStartX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStartX()
        {
            return IExecuteWithSignature<int>("getStartX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getStartY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStartY()
        {
            return IExecuteWithSignature<int>("getStartY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#forceFinished(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void ForceFinished(bool arg0)
        {
            IExecuteWithSignature("forceFinished", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#setFriction(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetFriction(float arg0)
        {
            IExecuteWithSignature("setFriction", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#getCurrVelocity()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCurrVelocity()
        {
            return IExecuteWithSignature<float>("getCurrVelocity", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#abortAnimation()"/>
        /// </summary>
        public void AbortAnimation()
        {
            IExecuteWithSignature("abortAnimation", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#fling(int,int,int,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public void Fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
        {
            IExecute("fling", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#fling(int,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void Fling(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
        {
            IExecute("fling", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#notifyHorizontalEdgeReached(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void NotifyHorizontalEdgeReached(int arg0, int arg1, int arg2)
        {
            IExecute("notifyHorizontalEdgeReached", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#notifyVerticalEdgeReached(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void NotifyVerticalEdgeReached(int arg0, int arg1, int arg2)
        {
            IExecute("notifyVerticalEdgeReached", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#startScroll(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void StartScroll(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecute("startScroll", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/OverScroller.html#startScroll(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void StartScroll(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("startScroll", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}