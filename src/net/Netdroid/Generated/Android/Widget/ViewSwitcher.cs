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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region ViewSwitcher
    public partial class ViewSwitcher
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewSwitcher.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ViewSwitcher(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewSwitcher.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ViewSwitcher(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ViewSwitcher.html#getNextView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetNextView()
        {
            return IExecuteWithSignature<Android.View.View>("getNextView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewSwitcher.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewSwitcher.html#setFactory(android.widget.ViewSwitcher.ViewFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ViewSwitcher.ViewFactory"/></param>
        public void SetFactory(Android.Widget.ViewSwitcher.ViewFactory arg0)
        {
            IExecuteWithSignature("setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ViewFactory
        public partial class ViewFactory
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
            /// <see href="https://developer.android.com/reference/android/widget/ViewSwitcher.ViewFactory.html#makeView()"/>
            /// </summary>
            /// <returns><see cref="Android.View.View"/></returns>
            public Android.View.View MakeView()
            {
                return IExecuteWithSignature<Android.View.View>("makeView", "()Landroid/view/View;");
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