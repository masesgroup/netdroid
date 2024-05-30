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
    #region ScrollView
    public partial class ScrollView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ScrollView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ScrollView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ScrollView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ScrollView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#getBottomEdgeEffectColor()"/> <see href="https://developer.android.com/reference/android/widget/ScrollView.html#setBottomEdgeEffectColor(int)"/>
        /// </summary>
        public int BottomEdgeEffectColor
        {
            get { return IExecuteWithSignature<int>("getBottomEdgeEffectColor", "()I"); } set { IExecuteWithSignature("setBottomEdgeEffectColor", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#getMaxScrollAmount()"/> 
        /// </summary>
        public int MaxScrollAmount
        {
            get { return IExecuteWithSignature<int>("getMaxScrollAmount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#getTopEdgeEffectColor()"/> <see href="https://developer.android.com/reference/android/widget/ScrollView.html#setTopEdgeEffectColor(int)"/>
        /// </summary>
        public int TopEdgeEffectColor
        {
            get { return IExecuteWithSignature<int>("getTopEdgeEffectColor", "()I"); } set { IExecuteWithSignature("setTopEdgeEffectColor", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#arrowScroll(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ArrowScroll(int arg0)
        {
            return IExecuteWithSignature<bool>("arrowScroll", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#executeKeyEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ExecuteKeyEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#fullScroll(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool FullScroll(int arg0)
        {
            return IExecuteWithSignature<bool>("fullScroll", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#isFillViewport()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFillViewport()
        {
            return IExecuteWithSignature<bool>("isFillViewport", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#isSmoothScrollingEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSmoothScrollingEnabled()
        {
            return IExecuteWithSignature<bool>("isSmoothScrollingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#pageScroll(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PageScroll(int arg0)
        {
            return IExecuteWithSignature<bool>("pageScroll", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#smoothScrollBy(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SmoothScrollBy(int arg0, int arg1)
        {
            IExecute("smoothScrollBy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#smoothScrollTo(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SmoothScrollTo(int arg0, int arg1)
        {
            IExecute("smoothScrollTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#fling(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Fling(int arg0)
        {
            IExecuteWithSignature("fling", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#scrollToDescendant(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void ScrollToDescendant(Android.View.View arg0)
        {
            IExecuteWithSignature("scrollToDescendant", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#setEdgeEffectColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetEdgeEffectColor(int arg0)
        {
            IExecuteWithSignature("setEdgeEffectColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#setFillViewport(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFillViewport(bool arg0)
        {
            IExecuteWithSignature("setFillViewport", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ScrollView.html#setSmoothScrollingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSmoothScrollingEnabled(bool arg0)
        {
            IExecuteWithSignature("setSmoothScrollingEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}