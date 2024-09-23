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

namespace Java.Lang.Invoke
{
    #region TypeDescriptor declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.html"/>
    /// </summary>
    public partial class TypeDescriptor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TypeDescriptor>
    {
        const string _bridgeClassName = "java.lang.invoke.TypeDescriptor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TypeDescriptor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeDescriptor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TypeDescriptor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeDescriptor(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region OfField declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html"/>
        /// </summary>
        public partial class OfField : Java.Lang.Invoke.TypeDescriptor
        {
            const string _bridgeClassName = "java.lang.invoke.TypeDescriptor$OfField";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("OfField class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfField() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("OfField class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfField(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region OfField<F> declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html"/>
        /// </summary>
        /// <typeparam name="F"><see cref="Java.Lang.Invoke.TypeDescriptor.OfField{F}"/></typeparam>
        public partial class OfField<F> : Java.Lang.Invoke.TypeDescriptor where F : Java.Lang.Invoke.TypeDescriptor.OfField<F>
        {
            const string _bridgeClassName = "java.lang.invoke.TypeDescriptor$OfField";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("OfField class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfField() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("OfField class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfField(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region OfMethod declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html"/>
        /// </summary>
        public partial class OfMethod : Java.Lang.Invoke.TypeDescriptor
        {
            const string _bridgeClassName = "java.lang.invoke.TypeDescriptor$OfMethod";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("OfMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfMethod() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("OfMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfMethod(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region OfMethod<F, M> declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html"/>
        /// </summary>
        /// <typeparam name="F"><see cref="Java.Lang.Invoke.TypeDescriptor.OfField{F}"/></typeparam>
        /// <typeparam name="M"><see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod{F, M}"/></typeparam>
        public partial class OfMethod<F, M> : Java.Lang.Invoke.TypeDescriptor where F : Java.Lang.Invoke.TypeDescriptor.OfField<F> where M : Java.Lang.Invoke.TypeDescriptor.OfMethod<F, M>
        {
            const string _bridgeClassName = "java.lang.invoke.TypeDescriptor$OfMethod";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("OfMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfMethod() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("OfMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OfMethod(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region ITypeDescriptor
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeDescriptor
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region TypeDescriptor implementation
    public partial class TypeDescriptor : Java.Lang.Invoke.ITypeDescriptor
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
        /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.html#descriptorString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String DescriptorString()
        {
            return IExecuteWithSignature<Java.Lang.String>("descriptorString", "()Ljava/lang/String;");
        }
    
        #endregion
    
        #region Nested classes
        #region OfField implementation
        public partial class OfField
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
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#isArray()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsArray()
            {
                return IExecuteWithSignature<bool>("isArray", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#isPrimitive()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsPrimitive()
            {
                return IExecuteWithSignature<bool>("isPrimitive", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#arrayType()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfField ArrayType()
            {
                return IExecuteWithSignature<Java.Lang.Invoke.TypeDescriptor.OfField>("arrayType", "()Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#componentType()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfField ComponentType()
            {
                return IExecuteWithSignature<Java.Lang.Invoke.TypeDescriptor.OfField>("componentType", "()Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OfField<F> implementation
        public partial class OfField<F>
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Lang.Invoke.TypeDescriptor.OfField{F}"/> to <see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/>
            /// </summary>
            public static implicit operator Java.Lang.Invoke.TypeDescriptor.OfField(Java.Lang.Invoke.TypeDescriptor.OfField<F> t) => t.Cast<Java.Lang.Invoke.TypeDescriptor.OfField>();
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#isArray()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsArray()
            {
                return IExecuteWithSignature<bool>("isArray", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#isPrimitive()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsPrimitive()
            {
                return IExecuteWithSignature<bool>("isPrimitive", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#arrayType()"/>
            /// </summary>
            /// <returns><typeparamref name="F"/></returns>
            public F ArrayType()
            {
                return IExecuteWithSignature<F>("arrayType", "()Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfField.html#componentType()"/>
            /// </summary>
            /// <returns><typeparamref name="F"/></returns>
            public F ComponentType()
            {
                return IExecuteWithSignature<F>("componentType", "()Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OfMethod implementation
        public partial class OfMethod
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
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfField ParameterType(int arg0)
            {
                return IExecuteWithSignature<Java.Lang.Invoke.TypeDescriptor.OfField>("parameterType", "(I)Ljava/lang/invoke/TypeDescriptor$OfField;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#returnType()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfField ReturnType()
            {
                return IExecuteWithSignature<Java.Lang.Invoke.TypeDescriptor.OfField>("returnType", "()Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterArray()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfField[] ParameterArray()
            {
                return IExecuteWithSignatureArray<Java.Lang.Invoke.TypeDescriptor.OfField>("parameterArray", "()[Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ParameterCount()
            {
                return IExecuteWithSignature<int>("parameterCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterList()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List ParameterList()
            {
                return IExecuteWithSignature<Java.Util.List>("parameterList", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#changeParameterType(int,java.lang.invoke.TypeDescriptor.OfField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></param>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfMethod ChangeParameterType(int arg0, Java.Lang.Invoke.TypeDescriptor.OfField arg1)
            {
                return IExecute<Java.Lang.Invoke.TypeDescriptor.OfMethod>("changeParameterType", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#changeReturnType(java.lang.invoke.TypeDescriptor.OfField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></param>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfMethod ChangeReturnType(Java.Lang.Invoke.TypeDescriptor.OfField arg0)
            {
                return IExecuteWithSignature<Java.Lang.Invoke.TypeDescriptor.OfMethod>("changeReturnType", "(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#dropParameterTypes(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfMethod DropParameterTypes(int arg0, int arg1)
            {
                return IExecute<Java.Lang.Invoke.TypeDescriptor.OfMethod>("dropParameterTypes", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#insertParameterTypes(int,java.lang.invoke.TypeDescriptor.OfField[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Invoke.TypeDescriptor.OfField"/></param>
            /// <returns><see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod"/></returns>
            public Java.Lang.Invoke.TypeDescriptor.OfMethod InsertParameterTypes(int arg0, params Java.Lang.Invoke.TypeDescriptor.OfField[] arg1)
            {
                if (arg1.Length == 0) return IExecute<Java.Lang.Invoke.TypeDescriptor.OfMethod>("insertParameterTypes", arg0); else return IExecute<Java.Lang.Invoke.TypeDescriptor.OfMethod>("insertParameterTypes", arg0, arg1);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OfMethod<F, M> implementation
        public partial class OfMethod<F, M>
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod{F, M}"/> to <see cref="Java.Lang.Invoke.TypeDescriptor.OfMethod"/>
            /// </summary>
            public static implicit operator Java.Lang.Invoke.TypeDescriptor.OfMethod(Java.Lang.Invoke.TypeDescriptor.OfMethod<F, M> t) => t.Cast<Java.Lang.Invoke.TypeDescriptor.OfMethod>();
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><typeparamref name="F"/></returns>
            public F ParameterType(int arg0)
            {
                return IExecuteWithSignature<F>("parameterType", "(I)Ljava/lang/invoke/TypeDescriptor$OfField;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#returnType()"/>
            /// </summary>
            /// <returns><typeparamref name="F"/></returns>
            public F ReturnType()
            {
                return IExecuteWithSignature<F>("returnType", "()Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterArray()"/>
            /// </summary>
            /// <returns><typeparamref name="F"/></returns>
            public F[] ParameterArray()
            {
                return IExecuteWithSignatureArray<F>("parameterArray", "()[Ljava/lang/invoke/TypeDescriptor$OfField;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ParameterCount()
            {
                return IExecuteWithSignature<int>("parameterCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#parameterList()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<F> ParameterList()
            {
                return IExecuteWithSignature<Java.Util.List<F>>("parameterList", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#changeParameterType(int,java.lang.invoke.TypeDescriptor.OfField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><typeparamref name="F"/></param>
            /// <returns><typeparamref name="M"/></returns>
            public M ChangeParameterType(int arg0, F arg1)
            {
                return IExecute<M>("changeParameterType", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#changeReturnType(java.lang.invoke.TypeDescriptor.OfField)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="F"/></param>
            /// <returns><typeparamref name="M"/></returns>
            public M ChangeReturnType(F arg0)
            {
                return IExecuteWithSignature<M>("changeReturnType", "(Ljava/lang/invoke/TypeDescriptor$OfField;)Ljava/lang/invoke/TypeDescriptor$OfMethod;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#dropParameterTypes(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><typeparamref name="M"/></returns>
            public M DropParameterTypes(int arg0, int arg1)
            {
                return IExecute<M>("dropParameterTypes", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/lang/invoke/TypeDescriptor.OfMethod.html#insertParameterTypes(int,java.lang.invoke.TypeDescriptor.OfField[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><typeparamref name="F"/></param>
            /// <returns><typeparamref name="M"/></returns>
            public M InsertParameterTypes(int arg0, params F[] arg1)
            {
                if (arg1.Length == 0) return IExecute<M>("insertParameterTypes", arg0); else return IExecute<M>("insertParameterTypes", arg0, arg1);
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