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

namespace Android.Security
{
    #region ConfirmationCallback
    public partial class ConfirmationCallback
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
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationCallback.html#onCanceled()"/>
        /// </summary>
        public void OnCanceled()
        {
            IExecuteWithSignature("onCanceled", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationCallback.html#onConfirmed(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void OnConfirmed(byte[] arg0)
        {
            IExecuteWithSignature("onConfirmed", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationCallback.html#onDismissed()"/>
        /// </summary>
        public void OnDismissed()
        {
            IExecuteWithSignature("onDismissed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationCallback.html#onError(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void OnError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("onError", "(Ljava/lang/Throwable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}