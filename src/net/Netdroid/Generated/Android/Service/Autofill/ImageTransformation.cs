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

namespace Android.Service.Autofill
{
    #region ImageTransformation
    public partial class ImageTransformation : Android.Service.Autofill.ITransformation, Android.Os.IParcelable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Service.Autofill.ImageTransformation"/> to <see cref="Android.Service.Autofill.Transformation"/>
        /// </summary>
        public static implicit operator Android.Service.Autofill.Transformation(Android.Service.Autofill.ImageTransformation t) => t.Cast<Android.Service.Autofill.Transformation>();
        /// <summary>
        /// Converter from <see cref="Android.Service.Autofill.ImageTransformation"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Service.Autofill.ImageTransformation t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.Builder.html#%3Cinit%3E(android.view.autofill.AutofillId,java.util.regex.Pattern,int,java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Java.Lang.CharSequence"/></param>
            public Builder(Android.View.Autofill.AutofillId arg0, Java.Util.Regex.Pattern arg1, int arg2, Java.Lang.CharSequence arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.Builder.html#%3Cinit%3E(android.view.autofill.AutofillId,java.util.regex.Pattern,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Autofill.AutofillId"/></param>
            /// <param name="arg1"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            [global::System.Obsolete()]
            public Builder(Android.View.Autofill.AutofillId arg0, Java.Util.Regex.Pattern arg1, int arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.ImageTransformation"/></returns>
            public Android.Service.Autofill.ImageTransformation Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.ImageTransformation>("build", "()Landroid/service/autofill/ImageTransformation;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.Builder.html#addOption(java.util.regex.Pattern,int,java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Autofill.ImageTransformation.Builder"/></returns>
            public Android.Service.Autofill.ImageTransformation.Builder AddOption(Java.Util.Regex.Pattern arg0, int arg1, Java.Lang.CharSequence arg2)
            {
                return IExecute<Android.Service.Autofill.ImageTransformation.Builder>("addOption", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/ImageTransformation.Builder.html#addOption(java.util.regex.Pattern,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Autofill.ImageTransformation.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Service.Autofill.ImageTransformation.Builder AddOption(Java.Util.Regex.Pattern arg0, int arg1)
            {
                return IExecute<Android.Service.Autofill.ImageTransformation.Builder>("addOption", arg0, arg1);
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