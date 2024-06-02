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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region Parameter
    public partial class Parameter
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
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAnnotation<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getDeclaredAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetDeclaredAnnotation<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecute<T>("getDeclaredAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetAnnotationsByType<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteArray<T>("getAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getDeclaredAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetDeclaredAnnotationsByType<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteArray<T>("getDeclaredAnnotationsByType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#isImplicit()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsImplicit()
        {
            return IExecuteWithSignature<bool>("isImplicit", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#isNamePresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamePresent()
        {
            return IExecuteWithSignature<bool>("isNamePresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#isSynthetic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSynthetic()
        {
            return IExecuteWithSignature<bool>("isSynthetic", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#isVarArgs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecuteWithSignature<bool>("isVarArgs", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetModifiers()
        {
            return IExecuteWithSignature<int>("getModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getDeclaredAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetDeclaredAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getDeclaringExecutable()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Executable"/></returns>
        public Java.Lang.Reflect.Executable GetDeclaringExecutable()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.Executable>("getDeclaringExecutable", "()Ljava/lang/reflect/Executable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getParameterizedType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type GetParameterizedType()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.Type>("getParameterizedType", "()Ljava/lang/reflect/Type;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Parameter.html#getName()"/>
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