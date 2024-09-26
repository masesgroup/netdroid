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

namespace Java.Util
{
    #region AbstractList declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/AbstractList.html"/>
    /// </summary>
    public partial class AbstractList : Java.Util.AbstractCollection
    {
        const string _bridgeClassName = "java.util.AbstractList";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractList class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractList() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractList class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractList(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AbstractList<E> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/AbstractList.html"/>
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public partial class AbstractList<E> : Java.Util.AbstractCollection<E>
    {
        const string _bridgeClassName = "java.util.AbstractList";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractList class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractList() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractList class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractList(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region AbstractList implementation
    public partial class AbstractList
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractList"/> to <see cref="Java.Util.List"/>
        /// </summary>
        public static implicit operator Java.Util.List(Java.Util.AbstractList t) => t.Cast<Java.Util.List>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(int arg0)
        {
            return IExecuteWithSignature("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(int arg0, Java.Util.Collection arg1)
        {
            return IExecuteWithSignature<bool>("addAll", "(ILjava/util/Collection;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(int arg0)
        {
            return IExecuteWithSignature("remove", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Set(int arg0, object arg1)
        {
            return IExecuteWithSignature("set", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#lastIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int LastIndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("lastIndexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#subList(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List SubList(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Util.List>("subList", "(II)Ljava/util/List;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#listIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator ListIterator()
        {
            return IExecuteWithSignature<Java.Util.ListIterator>("listIterator", "()Ljava/util/ListIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#listIterator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator ListIterator(int arg0)
        {
            return IExecuteWithSignature<Java.Util.ListIterator>("listIterator", "(I)Ljava/util/ListIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#add(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Add(int arg0, object arg1)
        {
            IExecuteWithSignature("add", "(ILjava/lang/Object;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractList<E> implementation
    public partial class AbstractList<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractList{E}"/> to <see cref="Java.Util.List{E}"/>
        /// </summary>
        public static implicit operator Java.Util.List<E>(Java.Util.AbstractList<E> t) => t.Cast<Java.Util.List<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractList{E}"/> to <see cref="Java.Util.AbstractList"/>
        /// </summary>
        public static implicit operator Java.Util.AbstractList(Java.Util.AbstractList<E> t) => t.Cast<Java.Util.AbstractList>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(int arg0)
        {
            return IExecuteWithSignature<E>("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg1ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg1ExtendsE>(int arg0, Java.Util.Collection<Arg1ExtendsE> arg1) where Arg1ExtendsE : E
        {
            return IExecuteWithSignature<bool>("addAll", "(ILjava/util/Collection;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Remove(int arg0)
        {
            return IExecuteWithSignature<E>("remove", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Set(int arg0, E arg1)
        {
            return IExecuteWithSignature<E>("set", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#lastIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int LastIndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("lastIndexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#subList(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<E> SubList(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Util.List<E>>("subList", "(II)Ljava/util/List;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#listIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator<E> ListIterator()
        {
            return IExecuteWithSignature<Java.Util.ListIterator<E>>("listIterator", "()Ljava/util/ListIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#listIterator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator<E> ListIterator(int arg0)
        {
            return IExecuteWithSignature<Java.Util.ListIterator<E>>("listIterator", "(I)Ljava/util/ListIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/AbstractList.html#add(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Add(int arg0, E arg1)
        {
            IExecuteWithSignature("add", "(ILjava/lang/Object;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}