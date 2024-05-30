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
    #region ViewOutlineProvider
    public partial class ViewOutlineProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#BACKGROUND"/>
        /// </summary>
        public static Android.View.ViewOutlineProvider BACKGROUND { get { if (!_BACKGROUNDReady) { _BACKGROUNDContent = SGetField<Android.View.ViewOutlineProvider>(LocalBridgeClazz, "BACKGROUND"); _BACKGROUNDReady = true; } return _BACKGROUNDContent; } }
        private static Android.View.ViewOutlineProvider _BACKGROUNDContent = default;
        private static bool _BACKGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#BOUNDS"/>
        /// </summary>
        public static Android.View.ViewOutlineProvider BOUNDS { get { if (!_BOUNDSReady) { _BOUNDSContent = SGetField<Android.View.ViewOutlineProvider>(LocalBridgeClazz, "BOUNDS"); _BOUNDSReady = true; } return _BOUNDSContent; } }
        private static Android.View.ViewOutlineProvider _BOUNDSContent = default;
        private static bool _BOUNDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#PADDED_BOUNDS"/>
        /// </summary>
        public static Android.View.ViewOutlineProvider PADDED_BOUNDS { get { if (!_PADDED_BOUNDSReady) { _PADDED_BOUNDSContent = SGetField<Android.View.ViewOutlineProvider>(LocalBridgeClazz, "PADDED_BOUNDS"); _PADDED_BOUNDSReady = true; } return _PADDED_BOUNDSContent; } }
        private static Android.View.ViewOutlineProvider _PADDED_BOUNDSContent = default;
        private static bool _PADDED_BOUNDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#getOutline(android.view.View,android.graphics.Outline)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Outline"/></param>
        public void GetOutline(Android.View.View arg0, Android.Graphics.Outline arg1)
        {
            IExecute("getOutline", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}