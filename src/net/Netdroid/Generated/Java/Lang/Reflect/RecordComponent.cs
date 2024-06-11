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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region RecordComponent
    public partial class RecordComponent
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
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAnnotation<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignature<T>("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getDeclaredAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetDeclaredAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getDeclaringRecord()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetDeclaringRecord()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getDeclaringRecord", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getAccessor()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Method"/></returns>
        public Java.Lang.Reflect.Method GetAccessor()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.Method>("getAccessor", "()Ljava/lang/reflect/Method;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getGenericType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type GetGenericType()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.Type>("getGenericType", "()Ljava/lang/reflect/Type;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getGenericSignature()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetGenericSignature()
        {
            return IExecuteWithSignature<Java.Lang.String>("getGenericSignature", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/RecordComponent.html#getName()"/>
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