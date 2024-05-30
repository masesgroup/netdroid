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
    #region TextClassification
    public partial class TextClassification
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getActions()"/> 
        /// </summary>
        public Java.Util.List<Android.App.RemoteAction> Actions
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.App.RemoteAction>>("getActions", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getEntityCount()"/> 
        /// </summary>
        public int EntityCount
        {
            get { return IExecuteWithSignature<int>("getEntityCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getExtras()"/> 
        /// </summary>
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getId()"/> 
        /// </summary>
        public Java.Lang.String Id
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getText()"/> 
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getConfidenceScore(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetConfidenceScore(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<float>("getConfidenceScore", "(Ljava/lang/String;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#getEntity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEntity(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getEntity", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Textclassifier.TextClassification"/></returns>
            public Android.View.Textclassifier.TextClassification Build()
            {
                return IExecute<Android.View.Textclassifier.TextClassification>("build");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Builder.html#addAction(android.app.RemoteAction)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.RemoteAction"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassification.Builder"/></returns>
            public Android.View.Textclassifier.TextClassification.Builder AddAction(Android.App.RemoteAction arg0)
            {
                return IExecute<Android.View.Textclassifier.TextClassification.Builder>("addAction", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Builder.html#setEntityType(java.lang.String,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassification.Builder"/></returns>
            public Android.View.Textclassifier.TextClassification.Builder SetEntityType(Java.Lang.String arg0, float arg1)
            {
                return IExecute<Android.View.Textclassifier.TextClassification.Builder>("setEntityType", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassification.Builder"/></returns>
            public Android.View.Textclassifier.TextClassification.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecute<Android.View.Textclassifier.TextClassification.Builder>("setExtras", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Builder.html#setId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassification.Builder"/></returns>
            public Android.View.Textclassifier.TextClassification.Builder SetId(Java.Lang.String arg0)
            {
                return IExecute<Android.View.Textclassifier.TextClassification.Builder>("setId", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Builder.html#setText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextClassification.Builder"/></returns>
            public Android.View.Textclassifier.TextClassification.Builder SetText(Java.Lang.String arg0)
            {
                return IExecute<Android.View.Textclassifier.TextClassification.Builder>("setText", arg0);
            }

            #endregion

            #region Nested classes

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
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getCallingPackageName()"/> 
            /// </summary>
            public Java.Lang.String CallingPackageName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getCallingPackageName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getDefaultLocales()"/> 
            /// </summary>
            public Android.Os.LocaleList DefaultLocales
            {
                get { return IExecuteWithSignature<Android.Os.LocaleList>("getDefaultLocales", "()Landroid/os/LocaleList;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getEndIndex()"/> 
            /// </summary>
            public int EndIndex
            {
                get { return IExecuteWithSignature<int>("getEndIndex", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getExtras()"/> 
            /// </summary>
            public Android.Os.Bundle Extras
            {
                get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getReferenceTime()"/> 
            /// </summary>
            public Java.Time.ZonedDateTime ReferenceTime
            {
                get { return IExecuteWithSignature<Java.Time.ZonedDateTime>("getReferenceTime", "()Ljava/time/ZonedDateTime;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getStartIndex()"/> 
            /// </summary>
            public int StartIndex
            {
                get { return IExecuteWithSignature<int>("getStartIndex", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#getText()"/> 
            /// </summary>
            public Java.Lang.CharSequence Text
            {
                get { return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "()Ljava/lang/CharSequence;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.html#writeToParcel(android.os.Parcel,int)"/>
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.Builder.html#%3Cinit%3E(java.lang.CharSequence,int,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                /// <param name="arg2"><see cref="int"/></param>
                public Builder(Java.Lang.CharSequence arg0, int arg1, int arg2)
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.Textclassifier.TextClassification.Request"/></returns>
                public Android.View.Textclassifier.TextClassification.Request Build()
                {
                    return IExecute<Android.View.Textclassifier.TextClassification.Request>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.Builder.html#setDefaultLocales(android.os.LocaleList)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.LocaleList"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassification.Request.Builder"/></returns>
                public Android.View.Textclassifier.TextClassification.Request.Builder SetDefaultLocales(Android.Os.LocaleList arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassification.Request.Builder>("setDefaultLocales", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.Builder.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassification.Request.Builder"/></returns>
                public Android.View.Textclassifier.TextClassification.Request.Builder SetExtras(Android.Os.Bundle arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassification.Request.Builder>("setExtras", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextClassification.Request.Builder.html#setReferenceTime(java.time.ZonedDateTime)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Time.ZonedDateTime"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextClassification.Request.Builder"/></returns>
                public Android.View.Textclassifier.TextClassification.Request.Builder SetReferenceTime(Java.Time.ZonedDateTime arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextClassification.Request.Builder>("setReferenceTime", arg0);
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