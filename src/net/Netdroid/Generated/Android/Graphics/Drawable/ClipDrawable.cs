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

namespace Android.Graphics.Drawable
{
    #region ClipDrawable
    public partial class ClipDrawable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ClipDrawable.html#%3Cinit%3E(android.graphics.drawable.Drawable,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ClipDrawable(Android.Graphics.Drawable.Drawable arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ClipDrawable.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/ClipDrawable.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 

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