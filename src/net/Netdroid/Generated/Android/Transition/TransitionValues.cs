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

namespace Android.Transition
{
    #region TransitionValues
    public partial class TransitionValues
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionValues.html#%3Cinit%3E(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public TransitionValues(Android.View.View arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionValues.html#view"/>
        /// </summary>
        public Android.View.View view { get { return IGetField<Android.View.View>("view"); } set { ISetField("view", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionValues.html#values"/>
        /// </summary>
        public Java.Util.Map values { get { if (!_valuesReady) { _valuesContent = IGetField<Java.Util.Map>("values"); _valuesReady = true; } return _valuesContent; } }
        private Java.Util.Map _valuesContent = default;
        private bool _valuesReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}