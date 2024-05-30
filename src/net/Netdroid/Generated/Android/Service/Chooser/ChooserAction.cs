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

namespace Android.Service.Chooser
{
    #region ChooserAction
    public partial class ChooserAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.html#getAction()"/> 
        /// </summary>
        public Android.App.PendingIntent Action
        {
            get { return IExecuteWithSignature<Android.App.PendingIntent>("getAction", "()Landroid/app/PendingIntent;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.html#getIcon()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Icon Icon
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.html#getLabel()"/> 
        /// </summary>
        public Java.Lang.CharSequence Label
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.Builder.html#%3Cinit%3E(android.graphics.drawable.Icon,java.lang.CharSequence,android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
            public Builder(Android.Graphics.Drawable.Icon arg0, Java.Lang.CharSequence arg1, Android.App.PendingIntent arg2)
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
            /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserAction.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Chooser.ChooserAction"/></returns>
            public Android.Service.Chooser.ChooserAction Build()
            {
                return IExecuteWithSignature<Android.Service.Chooser.ChooserAction>("build", "()Landroid/service/chooser/ChooserAction;");
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