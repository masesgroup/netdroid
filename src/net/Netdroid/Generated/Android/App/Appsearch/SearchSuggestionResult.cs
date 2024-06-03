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

namespace Android.App.Appsearch
{
    #region SearchSuggestionResult
    public partial class SearchSuggestionResult
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionResult.html#getSuggestedResult()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSuggestedResult()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSuggestedResult", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionResult.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionResult"/></returns>
            public Android.App.Appsearch.SearchSuggestionResult Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionResult>("build", "()Landroid/app/appsearch/SearchSuggestionResult;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionResult.Builder.html#setSuggestedResult(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionResult.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionResult.Builder SetSuggestedResult(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionResult.Builder>("setSuggestedResult", "(Ljava/lang/String;)Landroid/app/appsearch/SearchSuggestionResult$Builder;", arg0);
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