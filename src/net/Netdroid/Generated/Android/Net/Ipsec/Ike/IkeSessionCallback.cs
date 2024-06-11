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

namespace Android.Net.Ipsec.Ike
{
    #region IIkeSessionCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IIkeSessionCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IkeSessionCallback
    public partial class IkeSessionCallback : Android.Net.Ipsec.Ike.IIkeSessionCallback
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
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionCallback.html#onClosed()"/>
        /// </summary>
        public void OnClosed()
        {
            IExecuteWithSignature("onClosed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionCallback.html#onOpened(android.net.ipsec.ike.IkeSessionConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeSessionConfiguration"/></param>
        public void OnOpened(Android.Net.Ipsec.Ike.IkeSessionConfiguration arg0)
        {
            IExecuteWithSignature("onOpened", "(Landroid/net/ipsec/ike/IkeSessionConfiguration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionCallback.html#onClosedWithException(android.net.ipsec.ike.exceptions.IkeException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.Exceptions.IkeException"/></param>
        public void OnClosedWithException(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("onClosedWithException", "(Landroid/net/ipsec/ike/exceptions/IkeException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSessionCallback.html#onError(android.net.ipsec.ike.exceptions.IkeException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.Exceptions.IkeException"/></param>
        public void OnError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("onError", "(Landroid/net/ipsec/ike/exceptions/IkeException;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}