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

namespace Android.Net.Ipsec.Ike
{
    #region IChildSessionCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IChildSessionCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ChildSessionCallback
    public partial class ChildSessionCallback : Android.Net.Ipsec.Ike.IChildSessionCallback
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
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionCallback.html#onClosed()"/>
        /// </summary>
        public void OnClosed()
        {
            IExecuteWithSignature("onClosed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionCallback.html#onIpSecTransformCreated(android.net.IpSecTransform,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.IpSecTransform"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnIpSecTransformCreated(Android.Net.IpSecTransform arg0, int arg1)
        {
            IExecute("onIpSecTransformCreated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionCallback.html#onIpSecTransformDeleted(android.net.IpSecTransform,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.IpSecTransform"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnIpSecTransformDeleted(Android.Net.IpSecTransform arg0, int arg1)
        {
            IExecute("onIpSecTransformDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionCallback.html#onOpened(android.net.ipsec.ike.ChildSessionConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.ChildSessionConfiguration"/></param>
        public void OnOpened(Android.Net.Ipsec.Ike.ChildSessionConfiguration arg0)
        {
            IExecuteWithSignature("onOpened", "(Landroid/net/ipsec/ike/ChildSessionConfiguration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionCallback.html#onClosedWithException(android.net.ipsec.ike.exceptions.IkeException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.Exceptions.IkeException"/></param>
        public void OnClosedWithException(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("onClosedWithException", "(Landroid/net/ipsec/ike/exceptions/IkeException;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}