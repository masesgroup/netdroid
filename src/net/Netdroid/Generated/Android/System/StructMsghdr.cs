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

namespace Android.System
{
    #region StructMsghdr
    public partial class StructMsghdr
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructMsghdr.html#%3Cinit%3E(java.net.SocketAddress,java.nio.ByteBuffer[],android.system.StructCmsghdr[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Android.System.StructCmsghdr"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public StructMsghdr(Java.Net.SocketAddress arg0, Java.Nio.ByteBuffer[] arg1, Android.System.StructCmsghdr[] arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructMsghdr.html#msg_control"/>
        /// </summary>
        public Android.System.StructCmsghdr[] msg_control { get { return IGetFieldArray<Android.System.StructCmsghdr>("msg_control"); } set { ISetField("msg_control", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructMsghdr.html#msg_iov"/>
        /// </summary>
        public Java.Nio.ByteBuffer[] msg_iov { get { if (!_msg_iovReady) { _msg_iovContent = IGetFieldArray<Java.Nio.ByteBuffer>("msg_iov"); _msg_iovReady = true; } return _msg_iovContent; } }
        private Java.Nio.ByteBuffer[] _msg_iovContent = default;
        private bool _msg_iovReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructMsghdr.html#msg_flags"/>
        /// </summary>
        public int msg_flags { get { return IGetField<int>("msg_flags"); } set { ISetField("msg_flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructMsghdr.html#msg_name"/>
        /// </summary>
        public Java.Net.SocketAddress msg_name { get { return IGetField<Java.Net.SocketAddress>("msg_name"); } set { ISetField("msg_name", value); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}