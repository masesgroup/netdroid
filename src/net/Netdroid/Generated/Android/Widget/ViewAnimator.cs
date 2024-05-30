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
    #region ViewAnimator
    public partial class ViewAnimator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ViewAnimator(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ViewAnimator(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getAnimateFirstView()"/> <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setAnimateFirstView(boolean)"/>
        /// </summary>
        public bool AnimateFirstView
        {
            get { return IExecuteWithSignature<bool>("getAnimateFirstView", "()Z"); } set { IExecuteWithSignature("setAnimateFirstView", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getCurrentView()"/> 
        /// </summary>
        public Android.View.View CurrentView
        {
            get { return IExecuteWithSignature<Android.View.View>("getCurrentView", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getDisplayedChild()"/> <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setDisplayedChild(int)"/>
        /// </summary>
        public int DisplayedChild
        {
            get { return IExecuteWithSignature<int>("getDisplayedChild", "()I"); } set { IExecuteWithSignature("setDisplayedChild", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getInAnimation()"/> <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setInAnimation(android.view.animation.Animation)"/>
        /// </summary>
        public Android.View.Animation.Animation InAnimation
        {
            get { return IExecuteWithSignature<Android.View.Animation.Animation>("getInAnimation", "()Landroid/view/animation/Animation;"); } set { IExecuteWithSignature("setInAnimation", "(Landroid/view/animation/Animation;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getOutAnimation()"/> <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setOutAnimation(android.view.animation.Animation)"/>
        /// </summary>
        public Android.View.Animation.Animation OutAnimation
        {
            get { return IExecuteWithSignature<Android.View.Animation.Animation>("getOutAnimation", "()Landroid/view/animation/Animation;"); } set { IExecuteWithSignature("setOutAnimation", "(Landroid/view/animation/Animation;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setInAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecute("setInAnimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setOutAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetOutAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecute("setOutAnimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#showNext()"/>
        /// </summary>
        public void ShowNext()
        {
            IExecuteWithSignature("showNext", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#showPrevious()"/>
        /// </summary>
        public void ShowPrevious()
        {
            IExecuteWithSignature("showPrevious", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}