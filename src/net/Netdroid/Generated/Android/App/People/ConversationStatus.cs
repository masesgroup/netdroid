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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.People
{
    #region ConversationStatus
    public partial class ConversationStatus
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_ANNIVERSARY"/>
        /// </summary>
        public static int ACTIVITY_ANNIVERSARY { get { if (!_ACTIVITY_ANNIVERSARYReady) { _ACTIVITY_ANNIVERSARYContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_ANNIVERSARY"); _ACTIVITY_ANNIVERSARYReady = true; } return _ACTIVITY_ANNIVERSARYContent; } }
        private static int _ACTIVITY_ANNIVERSARYContent = default;
        private static bool _ACTIVITY_ANNIVERSARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_AUDIO"/>
        /// </summary>
        public static int ACTIVITY_AUDIO { get { if (!_ACTIVITY_AUDIOReady) { _ACTIVITY_AUDIOContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_AUDIO"); _ACTIVITY_AUDIOReady = true; } return _ACTIVITY_AUDIOContent; } }
        private static int _ACTIVITY_AUDIOContent = default;
        private static bool _ACTIVITY_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_BIRTHDAY"/>
        /// </summary>
        public static int ACTIVITY_BIRTHDAY { get { if (!_ACTIVITY_BIRTHDAYReady) { _ACTIVITY_BIRTHDAYContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_BIRTHDAY"); _ACTIVITY_BIRTHDAYReady = true; } return _ACTIVITY_BIRTHDAYContent; } }
        private static int _ACTIVITY_BIRTHDAYContent = default;
        private static bool _ACTIVITY_BIRTHDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_GAME"/>
        /// </summary>
        public static int ACTIVITY_GAME { get { if (!_ACTIVITY_GAMEReady) { _ACTIVITY_GAMEContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_GAME"); _ACTIVITY_GAMEReady = true; } return _ACTIVITY_GAMEContent; } }
        private static int _ACTIVITY_GAMEContent = default;
        private static bool _ACTIVITY_GAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_LOCATION"/>
        /// </summary>
        public static int ACTIVITY_LOCATION { get { if (!_ACTIVITY_LOCATIONReady) { _ACTIVITY_LOCATIONContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_LOCATION"); _ACTIVITY_LOCATIONReady = true; } return _ACTIVITY_LOCATIONContent; } }
        private static int _ACTIVITY_LOCATIONContent = default;
        private static bool _ACTIVITY_LOCATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_NEW_STORY"/>
        /// </summary>
        public static int ACTIVITY_NEW_STORY { get { if (!_ACTIVITY_NEW_STORYReady) { _ACTIVITY_NEW_STORYContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_NEW_STORY"); _ACTIVITY_NEW_STORYReady = true; } return _ACTIVITY_NEW_STORYContent; } }
        private static int _ACTIVITY_NEW_STORYContent = default;
        private static bool _ACTIVITY_NEW_STORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_OTHER"/>
        /// </summary>
        public static int ACTIVITY_OTHER { get { if (!_ACTIVITY_OTHERReady) { _ACTIVITY_OTHERContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_OTHER"); _ACTIVITY_OTHERReady = true; } return _ACTIVITY_OTHERContent; } }
        private static int _ACTIVITY_OTHERContent = default;
        private static bool _ACTIVITY_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_UPCOMING_BIRTHDAY"/>
        /// </summary>
        public static int ACTIVITY_UPCOMING_BIRTHDAY { get { if (!_ACTIVITY_UPCOMING_BIRTHDAYReady) { _ACTIVITY_UPCOMING_BIRTHDAYContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_UPCOMING_BIRTHDAY"); _ACTIVITY_UPCOMING_BIRTHDAYReady = true; } return _ACTIVITY_UPCOMING_BIRTHDAYContent; } }
        private static int _ACTIVITY_UPCOMING_BIRTHDAYContent = default;
        private static bool _ACTIVITY_UPCOMING_BIRTHDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#ACTIVITY_VIDEO"/>
        /// </summary>
        public static int ACTIVITY_VIDEO { get { if (!_ACTIVITY_VIDEOReady) { _ACTIVITY_VIDEOContent = SGetField<int>(LocalBridgeClazz, "ACTIVITY_VIDEO"); _ACTIVITY_VIDEOReady = true; } return _ACTIVITY_VIDEOContent; } }
        private static int _ACTIVITY_VIDEOContent = default;
        private static bool _ACTIVITY_VIDEOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#AVAILABILITY_AVAILABLE"/>
        /// </summary>
        public static int AVAILABILITY_AVAILABLE { get { if (!_AVAILABILITY_AVAILABLEReady) { _AVAILABILITY_AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "AVAILABILITY_AVAILABLE"); _AVAILABILITY_AVAILABLEReady = true; } return _AVAILABILITY_AVAILABLEContent; } }
        private static int _AVAILABILITY_AVAILABLEContent = default;
        private static bool _AVAILABILITY_AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#AVAILABILITY_BUSY"/>
        /// </summary>
        public static int AVAILABILITY_BUSY { get { if (!_AVAILABILITY_BUSYReady) { _AVAILABILITY_BUSYContent = SGetField<int>(LocalBridgeClazz, "AVAILABILITY_BUSY"); _AVAILABILITY_BUSYReady = true; } return _AVAILABILITY_BUSYContent; } }
        private static int _AVAILABILITY_BUSYContent = default;
        private static bool _AVAILABILITY_BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#AVAILABILITY_OFFLINE"/>
        /// </summary>
        public static int AVAILABILITY_OFFLINE { get { if (!_AVAILABILITY_OFFLINEReady) { _AVAILABILITY_OFFLINEContent = SGetField<int>(LocalBridgeClazz, "AVAILABILITY_OFFLINE"); _AVAILABILITY_OFFLINEReady = true; } return _AVAILABILITY_OFFLINEContent; } }
        private static int _AVAILABILITY_OFFLINEContent = default;
        private static bool _AVAILABILITY_OFFLINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#AVAILABILITY_UNKNOWN"/>
        /// </summary>
        public static int AVAILABILITY_UNKNOWN { get { if (!_AVAILABILITY_UNKNOWNReady) { _AVAILABILITY_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "AVAILABILITY_UNKNOWN"); _AVAILABILITY_UNKNOWNReady = true; } return _AVAILABILITY_UNKNOWNContent; } }
        private static int _AVAILABILITY_UNKNOWNContent = default;
        private static bool _AVAILABILITY_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getActivity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetActivity()
        {
            return IExecuteWithSignature<int>("getActivity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getAvailability()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAvailability()
        {
            return IExecuteWithSignature<int>("getAvailability", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getEndTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetEndTimeMillis()
        {
            return IExecuteWithSignature<long>("getEndTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#getStartTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartTimeMillis()
        {
            return IExecuteWithSignature<long>("getStartTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#%3Cinit%3E(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(Java.Lang.String arg0, int arg1)
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
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.People.ConversationStatus"/></returns>
            public Android.App.People.ConversationStatus Build()
            {
                return IExecuteWithSignature<Android.App.People.ConversationStatus>("build", "()Landroid/app/people/ConversationStatus;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#setAvailability(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.People.ConversationStatus.Builder"/></returns>
            public Android.App.People.ConversationStatus.Builder SetAvailability(int arg0)
            {
                return IExecuteWithSignature<Android.App.People.ConversationStatus.Builder>("setAvailability", "(I)Landroid/app/people/ConversationStatus$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#setDescription(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.App.People.ConversationStatus.Builder"/></returns>
            public Android.App.People.ConversationStatus.Builder SetDescription(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.App.People.ConversationStatus.Builder>("setDescription", "(Ljava/lang/CharSequence;)Landroid/app/people/ConversationStatus$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#setEndTimeMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.App.People.ConversationStatus.Builder"/></returns>
            public Android.App.People.ConversationStatus.Builder SetEndTimeMillis(long arg0)
            {
                return IExecuteWithSignature<Android.App.People.ConversationStatus.Builder>("setEndTimeMillis", "(J)Landroid/app/people/ConversationStatus$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#setIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.App.People.ConversationStatus.Builder"/></returns>
            public Android.App.People.ConversationStatus.Builder SetIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.App.People.ConversationStatus.Builder>("setIcon", "(Landroid/graphics/drawable/Icon;)Landroid/app/people/ConversationStatus$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/people/ConversationStatus.Builder.html#setStartTimeMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.App.People.ConversationStatus.Builder"/></returns>
            public Android.App.People.ConversationStatus.Builder SetStartTimeMillis(long arg0)
            {
                return IExecuteWithSignature<Android.App.People.ConversationStatus.Builder>("setStartTimeMillis", "(J)Landroid/app/people/ConversationStatus$Builder;", arg0);
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