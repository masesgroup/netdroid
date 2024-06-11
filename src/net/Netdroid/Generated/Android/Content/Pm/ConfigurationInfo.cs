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

namespace Android.Content.Pm
{
    #region ConfigurationInfo
    public partial class ConfigurationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#%3Cinit%3E(android.content.pm.ConfigurationInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.ConfigurationInfo"/></param>
        public ConfigurationInfo(Android.Content.Pm.ConfigurationInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#reqGlEsVersion"/>
        /// </summary>
        public int reqGlEsVersion { get { return IGetField<int>("reqGlEsVersion"); } set { ISetField("reqGlEsVersion", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#reqInputFeatures"/>
        /// </summary>
        public int reqInputFeatures { get { return IGetField<int>("reqInputFeatures"); } set { ISetField("reqInputFeatures", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#reqKeyboardType"/>
        /// </summary>
        public int reqKeyboardType { get { return IGetField<int>("reqKeyboardType"); } set { ISetField("reqKeyboardType", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#reqNavigation"/>
        /// </summary>
        public int reqNavigation { get { return IGetField<int>("reqNavigation"); } set { ISetField("reqNavigation", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#reqTouchScreen"/>
        /// </summary>
        public int reqTouchScreen { get { return IGetField<int>("reqTouchScreen"); } set { ISetField("reqTouchScreen", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#GL_ES_VERSION_UNDEFINED"/>
        /// </summary>
        public static int GL_ES_VERSION_UNDEFINED { get { if (!_GL_ES_VERSION_UNDEFINEDReady) { _GL_ES_VERSION_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "GL_ES_VERSION_UNDEFINED"); _GL_ES_VERSION_UNDEFINEDReady = true; } return _GL_ES_VERSION_UNDEFINEDContent; } }
        private static int _GL_ES_VERSION_UNDEFINEDContent = default;
        private static bool _GL_ES_VERSION_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#INPUT_FEATURE_FIVE_WAY_NAV"/>
        /// </summary>
        public static int INPUT_FEATURE_FIVE_WAY_NAV { get { if (!_INPUT_FEATURE_FIVE_WAY_NAVReady) { _INPUT_FEATURE_FIVE_WAY_NAVContent = SGetField<int>(LocalBridgeClazz, "INPUT_FEATURE_FIVE_WAY_NAV"); _INPUT_FEATURE_FIVE_WAY_NAVReady = true; } return _INPUT_FEATURE_FIVE_WAY_NAVContent; } }
        private static int _INPUT_FEATURE_FIVE_WAY_NAVContent = default;
        private static bool _INPUT_FEATURE_FIVE_WAY_NAVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#INPUT_FEATURE_HARD_KEYBOARD"/>
        /// </summary>
        public static int INPUT_FEATURE_HARD_KEYBOARD { get { if (!_INPUT_FEATURE_HARD_KEYBOARDReady) { _INPUT_FEATURE_HARD_KEYBOARDContent = SGetField<int>(LocalBridgeClazz, "INPUT_FEATURE_HARD_KEYBOARD"); _INPUT_FEATURE_HARD_KEYBOARDReady = true; } return _INPUT_FEATURE_HARD_KEYBOARDContent; } }
        private static int _INPUT_FEATURE_HARD_KEYBOARDContent = default;
        private static bool _INPUT_FEATURE_HARD_KEYBOARDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#getGlEsVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetGlEsVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getGlEsVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/ConfigurationInfo.html#writeToParcel(android.os.Parcel,int)"/>
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