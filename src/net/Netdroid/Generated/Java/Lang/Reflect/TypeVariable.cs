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

namespace Java.Lang.Reflect
{
    #region TypeVariable declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html"/>
    /// </summary>
    public partial class TypeVariable : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TypeVariable>
    {
        const string _bridgeClassName = "java.lang.reflect.TypeVariable";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TypeVariable class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeVariable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TypeVariable class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeVariable(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region TypeVariable<D> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html"/>
    /// </summary>
    /// <typeparam name="D"><see cref="Java.Lang.Reflect.IGenericDeclaration"/></typeparam>
    public partial class TypeVariable<D> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TypeVariable<D>> where D : Java.Lang.Reflect.IGenericDeclaration, new()
    {
        const string _bridgeClassName = "java.lang.reflect.TypeVariable";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TypeVariable class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeVariable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TypeVariable class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeVariable(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region TypeVariable implementation
    public partial class TypeVariable
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable"/> to <see cref="Java.Lang.Reflect.Type"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Type(Java.Lang.Reflect.TypeVariable t) => t.Cast<Java.Lang.Reflect.Type>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.TypeVariable t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html#getGenericDeclaration()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.GenericDeclaration"/></returns>
        public Java.Lang.Reflect.GenericDeclaration GetGenericDeclaration()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.GenericDeclaration>("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html#getBounds()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type[] GetBounds()
        {
            return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getBounds", "()[Ljava/lang/reflect/Type;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html#getName()"/>
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

    #region ITypeVariable<D>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeVariable<D>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region TypeVariable<D> implementation
    public partial class TypeVariable<D> : Java.Lang.Reflect.ITypeVariable<D>, Java.Lang.Reflect.IType, Java.Lang.Reflect.IAnnotatedElement
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable{D}"/> to <see cref="Java.Lang.Reflect.Type"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Type(Java.Lang.Reflect.TypeVariable<D> t) => t.Cast<Java.Lang.Reflect.Type>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable{D}"/> to <see cref="Java.Lang.Reflect.AnnotatedElement"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.AnnotatedElement(Java.Lang.Reflect.TypeVariable<D> t) => t.Cast<Java.Lang.Reflect.AnnotatedElement>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.TypeVariable{D}"/> to <see cref="Java.Lang.Reflect.TypeVariable"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.TypeVariable(Java.Lang.Reflect.TypeVariable<D> t) => t.Cast<Java.Lang.Reflect.TypeVariable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html#getGenericDeclaration()"/>
        /// </summary>
        /// <returns><typeparamref name="D"/></returns>
        public D GetGenericDeclaration()
        {
            return IExecuteWithSignature<D>("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html#getBounds()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type[] GetBounds()
        {
            return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getBounds", "()[Ljava/lang/reflect/Type;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/TypeVariable.html#getName()"/>
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
}