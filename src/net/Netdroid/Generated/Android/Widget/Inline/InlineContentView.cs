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

namespace Android.Widget.Inline
{
    #region InlineContentView
    public partial class InlineContentView
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
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.html#getSurfaceControl()"/>
        /// </summary>
        /// <returns><see cref="Android.View.SurfaceControl"/></returns>
        public Android.View.SurfaceControl GetSurfaceControl()
        {
            return IExecuteWithSignature<Android.View.SurfaceControl>("getSurfaceControl", "()Landroid/view/SurfaceControl;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.html#isZOrderedOnTop()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsZOrderedOnTop()
        {
            return IExecuteWithSignature<bool>("isZOrderedOnTop", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.html#setZOrderedOnTop(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetZOrderedOnTop(bool arg0)
        {
            return IExecuteWithSignature<bool>("setZOrderedOnTop", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.html#onLayout(boolean,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void OnLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecute("onLayout", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.html#setSurfaceControlCallback(android.widget.inline.InlineContentView.SurfaceControlCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.Inline.InlineContentView.SurfaceControlCallback"/></param>
        public void SetSurfaceControlCallback(Android.Widget.Inline.InlineContentView.SurfaceControlCallback arg0)
        {
            IExecuteWithSignature("setSurfaceControlCallback", "(Landroid/widget/inline/InlineContentView$SurfaceControlCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region SurfaceControlCallback
        public partial class SurfaceControlCallback
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
            /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.SurfaceControlCallback.html#onCreated(android.view.SurfaceControl)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceControl"/></param>
            public void OnCreated(Android.View.SurfaceControl arg0)
            {
                IExecuteWithSignature("onCreated", "(Landroid/view/SurfaceControl;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/inline/InlineContentView.SurfaceControlCallback.html#onDestroyed(android.view.SurfaceControl)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceControl"/></param>
            public void OnDestroyed(Android.View.SurfaceControl arg0)
            {
                IExecuteWithSignature("onDestroyed", "(Landroid/view/SurfaceControl;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}