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

namespace Android.Security
{
    #region AppUriAuthenticationPolicy
    public partial class AppUriAuthenticationPolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/AppUriAuthenticationPolicy.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/AppUriAuthenticationPolicy.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/AppUriAuthenticationPolicy.html#getAppAndUriMappings()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.Map<Android.Net.Uri, Java.Lang.String>> GetAppAndUriMappings()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Map<Android.Net.Uri, Java.Lang.String>>>("getAppAndUriMappings", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/AppUriAuthenticationPolicy.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/security/AppUriAuthenticationPolicy.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.AppUriAuthenticationPolicy"/></returns>
            public Android.Security.AppUriAuthenticationPolicy Build()
            {
                return IExecuteWithSignature<Android.Security.AppUriAuthenticationPolicy>("build", "()Landroid/security/AppUriAuthenticationPolicy;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/AppUriAuthenticationPolicy.Builder.html#addAppAndUriMapping(java.lang.String,android.net.Uri,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Security.AppUriAuthenticationPolicy.Builder"/></returns>
            public Android.Security.AppUriAuthenticationPolicy.Builder AddAppAndUriMapping(Java.Lang.String arg0, Android.Net.Uri arg1, Java.Lang.String arg2)
            {
                return IExecute<Android.Security.AppUriAuthenticationPolicy.Builder>("addAppAndUriMapping", arg0, arg1, arg2);
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