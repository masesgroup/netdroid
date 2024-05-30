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
    #region AppSearchBatchResult
    public partial class AppSearchBatchResult
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#getAll()"/> 
        /// </summary>
        public Java.Util.Map All
        {
            get { return IExecuteWithSignature<Java.Util.Map>("getAll", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#getFailures()"/> 
        /// </summary>
        public Java.Util.Map Failures
        {
            get { return IExecuteWithSignature<Java.Util.Map>("getFailures", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#getSuccesses()"/> 
        /// </summary>
        public Java.Util.Map Successes
        {
            get { return IExecuteWithSignature<Java.Util.Map>("getSuccesses", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#isSuccess()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSuccess()
        {
            return IExecuteWithSignature<bool>("isSuccess", "()Z");
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.AppSearchBatchResult>("build", "()Landroid/app/appsearch/AppSearchBatchResult;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#setFailure(java.lang.Object,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult.Builder SetFailure(object arg0, int arg1, Java.Lang.String arg2)
            {
                return IExecute<Android.App.Appsearch.AppSearchBatchResult.Builder>("setFailure", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#setResult(java.lang.Object,android.app.appsearch.AppSearchResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="Android.App.Appsearch.AppSearchResult"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult.Builder SetResult(object arg0, Android.App.Appsearch.AppSearchResult arg1)
            {
                return IExecute<Android.App.Appsearch.AppSearchBatchResult.Builder>("setResult", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#setSuccess(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult.Builder SetSuccess(object arg0, object arg1)
            {
                return IExecute<Android.App.Appsearch.AppSearchBatchResult.Builder>("setSuccess", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Builder<KeyType, ValueType>
        public partial class Builder<KeyType, ValueType>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.App.Appsearch.AppSearchBatchResult.Builder{KeyType, ValueType}"/> to <see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/>
            /// </summary>
            public static implicit operator Android.App.Appsearch.AppSearchBatchResult.Builder(Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType> t) => t.Cast<Android.App.Appsearch.AppSearchBatchResult.Builder>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult<KeyType, ValueType> Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.AppSearchBatchResult<KeyType, ValueType>>("build", "()Landroid/app/appsearch/AppSearchBatchResult;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#setFailure(java.lang.Object,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="KeyType"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType> SetFailure(KeyType arg0, int arg1, Java.Lang.String arg2)
            {
                return IExecute<Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType>>("setFailure", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#setResult(java.lang.Object,android.app.appsearch.AppSearchResult)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="KeyType"/></param>
            /// <param name="arg1"><see cref="Android.App.Appsearch.AppSearchResult"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType> SetResult(KeyType arg0, Android.App.Appsearch.AppSearchResult<ValueType> arg1)
            {
                return IExecute<Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType>>("setResult", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.Builder.html#setSuccess(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="KeyType"/></param>
            /// <param name="arg1"><typeparamref name="ValueType"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchBatchResult.Builder"/></returns>
            public Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType> SetSuccess(KeyType arg0, ValueType arg1)
            {
                return IExecute<Android.App.Appsearch.AppSearchBatchResult.Builder<KeyType, ValueType>>("setSuccess", arg0, arg1);
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

    #region AppSearchBatchResult<KeyType, ValueType>
    public partial class AppSearchBatchResult<KeyType, ValueType>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.App.Appsearch.AppSearchBatchResult{KeyType, ValueType}"/> to <see cref="Android.App.Appsearch.AppSearchBatchResult"/>
        /// </summary>
        public static implicit operator Android.App.Appsearch.AppSearchBatchResult(Android.App.Appsearch.AppSearchBatchResult<KeyType, ValueType> t) => t.Cast<Android.App.Appsearch.AppSearchBatchResult>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#getAll()"/> 
        /// </summary>
        public Java.Util.Map<KeyType, Android.App.Appsearch.AppSearchResult<ValueType>> All
        {
            get { return IExecuteWithSignature<Java.Util.Map<KeyType, Android.App.Appsearch.AppSearchResult<ValueType>>>("getAll", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#getFailures()"/> 
        /// </summary>
        public Java.Util.Map<KeyType, Android.App.Appsearch.AppSearchResult<ValueType>> Failures
        {
            get { return IExecuteWithSignature<Java.Util.Map<KeyType, Android.App.Appsearch.AppSearchResult<ValueType>>>("getFailures", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#getSuccesses()"/> 
        /// </summary>
        public Java.Util.Map<KeyType, ValueType> Successes
        {
            get { return IExecuteWithSignature<Java.Util.Map<KeyType, ValueType>>("getSuccesses", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchBatchResult.html#isSuccess()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSuccess()
        {
            return IExecuteWithSignature<bool>("isSuccess", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}