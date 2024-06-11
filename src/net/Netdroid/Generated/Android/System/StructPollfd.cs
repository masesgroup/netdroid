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

namespace Android.System
{
    #region StructPollfd
    public partial class StructPollfd
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructPollfd.html#fd"/>
        /// </summary>
        public Java.Io.FileDescriptor fd { get { return IGetField<Java.Io.FileDescriptor>("fd"); } set { ISetField("fd", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructPollfd.html#userData"/>
        /// </summary>
        public object userData { get { return IGetField("userData"); } set { ISetField("userData", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructPollfd.html#events"/>
        /// </summary>
        public short events { get { return IGetField<short>("events"); } set { ISetField("events", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructPollfd.html#revents"/>
        /// </summary>
        public short revents { get { return IGetField<short>("revents"); } set { ISetField("revents", value); } }

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