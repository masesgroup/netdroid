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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View
{
    #region IScrollFeedbackProvider
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScrollFeedbackProvider
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScrollFeedbackProvider
    public partial class ScrollFeedbackProvider : Android.View.IScrollFeedbackProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollFeedbackProvider.html#createProvider(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.ScrollFeedbackProvider"/></returns>
        public static Android.View.ScrollFeedbackProvider CreateProvider(Android.View.View arg0)
        {
            return SExecuteWithSignature<Android.View.ScrollFeedbackProvider>(LocalBridgeClazz, "createProvider", "(Landroid/view/View;)Landroid/view/ScrollFeedbackProvider;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollFeedbackProvider.html#onScrollLimit(int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void OnScrollLimit(int arg0, int arg1, int arg2, bool arg3)
        {
            IExecute("onScrollLimit", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollFeedbackProvider.html#onScrollProgress(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void OnScrollProgress(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("onScrollProgress", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollFeedbackProvider.html#onSnapToItem(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnSnapToItem(int arg0, int arg1, int arg2)
        {
            IExecute("onSnapToItem", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}