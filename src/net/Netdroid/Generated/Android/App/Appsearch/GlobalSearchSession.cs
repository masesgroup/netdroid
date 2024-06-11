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
    #region GlobalSearchSession
    public partial class GlobalSearchSession
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#search(java.lang.String,android.app.appsearch.SearchSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.SearchSpec"/></param>
        /// <returns><see cref="Android.App.Appsearch.SearchResults"/></returns>
        public Android.App.Appsearch.SearchResults Search(Java.Lang.String arg0, Android.App.Appsearch.SearchSpec arg1)
        {
            return IExecute<Android.App.Appsearch.SearchResults>("search", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#getByDocumentId(java.lang.String,java.lang.String,android.app.appsearch.GetByDocumentIdRequest,java.util.concurrent.Executor,android.app.appsearch.BatchResultCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.App.Appsearch.GetByDocumentIdRequest"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.App.Appsearch.BatchResultCallback"/></param>
        public void GetByDocumentId(Java.Lang.String arg0, Java.Lang.String arg1, Android.App.Appsearch.GetByDocumentIdRequest arg2, Java.Util.Concurrent.Executor arg3, Android.App.Appsearch.BatchResultCallback<Java.Lang.String, Android.App.Appsearch.GenericDocument> arg4)
        {
            IExecute("getByDocumentId", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#getSchema(java.lang.String,java.lang.String,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetSchema(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.Concurrent.Executor arg2, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.GetSchemaResponse>> arg3)
        {
            IExecute("getSchema", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#registerObserverCallback(java.lang.String,android.app.appsearch.observer.ObserverSpec,java.util.concurrent.Executor,android.app.appsearch.observer.ObserverCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.Observer.ObserverSpec"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.App.Appsearch.Observer.ObserverCallback"/></param>
        /// <exception cref="Android.App.Appsearch.Exceptions.AppSearchException"/>
        public void RegisterObserverCallback(Java.Lang.String arg0, Android.App.Appsearch.Observer.ObserverSpec arg1, Java.Util.Concurrent.Executor arg2, Android.App.Appsearch.Observer.ObserverCallback arg3)
        {
            IExecute("registerObserverCallback", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#reportSystemUsage(android.app.appsearch.ReportSystemUsageRequest,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.ReportSystemUsageRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void ReportSystemUsage(Android.App.Appsearch.ReportSystemUsageRequest arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Java.Lang.Void>> arg2)
        {
            IExecute("reportSystemUsage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/GlobalSearchSession.html#unregisterObserverCallback(java.lang.String,android.app.appsearch.observer.ObserverCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.Observer.ObserverCallback"/></param>
        /// <exception cref="Android.App.Appsearch.Exceptions.AppSearchException"/>
        public void UnregisterObserverCallback(Java.Lang.String arg0, Android.App.Appsearch.Observer.ObserverCallback arg1)
        {
            IExecute("unregisterObserverCallback", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}