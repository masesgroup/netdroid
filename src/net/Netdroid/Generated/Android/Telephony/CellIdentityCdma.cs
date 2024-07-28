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

namespace Android.Telephony
{
    #region CellIdentityCdma
    public partial class CellIdentityCdma
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityCdma.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityCdma.html#getBasestationId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBasestationId()
        {
            return IExecuteWithSignature<int>("getBasestationId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityCdma.html#getLatitude()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLatitude()
        {
            return IExecuteWithSignature<int>("getLatitude", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityCdma.html#getLongitude()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLongitude()
        {
            return IExecuteWithSignature<int>("getLongitude", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityCdma.html#getNetworkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkId()
        {
            return IExecuteWithSignature<int>("getNetworkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityCdma.html#getSystemId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSystemId()
        {
            return IExecuteWithSignature<int>("getSystemId", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}