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

namespace Java.Util.Concurrent
{
    #region ConcurrentNavigableMap declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html"/>
    /// </summary>
    public partial class ConcurrentNavigableMap : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConcurrentNavigableMap>
    {
        const string _bridgeClassName = "java.util.concurrent.ConcurrentNavigableMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConcurrentNavigableMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentNavigableMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConcurrentNavigableMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentNavigableMap(params object[] args) : base(args) { }
    
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

    #region ConcurrentNavigableMap<K, V> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class ConcurrentNavigableMap<K, V> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConcurrentNavigableMap<K, V>>
    {
        const string _bridgeClassName = "java.util.concurrent.ConcurrentNavigableMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConcurrentNavigableMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentNavigableMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConcurrentNavigableMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentNavigableMap(params object[] args) : base(args) { }
    
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

    #region ConcurrentNavigableMap implementation
    public partial class ConcurrentNavigableMap
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/> to <see cref="Java.Util.Concurrent.ConcurrentMap"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentMap(Java.Util.Concurrent.ConcurrentNavigableMap t) => t.Cast<Java.Util.Concurrent.ConcurrentMap>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/> to <see cref="Java.Util.NavigableMap"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap(Java.Util.Concurrent.ConcurrentNavigableMap t) => t.Cast<Java.Util.NavigableMap>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#descendingKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet DescendingKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("descendingKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#navigableKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet NavigableKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("navigableKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#descendingMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap DescendingMap()
        {
            return IExecuteWithSignature<Java.Util.NavigableMap>("descendingMap", "()Ljava/util/NavigableMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap HeadMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap SubMap(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap TailMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMap(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IConcurrentNavigableMap<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConcurrentNavigableMap<K, V>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ConcurrentNavigableMap<K, V> implementation
    public partial class ConcurrentNavigableMap<K, V> : Java.Util.Concurrent.IConcurrentNavigableMap<K, V>, Java.Util.Concurrent.IConcurrentMap<K, V>, Java.Util.INavigableMap<K, V>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentNavigableMap{K, V}"/> to <see cref="Java.Util.Concurrent.ConcurrentMap{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentMap<K, V>(Java.Util.Concurrent.ConcurrentNavigableMap<K, V> t) => t.Cast<Java.Util.Concurrent.ConcurrentMap<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentNavigableMap{K, V}"/> to <see cref="Java.Util.NavigableMap{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap<K, V>(Java.Util.Concurrent.ConcurrentNavigableMap<K, V> t) => t.Cast<Java.Util.NavigableMap<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentNavigableMap{K, V}"/> to <see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentNavigableMap(Java.Util.Concurrent.ConcurrentNavigableMap<K, V> t) => t.Cast<Java.Util.Concurrent.ConcurrentNavigableMap>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#descendingKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> DescendingKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<K>>("descendingKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#navigableKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> NavigableKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<K>>("navigableKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#descendingMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap DescendingMap()
        {
            return IExecuteWithSignature<Java.Util.NavigableMap>("descendingMap", "()Ljava/util/NavigableMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap HeadMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap SubMap(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap TailMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMap(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentNavigableMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}