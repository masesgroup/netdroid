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

namespace Android.View.Translation
{
    #region TranslationCapability
    public partial class TranslationCapability
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#STATE_AVAILABLE_TO_DOWNLOAD"/>
        /// </summary>
        public static int STATE_AVAILABLE_TO_DOWNLOAD { get { if (!_STATE_AVAILABLE_TO_DOWNLOADReady) { _STATE_AVAILABLE_TO_DOWNLOADContent = SGetField<int>(LocalBridgeClazz, "STATE_AVAILABLE_TO_DOWNLOAD"); _STATE_AVAILABLE_TO_DOWNLOADReady = true; } return _STATE_AVAILABLE_TO_DOWNLOADContent; } }
        private static int _STATE_AVAILABLE_TO_DOWNLOADContent = default;
        private static bool _STATE_AVAILABLE_TO_DOWNLOADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#STATE_DOWNLOADING"/>
        /// </summary>
        public static int STATE_DOWNLOADING { get { if (!_STATE_DOWNLOADINGReady) { _STATE_DOWNLOADINGContent = SGetField<int>(LocalBridgeClazz, "STATE_DOWNLOADING"); _STATE_DOWNLOADINGReady = true; } return _STATE_DOWNLOADINGContent; } }
        private static int _STATE_DOWNLOADINGContent = default;
        private static bool _STATE_DOWNLOADINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#STATE_NOT_AVAILABLE"/>
        /// </summary>
        public static int STATE_NOT_AVAILABLE { get { if (!_STATE_NOT_AVAILABLEReady) { _STATE_NOT_AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "STATE_NOT_AVAILABLE"); _STATE_NOT_AVAILABLEReady = true; } return _STATE_NOT_AVAILABLEContent; } }
        private static int _STATE_NOT_AVAILABLEContent = default;
        private static bool _STATE_NOT_AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#STATE_ON_DEVICE"/>
        /// </summary>
        public static int STATE_ON_DEVICE { get { if (!_STATE_ON_DEVICEReady) { _STATE_ON_DEVICEContent = SGetField<int>(LocalBridgeClazz, "STATE_ON_DEVICE"); _STATE_ON_DEVICEReady = true; } return _STATE_ON_DEVICEContent; } }
        private static int _STATE_ON_DEVICEContent = default;
        private static bool _STATE_ON_DEVICEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#getSourceSpec()"/> 
        /// </summary>
        public Android.View.Translation.TranslationSpec SourceSpec
        {
            get { return IExecuteWithSignature<Android.View.Translation.TranslationSpec>("getSourceSpec", "()Landroid/view/translation/TranslationSpec;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#getState()"/> 
        /// </summary>
        public int State
        {
            get { return IExecuteWithSignature<int>("getState", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#getSupportedTranslationFlags()"/> 
        /// </summary>
        public int SupportedTranslationFlags
        {
            get { return IExecuteWithSignature<int>("getSupportedTranslationFlags", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#getTargetSpec()"/> 
        /// </summary>
        public Android.View.Translation.TranslationSpec TargetSpec
        {
            get { return IExecuteWithSignature<Android.View.Translation.TranslationSpec>("getTargetSpec", "()Landroid/view/translation/TranslationSpec;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#isUiTranslationEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUiTranslationEnabled()
        {
            return IExecuteWithSignature<bool>("isUiTranslationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationCapability.html#writeToParcel(android.os.Parcel,int)"/>
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