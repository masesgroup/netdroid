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

namespace Android.View
{
    #region LayoutInflater
    public partial class LayoutInflater
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#from(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.View.LayoutInflater"/></returns>
        public static Android.View.LayoutInflater From(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.View.LayoutInflater>(LocalBridgeClazz, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#cloneInContext(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.View.LayoutInflater"/></returns>
        public Android.View.LayoutInflater CloneInContext(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<Android.View.LayoutInflater>("cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#getContext()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Context"/></returns>
        public Android.Content.Context GetContext()
        {
            return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.View.LayoutInflater.Filter"/></returns>
        public Android.View.LayoutInflater.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.View.LayoutInflater.Filter>("getFilter", "()Landroid/view/LayoutInflater$Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#inflate(int,android.view.ViewGroup,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View Inflate(int arg0, Android.View.ViewGroup arg1, bool arg2)
        {
            return IExecute<Android.View.View>("inflate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#inflate(int,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View Inflate(int arg0, Android.View.ViewGroup arg1)
        {
            return IExecute<Android.View.View>("inflate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#inflate(org.xmlpull.v1.XmlPullParser,android.view.ViewGroup,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xmlpull.V1.XmlPullParser"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View Inflate(Org.Xmlpull.V1.XmlPullParser arg0, Android.View.ViewGroup arg1, bool arg2)
        {
            return IExecute<Android.View.View>("inflate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#inflate(org.xmlpull.v1.XmlPullParser,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xmlpull.V1.XmlPullParser"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View Inflate(Org.Xmlpull.V1.XmlPullParser arg0, Android.View.ViewGroup arg1)
        {
            return IExecute<Android.View.View>("inflate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#onCreateView(android.content.Context,android.view.View,java.lang.String,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Util.AttributeSet"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Android.View.View OnCreateView(Android.Content.Context arg0, Android.View.View arg1, Java.Lang.String arg2, Android.Util.AttributeSet arg3)
        {
            return IExecute<Android.View.View>("onCreateView", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#getFactory()"/>
        /// </summary>
        /// <returns><see cref="Android.View.LayoutInflater.Factory"/></returns>
        public Android.View.LayoutInflater.Factory GetFactory()
        {
            return IExecuteWithSignature<Android.View.LayoutInflater.Factory>("getFactory", "()Landroid/view/LayoutInflater$Factory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#getFactory2()"/>
        /// </summary>
        /// <returns><see cref="Android.View.LayoutInflater.Factory2"/></returns>
        public Android.View.LayoutInflater.Factory2 GetFactory2()
        {
            return IExecuteWithSignature<Android.View.LayoutInflater.Factory2>("getFactory2", "()Landroid/view/LayoutInflater$Factory2;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#createView(android.content.Context,java.lang.String,java.lang.String,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Util.AttributeSet"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Android.View.InflateException"/>
        public Android.View.View CreateView(Android.Content.Context arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Util.AttributeSet arg3)
        {
            return IExecute<Android.View.View>("createView", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#createView(java.lang.String,java.lang.String,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Util.AttributeSet"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Android.View.InflateException"/>
        public Android.View.View CreateView(Java.Lang.String arg0, Java.Lang.String arg1, Android.Util.AttributeSet arg2)
        {
            return IExecute<Android.View.View>("createView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#setFactory(android.view.LayoutInflater.Factory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.LayoutInflater.Factory"/></param>
        public void SetFactory(Android.View.LayoutInflater.Factory arg0)
        {
            IExecuteWithSignature("setFactory", "(Landroid/view/LayoutInflater$Factory;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#setFactory2(android.view.LayoutInflater.Factory2)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.LayoutInflater.Factory2"/></param>
        public void SetFactory2(Android.View.LayoutInflater.Factory2 arg0)
        {
            IExecuteWithSignature("setFactory2", "(Landroid/view/LayoutInflater$Factory2;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.html#setFilter(android.view.LayoutInflater.Filter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.LayoutInflater.Filter"/></param>
        public void SetFilter(Android.View.LayoutInflater.Filter arg0)
        {
            IExecuteWithSignature("setFilter", "(Landroid/view/LayoutInflater$Filter;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Factory
        public partial class Factory
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
            /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.Factory.html#onCreateView(java.lang.String,android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Content.Context"/></param>
            /// <param name="arg2"><see cref="Android.Util.AttributeSet"/></param>
            /// <returns><see cref="Android.View.View"/></returns>
            public Android.View.View OnCreateView(Java.Lang.String arg0, Android.Content.Context arg1, Android.Util.AttributeSet arg2)
            {
                return IExecute<Android.View.View>("onCreateView", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Factory2
        public partial class Factory2
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
            /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.Factory2.html#onCreateView(android.view.View,java.lang.String,android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Android.Content.Context"/></param>
            /// <param name="arg3"><see cref="Android.Util.AttributeSet"/></param>
            /// <returns><see cref="Android.View.View"/></returns>
            public Android.View.View OnCreateView(Android.View.View arg0, Java.Lang.String arg1, Android.Content.Context arg2, Android.Util.AttributeSet arg3)
            {
                return IExecute<Android.View.View>("onCreateView", arg0, arg1, arg2, arg3);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Filter
        public partial class Filter
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
            /// <see href="https://developer.android.com/reference/android/view/LayoutInflater.Filter.html#onLoadClass(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool OnLoadClass(Java.Lang.Class arg0)
            {
                return IExecuteWithSignature<bool>("onLoadClass", "(Ljava/lang/Class;)Z", arg0);
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