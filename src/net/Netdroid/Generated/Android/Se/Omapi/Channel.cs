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

namespace Android.Se.Omapi
{
    #region Channel
    public partial class Channel
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
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#getSession()"/>
        /// </summary>
        /// <returns><see cref="Android.Se.Omapi.Session"/></returns>
        public Android.Se.Omapi.Session GetSession()
        {
            return IExecuteWithSignature<Android.Se.Omapi.Session>("getSession", "()Landroid/se/omapi/Session;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#isBasicChannel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBasicChannel()
        {
            return IExecuteWithSignature<bool>("isBasicChannel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#selectNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool SelectNext()
        {
            return IExecuteWithSignature<bool>("selectNext", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#getSelectResponse()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSelectResponse()
        {
            return IExecuteWithSignatureArray<byte>("getSelectResponse", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#transmit(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] Transmit(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("transmit", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Channel.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}