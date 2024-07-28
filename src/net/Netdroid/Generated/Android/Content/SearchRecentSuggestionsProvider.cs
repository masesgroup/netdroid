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

namespace Android.Content
{
    #region SearchRecentSuggestionsProvider
    public partial class SearchRecentSuggestionsProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SearchRecentSuggestionsProvider.html#DATABASE_MODE_2LINES"/>
        /// </summary>
        public static int DATABASE_MODE_2LINES { get { if (!_DATABASE_MODE_2LINESReady) { _DATABASE_MODE_2LINESContent = SGetField<int>(LocalBridgeClazz, "DATABASE_MODE_2LINES"); _DATABASE_MODE_2LINESReady = true; } return _DATABASE_MODE_2LINESContent; } }
        private static int _DATABASE_MODE_2LINESContent = default;
        private static bool _DATABASE_MODE_2LINESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SearchRecentSuggestionsProvider.html#DATABASE_MODE_QUERIES"/>
        /// </summary>
        public static int DATABASE_MODE_QUERIES { get { if (!_DATABASE_MODE_QUERIESReady) { _DATABASE_MODE_QUERIESContent = SGetField<int>(LocalBridgeClazz, "DATABASE_MODE_QUERIES"); _DATABASE_MODE_QUERIESReady = true; } return _DATABASE_MODE_QUERIESContent; } }
        private static int _DATABASE_MODE_QUERIESContent = default;
        private static bool _DATABASE_MODE_QUERIESReady = false; // this is used because in case of generics 

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