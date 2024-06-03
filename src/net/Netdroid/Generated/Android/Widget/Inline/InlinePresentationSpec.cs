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

namespace Android.Widget.Inline
{
    #region InlinePresentationSpec
    public partial class InlinePresentationSpec
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.html#getStyle()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetStyle()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getStyle", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.html#getMaxSize()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size GetMaxSize()
        {
            return IExecuteWithSignature<Android.Util.Size>("getMaxSize", "()Landroid/util/Size;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.html#getMinSize()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size GetMinSize()
        {
            return IExecuteWithSignature<Android.Util.Size>("getMinSize", "()Landroid/util/Size;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.Builder.html#%3Cinit%3E(android.util.Size,android.util.Size)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Size"/></param>
            /// <param name="arg1"><see cref="Android.Util.Size"/></param>
            public Builder(Android.Util.Size arg0, Android.Util.Size arg1)
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
            /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Widget.Inline.InlinePresentationSpec"/></returns>
            public Android.Widget.Inline.InlinePresentationSpec Build()
            {
                return IExecuteWithSignature<Android.Widget.Inline.InlinePresentationSpec>("build", "()Landroid/widget/inline/InlinePresentationSpec;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/inline/InlinePresentationSpec.Builder.html#setStyle(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Widget.Inline.InlinePresentationSpec.Builder"/></returns>
            public Android.Widget.Inline.InlinePresentationSpec.Builder SetStyle(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Widget.Inline.InlinePresentationSpec.Builder>("setStyle", "(Landroid/os/Bundle;)Landroid/widget/inline/InlinePresentationSpec$Builder;", arg0);
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