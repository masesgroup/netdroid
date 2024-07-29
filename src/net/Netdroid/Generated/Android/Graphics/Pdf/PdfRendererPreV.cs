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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics.Pdf
{
    #region PdfRendererPreV
    public partial class PdfRendererPreV
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#%3Cinit%3E(android.os.ParcelFileDescriptor,android.graphics.pdf.LoadParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Pdf.LoadParams"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PdfRendererPreV(Android.Os.ParcelFileDescriptor arg0, Android.Graphics.Pdf.LoadParams arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#%3Cinit%3E(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PdfRendererPreV(Android.Os.ParcelFileDescriptor arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#DOCUMENT_LINEARIZED_TYPE_LINEARIZED"/>
        /// </summary>
        public static int DOCUMENT_LINEARIZED_TYPE_LINEARIZED { get { if (!_DOCUMENT_LINEARIZED_TYPE_LINEARIZEDReady) { _DOCUMENT_LINEARIZED_TYPE_LINEARIZEDContent = SGetField<int>(LocalBridgeClazz, "DOCUMENT_LINEARIZED_TYPE_LINEARIZED"); _DOCUMENT_LINEARIZED_TYPE_LINEARIZEDReady = true; } return _DOCUMENT_LINEARIZED_TYPE_LINEARIZEDContent; } }
        private static int _DOCUMENT_LINEARIZED_TYPE_LINEARIZEDContent = default;
        private static bool _DOCUMENT_LINEARIZED_TYPE_LINEARIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZED"/>
        /// </summary>
        public static int DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZED { get { if (!_DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZEDReady) { _DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZEDContent = SGetField<int>(LocalBridgeClazz, "DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZED"); _DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZEDReady = true; } return _DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZEDContent; } }
        private static int _DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZEDContent = default;
        private static bool _DOCUMENT_LINEARIZED_TYPE_NON_LINEARIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#PDF_FORM_TYPE_ACRO_FORM"/>
        /// </summary>
        public static int PDF_FORM_TYPE_ACRO_FORM { get { if (!_PDF_FORM_TYPE_ACRO_FORMReady) { _PDF_FORM_TYPE_ACRO_FORMContent = SGetField<int>(LocalBridgeClazz, "PDF_FORM_TYPE_ACRO_FORM"); _PDF_FORM_TYPE_ACRO_FORMReady = true; } return _PDF_FORM_TYPE_ACRO_FORMContent; } }
        private static int _PDF_FORM_TYPE_ACRO_FORMContent = default;
        private static bool _PDF_FORM_TYPE_ACRO_FORMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#PDF_FORM_TYPE_NONE"/>
        /// </summary>
        public static int PDF_FORM_TYPE_NONE { get { if (!_PDF_FORM_TYPE_NONEReady) { _PDF_FORM_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "PDF_FORM_TYPE_NONE"); _PDF_FORM_TYPE_NONEReady = true; } return _PDF_FORM_TYPE_NONEContent; } }
        private static int _PDF_FORM_TYPE_NONEContent = default;
        private static bool _PDF_FORM_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#PDF_FORM_TYPE_XFA_FOREGROUND"/>
        /// </summary>
        public static int PDF_FORM_TYPE_XFA_FOREGROUND { get { if (!_PDF_FORM_TYPE_XFA_FOREGROUNDReady) { _PDF_FORM_TYPE_XFA_FOREGROUNDContent = SGetField<int>(LocalBridgeClazz, "PDF_FORM_TYPE_XFA_FOREGROUND"); _PDF_FORM_TYPE_XFA_FOREGROUNDReady = true; } return _PDF_FORM_TYPE_XFA_FOREGROUNDContent; } }
        private static int _PDF_FORM_TYPE_XFA_FOREGROUNDContent = default;
        private static bool _PDF_FORM_TYPE_XFA_FOREGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#PDF_FORM_TYPE_XFA_FULL"/>
        /// </summary>
        public static int PDF_FORM_TYPE_XFA_FULL { get { if (!_PDF_FORM_TYPE_XFA_FULLReady) { _PDF_FORM_TYPE_XFA_FULLContent = SGetField<int>(LocalBridgeClazz, "PDF_FORM_TYPE_XFA_FULL"); _PDF_FORM_TYPE_XFA_FULLReady = true; } return _PDF_FORM_TYPE_XFA_FULLContent; } }
        private static int _PDF_FORM_TYPE_XFA_FULLContent = default;
        private static bool _PDF_FORM_TYPE_XFA_FULLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#openPage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Pdf.PdfRendererPreV.Page"/></returns>
        public Android.Graphics.Pdf.PdfRendererPreV.Page OpenPage(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Pdf.PdfRendererPreV.Page>("openPage", "(I)Landroid/graphics/pdf/PdfRendererPreV$Page;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#getDocumentLinearizationType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDocumentLinearizationType()
        {
            return IExecuteWithSignature<int>("getDocumentLinearizationType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#getPageCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPageCount()
        {
            return IExecuteWithSignature<int>("getPageCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#getPdfFormType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPdfFormType()
        {
            return IExecuteWithSignature<int>("getPdfFormType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.html#write(android.os.ParcelFileDescriptor,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Android.Os.ParcelFileDescriptor arg0, bool arg1)
        {
            IExecute("write", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Page
        public partial class Page
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
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getFormWidgetInfoAtIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.Models.FormWidgetInfo"/></returns>
            public Android.Graphics.Pdf.Models.FormWidgetInfo GetFormWidgetInfoAtIndex(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.Models.FormWidgetInfo>("getFormWidgetInfoAtIndex", "(I)Landroid/graphics/pdf/models/FormWidgetInfo;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getFormWidgetInfoAtPosition(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.Models.FormWidgetInfo"/></returns>
            public Android.Graphics.Pdf.Models.FormWidgetInfo GetFormWidgetInfoAtPosition(int arg0, int arg1)
            {
                return IExecute<Android.Graphics.Pdf.Models.FormWidgetInfo>("getFormWidgetInfoAtPosition", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#selectContent(android.graphics.pdf.models.selection.SelectionBoundary,android.graphics.pdf.models.selection.SelectionBoundary)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Pdf.Models.Selection.SelectionBoundary"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Pdf.Models.Selection.SelectionBoundary"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.Models.Selection.PageSelection"/></returns>
            public Android.Graphics.Pdf.Models.Selection.PageSelection SelectContent(Android.Graphics.Pdf.Models.Selection.SelectionBoundary arg0, Android.Graphics.Pdf.Models.Selection.SelectionBoundary arg1)
            {
                return IExecute<Android.Graphics.Pdf.Models.Selection.PageSelection>("selectContent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getHeight()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetHeight()
            {
                return IExecuteWithSignature<int>("getHeight", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getIndex()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetIndex()
            {
                return IExecuteWithSignature<int>("getIndex", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getWidth()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetWidth()
            {
                return IExecuteWithSignature<int>("getWidth", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getGotoLinks()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Content.PdfPageGotoLinkContent> GetGotoLinks()
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Content.PdfPageGotoLinkContent>>("getGotoLinks", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getImageContents()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Content.PdfPageImageContent> GetImageContents()
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Content.PdfPageImageContent>>("getImageContents", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getLinkContents()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Content.PdfPageLinkContent> GetLinkContents()
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Content.PdfPageLinkContent>>("getLinkContents", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getTextContents()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Content.PdfPageTextContent> GetTextContents()
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Content.PdfPageTextContent>>("getTextContents", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getFormWidgetInfos()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Models.FormWidgetInfo> GetFormWidgetInfos()
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Models.FormWidgetInfo>>("getFormWidgetInfos", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#getFormWidgetInfos(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Models.FormWidgetInfo> GetFormWidgetInfos(int[] arg0)
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Models.FormWidgetInfo>>("getFormWidgetInfos", "([I)Ljava/util/List;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#searchText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Pdf.Models.PageMatchBounds> SearchText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Pdf.Models.PageMatchBounds>>("searchText", "(Ljava/lang/String;)Ljava/util/List;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#applyEdit(android.graphics.pdf.models.FormEditRecord)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Pdf.Models.FormEditRecord"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Android.Graphics.Rect> ApplyEdit(Android.Graphics.Pdf.Models.FormEditRecord arg0)
            {
                return IExecuteWithSignature<Java.Util.List<Android.Graphics.Rect>>("applyEdit", "(Landroid/graphics/pdf/models/FormEditRecord;)Ljava/util/List;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#close()"/>
            /// </summary>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/PdfRendererPreV.Page.html#render(android.graphics.Bitmap,android.graphics.Rect,android.graphics.Matrix,android.graphics.pdf.RenderParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
            /// <param name="arg2"><see cref="Android.Graphics.Matrix"/></param>
            /// <param name="arg3"><see cref="Android.Graphics.Pdf.RenderParams"/></param>
            public void Render(Android.Graphics.Bitmap arg0, Android.Graphics.Rect arg1, Android.Graphics.Matrix arg2, Android.Graphics.Pdf.RenderParams arg3)
            {
                IExecute("render", arg0, arg1, arg2, arg3);
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