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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Appsearch
{
    #region PutDocumentsRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.html"/>
    /// </summary>
    public partial class PutDocumentsRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PutDocumentsRequest>
    {
        const string _bridgeClassName = "android.app.appsearch.PutDocumentsRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PutDocumentsRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PutDocumentsRequest(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.app.appsearch.PutDocumentsRequest$Builder";
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

    #region PutDocumentsRequest implementation
    public partial class PutDocumentsRequest
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.html#getGenericDocuments()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Appsearch.GenericDocument> GetGenericDocuments()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Appsearch.GenericDocument>>("getGenericDocuments", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.html#getTakenActionGenericDocuments()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Appsearch.GenericDocument> GetTakenActionGenericDocuments()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Appsearch.GenericDocument>>("getTakenActionGenericDocuments", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.PutDocumentsRequest"/></returns>
            public Android.App.Appsearch.PutDocumentsRequest Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest>("build", "()Landroid/app/appsearch/PutDocumentsRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.Builder.html#addGenericDocuments(android.app.appsearch.GenericDocument[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.GenericDocument"/></param>
            /// <returns><see cref="Android.App.Appsearch.PutDocumentsRequest.Builder"/></returns>
            public Android.App.Appsearch.PutDocumentsRequest.Builder AddGenericDocuments(params Android.App.Appsearch.GenericDocument[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest.Builder>("addGenericDocuments", "([Landroid/app/appsearch/GenericDocument;)Landroid/app/appsearch/PutDocumentsRequest$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest.Builder>("addGenericDocuments", "([Landroid/app/appsearch/GenericDocument;)Landroid/app/appsearch/PutDocumentsRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.Builder.html#addGenericDocuments(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <typeparam name="Arg0ExtendsAndroid_App_Appsearch_GenericDocument"><see cref="Android.App.Appsearch.GenericDocument"/></typeparam>
            /// <returns><see cref="Android.App.Appsearch.PutDocumentsRequest.Builder"/></returns>
            public Android.App.Appsearch.PutDocumentsRequest.Builder AddGenericDocuments<Arg0ExtendsAndroid_App_Appsearch_GenericDocument>(Java.Util.Collection<Arg0ExtendsAndroid_App_Appsearch_GenericDocument> arg0) where Arg0ExtendsAndroid_App_Appsearch_GenericDocument : Android.App.Appsearch.GenericDocument
            {
                return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest.Builder>("addGenericDocuments", "(Ljava/util/Collection;)Landroid/app/appsearch/PutDocumentsRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.Builder.html#addTakenActionGenericDocuments(android.app.appsearch.GenericDocument[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.GenericDocument"/></param>
            /// <returns><see cref="Android.App.Appsearch.PutDocumentsRequest.Builder"/></returns>
            /// <exception cref="Android.App.Appsearch.Exceptions.AppSearchException"/>
            public Android.App.Appsearch.PutDocumentsRequest.Builder AddTakenActionGenericDocuments(params Android.App.Appsearch.GenericDocument[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest.Builder>("addTakenActionGenericDocuments", "([Landroid/app/appsearch/GenericDocument;)Landroid/app/appsearch/PutDocumentsRequest$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest.Builder>("addTakenActionGenericDocuments", "([Landroid/app/appsearch/GenericDocument;)Landroid/app/appsearch/PutDocumentsRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/PutDocumentsRequest.Builder.html#addTakenActionGenericDocuments(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <typeparam name="Arg0ExtendsAndroid_App_Appsearch_GenericDocument"><see cref="Android.App.Appsearch.GenericDocument"/></typeparam>
            /// <returns><see cref="Android.App.Appsearch.PutDocumentsRequest.Builder"/></returns>
            /// <exception cref="Android.App.Appsearch.Exceptions.AppSearchException"/>
            public Android.App.Appsearch.PutDocumentsRequest.Builder AddTakenActionGenericDocuments<Arg0ExtendsAndroid_App_Appsearch_GenericDocument>(Java.Util.Collection<Arg0ExtendsAndroid_App_Appsearch_GenericDocument> arg0) where Arg0ExtendsAndroid_App_Appsearch_GenericDocument : Android.App.Appsearch.GenericDocument
            {
                return IExecuteWithSignature<Android.App.Appsearch.PutDocumentsRequest.Builder>("addTakenActionGenericDocuments", "(Ljava/util/Collection;)Landroid/app/appsearch/PutDocumentsRequest$Builder;", arg0);
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