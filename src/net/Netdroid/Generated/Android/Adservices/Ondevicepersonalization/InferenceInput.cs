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

namespace Android.Adservices.Ondevicepersonalization
{
    #region InferenceInput declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.html"/>
    /// </summary>
    public partial class InferenceInput : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InferenceInput>
    {
        const string _bridgeClassName = "android.adservices.ondevicepersonalization.InferenceInput";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InferenceInput() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InferenceInput(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.ondevicepersonalization.InferenceInput$Builder";
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

        #region Params declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html"/>
        /// </summary>
        public partial class Params : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Params>
        {
            const string _bridgeClassName = "android.adservices.ondevicepersonalization.InferenceInput$Params";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Params() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Params(params object[] args) : base(args) { }

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
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.adservices.ondevicepersonalization.InferenceInput$Params$Builder";
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

    
    }
    #endregion

    #region InferenceInput implementation
    public partial class InferenceInput
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params"/></returns>
        public Android.Adservices.Ondevicepersonalization.InferenceInput.Params GetParams()
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params>("getParams", "()Landroid/adservices/ondevicepersonalization/InferenceInput$Params;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.html#getExpectedOutputStructure()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceOutput"/></returns>
        public Android.Adservices.Ondevicepersonalization.InferenceOutput GetExpectedOutputStructure()
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceOutput>("getExpectedOutputStructure", "()Landroid/adservices/ondevicepersonalization/InferenceOutput;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.html#getBatchSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBatchSize()
        {
            return IExecuteWithSignature<int>("getBatchSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.html#getInputData()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] GetInputData()
        {
            return IExecuteWithSignatureArray<object>("getInputData", "()[Ljava/lang/Object;");
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
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput"/></returns>
            public Android.Adservices.Ondevicepersonalization.InferenceInput Build()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput>("build", "()Landroid/adservices/ondevicepersonalization/InferenceInput;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Builder.html#setBatchSize(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.InferenceInput.Builder SetBatchSize(int arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Builder>("setBatchSize", "(I)Landroid/adservices/ondevicepersonalization/InferenceInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Builder.html#setExpectedOutputStructure(android.adservices.ondevicepersonalization.InferenceOutput)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.InferenceOutput"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.InferenceInput.Builder SetExpectedOutputStructure(Android.Adservices.Ondevicepersonalization.InferenceOutput arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Builder>("setExpectedOutputStructure", "(Landroid/adservices/ondevicepersonalization/InferenceOutput;)Landroid/adservices/ondevicepersonalization/InferenceInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Builder.html#setInputData(java.lang.Object[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.InferenceInput.Builder SetInputData(params object[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Builder>("setInputData", "([Ljava/lang/Object;)Landroid/adservices/ondevicepersonalization/InferenceInput$Builder;"); else return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Builder>("setInputData", "([Ljava/lang/Object;)Landroid/adservices/ondevicepersonalization/InferenceInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Builder.html#setParams(android.adservices.ondevicepersonalization.InferenceInput.Params)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.InferenceInput.Builder SetParams(Android.Adservices.Ondevicepersonalization.InferenceInput.Params arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Builder>("setParams", "(Landroid/adservices/ondevicepersonalization/InferenceInput$Params;)Landroid/adservices/ondevicepersonalization/InferenceInput$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Params implementation
        public partial class Params
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#DELEGATE_CPU"/>
            /// </summary>
            public static int DELEGATE_CPU { get { if (!_DELEGATE_CPUReady) { _DELEGATE_CPUContent = SGetField<int>(LocalBridgeClazz, "DELEGATE_CPU"); _DELEGATE_CPUReady = true; } return _DELEGATE_CPUContent; } }
            private static int _DELEGATE_CPUContent = default;
            private static bool _DELEGATE_CPUReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#MODEL_TYPE_TENSORFLOW_LITE"/>
            /// </summary>
            public static int MODEL_TYPE_TENSORFLOW_LITE { get { if (!_MODEL_TYPE_TENSORFLOW_LITEReady) { _MODEL_TYPE_TENSORFLOW_LITEContent = SGetField<int>(LocalBridgeClazz, "MODEL_TYPE_TENSORFLOW_LITE"); _MODEL_TYPE_TENSORFLOW_LITEReady = true; } return _MODEL_TYPE_TENSORFLOW_LITEContent; } }
            private static int _MODEL_TYPE_TENSORFLOW_LITEContent = default;
            private static bool _MODEL_TYPE_TENSORFLOW_LITEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#getKeyValueStore()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.KeyValueStore"/></returns>
            public Android.Adservices.Ondevicepersonalization.KeyValueStore GetKeyValueStore()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.KeyValueStore>("getKeyValueStore", "()Landroid/adservices/ondevicepersonalization/KeyValueStore;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#getDelegateType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetDelegateType()
            {
                return IExecuteWithSignature<int>("getDelegateType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#getModelType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetModelType()
            {
                return IExecuteWithSignature<int>("getModelType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#getRecommendedNumThreads()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetRecommendedNumThreads()
            {
                return IExecuteWithSignature<int>("getRecommendedNumThreads", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.html#getModelKey()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetModelKey()
            {
                return IExecuteWithSignature<Java.Lang.String>("getModelKey", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes
            #region Builder implementation
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#%3Cinit%3E(android.adservices.ondevicepersonalization.KeyValueStore,java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.KeyValueStore"/></param>
                /// <param name="arg1"><see cref="Java.Lang.String"/></param>
                public Builder(Android.Adservices.Ondevicepersonalization.KeyValueStore arg0, Java.Lang.String arg1)
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
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params"/></returns>
                public Android.Adservices.Ondevicepersonalization.InferenceInput.Params Build()
                {
                    return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params>("build", "()Landroid/adservices/ondevicepersonalization/InferenceInput$Params;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#setDelegateType(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder"/></returns>
                public Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder SetDelegateType(int arg0)
                {
                    return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder>("setDelegateType", "(I)Landroid/adservices/ondevicepersonalization/InferenceInput$Params$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#setKeyValueStore(android.adservices.ondevicepersonalization.KeyValueStore)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.KeyValueStore"/></param>
                /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder"/></returns>
                public Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder SetKeyValueStore(Android.Adservices.Ondevicepersonalization.KeyValueStore arg0)
                {
                    return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder>("setKeyValueStore", "(Landroid/adservices/ondevicepersonalization/KeyValueStore;)Landroid/adservices/ondevicepersonalization/InferenceInput$Params$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#setModelKey(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder"/></returns>
                public Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder SetModelKey(Java.Lang.String arg0)
                {
                    return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder>("setModelKey", "(Ljava/lang/String;)Landroid/adservices/ondevicepersonalization/InferenceInput$Params$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#setModelType(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder"/></returns>
                public Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder SetModelType(int arg0)
                {
                    return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder>("setModelType", "(I)Landroid/adservices/ondevicepersonalization/InferenceInput$Params$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/InferenceInput.Params.Builder.html#setRecommendedNumThreads(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder"/></returns>
                public Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder SetRecommendedNumThreads(int arg0)
                {
                    return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.InferenceInput.Params.Builder>("setRecommendedNumThreads", "(I)Landroid/adservices/ondevicepersonalization/InferenceInput$Params$Builder;", arg0);
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