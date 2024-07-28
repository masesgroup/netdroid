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

namespace Android.App.Admin
{
    #region SystemUpdatePolicy
    public partial class SystemUpdatePolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#TYPE_INSTALL_AUTOMATIC"/>
        /// </summary>
        public static int TYPE_INSTALL_AUTOMATIC { get { if (!_TYPE_INSTALL_AUTOMATICReady) { _TYPE_INSTALL_AUTOMATICContent = SGetField<int>(LocalBridgeClazz, "TYPE_INSTALL_AUTOMATIC"); _TYPE_INSTALL_AUTOMATICReady = true; } return _TYPE_INSTALL_AUTOMATICContent; } }
        private static int _TYPE_INSTALL_AUTOMATICContent = default;
        private static bool _TYPE_INSTALL_AUTOMATICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#TYPE_INSTALL_WINDOWED"/>
        /// </summary>
        public static int TYPE_INSTALL_WINDOWED { get { if (!_TYPE_INSTALL_WINDOWEDReady) { _TYPE_INSTALL_WINDOWEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_INSTALL_WINDOWED"); _TYPE_INSTALL_WINDOWEDReady = true; } return _TYPE_INSTALL_WINDOWEDContent; } }
        private static int _TYPE_INSTALL_WINDOWEDContent = default;
        private static bool _TYPE_INSTALL_WINDOWEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#TYPE_POSTPONE"/>
        /// </summary>
        public static int TYPE_POSTPONE { get { if (!_TYPE_POSTPONEReady) { _TYPE_POSTPONEContent = SGetField<int>(LocalBridgeClazz, "TYPE_POSTPONE"); _TYPE_POSTPONEReady = true; } return _TYPE_POSTPONEContent; } }
        private static int _TYPE_POSTPONEContent = default;
        private static bool _TYPE_POSTPONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#createAutomaticInstallPolicy()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Admin.SystemUpdatePolicy"/></returns>
        public static Android.App.Admin.SystemUpdatePolicy CreateAutomaticInstallPolicy()
        {
            return SExecuteWithSignature<Android.App.Admin.SystemUpdatePolicy>(LocalBridgeClazz, "createAutomaticInstallPolicy", "()Landroid/app/admin/SystemUpdatePolicy;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#createPostponeInstallPolicy()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Admin.SystemUpdatePolicy"/></returns>
        public static Android.App.Admin.SystemUpdatePolicy CreatePostponeInstallPolicy()
        {
            return SExecuteWithSignature<Android.App.Admin.SystemUpdatePolicy>(LocalBridgeClazz, "createPostponeInstallPolicy", "()Landroid/app/admin/SystemUpdatePolicy;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#createWindowedInstallPolicy(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Admin.SystemUpdatePolicy"/></returns>
        public static Android.App.Admin.SystemUpdatePolicy CreateWindowedInstallPolicy(int arg0, int arg1)
        {
            return SExecute<Android.App.Admin.SystemUpdatePolicy>(LocalBridgeClazz, "createWindowedInstallPolicy", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#setFreezePeriods(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Android.App.Admin.SystemUpdatePolicy"/></returns>
        public Android.App.Admin.SystemUpdatePolicy SetFreezePeriods(Java.Util.List<Android.App.Admin.FreezePeriod> arg0)
        {
            return IExecuteWithSignature<Android.App.Admin.SystemUpdatePolicy>("setFreezePeriods", "(Ljava/util/List;)Landroid/app/admin/SystemUpdatePolicy;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#getInstallWindowEnd()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInstallWindowEnd()
        {
            return IExecuteWithSignature<int>("getInstallWindowEnd", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#getInstallWindowStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInstallWindowStart()
        {
            return IExecuteWithSignature<int>("getInstallWindowStart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#getPolicyType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPolicyType()
        {
            return IExecuteWithSignature<int>("getPolicyType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#getFreezePeriods()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Admin.FreezePeriod> GetFreezePeriods()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Admin.FreezePeriod>>("getFreezePeriods", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/SystemUpdatePolicy.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region ValidationFailedException
        public partial class ValidationFailedException
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}