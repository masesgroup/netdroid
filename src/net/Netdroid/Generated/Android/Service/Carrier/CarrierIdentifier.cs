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

namespace Android.Service.Carrier
{
    #region CarrierIdentifier
    public partial class CarrierIdentifier
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#%3Cinit%3E(byte[],java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public CarrierIdentifier(byte[] arg0, Java.Lang.String arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public CarrierIdentifier(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, Java.Lang.String arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        public CarrierIdentifier(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, Java.Lang.String arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getCarrierId()"/> 
        /// </summary>
        public int CarrierId
        {
            get { return IExecuteWithSignature<int>("getCarrierId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getGid1()"/> 
        /// </summary>
        public Java.Lang.String Gid1
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getGid1", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getGid2()"/> 
        /// </summary>
        public Java.Lang.String Gid2
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getGid2", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getImsi()"/> 
        /// </summary>
        public Java.Lang.String Imsi
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getImsi", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getMcc()"/> 
        /// </summary>
        public Java.Lang.String Mcc
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMcc", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getMnc()"/> 
        /// </summary>
        public Java.Lang.String Mnc
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMnc", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getSpecificCarrierId()"/> 
        /// </summary>
        public int SpecificCarrierId
        {
            get { return IExecuteWithSignature<int>("getSpecificCarrierId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#getSpn()"/> 
        /// </summary>
        public Java.Lang.String Spn
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpn", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/carrier/CarrierIdentifier.html#writeToParcel(android.os.Parcel,int)"/>
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