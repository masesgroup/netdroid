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
    #region Session
    public partial class Session
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
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#openBasicChannel(byte[],byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Android.Se.Omapi.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Se.Omapi.Channel OpenBasicChannel(byte[] arg0, byte arg1)
        {
            return IExecute<Android.Se.Omapi.Channel>("openBasicChannel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#openBasicChannel(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Android.Se.Omapi.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Se.Omapi.Channel OpenBasicChannel(byte[] arg0)
        {
            return IExecuteWithSignature<Android.Se.Omapi.Channel>("openBasicChannel", "([B)Landroid/se/omapi/Channel;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#openLogicalChannel(byte[],byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Android.Se.Omapi.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Se.Omapi.Channel OpenLogicalChannel(byte[] arg0, byte arg1)
        {
            return IExecute<Android.Se.Omapi.Channel>("openLogicalChannel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#openLogicalChannel(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Android.Se.Omapi.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Se.Omapi.Channel OpenLogicalChannel(byte[] arg0)
        {
            return IExecuteWithSignature<Android.Se.Omapi.Channel>("openLogicalChannel", "([B)Landroid/se/omapi/Channel;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#getReader()"/>
        /// </summary>
        /// <returns><see cref="Android.Se.Omapi.Reader"/></returns>
        public Android.Se.Omapi.Reader GetReader()
        {
            return IExecuteWithSignature<Android.Se.Omapi.Reader>("getReader", "()Landroid/se/omapi/Reader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#getATR()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetATR()
        {
            return IExecuteWithSignatureArray<byte>("getATR", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/Session.html#closeChannels()"/>
        /// </summary>
        public void CloseChannels()
        {
            IExecuteWithSignature("closeChannels", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}