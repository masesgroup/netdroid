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

using Java.Lang.Annotation;
using Java.Lang.Reflect;
using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    public partial class Class : IGenericDeclaration
    {
        static readonly Java.Lang.ClassLoader _loader = storeLoader();
        static Java.Lang.ClassLoader storeLoader()
        {
            return Java.Lang.ClassLoader.SystemClassLoader;
        }
        /// <summary>
        /// Returns the cached <see cref="Java.Lang.ClassLoader.SystemClassLoader"/>, it is used internally from <see cref="Of{T}"/>
        /// </summary>
        public static Java.Lang.ClassLoader SystemClassLoader => _loader;
        /// <summary>
        /// Returns the <see cref="Class"/> object associated with the class or interface with the given string name.
        /// </summary>
        /// <typeparam name="T">The type implementing <see cref="IJVMBridgeBase"/></typeparam>
        /// <param name="loader">The <see cref="Java.Lang.ClassLoader"/> to be used, default will use <see cref="SystemClassLoader"/></param>
        /// <returns>The <see cref="Class{T}"/> object for the class with the specified name.</returns>
        public static Class<T> Of<T>(Java.Lang.ClassLoader loader = null) where T : IJVMBridgeBase, new()
        {
            return SExecute<Class<T>>("forName", ClassNameOf<T>(), true, loader != null ? loader : SystemClassLoader);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedElement.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        public T GetAnnotation<T>(Class arg0) where T : IAnnotation, new()
        {
            return IExecute<T>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedElement.html#getAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        public T[] GetAnnotationsByType<T>(Class arg0) where T : IAnnotation, new()
        {
            return IExecuteArray<T>("getAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedElement.html#getDeclaredAnnotation(java.lang.Class)"/>
        /// </summary>
        public T GetDeclaredAnnotation<T>(Class arg0) where T : IAnnotation, new()
        {
            return IExecute<T>("getDeclaredAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/AnnotatedElement.html#getDeclaredAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        public T[] GetDeclaredAnnotationsByType<T>(Class arg0) where T : IAnnotation, new()
        {
            return IExecuteArray<T>("getDeclaredAnnotationsByType", arg0);
        }
    }
}
