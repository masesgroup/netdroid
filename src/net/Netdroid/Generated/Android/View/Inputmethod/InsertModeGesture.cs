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
    #region InsertModeGesture
    public partial class InsertModeGesture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.View.Inputmethod.InsertModeGesture"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.View.Inputmethod.InsertModeGesture t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.html#getCancellationSignal()"/> 
        /// </summary>
        public Android.Os.CancellationSignal CancellationSignal
        {
            get { return IExecuteWithSignature<Android.Os.CancellationSignal>("getCancellationSignal", "()Landroid/os/CancellationSignal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.html#getInsertionPoint()"/> 
        /// </summary>
        public Android.Graphics.PointF InsertionPoint
        {
            get { return IExecuteWithSignature<Android.Graphics.PointF>("getInsertionPoint", "()Landroid/graphics/PointF;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Inputmethod.InsertModeGesture"/></returns>
            public Android.View.Inputmethod.InsertModeGesture Build()
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertModeGesture>("build", "()Landroid/view/inputmethod/InsertModeGesture;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.Builder.html#setCancellationSignal(android.os.CancellationSignal)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.CancellationSignal"/></param>
            /// <returns><see cref="Android.View.Inputmethod.InsertModeGesture.Builder"/></returns>
            public Android.View.Inputmethod.InsertModeGesture.Builder SetCancellationSignal(Android.Os.CancellationSignal arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertModeGesture.Builder>("setCancellationSignal", "(Landroid/os/CancellationSignal;)Landroid/view/inputmethod/InsertModeGesture$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.Builder.html#setFallbackText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.InsertModeGesture.Builder"/></returns>
            public Android.View.Inputmethod.InsertModeGesture.Builder SetFallbackText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertModeGesture.Builder>("setFallbackText", "(Ljava/lang/String;)Landroid/view/inputmethod/InsertModeGesture$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InsertModeGesture.Builder.html#setInsertionPoint(android.graphics.PointF)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.PointF"/></param>
            /// <returns><see cref="Android.View.Inputmethod.InsertModeGesture.Builder"/></returns>
            public Android.View.Inputmethod.InsertModeGesture.Builder SetInsertionPoint(Android.Graphics.PointF arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.InsertModeGesture.Builder>("setInsertionPoint", "(Landroid/graphics/PointF;)Landroid/view/inputmethod/InsertModeGesture$Builder;", arg0);
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