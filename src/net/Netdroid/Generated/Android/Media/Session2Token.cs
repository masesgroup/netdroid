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

namespace Android.Media
{
    #region Session2Token
    public partial class Session2Token
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#%3Cinit%3E(android.content.Context,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        public Session2Token(Android.Content.Context arg0, Android.Content.ComponentName arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#TYPE_SESSION"/>
        /// </summary>
        public static int TYPE_SESSION { get { if (!_TYPE_SESSIONReady) { _TYPE_SESSIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_SESSION"); _TYPE_SESSIONReady = true; } return _TYPE_SESSIONContent; } }
        private static int _TYPE_SESSIONContent = default;
        private static bool _TYPE_SESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#TYPE_SESSION_SERVICE"/>
        /// </summary>
        public static int TYPE_SESSION_SERVICE { get { if (!_TYPE_SESSION_SERVICEReady) { _TYPE_SESSION_SERVICEContent = SGetField<int>(LocalBridgeClazz, "TYPE_SESSION_SERVICE"); _TYPE_SESSION_SERVICEReady = true; } return _TYPE_SESSION_SERVICEContent; } }
        private static int _TYPE_SESSION_SERVICEContent = default;
        private static bool _TYPE_SESSION_SERVICEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#getUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUid()
        {
            return IExecuteWithSignature<int>("getUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#getServiceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetServiceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServiceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Token.html#writeToParcel(android.os.Parcel,int)"/>
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