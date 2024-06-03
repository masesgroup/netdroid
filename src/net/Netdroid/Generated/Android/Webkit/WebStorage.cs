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

namespace Android.Webkit
{
    #region WebStorage
    public partial class WebStorage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.WebStorage"/></returns>
        public static Android.Webkit.WebStorage GetInstance()
        {
            return SExecuteWithSignature<Android.Webkit.WebStorage>(LocalBridgeClazz, "getInstance", "()Landroid/webkit/WebStorage;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#deleteAllData()"/>
        /// </summary>
        public void DeleteAllData()
        {
            IExecuteWithSignature("deleteAllData", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#deleteOrigin(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void DeleteOrigin(Java.Lang.String arg0)
        {
            IExecuteWithSignature("deleteOrigin", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#getOrigins(android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.ValueCallback"/></param>
        public void GetOrigins(Android.Webkit.ValueCallback<Java.Util.Map> arg0)
        {
            IExecuteWithSignature("getOrigins", "(Landroid/webkit/ValueCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#getQuotaForOrigin(java.lang.String,android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.ValueCallback"/></param>
        public void GetQuotaForOrigin(Java.Lang.String arg0, Android.Webkit.ValueCallback<Java.Lang.Long> arg1)
        {
            IExecute("getQuotaForOrigin", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#getUsageForOrigin(java.lang.String,android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.ValueCallback"/></param>
        public void GetUsageForOrigin(Java.Lang.String arg0, Android.Webkit.ValueCallback<Java.Lang.Long> arg1)
        {
            IExecute("getUsageForOrigin", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.html#setQuotaForOrigin(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void SetQuotaForOrigin(Java.Lang.String arg0, long arg1)
        {
            IExecute("setQuotaForOrigin", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Origin
        public partial class Origin
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
            /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.Origin.html#getOrigin()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetOrigin()
            {
                return IExecuteWithSignature<Java.Lang.String>("getOrigin", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.Origin.html#getQuota()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetQuota()
            {
                return IExecuteWithSignature<long>("getQuota", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.Origin.html#getUsage()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetUsage()
            {
                return IExecuteWithSignature<long>("getUsage", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region QuotaUpdater
        public partial class QuotaUpdater
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
            /// <see href="https://developer.android.com/reference/android/webkit/WebStorage.QuotaUpdater.html#updateQuota(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            [global::System.Obsolete()]
            public void UpdateQuota(long arg0)
            {
                IExecuteWithSignature("updateQuota", "(J)V", arg0);
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