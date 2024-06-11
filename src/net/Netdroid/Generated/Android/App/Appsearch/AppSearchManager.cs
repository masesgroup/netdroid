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

namespace Android.App.Appsearch
{
    #region AppSearchManager
    public partial class AppSearchManager
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.html#createGlobalSearchSession(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void CreateGlobalSearchSession(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.GlobalSearchSession>> arg1)
        {
            IExecute("createGlobalSearchSession", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.html#createSearchSession(android.app.appsearch.AppSearchManager.SearchContext,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.AppSearchManager.SearchContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void CreateSearchSession(Android.App.Appsearch.AppSearchManager.SearchContext arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.AppSearchSession>> arg2)
        {
            IExecute("createSearchSession", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region SearchContext
        public partial class SearchContext
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.html#getDatabaseName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDatabaseName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDatabaseName", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchManager.SearchContext"/></returns>
                public Android.App.Appsearch.AppSearchManager.SearchContext Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchManager.SearchContext>("build", "()Landroid/app/appsearch/AppSearchManager$SearchContext;");
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}