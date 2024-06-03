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
    #region SearchSuggestionSpec
    public partial class SearchSuggestionSpec
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNT"/>
        /// </summary>
        public static int SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNT { get { if (!_SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNTReady) { _SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNTContent = SGetField<int>(LocalBridgeClazz, "SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNT"); _SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNTReady = true; } return _SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNTContent; } }
        private static int _SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNTContent = default;
        private static bool _SUGGESTION_RANKING_STRATEGY_DOCUMENT_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#SUGGESTION_RANKING_STRATEGY_NONE"/>
        /// </summary>
        public static int SUGGESTION_RANKING_STRATEGY_NONE { get { if (!_SUGGESTION_RANKING_STRATEGY_NONEReady) { _SUGGESTION_RANKING_STRATEGY_NONEContent = SGetField<int>(LocalBridgeClazz, "SUGGESTION_RANKING_STRATEGY_NONE"); _SUGGESTION_RANKING_STRATEGY_NONEReady = true; } return _SUGGESTION_RANKING_STRATEGY_NONEContent; } }
        private static int _SUGGESTION_RANKING_STRATEGY_NONEContent = default;
        private static bool _SUGGESTION_RANKING_STRATEGY_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCY"/>
        /// </summary>
        public static int SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCY { get { if (!_SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCYReady) { _SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCYContent = SGetField<int>(LocalBridgeClazz, "SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCY"); _SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCYReady = true; } return _SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCYContent; } }
        private static int _SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCYContent = default;
        private static bool _SUGGESTION_RANKING_STRATEGY_TERM_FREQUENCYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#getMaximumResultCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumResultCount()
        {
            return IExecuteWithSignature<int>("getMaximumResultCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#getRankingStrategy()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRankingStrategy()
        {
            return IExecuteWithSignature<int>("getRankingStrategy", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#getFilterNamespaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetFilterNamespaces()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getFilterNamespaces", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#getFilterSchemas()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetFilterSchemas()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getFilterSchemas", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.html#getFilterDocumentIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> GetFilterDocumentIds()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("getFilterDocumentIds", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec>("build", "()Landroid/app/appsearch/SearchSuggestionSpec;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#addFilterDocumentIds(java.lang.String,java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder AddFilterDocumentIds(Java.Lang.String arg0, params Java.Lang.String[] arg1)
            {
                if (arg1.Length == 0) return IExecute<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterDocumentIds", arg0); else return IExecute<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterDocumentIds", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#addFilterDocumentIds(java.lang.String,java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder AddFilterDocumentIds(Java.Lang.String arg0, Java.Util.Collection<Java.Lang.String> arg1)
            {
                return IExecute<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterDocumentIds", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#addFilterNamespaces(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder AddFilterNamespaces(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterNamespaces", "([Ljava/lang/String;)Landroid/app/appsearch/SearchSuggestionSpec$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterNamespaces", "([Ljava/lang/String;)Landroid/app/appsearch/SearchSuggestionSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#addFilterNamespaces(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder AddFilterNamespaces(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterNamespaces", "(Ljava/util/Collection;)Landroid/app/appsearch/SearchSuggestionSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#addFilterSchemas(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder AddFilterSchemas(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterSchemas", "([Ljava/lang/String;)Landroid/app/appsearch/SearchSuggestionSpec$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterSchemas", "([Ljava/lang/String;)Landroid/app/appsearch/SearchSuggestionSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#addFilterSchemas(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder AddFilterSchemas(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("addFilterSchemas", "(Ljava/util/Collection;)Landroid/app/appsearch/SearchSuggestionSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchSuggestionSpec.Builder.html#setRankingStrategy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchSuggestionSpec.Builder"/></returns>
            public Android.App.Appsearch.SearchSuggestionSpec.Builder SetRankingStrategy(int arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchSuggestionSpec.Builder>("setRankingStrategy", "(I)Landroid/app/appsearch/SearchSuggestionSpec$Builder;", arg0);
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