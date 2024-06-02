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

namespace Android.App.Appsearch
{
    #region AppSearchSchema
    public partial class AppSearchSchema
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.html#getSchemaType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSchemaType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSchemaType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Appsearch.AppSearchSchema.PropertyConfig> GetProperties()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Appsearch.AppSearchSchema.PropertyConfig>>("getProperties", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region BooleanPropertyConfig
        public partial class BooleanPropertyConfig
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

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.BooleanPropertyConfig.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.BooleanPropertyConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.BooleanPropertyConfig"/></returns>
                public Android.App.Appsearch.AppSearchSchema.BooleanPropertyConfig Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.BooleanPropertyConfig>("build", "()Landroid/app/appsearch/AppSearchSchema$BooleanPropertyConfig;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.BooleanPropertyConfig.Builder.html#setCardinality(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.BooleanPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.BooleanPropertyConfig.Builder SetCardinality(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.BooleanPropertyConfig.Builder>("setCardinality", "(I)Landroid/app/appsearch/AppSearchSchema$BooleanPropertyConfig$Builder;", arg0);
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

        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.AppSearchSchema"/></returns>
            public Android.App.Appsearch.AppSearchSchema Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema>("build", "()Landroid/app/appsearch/AppSearchSchema;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.Builder.html#addProperty(android.app.appsearch.AppSearchSchema.PropertyConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.AppSearchSchema.PropertyConfig"/></param>
            /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.Builder"/></returns>
            public Android.App.Appsearch.AppSearchSchema.Builder AddProperty(Android.App.Appsearch.AppSearchSchema.PropertyConfig arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.Builder>("addProperty", "(Landroid/app/appsearch/AppSearchSchema$PropertyConfig;)Landroid/app/appsearch/AppSearchSchema$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BytesPropertyConfig
        public partial class BytesPropertyConfig
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

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.BytesPropertyConfig.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.BytesPropertyConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.BytesPropertyConfig"/></returns>
                public Android.App.Appsearch.AppSearchSchema.BytesPropertyConfig Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.BytesPropertyConfig>("build", "()Landroid/app/appsearch/AppSearchSchema$BytesPropertyConfig;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.BytesPropertyConfig.Builder.html#setCardinality(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.BytesPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.BytesPropertyConfig.Builder SetCardinality(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.BytesPropertyConfig.Builder>("setCardinality", "(I)Landroid/app/appsearch/AppSearchSchema$BytesPropertyConfig$Builder;", arg0);
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

        #region DocumentPropertyConfig
        public partial class DocumentPropertyConfig
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DocumentPropertyConfig.html#shouldIndexNestedProperties()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool ShouldIndexNestedProperties()
            {
                return IExecuteWithSignature<bool>("shouldIndexNestedProperties", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DocumentPropertyConfig.html#getSchemaType()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetSchemaType()
            {
                return IExecuteWithSignature<Java.Lang.String>("getSchemaType", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DocumentPropertyConfig.Builder.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                /// <param name="arg1"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0, Java.Lang.String arg1)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DocumentPropertyConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig"/></returns>
                public Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig>("build", "()Landroid/app/appsearch/AppSearchSchema$DocumentPropertyConfig;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DocumentPropertyConfig.Builder.html#setCardinality(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig.Builder SetCardinality(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig.Builder>("setCardinality", "(I)Landroid/app/appsearch/AppSearchSchema$DocumentPropertyConfig$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DocumentPropertyConfig.Builder.html#setShouldIndexNestedProperties(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig.Builder SetShouldIndexNestedProperties(bool arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.DocumentPropertyConfig.Builder>("setShouldIndexNestedProperties", "(Z)Landroid/app/appsearch/AppSearchSchema$DocumentPropertyConfig$Builder;", arg0);
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

        #region DoublePropertyConfig
        public partial class DoublePropertyConfig
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

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DoublePropertyConfig.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DoublePropertyConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.DoublePropertyConfig"/></returns>
                public Android.App.Appsearch.AppSearchSchema.DoublePropertyConfig Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.DoublePropertyConfig>("build", "()Landroid/app/appsearch/AppSearchSchema$DoublePropertyConfig;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.DoublePropertyConfig.Builder.html#setCardinality(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.DoublePropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.DoublePropertyConfig.Builder SetCardinality(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.DoublePropertyConfig.Builder>("setCardinality", "(I)Landroid/app/appsearch/AppSearchSchema$DoublePropertyConfig$Builder;", arg0);
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

        #region LongPropertyConfig
        public partial class LongPropertyConfig
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.html#INDEXING_TYPE_NONE"/>
            /// </summary>
            public static int INDEXING_TYPE_NONE { get { if (!_INDEXING_TYPE_NONEReady) { _INDEXING_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "INDEXING_TYPE_NONE"); _INDEXING_TYPE_NONEReady = true; } return _INDEXING_TYPE_NONEContent; } }
            private static int _INDEXING_TYPE_NONEContent = default;
            private static bool _INDEXING_TYPE_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.html#INDEXING_TYPE_RANGE"/>
            /// </summary>
            public static int INDEXING_TYPE_RANGE { get { if (!_INDEXING_TYPE_RANGEReady) { _INDEXING_TYPE_RANGEContent = SGetField<int>(LocalBridgeClazz, "INDEXING_TYPE_RANGE"); _INDEXING_TYPE_RANGEReady = true; } return _INDEXING_TYPE_RANGEContent; } }
            private static int _INDEXING_TYPE_RANGEContent = default;
            private static bool _INDEXING_TYPE_RANGEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.html#getIndexingType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetIndexingType()
            {
                return IExecuteWithSignature<int>("getIndexingType", "()I");
            }

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.LongPropertyConfig"/></returns>
                public Android.App.Appsearch.AppSearchSchema.LongPropertyConfig Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.LongPropertyConfig>("build", "()Landroid/app/appsearch/AppSearchSchema$LongPropertyConfig;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.Builder.html#setCardinality(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.LongPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.LongPropertyConfig.Builder SetCardinality(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.LongPropertyConfig.Builder>("setCardinality", "(I)Landroid/app/appsearch/AppSearchSchema$LongPropertyConfig$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.LongPropertyConfig.Builder.html#setIndexingType(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.LongPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.LongPropertyConfig.Builder SetIndexingType(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.LongPropertyConfig.Builder>("setIndexingType", "(I)Landroid/app/appsearch/AppSearchSchema$LongPropertyConfig$Builder;", arg0);
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

        #region PropertyConfig
        public partial class PropertyConfig
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.PropertyConfig.html#CARDINALITY_OPTIONAL"/>
            /// </summary>
            public static int CARDINALITY_OPTIONAL { get { if (!_CARDINALITY_OPTIONALReady) { _CARDINALITY_OPTIONALContent = SGetField<int>(LocalBridgeClazz, "CARDINALITY_OPTIONAL"); _CARDINALITY_OPTIONALReady = true; } return _CARDINALITY_OPTIONALContent; } }
            private static int _CARDINALITY_OPTIONALContent = default;
            private static bool _CARDINALITY_OPTIONALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.PropertyConfig.html#CARDINALITY_REPEATED"/>
            /// </summary>
            public static int CARDINALITY_REPEATED { get { if (!_CARDINALITY_REPEATEDReady) { _CARDINALITY_REPEATEDContent = SGetField<int>(LocalBridgeClazz, "CARDINALITY_REPEATED"); _CARDINALITY_REPEATEDReady = true; } return _CARDINALITY_REPEATEDContent; } }
            private static int _CARDINALITY_REPEATEDContent = default;
            private static bool _CARDINALITY_REPEATEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.PropertyConfig.html#CARDINALITY_REQUIRED"/>
            /// </summary>
            public static int CARDINALITY_REQUIRED { get { if (!_CARDINALITY_REQUIREDReady) { _CARDINALITY_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "CARDINALITY_REQUIRED"); _CARDINALITY_REQUIREDReady = true; } return _CARDINALITY_REQUIREDContent; } }
            private static int _CARDINALITY_REQUIREDContent = default;
            private static bool _CARDINALITY_REQUIREDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.PropertyConfig.html#getCardinality()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCardinality()
            {
                return IExecuteWithSignature<int>("getCardinality", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.PropertyConfig.html#getName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StringPropertyConfig
        public partial class StringPropertyConfig
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#INDEXING_TYPE_EXACT_TERMS"/>
            /// </summary>
            public static int INDEXING_TYPE_EXACT_TERMS { get { if (!_INDEXING_TYPE_EXACT_TERMSReady) { _INDEXING_TYPE_EXACT_TERMSContent = SGetField<int>(LocalBridgeClazz, "INDEXING_TYPE_EXACT_TERMS"); _INDEXING_TYPE_EXACT_TERMSReady = true; } return _INDEXING_TYPE_EXACT_TERMSContent; } }
            private static int _INDEXING_TYPE_EXACT_TERMSContent = default;
            private static bool _INDEXING_TYPE_EXACT_TERMSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#INDEXING_TYPE_NONE"/>
            /// </summary>
            public static int INDEXING_TYPE_NONE { get { if (!_INDEXING_TYPE_NONEReady) { _INDEXING_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "INDEXING_TYPE_NONE"); _INDEXING_TYPE_NONEReady = true; } return _INDEXING_TYPE_NONEContent; } }
            private static int _INDEXING_TYPE_NONEContent = default;
            private static bool _INDEXING_TYPE_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#INDEXING_TYPE_PREFIXES"/>
            /// </summary>
            public static int INDEXING_TYPE_PREFIXES { get { if (!_INDEXING_TYPE_PREFIXESReady) { _INDEXING_TYPE_PREFIXESContent = SGetField<int>(LocalBridgeClazz, "INDEXING_TYPE_PREFIXES"); _INDEXING_TYPE_PREFIXESReady = true; } return _INDEXING_TYPE_PREFIXESContent; } }
            private static int _INDEXING_TYPE_PREFIXESContent = default;
            private static bool _INDEXING_TYPE_PREFIXESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#JOINABLE_VALUE_TYPE_NONE"/>
            /// </summary>
            public static int JOINABLE_VALUE_TYPE_NONE { get { if (!_JOINABLE_VALUE_TYPE_NONEReady) { _JOINABLE_VALUE_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "JOINABLE_VALUE_TYPE_NONE"); _JOINABLE_VALUE_TYPE_NONEReady = true; } return _JOINABLE_VALUE_TYPE_NONEContent; } }
            private static int _JOINABLE_VALUE_TYPE_NONEContent = default;
            private static bool _JOINABLE_VALUE_TYPE_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#JOINABLE_VALUE_TYPE_QUALIFIED_ID"/>
            /// </summary>
            public static int JOINABLE_VALUE_TYPE_QUALIFIED_ID { get { if (!_JOINABLE_VALUE_TYPE_QUALIFIED_IDReady) { _JOINABLE_VALUE_TYPE_QUALIFIED_IDContent = SGetField<int>(LocalBridgeClazz, "JOINABLE_VALUE_TYPE_QUALIFIED_ID"); _JOINABLE_VALUE_TYPE_QUALIFIED_IDReady = true; } return _JOINABLE_VALUE_TYPE_QUALIFIED_IDContent; } }
            private static int _JOINABLE_VALUE_TYPE_QUALIFIED_IDContent = default;
            private static bool _JOINABLE_VALUE_TYPE_QUALIFIED_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#TOKENIZER_TYPE_NONE"/>
            /// </summary>
            public static int TOKENIZER_TYPE_NONE { get { if (!_TOKENIZER_TYPE_NONEReady) { _TOKENIZER_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "TOKENIZER_TYPE_NONE"); _TOKENIZER_TYPE_NONEReady = true; } return _TOKENIZER_TYPE_NONEContent; } }
            private static int _TOKENIZER_TYPE_NONEContent = default;
            private static bool _TOKENIZER_TYPE_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#TOKENIZER_TYPE_PLAIN"/>
            /// </summary>
            public static int TOKENIZER_TYPE_PLAIN { get { if (!_TOKENIZER_TYPE_PLAINReady) { _TOKENIZER_TYPE_PLAINContent = SGetField<int>(LocalBridgeClazz, "TOKENIZER_TYPE_PLAIN"); _TOKENIZER_TYPE_PLAINReady = true; } return _TOKENIZER_TYPE_PLAINContent; } }
            private static int _TOKENIZER_TYPE_PLAINContent = default;
            private static bool _TOKENIZER_TYPE_PLAINReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#TOKENIZER_TYPE_RFC822"/>
            /// </summary>
            public static int TOKENIZER_TYPE_RFC822 { get { if (!_TOKENIZER_TYPE_RFC822Ready) { _TOKENIZER_TYPE_RFC822Content = SGetField<int>(LocalBridgeClazz, "TOKENIZER_TYPE_RFC822"); _TOKENIZER_TYPE_RFC822Ready = true; } return _TOKENIZER_TYPE_RFC822Content; } }
            private static int _TOKENIZER_TYPE_RFC822Content = default;
            private static bool _TOKENIZER_TYPE_RFC822Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#TOKENIZER_TYPE_VERBATIM"/>
            /// </summary>
            public static int TOKENIZER_TYPE_VERBATIM { get { if (!_TOKENIZER_TYPE_VERBATIMReady) { _TOKENIZER_TYPE_VERBATIMContent = SGetField<int>(LocalBridgeClazz, "TOKENIZER_TYPE_VERBATIM"); _TOKENIZER_TYPE_VERBATIMReady = true; } return _TOKENIZER_TYPE_VERBATIMContent; } }
            private static int _TOKENIZER_TYPE_VERBATIMContent = default;
            private static bool _TOKENIZER_TYPE_VERBATIMReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#getIndexingType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetIndexingType()
            {
                return IExecuteWithSignature<int>("getIndexingType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#getJoinableValueType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetJoinableValueType()
            {
                return IExecuteWithSignature<int>("getJoinableValueType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.html#getTokenizerType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTokenizerType()
            {
                return IExecuteWithSignature<int>("getTokenizerType", "()I");
            }

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.StringPropertyConfig"/></returns>
                public Android.App.Appsearch.AppSearchSchema.StringPropertyConfig Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.StringPropertyConfig>("build", "()Landroid/app/appsearch/AppSearchSchema$StringPropertyConfig;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.Builder.html#setCardinality(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder SetCardinality(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder>("setCardinality", "(I)Landroid/app/appsearch/AppSearchSchema$StringPropertyConfig$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.Builder.html#setIndexingType(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder SetIndexingType(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder>("setIndexingType", "(I)Landroid/app/appsearch/AppSearchSchema$StringPropertyConfig$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.Builder.html#setJoinableValueType(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder SetJoinableValueType(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder>("setJoinableValueType", "(I)Landroid/app/appsearch/AppSearchSchema$StringPropertyConfig$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSchema.StringPropertyConfig.Builder.html#setTokenizerType(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder"/></returns>
                public Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder SetTokenizerType(int arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchSchema.StringPropertyConfig.Builder>("setTokenizerType", "(I)Landroid/app/appsearch/AppSearchSchema$StringPropertyConfig$Builder;", arg0);
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