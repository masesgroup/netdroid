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

namespace Android.App.Admin
{
    #region PackagePolicy
    public partial class PackagePolicy
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#%3Cinit%3E(int,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        public PackagePolicy(int arg0, Java.Util.Set<Java.Lang.String> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public PackagePolicy(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#PACKAGE_POLICY_ALLOWLIST"/>
        /// </summary>
        public static int PACKAGE_POLICY_ALLOWLIST { get { if (!_PACKAGE_POLICY_ALLOWLISTReady) { _PACKAGE_POLICY_ALLOWLISTContent = SGetField<int>(LocalBridgeClazz, "PACKAGE_POLICY_ALLOWLIST"); _PACKAGE_POLICY_ALLOWLISTReady = true; } return _PACKAGE_POLICY_ALLOWLISTContent; } }
        private static int _PACKAGE_POLICY_ALLOWLISTContent = default;
        private static bool _PACKAGE_POLICY_ALLOWLISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#PACKAGE_POLICY_ALLOWLIST_AND_SYSTEM"/>
        /// </summary>
        public static int PACKAGE_POLICY_ALLOWLIST_AND_SYSTEM { get { if (!_PACKAGE_POLICY_ALLOWLIST_AND_SYSTEMReady) { _PACKAGE_POLICY_ALLOWLIST_AND_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "PACKAGE_POLICY_ALLOWLIST_AND_SYSTEM"); _PACKAGE_POLICY_ALLOWLIST_AND_SYSTEMReady = true; } return _PACKAGE_POLICY_ALLOWLIST_AND_SYSTEMContent; } }
        private static int _PACKAGE_POLICY_ALLOWLIST_AND_SYSTEMContent = default;
        private static bool _PACKAGE_POLICY_ALLOWLIST_AND_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#PACKAGE_POLICY_BLOCKLIST"/>
        /// </summary>
        public static int PACKAGE_POLICY_BLOCKLIST { get { if (!_PACKAGE_POLICY_BLOCKLISTReady) { _PACKAGE_POLICY_BLOCKLISTContent = SGetField<int>(LocalBridgeClazz, "PACKAGE_POLICY_BLOCKLIST"); _PACKAGE_POLICY_BLOCKLISTReady = true; } return _PACKAGE_POLICY_BLOCKLISTContent; } }
        private static int _PACKAGE_POLICY_BLOCKLISTContent = default;
        private static bool _PACKAGE_POLICY_BLOCKLISTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#getPolicyType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPolicyType()
        {
            return IExecuteWithSignature<int>("getPolicyType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#getPackageNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetPackageNames()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getPackageNames", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PackagePolicy.html#writeToParcel(android.os.Parcel,int)"/>
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