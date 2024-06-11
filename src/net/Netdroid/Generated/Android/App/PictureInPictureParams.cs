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

namespace Android.App
{
    #region PictureInPictureParams
    public partial class PictureInPictureParams
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getCloseAction()"/>
        /// </summary>
        /// <returns><see cref="Android.App.RemoteAction"/></returns>
        public Android.App.RemoteAction GetCloseAction()
        {
            return IExecuteWithSignature<Android.App.RemoteAction>("getCloseAction", "()Landroid/app/RemoteAction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getSourceRectHint()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetSourceRectHint()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getSourceRectHint", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getAspectRatio()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.Rational"/></returns>
        public Android.Util.Rational GetAspectRatio()
        {
            return IExecuteWithSignature<Android.Util.Rational>("getAspectRatio", "()Landroid/util/Rational;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getExpandedAspectRatio()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.Rational"/></returns>
        public Android.Util.Rational GetExpandedAspectRatio()
        {
            return IExecuteWithSignature<Android.Util.Rational>("getExpandedAspectRatio", "()Landroid/util/Rational;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#isAutoEnterEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAutoEnterEnabled()
        {
            return IExecuteWithSignature<bool>("isAutoEnterEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#isSeamlessResizeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSeamlessResizeEnabled()
        {
            return IExecuteWithSignature<bool>("isSeamlessResizeEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getSubtitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSubtitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSubtitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#getActions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.RemoteAction> GetActions()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.RemoteAction>>("getActions", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#%3Cinit%3E(android.app.PictureInPictureParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.PictureInPictureParams"/></param>
            public Builder(Android.App.PictureInPictureParams arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.PictureInPictureParams"/></returns>
            public Android.App.PictureInPictureParams Build()
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams>("build", "()Landroid/app/PictureInPictureParams;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setActions(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetActions(Java.Util.List<Android.App.RemoteAction> arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setActions", "(Ljava/util/List;)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setAspectRatio(android.util.Rational)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Rational"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetAspectRatio(Android.Util.Rational arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setAspectRatio", "(Landroid/util/Rational;)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setAutoEnterEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetAutoEnterEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setAutoEnterEnabled", "(Z)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setCloseAction(android.app.RemoteAction)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.RemoteAction"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetCloseAction(Android.App.RemoteAction arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setCloseAction", "(Landroid/app/RemoteAction;)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setExpandedAspectRatio(android.util.Rational)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Rational"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetExpandedAspectRatio(Android.Util.Rational arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setExpandedAspectRatio", "(Landroid/util/Rational;)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setSeamlessResizeEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetSeamlessResizeEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setSeamlessResizeEnabled", "(Z)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setSourceRectHint(android.graphics.Rect)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetSourceRectHint(Android.Graphics.Rect arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setSourceRectHint", "(Landroid/graphics/Rect;)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setSubtitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetSubtitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setSubtitle", "(Ljava/lang/CharSequence;)Landroid/app/PictureInPictureParams$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/PictureInPictureParams.Builder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.App.PictureInPictureParams.Builder"/></returns>
            public Android.App.PictureInPictureParams.Builder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.App.PictureInPictureParams.Builder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/app/PictureInPictureParams$Builder;", arg0);
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