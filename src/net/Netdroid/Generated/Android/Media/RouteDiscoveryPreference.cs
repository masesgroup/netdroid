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

namespace Android.Media
{
    #region RouteDiscoveryPreference
    public partial class RouteDiscoveryPreference
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.html#getPreferredFeatures()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> PreferredFeatures
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getPreferredFeatures", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.html#shouldPerformActiveScan()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldPerformActiveScan()
        {
            return IExecuteWithSignature<bool>("shouldPerformActiveScan", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.Builder.html#%3Cinit%3E(android.media.RouteDiscoveryPreference)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.RouteDiscoveryPreference"/></param>
            public Builder(Android.Media.RouteDiscoveryPreference arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.Builder.html#%3Cinit%3E(java.util.List,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public Builder(Java.Util.List<Java.Lang.String> arg0, bool arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.RouteDiscoveryPreference"/></returns>
            public Android.Media.RouteDiscoveryPreference Build()
            {
                return IExecuteWithSignature<Android.Media.RouteDiscoveryPreference>("build", "()Landroid/media/RouteDiscoveryPreference;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.Builder.html#setPreferredFeatures(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Media.RouteDiscoveryPreference.Builder"/></returns>
            public Android.Media.RouteDiscoveryPreference.Builder SetPreferredFeatures(Java.Util.List<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.Media.RouteDiscoveryPreference.Builder>("setPreferredFeatures", "(Ljava/util/List;)Landroid/media/RouteDiscoveryPreference$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/RouteDiscoveryPreference.Builder.html#setShouldPerformActiveScan(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Media.RouteDiscoveryPreference.Builder"/></returns>
            public Android.Media.RouteDiscoveryPreference.Builder SetShouldPerformActiveScan(bool arg0)
            {
                return IExecuteWithSignature<Android.Media.RouteDiscoveryPreference.Builder>("setShouldPerformActiveScan", "(Z)Landroid/media/RouteDiscoveryPreference$Builder;", arg0);
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