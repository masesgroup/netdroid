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

namespace Android.App
{
    #region Presentation
    public partial class Presentation
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Presentation.html#%3Cinit%3E(android.content.Context,android.view.Display,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.Display"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Presentation(Android.Content.Context arg0, Android.View.Display arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Presentation.html#%3Cinit%3E(android.content.Context,android.view.Display)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.Display"/></param>
        public Presentation(Android.Content.Context arg0, Android.View.Display arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/app/Presentation.html#getResources()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources"/></returns>
        public Android.Content.Res.Resources GetResources()
        {
            return IExecuteWithSignature<Android.Content.Res.Resources>("getResources", "()Landroid/content/res/Resources;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Presentation.html#getDisplay()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Display"/></returns>
        public Android.View.Display GetDisplay()
        {
            return IExecuteWithSignature<Android.View.Display>("getDisplay", "()Landroid/view/Display;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Presentation.html#onDisplayChanged()"/>
        /// </summary>
        public void OnDisplayChanged()
        {
            IExecuteWithSignature("onDisplayChanged", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Presentation.html#onDisplayRemoved()"/>
        /// </summary>
        public void OnDisplayRemoved()
        {
            IExecuteWithSignature("onDisplayRemoved", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}