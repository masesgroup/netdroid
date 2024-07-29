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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Quickaccesswallet
{
    #region WalletCard
    public partial class WalletCard
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#CARD_TYPE_NON_PAYMENT"/>
        /// </summary>
        public static int CARD_TYPE_NON_PAYMENT { get { if (!_CARD_TYPE_NON_PAYMENTReady) { _CARD_TYPE_NON_PAYMENTContent = SGetField<int>(LocalBridgeClazz, "CARD_TYPE_NON_PAYMENT"); _CARD_TYPE_NON_PAYMENTReady = true; } return _CARD_TYPE_NON_PAYMENTContent; } }
        private static int _CARD_TYPE_NON_PAYMENTContent = default;
        private static bool _CARD_TYPE_NON_PAYMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#CARD_TYPE_PAYMENT"/>
        /// </summary>
        public static int CARD_TYPE_PAYMENT { get { if (!_CARD_TYPE_PAYMENTReady) { _CARD_TYPE_PAYMENTContent = SGetField<int>(LocalBridgeClazz, "CARD_TYPE_PAYMENT"); _CARD_TYPE_PAYMENTReady = true; } return _CARD_TYPE_PAYMENTContent; } }
        private static int _CARD_TYPE_PAYMENTContent = default;
        private static bool _CARD_TYPE_PAYMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#CARD_TYPE_UNKNOWN"/>
        /// </summary>
        public static int CARD_TYPE_UNKNOWN { get { if (!_CARD_TYPE_UNKNOWNReady) { _CARD_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CARD_TYPE_UNKNOWN"); _CARD_TYPE_UNKNOWNReady = true; } return _CARD_TYPE_UNKNOWNContent; } }
        private static int _CARD_TYPE_UNKNOWNContent = default;
        private static bool _CARD_TYPE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getPendingIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        public Android.App.PendingIntent GetPendingIntent()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getPendingIntent", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getCardIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetCardIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getCardIcon", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getCardImage()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetCardImage()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getCardImage", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getNonPaymentCardSecondaryImage()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetNonPaymentCardSecondaryImage()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getNonPaymentCardSecondaryImage", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getCardType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCardType()
        {
            return IExecuteWithSignature<int>("getCardType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getCardLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCardLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCardLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getContentDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetContentDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getCardId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCardId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCardId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#getCardLocations()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Location.Location> GetCardLocations()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Location.Location>>("getCardLocations", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#%3Cinit%3E(java.lang.String,android.graphics.drawable.Icon,java.lang.CharSequence,android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg3"><see cref="Android.App.PendingIntent"/></param>
            public Builder(Java.Lang.String arg0, Android.Graphics.Drawable.Icon arg1, Java.Lang.CharSequence arg2, Android.App.PendingIntent arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#%3Cinit%3E(java.lang.String,int,android.graphics.drawable.Icon,java.lang.CharSequence,android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <param name="arg3"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg4"><see cref="Android.App.PendingIntent"/></param>
            public Builder(Java.Lang.String arg0, int arg1, Android.Graphics.Drawable.Icon arg2, Java.Lang.CharSequence arg3, Android.App.PendingIntent arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
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
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Quickaccesswallet.WalletCard"/></returns>
            public Android.Service.Quickaccesswallet.WalletCard Build()
            {
                return IExecuteWithSignature<Android.Service.Quickaccesswallet.WalletCard>("build", "()Landroid/service/quickaccesswallet/WalletCard;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#setCardIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.Service.Quickaccesswallet.WalletCard.Builder"/></returns>
            public Android.Service.Quickaccesswallet.WalletCard.Builder SetCardIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.Service.Quickaccesswallet.WalletCard.Builder>("setCardIcon", "(Landroid/graphics/drawable/Icon;)Landroid/service/quickaccesswallet/WalletCard$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#setCardLabel(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Quickaccesswallet.WalletCard.Builder"/></returns>
            public Android.Service.Quickaccesswallet.WalletCard.Builder SetCardLabel(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Quickaccesswallet.WalletCard.Builder>("setCardLabel", "(Ljava/lang/CharSequence;)Landroid/service/quickaccesswallet/WalletCard$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#setCardLocations(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Service.Quickaccesswallet.WalletCard.Builder"/></returns>
            public Android.Service.Quickaccesswallet.WalletCard.Builder SetCardLocations(Java.Util.List<Android.Location.Location> arg0)
            {
                return IExecuteWithSignature<Android.Service.Quickaccesswallet.WalletCard.Builder>("setCardLocations", "(Ljava/util/List;)Landroid/service/quickaccesswallet/WalletCard$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/quickaccesswallet/WalletCard.Builder.html#setNonPaymentCardSecondaryImage(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.Service.Quickaccesswallet.WalletCard.Builder"/></returns>
            public Android.Service.Quickaccesswallet.WalletCard.Builder SetNonPaymentCardSecondaryImage(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.Service.Quickaccesswallet.WalletCard.Builder>("setNonPaymentCardSecondaryImage", "(Landroid/graphics/drawable/Icon;)Landroid/service/quickaccesswallet/WalletCard$Builder;", arg0);
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