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

namespace Android.Provider
{
    #region SearchRecentSuggestions
    public partial class SearchRecentSuggestions
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#%3Cinit%3E(android.content.Context,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SearchRecentSuggestions(Android.Content.Context arg0, Java.Lang.String arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#QUERIES_PROJECTION_DATE_INDEX"/>
        /// </summary>
        public static int QUERIES_PROJECTION_DATE_INDEX { get { if (!_QUERIES_PROJECTION_DATE_INDEXReady) { _QUERIES_PROJECTION_DATE_INDEXContent = SGetField<int>(LocalBridgeClazz, "QUERIES_PROJECTION_DATE_INDEX"); _QUERIES_PROJECTION_DATE_INDEXReady = true; } return _QUERIES_PROJECTION_DATE_INDEXContent; } }
        private static int _QUERIES_PROJECTION_DATE_INDEXContent = default;
        private static bool _QUERIES_PROJECTION_DATE_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#QUERIES_PROJECTION_DISPLAY1_INDEX"/>
        /// </summary>
        public static int QUERIES_PROJECTION_DISPLAY1_INDEX { get { if (!_QUERIES_PROJECTION_DISPLAY1_INDEXReady) { _QUERIES_PROJECTION_DISPLAY1_INDEXContent = SGetField<int>(LocalBridgeClazz, "QUERIES_PROJECTION_DISPLAY1_INDEX"); _QUERIES_PROJECTION_DISPLAY1_INDEXReady = true; } return _QUERIES_PROJECTION_DISPLAY1_INDEXContent; } }
        private static int _QUERIES_PROJECTION_DISPLAY1_INDEXContent = default;
        private static bool _QUERIES_PROJECTION_DISPLAY1_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#QUERIES_PROJECTION_DISPLAY2_INDEX"/>
        /// </summary>
        public static int QUERIES_PROJECTION_DISPLAY2_INDEX { get { if (!_QUERIES_PROJECTION_DISPLAY2_INDEXReady) { _QUERIES_PROJECTION_DISPLAY2_INDEXContent = SGetField<int>(LocalBridgeClazz, "QUERIES_PROJECTION_DISPLAY2_INDEX"); _QUERIES_PROJECTION_DISPLAY2_INDEXReady = true; } return _QUERIES_PROJECTION_DISPLAY2_INDEXContent; } }
        private static int _QUERIES_PROJECTION_DISPLAY2_INDEXContent = default;
        private static bool _QUERIES_PROJECTION_DISPLAY2_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#QUERIES_PROJECTION_QUERY_INDEX"/>
        /// </summary>
        public static int QUERIES_PROJECTION_QUERY_INDEX { get { if (!_QUERIES_PROJECTION_QUERY_INDEXReady) { _QUERIES_PROJECTION_QUERY_INDEXContent = SGetField<int>(LocalBridgeClazz, "QUERIES_PROJECTION_QUERY_INDEX"); _QUERIES_PROJECTION_QUERY_INDEXReady = true; } return _QUERIES_PROJECTION_QUERY_INDEXContent; } }
        private static int _QUERIES_PROJECTION_QUERY_INDEXContent = default;
        private static bool _QUERIES_PROJECTION_QUERY_INDEXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#QUERIES_PROJECTION_1LINE"/>
        /// </summary>
        public static Java.Lang.String[] QUERIES_PROJECTION_1LINE { get { if (!_QUERIES_PROJECTION_1LINEReady) { _QUERIES_PROJECTION_1LINEContent = SGetFieldArray<Java.Lang.String>(LocalBridgeClazz, "QUERIES_PROJECTION_1LINE"); _QUERIES_PROJECTION_1LINEReady = true; } return _QUERIES_PROJECTION_1LINEContent; } }
        private static Java.Lang.String[] _QUERIES_PROJECTION_1LINEContent = default;
        private static bool _QUERIES_PROJECTION_1LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#QUERIES_PROJECTION_2LINE"/>
        /// </summary>
        public static Java.Lang.String[] QUERIES_PROJECTION_2LINE { get { if (!_QUERIES_PROJECTION_2LINEReady) { _QUERIES_PROJECTION_2LINEContent = SGetFieldArray<Java.Lang.String>(LocalBridgeClazz, "QUERIES_PROJECTION_2LINE"); _QUERIES_PROJECTION_2LINEReady = true; } return _QUERIES_PROJECTION_2LINEContent; } }
        private static Java.Lang.String[] _QUERIES_PROJECTION_2LINEContent = default;
        private static bool _QUERIES_PROJECTION_2LINEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#clearHistory()"/>
        /// </summary>
        public void ClearHistory()
        {
            IExecuteWithSignature("clearHistory", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/SearchRecentSuggestions.html#saveRecentQuery(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SaveRecentQuery(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("saveRecentQuery", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}