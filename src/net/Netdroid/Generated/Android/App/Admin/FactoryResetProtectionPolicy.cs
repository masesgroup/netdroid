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
    #region FactoryResetProtectionPolicy
    public partial class FactoryResetProtectionPolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.html#isFactoryResetProtectionEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFactoryResetProtectionEnabled()
        {
            return IExecuteWithSignature<bool>("isFactoryResetProtectionEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.html#getFactoryResetProtectionAccounts()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetFactoryResetProtectionAccounts()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getFactoryResetProtectionAccounts", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Admin.FactoryResetProtectionPolicy"/></returns>
            public Android.App.Admin.FactoryResetProtectionPolicy Build()
            {
                return IExecuteWithSignature<Android.App.Admin.FactoryResetProtectionPolicy>("build", "()Landroid/app/admin/FactoryResetProtectionPolicy;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.Builder.html#setFactoryResetProtectionAccounts(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Admin.FactoryResetProtectionPolicy.Builder"/></returns>
            public Android.App.Admin.FactoryResetProtectionPolicy.Builder SetFactoryResetProtectionAccounts(Java.Util.List<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.FactoryResetProtectionPolicy.Builder>("setFactoryResetProtectionAccounts", "(Ljava/util/List;)Landroid/app/admin/FactoryResetProtectionPolicy$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/FactoryResetProtectionPolicy.Builder.html#setFactoryResetProtectionEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Admin.FactoryResetProtectionPolicy.Builder"/></returns>
            public Android.App.Admin.FactoryResetProtectionPolicy.Builder SetFactoryResetProtectionEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.FactoryResetProtectionPolicy.Builder>("setFactoryResetProtectionEnabled", "(Z)Landroid/app/admin/FactoryResetProtectionPolicy$Builder;", arg0);
            }

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