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

namespace Android.Webkit
{
    #region WebMessagePort
    public partial class WebMessagePort
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
        /// <see href="https://developer.android.com/reference/android/webkit/WebMessagePort.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebMessagePort.html#postMessage(android.webkit.WebMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebMessage"/></param>
        public void PostMessage(Android.Webkit.WebMessage arg0)
        {
            IExecuteWithSignature("postMessage", "(Landroid/webkit/WebMessage;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebMessagePort.html#setWebMessageCallback(android.webkit.WebMessagePort.WebMessageCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebMessagePort.WebMessageCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void SetWebMessageCallback(Android.Webkit.WebMessagePort.WebMessageCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("setWebMessageCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebMessagePort.html#setWebMessageCallback(android.webkit.WebMessagePort.WebMessageCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebMessagePort.WebMessageCallback"/></param>
        public void SetWebMessageCallback(Android.Webkit.WebMessagePort.WebMessageCallback arg0)
        {
            IExecuteWithSignature("setWebMessageCallback", "(Landroid/webkit/WebMessagePort$WebMessageCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region WebMessageCallback
        public partial class WebMessageCallback
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
            /// <see href="https://developer.android.com/reference/android/webkit/WebMessagePort.WebMessageCallback.html#onMessage(android.webkit.WebMessagePort,android.webkit.WebMessage)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Webkit.WebMessagePort"/></param>
            /// <param name="arg1"><see cref="Android.Webkit.WebMessage"/></param>
            public void OnMessage(Android.Webkit.WebMessagePort arg0, Android.Webkit.WebMessage arg1)
            {
                IExecute("onMessage", arg0, arg1);
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