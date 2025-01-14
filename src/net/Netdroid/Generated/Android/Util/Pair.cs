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

namespace Android.Util
{
    #region Pair declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/Pair.html"/>
    /// </summary>
    public partial class Pair : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Pair>
    {
        const string _bridgeClassName = "android.util.Pair";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Pair() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Pair(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region Pair<F, S> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/Pair.html"/>
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="S"></typeparam>
    public partial class Pair<F, S> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Pair<F, S>>
    {
        const string _bridgeClassName = "android.util.Pair";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Pair() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Pair(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region Pair implementation
    public partial class Pair
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#%3Cinit%3E(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public Pair(object arg0, object arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#first"/>
        /// </summary>
        public object first { get { if (!_firstReady) { _firstContent = IGetField<object>("first"); _firstReady = true; } return _firstContent; } }
        private object _firstContent = default;
        private bool _firstReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#second"/>
        /// </summary>
        public object second { get { if (!_secondReady) { _secondContent = IGetField<object>("second"); _secondReady = true; } return _secondContent; } }
        private object _secondContent = default;
        private bool _secondReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#create(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Android.Util.Pair"/></returns>
        public static Android.Util.Pair Create(object arg0, object arg1)
        {
            return SExecuteWithSignature<Android.Util.Pair>(LocalBridgeClazz, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region Pair<F, S> implementation
    public partial class Pair<F, S>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#%3Cinit%3E(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="F"/></param>
        /// <param name="arg1"><typeparamref name="S"/></param>
        public Pair(F arg0, S arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.Pair{F, S}"/> to <see cref="Android.Util.Pair"/>
        /// </summary>
        public static implicit operator Android.Util.Pair(Android.Util.Pair<F, S> t) => t.Cast<Android.Util.Pair>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#first"/>
        /// </summary>
        public F first { get { if (!_firstReady) { _firstContent = IGetField<F>("first"); _firstReady = true; } return _firstContent; } }
        private F _firstContent = default;
        private bool _firstReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#second"/>
        /// </summary>
        public S second { get { if (!_secondReady) { _secondContent = IGetField<S>("second"); _secondReady = true; } return _secondContent; } }
        private S _secondContent = default;
        private bool _secondReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Pair.html#create(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <param name="arg1"><typeparamref name="B"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="B"></typeparam>
        /// <returns><see cref="Android.Util.Pair"/></returns>
        public static Android.Util.Pair<A, B> Create<A, B>(A arg0, B arg1)
        {
            return SExecuteWithSignature<Android.Util.Pair<A, B>>(LocalBridgeClazz, "create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}