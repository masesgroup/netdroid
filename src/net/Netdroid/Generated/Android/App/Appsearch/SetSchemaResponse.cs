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

namespace Android.App.Appsearch
{
    #region SetSchemaResponse
    public partial class SetSchemaResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#getMigrationFailures()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Appsearch.SetSchemaResponse.MigrationFailure> GetMigrationFailures()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Appsearch.SetSchemaResponse.MigrationFailure>>("getMigrationFailures", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#getDeletedTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetDeletedTypes()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getDeletedTypes", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#getIncompatibleTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetIncompatibleTypes()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getIncompatibleTypes", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#getMigratedTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetMigratedTypes()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getMigratedTypes", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse"/></returns>
            public Android.App.Appsearch.SetSchemaResponse Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse>("build", "()Landroid/app/appsearch/SetSchemaResponse;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addDeletedType(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddDeletedType(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addDeletedType", "(Ljava/lang/String;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addDeletedTypes(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddDeletedTypes(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addDeletedTypes", "(Ljava/util/Collection;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addIncompatibleType(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddIncompatibleType(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addIncompatibleType", "(Ljava/lang/String;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addIncompatibleTypes(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddIncompatibleTypes(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addIncompatibleTypes", "(Ljava/util/Collection;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addMigratedType(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddMigratedType(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addMigratedType", "(Ljava/lang/String;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addMigratedTypes(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddMigratedTypes(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addMigratedTypes", "(Ljava/util/Collection;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addMigrationFailure(android.app.appsearch.SetSchemaResponse.MigrationFailure)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.SetSchemaResponse.MigrationFailure"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddMigrationFailure(Android.App.Appsearch.SetSchemaResponse.MigrationFailure arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addMigrationFailure", "(Landroid/app/appsearch/SetSchemaResponse$MigrationFailure;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.Builder.html#addMigrationFailures(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaResponse.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaResponse.Builder AddMigrationFailures(Java.Util.Collection<Android.App.Appsearch.SetSchemaResponse.MigrationFailure> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaResponse.Builder>("addMigrationFailures", "(Ljava/util/Collection;)Landroid/app/appsearch/SetSchemaResponse$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MigrationFailure
        public partial class MigrationFailure
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,android.app.appsearch.AppSearchResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Android.App.Appsearch.AppSearchResult"/></param>
            public MigrationFailure(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.App.Appsearch.AppSearchResult<object> arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#getAppSearchResult()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.AppSearchResult"/></returns>
            public Android.App.Appsearch.AppSearchResult<Java.Lang.Void> GetAppSearchResult()
            {
                return IExecuteWithSignature<Android.App.Appsearch.AppSearchResult<Java.Lang.Void>>("getAppSearchResult", "()Landroid/app/appsearch/AppSearchResult;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#getDocumentId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDocumentId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDocumentId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#getNamespace()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetNamespace()
            {
                return IExecuteWithSignature<Java.Lang.String>("getNamespace", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#getSchemaType()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetSchemaType()
            {
                return IExecuteWithSignature<Java.Lang.String>("getSchemaType", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaResponse.MigrationFailure.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
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