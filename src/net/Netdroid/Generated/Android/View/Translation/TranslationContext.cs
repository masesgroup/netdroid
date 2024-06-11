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

namespace Android.View.Translation
{
    #region TranslationContext
    public partial class TranslationContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#FLAG_DEFINITIONS"/>
        /// </summary>
        public static int FLAG_DEFINITIONS { get { if (!_FLAG_DEFINITIONSReady) { _FLAG_DEFINITIONSContent = SGetField<int>(LocalBridgeClazz, "FLAG_DEFINITIONS"); _FLAG_DEFINITIONSReady = true; } return _FLAG_DEFINITIONSContent; } }
        private static int _FLAG_DEFINITIONSContent = default;
        private static bool _FLAG_DEFINITIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#FLAG_LOW_LATENCY"/>
        /// </summary>
        public static int FLAG_LOW_LATENCY { get { if (!_FLAG_LOW_LATENCYReady) { _FLAG_LOW_LATENCYContent = SGetField<int>(LocalBridgeClazz, "FLAG_LOW_LATENCY"); _FLAG_LOW_LATENCYReady = true; } return _FLAG_LOW_LATENCYContent; } }
        private static int _FLAG_LOW_LATENCYContent = default;
        private static bool _FLAG_LOW_LATENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#FLAG_TRANSLITERATION"/>
        /// </summary>
        public static int FLAG_TRANSLITERATION { get { if (!_FLAG_TRANSLITERATIONReady) { _FLAG_TRANSLITERATIONContent = SGetField<int>(LocalBridgeClazz, "FLAG_TRANSLITERATION"); _FLAG_TRANSLITERATIONReady = true; } return _FLAG_TRANSLITERATIONContent; } }
        private static int _FLAG_TRANSLITERATIONContent = default;
        private static bool _FLAG_TRANSLITERATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#getSourceSpec()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Translation.TranslationSpec"/></returns>
        public Android.View.Translation.TranslationSpec GetSourceSpec()
        {
            return IExecuteWithSignature<Android.View.Translation.TranslationSpec>("getSourceSpec", "()Landroid/view/translation/TranslationSpec;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#getTargetSpec()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Translation.TranslationSpec"/></returns>
        public Android.View.Translation.TranslationSpec GetTargetSpec()
        {
            return IExecuteWithSignature<Android.View.Translation.TranslationSpec>("getTargetSpec", "()Landroid/view/translation/TranslationSpec;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#getTranslationFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTranslationFlags()
        {
            return IExecuteWithSignature<int>("getTranslationFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.Builder.html#%3Cinit%3E(android.view.translation.TranslationSpec,android.view.translation.TranslationSpec)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Translation.TranslationSpec"/></param>
            /// <param name="arg1"><see cref="Android.View.Translation.TranslationSpec"/></param>
            public Builder(Android.View.Translation.TranslationSpec arg0, Android.View.Translation.TranslationSpec arg1)
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
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Translation.TranslationContext"/></returns>
            public Android.View.Translation.TranslationContext Build()
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationContext>("build", "()Landroid/view/translation/TranslationContext;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/translation/TranslationContext.Builder.html#setTranslationFlags(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Translation.TranslationContext.Builder"/></returns>
            public Android.View.Translation.TranslationContext.Builder SetTranslationFlags(int arg0)
            {
                return IExecuteWithSignature<Android.View.Translation.TranslationContext.Builder>("setTranslationFlags", "(I)Landroid/view/translation/TranslationContext$Builder;", arg0);
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