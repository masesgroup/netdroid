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

namespace Android.App
{
    #region Person
    public partial class Person
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#toBuilder()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Person.Builder"/></returns>
        public Android.App.Person.Builder ToBuilder()
        {
            return IExecuteWithSignature<Android.App.Person.Builder>("toBuilder", "()Landroid/app/Person$Builder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#getIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#isBot()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBot()
        {
            return IExecuteWithSignature<bool>("isBot", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#isImportant()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsImportant()
        {
            return IExecuteWithSignature<bool>("isImportant", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#getKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetKey()
        {
            return IExecuteWithSignature<Java.Lang.String>("getKey", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#getUri()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUri()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUri", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Person.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Person"/></returns>
            public Android.App.Person Build()
            {
                return IExecuteWithSignature<Android.App.Person>("build", "()Landroid/app/Person;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#setBot(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Person.Builder"/></returns>
            public Android.App.Person.Builder SetBot(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Person.Builder>("setBot", "(Z)Landroid/app/Person$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#setIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.App.Person.Builder"/></returns>
            public Android.App.Person.Builder SetIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.App.Person.Builder>("setIcon", "(Landroid/graphics/drawable/Icon;)Landroid/app/Person$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#setImportant(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Person.Builder"/></returns>
            public Android.App.Person.Builder SetImportant(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Person.Builder>("setImportant", "(Z)Landroid/app/Person$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#setKey(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Person.Builder"/></returns>
            public Android.App.Person.Builder SetKey(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Person.Builder>("setKey", "(Ljava/lang/String;)Landroid/app/Person$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#setName(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.App.Person.Builder"/></returns>
            public Android.App.Person.Builder SetName(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.App.Person.Builder>("setName", "(Ljava/lang/CharSequence;)Landroid/app/Person$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/Person.Builder.html#setUri(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Person.Builder"/></returns>
            public Android.App.Person.Builder SetUri(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Person.Builder>("setUri", "(Ljava/lang/String;)Landroid/app/Person$Builder;", arg0);
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