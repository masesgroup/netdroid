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
    #region ReportSystemUsageRequest
    public partial class ReportSystemUsageRequest
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.html#getDatabaseName()"/> 
        /// </summary>
        public Java.Lang.String DatabaseName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDatabaseName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.html#getDocumentId()"/> 
        /// </summary>
        public Java.Lang.String DocumentId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDocumentId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.html#getNamespace()"/> 
        /// </summary>
        public Java.Lang.String Namespace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNamespace", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.html#getPackageName()"/> 
        /// </summary>
        public Java.Lang.String PackageName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.html#getUsageTimestampMillis()"/> 
        /// </summary>
        public long UsageTimestampMillis
        {
            get { return IExecuteWithSignature<long>("getUsageTimestampMillis", "()J"); }
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.Builder.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.ReportSystemUsageRequest"/></returns>
            public Android.App.Appsearch.ReportSystemUsageRequest Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.ReportSystemUsageRequest>("build", "()Landroid/app/appsearch/ReportSystemUsageRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/ReportSystemUsageRequest.Builder.html#setUsageTimestampMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.App.Appsearch.ReportSystemUsageRequest.Builder"/></returns>
            public Android.App.Appsearch.ReportSystemUsageRequest.Builder SetUsageTimestampMillis(long arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.ReportSystemUsageRequest.Builder>("setUsageTimestampMillis", "(J)Landroid/app/appsearch/ReportSystemUsageRequest$Builder;", arg0);
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