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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Appsearch
{
    #region JoinSpec
    public partial class JoinSpec
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#AGGREGATION_SCORING_AVG_RANKING_SIGNAL"/>
        /// </summary>
        public static int AGGREGATION_SCORING_AVG_RANKING_SIGNAL { get { if (!_AGGREGATION_SCORING_AVG_RANKING_SIGNALReady) { _AGGREGATION_SCORING_AVG_RANKING_SIGNALContent = SGetField<int>(LocalBridgeClazz, "AGGREGATION_SCORING_AVG_RANKING_SIGNAL"); _AGGREGATION_SCORING_AVG_RANKING_SIGNALReady = true; } return _AGGREGATION_SCORING_AVG_RANKING_SIGNALContent; } }
        private static int _AGGREGATION_SCORING_AVG_RANKING_SIGNALContent = default;
        private static bool _AGGREGATION_SCORING_AVG_RANKING_SIGNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#AGGREGATION_SCORING_MAX_RANKING_SIGNAL"/>
        /// </summary>
        public static int AGGREGATION_SCORING_MAX_RANKING_SIGNAL { get { if (!_AGGREGATION_SCORING_MAX_RANKING_SIGNALReady) { _AGGREGATION_SCORING_MAX_RANKING_SIGNALContent = SGetField<int>(LocalBridgeClazz, "AGGREGATION_SCORING_MAX_RANKING_SIGNAL"); _AGGREGATION_SCORING_MAX_RANKING_SIGNALReady = true; } return _AGGREGATION_SCORING_MAX_RANKING_SIGNALContent; } }
        private static int _AGGREGATION_SCORING_MAX_RANKING_SIGNALContent = default;
        private static bool _AGGREGATION_SCORING_MAX_RANKING_SIGNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#AGGREGATION_SCORING_MIN_RANKING_SIGNAL"/>
        /// </summary>
        public static int AGGREGATION_SCORING_MIN_RANKING_SIGNAL { get { if (!_AGGREGATION_SCORING_MIN_RANKING_SIGNALReady) { _AGGREGATION_SCORING_MIN_RANKING_SIGNALContent = SGetField<int>(LocalBridgeClazz, "AGGREGATION_SCORING_MIN_RANKING_SIGNAL"); _AGGREGATION_SCORING_MIN_RANKING_SIGNALReady = true; } return _AGGREGATION_SCORING_MIN_RANKING_SIGNALContent; } }
        private static int _AGGREGATION_SCORING_MIN_RANKING_SIGNALContent = default;
        private static bool _AGGREGATION_SCORING_MIN_RANKING_SIGNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNAL"/>
        /// </summary>
        public static int AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNAL { get { if (!_AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNALReady) { _AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNALContent = SGetField<int>(LocalBridgeClazz, "AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNAL"); _AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNALReady = true; } return _AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNALContent; } }
        private static int _AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNALContent = default;
        private static bool _AGGREGATION_SCORING_OUTER_RESULT_RANKING_SIGNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#AGGREGATION_SCORING_RESULT_COUNT"/>
        /// </summary>
        public static int AGGREGATION_SCORING_RESULT_COUNT { get { if (!_AGGREGATION_SCORING_RESULT_COUNTReady) { _AGGREGATION_SCORING_RESULT_COUNTContent = SGetField<int>(LocalBridgeClazz, "AGGREGATION_SCORING_RESULT_COUNT"); _AGGREGATION_SCORING_RESULT_COUNTReady = true; } return _AGGREGATION_SCORING_RESULT_COUNTContent; } }
        private static int _AGGREGATION_SCORING_RESULT_COUNTContent = default;
        private static bool _AGGREGATION_SCORING_RESULT_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#AGGREGATION_SCORING_SUM_RANKING_SIGNAL"/>
        /// </summary>
        public static int AGGREGATION_SCORING_SUM_RANKING_SIGNAL { get { if (!_AGGREGATION_SCORING_SUM_RANKING_SIGNALReady) { _AGGREGATION_SCORING_SUM_RANKING_SIGNALContent = SGetField<int>(LocalBridgeClazz, "AGGREGATION_SCORING_SUM_RANKING_SIGNAL"); _AGGREGATION_SCORING_SUM_RANKING_SIGNALReady = true; } return _AGGREGATION_SCORING_SUM_RANKING_SIGNALContent; } }
        private static int _AGGREGATION_SCORING_SUM_RANKING_SIGNALContent = default;
        private static bool _AGGREGATION_SCORING_SUM_RANKING_SIGNALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#getNestedSearchSpec()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Appsearch.SearchSpec"/></returns>
        public Android.App.Appsearch.SearchSpec GetNestedSearchSpec()
        {
            return IExecuteWithSignature<Android.App.Appsearch.SearchSpec>("getNestedSearchSpec", "()Landroid/app/appsearch/SearchSpec;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#getAggregationScoringStrategy()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAggregationScoringStrategy()
        {
            return IExecuteWithSignature<int>("getAggregationScoringStrategy", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#getMaxJoinedResultCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxJoinedResultCount()
        {
            return IExecuteWithSignature<int>("getMaxJoinedResultCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#getChildPropertyExpression()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetChildPropertyExpression()
        {
            return IExecuteWithSignature<Java.Lang.String>("getChildPropertyExpression", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#getNestedQuery()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNestedQuery()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNestedQuery", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.Builder.html#%3Cinit%3E(java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.JoinSpec"/></returns>
            public Android.App.Appsearch.JoinSpec Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.JoinSpec>("build", "()Landroid/app/appsearch/JoinSpec;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.Builder.html#setAggregationScoringStrategy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Appsearch.JoinSpec.Builder"/></returns>
            public Android.App.Appsearch.JoinSpec.Builder SetAggregationScoringStrategy(int arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.JoinSpec.Builder>("setAggregationScoringStrategy", "(I)Landroid/app/appsearch/JoinSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.Builder.html#setMaxJoinedResultCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Appsearch.JoinSpec.Builder"/></returns>
            public Android.App.Appsearch.JoinSpec.Builder SetMaxJoinedResultCount(int arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.JoinSpec.Builder>("setMaxJoinedResultCount", "(I)Landroid/app/appsearch/JoinSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/JoinSpec.Builder.html#setNestedSearch(java.lang.String,android.app.appsearch.SearchSpec)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.App.Appsearch.SearchSpec"/></param>
            /// <returns><see cref="Android.App.Appsearch.JoinSpec.Builder"/></returns>
            public Android.App.Appsearch.JoinSpec.Builder SetNestedSearch(Java.Lang.String arg0, Android.App.Appsearch.SearchSpec arg1)
            {
                return IExecute<Android.App.Appsearch.JoinSpec.Builder>("setNestedSearch", arg0, arg1);
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