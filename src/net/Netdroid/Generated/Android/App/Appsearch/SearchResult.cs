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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Appsearch
{
    #region SearchResult declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html"/>
    /// </summary>
    public partial class SearchResult : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.appsearch.SearchResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SearchResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SearchResult(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.app.appsearch.SearchResult$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region MatchInfo declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html"/>
        /// </summary>
        public partial class MatchInfo : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.app.appsearch.SearchResult$MatchInfo";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MatchInfo() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MatchInfo(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
            #region Builder declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.app.appsearch.SearchResult$MatchInfo$Builder";
                /// <summary>
                /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
                /// </summary>
                public Builder() { }
                /// <summary>
                /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
                /// </summary>
                public Builder(params object[] args) : base(args) { }
            
                private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
                private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
                /// </summary>
                public override string BridgeClassName => _bridgeClassName;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
                /// </summary>
                public override bool IsBridgeAbstract => false;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
                /// </summary>
                public override bool IsBridgeCloseable => false;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
                /// </summary>
                public override bool IsBridgeInterface => false;
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
                /// </summary>
                public override bool IsBridgeStatic => true;
            
                // TODO: complete the class
            
            }
            #endregion

        
        }
        #endregion

        #region MatchRange declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchRange.html"/>
        /// </summary>
        public partial class MatchRange : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MatchRange>
        {
            const string _bridgeClassName = "android.app.appsearch.SearchResult$MatchRange";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MatchRange() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MatchRange(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region SearchResult implementation
    public partial class SearchResult
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#getGenericDocument()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Appsearch.GenericDocument"/></returns>
        public Android.App.Appsearch.GenericDocument GetGenericDocument()
        {
            return IExecuteWithSignature<Android.App.Appsearch.GenericDocument>("getGenericDocument", "()Landroid/app/appsearch/GenericDocument;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#getRankingSignal()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetRankingSignal()
        {
            return IExecuteWithSignature<double>("getRankingSignal", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#getDatabaseName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDatabaseName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDatabaseName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#getJoinedResults()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Appsearch.SearchResult> GetJoinedResults()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Appsearch.SearchResult>>("getJoinedResults", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#getMatchInfos()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Appsearch.SearchResult.MatchInfo> GetMatchInfos()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Appsearch.SearchResult.MatchInfo>>("getMatchInfos", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SearchResult"/></returns>
            public Android.App.Appsearch.SearchResult Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult>("build", "()Landroid/app/appsearch/SearchResult;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html#addJoinedResult(android.app.appsearch.SearchResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.SearchResult"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.Builder"/></returns>
            public Android.App.Appsearch.SearchResult.Builder AddJoinedResult(Android.App.Appsearch.SearchResult arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.Builder>("addJoinedResult", "(Landroid/app/appsearch/SearchResult;)Landroid/app/appsearch/SearchResult$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html#addMatchInfo(android.app.appsearch.SearchResult.MatchInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.SearchResult.MatchInfo"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.Builder"/></returns>
            public Android.App.Appsearch.SearchResult.Builder AddMatchInfo(Android.App.Appsearch.SearchResult.MatchInfo arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.Builder>("addMatchInfo", "(Landroid/app/appsearch/SearchResult$MatchInfo;)Landroid/app/appsearch/SearchResult$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html#setGenericDocument(android.app.appsearch.GenericDocument)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.GenericDocument"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.Builder"/></returns>
            public Android.App.Appsearch.SearchResult.Builder SetGenericDocument(Android.App.Appsearch.GenericDocument arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.Builder>("setGenericDocument", "(Landroid/app/appsearch/GenericDocument;)Landroid/app/appsearch/SearchResult$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.Builder.html#setRankingSignal(double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.Builder"/></returns>
            public Android.App.Appsearch.SearchResult.Builder SetRankingSignal(double arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.Builder>("setRankingSignal", "(D)Landroid/app/appsearch/SearchResult$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region MatchInfo implementation
        public partial class MatchInfo
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getPropertyPathObject()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.PropertyPath"/></returns>
            public Android.App.Appsearch.PropertyPath GetPropertyPathObject()
            {
                return IExecuteWithSignature<Android.App.Appsearch.PropertyPath>("getPropertyPathObject", "()Landroid/app/appsearch/PropertyPath;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getExactMatchRange()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchRange"/></returns>
            public Android.App.Appsearch.SearchResult.MatchRange GetExactMatchRange()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchRange>("getExactMatchRange", "()Landroid/app/appsearch/SearchResult$MatchRange;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getSnippetRange()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchRange"/></returns>
            public Android.App.Appsearch.SearchResult.MatchRange GetSnippetRange()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchRange>("getSnippetRange", "()Landroid/app/appsearch/SearchResult$MatchRange;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getSubmatchRange()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchRange"/></returns>
            public Android.App.Appsearch.SearchResult.MatchRange GetSubmatchRange()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchRange>("getSubmatchRange", "()Landroid/app/appsearch/SearchResult$MatchRange;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getExactMatch()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetExactMatch()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getExactMatch", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getSnippet()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetSnippet()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getSnippet", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getSubmatch()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetSubmatch()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getSubmatch", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getFullText()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetFullText()
            {
                return IExecuteWithSignature<Java.Lang.String>("getFullText", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#getPropertyPath()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetPropertyPath()
            {
                return IExecuteWithSignature<Java.Lang.String>("getPropertyPath", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }
        
            #endregion
        
            #region Nested classes
            #region Builder implementation
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.Builder.html#%3Cinit%3E(java.lang.String)"/>
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchInfo"/></returns>
                public Android.App.Appsearch.SearchResult.MatchInfo Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchInfo>("build", "()Landroid/app/appsearch/SearchResult$MatchInfo;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.Builder.html#setExactMatchRange(android.app.appsearch.SearchResult.MatchRange)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.App.Appsearch.SearchResult.MatchRange"/></param>
                /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchInfo.Builder"/></returns>
                public Android.App.Appsearch.SearchResult.MatchInfo.Builder SetExactMatchRange(Android.App.Appsearch.SearchResult.MatchRange arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchInfo.Builder>("setExactMatchRange", "(Landroid/app/appsearch/SearchResult$MatchRange;)Landroid/app/appsearch/SearchResult$MatchInfo$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.Builder.html#setSnippetRange(android.app.appsearch.SearchResult.MatchRange)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.App.Appsearch.SearchResult.MatchRange"/></param>
                /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchInfo.Builder"/></returns>
                public Android.App.Appsearch.SearchResult.MatchInfo.Builder SetSnippetRange(Android.App.Appsearch.SearchResult.MatchRange arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchInfo.Builder>("setSnippetRange", "(Landroid/app/appsearch/SearchResult$MatchRange;)Landroid/app/appsearch/SearchResult$MatchInfo$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchInfo.Builder.html#setSubmatchRange(android.app.appsearch.SearchResult.MatchRange)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.App.Appsearch.SearchResult.MatchRange"/></param>
                /// <returns><see cref="Android.App.Appsearch.SearchResult.MatchInfo.Builder"/></returns>
                public Android.App.Appsearch.SearchResult.MatchInfo.Builder SetSubmatchRange(Android.App.Appsearch.SearchResult.MatchRange arg0)
                {
                    return IExecuteWithSignature<Android.App.Appsearch.SearchResult.MatchInfo.Builder>("setSubmatchRange", "(Landroid/app/appsearch/SearchResult$MatchRange;)Landroid/app/appsearch/SearchResult$MatchInfo$Builder;", arg0);
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

        #region MatchRange implementation
        public partial class MatchRange
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchRange.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public MatchRange(int arg0, int arg1)
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchRange.html#getEnd()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetEnd()
            {
                return IExecuteWithSignature<int>("getEnd", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SearchResult.MatchRange.html#getStart()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetStart()
            {
                return IExecuteWithSignature<int>("getStart", "()I");
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