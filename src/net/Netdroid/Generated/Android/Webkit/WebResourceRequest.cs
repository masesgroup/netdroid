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

namespace Android.Webkit
{
    #region IWebResourceRequest
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWebResourceRequest
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WebResourceRequest
    public partial class WebResourceRequest : Android.Webkit.IWebResourceRequest
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
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceRequest.html#getUrl()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetUrl()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getUrl", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceRequest.html#hasGesture()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasGesture()
        {
            return IExecuteWithSignature<bool>("hasGesture", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceRequest.html#isForMainFrame()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForMainFrame()
        {
            return IExecuteWithSignature<bool>("isForMainFrame", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceRequest.html#isRedirect()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRedirect()
        {
            return IExecuteWithSignature<bool>("isRedirect", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceRequest.html#getMethod()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMethod()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMethod", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceRequest.html#getRequestHeaders()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> GetRequestHeaders()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("getRequestHeaders", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}