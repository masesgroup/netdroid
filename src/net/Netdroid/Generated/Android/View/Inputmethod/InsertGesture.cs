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

namespace Android.View.Inputmethod
{
    #region InsertGesture
    public partial class InsertGesture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.View.Inputmethod.InsertGesture"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.View.Inputmethod.InsertGesture t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.html#getInsertionPoint()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PointF"/></returns>
        public Android.Graphics.PointF GetInsertionPoint()
        {
            return IExecuteWithSignature<Android.Graphics.PointF>("getInsertionPoint", "()Landroid/graphics/PointF;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.html#getTextToInsert()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTextToInsert()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTextToInsert", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Inputmethod.InsertGesture"/></returns>
            public Android.View.Inputmethod.InsertGesture Build()
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertGesture>("build", "()Landroid/view/inputmethod/InsertGesture;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.Builder.html#setFallbackText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.InsertGesture.Builder"/></returns>
            public Android.View.Inputmethod.InsertGesture.Builder SetFallbackText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertGesture.Builder>("setFallbackText", "(Ljava/lang/String;)Landroid/view/inputmethod/InsertGesture$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.Builder.html#setInsertionPoint(android.graphics.PointF)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.PointF"/></param>
            /// <returns><see cref="Android.View.Inputmethod.InsertGesture.Builder"/></returns>
            public Android.View.Inputmethod.InsertGesture.Builder SetInsertionPoint(Android.Graphics.PointF arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertGesture.Builder>("setInsertionPoint", "(Landroid/graphics/PointF;)Landroid/view/inputmethod/InsertGesture$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertGesture.Builder.html#setTextToInsert(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.InsertGesture.Builder"/></returns>
            public Android.View.Inputmethod.InsertGesture.Builder SetTextToInsert(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertGesture.Builder>("setTextToInsert", "(Ljava/lang/String;)Landroid/view/inputmethod/InsertGesture$Builder;", arg0);
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