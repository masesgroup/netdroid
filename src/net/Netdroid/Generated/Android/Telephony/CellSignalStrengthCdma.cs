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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony
{
    #region CellSignalStrengthCdma
    public partial class CellSignalStrengthCdma
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Telephony.CellSignalStrengthCdma"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Telephony.CellSignalStrengthCdma t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getCdmaDbm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCdmaDbm()
        {
            return IExecuteWithSignature<int>("getCdmaDbm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getCdmaEcio()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCdmaEcio()
        {
            return IExecuteWithSignature<int>("getCdmaEcio", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getCdmaLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCdmaLevel()
        {
            return IExecuteWithSignature<int>("getCdmaLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getEvdoDbm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEvdoDbm()
        {
            return IExecuteWithSignature<int>("getEvdoDbm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getEvdoEcio()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEvdoEcio()
        {
            return IExecuteWithSignature<int>("getEvdoEcio", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getEvdoLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEvdoLevel()
        {
            return IExecuteWithSignature<int>("getEvdoLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#getEvdoSnr()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEvdoSnr()
        {
            return IExecuteWithSignature<int>("getEvdoSnr", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrengthCdma.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}