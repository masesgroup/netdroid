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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Provider
{
    #region Browser
    public partial class Browser
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/Browser.html#EXTRA_APPLICATION_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPLICATION_ID { get { if (!_EXTRA_APPLICATION_IDReady) { _EXTRA_APPLICATION_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPLICATION_ID"); _EXTRA_APPLICATION_IDReady = true; } return _EXTRA_APPLICATION_IDContent; } }
        private static Java.Lang.String _EXTRA_APPLICATION_IDContent = default;
        private static bool _EXTRA_APPLICATION_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/Browser.html#EXTRA_CREATE_NEW_TAB"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CREATE_NEW_TAB { get { if (!_EXTRA_CREATE_NEW_TABReady) { _EXTRA_CREATE_NEW_TABContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CREATE_NEW_TAB"); _EXTRA_CREATE_NEW_TABReady = true; } return _EXTRA_CREATE_NEW_TABContent; } }
        private static Java.Lang.String _EXTRA_CREATE_NEW_TABContent = default;
        private static bool _EXTRA_CREATE_NEW_TABReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/Browser.html#EXTRA_HEADERS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_HEADERS { get { if (!_EXTRA_HEADERSReady) { _EXTRA_HEADERSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_HEADERS"); _EXTRA_HEADERSReady = true; } return _EXTRA_HEADERSContent; } }
        private static Java.Lang.String _EXTRA_HEADERSContent = default;
        private static bool _EXTRA_HEADERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/Browser.html#INITIAL_ZOOM_LEVEL"/>
        /// </summary>
        public static Java.Lang.String INITIAL_ZOOM_LEVEL { get { if (!_INITIAL_ZOOM_LEVELReady) { _INITIAL_ZOOM_LEVELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INITIAL_ZOOM_LEVEL"); _INITIAL_ZOOM_LEVELReady = true; } return _INITIAL_ZOOM_LEVELContent; } }
        private static Java.Lang.String _INITIAL_ZOOM_LEVELContent = default;
        private static bool _INITIAL_ZOOM_LEVELReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/Browser.html#sendString(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public static void SendString(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            SExecute(LocalBridgeClazz, "sendString", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}