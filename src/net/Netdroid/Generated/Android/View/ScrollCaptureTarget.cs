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
    #region ScrollCaptureTarget
    public partial class ScrollCaptureTarget
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#%3Cinit%3E(android.view.View,android.graphics.Rect,android.graphics.Point,android.view.ScrollCaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Point"/></param>
        /// <param name="arg3"><see cref="Android.View.ScrollCaptureCallback"/></param>
        public ScrollCaptureTarget(Android.View.View arg0, Android.Graphics.Rect arg1, Android.Graphics.Point arg2, Android.View.ScrollCaptureCallback arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getCallback()"/> 
        /// </summary>
        public Android.View.ScrollCaptureCallback Callback
        {
            get { return IExecuteWithSignature<Android.View.ScrollCaptureCallback>("getCallback", "()Landroid/view/ScrollCaptureCallback;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getContainingView()"/> 
        /// </summary>
        public Android.View.View ContainingView
        {
            get { return IExecuteWithSignature<Android.View.View>("getContainingView", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getHint()"/> 
        /// </summary>
        public int Hint
        {
            get { return IExecuteWithSignature<int>("getHint", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getLocalVisibleRect()"/> 
        /// </summary>
        public Android.Graphics.Rect LocalVisibleRect
        {
            get { return IExecuteWithSignature<Android.Graphics.Rect>("getLocalVisibleRect", "()Landroid/graphics/Rect;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getPositionInWindow()"/> 
        /// </summary>
        public Android.Graphics.Point PositionInWindow
        {
            get { return IExecuteWithSignature<Android.Graphics.Point>("getPositionInWindow", "()Landroid/graphics/Point;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getScrollBounds()"/> <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#setScrollBounds(android.graphics.Rect)"/>
        /// </summary>
        public Android.Graphics.Rect ScrollBounds
        {
            get { return IExecuteWithSignature<Android.Graphics.Rect>("getScrollBounds", "()Landroid/graphics/Rect;"); } set { IExecuteWithSignature("setScrollBounds", "(Landroid/graphics/Rect;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#updatePositionInWindow()"/>
        /// </summary>
        public void UpdatePositionInWindow()
        {
            IExecuteWithSignature("updatePositionInWindow", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}