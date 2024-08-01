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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Webkit
{
    #region TracingController
    public partial class TracingController
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/TracingController.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.TracingController"/></returns>
        public static Android.Webkit.TracingController GetInstance()
        {
            return SExecuteWithSignature<Android.Webkit.TracingController>(LocalBridgeClazz, "getInstance", "()Landroid/webkit/TracingController;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/TracingController.html#isTracing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTracing()
        {
            return IExecuteWithSignature<bool>("isTracing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/TracingController.html#stop(java.io.OutputStream,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Stop(Java.Io.OutputStream arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<bool>("stop", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/TracingController.html#start(android.webkit.TracingConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.TracingConfig"/></param>
        public void Start(Android.Webkit.TracingConfig arg0)
        {
            IExecuteWithSignature("start", "(Landroid/webkit/TracingConfig;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}