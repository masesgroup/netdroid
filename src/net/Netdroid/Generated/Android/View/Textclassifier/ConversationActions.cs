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

namespace Android.View.Textclassifier
{
    #region ConversationActions
    public partial class ConversationActions
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.html#%3Cinit%3E(java.util.List,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ConversationActions(Java.Util.List<Android.View.Textclassifier.ConversationAction> arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.html#getConversationActions()"/> 
        /// </summary>
        public Java.Util.List<Android.View.Textclassifier.ConversationAction> GetConversationActions
        {
            get { return IExecute<Java.Util.List<Android.View.Textclassifier.ConversationAction>>("getConversationActions"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Message
        public partial class Message
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#PERSON_USER_OTHERS"/>
            /// </summary>
            public static Android.App.Person PERSON_USER_OTHERS { get { if (!_PERSON_USER_OTHERSReady) { _PERSON_USER_OTHERSContent = SGetField<Android.App.Person>(LocalBridgeClazz, "PERSON_USER_OTHERS"); _PERSON_USER_OTHERSReady = true; } return _PERSON_USER_OTHERSContent; } }
            private static Android.App.Person _PERSON_USER_OTHERSContent = default;
            private static bool _PERSON_USER_OTHERSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#PERSON_USER_SELF"/>
            /// </summary>
            public static Android.App.Person PERSON_USER_SELF { get { if (!_PERSON_USER_SELFReady) { _PERSON_USER_SELFContent = SGetField<Android.App.Person>(LocalBridgeClazz, "PERSON_USER_SELF"); _PERSON_USER_SELFReady = true; } return _PERSON_USER_SELFContent; } }
            private static Android.App.Person _PERSON_USER_SELFContent = default;
            private static bool _PERSON_USER_SELFReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#getAuthor()"/> 
            /// </summary>
            public Android.App.Person Author
            {
                get { return IExecuteWithSignature<Android.App.Person>("getAuthor", "()Landroid/app/Person;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#getExtras()"/> 
            /// </summary>
            public Android.Os.Bundle Extras
            {
                get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#getReferenceTime()"/> 
            /// </summary>
            public Java.Time.ZonedDateTime ReferenceTime
            {
                get { return IExecuteWithSignature<Java.Time.ZonedDateTime>("getReferenceTime", "()Ljava/time/ZonedDateTime;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#getText()"/> 
            /// </summary>
            public Java.Lang.CharSequence Text
            {
                get { return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "()Ljava/lang/CharSequence;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.html#writeToParcel(android.os.Parcel,int)"/>
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.Builder.html#%3Cinit%3E(android.app.Person)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.App.Person"/></param>
                public Builder(Android.App.Person arg0)
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Message"/></returns>
                public Android.View.Textclassifier.ConversationActions.Message Build()
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Message>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.Builder.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Message.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Message.Builder SetExtras(Android.Os.Bundle arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Message.Builder>("setExtras", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.Builder.html#setReferenceTime(java.time.ZonedDateTime)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Time.ZonedDateTime"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Message.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Message.Builder SetReferenceTime(Java.Time.ZonedDateTime arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Message.Builder>("setReferenceTime", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Message.Builder.html#setText(java.lang.CharSequence)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Message.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Message.Builder SetText(Java.Lang.CharSequence arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Message.Builder>("setText", arg0);
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

        #region Request
        public partial class Request
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#HINT_FOR_IN_APP"/>
            /// </summary>
            public static Java.Lang.String HINT_FOR_IN_APP { get { if (!_HINT_FOR_IN_APPReady) { _HINT_FOR_IN_APPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_FOR_IN_APP"); _HINT_FOR_IN_APPReady = true; } return _HINT_FOR_IN_APPContent; } }
            private static Java.Lang.String _HINT_FOR_IN_APPContent = default;
            private static bool _HINT_FOR_IN_APPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#HINT_FOR_NOTIFICATION"/>
            /// </summary>
            public static Java.Lang.String HINT_FOR_NOTIFICATION { get { if (!_HINT_FOR_NOTIFICATIONReady) { _HINT_FOR_NOTIFICATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_FOR_NOTIFICATION"); _HINT_FOR_NOTIFICATIONReady = true; } return _HINT_FOR_NOTIFICATIONContent; } }
            private static Java.Lang.String _HINT_FOR_NOTIFICATIONContent = default;
            private static bool _HINT_FOR_NOTIFICATIONReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#getCallingPackageName()"/> 
            /// </summary>
            public Java.Lang.String CallingPackageName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getCallingPackageName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#getConversation()"/> 
            /// </summary>
            public Java.Util.List<Android.View.Textclassifier.ConversationActions.Message> Conversation
            {
                get { return IExecute<Java.Util.List<Android.View.Textclassifier.ConversationActions.Message>>("getConversation"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#getExtras()"/> 
            /// </summary>
            public Android.Os.Bundle Extras
            {
                get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#getHints()"/> 
            /// </summary>
            public Java.Util.List<Java.Lang.String> Hints
            {
                get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getHints", "()Ljava/util/List;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#getMaxSuggestions()"/> 
            /// </summary>
            public int MaxSuggestions
            {
                get { return IExecuteWithSignature<int>("getMaxSuggestions", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#getTypeConfig()"/> 
            /// </summary>
            public Android.View.Textclassifier.TextClassifier.EntityConfig TypeConfig
            {
                get { return IExecute<Android.View.Textclassifier.TextClassifier.EntityConfig>("getTypeConfig"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.html#writeToParcel(android.os.Parcel,int)"/>
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.Builder.html#%3Cinit%3E(java.util.List)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Util.List"/></param>
                public Builder(Java.Util.List<Android.View.Textclassifier.ConversationActions.Message> arg0)
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Request"/></returns>
                public Android.View.Textclassifier.ConversationActions.Request Build()
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Request>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.Builder.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Request.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Request.Builder SetExtras(Android.Os.Bundle arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Request.Builder>("setExtras", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.Builder.html#setHints(java.util.List)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Util.List"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Request.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Request.Builder SetHints(Java.Util.List<Java.Lang.String> arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Request.Builder>("setHints", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.Builder.html#setMaxSuggestions(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Request.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Request.Builder SetMaxSuggestions(int arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Request.Builder>("setMaxSuggestions", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationActions.Request.Builder.html#setTypeConfig(android.view.textclassifier.TextClassifier.EntityConfig)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.View.Textclassifier.TextClassifier.EntityConfig"/></param>
                /// <returns><see cref="Android.View.Textclassifier.ConversationActions.Request.Builder"/></returns>
                public Android.View.Textclassifier.ConversationActions.Request.Builder SetTypeConfig(Android.View.Textclassifier.TextClassifier.EntityConfig arg0)
                {
                    return IExecute<Android.View.Textclassifier.ConversationActions.Request.Builder>("setTypeConfig", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}