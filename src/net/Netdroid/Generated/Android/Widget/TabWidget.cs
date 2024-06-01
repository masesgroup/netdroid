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
    #region TabWidget
    public partial class TabWidget
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [System.Obsolete()]
        public TabWidget(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [System.Obsolete()]
        public TabWidget(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [System.Obsolete()]
        public TabWidget(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [System.Obsolete()]
        public TabWidget(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#getLeftStripDrawable()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Graphics.Drawable.Drawable LeftStripDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getLeftStripDrawable", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#getRightStripDrawable()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Graphics.Drawable.Drawable RightStripDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getRightStripDrawable", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#getTabCount()"/> 
        /// </summary>
        [System.Obsolete()]
        public int TabCount
        {
            get { return IExecuteWithSignature<int>("getTabCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#getChildTabViewAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        [System.Obsolete()]
        public Android.View.View GetChildTabViewAt(int arg0)
        {
            return IExecuteWithSignature<Android.View.View>("getChildTabViewAt", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#isStripEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsStripEnabled()
        {
            return IExecuteWithSignature<bool>("isStripEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#dispatchDraw(android.graphics.Canvas)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        [System.Obsolete()]
        public void DispatchDraw(Android.Graphics.Canvas arg0)
        {
            IExecuteWithSignature("dispatchDraw", "(Landroid/graphics/Canvas;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#focusCurrentTab(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void FocusCurrentTab(int arg0)
        {
            IExecuteWithSignature("focusCurrentTab", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#onFocusChange(android.view.View,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [System.Obsolete()]
        public void OnFocusChange(Android.View.View arg0, bool arg1)
        {
            IExecute("onFocusChange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setCurrentTab(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetCurrentTab(int arg0)
        {
            IExecuteWithSignature("setCurrentTab", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setDividerDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetDividerDrawable(int arg0)
        {
            IExecuteWithSignature("setDividerDrawable", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setLeftStripDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        [System.Obsolete()]
        public void SetLeftStripDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setLeftStripDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetLeftStripDrawable(int arg0)
        {
            IExecuteWithSignature("setLeftStripDrawable", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setRightStripDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        [System.Obsolete()]
        public void SetRightStripDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setRightStripDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetRightStripDrawable(int arg0)
        {
            IExecuteWithSignature("setRightStripDrawable", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabWidget.html#setStripEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetStripEnabled(bool arg0)
        {
            IExecuteWithSignature("setStripEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}