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

namespace Android.Content.Pm
{
    #region ApkChecksum
    public partial class ApkChecksum
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#getInstallerCertificate()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate InstallerCertificate
        {
            get { return IExecuteWithSignature<Java.Security.Cert.Certificate>("getInstallerCertificate", "()Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#getInstallerPackageName()"/> 
        /// </summary>
        public Java.Lang.String InstallerPackageName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInstallerPackageName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#getSplitName()"/> 
        /// </summary>
        public Java.Lang.String SplitName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSplitName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#getValue()"/> 
        /// </summary>
        public byte[] Value
        {
            get { return IExecuteWithSignatureArray<byte>("getValue", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ApkChecksum.html#writeToParcel(android.os.Parcel,int)"/>
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