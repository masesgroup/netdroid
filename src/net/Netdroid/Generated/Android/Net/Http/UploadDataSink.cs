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

namespace Android.Net.Http
{
    #region UploadDataSink
    public partial class UploadDataSink
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
        /// <see href="https://developer.android.com/reference/android/net/http/UploadDataSink.html#onReadError(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        public void OnReadError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("onReadError", "(Ljava/lang/Exception;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/UploadDataSink.html#onReadSucceeded(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnReadSucceeded(bool arg0)
        {
            IExecuteWithSignature("onReadSucceeded", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/UploadDataSink.html#onRewindError(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        public void OnRewindError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("onRewindError", "(Ljava/lang/Exception;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/UploadDataSink.html#onRewindSucceeded()"/>
        /// </summary>
        public void OnRewindSucceeded()
        {
            IExecuteWithSignature("onRewindSucceeded", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}